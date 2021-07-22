using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Com.Core.ConwayOsler.Handlers
{
  public class ApiHandler
  {
    private readonly HttpClient _httpClient;
    private string _httpResponseMessage;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="baseUri"></param>
    /// <param name="authorizationToken"></param>
    public ApiHandler(Uri baseUri, string authorizationToken = null)
    {
      var cookieContainer = new CookieContainer();
      
      _httpClient = new HttpClient(new HttpClientHandler() { CookieContainer = cookieContainer })
      {
        Timeout = TimeSpan.FromSeconds(30),
        BaseAddress = baseUri,
      };
      
      if (authorizationToken != null)
      {
        _httpClient.DefaultRequestHeaders.Add("Authorization", authorizationToken);
        _httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
        cookieContainer.Add(baseUri, new Cookie("token", authorizationToken));
      }
    }

    public async Task<object> ProcessRequestAsync<T>(HttpMethod httpMethod, object requestBody = null,string mediaType = "application/json")
    {
      try
      {
        var httpRequestMessage = new HttpRequestMessage(httpMethod, _httpClient.BaseAddress);

        CreateJsonHttpRequest(requestBody, httpMethod, httpRequestMessage, mediaType);

        _httpResponseMessage = await SendHttpRequestAsync(httpRequestMessage);

        return JsonConvert.DeserializeObject<T>(_httpResponseMessage);

      }
      catch (Exception)
      {
        try
        {
          return _httpResponseMessage;
        }
        catch (Exception e)
        {
          Console.WriteLine(e);
          throw;
        }
      }
    }

    private static void CreateJsonHttpRequest(object requestBody, HttpMethod httpMethod, HttpRequestMessage httpRequestMessage, string mediaType)
    {
      if (httpMethod == HttpMethod.Get) return;
      httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(requestBody));
      httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue(mediaType);
    }

    private async Task<string> SendHttpRequestAsync(HttpRequestMessage httpRequestMessage)
    {
      var httpResponseMessage = new HttpResponseMessage();
      try
      {
        httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);

        return await httpResponseMessage.Content.ReadAsStringAsync();
      }
      catch (HttpRequestException httpRequestException)
      {
        Console.WriteLine(httpRequestException);
        throw;
      }
    }
  }
}
