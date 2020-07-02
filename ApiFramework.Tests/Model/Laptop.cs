using System.Collections.Generic;

namespace ApiFramework.Tests.Model
{
    public class Laptop
    {
        public string BrandName { get; set; }
        public Features Features { get; set; }
        public int Id { get; set; }
        public string LaptopName { get; set; }
    }

    public class Features
    {
        public List<string> Feature { get; set; }
    }
}
