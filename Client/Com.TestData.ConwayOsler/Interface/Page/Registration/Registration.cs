using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Registration
{
  public class Registration : CoreInterface
  {
    public Address.Address Address = new Address.Address();
    public Personal.Personal Personal = new Personal.Personal();

    public void WaitForRegistrationForm(string elementId = "account-creation_form")
    {
      Client.Actions.Wait.ForElementId(elementId);
    }

    public void SubmitRegistrationForm(string elementId = "submitAccount")
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
