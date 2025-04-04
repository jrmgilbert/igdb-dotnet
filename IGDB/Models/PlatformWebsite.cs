namespace IGDB.Models
{
  /// <summary>
  /// The main website for the platform
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#platform-website"/>
  public class PlatformWebsite : IgdbEntityBase
  {
    /// <summary>
    /// The service this website links to
    /// </summary>
    public Enums.PlatformWebsiteCategory? Category { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Trusted { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}