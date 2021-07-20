using System;
using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Booking.DeleteBooking
{
  public class DeleteBooking : IDeleteBooking
  {
    public async Task GenericAsync(string bookingId = "")
    {
      await new Controller.Booking.BookingController().DeleteBookingAsync<string>(bookingId,false).ConfigureAwait(false);
    }

    public async Task ValidAsync(string bookingId = "")
    {
      await new Controller.Booking.BookingController().DeleteBookingAsync<string>(bookingId).ConfigureAwait(false);
    }

    public async Task InvalidAsync(string bookingId = "")
    {
      await new Controller.Booking.BookingController().DeleteBookingAsync<string>(bookingId).ConfigureAwait(false);
    }
  }
}
