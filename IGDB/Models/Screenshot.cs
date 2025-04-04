namespace IGDB.Models
{
  /// <summary>
  /// Screenshots of games
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#screenshot"/>
  public class Screenshot : IgdbImageEntityBase
  {
    /// <summary>
    /// The game this video is associated with
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }
  }
}