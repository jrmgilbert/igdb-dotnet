using Newtonsoft.Json;

namespace IGDB.Models
{
  /// <summary>
  /// 
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#platform-version"/>
  public class PlatformVersion : IgdbEntityBase
  {
    /// <summary>
    /// Who developed this platform version
    /// </summary>
    public IdentitiesOrValues<PlatformVersionCompany> Companies { get; set; }

    /// <summary>
    /// The network capabilities
    /// </summary>
    public string Connectivity { get; set; }

    /// <summary>
    /// The integrated control processing unit
    /// </summary>
    [JsonProperty("cpu")]
    public string CPU { get; set; }

    /// <summary>
    /// The graphics chipset
    /// </summary>
    public string Graphics { get; set; }

    /// <summary>
    /// Who manufactured this version of the platform
    /// </summary>
    public IdentityOrValue<PlatformVersionCompany> MainManufacturer { get; set; }

    /// <summary>
    /// The type of media this version accepted
    /// </summary>
    public string Media { get; set; }

    /// <summary>
    /// How much memory there is
    /// </summary>
    public string Memory { get; set; }

    /// <summary>
    /// The name of the platform version
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The operating system installed on the platform version
    /// </summary>
    [JsonProperty("os")]
    public string OS { get; set; }

    /// <summary>
    /// The output video rate
    /// </summary>
    public string Output { get; set; }

    /// <summary>
    /// The logo of this platform version
    /// </summary>
    public IdentityOrValue<PlatformLogo> PlatformLogo { get; set; }

    /// <summary>
    /// When this platform was released
    /// </summary>
    public IdentitiesOrValues<PlatformVersionReleaseDate> PlatformVersionReleaseDates { get; set; }

    /// <summary>
    /// The maximum resolution
    /// </summary>
    public string Resolutions { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// The sound chipset
    /// </summary>
    public string Sound { get; set; }

    /// <summary>
    /// How much storage there is
    /// </summary>
    public string Storage { get; set; }

    /// <summary>
    /// A short summary
    /// </summary>
    public string Summary { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}