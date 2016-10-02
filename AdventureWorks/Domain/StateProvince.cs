namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The state province.
    /// </summary>
    [Table("Person.StateProvince")]
    public class StateProvince
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateProvince"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StateProvince()
        {
            this.Addresses = new HashSet<Address>();
            this.SalesTaxRates = new HashSet<SalesTaxRate>();
        }

        /// <summary>
        /// Gets or sets the state province id.
        /// </summary>
        public int StateProvinceID { get; set; }

        /// <summary>
        /// Gets or sets the state province code.
        /// </summary>
        [Required]
        [StringLength(3)]
        public string StateProvinceCode { get; set; }

        /// <summary>
        /// Gets or sets the country region code.
        /// </summary>
        [Required]
        [StringLength(3)]
        public string CountryRegionCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is only state province flag.
        /// </summary>
        public bool IsOnlyStateProvinceFlag { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the territory id.
        /// </summary>
        public int TerritoryID { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the country region.
        /// </summary>
        public virtual CountryRegion CountryRegion { get; set; }

        /// <summary>
        /// Gets or sets the sales tax rates.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }

        /// <summary>
        /// Gets or sets the sales territory.
        /// </summary>
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
