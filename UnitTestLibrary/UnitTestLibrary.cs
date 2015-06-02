using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ritter.Atlas;
namespace UnitTestLibrary
{
  [TestClass]
  public class UnitTestLibrary
  {
    [TestMethod]
    public void TestMethod_derived_zip_code()
    {
      var zipcode = new ZipCode { Id = "17011" };
      Assert.AreEqual("170", zipcode.ScfCode);
    }
  }
}