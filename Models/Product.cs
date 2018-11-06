using System.ComponentModel.DataAnnotations;
using Amica.Models.Resources;

namespace Amica.Models
{
    /// <summary>
    /// Product information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    public class Product : BaseModelWithCompanyId
    {
        private string _code;
        private string _barCode;
        private string _vendorCode;
        private string _name;
        private string _description;
        private string _unitOfMeasure = UnitOfMeasureHelper.DefaultValue;
        private string _notes;
        private string _productCategory;
        private bool _is_product = true;
        private decimal _most_recent_cost;
        private decimal _average_cost;
        private string _vatId;

        /// <summary>
        /// Gets or sets the product code.
        /// </summary>
        /// <value>The product code.</value>
        [Display(Name = nameof(Properties.Code), ResourceType = typeof(Properties))]
        public string Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.Name), ResourceType = typeof(Properties))]
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the barcode.
        /// </summary>
        /// <value>
        /// The IBAN code.
        /// </value>
        [Display(Name = nameof(Properties.BarCode), ResourceType = typeof(Properties))]
        public string BarCode
        {
            set { SetProperty(ref _barCode, value); }
            get { return _barCode; }
        }

        /// <summary>
        /// Gets or sets cendor code.
        /// </summary>
        /// <value>
        /// The BIC/SWIFT code.
        /// </value>
        [Display(Name = nameof(Properties.VendorCode), ResourceType = typeof(Properties))]
        public string VendorCode
        {
            set { SetProperty(ref _vendorCode, value); }
            get { return _vendorCode; }
        }
        /// <summary>
        /// Gets or sets the description (used when invoicing).
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.ProductDescription), ResourceType = typeof(Properties))]
        public string Description
        {
            set { SetProperty(ref _description, value); }
            get { return _description; }
        }
        /// <summary>
        /// Gets or sets the unit of measure.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.UnitOfMeasure), ResourceType = typeof(Properties))]
        public string UnitOfMeasure
        {
            set { SetProperty(ref _unitOfMeasure, value); }
            get { return _unitOfMeasure; }
        }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.Notes), ResourceType = typeof(Properties))]
        public string Notes
        {
            set { SetProperty(ref _notes, value); }
            get { return _notes; }
        }
        /// <summary>
        /// Gets or sets the product category.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.ProductCategory), ResourceType = typeof(Properties))]
        public string ProductCategory
        {
            set { SetProperty(ref _productCategory, value); }
            get { return _productCategory; }
        }
        /// <summary>
        /// Gets or sets the if it is a product or service.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.IsProduct), ResourceType = typeof(Properties))]
        public bool IsProduct
        {
            set { SetProperty(ref _is_product, value); }
            get { return _is_product; }
        }
        /// <summary>
        /// Gets or sets the most recent cost.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.MostRecentCost), ResourceType = typeof(Properties))]
        public decimal MostRecentCost
        {
            set { SetProperty(ref _most_recent_cost, value); }
            get { return _most_recent_cost; }
        }
        /// <summary>
        /// Gets or sets the average cost.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.AverageCost), ResourceType = typeof(Properties))]
        public decimal AverageCost
        {
            set { SetProperty(ref _average_cost, value); }
            get { return _average_cost; }
        }
        /// <summary>
        /// Gets or sets the Vat Id for the product.
        /// </summary>
        /// <value>
        /// The Vat Id.
        /// </value>
        [Display(Name = nameof(Properties.Vat), ResourceType = typeof(Properties))]
        public string PricelistId
        {
            set { SetProperty(ref _vatId, value); }
            get { return _vatId; }
        }
    }
}