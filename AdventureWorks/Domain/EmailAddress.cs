namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The email address.
    /// </summary>
    [Table("Person.EmailAddress")]
    public class EmailAddress : Entity
    {
        /// <summary>
        ///     Gets or sets the business entity id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        ///     Gets or sets the email address 1.
        /// </summary>
        [Column("EmailAddress")]
        [StringLength(50)]
        public string EmailAddress1 { get; set; }

        /// <summary>
        ///     Gets or sets the email address id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public int EmailAddressID { get; set; }

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