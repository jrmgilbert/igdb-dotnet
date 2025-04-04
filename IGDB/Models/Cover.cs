namespace IGDB.Models
{
  /// <summary>
  /// The cover art of games
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#cover"/>
  public class Cover : IgdbImageEntityBase
  {
    /// <summary>
    /// The game this cover is associated with.
    /// If it is empty then this cover belongs to a game_localization, which can be found under game_localization field
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// The game localization this cover might be associated with
    /// </summary>
    public IdentityOrValue<GameLocalization> GameLocalization { get; set; }
  }
}