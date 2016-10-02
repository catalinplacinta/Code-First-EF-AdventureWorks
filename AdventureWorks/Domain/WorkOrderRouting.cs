namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The work order routing.
    /// </summary>
    [Table("Production.WorkOrderRouting")]
    public class WorkOrderRouting
    {
        /// <summary>
        /// Gets or sets the work order id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkOrderID { get; set; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the operation sequence.
        /// </summary>
        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OperationSequence { get; set; }

        /// <summary>
        /// Gets or sets the location id.
        /// </summary>
        public short LocationID { get; set; }

        /// <summary>
        /// Gets or sets the scheduled start date.
        /// </summary>
        public DateTime ScheduledStartDate { get; set; }

        /// <summary>
        /// Gets or sets the scheduled end date.
        /// </summary>
        public DateTime ScheduledEndDate { get; set; }

        /// <summary>
        /// Gets or sets the actual start date.
        /// </summary>
        public DateTime? ActualStartDate { get; set; }

        /// <summary>
        /// Gets or sets the actual end date.
        /// </summary>
        public DateTime? ActualEndDate { get; set; }

        /// <summary>
        /// Gets or sets the actual resource hrs.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public decimal? ActualResourceHrs { get; set; }

        /// <summary>
        /// Gets or sets the planned cost.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal PlannedCost { get; set; }

        /// <summary>
        /// Gets or sets the actual cost.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal? ActualCost { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public virtual Location Location { get; set; }

        /// <summary>
        /// Gets or sets the work order.
        /// </summary>
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
