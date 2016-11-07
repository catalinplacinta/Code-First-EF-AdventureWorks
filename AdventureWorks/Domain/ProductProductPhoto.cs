namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The product product photo.
    /// </summary>
    [Table("Production.ProductProductPhoto")]
    public class ProductProductPhoto : Entity
    {
        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether primary.
        /// </summary>
        public bool Primary { get; set; }

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
        ///     Gets or sets the product photo.
        /// </summary>
        public virtual ProductPhoto ProductPhoto { get; set; }

        /// <summary>
        ///     Gets or sets the product photo id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductPhotoID { get; set; }
    }
}