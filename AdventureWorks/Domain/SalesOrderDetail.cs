namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The sales order detail.
    /// </summary>
    [Table("Sales.SalesOrderDetail")]
    public class SalesOrderDetail
    {
        /// <summary>
        /// Gets or sets the sales order id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesOrderID { get; set; }

        /// <summary>
        /// Gets or sets the sales order detail id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public int SalesOrderDetailID { get; set; }

        /// <summary>
        /// Gets or sets the carrier tracking number.
        /// </summary>
        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        /// <summary>
        /// Gets or sets the order qty.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public short OrderQty { get; set; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the special offer id.
        /// </summary>
        public int SpecialOfferID { get; set; }

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the unit price discount.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }

        /// <summary>
        /// Gets or sets the line total.
        /// </summary>
        [Column(TypeName = "numeric")]

        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal LineTotal { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the sales order header.
        /// </summary>
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

        /// <summary>
        /// Gets or sets the special offer product.
        /// </summary>
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }
    }
}
