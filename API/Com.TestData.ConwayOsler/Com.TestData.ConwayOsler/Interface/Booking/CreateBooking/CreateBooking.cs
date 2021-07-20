using Com.TestData.ConwayOsler.Model.Booking;
using System;
using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Booking.CreateBooking
{
  public class CreateBooking : ICreateBooking
  {
    public async Task<CreateBookingResponse> GenericAsync(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "")
    {
      return await new Controller.Booking.BookingController().CreateBookingAsync<CreateBookingResponse>(
        firstName,
        lastName,
        totalPrice,
        depositPaid,
        checkIn,
        checkOut,
        additionalNeeds,
        false).ConfigureAwait(false);
    }

    public async Task<CreateBookingResponse> ValidAsync(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "")
    {
      return await new Controller.Booking.BookingController().CreateBookingAsync<CreateBookingResponse>(
        firstName,
        lastName,
        totalPrice,
        depositPaid,
        checkIn,
        checkOut,
        additionalNeeds).ConfigureAwait(false);
    }

    public async Task InvalidAsync(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "")
    {
      await new Controller.Booking.BookingController().CreateBookingAsync<string>(
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
