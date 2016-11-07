namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The product inventory.
    /// </summary>
    [Table("Production.ProductInventory")]
    public class ProductInventory : Entity
    {
        /// <summary>
        ///     Gets or sets the bin.
        /// </summary>
        public byte Bin { get; set; }

        /// <summary>
        ///     Gets or sets the location.
        /// </summary>
        public virtual Location Location { get; set; }

        /// <summary>
        ///     Gets or sets the location id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LocationID { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        ///     Gets or sets the product id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        /// <summary>
        ///     Gets or sets the quantity.
        /// </summary>
        public short Quantity { get; set; }

        /// <summary>
        ///     Gets or sets the shelf.
        /// </summary>
        [Required]
        [StringLength(10)]
        public string Shelf { get; set; }
    }
}