using Com.Core.ConwayOsler.Handlers.Client.Actions;

namespace Com.Core.ConwayOsler.Interface.Client.Actions.Launch
{
  public class Launch
  {
    public void Execute(string launchUrl)
    {
      new LaunchAction().Chrome(launchUrl);
    }
  }
}
