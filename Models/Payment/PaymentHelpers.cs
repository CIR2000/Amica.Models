using Amica.Models.Resources;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Amica.Models
{
    /// <summary>
    /// Payment helpers.
    /// </summary>
    public class PaymentHelpers
    {
        // by convention, item with key 1 is the default value

        /// <summary>
        /// The first payment options
        /// </summary>
        public static readonly ReadOnlyDictionary<PaymentOption, FirstPaymentOption> FirstPaymentOptions = 
			new ReadOnlyDictionary<PaymentOption, FirstPaymentOption>(
				new Dictionary<PaymentOption, FirstPaymentOption>
				{
                    { PaymentOption.Normal, new FirstPaymentOption { Option = PaymentOption.Normal, Description = PaymentResources.Normal }},
					{ PaymentOption.VatIncluded, new FirstPaymentOption { Option = PaymentOption.VatIncluded, Description =  PaymentResources.VatIncluded }},
					{ PaymentOption.VatOnly, new FirstPaymentOption { Option = PaymentOption.VatOnly, Description = PaymentResources.VatOnly }},
					{ PaymentOption.FeesIncluded, new FirstPaymentOption { Option = PaymentOption.FeesIncluded, Description = PaymentResources.FeesIncluded }},
				});

        /// <summary>
        /// The first payment date options
        /// </summary>
        public static readonly ReadOnlyDictionary<PaymentDate, FirstPaymentDate> FirstPaymentDates = 
			new ReadOnlyDictionary<PaymentDate,  FirstPaymentDate>(
                new Dictionary<PaymentDate,  FirstPaymentDate>
                {
					{ PaymentDate.DocumentDate, new FirstPaymentDate { Option = PaymentDate.DocumentDate, Description = PaymentResources.AtDocumentDate }},
					{ PaymentDate.EndOfMonth, new FirstPaymentDate { Option = PaymentDate.EndOfMonth, Description = PaymentResources.AtEndOfMonth }},
					{ PaymentDate.Explicit, new FirstPaymentDate { Option = PaymentDate.Explicit, Description = PaymentResources.AtExplicitDate }},
                });

        /// <summary>
        /// Supported payment methods
        /// </summary>
        public static readonly ReadOnlyCollection<PaymentMethod> PaymentMethods =
            new ReadOnlyCollection<PaymentMethod>(
                new List<PaymentMethod>
                {
                    new PaymentMethod {Name = ItalianPA.MP01, Code = "MP01" },
                    new PaymentMethod {Name = ItalianPA.MP02, Code = "MP02" },
                    new PaymentMethod {Name = ItalianPA.MP03, Code = "MP03" },
                    new PaymentMethod {Name = ItalianPA.MP04, Code = "MP04" },
                    new PaymentMethod {Name = ItalianPA.MP05, Code = "MP05" },
                    new PaymentMethod {Name = ItalianPA.MP06, Code = "MP06" },
                    new PaymentMethod {Name = ItalianPA.MP07, Code = "MP07" },
                    new PaymentMethod {Name = ItalianPA.MP08, Code = "MP08" },
                    new PaymentMethod {Name = ItalianPA.MP09, Code = "MP09" },
                    new PaymentMethod {Name = ItalianPA.MP10, Code = "MP10" },
                    new PaymentMethod {Name = ItalianPA.MP11, Code = "MP11" },
                    new PaymentMethod {Name = ItalianPA.MP12, Code = "MP12", IsBankReceipt=true },
                    new PaymentMethod {Name = ItalianPA.MP13, Code = "MP13" },
                    new PaymentMethod {Name = ItalianPA.MP14, Code = "MP14" },
                    new PaymentMethod {Name = ItalianPA.MP15, Code = "MP15" },
                    new PaymentMethod {Name = ItalianPA.MP16, Code = "MP16" },
                    new PaymentMethod {Name = ItalianPA.MP17, Code = "MP17" },
                    new PaymentMethod {Name = ItalianPA.MP18, Code = "MP18" },
                    new PaymentMethod {Name = ItalianPA.MP19, Code = "MP19" },
                    new PaymentMethod {Name = ItalianPA.MP20, Code = "MP20" },
                    new PaymentMethod {Name = ItalianPA.MP21, Code = "MP21" },
                    new PaymentMethod {Name = ItalianPA.MP22, Code = "MP22" },
                });

    }
}
