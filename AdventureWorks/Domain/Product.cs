namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The product.
    /// </summary>
    [Table("Production.Product")]
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.BillOfMaterials = new HashSet<BillOfMaterial>();
            this.BillOfMaterials1 = new HashSet<BillOfMaterial>();
            this.ProductCostHistories = new HashSet<ProductCostHistory>();
            this.ProductInventories = new HashSet<ProductInventory>();
            this.ProductListPriceHistories = new HashSet<ProductListPriceHistory>();
            this.ProductProductPhotoes = new HashSet<ProductProductPhoto>();
            this.ProductReviews = new HashSet<ProductReview>();
            this.ProductVendors = new HashSet<ProductVendor>();
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            this.ShoppingCartItems = new HashSet<ShoppingCartItem>();
            this.SpecialOfferProducts = new HashSet<SpecialOfferProduct>();
            this.TransactionHistories = new HashSet<TransactionHistory>();
            this.WorkOrders = new HashSet<WorkOrder>();
        }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product number.
        /// </summary>
        [Required]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether make flag.
        /// </summary>
        public bool MakeFlag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether finished goods flag.
        /// </summary>
        public bool FinishedGoodsFlag { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [StringLength(15)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the safety stock level.
        /// </summary>
        public short SafetyStockLevel { get; set; }

        /// <summary>
        /// Gets or sets the reorder point.
        /// </summary>
        public short ReorderPoint { get; set; }

        /// <summary>
        /// Gets or sets the standard cost.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal StandardCost { get; set; }

        /// <summary>
        /// Gets or sets the list price.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        [StringLength(5)]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the size unit measure code.
        /// </summary>
        [StringLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets the weight unit measure code.
        /// </summary>
        [StringLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or sets the days to manufacture.
        /// </summary>
        public int DaysToManufacture { get; set; }

        /// <summary>
        /// Gets or sets the product line.
        /// </summary>
        [StringLength(2)]
        public string ProductLine { get; set; }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        [StringLength(2)]
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        [StringLength(2)]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the product subcategory id.
        /// </summary>
        public int? ProductSubcategoryID { get; set; }

        /// <summary>
        /// Gets or sets the product model id.
        /// </summary>
        public int? ProductModelID { get; set; }

        /// <summary>
        /// Gets or sets the sell start date.
        /// </summary>
        public DateTime SellStartDate { get; set; }

        /// <summary>
        /// Gets or sets the sell end date.
        /// </summary>
        public DateTime? SellEndDate { get; set; }

        /// <summary>
        /// Gets or sets the discontinued date.
        /// </summary>
        public DateTime? DiscontinuedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the bill of materials.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }

        /// <summary>
        /// Gets or sets the bill of materials 1.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOfMaterial> BillOfMaterials1 { get; set; }

        /// <summary>
        /// Gets or sets the product model.
        /// </summary>
        public virtual ProductModel ProductModel { get; set; }

        /// <summary>
        /// Gets or sets the product subcategory.
        /// </summary>
        public virtual ProductSubcategory ProductSubcategory { get; set; }

        /// <summary>
        /// Gets or sets the unit measure.
        /// </summary>
        public virtual UnitMeasure UnitMeasure { get; set; }

        /// <summary>
        /// Gets or sets the unit measure 1.
        /// </summary>
        public virtual UnitMeasure UnitMeasure1 { get; set; }

        /// <summary>
        /// Gets or sets the product cost histories.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }

        /// <summary>
        /// Gets or sets the product document.
        /// </summary>
        public virtual ProductDocument ProductDocument { get; set; }

        /// <summary>
        /// Gets or sets the product inventories.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }

        /// <summary>
        /// Gets or sets the product list price histories.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }

        /// <summary>
        /// Gets or sets the product product photoes.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; }

        /// <summary>
        /// Gets or sets the product reviews.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductReview> ProductReviews { get; set; }

        /// <summary>
        /// Gets or sets the product vendors.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }

        /// <summary>
        /// Gets or sets the purchase order details.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the shopping cart items.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        /// <summary>
        /// Gets or sets the special offer products.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

        /// <summary>
        /// Gets or sets the transaction histories.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }

        /// <summary>
        /// Gets or sets the work orders.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
