namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The product model illustration.
    /// </summary>
    [Table("Production.ProductModelIllustration")]
    public class ProductModelIllustration : Entity
    {
        /// <summary>
        ///     Gets or sets the illustration.
        /// </summary>
        public virtual Illustration Illustration { get; set; }

        /// <summary>
        ///     Gets or sets the illustration id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IllustrationID { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

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