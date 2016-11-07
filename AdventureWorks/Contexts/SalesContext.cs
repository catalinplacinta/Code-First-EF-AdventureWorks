namespace AdventureWorks.Contexts
{
    using System.Data.Entity;

    using AdventureWorks.Domain;
    using AdventureWorks.Initializers;

    /// <summary>
    ///     The sales context.
    /// </summary>
    public class SalesContext : Context
    {
        #region < Constructors >

        /// <summary>
        ///     Initializes a new instance of the <see cref="SalesContext" /> class.
        /// </summary>
        public SalesContext()
            : base("AdventureWorks")
        {
            Database.SetInitializer(new SalesInitializer());
        }

        #endregion

        #region < Properties >

        /// <summary>
        ///     Gets or sets the country region currencies.
        /// </summary>
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

        /// <summary>
        ///     Gets or sets the credit cards.
        /// </summary>
        public virtual DbSet<CreditCard> CreditCards { get; set; }

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
        ///     Gets or sets the person credit cards.
        /// </summary>
        public virtual DbSet<PersonCreditCard> PersonCreditCards { get; set; }

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
        ///     Gets or sets the stores.
        /// </summary>
        public virtual DbSet<Store> Stores { get; set; }

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