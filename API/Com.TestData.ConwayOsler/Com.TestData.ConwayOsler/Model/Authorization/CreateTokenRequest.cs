

using Newtonsoft.Json;

namespace Com.TestData.ConwayOsler.Model.Authorization
{
  public class CreateTokenRequest
  {
    [JsonProperty(Required = Required.Always)]
    public string username { get; set; }

    [JsonProperty(Required = Required.Always)]
    public string password { get; set; }

    internal static CreateTokenRequest GetCreateTokenRequest(string username = "", string password = "")
    {
      return new CreateTokenRequest()
      {
        username = string.IsNullOrEmpty(username) ? "admin" : username,
        password = string.IsNullOrEmpty(password) ? "password123" : password
      };
    }
  }
}
