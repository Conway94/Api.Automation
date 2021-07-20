using Com.TestData.ConwayOsler.Actions;

namespace Com.TestData.ConwayOsler.Interface.Actions.WaitFor
{
  public class WaitFor
  {
    public void ElementId(string elementId)
    {
      new WaitForAction().ElementId(elementId);
    }
  }
}
