namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The sales person quota history.
    /// </summary>
    [Table("Sales.SalesPersonQuotaHistory")]
    public class SalesPersonQuotaHistory
    {
        /// <summary>
        /// Gets or sets the business entity id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the quota date.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public DateTime QuotaDate { get; set; }

        /// <summary>
        /// Gets or sets the sales quota.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal SalesQuota { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the sales person.
        /// </summary>
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
