namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The address type.
    /// </summary>
    [Table("Person.AddressType")]
    public class AddressType : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AddressType" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public AddressType()
        {
            this.BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
        }

        /// <summary>
        ///     Gets or sets the address type id.
        /// </summary>
        public int AddressTypeID { get; set; }

        /// <summary>
        ///     Gets or sets the business entity addresses.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

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