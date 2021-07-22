using NUnit.Framework;
using static Com.Test.ConwayOsler.Data.Data;

namespace Regression
{
  [Order(0)]
  [TestFixture]
  public class Launch : LaunchData
  {
    [TestCase(Description = "Valid Launch Website")]
    public void ValidLaunchWebsite()
    {
      Website.Launch.Url(LaunchData.launchUrl);
    }
  }
}
