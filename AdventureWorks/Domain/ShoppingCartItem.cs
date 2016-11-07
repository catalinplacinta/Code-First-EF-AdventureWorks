namespace AdventureWorks.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    ///     The shopping cart item.
    /// </summary>
    [Table("Sales.ShoppingCartItem")]
    public class ShoppingCartItem : Entity
    {
        /// <summary>
        ///     Gets or sets the date created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        ///     Gets or sets the modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///     Gets or sets the product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        ///     Gets or sets the product id.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        ///     Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        ///     Gets or sets the shopping cart id.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string ShoppingCartID { get; set; }

        /// <summary>
        ///     Gets or sets the shopping cart item id.
        /// </summary>
        public int ShoppingCartItemID { get; set; }
    }
}