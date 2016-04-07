using System;
using System.Collections.Generic;
using System.Text;

namespace Amica.vNext.Models.Documents
{
    public class Invoice : Document
    {
        public Invoice() : base()
        {
            Type = DocumentHelpers.Types[DocumentType.Invoice];
        }
    }
}
