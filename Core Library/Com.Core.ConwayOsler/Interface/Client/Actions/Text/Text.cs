using Com.Core.ConwayOsler.Handlers.Client.Actions;

namespace Com.Core.ConwayOsler.Interface.Client.Actions.Text
{
  public class Text
  {
    public void InsertId(string elementId, string inputText)
    {
      new TextAction().InsertTextIntoIdField(elementId, inputText);
    }

    public void InsertCss(string cssSelector, string inputText)
    {
      new TextAction().InsertTextIntoCssField(cssSelector, inputText);
    }

    public void ValidateId(string elementId, string text)
    {
      new TextAction().ValidateTextId(elementId, text);
    }

    public void ValidateClass(string elementClass, string text)
    {
      new TextAction().ValidateTextClass(elementClass, text);
    }

    public void ValidateCssSelector(string cssSelector, string text)
    {
      new TextAction().ValidateTextCssSelector(cssSelector, text);
    }
  }
}
