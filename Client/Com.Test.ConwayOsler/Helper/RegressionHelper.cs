using Com.Core.ConwayOsler.Handlers.Client.Helper;
using NUnit.Framework;

namespace Com.Test.ConwayOsler.Helper
{
  public class RegressionHelper : Helper
  {
    public class SignInHelper : RegressionHelper
    {
      [OneTimeSetUp]
      public void OneTimeSetup()
      {
        if (SeleniumHelper.Driver == null)
        {
          Website.Launch.Url(Data.Data.LaunchData.launchUrl);
          Website.Page.Home.ClickSignIn();
          Website.Page.SignIn.EnterEmailAddress(Data.Data.SignInData.userEmail);
          Website.Page.SignIn.SubmitCreateAccount();
        }
      }
    }

    public class RegistrationHelper : RegressionHelper
    {
      [OneTimeSetUp]
      public void OneTimeSetup()
      {
        if (SeleniumHelper.Driver == null)
        {
          Website.Launch.Url(Data.Data.LaunchData.accountCreationUrl);
          Website.Page.Home.ClickSignIn();
          Website.Page.SignIn.EnterEmailAddress(Data.Data.SignInData.userEmail);
          Website.Page.SignIn.SubmitCreateAccount();
        }
      }
    }

    public class OrderHelper : RegressionHelper
    {
      [OneTimeSetUp]
      public void OneTimeSetup()
      {
        if (SeleniumHelper.Driver == null)
        {
          Website.Launch.Url(Data.Data.LaunchData.accountCreationUrl);
          Website.Page.Home.ClickSignIn();
          
        }
      }
    }
  }
}
