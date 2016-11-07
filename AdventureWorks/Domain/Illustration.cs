namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The illustration.
    /// </summary>
    [Table("Production.Illustration")]
    public class Illustration : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Illustration" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public Illustration()
        {
            this.ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        }

        /// <summary>
        ///     Gets or sets the diagram.
        /// </summary>
        [Column(TypeName = "xml")]
        public string Diagram { get; set; }

        /// <summary>
        ///     Gets or sets the illustration id.
        /// </summary>
        public int IllustrationID { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the product model illustrations.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
    }
}