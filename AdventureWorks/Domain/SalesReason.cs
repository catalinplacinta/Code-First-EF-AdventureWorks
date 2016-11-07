namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The sales reason.
    /// </summary>
    [Table("Sales.SalesReason")]
    public class SalesReason : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SalesReason" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public SalesReason()
        {
            this.SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
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
        ///     Gets or sets the reason type.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string ReasonType { get; set; }

        /// <summary>
        ///     Gets or sets the sales order header sales reasons.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        /// <summary>
        ///     Gets or sets the sales reason id.
        /// </summary>
        public int SalesReasonID { get; set; }
    }
}