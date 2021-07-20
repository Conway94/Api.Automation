using Com.TestData.ConwayOsler.Actions;

namespace Com.TestData.ConwayOsler.Interface.Actions.Text
{
  public class Text
  {
    public void Insert(string elementId, string inputText)
    {
      new InsertTextAction().InsertTextIntoIdField(elementId, inputText);
    }
  }
}
