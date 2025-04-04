namespace IGDB.Models
{
  /// <summary>
  /// Video game engines such as unreal engine.
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-engine"/>
  public class GameEngine : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// Companies who used this game engine
    /// </summary>
    public IdentitiesOrValues<Company> Companies { get; set; }

    /// <summary>
    /// Description of the game engine
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Logo of the game engine
    /// </summary>
    public IdentityOrValue<GameEngineLogo> Logo { get; set; }

    /// <summary>
    /// Name of the game engine
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Platforms this game engine was deployed on
    /// </summary>
    public IdentitiesOrValues<Platform> Platforms { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}