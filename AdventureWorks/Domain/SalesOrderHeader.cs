namespace AdventureWorks.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The sales order header.
    /// </summary>
    [Table("Sales.SalesOrderHeader")]
    public class SalesOrderHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderHeader"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrderHeader()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
            this.SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
        }

        /// <summary>
        /// Gets or sets the sales order id.
        /// </summary>
        [Key]
        public int SalesOrderID { get; set; }

        /// <summary>
        /// Gets or sets the revision number.
        /// </summary>
        public byte RevisionNumber { get; set; }

        /// <summary>
        /// Gets or sets the order date.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the ship date.
        /// </summary>
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether online order flag.
        /// </summary>
        public bool OnlineOrderFlag { get; set; }

        /// <summary>
        /// Gets or sets the sales order number.
        /// </summary>
        /// [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the purchase order number.
        /// </summary>
        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        [StringLength(15)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the customer id.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the sales person id.
        /// </summary>
        public int? SalesPersonID { get; set; }

        /// <summary>
        /// Gets or sets the territory id.
        /// </summary>
        public int? TerritoryID { get; set; }

        /// <summary>
        /// Gets or sets the bill to address id.
        /// </summary>
        public int BillToAddressID { get; set; }

        /// <summary>
        /// Gets or sets the ship to address id.
        /// </summary>
        public int ShipToAddressID { get; set; }

        /// <summary>
        /// Gets or sets the ship method id.
        /// </summary>
        public int ShipMethodID { get; set; }

        /// <summary>
        /// Gets or sets the credit card id.
        /// </summary>
        public int? CreditCardID { get; set; }

        /// <summary>
        /// Gets or sets the credit card approval code.
        /// </summary>
        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        /// <summary>
        /// Gets or sets the currency rate id.
        /// </summary>
        public int? CurrencyRateID { get; set; }

        /// <summary>
        /// Gets or sets the sub total.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Gets or sets the tax amt.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        [Column(TypeName = "money")]
        public decimal TaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the freight.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal Freight { get; set; }

        /// <summary>
        /// Gets or sets the total due.
        /// </summary>
        /// [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "money")]
        public decimal TotalDue { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [StringLength(128)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        public virtual Address Address1 { get; set; }

        /// <summary>
        /// Gets or sets the ship method.
        /// </summary>
        public virtual ShipMethod ShipMethod { get; set; }

        /// <summary>
        /// Gets or sets the credit card.
        /// </summary>
        public virtual CreditCard CreditCard { get; set; }

        /// <summary>
        /// Gets or sets the currency rate.
        /// </summary>
        public virtual CurrencyRate CurrencyRate { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the sales order details.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the sales person.
        /// </summary>
        public virtual SalesPerson SalesPerson { get; set; }

        /// <summary>
        /// Gets or sets the sales territory.
        /// </summary>
        public virtual SalesTerritory SalesTerritory { get; set; }

        /// <summary>
        /// Gets or sets the sales order header sales reasons.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1404:CodeAnalysisSuppressionMustHaveJustification", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
    }
}
