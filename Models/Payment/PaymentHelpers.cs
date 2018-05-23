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
                    new PaymentMethod {Name = ItalianPA.MP01, PublicAdministrationCode = "MP01" },
                    new PaymentMethod {Name = ItalianPA.MP02, PublicAdministrationCode = "MP02" },
                    new PaymentMethod {Name = ItalianPA.MP03, PublicAdministrationCode = "MP03" },
                    new PaymentMethod {Name = ItalianPA.MP04, PublicAdministrationCode = "MP04" },
                    new PaymentMethod {Name = ItalianPA.MP05, PublicAdministrationCode = "MP05" },
                    new PaymentMethod {Name = ItalianPA.MP06, PublicAdministrationCode = "MP06" },
                    new PaymentMethod {Name = ItalianPA.MP07, PublicAdministrationCode = "MP07" },
                    new PaymentMethod {Name = ItalianPA.MP08, PublicAdministrationCode = "MP08" },
                    new PaymentMethod {Name = ItalianPA.MP09, PublicAdministrationCode = "MP09" },
                    new PaymentMethod {Name = ItalianPA.MP10, PublicAdministrationCode = "MP10" },
                    new PaymentMethod {Name = ItalianPA.MP11, PublicAdministrationCode = "MP11" },
                    new PaymentMethod {Name = ItalianPA.MP12, PublicAdministrationCode = "MP12", IsBankReceipt=true },
                    new PaymentMethod {Name = ItalianPA.MP13, PublicAdministrationCode = "MP13" },
                    new PaymentMethod {Name = ItalianPA.MP14, PublicAdministrationCode = "MP14" },
                    new PaymentMethod {Name = ItalianPA.MP15, PublicAdministrationCode = "MP15" },
                    new PaymentMethod {Name = ItalianPA.MP16, PublicAdministrationCode = "MP16" },
                    new PaymentMethod {Name = ItalianPA.MP17, PublicAdministrationCode = "MP17" },
                    new PaymentMethod {Name = ItalianPA.MP18, PublicAdministrationCode = "MP18" },
                    new PaymentMethod {Name = ItalianPA.MP19, PublicAdministrationCode = "MP19" },
                    new PaymentMethod {Name = ItalianPA.MP20, PublicAdministrationCode = "MP20" },
                    new PaymentMethod {Name = ItalianPA.MP21, PublicAdministrationCode = "MP21" },
                    new PaymentMethod {Name = ItalianPA.MP22, PublicAdministrationCode = "MP22" },
                });

    }
}
