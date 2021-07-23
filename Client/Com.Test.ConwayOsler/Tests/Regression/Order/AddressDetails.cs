using Com.Test.ConwayOsler.Helper;
using NUnit.Framework;
using static Com.Test.ConwayOsler.Data.Data;

namespace Regression
{
  [Order(6)]
  [TestFixture]
  public class AddressDetails : Helper
  {
    [TestCase(Description = "Valid Address Details")]
    public void ValidAddressDetails()
    {
      Website.Page.Order.Address.WaitForAddressPage();
      Website.Page.Order.Address.ValidateDeliveryAlias(RegistrationData.alias);
      Website.Page.Order.Address.ValidateName(RegistrationData.firstName, RegistrationData.lastName);
      Website.Page.Order.Address.ValidateCompany(RegistrationData.company);
      Website.Page.Order.Address.ValidateAddress(RegistrationData.address1, RegistrationData.address2);
      Website.Page.Order.Address.ValidateCityStatePostalCode(RegistrationData.city, RegistrationData.state, RegistrationData.postalCode);
      Website.Page.Order.Address.ValidateCountry(RegistrationData.country);
      Website.Page.Order.Address.ValidatePhoneNumber(RegistrationData.phoneNumber);
      Website.Page.Order.Address.ValidateMobileNumber(RegistrationData.mobileNumber);
      Website.Page.Order.Address.InsertTextOrderInfo(RegistrationData.otherInfo);
      Website.Page.Order.Address.ClickProceedToCheckout();
    }
  }
}
