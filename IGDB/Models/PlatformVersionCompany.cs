namespace IGDB.Models
{
  /// <summary>
  /// A platform developer
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#platform-version-company"/>
  public class PlatformVersionCompany : IgdbEntityBase
  {
    /// <summary>
    /// Any notable comments about the developer
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// The company responsible for developing this platform version
    /// </summary>
    public IdentityOrValue<Company> Company { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Developer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Manufacturer { get; set; }
  }
}