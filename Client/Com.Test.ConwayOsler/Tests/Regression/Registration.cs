using NUnit.Framework;

namespace Com.Test.ConwayOsler.Tests.Regression
{
  [Order(0)]
  [TestFixture]
  public class Registration : Helper.Helper
  {
    [TestCase(Description = "Valid Registration")]
    public void ValidRegistration()
    {
      //Home Page
      AutomationPractice.Actions.LaunchUrl.Execute("http://automationpractice.com/index.php");
      AutomationPractice.Actions.Click.ElementClass("login");

      //Sign-In Page
      AutomationPractice.Actions.Text.Insert("email_create","Joey1@gmail.com");
      AutomationPractice.Actions.Click.ElementId("SubmitCreate");

      //User Details
      AutomationPractice.Actions.WaitFor.ElementId("account-creation_form");
      AutomationPractice.Actions.Click.ElementId("id_gender1");
      AutomationPractice.Actions.Text.Insert("customer_firstname", "Joe");
      AutomationPractice.Actions.Text.Insert("customer_lastname", "Ghetto");
      AutomationPractice.Actions.Text.Insert("passwd", "FoodIsLife");

      //Date of Birth
      AutomationPractice.Actions.Click.ElementId("uniform-days");
      AutomationPractice.Actions.Select.ElementId("days", "9");
      AutomationPractice.Actions.Click.ElementId("uniform-months");
      AutomationPractice.Actions.Select.ElementId("months", "March");
      AutomationPractice.Actions.Click.ElementId("uniform-years");
      AutomationPractice.Actions.Select.ElementId("years", "1987");

      //News Letter
      AutomationPractice.Actions.Click.ElementId("newsletter");

      //Special Offer Notice
      AutomationPractice.Actions.Click.ElementId("uniform-optin");

      //Address Details
      AutomationPractice.Actions.Text.Insert("firstname", "Joe");
      AutomationPractice.Actions.Text.Insert("lastname", "Ghetto");
      AutomationPractice.Actions.Text.Insert("company", "Impractical Jokers");
      AutomationPractice.Actions.Text.Insert("address1", "Somewhere");
      AutomationPractice.Actions.Text.Insert("address2", "Else");
      AutomationPractice.Actions.Text.Insert("city", "California");
      AutomationPractice.Actions.Click.ElementId("uniform-id_state");
      AutomationPractice.Actions.Select.ElementId("id_state", "Hawaii");
      AutomationPractice.Actions.Text.Insert("postcode", "12345");
      AutomationPractice.Actions.Click.ElementId("uniform-id_country");
      AutomationPractice.Actions.Select.ElementId("id_country", "United States");
      AutomationPractice.Actions.Text.Insert("other", "N/A");
      AutomationPractice.Actions.Text.Insert("phone", "0315556351");
      AutomationPractice.Actions.Text.Insert("phone_mobile", "0839994565");
      AutomationPractice.Actions.Text.Insert("alias", "Joey");


      //Submit Registration Form
      AutomationPractice.Actions.Click.ElementId("submitAccount");

      // TODO : Create Classes seperated by webpage / requirements
      // TODO : All other functions to use Login instead of Register
      
    }
  }
}
