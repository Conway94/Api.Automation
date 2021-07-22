using Com.Core.ConwayOsler.Handlers.Client.Actions;

namespace Com.Core.ConwayOsler.Interface.Client.Actions.Click
{
  public class Click
  {
    public void ElementClass(string elementClass)
    {
      new ClickAction().ClickElementClass(elementClass);
    }

    public void ElementClass(string elementClass, string title)
    {
      new ClickAction().ClickElementClass(elementClass, title);
    }

    public void ElementId(string elementId)
    {
      new ClickAction().ClickElementId(elementId);
    }

    public void ElementXpath(string xpath)
    {
      new ClickAction().ClickElementXpath(xpath);
    }
  }
}
