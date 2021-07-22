using NUnit.Framework;
using static Com.Test.ConwayOsler.Data.Data;
using static Com.Test.ConwayOsler.Helper.RegressionHelper;

namespace Regression
{
  [Order(1)]
  [TestFixture]
  public class SignIn : SignInHelper
  {
    
    [TestCase(Description = "Valid SignIn")]
    public void ValidSignIn()
    {
      Website.Page.Home.ClickSignIn();
      Website.Page.SignIn.EnterEmailAddress(SignInData.userEmail);
      Website.Page.SignIn.SubmitCreateAccount();
    }
  }
}
