using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Interface.Authorization.CreateToken
{
  public interface ICreateToken
  {
    Task GenericAsync(string userName = "", string password = "");
    Task ValidAsync(string userName = "", string password = "");
  }
}
