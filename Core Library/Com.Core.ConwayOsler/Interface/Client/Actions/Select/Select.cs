using Com.Core.ConwayOsler.Handlers.Client.Actions;

namespace Com.Core.ConwayOsler.Interface.Client.Actions.Select
{
  public class Select
  {
    public void ElementId(string elementId, string selectValue)
    {
      new SelectAction().DropDownSelect(elementId, selectValue);
    }
  }
}
