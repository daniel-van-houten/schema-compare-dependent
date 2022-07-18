using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DatabaseDependentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contextOptions = new DbContextOptionsBuilder<GuitarsDbContext>().UseNpgsql("Server=localhost; Port=5438; Database=example; User ID=postgres; Password=postgres");
            var guitarContext = new GuitarsDbContext(contextOptions.Options);

            // Test Db Access

            var guitars = guitarContext.Guitars;

            guitars.ToList().ForEach(Console.WriteLine);
        }
    }
}
