using Com.Test.ConwayOsler.Helper;
using NUnit.Framework;

namespace Regression
{
  [Order(8)]
  [TestFixture]
  public class PaymentDetails : Helper
  {
    [TestCase(Description = "Valid Payment Details")]
    public void ValidPaymentDetails()
    {
      Website.Page.Order.Payment.WaitForPaymentPage();
      Website.Page.Order.Payment.ClickPayByBankWire();
      Website.Page.Order.Payment.ValidateBankWirePage();
      Website.Page.Order.Payment.ClickConfirmOrder();
      Website.Page.Order.Payment.ValidateOrderComplete();
    }
  }
}
