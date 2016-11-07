namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The person credit card.
    /// </summary>
    [Table("Sales.PersonCreditCard")]
    public class PersonCreditCard : Entity
    {
        /// <summary>
        ///     Gets or sets the business entity id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        ///     Gets or sets the credit card.
        /// </summary>
        public virtual CreditCard CreditCard { get; set; }

        /// <summary>
        ///     Gets or sets the credit card id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditCardID { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the person.
        /// </summary>
        public virtual Person Person { get; set; }
    }
}