namespace IGDB.Models
{
  /// <summary>
  /// Keywords are words or phrases that get tagged to a game such as "world war 2" or "steampunk"
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#keyword"/>
  public class Keyword : IgdbTimestampedEntityBase
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