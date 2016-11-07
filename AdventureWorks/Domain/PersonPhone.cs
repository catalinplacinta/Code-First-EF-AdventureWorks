namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The person phone.
    /// </summary>
    [Table("Person.PersonPhone")]
    public class PersonPhone : Entity
    {
        /// <summary>
        ///     Gets or sets the business entity id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the person.
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        ///     Gets or sets the phone number.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     Gets or sets the phone number type.
        /// </summary>
        public virtual PhoneNumberType PhoneNumberType { get; set; }

        /// <summary>
        ///     Gets or sets the phone number type id.
        /// </summary>
        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhoneNumberTypeID { get; set; }
    }
}