namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The country region.
    /// </summary>
    [Table("Person.CountryRegion")]
    public class CountryRegion : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CountryRegion" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public CountryRegion()
        {
            this.CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            this.SalesTerritories = new HashSet<SalesTerritory>();
            this.StateProvinces = new HashSet<StateProvince>();
        }

        /// <summary>
        ///     Gets or sets the country region code.
        /// </summary>
        [Key]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        /// <summary>
        ///     Gets or sets the country region currencies.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the sales territories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }

        /// <summary>
        ///     Gets or sets the state provinces.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
    }
}