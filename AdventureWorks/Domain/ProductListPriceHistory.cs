namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The product list price history.
    /// </summary>
    [Table("Production.ProductListPriceHistory")]
    public class ProductListPriceHistory
    {
        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the list price.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public virtual Product Product { get; set; }
    }
}
