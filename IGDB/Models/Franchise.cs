namespace IGDB.Models
{
  /// <summary>
  /// A list of video game franchises such as Star Wars
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#franchise"/>
  public class Franchise : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The games that are associated with this franchise
    /// </summary>
    public IdentitiesOrValues<Game> Games { get; set; }

    /// <summary>
    /// The name of the franchise
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