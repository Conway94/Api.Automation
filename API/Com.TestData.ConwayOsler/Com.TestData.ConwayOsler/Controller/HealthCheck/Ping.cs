using Com.Core.ConwayOsler.Interface;
using System;
using System.Net;
using System.Threading.Tasks;
using Com.TestData.ConwayOsler.Helper;
using Com.TestData.ConwayOsler.Model.Authorization;
using NUnit.Framework;

namespace Com.TestData.ConwayOsler.Controller.HealthCheck
{
  public class HealthCheck
  {
    private static Uri _createHealthCheckUrl;
    private static string _CreateHealthCheckEndPoint = "ping";
    public static CoreInterface Core = new CoreInterface();

    public HealthCheck()
    {
      if (_createHealthCheckUrl == null)
      {
        _ = CreateUriAsync();
      }
    }

    /// <summary>
    /// Creation of Url Endpoint for Rest Actions.
    /// </summary>
    public async Task CreateUriAsync()
    {
      _createHealthCheckUrl = await UriHelper.GetRestfulBookerUriAsync(_CreateHealthCheckEndPoint).ConfigureAwait(false);
    }

    /// <summary>
    /// A simple health check endpoint to confirm whether the API is up and running.
    /// </summary>
    /// <param name="mustValidateResponse">Boolean value indicating whether the rest api response should be validated.</param>
    public async Task PingAsync(bool mustValidate = true)
    {
      var httpStatusCodeString = await Core.Api.GetAsync<string>(_createHealthCheckUrl).ConfigureAwait(false);


      if (mustValidate)
      {
        Assert.AreEqual(HttpStatusCode.Created.ToString(), httpStatusCodeString);
      }
    }
  }
}
