namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The shift.
    /// </summary>
    [Table("HumanResources.Shift")]
    public class Shift : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Shift" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public Shift()
        {
            this.EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        }

        /// <summary>
        ///     Gets or sets the employee department histories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        /// <summary>
        ///     Gets or sets the end time.
        /// </summary>
        public TimeSpan EndTime { get; set; }

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
        ///     Gets or sets the shift id.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ShiftID { get; set; }

        /// <summary>
        ///     Gets or sets the start time.
        /// </summary>
        public TimeSpan StartTime { get; set; }
    }
}