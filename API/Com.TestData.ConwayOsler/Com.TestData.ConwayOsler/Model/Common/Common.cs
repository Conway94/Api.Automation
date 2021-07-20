using System;
using Newtonsoft.Json;

namespace Com.TestData.ConwayOsler.Model.Common
{
  public class Booking
  {
    [JsonProperty(Required = Required.Always)]
    public string firstname { get; set; }

    [JsonProperty(Required = Required.Always)]
    public string lastname { get; set; }

    [JsonProperty(Required = Required.Always)]
    public int totalprice { get; set; }

    [JsonProperty(Required = Required.Always)]
    public bool depositpaid { get; set; }

    [JsonProperty(Required = Required.Always)]
    public BookingDates bookingdates { get; set; }

    [JsonProperty(Required = Required.Always)]
    public string additionalneeds { get; set; }
  }

  public class BookingDates
  {
    [JsonProperty(Required = Required.Always)]
    public string checkin { get; set; }

    [JsonProperty(Required = Required.Always)]
    public string checkout { get; set; }
  }
}
