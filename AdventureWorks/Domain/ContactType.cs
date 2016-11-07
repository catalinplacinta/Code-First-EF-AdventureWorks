namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The contact type.
    /// </summary>
    [Table("Person.ContactType")]
    public class ContactType : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ContactType" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public ContactType()
        {
            this.BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        }

        /// <summary>
        ///     Gets or sets the business entity contacts.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

        /// <summary>
        ///     Gets or sets the contact type id.
        /// </summary>
        public int ContactTypeID { get; set; }

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
    }
}