namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The location.
    /// </summary>
    [Table("Production.Location")]
    public class Location : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public Location()
        {
            this.ProductInventories = new HashSet<ProductInventory>();
            this.WorkOrderRoutings = new HashSet<WorkOrderRouting>();
        }

        /// <summary>
        ///     Gets or sets the availability.
        /// </summary>
        public decimal Availability { get; set; }

        /// <summary>
        ///     Gets or sets the cost rate.
        /// </summary>
        [Column(TypeName = "smallmoney")]
        public decimal CostRate { get; set; }

        /// <summary>
        ///     Gets or sets the location id.
        /// </summary>
        public short LocationID { get; set; }

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
        ///     Gets or sets the product inventories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }

        /// <summary>
        ///     Gets or sets the work order routings.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}