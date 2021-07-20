using NUnit.Framework;
using System.Threading.Tasks;

namespace Com.Test.ConwayOsler.Helper
{
  /// <summary>
  /// Class for pre-test setup.
  /// </summary>
  public class RegressionHelper : Helper
  {

    public class CreateTokenSetup : RegressionHelper
    {
    }

    public class CreateBookingSetup : RegressionHelper
    {
      [OneTimeSetUp]
      public async Task OneTimeSetup()
      {
        await RestfulBooker.Authorization.CreateToken.ValidAsync();
      }
    }

    public class UpdateBookingSetup : RegressionHelper
    {
      [OneTimeSetUp]
      public async Task OneTimeSetup()
      {
        await RestfulBooker.Authorization.CreateToken.ValidAsync();
        await RestfulBooker.Booking.CreateBooking.ValidAsync();
      }
    }

    public class DeleteBookingSetup : RegressionHelper
    {
      [OneTimeSetUp]
      public async Task OneTimeSetup()
      {
        await RestfulBooker.Authorization.CreateToken.ValidAsync();
      }
    }
  }
}
