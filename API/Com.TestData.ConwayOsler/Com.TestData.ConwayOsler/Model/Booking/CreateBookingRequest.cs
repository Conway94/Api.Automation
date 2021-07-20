using System;
using System.Globalization;
using Com.TestData.ConwayOsler.Model.Common;

namespace Com.TestData.ConwayOsler.Model.Booking
{
  public class CreateBookingRequest : Common.Booking
  {

    private static readonly string _dateTimeFormat = "yyyy-MM-dd";
    internal static CreateBookingRequest GetCreateBookingRequest(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "")
    {
      return new CreateBookingRequest()
      {
        firstname = string.IsNullOrEmpty(firstName) ? "Jim" : firstName,
        lastname = string.IsNullOrEmpty(lastName) ? "Brown" : lastName,
        totalprice = totalPrice ?? 111,
        depositpaid = depositPaid ?? true,
        bookingdates = new BookingDates()
        {
          checkin = string.IsNullOrEmpty(checkIn) ? DateTime.Now.ToString(_dateTimeFormat) : checkIn,
          checkout = string.IsNullOrEmpty(checkOut) ? DateTime.Now.ToString(_dateTimeFormat) : checkOut,
        },
        additionalneeds = string.IsNullOrEmpty(additionalNeeds) ? "Breakfast" : additionalNeeds,
      };
    }
  }
}
