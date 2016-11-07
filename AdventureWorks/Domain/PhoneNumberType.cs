namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The phone number type.
    /// </summary>
    [Table("Person.PhoneNumberType")]
    public class PhoneNumberType : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PhoneNumberType" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public PhoneNumberType()
        {
            this.PersonPhones = new HashSet<PersonPhone>();
        }

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

        /// <summary>
        ///     Gets or sets the person phones.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }

        /// <summary>
        ///     Gets or sets the phone number type id.
        /// </summary>
        public int PhoneNumberTypeID { get; set; }
    }
}