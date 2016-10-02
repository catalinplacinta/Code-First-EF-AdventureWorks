namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The sales territory history.
    /// </summary>
    [Table("Sales.SalesTerritoryHistory")]
    public class SalesTerritoryHistory
    {
        /// <summary>
        /// Gets or sets the business entity id.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the territory id.
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TerritoryID { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [Key]
        [Column(Order = 2)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the sales person.
        /// </summary>
        public virtual SalesPerson SalesPerson { get; set; }

        /// <summary>
        /// Gets or sets the sales territory.
        /// </summary>
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
