using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HueApi.Models.Clip
{
  [DataContract]
  public class BridgeConfig
  {

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("mac")]
    public string? MacAddress { get; set; }

    [JsonPropertyName("dhcp")]
    public bool Dhcp { get; set; }

    [JsonPropertyName("ipaddress")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("netmask")]
    public string? NetMask { get; set; }

    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    [JsonPropertyName("UTC")]
    public DateTimeOffset? Utc { get; set; }

    [JsonPropertyName("swversion")]
    public string? SoftwareVersion { get; set; }

    [JsonPropertyName("swupdate2")]
    public SoftwareUpdate2? SoftwareUpdate2 { get; set; }

    [JsonPropertyName("whitelist")]
    public Dictionary<string, WhiteList> WhiteList { get; set; } = new();

    [JsonPropertyName("linkbutton")]
    public bool LinkButton { get; set; }

    [JsonPropertyName("portalservices")]
    public bool PortalServices { get; set; }

    [JsonPropertyName("portalconnection")]
    public string? PortalConnection { get; set; }

    [JsonPropertyName("apiversion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("localtime")]
    public DateTimeOffset? LocalTime { get; set; }

    [JsonPropertyName("timezone")]
    public string? TimeZone { get; set; }

    [JsonPropertyName("portalstate")]
    public PortalState? PortalState { get; set; }

    [JsonPropertyName("zigbeechannel")]
    public int? ZigbeeChannel { get; set; }

    /// <summary>
    /// Perform a touchlink action if set to true, setting to false is ignored. When set to true a touchlink procedure starts which adds the closet lamp (within range) to the ZigBee network.  You can then search for new lights and lamp will show up in the bridge.
    /// </summary>
    [JsonPropertyName("touchlink")]
    public bool TouchLink { get; set; }

    /// <summary>
    /// Indicates if bridge settings are factory new.
    /// </summary>
    [JsonPropertyName("factorynew")]
    public bool FactoryNew { get; set; }

    /// <summary>
    ///  If a bridge backup file has been restored on this bridge from a bridge with a different bridgeid, it will indicate that bridge id, otherwise it will be null.
    /// </summary>
    [JsonPropertyName("replacesbridgeid")]
    public string? ReplacesBridgeId { get; set; }

    /// <summary>
    /// This parameter uniquely identifies the hardware model of the bridge (BSB001, BSB002, BSB003).
    /// </summary>
    [JsonPropertyName("modelid")]
    public string? ModelId { get; set; }

    /// <summary>
    /// The unique bridge id. This is currently generated from the bridge Ethernet mac address.
    /// </summary>
    [JsonPropertyName("bridgeid")]
    public string? BridgeId { get; set; }

    [JsonPropertyName("datastoreversion")]
    public string? DataStoreVersion { get; set; }

    [JsonPropertyName("starterkitid")]
    public string? StarterKitId { get; set; }

    [JsonPropertyName("internetservices")]
    public InternetServices? InternetServices { get; set; }

  }

  public class InternetServices
  {
    /// <summary>
    /// Connected:   If remote CLIP is available.
    /// Disconnected:  If remoteaccess is unavailable, reasons can be portalservices are false or no remote connection is available.
    /// </summary>
    [JsonPropertyName("remoteaccess")]
    public InternetServicesState RemoteAccess { get; set; }

    /// <summary>
    /// Connected:    Bridge has a connection to Internet.
    /// Disconnected:   Bridge cannot reach the Internet.
    /// </summary>
    [JsonPropertyName("internet")]
    public InternetServicesState Internet { get; set; }

    /// <summary>
    /// Connected:    Time was synchronized with internet service.
    /// Disconnected:  Internet time service was not reachable for 48hrs.
    /// </summary>
    [JsonPropertyName("time")]
    public InternetServicesState Time { get; set; }

    /// <summary>
    /// Connected:    swupdate server is available.
    /// Disconnected:  swupdate server was not reachable in the last 24 hrs.
    /// </summary>
    [JsonPropertyName("swupdate")]
    public InternetServicesState SWUpdate { get; set; }
  }

  /// <summary>
  /// Possible InternetServices States
  /// </summary>
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum InternetServicesState
  {
    [EnumMember(Value = "connected")]
    Connected,
    [EnumMember(Value = "disconnected")]
    Disconnected,
  }

  public class PortalState
  {
    [JsonPropertyName("signedon")]
    public bool SignedOn { get; set; }

    [JsonPropertyName("incoming")]
    public bool Incoming { get; set; }

    [JsonPropertyName("outgoing")]
    public bool Outgoing { get; set; }

    [JsonPropertyName("communication")]
    public string? Communication { get; set; }
  }

  public class WhiteList
  {
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("last use date")]
    public DateTimeOffset? LastUsedDate { get; set; }

    [JsonPropertyName("create date")]
    public DateTimeOffset? CreateDate { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

  }
}
