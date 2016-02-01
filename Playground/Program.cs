using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amica.vNext.Models;
using Newtonsoft.Json;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Document();
            d.Contact.Name = "contact name";
            d.Contact.Vat = "vat";
            d.Items.Add(new DocumentItem {Sku = "sku", Description = "description"});
            d.Date = DateTime.Now;

            string output = JsonConvert.SerializeObject(d);
            Console.Write(output);

        }
    }
}
