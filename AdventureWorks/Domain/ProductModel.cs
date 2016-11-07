namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The product model.
    /// </summary>
    [Table("Production.ProductModel")]
    public class ProductModel : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProductModel" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public ProductModel()
        {
            this.Products = new HashSet<Product>();
            this.ProductModelIllustrations = new HashSet<ProductModelIllustration>();
            this.ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        }

        /// <summary>
        ///     Gets or sets the catalog description.
        /// </summary>
        [Column(TypeName = "xml")]
        public string CatalogDescription { get; set; }

        /// <summary>
        ///     Gets or sets the instructions.
        /// </summary>
        [Column(TypeName = "xml")]
        public string Instructions { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the product model id.
        /// </summary>
        public int ProductModelID { get; set; }

        /// <summary>
        ///     Gets or sets the product model illustrations.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

        /// <summary>
        ///     Gets or sets the product model product description cultures.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get;
            set; }

        /// <summary>
        ///     Gets or sets the products.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<Product> Products { get; set; }
    }
}