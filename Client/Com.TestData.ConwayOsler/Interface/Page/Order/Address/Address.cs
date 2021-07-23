using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Order.Address
{
  public class Address : CoreInterface
  {
    private const string _addressPage = "#order_step > li.step_current.third";
    private const string _deliveryAddressAlias = "id_address_delivery";
    private const string _firstNameLastName = "#address_delivery > li.address_firstname.address_lastname";
    private const string _company = "address_company";
    private const string _address = "#address_delivery > li.address_address1.address_address2";
    private const string _cityStatePostalCode = "#address_delivery > li.address_city.address_state_name.address_postcode";
    private const string _country = "address_country_name";
    private const string _phoneNumber = "address_phone";
    private const string _mobileNumber = "address_phone_mobile";
    private const string _orderInfo = "#ordermsg > textarea";
    private const string _proceedToCheckout = "//*[@id=\"center_column\"]/form/p/button";

    public void WaitForAddressPage(string cssSelector = _addressPage)
    {
      Client.Actions.Wait.ForCssSelector(cssSelector);
    }

    public void ValidateDeliveryAlias(string deliveryAddressAlias, string elementId = _deliveryAddressAlias)
    {
      Client.Actions.Text.ValidateId(elementId, deliveryAddressAlias);
    }

    public void ValidateName(string firstName, string LastName, string cssSelector = _firstNameLastName)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, $"{firstName} {LastName}");
    }

    public void ValidateCompany(string company, string elementClass = _company)
    {
      Client.Actions.Text.ValidateClass(elementClass, company);
    }

    public void ValidateAddress(string address1, string address2, string cssSelector = _address)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, $"{address1} {address2}");
    }

    public void ValidateCityStatePostalCode(string city, string state, string postalCode, string cssSelector = _cityStatePostalCode)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, $"{city}, {state} {postalCode}");
    }

    public void ValidateCountry(string country, string elementClass = _country)
    {
      Client.Actions.Text.ValidateClass(elementClass, country);
    }

    public void ValidatePhoneNumber(string phoneNumber, string elementClass = _phoneNumber)
    {
      Client.Actions.Text.ValidateClass(elementClass, phoneNumber);
    }

    public void ValidateMobileNumber(string mobileNumber, string elementClass = _mobileNumber)
    {
      Client.Actions.Text.ValidateClass(elementClass, mobileNumber);
    }

    public void InsertTextOrderInfo(string orderInfo, string cssSelector = _orderInfo)
    {
      Client.Actions.Text.InsertCss(cssSelector, orderInfo);
    }
    public void ClickProceedToCheckout(string xpath = _proceedToCheckout)
    {
      Client.Actions.Click.ElementXpath(xpath);
    }
  }
}
