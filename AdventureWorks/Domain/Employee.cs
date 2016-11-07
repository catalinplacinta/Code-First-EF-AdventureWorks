namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The employee.
    /// </summary>
    [Table("HumanResources.Employee")]
    public class Employee : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Employee" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "Reviewed. Suppression is OK here.")]
        public Employee()
        {
            this.EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            this.EmployeePayHistories = new HashSet<EmployeePayHistory>();
            this.JobCandidates = new HashSet<JobCandidate>();
            this.PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
        }

        /// <summary>
        ///     Gets or sets the birth date.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        ///     Gets or sets the business entity id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether current flag.
        /// </summary>
        public bool CurrentFlag { get; set; }

        /// <summary>
        ///     Gets or sets the employee department histories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        /// <summary>
        ///     Gets or sets the employee pay histories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }

        /// <summary>
        ///     Gets or sets the gender.
        /// </summary>
        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        /// <summary>
        ///     Gets or sets the hire date.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }

        /// <summary>
        ///     Gets or sets the job candidates.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }

        /// <summary>
        ///     Gets or sets the job title.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string JobTitle { get; set; }

        /// <summary>
        ///     Gets or sets the login id.
        /// </summary>
        [Required]
        [StringLength(256)]
        public string LoginID { get; set; }

        /// <summary>
        ///     Gets or sets the marital status.
        /// </summary>
        [Required]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the national id number.
        /// </summary>
        [Required]
        [StringLength(15)]
        public string NationalIDNumber { get; set; }

        /// <summary>
        ///     Gets or sets the person.
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        ///     Gets or sets the purchase order headers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether salaried flag.
        /// </summary>
        public bool SalariedFlag { get; set; }

        /// <summary>
        ///     Gets or sets the sales person.
        /// </summary>
        public virtual SalesPerson SalesPerson { get; set; }

        /// <summary>
        ///     Gets or sets the sick leave hours.
        /// </summary>
        public short SickLeaveHours { get; set; }

        /// <summary>
        ///     Gets or sets the vacation hours.
        /// </summary>
        public short VacationHours { get; set; }
    }
}