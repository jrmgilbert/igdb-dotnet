namespace IGDB.Models
{
  /// <summary>
  /// The release status of the game
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-status"/>
  public class GameStatus : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Status { get; set; }
  }
}