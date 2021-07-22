using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Registration.Address
{
  public class Address : CoreInterface
  {
    public void EnterFirstName(string firstName, string elementId = "firstname")
    {
      Client.Actions.Text.Insert(elementId, firstName);
    }

    public void EnterLastName(string lastName, string elementId = "lastname")
    {
      Client.Actions.Text.Insert(elementId, lastName);
    }

    public void EnterCompany(string company, string elementId = "company")
    {
      Client.Actions.Text.Insert(elementId, company);
    }

    public void EnterAddressField1(string addressField1, string elementId = "address1")
    {
      Client.Actions.Text.Insert(elementId, addressField1);
    }

    public void EnterAddressField2(string addressField2, string elementId = "address2")
    {
      Client.Actions.Text.Insert(elementId, addressField2);
    }

    public void EnterCity(string city, string elementId = "city")
    {
      Client.Actions.Text.Insert(elementId, city);
    }

    public void EnterState(string state, string toggleElementId = "uniform-id_state", string stateElementId = "id_state")
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(stateElementId, state);
    }

    public void EnterPostCode(string postCode, string elementId = "postcode")
    {
      Client.Actions.Text.Insert(elementId, postCode);
    }

    public void EnterCountry(string country, string toggleElementId = "uniform-id_country", string countryElementId = "id_country")
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(countryElementId, country);
    }

    public void EnterOtherInfo(string postCode, string elementId = "other")
    {
      Client.Actions.Text.Insert(elementId, postCode);
    }

    public void EnterPhoneNumber(string postCode, string elementId = "phone")
    {
      Client.Actions.Text.Insert(elementId, postCode);
    }

    public void EnterMobileNumber(string postCode, string elementId = "phone_mobile")
    {
      Client.Actions.Text.Insert(elementId, postCode);
    }

    public void EnterAlias(string postCode, string elementId = "alias")
    {
      Client.Actions.Text.Insert(elementId, postCode);
    }
  }
}
