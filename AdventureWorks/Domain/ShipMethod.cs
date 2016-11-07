namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The ship method.
    /// </summary>
    [Table("Purchasing.ShipMethod")]
    public class ShipMethod : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ShipMethod" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public ShipMethod()
        {
            this.PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
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
        ///     Gets or sets the purchase order headers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        /// <summary>
        ///     Gets or sets the sales order headers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        ///     Gets or sets the ship base.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ShipBase { get; set; }

        /// <summary>
        ///     Gets or sets the ship method id.
        /// </summary>
        public int ShipMethodID { get; set; }

        /// <summary>
        ///     Gets or sets the ship rate.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ShipRate { get; set; }
    }
}