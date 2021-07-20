using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Booking.UpdateBooking
{
  public interface IUpdateBooking
  {
    Task GenericAsync(
      string bookingId = "",
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "");

    Task ValidAsync(
      string bookingId = "",
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "");

    Task InvalidAsync(
      string bookingId = "",
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "");
  }
}
