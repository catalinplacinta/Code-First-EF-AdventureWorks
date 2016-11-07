namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The employee department history.
    /// </summary>
    [Table("HumanResources.EmployeeDepartmentHistory")]
    public class EmployeeDepartmentHistory : Entity
    {
        /// <summary>
        ///     Gets or sets the business entity id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        ///     Gets or sets the department.
        /// </summary>
        public virtual Department Department { get; set; }

        /// <summary>
        ///     Gets or sets the department id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DepartmentID { get; set; }

        /// <summary>
        ///     Gets or sets the employee.
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        ///     Gets or sets the end date.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the shift.
        /// </summary>
        public virtual Shift Shift { get; set; }

        /// <summary>
        ///     Gets or sets the shift id.
        /// </summary>
        [Key]
        [Column(Order = 2)]
        public byte ShiftID { get; set; }

        /// <summary>
        ///     Gets or sets the start date.
        /// </summary>
        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime StartDate { get; set; }
    }
}