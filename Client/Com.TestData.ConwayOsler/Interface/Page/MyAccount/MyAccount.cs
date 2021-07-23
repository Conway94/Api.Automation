using Com.Core.ConwayOsler.Interface;


namespace Com.TestData.ConwayOsler.Interface.Page.MyAccount
{
  public class MyAccount : CoreInterface
  {
    private const string _myAccountPage = "#columns > div.breadcrumb.clearfix > span.navigation_page";
    private const string _myPersonalInformationButton = "#center_column > div > div:nth-child(1) > ul > li:nth-child(4) > a";
    private const string _yourPersonalInformationText = "#center_column > div > h1";
    private const string _firstNameField = "firstname";
    private const string _oldPassword = "old_passwd";
    private const string _newPassword = "passwd";
    private const string _confirmPassword = "confirmation";
    private const string _saveButton = "#center_column > div > form > fieldset > div:nth-child(11) > button";

    public void WaitForMyAccountPage(string cssSelector = _myAccountPage)
    {
      Client.Actions.Wait.ForCssSelector(_myAccountPage);
    }

    public void ClickMyPersonalInformation(string cssSelector = _myPersonalInformationButton)
    {
      Client.Actions.Click.CssSelector(_myPersonalInformationButton);
    }

    public void ValidateYourPersonalInformationText(string text = "YOUR PERSONAL INFORMATION", string cssSelector = _yourPersonalInformationText)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, text);
    }

    public void UpdateFirstNameField(string text = " Bologna", string elementId = _firstNameField)
    {
      Client.Actions.Text.InsertId(elementId, text);
    }

    public void InsertOldPassword(string text, string elementId = _oldPassword)
    {
      Client.Actions.Text.InsertId(elementId, text);
    }

    public void InsertNewPassword(string text, string elementId = _newPassword)
    {
      Client.Actions.Text.InsertId(elementId, text);
    }

    public void InsertConfirmPassword(string text, string elementId = _confirmPassword)
    {
      Client.Actions.Text.InsertId(elementId, text);
    }

    public void ClickSave(string cssSelector = _saveButton)
    {
      Client.Actions.Click.CssSelector(cssSelector);
    }
  }
}
