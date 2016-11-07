namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The customer.
    /// </summary>
    [Table("Sales.Customer")]
    public class Customer : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Customer" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public Customer()
        {
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        ///     Gets or sets the account number.
        /// </summary>
        /// [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(10)]
        public string AccountNumber { get; set; }

        /// <summary>
        ///     Gets or sets the customer id.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the person.
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        ///     Gets or sets the person id.
        /// </summary>
        public int? PersonID { get; set; }

        /// <summary>
        ///     Gets or sets the sales order headers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        ///     Gets or sets the sales territory.
        /// </summary>
        public virtual SalesTerritory SalesTerritory { get; set; }

        /// <summary>
        ///     Gets or sets the store.
        /// </summary>
        public virtual Store Store { get; set; }

        /// <summary>
        ///     Gets or sets the store id.
        /// </summary>
        public int? StoreID { get; set; }

        /// <summary>
        ///     Gets or sets the territory id.
        /// </summary>
        public int? TerritoryID { get; set; }
    }
}