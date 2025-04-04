namespace IGDB.Models
{
  /// <summary>
  /// The type that this game is
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-type"/>
  public class GameType : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Type { get; set; }
  }
}