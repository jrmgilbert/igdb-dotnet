
namespace IGDB.Models
{
  /// <summary>
  /// official artworks (resolution and aspect ratio may vary)
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#artwork"/>
  public class Artwork : IgdbImageEntityBase
  {
    /// <summary>
    /// The game this artwork is associated with
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }
  }
}