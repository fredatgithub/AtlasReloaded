using System;
using Ritter.Atlas;

namespace UsageConsole
{
  class Program
  {
    static void Main()
    {
      Action<string> Display = s => Console.WriteLine(s);
      var zipcode = new ZipCode { Id = "17011" };
      var zipcode2 = new ZipCode { Id = "90210" };
      var zipcode3 = new ZipCode { Id = "75017" };
      var zipcode4 = new ZipCode { Id = "75020" };
      Console.ReadKey();
    }
  }
}