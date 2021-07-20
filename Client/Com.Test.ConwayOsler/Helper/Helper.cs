using Com.TestData.ConwayOsler.Helper;
using Com.TestData.ConwayOsler.Interface;
using NUnit.Framework;

namespace Com.Test.ConwayOsler.Helper
{
  public class Helper
  {
    public static AutomationPractice AutomationPractice = new AutomationPractice();
  }
}

public class OneTimeTearDown
{
  [OneTimeTearDown]
  public void TearDown()
  {
    SeleniumHelper.Driver.Quit();
  }
}
