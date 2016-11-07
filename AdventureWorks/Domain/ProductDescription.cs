namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The product description.
    /// </summary>
    [Table("Production.ProductDescription")]
    public class ProductDescription : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProductDescription" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public ProductDescription()
        {
            this.ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        [Required]
        [StringLength(400)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the product description id.
        /// </summary>
        public int ProductDescriptionID { get; set; }

        /// <summary>
        ///     Gets or sets the product model product description cultures.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get;
            set; }
    }
}