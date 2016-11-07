namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The product review.
    /// </summary>
    [Table("Production.ProductReview")]
    public class ProductReview : Entity
    {
        /// <summary>
        ///     Gets or sets the comments.
        /// </summary>
        [StringLength(3850)]
        public string Comments { get; set; }

        /// <summary>
        ///     Gets or sets the email address.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }

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
        public int ProductID { get; set; }

        /// <summary>
        ///     Gets or sets the product review id.
        /// </summary>
        public int ProductReviewID { get; set; }

        /// <summary>
        ///     Gets or sets the rating.
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        ///     Gets or sets the review date.
        /// </summary>
        public DateTime ReviewDate { get; set; }

        /// <summary>
        ///     Gets or sets the reviewer name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string ReviewerName { get; set; }
    }
}