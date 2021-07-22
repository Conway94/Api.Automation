using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Registration.Personal
{
  public class Personal : CoreInterface
  {
    public void ClickGenderToggle(string elementId = "id_gender1")
    {
      Client.Actions.Click.ElementId(elementId);
    }

    public void EnterFirstName(string firstName, string elementId = "customer_firstname")
    {
      Client.Actions.Text.Insert(elementId, firstName);
    }

    public void EnterLastName(string lastName, string elementId = "customer_lastname")
    {
      Client.Actions.Text.Insert(elementId, lastName);
    }

    public void EnterPassword(string password, string elementId = "passwd")
    {
      Client.Actions.Text.Insert(elementId, password);
    }

    public void EnterDateOfBirthDay(string day, string toggleElementId = "uniform-days", string dayElementId = "days")
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(dayElementId, day);
    }

    public void EnterDateOfBirthMonth(string month, string toggleElementId = "uniform-months", string monthElementId = "months")
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(monthElementId, month);
    }

    public void EnterDateOfBirthYear(string year, string toggleElementId = "uniform-years", string yearElementId = "years")
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(yearElementId, year);
    }

    public void ClickNewsLetterToggle(string elementId = "newsletter")
    {
      Client.Actions.Click.ElementId(elementId);
    }

    public void ClickSpecialOfferToggle(string elementId = "uniform-optin")
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
