using NUnit.Framework;
using System.Threading.Tasks;
using static Com.Test.ConwayOsler.Helper.RegressionHelper;

namespace Com.Test.ConwayOsler.Tests.Regression
{
  [TestFixture]
  public class UpdateBooking : UpdateBookingSetup
  {
    [TestCase(TestName = "Valid UpdateBooking Request")]
    public async Task UpdateBookingValid()
    {
      await RestfulBooker.Booking.UpdateBooking.ValidAsync();
    }
  }
}
