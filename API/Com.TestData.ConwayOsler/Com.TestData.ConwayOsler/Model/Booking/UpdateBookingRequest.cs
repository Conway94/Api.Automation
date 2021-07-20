using System;
using Com.TestData.ConwayOsler.Model.Common;
using Newtonsoft.Json;

namespace Com.TestData.ConwayOsler.Model.Booking
{
  public class UpdateBookingRequest : Common.Booking
  {
    [JsonProperty(Required = Required.Always)]
    public BookingDates bookingdates { get; set; }

    internal static UpdateBookingRequest GetUpdateBookingRequest(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "")
    {
      return new UpdateBookingRequest()
      {
        firstname = string.IsNullOrEmpty(firstName) ? "James" : firstName,
        lastname = string.IsNullOrEmpty(lastName) ? "White" : lastName,
        totalprice = totalPrice ?? 12,
        depositpaid = depositPaid ?? false,
        bookingdates = new BookingDates()
        {
          checkin = string.IsNullOrEmpty(checkIn) ? DateTime.Now.ToString("yyyy-MM-dd") : checkIn,
          checkout = string.IsNullOrEmpty(checkOut) ? DateTime.Now.ToString("yyyy-MM-dd") : checkOut,
        },
        additionalneeds = string.IsNullOrEmpty(additionalNeeds) ? "Dinner" : additionalNeeds,
      };
    }
  }
}
