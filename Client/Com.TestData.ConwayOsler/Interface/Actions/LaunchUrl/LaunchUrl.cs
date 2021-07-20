using Com.TestData.ConwayOsler.Actions;
using OpenQA.Selenium;

namespace Com.TestData.ConwayOsler.Interface.Actions.LaunchUrl
{
  public class LaunchUrl
  {
    public void Execute(string websiteLink)
    {
      new LaunchAction().Chrome(websiteLink);
    }
  }
}
