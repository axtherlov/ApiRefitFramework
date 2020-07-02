using System;
using System.Collections.Generic;

namespace ApiFramework.Tests.Model.Generators
{
    public class LaptopFactory
    {
        public Laptop CreateLaptop()
        {
            var random = new Random();
            var laptop = new Laptop()
            {
                Id = random.Next(1000),
                BrandName = "Sample Brand Name",
                LaptopName = "Sample Laptop Name",
                Features = new Features()
            };

            laptop.Features.Feature = new List<string>()
            {
                ("Sample feature 1"),
                ("Sample feature 2")
            };

            return laptop;
        }
    }
}
