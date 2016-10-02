namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The illustration.
    /// </summary>
    [Table("Production.Illustration")]
    public class Illustration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Illustration"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Illustration()
        {
            this.ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        }

        /// <summary>
        /// Gets or sets the illustration id.
        /// </summary>
        public int IllustrationID { get; set; }

        /// <summary>
        /// Gets or sets the diagram.
        /// </summary>
        [Column(TypeName = "xml")]
        public string Diagram { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the product model illustrations.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
    }
}
