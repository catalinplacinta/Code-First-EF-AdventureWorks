namespace AdventureWorks.Contexts
{
    using System.Data.Entity;

    using AdventureWorks.Domain;
    using AdventureWorks.Initializers;

    /// <summary>
    ///     The person context.
    /// </summary>
    public class PersonContext : Context
    {
        #region < Constructor >

        /// <summary>
        ///     Initializes a new instance of the <see cref="PersonContext" /> class.
        /// </summary>
        public PersonContext()
            : base("AdventureWorks")
        {
            Database.SetInitializer(new PersonInitializer());
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
        ///     Gets or sets the country regions.
        /// </summary>
        public virtual DbSet<CountryRegion> CountryRegions { get; set; }

        /// <summary>
        ///     Gets or sets the email addresses.
        /// </summary>
        public virtual DbSet<EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        ///     Gets or sets the passwords.
        /// </summary>
        public virtual DbSet<Password> Passwords { get; set; }

        /// <summary>
        ///     Gets or sets the people.
        /// </summary>
        public virtual DbSet<Person> People { get; set; }

        /// <summary>
        ///     Gets or sets the person phones.
        /// </summary>
        public virtual DbSet<PersonPhone> PersonPhones { get; set; }

        /// <summary>
        ///     Gets or sets the phone number types.
        /// </summary>
        public virtual DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

        /// <summary>
        ///     Gets or sets the state provinces.
        /// </summary>
        public virtual DbSet<StateProvince> StateProvinces { get; set; }

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
        }

        #endregion
    }
}