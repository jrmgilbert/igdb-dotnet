namespace IGDB.Models
{
  /// <summary>
  /// Game localization for a game
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-localization"/>
  public class GameLocalization : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The cover of this game localization
    /// </summary>
    public IdentityOrValue<Cover> Cover { get; set; }

    /// <summary>
    /// The Game the localization belongs to
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Region of the localization
    /// </summary>
    public IdentityOrValue<Region> Region { get; set; }
  }
}