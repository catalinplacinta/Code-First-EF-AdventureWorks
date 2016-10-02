namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The currency rate.
    /// </summary>
    [Table("Sales.CurrencyRate")]
    public class CurrencyRate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyRate"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CurrencyRate()
        {
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Gets or sets the currency rate id.
        /// </summary>
        public int CurrencyRateID { get; set; }

        /// <summary>
        /// Gets or sets the currency rate date.
        /// </summary>
        public DateTime CurrencyRateDate { get; set; }

        /// <summary>
        /// Gets or sets the from currency code.
        /// </summary>
        [Required]
        [StringLength(3)]
        public string FromCurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the to currency code.
        /// </summary>
        [Required]
        [StringLength(3)]
        public string ToCurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the average rate.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal AverageRate { get; set; }

        /// <summary>
        /// Gets or sets the end of day rate.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal EndOfDayRate { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public virtual Currency Currency { get; set; }

        /// <summary>
        /// Gets or sets the currency 1.
        /// </summary>
        public virtual Currency Currency1 { get; set; }

        /// <summary>
        /// Gets or sets the sales order headers.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
