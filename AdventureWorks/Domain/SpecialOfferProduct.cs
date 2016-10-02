namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The special offer product.
    /// </summary>
    [Table("Sales.SpecialOfferProduct")]
    public class SpecialOfferProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOfferProduct"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialOfferProduct()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }

        /// <summary>
        /// Gets or sets the special offer id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecialOfferID { get; set; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets the sales order details.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the special offer.
        /// </summary>
        public virtual SpecialOffer SpecialOffer { get; set; }
    }
}
