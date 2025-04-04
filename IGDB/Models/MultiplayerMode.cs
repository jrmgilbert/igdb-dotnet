using Newtonsoft.Json;

namespace IGDB.Models
{
  /// <summary>
  /// Data about the supported multiplayer types
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#multiplayer-mode"/>
  public class MultiplayerMode : IgdbEntityBase
  {
    /// <summary>
    /// True if the game supports campaign coop
    /// </summary>
    [JsonProperty("campaigncoop")]
    public bool? CampaignCoop { get; set; }

    /// <summary>
    /// True if the game supports drop in/out multiplayer
    /// </summary>
    [JsonProperty("dropin")]
    public bool? DropIn { get; set; }

    /// <summary>
    /// The game this multiplayer mode is associated with
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// True if the game supports LAN coop
    /// </summary>
    [JsonProperty("lancoop")]
    public bool? LanCoop { get; set; }

    /// <summary>
    /// True if the game supports offline coop
    /// </summary>
    [JsonProperty("offlinecoop")]
    public bool? OfflineCoop { get; set; }

    /// <summary>
    /// Maximum number of offline players in offline coop
    /// </summary>
    [JsonProperty("offlinecoopmax")]
    public int? OfflineCoopMax { get; set; }

    /// <summary>
    /// Maximum number of players in offline multiplayer
    /// </summary>
    [JsonProperty("offlinemax")]
    public int? OfflineMax { get; set; }

    /// <summary>
    /// True if the game supports online coop
    /// </summary>
    [JsonProperty("onlinecoop")]
    public bool? OnlineCoop { get; set; }

    /// <summary>
    /// Maximum number of online players in online coop
    /// </summary>
    [JsonProperty("onlinecoopmax")]
    public int? OnlineCoopMax { get; set; }

    /// <summary>
    /// Maximum number of players in online multiplayer
    /// </summary>
    [JsonProperty("onlinemax")]
    public int? OnlineMax { get; set; }

    /// <summary>
    /// The platform this multiplayer mode refers to
    /// </summary>
    public IdentityOrValue<Platform> Platform { get; set; }

    /// <summary>
    /// True if the game supports split screen, offline multiplayer
    /// </summary>
    [JsonProperty("splitscreen")]
    public bool? SplitScreen { get; set; }

    /// <summary>
    /// True if the game supports split screen, online multiplayer
    /// </summary>
    [JsonProperty("splitscreenonline")]
    public bool? SplitScreenOnline { get; set; }
  }
}