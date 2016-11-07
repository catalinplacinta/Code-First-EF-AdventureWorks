namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The transaction history archive.
    /// </summary>
    [Table("Production.TransactionHistoryArchive")]
    public class TransactionHistoryArchive : Entity
    {
        /// <summary>
        ///     Gets or sets the actual cost.
        /// </summary>
        [Column(TypeName = "money")]
        public decimal ActualCost { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the product id.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        ///     Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        ///     Gets or sets the reference order id.
        /// </summary>
        public int ReferenceOrderID { get; set; }

        /// <summary>
        ///     Gets or sets the reference order line id.
        /// </summary>
        public int ReferenceOrderLineID { get; set; }

        /// <summary>
        ///     Gets or sets the transaction date.
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        ///     Gets or sets the transaction id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionID { get; set; }

        /// <summary>
        ///     Gets or sets the transaction type.
        /// </summary>
        [Required]
        [StringLength(1)]
        public string TransactionType { get; set; }
    }
}