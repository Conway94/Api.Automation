using Com.TestData.ConwayOsler.Model.Booking;
using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Booking.CreateBooking
{
  public interface ICreateBooking
  {
    Task<CreateBookingResponse> GenericAsync(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "");

    Task<CreateBookingResponse> ValidAsync(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "");

    Task InvalidAsync(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "");
  }
}
