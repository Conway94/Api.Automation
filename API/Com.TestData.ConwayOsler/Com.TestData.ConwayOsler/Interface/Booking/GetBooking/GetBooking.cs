using Com.TestData.ConwayOsler.Controller.Booking;
using Com.TestData.ConwayOsler.Model.Booking;
using System;
using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Booking.GetBooking
{
  public class GetBooking : IGetBooking
  {
    public async Task GenericAsync(string bookingId)
    {
      await new BookingController().GetBookingAsync<GetBookingResponse>(bookingId, false);
    }

    public async Task ValidAsync(string bookingId)
    {
      await new BookingController().GetBookingAsync<GetBookingResponse>(bookingId, false);
    }

    public async Task InvalidAsync(string bookingId)
    {
      await new BookingController().GetBookingAsync<string>(bookingId, false);
    }
  }
}
