namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The purchase order detail.
    /// </summary>
    [Table("Purchasing.PurchaseOrderDetail")]
    public class PurchaseOrderDetail : Entity
    {
        /// <summary>
        ///     Gets or sets the due date.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        ///     Gets or sets the line total.
        /// </summary>
        /// [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "money")]
        public decimal LineTotal { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the order qty.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public short OrderQty { get; set; }

        /// <summary>
        ///     Gets or sets the product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        ///     Gets or sets the product id.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        ///     Gets or sets the purchase order detail id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public int PurchaseOrderDetailID { get; set; }

        /// <summary>
        ///     Gets or sets the purchase order header.
        /// </summary>
        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }

        /// <summary>
        ///     Gets or sets the purchase order id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseOrderID { get; set; }

        /// <summary>
        ///     Gets or sets the received qty.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public decimal ReceivedQty { get; set; }

        /// <summary>
        ///     Gets or sets the rejected qty.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public decimal RejectedQty { get; set; }

        /// <summary>
        ///     Gets or sets the stocked qty.
        /// </summary>
        /// [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public decimal StockedQty { get; set; }

        /// <summary>
        ///     Gets or sets the unit price.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
    }
}