namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The person.
    /// </summary>
    [Table("Person.Person")]
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            this.BusinessEntityContacts = new HashSet<BusinessEntityContact>();
            this.EmailAddresses = new HashSet<EmailAddress>();
            this.Customers = new HashSet<Customer>();
            this.PersonCreditCards = new HashSet<PersonCreditCard>();
            this.PersonPhones = new HashSet<PersonPhone>();
        }

        /// <summary>
        /// Gets or sets the business entity id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the person type.
        /// </summary>
        [Required]
        [StringLength(2)]
        public string PersonType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether name style.
        /// </summary>
        public bool NameStyle { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [StringLength(8)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle name.
        /// </summary>
        [StringLength(50)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the suffix.
        /// </summary>
        [StringLength(10)]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets the email promotion.
        /// </summary>
        public int EmailPromotion { get; set; }

        /// <summary>
        /// Gets or sets the additional contact info.
        /// </summary>
        [Column(TypeName = "xml")]
        public string AdditionalContactInfo { get; set; }

        /// <summary>
        /// Gets or sets the demographics.
        /// </summary>
        [Column(TypeName = "xml")]
        public string Demographics { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets the business entity.
        /// </summary>
        public virtual BusinessEntity BusinessEntity { get; set; }

        /// <summary>
        /// Gets or sets the business entity contacts.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

        /// <summary>
        /// Gets or sets the email addresses.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public virtual Password Password { get; set; }

        /// <summary>
        /// Gets or sets the customers.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the person credit cards.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

        /// <summary>
        /// Gets or sets the person phones.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
