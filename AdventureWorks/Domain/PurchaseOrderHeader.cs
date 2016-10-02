namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The purchase order header.
    /// </summary>
    [Table("Purchasing.PurchaseOrderHeader")]
    public class PurchaseOrderHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderHeader"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrderHeader()
        {
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }

        /// <summary>
        /// Gets or sets the purchase order id.
        /// </summary>
        [Key]
        public int PurchaseOrderID { get; set; }

        /// <summary>
        /// Gets or sets the revision number.
        /// </summary>
        public byte RevisionNumber { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the vendor id.
        /// </summary>
        public int VendorID { get; set; }

        /// <summary>
        /// Gets or sets the ship method id.
        /// </summary>
        public int ShipMethodID { get; set; }

        /// <summary>
        /// Gets or sets the order date.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the ship date.
        /// </summary>
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Gets or sets the sub total.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Gets or sets the tax amt.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        [Column(TypeName = "money")]
        public decimal TaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the freight.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal Freight { get; set; }

        /// <summary>
        /// Gets or sets the total due.
        /// </summary>
        /// [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "money")]
        public decimal TotalDue { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets the purchase order details.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the ship method.
        /// </summary>
        public virtual ShipMethod ShipMethod { get; set; }

        /// <summary>
        /// Gets or sets the vendor.
        /// </summary>
        public virtual Vendor Vendor { get; set; }
    }
}
