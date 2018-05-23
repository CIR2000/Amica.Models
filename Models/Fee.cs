using Amica.Models.Resources;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// Fee information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    /// <seealso cref="Amica.Models.IUniqueId" />
    public class Fee : BaseModelWithCompanyId, IUniqueId
    {
        private string _name;
        private decimal _amount;
        private PropertyModels.Vat _vat;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = nameof(Properties.Name), ResourceType =typeof(Properties))]
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        [Display(Name = nameof(Properties.Amount), ResourceType =typeof(Properties))]
        public decimal Amount
        {
            set { SetProperty(ref _amount, value); }
            get { return _amount; }
        }

        /// <summary>
        /// Gets or sets the VAT.
        /// </summary>
        /// <value>
        /// The VAT.
        /// </value>
        [Display(Name = nameof(Properties.Vat), ResourceType =typeof(Properties))]
        public PropertyModels.Vat Vat
        {
            set { SetProperty(ref _vat, value); }
            get { return _vat; }
        }
    }
}
