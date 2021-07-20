using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.TestData.ConwayOsler.Helper
{
  public class SeleniumHelper
  {
    private readonly string _disableInfoBars = "--disable-infobars";
    private static ChromeOptions options = new ChromeOptions();
    private static ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();

    public static IWebDriver Driver;

    public void ChromeWebDriver()
    {
      Driver = new ChromeDriver(driverService, options);
      options.AddArguments(_disableInfoBars);
      driverService.HideCommandPromptWindow = true;
    }
  }
}
