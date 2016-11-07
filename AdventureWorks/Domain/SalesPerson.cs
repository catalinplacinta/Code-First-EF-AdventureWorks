namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The sales person.
    /// </summary>
    [Table("Sales.SalesPerson")]
    public class SalesPerson : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SalesPerson" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public SalesPerson()
        {
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            this.SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
            this.SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            this.Stores = new HashSet<Store>();
        }

        /// <summary>
        ///     Gets or sets the bonus.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal Bonus { get; set; }

        /// <summary>
        ///     Gets or sets the business entity id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        ///     Gets or sets the commission pct.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        [Column(TypeName = "smallmoney")]
        public decimal CommissionPct { get; set; }

        /// <summary>
        ///     Gets or sets the employee.
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the sales last year.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal SalesLastYear { get; set; }

        /// <summary>
        ///     Gets or sets the sales order headers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        ///     Gets or sets the sales person quota histories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

        /// <summary>
        ///     Gets or sets the sales quota.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? SalesQuota { get; set; }

        /// <summary>
        ///     Gets or sets the sales territory.
        /// </summary>
        public virtual SalesTerritory SalesTerritory { get; set; }

        /// <summary>
        ///     Gets or sets the sales territory histories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        /// <summary>
        ///     Gets or sets the sales ytd.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        [Column(TypeName = "money")]
        public decimal SalesYTD { get; set; }

        /// <summary>
        ///     Gets or sets the stores.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<Store> Stores { get; set; }

        /// <summary>
        ///     Gets or sets the territory id.
        /// </summary>
        public int? TerritoryID { get; set; }
    }
}