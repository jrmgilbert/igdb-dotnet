namespace IGDB.Models
{
  /// <summary>
  /// Sources for the external games
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#external-game-source"/>
  public class ExternalGameSource : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
  }
}