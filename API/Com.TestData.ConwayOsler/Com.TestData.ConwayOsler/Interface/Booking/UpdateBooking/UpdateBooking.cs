using Com.TestData.ConwayOsler.Model.Booking;
using System;
using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Booking.UpdateBooking
{
  public class UpdateBooking : IUpdateBooking
  {
    public async Task GenericAsync(
      string bookingId = "",
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "")
    {
      await new Controller.Booking.BookingController().UpdateBookingAsync<UpdateBookingResponse>(
        bookingId,
        firstName,
        lastName,
        totalPrice,
        depositPaid,
        checkIn,
        checkOut,
        additionalNeeds).ConfigureAwait(false);
    }

    public async Task ValidAsync(
      string bookingId = "",
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "")
    {
      await new Controller.Booking.BookingController().UpdateBookingAsync<UpdateBookingResponse>(
        bookingId,
        firstName,
        lastName,
        totalPrice,
        depositPaid,
        checkIn,
        checkOut,
        additionalNeeds).ConfigureAwait(false);
    }

    public async Task InvalidAsync(
      string bookingId = "",
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "")
    {
      await new Controller.Booking.BookingController().UpdateBookingAsync<string>(
        bookingId,
        firstName,
        lastName,
        totalPrice,
        depositPaid,
        checkIn,
        checkOut,
        additionalNeeds).ConfigureAwait(false);
    }
  }
}
