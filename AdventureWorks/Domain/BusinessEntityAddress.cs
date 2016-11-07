namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The business entity address.
    /// </summary>
    [Table("Person.BusinessEntityAddress")]
    public class BusinessEntityAddress : Entity
    {
        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        ///     Gets or sets the address id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressID { get; set; }

        /// <summary>
        ///     Gets or sets the address type.
        /// </summary>
        public virtual AddressType AddressType { get; set; }

        /// <summary>
        ///     Gets or sets the address type id.
        /// </summary>
        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressTypeID { get; set; }

        /// <summary>
        ///     Gets or sets the business entity.
        /// </summary>
        public virtual BusinessEntity BusinessEntity { get; set; }

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
    }
}