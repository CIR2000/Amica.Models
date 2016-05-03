using System;
using System.Collections.Generic;
using System.Text;
using Amica.vNext.Models.Documents;

namespace Amica.vNext.Models
{
    public class ObjectFactory
    {
        public static Document CreateDocument(DocumentCategory category)
        {
			switch (category)
            {
                case DocumentCategory.Invoice:
                    return new Invoice();
                default:
                    throw new ArgumentException(nameof(category));
            }
        }
		public static Vat CreateVat()
        {
            return new Vat();
        }
    }

	//public class Factory<T>
 //   {
	//	static Factory()
 //       {
 //           Factory<Vat>.Register(typeof(Vat), () => new Vat());
 //           Factory<Invoice>.Register(typeof(Invoice), () => new Invoice());
 //       }

	//	static readonly Dictionary<Type, Func<T>> _dict 
	//		 = new Dictionary<Type, Func<T>>();

	//	public static T Create()
	//	{
	//		Func<T> constructor = null;
	//		if (_dict.TryGetValue(typeof(T), out constructor))
	//			return constructor();

	//		throw new ArgumentException("No type registered for this id");
	//	}

	//	private static void Register(Type type, Func<T> ctor)
	//	{
	//		_dict.Add(type, ctor);
	//	}
	//}
}
