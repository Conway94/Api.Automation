using Com.Core.ConwayOsler.Handlers.Client.Helper;

namespace Com.TestData.ConwayOsler.Interface.Quit
{
  public class Quit
  {
    public void Execute()
    {
      SeleniumHelper.Driver.Quit();
    }
  }
}
