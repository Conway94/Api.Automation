using NUnit.Framework;
using System.Threading.Tasks;
using static Com.Test.ConwayOsler.Helper.RegressionHelper;

namespace Com.Test.ConwayOsler.Tests.Regression
{
  [TestFixture]
  public class CreateToken : CreateTokenSetup
  {
    [TestCase("admin","password123",TestName = "Valid CreateToken Request")]
    public async Task CreateTokenValid(string username, string password)
    {
      await RestfulBooker.Authorization.CreateToken.ValidAsync(username,password);
    }
  }
}
