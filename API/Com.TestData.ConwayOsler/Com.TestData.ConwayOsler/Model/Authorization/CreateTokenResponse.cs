using Newtonsoft.Json;

namespace Com.TestData.ConwayOsler.Model.Authorization
{
  public class CreateTokenResponse
  {
    [JsonProperty(Required = Required.Always)]
    public string token { get; set; }
  }
}
