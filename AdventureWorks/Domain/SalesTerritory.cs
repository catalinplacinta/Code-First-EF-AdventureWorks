namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The sales territory.
    /// </summary>
    [Table("Sales.SalesTerritory")]
    public class SalesTerritory : Entity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SalesTerritory" /> class.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors",
             Justification = "Reviewed. Suppression is OK here.")]
        public SalesTerritory()
        {
            this.StateProvinces = new HashSet<StateProvince>();
            this.Customers = new HashSet<Customer>();
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            this.SalesPersons = new HashSet<SalesPerson>();
            this.SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
        }

        /// <summary>
        ///     Gets or sets the cost last year.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal CostLastYear { get; set; }

        /// <summary>
        ///     Gets or sets the cost ytd.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        [Column(TypeName = "money")]
        public decimal CostYTD { get; set; }

        /// <summary>
        ///     Gets or sets the country region.
        /// </summary>
        public virtual CountryRegion CountryRegion { get; set; }

        /// <summary>
        ///     Gets or sets the country region code.
        /// </summary>
        [Required]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        /// <summary>
        ///     Gets or sets the customers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<Customer> Customers { get; set; }

        /// <summary>
        ///     Gets or sets the group.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Group { get; set; }

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
        ///     Gets or sets the sales last year.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal SalesLastYear { get; set; }

        /// <summary>
        ///     Gets or sets the sales order headers.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        ///     Gets or sets the sales persons.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesPerson> SalesPersons { get; set; }

        /// <summary>
        ///     Gets or sets the sales territory histories.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        /// <summary>
        ///     Gets or sets the sales ytd.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        [Column(TypeName = "money")]
        public decimal SalesYTD { get; set; }

        /// <summary>
        ///     Gets or sets the state provinces.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly",
             Justification = "Reviewed. Suppression is OK here.")]
        public virtual ICollection<StateProvince> StateProvinces { get; set; }

        /// <summary>
        ///     Gets or sets the territory id.
        /// </summary>
        [Key]
        public int TerritoryID { get; set; }
    }
}