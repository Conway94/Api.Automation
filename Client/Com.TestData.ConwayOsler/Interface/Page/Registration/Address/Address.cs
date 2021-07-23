using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Registration.Address
{
  public class Address : CoreInterface
  {
    private const string _firstNameField = "firstname";
    private const string _lastNameField = "lastname";
    private const string _companyField = "company";
    private const string _address1Field = "address1";
    private const string _address2Field = "address2";
    private const string _cityField = "city";
    private const string _stateDropDown = "uniform-id_state";
    private const string _stateField = "id_state";
    private const string _postCodeField = "postcode";
    private const string _countryDropDown = "uniform-id_country";
    private const string _countryField = "id_country";
    private const string _otherField = "other";
    private const string _phoneField = "phone";
    private const string _phone_mobileField = "phone_mobile";
    private const string _aliasField = "alias";

    public void EnterFirstName(string firstName, string elementId = _firstNameField)
    {
      Client.Actions.Text.InsertId(elementId, firstName);
    }

    public void EnterLastName(string lastName, string elementId = _lastNameField)
    {
      Client.Actions.Text.InsertId(elementId, lastName);
    }

    public void EnterCompany(string company, string elementId = _companyField)
    {
      Client.Actions.Text.InsertId(elementId, company);
    }

    public void EnterAddressField1(string addressField1, string elementId = _address1Field)
    {
      Client.Actions.Text.InsertId(elementId, addressField1);
    }

    public void EnterAddressField2(string addressField2, string elementId = _address2Field)
    {
      Client.Actions.Text.InsertId(elementId, addressField2);
    }

    public void EnterCity(string city, string elementId = _cityField)
    {
      Client.Actions.Text.InsertId(elementId, city);
    }

    public void EnterState(string state, string toggleElementId = _stateDropDown, string stateElementId = _stateField)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(stateElementId, state);
    }

    public void EnterPostCode(string postCode, string elementId = _postCodeField)
    {
      Client.Actions.Text.InsertId(elementId, postCode);
    }

    public void EnterCountry(string country, string toggleElementId = _countryDropDown, string countryElementId = _countryField)
    {
      Client.Actions.Click.ElementId(toggleElementId);
      Client.Actions.Select.ElementId(countryElementId, country);
    }

    public void EnterOtherInfo(string otherInfo, string elementId = _otherField)
    {
      Client.Actions.Text.InsertId(elementId, otherInfo);
    }

    public void EnterPhoneNumber(string phoneNumber, string elementId = _phoneField)
    {
      Client.Actions.Text.InsertId(elementId, phoneNumber);
    }

    public void EnterMobileNumber(string mobileNumber, string elementId = _phone_mobileField)
    {
      Client.Actions.Text.InsertId(elementId, mobileNumber);
    }

    public void EnterAlias(string alias, string elementId = _aliasField)
    {
      Client.Actions.Text.InsertId(elementId, alias);
    }
  }
}
