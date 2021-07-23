using Com.Test.ConwayOsler.Data;
using Com.Test.ConwayOsler.Helper;
using NUnit.Framework;

namespace Regression
{
  [Order(9)]
  [TestFixture]
  public class MyAccount : Helper
  {
    [TestCase(Description = "Valid Update Account Details FirstName")]
    public void UpdateAccountDetailsFirstName()
    {
      Website.Page.Home.ClickMyAccount();
      Website.Page.MyAccount.WaitForMyAccountPage();
      Website.Page.MyAccount.ClickMyPersonalInformation();
      Website.Page.MyAccount.ValidateYourPersonalInformationText();
      Website.Page.MyAccount.UpdateFirstNameField();
      Website.Page.MyAccount.InsertOldPassword(Data.MyAccountData.oldPassword);
      Website.Page.MyAccount.InsertNewPassword(Data.MyAccountData.newPassword);
      Website.Page.MyAccount.InsertConfirmPassword(Data.MyAccountData.newPassword);
      Website.Page.MyAccount.ClickSave();
    }
  }
}
