namespace IGDB.Models
{
  /// <summary>
  /// Single player, Multiplayer etc
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-mode"/>
  public class GameMode : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The name of the game mode
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