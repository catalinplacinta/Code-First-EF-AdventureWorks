namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The business entity.
    /// </summary>
    [Table("Person.BusinessEntity")]
    public class BusinessEntity : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BusinessEntity" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public BusinessEntity()
        {
            this.BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            this.BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        }

        /// <summary>
        ///     Gets or sets the business entity addresses.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

        /// <summary>
        ///     Gets or sets the business entity contacts.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

        /// <summary>
        ///     Gets or sets the business entity id.
        /// </summary>
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
        ///     Gets or sets the store.
        /// </summary>
        public virtual Store Store { get; set; }

        /// <summary>
        ///     Gets or sets the vendor.
        /// </summary>
        public virtual Vendor Vendor { get; set; }
    }
}