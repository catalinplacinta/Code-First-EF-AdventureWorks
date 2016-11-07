namespace AdventureWorks.Contexts
{
    using System.Data.Entity;

    using AdventureWorks.Domain;
    using AdventureWorks.Initializers;

    /// <summary>
    ///     The adventure works context.
    /// </summary>
    public class HumanResourcesContext : Context
    {
        #region < Constructors >

        /// <summary>
        ///     Initializes a new instance of the <see cref="HumanResourcesContext" /> class.
        /// </summary>
        public HumanResourcesContext()
            : base("AdventureWorks")
        {
            Database.SetInitializer(new HumanResourcesInitializer());
        }

        #endregion

        #region < Properties >

        /// <summary>
        ///     Gets or sets the departments.
        /// </summary>
        public virtual DbSet<Department> Departments { get; set; }

        /// <summary>
        ///     Gets or sets the employee department histories.
        /// </summary>
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        /// <summary>
        ///     Gets or sets the employee pay histories.
        /// </summary>
        public virtual DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }

        /// <summary>
        ///     Gets or sets the employees.
        /// </summary>
        public virtual DbSet<Employee> Employees { get; set; }

        /// <summary>
        ///     Gets or sets the job candidates.
        /// </summary>
        public virtual DbSet<JobCandidate> JobCandidates { get; set; }

        /// <summary>
        ///     Gets or sets the shifts.
        /// </summary>
        public virtual DbSet<Shift> Shifts { get; set; }

        #endregion

        #region < Methods >

        /// <summary>
        ///     The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        ///     The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>().Property(e => e.MaritalStatus).IsFixedLength();

            modelBuilder.Entity<Employee>().Property(e => e.Gender).IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeePayHistories)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PurchaseOrderHeaders)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>().HasOptional(e => e.SalesPerson).WithRequired(e => e.Employee);

            modelBuilder.Entity<EmployeePayHistory>().Property(e => e.Rate).HasPrecision(19, 4);

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Shift)
                .WillCascadeOnDelete(false);
        }

        #endregion
    }
}