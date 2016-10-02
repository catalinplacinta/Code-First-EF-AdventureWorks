namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The sales tax rate.
    /// </summary>
    [Table("Sales.SalesTaxRate")]
    public class SalesTaxRate
    {
        /// <summary>
        /// Gets or sets the sales tax rate id.
        /// </summary>
        public int SalesTaxRateID { get; set; }

        /// <summary>
        /// Gets or sets the state province id.
        /// </summary>
        public int StateProvinceID { get; set; }

        /// <summary>
        /// Gets or sets the tax type.
        /// </summary>
        public byte TaxType { get; set; }

        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        [Column(TypeName = "smallmoney")]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the state province.
        /// </summary>
        public virtual StateProvince StateProvince { get; set; }
    }
}
