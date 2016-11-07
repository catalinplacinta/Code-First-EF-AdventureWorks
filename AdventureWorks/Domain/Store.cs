namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The store.
    /// </summary>
    [Table("Sales.Store")]
    public class Store : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public Store()
        {
            this.Customers = new HashSet<Customer>();
        }

        /// <summary>
        ///     Gets or sets the business entity.
        /// </summary>
        public virtual BusinessEntity BusinessEntity { get; set; }

        /// <summary>
        ///     Gets or sets the business entity id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        ///     Gets or sets the customers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<Customer> Customers { get; set; }

        /// <summary>
        ///     Gets or sets the demographics.
        /// </summary>
        [Column(TypeName = "xml")]
        public string Demographics { get; set; }

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
        ///     Gets or sets the sales person.
        /// </summary>
        public virtual SalesPerson SalesPerson { get; set; }

        /// <summary>
        ///     Gets or sets the sales person id.
        /// </summary>
        public int? SalesPersonID { get; set; }
    }
}