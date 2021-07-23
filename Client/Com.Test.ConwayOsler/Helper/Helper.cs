using Com.Test.ConwayOsler.Helper;
using Com.TestData.ConwayOsler.Interface;
using NUnit.Framework;

namespace Com.Test.ConwayOsler.Helper
{
  public class Helper
  {
    public static WebsiteInterface Website = new WebsiteInterface();
  }
}

public class OneTimeTearDown  : Helper
{
  [OneTimeTearDown]
  public void TearDown()
  {
   // Website.Quit.Execute();
  }
}
