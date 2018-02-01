using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amica.Models;
using Amica.Models.Documents;
using Newtonsoft.Json;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Amica.Models.Company.Company();
            var x = new Contact();

            //var d = new Invoice();
            //var d = new Invoice
            //{
            //    Contact =
            //    {
            //        Name = "contact name",
            //    }
            //};
            //d.Items.Add(new DocumentItem {Sku = "sku", Description = "description"});

            //string output = JsonConvert.SerializeObject(d);
            //Console.WriteLine(i.Category.Description);

        }
    }
}
