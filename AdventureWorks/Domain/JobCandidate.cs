namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The job candidate.
    /// </summary>
    [Table("HumanResources.JobCandidate")]
    public class JobCandidate
    {
        /// <summary>
        /// Gets or sets the job candidate id.
        /// </summary>
        public int JobCandidateID { get; set; }

        /// <summary>
        /// Gets or sets the business entity id.
        /// </summary>
        public int? BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the resume.
        /// </summary>
        [Column(TypeName = "xml")]
        public string Resume { get; set; }

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
