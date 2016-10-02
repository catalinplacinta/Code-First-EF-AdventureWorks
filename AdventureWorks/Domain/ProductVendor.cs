namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The product vendor.
    /// </summary>
    [Table("Purchasing.ProductVendor")]
    public class ProductVendor
    {
        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the business entity id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the average lead time.
        /// </summary>
        public int AverageLeadTime { get; set; }

        /// <summary>
        /// Gets or sets the standard price.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal StandardPrice { get; set; }

        /// <summary>
        /// Gets or sets the last receipt cost.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? LastReceiptCost { get; set; }

        /// <summary>
        /// Gets or sets the last receipt date.
        /// </summary>
        public DateTime? LastReceiptDate { get; set; }

        /// <summary>
        /// Gets or sets the min order qty.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public int MinOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the max order qty.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public int MaxOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the on order qty.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public int? OnOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the unit measure code.
        /// </summary>
        [Required]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets the unit measure.
        /// </summary>
        public virtual UnitMeasure UnitMeasure { get; set; }

        /// <summary>
        /// Gets or sets the vendor.
        /// </summary>
        public virtual Vendor Vendor { get; set; }
    }
}
