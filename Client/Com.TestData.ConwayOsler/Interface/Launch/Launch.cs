using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.TestData.ConwayOsler.Actions.Launch;

namespace Com.TestData.ConwayOsler.Interface.Launch
{
  public class Launch
  {
    public void Url(string launchUrl)
    {
      new LaunchAction().Url(launchUrl);
    }
  }
}
