namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The address.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
    [Table("Person.Address")]
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            this.BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            this.SalesOrderHeaders1 = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Gets or sets the address id.
        /// </summary>
        public int AddressID { get; set; }

        /// <summary>
        /// Gets or sets the address line 1.
        /// </summary>
        [Required]
        [StringLength(60)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2.
        /// </summary>
        [StringLength(60)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [Required]
        [StringLength(30)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state province id.
        /// </summary>
        public int StateProvinceID { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [Required]
        [StringLength(15)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the spatial location.
        /// </summary>
        public DbGeography SpatialLocation { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the state province.
        /// </summary>
        public virtual StateProvince StateProvince { get; set; }

        /// <summary>
        /// Gets or sets the business entity addresses.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

        /// <summary>
        /// Gets or sets the sales order headers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the sales order headers 1.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders1 { get; set; }
    }
}
