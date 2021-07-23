using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Shopping.TShirts
{
  public class TShirts : CoreInterface
  {
    private const string _fadedShortSleeveShirt = "product-container";
    private const string _colorOptionBlue = "color_14";

    public void ClickFadedShortSleeveTShirt(string elementClass = _fadedShortSleeveShirt)
    {
      Client.Actions.Click.ElementClass(elementClass);
    }

    public void ClickColor(string elementId = _colorOptionBlue)
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
