namespace AdventureWorks.Contexts
{
    using System.Data.Entity;
    using System.Diagnostics.CodeAnalysis;

    using AdventureWorks.Domain;
    using AdventureWorks.Initializers;

    /// <summary>
    ///     The production context.
    /// </summary>
    public class ProductionContext : Context
    {
        #region < Constructors >

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProductionContext" /> class.
        /// </summary>
        public ProductionContext()
            : base("AdventureWorks")
        {
            Database.SetInitializer(new ProductionInitializer());
        }

        #endregion

        #region < Properties >

        /// <summary>
        ///     Gets or sets the bill of materials.
        /// </summary>
        public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; }

        /// <summary>
        ///     Gets or sets the cultures.
        /// </summary>
        public virtual DbSet<Culture> Cultures { get; set; }

        /// <summary>
        ///     Gets or sets the illustrations.
        /// </summary>
        public virtual DbSet<Illustration> Illustrations { get; set; }

        /// <summary>
        ///     Gets or sets the locations.
        /// </summary>
        public virtual DbSet<Location> Locations { get; set; }

        /// <summary>
        ///     Gets or sets the product categories.
        /// </summary>
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }

        /// <summary>
        ///     Gets or sets the product cost histories.
        /// </summary>
        public virtual DbSet<ProductCostHistory> ProductCostHistories { get; set; }

        /// <summary>
        ///     Gets or sets the product descriptions.
        /// </summary>
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }

        /// <summary>
        ///     Gets or sets the product documents.
        /// </summary>
        public virtual DbSet<ProductDocument> ProductDocuments { get; set; }

        /// <summary>
        ///     Gets or sets the product inventories.
        /// </summary>
        public virtual DbSet<ProductInventory> ProductInventories { get; set; }

        /// <summary>
        ///     Gets or sets the product list price histories.
        /// </summary>
        public virtual DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }

        /// <summary>
        ///     Gets or sets the product model illustrations.
        /// </summary>
        public virtual DbSet<ProductModelIllustration> ProductModelIllustrations { get; set; }

        /// <summary>
        ///     Gets or sets the product model product description cultures.
        /// </summary>
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

        /// <summary>
        ///     Gets or sets the product models.
        /// </summary>
        public virtual DbSet<ProductModel> ProductModels { get; set; }

        /// <summary>
        ///     Gets or sets the product photoes.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual DbSet<ProductPhoto> ProductPhotoes { get; set; }

        /// <summary>
        ///     Gets or sets the product product photoes.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual DbSet<ProductProductPhoto> ProductProductPhotoes { get; set; }

        /// <summary>
        ///     Gets or sets the product reviews.
        /// </summary>
        public virtual DbSet<ProductReview> ProductReviews { get; set; }

        /// <summary>
        ///     Gets or sets the products.
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }

        /// <summary>
        ///     Gets or sets the product subcategories.
        /// </summary>
        public virtual DbSet<ProductSubcategory> ProductSubcategories { get; set; }

        /// <summary>
        ///     Gets or sets the scrap reasons.
        /// </summary>
        public virtual DbSet<ScrapReason> ScrapReasons { get; set; }

        /// <summary>
        ///     Gets or sets the transaction histories.
        /// </summary>
        public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }

        /// <summary>
        ///     Gets or sets the transaction history archives.
        /// </summary>
        public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }

        /// <summary>
        ///     Gets or sets the unit measures.
        /// </summary>
        public virtual DbSet<UnitMeasure> UnitMeasures { get; set; }

        /// <summary>
        ///     Gets or sets the work order routings.
        /// </summary>
        public virtual DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }

        /// <summary>
        ///     Gets or sets the work orders.
        /// </summary>
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }

        #endregion

        #region < Methods >

        /// <summary>
        ///     The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        ///     The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillOfMaterial>().Property(e => e.UnitMeasureCode).IsFixedLength();

            modelBuilder.Entity<BillOfMaterial>().Property(e => e.PerAssemblyQty).HasPrecision(8, 2);

            modelBuilder.Entity<Culture>().Property(e => e.CultureID).IsFixedLength();

            modelBuilder.Entity<Culture>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithRequired(e => e.Culture)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Illustration>()
                .HasMany(e => e.ProductModelIllustrations)
                .WithRequired(e => e.Illustration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>().Property(e => e.CostRate).HasPrecision(10, 4);

            modelBuilder.Entity<Location>().Property(e => e.Availability).HasPrecision(8, 2);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ProductInventories)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.WorkOrderRoutings)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>().Property(e => e.StandardCost).HasPrecision(19, 4);

            modelBuilder.Entity<Product>().Property(e => e.ListPrice).HasPrecision(19, 4);

            modelBuilder.Entity<Product>().Property(e => e.SizeUnitMeasureCode).IsFixedLength();

            modelBuilder.Entity<Product>().Property(e => e.WeightUnitMeasureCode).IsFixedLength();

            modelBuilder.Entity<Product>().Property(e => e.Weight).HasPrecision(8, 2);

            modelBuilder.Entity<Product>().Property(e => e.ProductLine).IsFixedLength();

            modelBuilder.Entity<Product>().Property(e => e.Class).IsFixedLength();

            modelBuilder.Entity<Product>().Property(e => e.Style).IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BillOfMaterials)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ComponentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BillOfMaterials1)
                .WithOptional(e => e.Product1)
                .HasForeignKey(e => e.ProductAssemblyID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductCostHistories)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>().HasOptional(e => e.ProductDocument).WithRequired(e => e.Product);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductInventories)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductListPriceHistories)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductProductPhotoes)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductReviews)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductVendors)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PurchaseOrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ShoppingCartItems)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SpecialOfferProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.TransactionHistories)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.WorkOrders)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.ProductSubcategories)
                .WithRequired(e => e.ProductCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductCostHistory>().Property(e => e.StandardCost).HasPrecision(19, 4);

            modelBuilder.Entity<ProductDescription>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithRequired(e => e.ProductDescription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductListPriceHistory>().Property(e => e.ListPrice).HasPrecision(19, 4);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.ProductModelIllustrations)
                .WithRequired(e => e.ProductModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.ProductModelProductDescriptionCultures)
                .WithRequired(e => e.ProductModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductModelProductDescriptionCulture>().Property(e => e.CultureID).IsFixedLength();

            modelBuilder.Entity<ProductPhoto>()
                .HasMany(e => e.ProductProductPhotoes)
                .WithRequired(e => e.ProductPhoto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionHistory>().Property(e => e.TransactionType).IsFixedLength();

            modelBuilder.Entity<TransactionHistory>().Property(e => e.ActualCost).HasPrecision(19, 4);

            modelBuilder.Entity<TransactionHistoryArchive>().Property(e => e.TransactionType).IsFixedLength();

            modelBuilder.Entity<TransactionHistoryArchive>().Property(e => e.ActualCost).HasPrecision(19, 4);

            modelBuilder.Entity<UnitMeasure>().Property(e => e.UnitMeasureCode).IsFixedLength();

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.BillOfMaterials)
                .WithRequired(e => e.UnitMeasure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.UnitMeasure)
                .HasForeignKey(e => e.SizeUnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.Products1)
                .WithOptional(e => e.UnitMeasure1)
                .HasForeignKey(e => e.WeightUnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(e => e.ProductVendors)
                .WithRequired(e => e.UnitMeasure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkOrder>()
                .HasMany(e => e.WorkOrderRoutings)
                .WithRequired(e => e.WorkOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkOrderRouting>().Property(e => e.ActualResourceHrs).HasPrecision(9, 4);

            modelBuilder.Entity<WorkOrderRouting>().Property(e => e.PlannedCost).HasPrecision(19, 4);

            modelBuilder.Entity<WorkOrderRouting>().Property(e => e.ActualCost).HasPrecision(19, 4);
        }

        #endregion
    }
}