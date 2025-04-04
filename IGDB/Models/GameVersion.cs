namespace IGDB.Models
{
  /// <summary>
  /// Details about game editions and versions
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-version"/>
  public class GameVersion : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// Features and descriptions of what makes each version/edition different from the main game
    /// </summary>
    public IdentitiesOrValues<GameVersionFeature> Features { get; set; }

    /// <summary>
    /// The game these versions/editions are of
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// Game Versions and Editions
    /// </summary>
    public IdentitiesOrValues<Game> Games { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}