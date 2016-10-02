namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The password.
    /// </summary>
    [Table("Person.Password")]
    public class Password
    {
        /// <summary>
        /// Gets or sets the business entity id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the password hash.
        /// </summary>
        [Required]
        [StringLength(128)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the password salt.
        /// </summary>
        [Required]
        [StringLength(10)]
        public string PasswordSalt { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the person.
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
