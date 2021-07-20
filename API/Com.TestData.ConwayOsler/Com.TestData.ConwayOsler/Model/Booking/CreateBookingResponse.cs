using Com.TestData.ConwayOsler.Model.Common;
using Newtonsoft.Json;

namespace Com.TestData.ConwayOsler.Model.Booking
{
  public class CreateBookingResponse
  {
    [JsonProperty(Required = Required.Always)]
    public int bookingid { get; set; }

    [JsonProperty(Required = Required.Always)]
    public Common.Booking booking { get; set; }
  }
}
