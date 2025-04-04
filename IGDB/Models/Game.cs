using System;

namespace IGDB.Models
{
  /// <summary>
  /// Video Games!
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game"/>
  public class Game : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The PEGI rating
    /// </summary>
    public IdentitiesOrValues<AgeRating> AgeRatings { get; set; }

    /// <summary>
    /// Rating based on external critic scores
    /// </summary>
    public double? AggregatedRating { get; set; }

    /// <summary>
    /// Number of external critic scores
    /// </summary>
    public int? AggregatedRatingCount { get; set; }

    /// <summary>
    /// Alternative names for this game
    /// </summary>
    public IdentitiesOrValues<AlternativeName> AlternativeNames { get; set; }

    /// <summary>
    /// Artworks of this game
    /// </summary>
    public IdentitiesOrValues<Artwork> Artworks { get; set; }

    /// <summary>
    /// The bundles this game is a part of
    /// </summary>
    public IdentitiesOrValues<Game> Bundles { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="GameType"> instead
    /// </summary>
    [Obsolete("Use GameType instead", error: false)]
    public Enums.Category? Category { get; set; }

    /// <summary>
    /// The collections that this game is in
    /// </summary>
    public IdentitiesOrValues<Collection> Collections { get; set; }

    /// <summary>
    /// The cover of this game
    /// </summary>
    public IdentityOrValue<Cover> Cover { get; set; }

    /// <summary>
    /// DLCs for this game
    /// </summary>
    public IdentitiesOrValues<Game> Dlcs { get; set; }

    /// <summary>
    /// Expanded games of this game
    /// </summary>
    public IdentitiesOrValues<Game> ExpandedGames { get; set; }

    /// <summary>
    /// Expansions of this game
    /// </summary>
    public IdentitiesOrValues<Game> Expansions { get; set; }

    /// <summary>
    /// External IDs this game has on other services
    /// </summary>
    public IdentitiesOrValues<ExternalGame> ExternalGames { get; set; }

    /// <summary>
    /// The first release date for this game
    /// </summary>
    public DateTimeOffset? FirstReleaseDate { get; set; }

    /// <summary>
    /// Forks of this game
    /// </summary>
    public IdentitiesOrValues<Game> Forks { get; set; }

    /// <summary>
    /// The main franchise
    /// </summary>
    public IdentityOrValue<Franchise> Franchise { get; set; }

    /// <summary>
    /// Other franchises the game belongs to
    /// </summary>
    public IdentitiesOrValues<Franchise> Franchises { get; set; }

    /// <summary>
    /// The game engine used in this game
    /// </summary>
    public IdentitiesOrValues<GameEngine> GameEngines { get; set; }

    /// <summary>
    /// Supported game localizations for this game. A region can have at most one game localization for a given game
    /// </summary>
    public IdentitiesOrValues<GameLocalization> GameLocalizations { get; set; }

    /// <summary>
    /// Modes of gameplay
    /// </summary>
    public IdentitiesOrValues<GameMode> GameModes { get; set; }

    /// <summary>
    /// The status of the games release
    /// </summary>
    public IdentityOrValue<GameStatus> GameStatus { get; set; }

    /// <summary>
    /// The type of game
    /// </summary>
    public IdentityOrValue<GameType> GameType { get; set; }

    /// <summary>
    /// Genres of the game
    /// </summary>
    public IdentitiesOrValues<Genre> Genres { get; set; }

    /// <summary>
    /// Number of follows a game gets before release
    /// </summary>
    public int? Hypes { get; set; }

    /// <summary>
    /// Companies who developed this game
    /// </summary>
    public IdentitiesOrValues<InvolvedCompany> InvolvedCompanies { get; set; }

    /// <summary>
    /// Associated keywords
    /// </summary>
    public IdentitiesOrValues<Keyword> Keywords { get; set; }

    /// <summary>
    /// Supported Languages for this game
    /// </summary>
    public IdentitiesOrValues<LanguageSupport> LanguageSupports { get; set; }

    /// <summary>
    /// Multiplayer modes for this game
    /// </summary>
    public IdentitiesOrValues<MultiplayerMode> MultiplayerModes { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// If a DLC, expansion or part of a bundle, this is the main game or bundle
    /// </summary>
    public IdentityOrValue<Game> ParentGame { get; set; }

    /// <summary>
    /// Platforms this game was released on
    /// </summary>
    public IdentitiesOrValues<Platform> Platforms { get; set; }

    /// <summary>
    /// The main perspective of the player
    /// </summary>
    public IdentitiesOrValues<PlayerPerspective> PlayerPerspectives { get; set; }

    /// <summary>
    /// Ports of this game
    /// </summary>
    public IdentitiesOrValues<Game> Ports { get; set; }

    /// <summary>
    /// Average IGDB user rating
    /// </summary>
    public double? Rating { get; set; }

    /// <summary>
    /// Total number of IGDB user ratings
    /// </summary>
    public int? RatingCount { get; set; }

    /// <summary>
    /// Release dates of this game
    /// </summary>
    public IdentitiesOrValues<ReleaseDate> ReleaseDates { get; set; }

    /// <summary>
    /// Remakes of this game
    /// </summary>
    public IdentitiesOrValues<Game> Remakes { get; set; }

    /// <summary>
    /// Remasters of this game
    /// </summary>
    public IdentitiesOrValues<Game> Remasters { get; set; }

    /// <summary>
    /// Screenshots of this game
    /// </summary>
    public IdentitiesOrValues<Screenshot> Screenshots { get; set; }

    /// <summary>
    /// Similar games
    /// </summary>
    public IdentitiesOrValues<Game> SimilarGames { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// Standalone expansions of this game
    /// </summary>
    public IdentitiesOrValues<Game> StandaloneExpansions { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="GameStatus"> instead
    /// </summary>
    [Obsolete("Use GameStatus instead", error: false)]
    public Enums.GameStatus? Status { get; set; }

    /// <summary>
    /// A short description of a games story
    /// </summary>
    public string Storyline { get; set; }

    /// <summary>
    /// A description of the game
    /// </summary>
    public string Summary { get; set; }

    /// <summary>
    /// Related entities in the IGDB API
    /// </summary>
    /// <seealso href="https://api-docs.igdb.com/#tag-numbers"/> 
    public int[] Tags { get; set; }

    /// <summary>
    /// Themes of the game
    /// </summary>
    public IdentitiesOrValues<Theme> Themes { get; set; }

    /// <summary>
    /// Average rating based on both IGDB user and external critic scores
    /// </summary>
    public double? TotalRating { get; set; }

    /// <summary>
    /// Total number of user and external critic scores
    /// </summary>
    public int? TotalRatingCount { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// If a version, this is the main game
    /// </summary>
    public IdentityOrValue<Game> VersionParent { get; set; }

    /// <summary>
    /// Title of this version (i.e Gold edition)
    /// </summary>
    public string VersionTitle { get; set; }

    /// <summary>
    /// Videos of this game
    /// </summary>
    public IdentitiesOrValues<GameVideo> Videos { get; set; }

    /// <summary>
    /// Websites associated with this game
    /// </summary>
    public IdentitiesOrValues<Website> Websites { get; set; }
  }
}