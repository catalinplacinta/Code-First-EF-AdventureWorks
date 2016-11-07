namespace AdventureWorks.Contexts
{
    using System.Data.Entity;
    using System.Diagnostics.CodeAnalysis;

    using AdventureWorks.Domain;
    using AdventureWorks.Initializers;

    /// <summary>
    ///     The adventure works context.
    /// </summary>
    public class AdventureWorksContext : Context
    {
        #region < Constructor >

        /// <summary>
        ///     Initializes a new instance of the <see cref="AdventureWorksContext" /> class.
        /// </summary>
        public AdventureWorksContext()
            : base("AdventureWorks")
        {
            Database.SetInitializer(new AdventureWorksInitializer());
        }

        #endregion

        #region < Properties >

        /// <summary>
        ///     Gets or sets the addresses.
        /// </summary>
        public virtual DbSet<Address> Addresses { get; set; }

        /// <summary>
        ///     Gets or sets the address types.
        /// </summary>
        public virtual DbSet<AddressType> AddressTypes { get; set; }

        /// <summary>
        ///     Gets or sets the bill of materials.
        /// </summary>
        public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; }

        /// <summary>
        ///     Gets or sets the business entities.
        /// </summary>
        public virtual DbSet<BusinessEntity> BusinessEntities { get; set; }

        /// <summary>
        ///     Gets or sets the business entity addresses.
        /// </summary>
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

        /// <summary>
        ///     Gets or sets the business entity contacts.
        /// </summary>
        public virtual DbSet<BusinessEntityContact> BusinessEntityContacts { get; set; }

        /// <summary>
        ///     Gets or sets the contact types.
        /// </summary>
        public virtual DbSet<ContactType> ContactTypes { get; set; }

        /// <summary>
        ///     Gets or sets the country region currencies.
        /// </summary>
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

        /// <summary>
        ///     Gets or sets the country regions.
        /// </summary>
        public virtual DbSet<CountryRegion> CountryRegions { get; set; }

        /// <summary>
        ///     Gets or sets the credit cards.
        /// </summary>
        public virtual DbSet<CreditCard> CreditCards { get; set; }

        /// <summary>
        ///     Gets or sets the cultures.
        /// </summary>
        public virtual DbSet<Culture> Cultures { get; set; }

        /// <summary>
        ///     Gets or sets the currencies.
        /// </summary>
        public virtual DbSet<Currency> Currencies { get; set; }

        /// <summary>
        ///     Gets or sets the currency rates.
        /// </summary>
        public virtual DbSet<CurrencyRate> CurrencyRates { get; set; }

        /// <summary>
        ///     Gets or sets the customers.
        /// </summary>
        public virtual DbSet<Customer> Customers { get; set; }

        /// <summary>
        ///     Gets or sets the departments.
        /// </summary>
        public virtual DbSet<Department> Departments { get; set; }

        /// <summary>
        ///     Gets or sets the email addresses.
        /// </summary>
        public virtual DbSet<EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        ///     Gets or sets the employee department histories.
        /// </summary>
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        /// <summary>
        ///     Gets or sets the employee pay histories.
        /// </summary>
        public virtual DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }

        /// <summary>
        ///     Gets or sets the employees.
        /// </summary>
        public virtual DbSet<Employee> Employees { get; set; }

        /// <summary>
        ///     Gets or sets the illustrations.
        /// </summary>
        public virtual DbSet<Illustration> Illustrations { get; set; }

        /// <summary>
        ///     Gets or sets the job candidates.
        /// </summary>
        public virtual DbSet<JobCandidate> JobCandidates { get; set; }

        /// <summary>
        ///     Gets or sets the locations.
        /// </summary>
        public virtual DbSet<Location> Locations { get; set; }

        /// <summary>
        ///     Gets or sets the passwords.
        /// </summary>
        public virtual DbSet<Password> Passwords { get; set; }

        /// <summary>
        ///     Gets or sets the people.
        /// </summary>
        public virtual DbSet<Person> People { get; set; }

        /// <summary>
        ///     Gets or sets the person credit cards.
        /// </summary>
        public virtual DbSet<PersonCreditCard> PersonCreditCards { get; set; }

        /// <summary>
        ///     Gets or sets the person phones.
        /// </summary>
        public virtual DbSet<PersonPhone> PersonPhones { get; set; }

        /// <summary>
        ///     Gets or sets the phone number types.
        /// </summary>
        public virtual DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

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
        ///     Gets or sets the sales order details.
        /// </summary>
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }

        /// <summary>
        ///     Gets or sets the sales order headers.
        /// </summary>
        public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        ///     Gets or sets the sales order header sales reasons.
        /// </summary>
        public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        /// <summary>
        ///     Gets or sets the sales person quota histories.
        /// </summary>
        public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

        /// <summary>
        ///     Gets or sets the sales persons.
        /// </summary>
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }

        /// <summary>
        ///     Gets or sets the sales reasons.
        /// </summary>
        public virtual DbSet<SalesReason> SalesReasons { get; set; }

        /// <summary>
        ///     Gets or sets the sales tax rates.
        /// </summary>
        public virtual DbSet<SalesTaxRate> SalesTaxRates { get; set; }

        /// <summary>
        ///     Gets or sets the sales territories.
        /// </summary>
        public virtual DbSet<SalesTerritory> SalesTerritories { get; set; }

        /// <summary>
        ///     Gets or sets the sales territory histories.
        /// </summary>
        public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        /// <summary>
        ///     Gets or sets the scrap reasons.
        /// </summary>
        public virtual DbSet<ScrapReason> ScrapReasons { get; set; }

        /// <summary>
        ///     Gets or sets the shifts.
        /// </summary>
        public virtual DbSet<Shift> Shifts { get; set; }

        /// <summary>
        ///     Gets or sets the ship methods.
        /// </summary>
        public virtual DbSet<ShipMethod> ShipMethods { get; set; }

        /// <summary>
        ///     Gets or sets the shopping cart items.
        /// </summary>
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        /// <summary>
        ///     Gets or sets the special offer products.
        /// </summary>
        public virtual DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }

        /// <summary>
        ///     Gets or sets the special offers.
        /// </summary>
        public virtual DbSet<SpecialOffer> SpecialOffers { get; set; }

        /// <summary>
        ///     Gets or sets the state provinces.
        /// </summary>
        public virtual DbSet<StateProvince> StateProvinces { get; set; }

        /// <summary>
        ///     Gets or sets the stores.
        /// </summary>
        public virtual DbSet<Store> Stores { get; set; }

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
        ///     Gets or sets the vendors.
        /// </summary>
        public virtual DbSet<Vendor> Vendors { get; set; }

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
            modelBuilder.Entity<Department>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>().Property(e => e.MaritalStatus).IsFixedLength();

            modelBuilder.Entity<Employee>().Property(e => e.Gender).IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeePayHistories)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>().HasOptional(e => e.SalesPerson).WithRequired(e => e.Employee);

            modelBuilder.Entity<EmployeePayHistory>().Property(e => e.Rate).HasPrecision(19, 4);

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Shift)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.BillToAddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.SalesOrderHeaders1)
                .WithRequired(e => e.Address1)
                .HasForeignKey(e => e.ShipToAddressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AddressType>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithRequired(e => e.AddressType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityAddresses)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessEntity>().HasOptional(e => e.Person).WithRequired(e => e.BusinessEntity);

            modelBuilder.Entity<BusinessEntity>().HasOptional(e => e.Store).WithRequired(e => e.BusinessEntity);

            modelBuilder.Entity<BusinessEntity>().HasOptional(e => e.Vendor).WithRequired(e => e.BusinessEntity);

            modelBuilder.Entity<ContactType>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithRequired(e => e.ContactType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.CountryRegionCurrencies)
                .WithRequired(e => e.CountryRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.SalesTerritories)
                .WithRequired(e => e.CountryRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryRegion>()
                .HasMany(e => e.StateProvinces)
                .WithRequired(e => e.CountryRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Password>().Property(e => e.PasswordHash).IsUnicode(false);

            modelBuilder.Entity<Password>().Property(e => e.PasswordSalt).IsUnicode(false);

            modelBuilder.Entity<Person>().Property(e => e.PersonType).IsFixedLength();

            modelBuilder.Entity<Person>().HasOptional(e => e.Employee).WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.BusinessEntityContacts)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.EmailAddresses)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>().HasOptional(e => e.Password).WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.PersonID);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonCreditCards)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PersonPhones)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhoneNumberType>()
                .HasMany(e => e.PersonPhones)
                .WithRequired(e => e.PhoneNumberType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StateProvince>().Property(e => e.StateProvinceCode).IsFixedLength();

            modelBuilder.Entity<StateProvince>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.StateProvince)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StateProvince>()
                .HasMany(e => e.SalesTaxRates)
                .WithRequired(e => e.StateProvince)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<CountryRegionCurrency>().Property(e => e.CurrencyCode).IsFixedLength();

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.PersonCreditCards)
                .WithRequired(e => e.CreditCard)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>().Property(e => e.CurrencyCode).IsFixedLength();

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CountryRegionCurrencies)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CurrencyRates)
                .WithRequired(e => e.Currency)
                .HasForeignKey(e => e.FromCurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CurrencyRates1)
                .WithRequired(e => e.Currency1)
                .HasForeignKey(e => e.ToCurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CurrencyRate>().Property(e => e.FromCurrencyCode).IsFixedLength();

            modelBuilder.Entity<CurrencyRate>().Property(e => e.ToCurrencyCode).IsFixedLength();

            modelBuilder.Entity<CurrencyRate>().Property(e => e.AverageRate).HasPrecision(19, 4);

            modelBuilder.Entity<CurrencyRate>().Property(e => e.EndOfDayRate).HasPrecision(19, 4);

            modelBuilder.Entity<Customer>().Property(e => e.AccountNumber).IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderDetail>().Property(e => e.UnitPrice).HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail>().Property(e => e.UnitPriceDiscount).HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderDetail>().Property(e => e.LineTotal).HasPrecision(38, 6);

            modelBuilder.Entity<SalesOrderHeader>().Property(e => e.CreditCardApprovalCode).IsUnicode(false);

            modelBuilder.Entity<SalesOrderHeader>().Property(e => e.SubTotal).HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>().Property(e => e.TaxAmt).HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>().Property(e => e.Freight).HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrderHeader>().Property(e => e.TotalDue).HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>().Property(e => e.SalesQuota).HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>().Property(e => e.Bonus).HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>().Property(e => e.CommissionPct).HasPrecision(10, 4);

            modelBuilder.Entity<SalesPerson>().Property(e => e.SalesYTD).HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>().Property(e => e.SalesLastYear).HasPrecision(19, 4);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesOrderHeaders)
                .WithOptional(e => e.SalesPerson)
                .HasForeignKey(e => e.SalesPersonID);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesPersonQuotaHistories)
                .WithRequired(e => e.SalesPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.SalesTerritoryHistories)
                .WithRequired(e => e.SalesPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.SalesPerson)
                .HasForeignKey(e => e.SalesPersonID);

            modelBuilder.Entity<SalesPersonQuotaHistory>().Property(e => e.SalesQuota).HasPrecision(19, 4);

            modelBuilder.Entity<SalesReason>()
                .HasMany(e => e.SalesOrderHeaderSalesReasons)
                .WithRequired(e => e.SalesReason)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTaxRate>().Property(e => e.TaxRate).HasPrecision(10, 4);

            modelBuilder.Entity<SalesTerritory>().Property(e => e.SalesYTD).HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>().Property(e => e.SalesLastYear).HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>().Property(e => e.CostYTD).HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>().Property(e => e.CostLastYear).HasPrecision(19, 4);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.StateProvinces)
                .WithRequired(e => e.SalesTerritory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTerritory>()
                .HasMany(e => e.SalesTerritoryHistories)
                .WithRequired(e => e.SalesTerritory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOffer>().Property(e => e.DiscountPct).HasPrecision(10, 4);

            modelBuilder.Entity<SpecialOffer>()
                .HasMany(e => e.SpecialOfferProducts)
                .WithRequired(e => e.SpecialOffer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialOfferProduct>()
                .HasMany(e => e.SalesOrderDetails)
                .WithRequired(e => e.SpecialOfferProduct)
                .HasForeignKey(e => new { e.SpecialOfferID, e.ProductID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.StoreID);
        }

        #endregion
    }
}