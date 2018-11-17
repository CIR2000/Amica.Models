using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Amica.Models.Resources;
using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Product price information.
    /// </summary>
    public class ProductInventory : ObservableObject
    {
        private string _warehouseId;
        private float _currentStock;
        private float _reserved;
        private float _ordered;
        private float _minimumStock;
        private DateTime _lastPurchase;
        private DateTime _lastSale;
        private decimal _totalSpent;
        private decimal _totalSold;
        private float _itemsPurchased;
        private float _itemsSold;

        /// <summary>
        /// Gets or sets the Warehouse Id.
        /// </summary>
        /// <value>The Warehouse Id.</value>
        [Required]
        public string WarehouseId
        {
            set { SetProperty(ref _warehouseId, value); }
            get { return _warehouseId; }
        }
        /// <summary>
        /// Gets or sets the current stock.
        /// </summary>
        /// <value>
        /// The current stock.
        /// </value>
        [Display(Name = nameof(Properties.CurrentStock), ResourceType = typeof(Properties))]
        public float CurrentStock
        {
            set { SetProperty(ref _currentStock, value); }
            get { return _currentStock; }
        }

        /// <summary>
        /// Gets or sets the number of items reserved by clients.
        /// </summary>
        /// <value>
        /// The number of items reserved by clients.
        /// </value>
        [Display(Name = nameof(Properties.Reserved), ResourceType = typeof(Properties))]
        public float Reserved
        {
            set { SetProperty(ref _reserved, value); }
            get { return _reserved; }
        }

        /// <summary>
        /// Gets or sets number of items expected to arrive (on order).
        /// </summary>
        /// <value>
        /// The number of items due to arrive (on order).
        /// </value>
        [Display(Name = nameof(Properties.Ordered), ResourceType = typeof(Properties))]
        public float Ordered
        {
            set { SetProperty(ref _ordered, value); }
            get { return _ordered; }
        }
        /// <summary>
        /// Gets or sets the minimum stock for the product.
        /// </summary>
        /// <value>
        /// The minimum stock.
        /// </value>
        [Display(Name = nameof(Properties.MinimumStock), ResourceType = typeof(Properties))]
        public float MinimumStock
        {
            set { SetProperty(ref _minimumStock, value); }
            get { return _minimumStock; }
        }
        /// <summary>
        /// Gets or sets the last purchase date.
        /// </summary>
        /// <value>
        /// The last purchase date.
        /// </value>
        [Display(Name = nameof(Properties.LastPurchase), ResourceType = typeof(Properties))]
        public DateTime LastPurchase
        {
            set { SetProperty(ref _lastPurchase, value); }
            get { return _lastPurchase; }
        }
        /// <summary>
        /// Gets or sets the last sale date.
        /// </summary>
        /// <value>
        /// The last sale date.
        /// </value>
        [Display(Name = nameof(Properties.LastSale), ResourceType = typeof(Properties))]
        public DateTime LastSale
        {
            set { SetProperty(ref _lastSale, value); }
            get { return _lastSale; }
        }
        /// <summary>
        /// Gets or sets the total value spent.
        /// </summary>
        /// <value>
        /// The total value spent.
        /// </value>
        [Display(Name = nameof(Properties.TotalSpent), ResourceType = typeof(Properties))]
        public decimal TotalSpent
        {
            set { SetProperty(ref _totalSpent, value); }
            get { return _totalSpent; }
        }
        /// <summary>
        /// Gets or sets the total value sold.
        /// </summary>
        /// <value>
        /// The total value sold.
        /// </value>
        [Display(Name = nameof(Properties.TotalSold), ResourceType = typeof(Properties))]
        public decimal TotalSold
        {
            set { SetProperty(ref _totalSold, value); }
            get { return _totalSold; }
        }
        /// <summary>
        /// Gets or sets the total items purchased.
        /// </summary>
        /// <value>
        /// The total items purchased.
        /// </value>
        [Display(Name = nameof(Properties.ItemsPurchased), ResourceType = typeof(Properties))]
        public float ItemsPurchased
        {
            set { SetProperty(ref _itemsPurchased, value); }
            get { return _itemsPurchased; }
        }
        /// <summary>
        /// Gets or sets the total items sold.
        /// </summary>
        /// <value>
        /// The total items sold.
        /// </value>
        [Display(Name = nameof(Properties.ItemsSold), ResourceType = typeof(Properties))]
        public float ItemsSold
        {
            set { SetProperty(ref _itemsSold, value); }
            get { return _itemsSold; }
        }
        /// <summary>
        /// Gets the number of available items (current stock minus the reserved items)
        /// </summary>
        /// <value>
        /// The number of available items
        /// </value>
        [Display(Name = nameof(Properties.AvailableStock), ResourceType = typeof(Properties))]
        [JsonIgnore]
        public float AvailableStock => CurrentStock - Reserved;
    }
}