using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.HealthCheck.Ping
{
  public class Ping
  {
    public async Task ValidAsync()
    {
      await new Controller.HealthCheck.HealthCheck().PingAsync().ConfigureAwait(false);
    }
  }
}
