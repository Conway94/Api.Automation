using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.SignIn
{
  public class SignIn : CoreInterface
  {
    public void EnterEmailAddress(string userEmail, string elementId = "email_create")
    {
      Client.Actions.Text.Insert(elementId, userEmail);
    }

    public void SubmitCreateAccount(string elementId = "SubmitCreate")
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
