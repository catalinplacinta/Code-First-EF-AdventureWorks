namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The product category.
    /// </summary>
    [Table("Production.ProductCategory")]
    public class ProductCategory : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProductCategory" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public ProductCategory()
        {
            this.ProductSubcategories = new HashSet<ProductSubcategory>();
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
        ///     Gets or sets the product category id.
        /// </summary>
        public int ProductCategoryID { get; set; }

        /// <summary>
        ///     Gets or sets the product subcategories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }
    }
}