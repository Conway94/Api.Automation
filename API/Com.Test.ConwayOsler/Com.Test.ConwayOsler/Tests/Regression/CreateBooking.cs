using NUnit.Framework;
using System.Threading.Tasks;
using static Com.Test.ConwayOsler.Helper.RegressionHelper;

namespace Com.Test.ConwayOsler.Tests.Regression
{
  [TestFixture]
  public class CreateBooking : CreateBookingSetup
  {
    [TestCase(TestName = "Valid CreateBooking Request")]
    public async Task CreateBookingValid()
    {
      await RestfulBooker.Booking.CreateBooking.ValidAsync();
    }
    
    [TestCase("2099-01-01", TestName = "Invalid CreateBooking - CheckIn Date Is Later Than CheckOut Date")]
    public async Task InvalidCheckInDate(string checkInDate)
    {
      await RestfulBooker.Booking.CreateBooking.InvalidAsync(checkIn: checkInDate);
    }

    [TestCase("1999-01-01", TestName = "Invalid CreateBooking - CheckOut Date Is Earlier Than CheckIn Date")]
    public async Task InvalidCheckOutDate(string checkOutDate)
    {
      await RestfulBooker.Booking.CreateBooking.InvalidAsync(checkOut: checkOutDate);
    }
  }
}
