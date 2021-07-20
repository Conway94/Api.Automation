using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Booking.DeleteBooking
{
  public interface IDeleteBooking
  {
    Task GenericAsync(string bookingId = "");
    Task ValidAsync(string bookingId = "");
    Task InvalidAsync(string bookingId = "");
  }
}
