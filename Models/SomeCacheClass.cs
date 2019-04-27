using System;

namespace DemoISPSessionCore.Models
{
    [Serializable]
    public class SomeCacheClass
    {
        public string SomeString { get; set; }
        public DateTimeOffset SomeDate { get; set; }
    }
}
