using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Authorization.CreateToken
{
  public class CreateToken : ICreateToken
  {
    public async Task GenericAsync(string userName = "", string password = "")
    {
      await new Controller.Authorization.Authorization().CreateTokenAsync(userName, password,false).ConfigureAwait(false);
    }

    public async Task ValidAsync(string userName = "", string password = "")
    {
      await new Controller.Authorization.Authorization().CreateTokenAsync(userName, password).ConfigureAwait(false);
    }
  }
}
