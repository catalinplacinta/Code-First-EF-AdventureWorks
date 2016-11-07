namespace AdventureWorks.Contexts
{
    using System.Data.Entity;

    using AdventureWorks.Domain;
    using AdventureWorks.Initializers;

    /// <summary>
    ///     The purchasing context.
    /// </summary>
    public class PurchasingContext : Context
    {
        #region < Constructors >

        /// <summary>
        ///     Initializes a new instance of the <see cref="PurchasingContext" /> class.
        /// </summary>
        public PurchasingContext()
            : base("AdventureWorks")
        {
            Database.SetInitializer(new PurchasingInitializer());
        }

        #endregion

        #region < Propertie >

        /// <summary>
        ///     Gets or sets the product vendors.
        /// </summary>
        public virtual DbSet<ProductVendor> ProductVendors { get; set; }

        /// <summary>
        ///     Gets or sets the purchase order details.
        /// </summary>
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        /// <summary>
        ///     Gets or sets the purchase order headers.
        /// </summary>
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        /// <summary>
        ///     Gets or sets the ship methods.
        /// </summary>
        public virtual DbSet<ShipMethod> ShipMethods { get; set; }

        /// <summary>
        ///     Gets or sets the vendors.
        /// </summary>
        public virtual DbSet<Vendor> Vendors { get; set; }

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
            modelBuilder.Entity<ProductVendor>().Property(e => e.StandardPrice).HasPrecision(19, 4);

            modelBuilder.Entity<ProductVendor>().Property(e => e.LastReceiptCost).HasPrecision(19, 4);

            modelBuilder.Entity<ProductVendor>().Property(e => e.UnitMeasureCode).IsFixedLength();

            modelBuilder.Entity<PurchaseOrderDetail>().Property(e => e.UnitPrice).HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderDetail>().Property(e => e.LineTotal).HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderDetail>().Property(e => e.ReceivedQty).HasPrecision(8, 2);

            modelBuilder.Entity<PurchaseOrderDetail>().Property(e => e.RejectedQty).HasPrecision(8, 2);

            modelBuilder.Entity<PurchaseOrderDetail>().Property(e => e.StockedQty).HasPrecision(9, 2);

            modelBuilder.Entity<PurchaseOrderHeader>().Property(e => e.SubTotal).HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>().Property(e => e.TaxAmt).HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>().Property(e => e.Freight).HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>().Property(e => e.TotalDue).HasPrecision(19, 4);

            modelBuilder.Entity<PurchaseOrderHeader>()
                .HasMany(e => e.PurchaseOrderDetails)
                .WithRequired(e => e.PurchaseOrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipMethod>().Property(e => e.ShipBase).HasPrecision(19, 4);

            modelBuilder.Entity<ShipMethod>().Property(e => e.ShipRate).HasPrecision(19, 4);

            modelBuilder.Entity<ShipMethod>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithRequired(e => e.ShipMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipMethod>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithRequired(e => e.ShipMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.ProductVendors)
                .WithRequired(e => e.Vendor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => e.VendorID)
                .WillCascadeOnDelete(false);
        }

        #endregion
    }
}