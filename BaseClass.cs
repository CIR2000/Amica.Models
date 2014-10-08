using System;

namespace Amica.vNext.Objects
{
    public abstract class BaseClass
    {
        public string Id { get; set; }
        public string ETag { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
    }
}
