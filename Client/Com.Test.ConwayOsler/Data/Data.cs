using System;

namespace Com.Test.ConwayOsler.Data
{
  public class Data : Helper.Helper
  {
    private static Random random = new Random();

    public class LaunchData : Data
    {
      public static string launchUrl = "http://automationpractice.com/index.php";
      public static string accountCreationUrl = "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";
    }

    public class SignInData : Data
    {
      public static string userEmail = $"Joey.Ghetto{random.Next(0, 9999)}@gmail.com";
    }

    public class RegistrationData : Data
    {
      public static string firstName = "Joe";
      public static string lastName = "Ghetto";
      public static string password = "FoodIsLife";
      public static string company = "ImpracticalJokers";
      public static string address1 = "Somewhere";
      public static string address2 = "Else";
      public static string city = "California";
      public static string state = "Hawaii";
      public static string postalCode = "12345";
      public static string country = "United States";
      public static string otherInfo = "N/A";
      public static string phoneNumber = "0315556351";
      public static string mobileNumber = "0839994565";
      public static string alias = "Joey";

      //Registration DateOfBirth
      public static string day = "9";
      public static string month = "March";
      public static string year = "1946";
    }

    public class MyAccountData
    {
      public static string oldPassword = RegistrationData.password;
      public static string newPassword = "FoodIs4Life";
    }
  }
}
