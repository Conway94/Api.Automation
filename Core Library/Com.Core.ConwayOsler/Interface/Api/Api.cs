using Com.Core.ConwayOsler.Handlers;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Com.Core.ConwayOsler.Interface.Api
{
  public class Api
  {
    public ApiHandler ApiHandler(Uri uri, string authorizationToken = null)
    {
      return new ApiHandler(uri, authorizationToken);
    }

    public async Task<dynamic> PostAsync<T>(Uri uri, object requestBody, string authorizationToken = null)
    {
      return await ApiHandler(uri, authorizationToken).ProcessRequestAsync<T>(HttpMethod.Post, requestBody);
    }

    public async Task<dynamic> GetAsync<T>(Uri uri, string authorizationToken = null)
    {
      return await ApiHandler(uri, authorizationToken).ProcessRequestAsync<T>(HttpMethod.Get);
    }

    public async Task<dynamic> PutAsync<T>(Uri uri, object requestBody, string authorizationToken = null)
    {
      return await ApiHandler(uri, authorizationToken).ProcessRequestAsync<T>(HttpMethod.Put, requestBody);
    }

    public async Task<dynamic> DeleteAsync<T>(Uri uri, string authorizationToken = null)
    {
      return await ApiHandler(uri, authorizationToken).ProcessRequestAsync<T>(HttpMethod.Delete, mediaType: "text/string");
    }
  }
}
