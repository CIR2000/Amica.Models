using System;
using System.Collections.Generic;
using System.Text;

namespace Amica.vNext.Models.Documents
{
	internal class ObjectIdGenerator 
	{
		private static readonly Random _random = new Random();

		public static string GenerateId()
		{
			var sinceEpoch = (DateTime.UtcNow - new DateTime(1970,1,1)).TotalSeconds;
			var machine = _random.Next(0, 16777215);
			var pid = (short)_random.Next(0, 32768);
			var increment = _random.Next(0, 16777215);

			return $"{sinceEpoch.ToString()}{machine.ToString()}{pid.ToString()}{increment.ToString()}";
		}
	}
}
