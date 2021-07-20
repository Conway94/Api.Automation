using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Booking.GetBooking
{
  public interface IGetBooking
  {
    Task GenericAsync(string bookingId);
    Task ValidAsync(string bookingId);
    Task InvalidAsync(string bookingId);
  }
}
