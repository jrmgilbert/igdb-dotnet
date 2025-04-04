namespace IGDB.Models
{
  /// <summary>
  /// The format of the game release
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-release-format"/>
  public class GameReleaseFormat : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Format { get; set; }
  }
}