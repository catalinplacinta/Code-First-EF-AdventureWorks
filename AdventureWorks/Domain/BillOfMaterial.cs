namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     The bill of material.
    /// </summary>
    [Table("Production.BillOfMaterials")]
    public class BillOfMaterial : Entity
    {
        /// <summary>
        ///     Gets or sets the bill of materials id.
        /// </summary>
        [Key]
        public int BillOfMaterialsID { get; set; }

        /// <summary>
        ///     Gets or sets the bom level.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public short BOMLevel { get; set; }

        /// <summary>
        ///     Gets or sets the component id.
        /// </summary>
        public int ComponentID { get; set; }

        /// <summary>
        ///     Gets or sets the end date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the per assembly qty.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
             Justification = "Reviewed. Suppression is OK here.")]
        public decimal PerAssemblyQty { get; set; }

        /// <summary>
        ///     Gets or sets the product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        ///     Gets or sets the product 1.
        /// </summary>
        public virtual Product Product1 { get; set; }

        /// <summary>
        ///     Gets or sets the product assembly id.
        /// </summary>
        public int? ProductAssemblyID { get; set; }

        /// <summary>
        ///     Gets or sets the start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        ///     Gets or sets the unit measure.
        /// </summary>
        public virtual UnitMeasure UnitMeasure { get; set; }

        /// <summary>
        ///     Gets or sets the unit measure code.
        /// </summary>
        [Required]
        [StringLength(3)]
        public string UnitMeasureCode { get; set; }
    }
}