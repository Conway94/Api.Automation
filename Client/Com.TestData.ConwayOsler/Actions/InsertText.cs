using Com.TestData.ConwayOsler.Helper;
using OpenQA.Selenium;
using System;

namespace Com.TestData.ConwayOsler.Actions
{
  public class InsertTextAction : SeleniumHelper
  {
    public void InsertTextIntoIdField(string elememtId,string inputText)
    {
      try
      {
        IWebElement field = Driver.FindElement(By.Id(elememtId));
        field.SendKeys(inputText);
        field.SendKeys(Keys.Tab);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
    }
  }
}
