using Com.TestData.ConwayOsler.Actions;

namespace Com.TestData.ConwayOsler.Interface.Actions.Click
{
  public class Click
  {
    public void ElementClass(string elementClass)
    {
      new ClickAction().ClickElementClass(elementClass);
    }

    public void ElementId(string elementId)
    {
      new ClickAction().ClickElementId(elementId);
    }
  }
}
