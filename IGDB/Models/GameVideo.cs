namespace IGDB.Models
{
  /// <summary>
  /// A video associated with a game
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-video"/>
  public class GameVideo : IgdbEntityBase
  {
    /// <summary>
    /// The game this video is associated with
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// The name of the video
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The external ID of the video (YouTube Links)
    /// </summary>
    public string VideoId { get; set; }
  }
}