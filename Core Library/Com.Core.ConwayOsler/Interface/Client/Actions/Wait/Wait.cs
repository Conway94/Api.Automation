using Com.Core.ConwayOsler.Handlers.Client.Actions;

namespace Com.Core.ConwayOsler.Interface.Client.Actions.Wait
{
  public class Wait
  {
    public void ForElementId(string elementId)
    {
      new WaitAction().ForElementId(elementId);
    }

    public void ForClassName(string className)
    {
      new WaitAction().ForClassName(className);
    }
  }
}
