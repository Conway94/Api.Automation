using DeepEqual.Syntax;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Com.Core.ConwayOsler.Interface.Utility.DeepCompare
{
  public class DeepCompare
  {
    /// <summary>
    /// Compare two Object's properties at a name, value and type level.
    /// </summary>
    /// <typeparam name="T">Expected Type of Object.</typeparam>
    /// <param name="actual">The Object that is undergoing validation.</param>
    /// <param name="expected">The Control Object that is deemed to be correct.</param>
    public async Task ObjectCompareAsync<T>(object actual, object expected)
    {
      if (actual.GetType().Name != typeof(T).Name)
        Assert.Fail($"The Expected {typeof(T).Name} did not match the Actual {actual.GetType().Name}");

      actual.ShouldDeepEqual(expected);
    }

    /// <summary>
    /// Compare two Object's properties at a name, value and type level.
    /// </summary>
    /// <param name="actual">The Object that is undergoing validation.</param>
    /// <param name="expected">The Control Object that is deemed to be correct.</param>
    public async Task ObjectCompareAsync(object actual, object expected)
    {
      actual.ShouldDeepEqual(expected);
    }
  }
}
