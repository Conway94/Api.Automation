using Com.Test.ConwayOsler.Helper;
using Com.TestData.ConwayOsler.Interface;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Com.Test.ConwayOsler.Helper
{
  public class Helper
  {
    public RestfulBooker RestfulBooker = new RestfulBooker();
  }
}


/// <summary>
/// Health Check conducted before tests are run.
/// If a failure occurs, this will automatically stop all tests from running.
/// </summary>
[SetUpFixture]
public class Setup : Helper
{
  [OneTimeSetUp]
  public async Task BeforeTestsHealthCheckAsync()
  {
    await RestfulBooker.HealthCheck.Ping.ValidAsync();
  }
}

