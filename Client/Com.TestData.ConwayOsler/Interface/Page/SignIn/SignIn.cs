using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.SignIn
{
  public class SignIn : CoreInterface
  {
    private const string _emailAddressField = "email_create";
    private const string _createAccountButton = "SubmitCreate";

    public void EnterEmailAddress(string userEmail, string elementId = _emailAddressField)
    {
      Client.Actions.Text.InsertId(elementId, userEmail);
    }

    public void SubmitCreateAccount(string elementId = _createAccountButton)
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
