namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The scrap reason.
    /// </summary>
    [Table("Production.ScrapReason")]
    public class ScrapReason : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ScrapReason" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public ScrapReason()
        {
            this.WorkOrders = new HashSet<WorkOrder>();
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
        ///     Gets or sets the scrap reason id.
        /// </summary>
        public short ScrapReasonID { get; set; }

        /// <summary>
        ///     Gets or sets the work orders.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}