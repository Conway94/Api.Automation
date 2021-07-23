using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Actions.Launch
{
  public class LaunchAction : CoreInterface
  {
    public void Url(string launchUrl)
    {
      Client.Actions.Launch.Execute(launchUrl);
    }
  }
}
