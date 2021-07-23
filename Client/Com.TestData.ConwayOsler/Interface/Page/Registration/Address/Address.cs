using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Registration.Address
{
  public class Address : CoreInterface
  {
    private const string _firstName = "firstname";
    private const string _lastName = "lastname";
    private const string _company = "company";
    private const string _address1 = "address1";
    private const string _address2 = "address2";
    private const string _city = "city";
    private const string _stateDropDown = "uniform-id_state";
    private const string _state = "id_state";
    private const string _postCode = "postcode";
    private const string _countryDropDown = "uniform-id_country";
    private const string _country = "id_country";
    private const string _other = "other";
    private const string _phone = "phone";
    private const string _phone_mobile = "phone_mobile";
    private const string _alias = "alias";

    public void EnterFirstName(string firstName, string elementId = _firstName)
    {
      Client.Actions.Text.InsertId(elementId, firstName);
    }

    public void EnterLastName(string lastName, string elementId = _lastName)
    {
      Client.Actions.Text.InsertId(elementId, lastName);
    }

    public void EnterCompany(string company, string elementId = _company)
    {
      Client.Actions.Text.InsertId(elementId, company);
    }

    public void EnterAddressField1(string addressField1, string elementId = _address1)
    {
      Client.Actions.Text.InsertId(elementId, addressField1);
    }

    public void EnterAddressField2(string addressField2, string elementId = _address2)
    {
      Client.Actions.Text.InsertId(elementId, addressField2);
    }

    public void EnterCity(string city, string elementId = _city)
    {
      Client.Actions.Text.InsertId(elementId, city);
    }

    public void EnterState(string state, string toggleElementId = _stateDropDown, string stateElementId = _state)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(stateElementId, state);
    }

    public void EnterPostCode(string postCode, string elementId = _postCode)
    {
      Client.Actions.Text.InsertId(elementId, postCode);
    }

    public void EnterCountry(string country, string toggleElementId = _countryDropDown, string countryElementId = _country)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(countryElementId, country);
    }

    public void EnterOtherInfo(string otherInfo, string elementId = _other)
    {
      Client.Actions.Text.InsertId(elementId, otherInfo);
    }

    public void EnterPhoneNumber(string phoneNumber, string elementId = _phone)
    {
      Client.Actions.Text.InsertId(elementId, phoneNumber);
    }

    public void EnterMobileNumber(string mobileNumber, string elementId = _phone_mobile)
    {
      Client.Actions.Text.InsertId(elementId, mobileNumber);
    }

    public void EnterAlias(string alias, string elementId = _alias)
    {
      Client.Actions.Text.InsertId(elementId, alias);
    }
  }
}
