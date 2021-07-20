using NUnit.Framework;
using System.Threading.Tasks;

namespace Com.Test.ConwayOsler.Tests.Regression
{
  [TestFixture]
  public class Ping : Helper.Helper
  {
    [TestCase(TestName = "Valid Ping Request")]
    public async Task PingValid()
    {
      await RestfulBooker.HealthCheck.Ping.ValidAsync();
    }
  }
}
