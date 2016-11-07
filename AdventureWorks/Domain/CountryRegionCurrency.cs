namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The country region currency.
    /// </summary>
    [Table("Sales.CountryRegionCurrency")]
    public class CountryRegionCurrency : Entity
    {
        /// <summary>
        ///     Gets or sets the country region.
        /// </summary>
        public virtual CountryRegion CountryRegion { get; set; }

        /// <summary>
        ///     Gets or sets the country region code.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        /// <summary>
        ///     Gets or sets the currency.
        /// </summary>
        public virtual Currency Currency { get; set; }

        /// <summary>
        ///     Gets or sets the currency code.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}