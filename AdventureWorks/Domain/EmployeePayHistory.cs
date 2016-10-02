namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The employee pay history.
    /// </summary>
    [Table("HumanResources.EmployeePayHistory")]
    public class EmployeePayHistory
    {
        /// <summary>
        /// Gets or sets the business entity id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the rate change date.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public DateTime RateChangeDate { get; set; }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets the pay frequency.
        /// </summary>
        public byte PayFrequency { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        public virtual Employee Employee { get; set; }
    }
}
