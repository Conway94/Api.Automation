using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Registration.Personal
{
  public class Personal : CoreInterface
  {
    private const string _genderMale = "id_gender1";
    private const string _firstName = "customer_firstname";
    private const string _lastName = "customer_lastname";
    private const string _password = "passwd";
    private const string _daysDropDown = "uniform-days";
    private const string _days = "days";
    private const string _monthsDropDown = "uniform-months";
    private const string _months = "months";
    private const string _yearsDropDown = "uniform-years";
    private const string _years = "years";
    private const string _newsletter = "newsletter";
    private const string _specialOffer = "uniform-optin";
    
    public void ClickGenderToggle(string elementId = _genderMale)
    {
      Client.Actions.Click.ElementId(elementId);
    }

    public void EnterFirstName(string firstName, string elementId = _firstName)
    {
      Client.Actions.Text.InsertId(elementId, firstName);
    }

    public void EnterLastName(string lastName, string elementId = _lastName)
    {
      Client.Actions.Text.InsertId(elementId, lastName);
    }

    public void EnterPassword(string password, string elementId = _password)
    {
      Client.Actions.Text.InsertId(elementId, password);
    }

    public void EnterDateOfBirthDay(string day, string toggleElementId = _daysDropDown, string dayElementId = _days)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(dayElementId, day);
    }

    public void EnterDateOfBirthMonth(string month, string toggleElementId = _monthsDropDown, string monthElementId = _months)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(monthElementId, month);
    }

    public void EnterDateOfBirthYear(string year, string toggleElementId = _yearsDropDown, string yearElementId = _years)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(yearElementId, year);
    }

    public void ClickNewsLetterToggle(string elementId = _newsletter)
    {
      Client.Actions.Click.ElementId(elementId);
    }

    public void ClickSpecialOfferToggle(string elementId = _specialOffer)
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
