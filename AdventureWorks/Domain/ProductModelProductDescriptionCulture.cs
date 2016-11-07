namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The product model product description culture.
    /// </summary>
    [Table("Production.ProductModelProductDescriptionCulture")]
    public class ProductModelProductDescriptionCulture : Entity
    {
        /// <summary>
        ///     Gets or sets the culture.
        /// </summary>
        public virtual Culture Culture { get; set; }

        /// <summary>
        ///     Gets or sets the culture id.
        /// </summary>
        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string CultureID { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the product description.
        /// </summary>
        public virtual ProductDescription ProductDescription { get; set; }

        /// <summary>
        ///     Gets or sets the product description id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductDescriptionID { get; set; }

        /// <summary>
        ///     Gets or sets the product model.
        /// </summary>
        public virtual ProductModel ProductModel { get; set; }

        /// <summary>
        ///     Gets or sets the product model id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductModelID { get; set; }
    }
}