namespace IGDB.Models
{
  /// <summary>
  /// Average time to beat times for a game
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-time-to-beat"/>
  public class GameTimeToBeat : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// Average time (in seconds) to finish the game to 100% completion
    /// </summary>
    public int? Completely { get; set; }

    /// <summary>
    /// Total number of time to beat submissions for this game
    /// </summary>
    public int? Count { get; set; }

    /// <summary>
    /// The ID of the game associated with the time to beat data
    /// </summary>
    public int? GameId { get; set; }

    /// <summary>
    /// Average time (in seconds) to finish the game to its credits without spending notable time on extras such as side quests
    /// </summary>
    public int? Hastily { get; set; }

    /// <summary>
    /// Average time (in seconds) to finish the game while mixing in some extras such as side quests without being overly thorough
    /// </summary>
    public int? Normally { get; set; }
  }
}