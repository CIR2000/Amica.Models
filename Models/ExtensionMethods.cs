using System;
using System.Collections.Generic;

namespace Amica.Models
{
    /// <summary>
    /// Dictionary extension and helper methods.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Gets the value or default.
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="dict">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static V GetValueOrDefault<K, V>(this IDictionary<K, V> dict, K key)
		{
			return dict.GetValueOrDefault(key, default(V));
		}

        /// <summary>
        /// Gets the value or default.
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="dict">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <param name="defVal">The definition value.</param>
        /// <returns></returns>
        public static V GetValueOrDefault<K, V>(this IDictionary<K, V> dict, K key, V defVal)
		{
			return dict.GetValueOrDefault(key, () => defVal);
		}

        /// <summary>
        /// Gets the value or default.
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="dict">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <param name="defValSelector">The definition value selector.</param>
        /// <returns></returns>
        public static V GetValueOrDefault<K, V>(this IDictionary<K, V> dict, K key, Func<V> defValSelector)
		{
            return dict.TryGetValue(key, out V value) ? value : defValSelector();
        }
    }
}
