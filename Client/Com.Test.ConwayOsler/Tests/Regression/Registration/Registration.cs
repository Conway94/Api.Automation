using NUnit.Framework;
using static Com.Test.ConwayOsler.Data.Data;
using static Com.Test.ConwayOsler.Helper.RegressionHelper;

namespace Regression
{
  [Order(2)]
  [TestFixture]
  public class Registration : RegistrationHelper
  {
    [TestCase(Description = "Valid Registration")]
    public void ValidRegistration()
    {
      Website.Page.Registration.WaitForRegistrationForm();
      
      //User Details
      Website.Page.Registration.Personal.ClickGenderToggle();
      Website.Page.Registration.Personal.EnterFirstName(RegistrationData.firstName);
      Website.Page.Registration.Personal.EnterLastName(RegistrationData.lastName);
      Website.Page.Registration.Personal.EnterPassword(RegistrationData.password);

      //Date of Birth           
      Website.Page.Registration.Personal.EnterDateOfBirthDay(RegistrationData.day);
      Website.Page.Registration.Personal.EnterDateOfBirthMonth(RegistrationData.month);
      Website.Page.Registration.Personal.EnterDateOfBirthYear(RegistrationData.year);

      //News Letter             
      Website.Page.Registration.Personal.ClickNewsLetterToggle();

      //Special Offer Notice    
      Website.Page.Registration.Personal.ClickSpecialOfferToggle();

      //Address Details
      Website.Page.Registration.Address.EnterCompany(RegistrationData.company);
      Website.Page.Registration.Address.EnterAddressField1(RegistrationData.address1);
      Website.Page.Registration.Address.EnterAddressField2(RegistrationData.address2);
      Website.Page.Registration.Address.EnterCity(RegistrationData.city);
      Website.Page.Registration.Address.EnterState(RegistrationData.state);
      Website.Page.Registration.Address.EnterPostCode(RegistrationData.postalCode);
      Website.Page.Registration.Address.EnterCountry(RegistrationData.country);
      Website.Page.Registration.Address.EnterOtherInfo(RegistrationData.otherInfo);
      Website.Page.Registration.Address.EnterPhoneNumber(RegistrationData.phoneNumber);
      Website.Page.Registration.Address.EnterMobileNumber(RegistrationData.mobileNumber);
      Website.Page.Registration.Address.EnterAlias(RegistrationData.alias);
      
      //Submit Registration Form
      Website.Page.Registration.SubmitRegistrationForm();
    }
  }
}
