using Com.Core.ConwayOsler.Interface;
using Com.TestData.ConwayOsler.Helper;
using Com.TestData.ConwayOsler.Model.Authorization;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Controller.Authorization
{
  public class Authorization
  {
    private static Uri _createTokenUrl;
    private static string _CreateTokenEndPoint = "auth";
    public static CoreInterface Core = new CoreInterface();

    public Authorization()
    {
      _ = CreateUriAsync();
    }

    /// <summary>
    /// Creation of Url Endpoint for Rest Actions.
    /// </summary>
    /// <returns>Returns a Uri Object containing the Rest Endpoint.</returns>
    public async Task CreateUriAsync()
    {
      _createTokenUrl = await UriHelper.GetRestfulBookerUriAsync(_CreateTokenEndPoint).ConfigureAwait(false);
    }

    /// <summary>
    /// Generates an authorization token to interact with the RestfulBooker api.
    /// </summary>
    /// <param name="userName">Username for authentication</param>
    /// <param name="password">Password for authentication</param>
    /// <param name="mustValidateResponse">Boolean value indicating whether the rest api response should be validated.</param>
    public async Task CreateTokenAsync(string userName = "", string password = "", bool mustValidate = true)
    {
      var createTokenRequest = CreateTokenRequest.GetCreateTokenRequest(userName, password);

      Authorizations.createTokenResponse = await Core.Api.PostAsync<CreateTokenResponse>(_createTokenUrl, createTokenRequest).ConfigureAwait(false);

      if (mustValidate)
      {
        Assert.NotNull(Authorizations.createTokenResponse);
      }
    }
  }
}
