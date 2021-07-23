using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Registration.Personal
{
  public class Personal : CoreInterface
  {
    private const string _genderMaleRadio = "id_gender1";
    private const string _firstNameField = "customer_firstname";
    private const string _lastNameField = "customer_lastname";
    private const string _passwordField = "passwd";
    private const string _daysDropDown = "uniform-days";
    private const string _daysField = "days";
    private const string _monthsDropDown = "uniform-months";
    private const string _monthsField = "months";
    private const string _yearsDropDown = "uniform-years";
    private const string _yearsField = "years";
    private const string _newsletterCheckBox = "newsletter";
    private const string _specialOfferCheckBox = "uniform-optin";
    
    public void ClickGenderToggle(string elementId = _genderMaleRadio)
    {
      Client.Actions.Click.ElementId(elementId);
    }

    public void EnterFirstName(string firstName, string elementId = _firstNameField)
    {
      Client.Actions.Text.InsertId(elementId, firstName);
    }

    public void EnterLastName(string lastName, string elementId = _lastNameField)
    {
      Client.Actions.Text.InsertId(elementId, lastName);
    }

    public void EnterPassword(string password, string elementId = _passwordField)
    {
      Client.Actions.Text.InsertId(elementId, password);
    }

    public void EnterDateOfBirthDay(string day, string toggleElementId = _daysDropDown, string dayElementId = _daysField)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(dayElementId, day);
    }

    public void EnterDateOfBirthMonth(string month, string toggleElementId = _monthsDropDown, string monthElementId = _monthsField)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(monthElementId, month);
    }

    public void EnterDateOfBirthYear(string year, string toggleElementId = _yearsDropDown, string yearElementId = _yearsField)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(yearElementId, year);
    }

    public void ClickNewsLetterToggle(string elementId = _newsletterCheckBox)
    {
      Client.Actions.Click.ElementId(elementId);
    }

    public void ClickSpecialOfferToggle(string elementId = _specialOfferCheckBox)
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
