using Com.TestData.ConwayOsler.Actions;

namespace Com.TestData.ConwayOsler.Interface.Actions.Select
{
  public class Select
  {
    public void ElementId(string elementId, string selectValue)
    {
      new SelectAction().DropDownSelect(elementId, selectValue);
    }
  }
}
