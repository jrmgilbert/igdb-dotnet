namespace IGDB.Models
{
  /// <summary>
  /// Player perspectives describe the view/perspective of the player in a video game
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#player-perspective"/>
  public class PlayerPerspective : IgdbTimestampedEntityBase
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