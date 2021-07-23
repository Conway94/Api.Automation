using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Registration
{
  public class Registration : CoreInterface
  {
    private const string _registrationPage = "account-creation_form";
    private const string _submitForm = "submitAccount";
    
    public Address.Address Address = new Address.Address();
    public Personal.Personal Personal = new Personal.Personal();

    public void WaitForRegistrationForm(string elementId = _registrationPage)
    {
      Client.Actions.Wait.ForElementId(elementId);
    }

    public void SubmitRegistrationForm(string elementId = _submitForm)
    {
      Client.Actions.Click.ElementId(elementId);
    }
  }
}
