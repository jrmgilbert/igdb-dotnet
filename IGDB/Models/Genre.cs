namespace IGDB.Models
{
  /// <summary>
  /// Genres of video game
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#genre"/>
  public class Genre : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}