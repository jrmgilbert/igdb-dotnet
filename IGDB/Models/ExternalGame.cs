using System;

namespace IGDB.Models
{
  /// <summary>
  /// Game IDs on other services
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#external-game"/>
  public class ExternalGame : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// DEPRECATED! Use <see cref="ExternalGameSource"/> instead
    /// </summary>
    [Obsolete("Use ExternalGameSource instead", error: false)]
    public Enums.ExternalCategory? Category { get; set; }

    /// <summary>
    /// The ISO country code of the external game product
    /// </summary>
    public double[] Countries { get; set; }

    /// <summary>
    /// The source of the external game
    /// </summary>
    public IdentityOrValue<ExternalGameSource> ExternalGameSource { get; set; }

    /// <summary>
    /// The IGDB ID of the game
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// The release format of the external game
    /// </summary>
    public IdentityOrValue<GameReleaseFormat> GameReleaseFormat { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="GameReleaseFormat"/>  instead
    /// </summary>
    [Obsolete("Use GameReleaseFormat instead", error: false)]
    public Enums.ExternalGameMedia? Media { get; set; }

    /// <summary>
    /// The name of the game according to the other service
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The platform of the external game product
    /// </summary>
    public IdentityOrValue<Platform> Platform { get; set; }

    /// <summary>
    /// The other services ID for this game
    /// </summary>
    public string Uid { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// The year in full (2018)
    /// </summary>
    public int? Year { get; set; }
  }
}