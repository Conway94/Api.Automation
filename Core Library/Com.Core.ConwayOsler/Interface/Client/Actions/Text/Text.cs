using Com.Core.ConwayOsler.Handlers.Client.Actions;

namespace Com.Core.ConwayOsler.Interface.Client.Actions.Text
{
  public class Text
  {
    public void Insert(string elementId, string inputText)
    {
      new TextAction().InsertTextIntoIdField(elementId, inputText);
    }

    public void ValidateId(string elementId, string text)
    {
      new TextAction().ValidateTextId(elementId, text);
    }

    public void ValidateClass(string elementClass, string text)
    {
      new TextAction().ValidateTextClass(elementClass, text);
    }
  }
}
