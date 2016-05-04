using System;
using System.Collections.Generic;
using System.Text;
using Amica.vNext.Models.Documents;

namespace Amica.vNext.Models
{
	public class Factory<T>
    {
		static readonly Dictionary<Type, Func<T>> _dict 
			 = new Dictionary<Type, Func<T>>();

		public static T Create()
        {
			// Assume there type T has been registered.
            return Create(typeof(T));
        }
		public  static T Create(Type derivedType)
		{
			Func<T> constructor = null;
			if (_dict.TryGetValue(derivedType, out constructor))
				return constructor();

			throw new ArgumentException($"No type registered for type {typeof(T).Name}");
		}


		public static void Register(Type derviedType, Func<T> ctor)
		{
			_dict.Add(derviedType, ctor);
		}
	}
}
