namespace IGDB.Models
{
  /// <summary>
  /// A collection of closely related platforms
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#platform-family"/>
  public class PlatformFamily : IgdbEntityBase
  {
    /// <summary>
    /// The name of the platform family
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }
  }
}