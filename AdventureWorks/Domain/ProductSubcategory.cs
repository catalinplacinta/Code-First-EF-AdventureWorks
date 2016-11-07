namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The product subcategory.
    /// </summary>
    [Table("Production.ProductSubcategory")]
    public class ProductSubcategory : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProductSubcategory" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public ProductSubcategory()
        {
            this.Products = new HashSet<Product>();
        }

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
        ///     Gets or sets the product category.
        /// </summary>
        public virtual ProductCategory ProductCategory { get; set; }

        /// <summary>
        ///     Gets or sets the product category id.
        /// </summary>
        public int ProductCategoryID { get; set; }

        /// <summary>
        ///     Gets or sets the products.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<Product> Products { get; set; }

        /// <summary>
        ///     Gets or sets the product subcategory id.
        /// </summary>
        public int ProductSubcategoryID { get; set; }
    }
}