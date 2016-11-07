namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The product photo.
    /// </summary>
    [Table("Production.ProductPhoto")]
    public class ProductPhoto : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProductPhoto" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public ProductPhoto()
        {
            this.ProductProductPhotoes = new HashSet<ProductProductPhoto>();
        }

        /// <summary>
        ///     Gets or sets the large photo.
        /// </summary>
        public byte[] LargePhoto { get; set; }

        /// <summary>
        ///     Gets or sets the large photo file name.
        /// </summary>
        [StringLength(50)]
        public string LargePhotoFileName { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the product photo id.
        /// </summary>
        public int ProductPhotoID { get; set; }

        /// <summary>
        ///     Gets or sets the product product photoes.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; }

        /// <summary>
        ///     Gets or sets the thumb nail photo.
        /// </summary>
        public byte[] ThumbNailPhoto { get; set; }

        /// <summary>
        ///     Gets or sets the thumbnail photo file name.
        /// </summary>
        [StringLength(50)]
        public string ThumbnailPhotoFileName { get; set; }
    }
}