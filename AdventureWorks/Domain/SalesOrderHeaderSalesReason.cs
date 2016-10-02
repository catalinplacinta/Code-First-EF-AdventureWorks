namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The sales order header sales reason.
    /// </summary>
    [Table("Sales.SalesOrderHeaderSalesReason")]
    public class SalesOrderHeaderSalesReason
    {
        /// <summary>
        /// Gets or sets the sales order id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesOrderID { get; set; }

        /// <summary>
        /// Gets or sets the sales reason id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesReasonID { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the sales order header.
        /// </summary>
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

        /// <summary>
        /// Gets or sets the sales reason.
        /// </summary>
        public virtual SalesReason SalesReason { get; set; }
    }
}
