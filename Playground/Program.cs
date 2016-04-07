using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amica.vNext.Models;
using Amica.vNext.Models.Documents;
using Newtonsoft.Json;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = Amica.vNext.Models.ItalianPA.PAHelpers.NaturaPA;
            //var d = new Invoice
            //{
            //    Contact =
            //    {
            //        Name = "contact name",
            //    }
            //};
            //d.Items.Add(new DocumentItem {Sku = "sku", Description = "description"});

            //string output = JsonConvert.SerializeObject(d);
            Console.Write(v.Count);

        }
    }
}
