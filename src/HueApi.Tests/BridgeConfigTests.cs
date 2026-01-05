using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace HueApi.Tests
{
  [TestClass]
  public class BridgeConfigTests
  {
    private readonly string ip;
    private readonly string key;

    public BridgeConfigTests()
    {
      var builder = new ConfigurationBuilder().AddUserSecrets<BehaviorInstanceTests>();
      var config = builder.Build();

      ip = config["ip"];
      key = config["key"];
    }

    [TestMethod]
    public async Task GetBridgeConfigTestNoKey()
    {
      var localHueClient = new LocalHueApi(ip, null);
      var result = await localHueClient.GetConfigAsync();

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.BridgeId);
      Assert.IsNotNull(result.Name);

      Assert.IsNull(result.ZigbeeChannel);

    }

    [TestMethod]
    public async Task GetBridgeConfigTestWithKey()
    {
      var localHueClient = new LocalHueApi(ip, key);
      var result = await localHueClient.GetConfigAsync();

      Assert.IsNotNull(result);
      Assert.IsNotNull(result.BridgeId);
      Assert.IsNotNull(result.Name);

      Assert.IsNotNull(result.ZigbeeChannel);

    }
  }
}
