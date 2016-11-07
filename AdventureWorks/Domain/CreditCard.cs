namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The credit card.
    /// </summary>
    [Table("Sales.CreditCard")]
    public class CreditCard : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CreditCard" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public CreditCard()
        {
            this.PersonCreditCards = new HashSet<PersonCreditCard>();
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        ///     Gets or sets the card number.
        /// </summary>
        [Required]
        [StringLength(25)]
        public string CardNumber { get; set; }

        /// <summary>
        ///     Gets or sets the card type.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string CardType { get; set; }

        /// <summary>
        ///     Gets or sets the credit card id.
        /// </summary>
        public int CreditCardID { get; set; }

        /// <summary>
        ///     Gets or sets the exp month.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public byte ExpMonth { get; set; }

        /// <summary>
        ///     Gets or sets the exp year.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public short ExpYear { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the person credit cards.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

        /// <summary>
        ///     Gets or sets the sales order headers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}