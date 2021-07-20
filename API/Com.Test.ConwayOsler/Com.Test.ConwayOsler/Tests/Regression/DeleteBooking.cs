using Com.TestData.ConwayOsler.Model.Booking;
using DeepEqual.Syntax;
using NUnit.Framework;
using System.Threading.Tasks;
using static Com.Test.ConwayOsler.Helper.RegressionHelper;

namespace Com.Test.ConwayOsler.Tests.Regression
{
  [TestFixture]
  public class DeleteBooking : DeleteBookingSetup
  {
    [TestCase(TestName = "Valid DeleteBooking Request")]
    public async Task DeleteBookingValid()
    {
      CreateBookingResponse createBookingResponse = await RestfulBooker.Booking.CreateBooking.ValidAsync().ConfigureAwait(false);
      
      await RestfulBooker.Booking.GetBooking.ValidAsync($"{createBookingResponse.bookingid}");
      Bookings.createBookingRequest.ShouldDeepEqual(Bookings.getBookingResponse);

      await RestfulBooker.Booking.DeleteBooking.ValidAsync();

      await RestfulBooker.Booking.GetBooking.GenericAsync($"{createBookingResponse.bookingid}");
      Assert.True(Bookings.getBookingResponse.ToString() == "Not Found");
    }
  }
}
