using System;
using System.Configuration;
using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Helper
{
  public static class UriHelper
  {
    /// <summary>
    /// Retrieves the baseUrl application setting from the app.config.
    /// </summary>
    /// <param name="endPoint">The method endpoint to append to the baseUrl.</param>
    /// <returns>Returns a Uri Object containing the Rest Endpoint.</returns>
    public static async Task<Uri> GetRestfulBookerUriAsync(string endPoint)
    {
      return new Uri($"{ConfigurationManager.AppSettings["baseUrl"]}{endPoint}");
    }
  }
}
