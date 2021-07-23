using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Order.Address
{
  public class Address : CoreInterface
  {
    private const string _addressPage = "#order_step > li.step_current.third";
    private const string _deliveryAddressAliasField = "id_address_delivery";
    private const string _firstNameLastNameField = "#address_delivery > li.address_firstname.address_lastname";
    private const string _companyField = "address_company";
    private const string _addressField = "#address_delivery > li.address_address1.address_address2";
    private const string _cityStatePostalCodeField = "#address_delivery > li.address_city.address_state_name.address_postcode";
    private const string _countryField = "address_country_name";
    private const string _phoneNumberField = "address_phone";
    private const string _mobileNumberField = "address_phone_mobile";
    private const string _orderInfoField = "#ordermsg > textarea";
    private const string _proceedToCheckoutButton = "//*[@id=\"center_column\"]/form/p/button";

    public void WaitForAddressPage(string cssSelector = _addressPage)
    {
      Client.Actions.Wait.ForCssSelector(cssSelector);
    }

    public void ValidateDeliveryAlias(string deliveryAddressAlias, string elementId = _deliveryAddressAliasField)
    {
      Client.Actions.Text.ValidateId(elementId, deliveryAddressAlias);
    }

    public void ValidateName(string firstName, string LastName, string cssSelector = _firstNameLastNameField)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, $"{firstName} {LastName}");
    }

    public void ValidateCompany(string company, string elementClass = _companyField)
    {
      Client.Actions.Text.ValidateClass(elementClass, company);
    }

    public void ValidateAddress(string address1, string address2, string cssSelector = _addressField)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, $"{address1} {address2}");
    }

    public void ValidateCityStatePostalCode(string city, string state, string postalCode, string cssSelector = _cityStatePostalCodeField)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, $"{city}, {state} {postalCode}");
    }

    public void ValidateCountry(string country, string elementClass = _countryField)
    {
      Client.Actions.Text.ValidateClass(elementClass, country);
    }

    public void ValidatePhoneNumber(string phoneNumber, string elementClass = _phoneNumberField)
    {
      Client.Actions.Text.ValidateClass(elementClass, phoneNumber);
    }

    public void ValidateMobileNumber(string mobileNumber, string elementClass = _mobileNumberField)
    {
      Client.Actions.Text.ValidateClass(elementClass, mobileNumber);
    }

    public void InsertTextOrderInfo(string orderInfo, string cssSelector = _orderInfoField)
    {
      Client.Actions.Text.InsertCss(cssSelector, orderInfo);
    }
    public void ClickProceedToCheckout(string xpath = _proceedToCheckoutButton)
    {
      Client.Actions.Click.ElementXpath(xpath);
    }
  }
}
