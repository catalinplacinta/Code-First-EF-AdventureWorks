namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The currency.
    /// </summary>
    [Table("Sales.Currency")]
    public class Currency : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public Currency()
        {
            this.CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            this.CurrencyRates = new HashSet<CurrencyRate>();
            this.CurrencyRates1 = new HashSet<CurrencyRate>();
        }

        /// <summary>
        ///     Gets or sets the country region currencies.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

        /// <summary>
        ///     Gets or sets the currency code.
        /// </summary>
        [Key]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        ///     Gets or sets the currency rates.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<CurrencyRate> CurrencyRates { get; set; }

        /// <summary>
        ///     Gets or sets the currency rates 1.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<CurrencyRate> CurrencyRates1 { get; set; }

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
    }
}