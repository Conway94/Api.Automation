using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Shopping.TShirts
{
  public class TShirts : CoreInterface
  {
    public void ClickFadedShortSleeveTShirt(string elementClass = "product-container")
    {
      Client.Actions.Click.ElementClass(elementClass);
    }

    public void ClickColor(string elementId = "color_14")
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
