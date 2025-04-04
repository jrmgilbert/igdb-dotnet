namespace IGDB.Models
{
  /// <summary>
  /// The bool/text value of the feature
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-version-feature-value"/>
  public class GameVersionFeatureValue : IgdbEntityBase
  {
    /// <summary>
    /// The version/edition this value refers to
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// The id of the game feature
    /// </summary>
    public IdentityOrValue<GameVersionFeature> GameFeature { get; set; }

    /// <summary>
    /// The boole value of this feature
    /// </summary>
    public IncludedFeature? IncludedFeature { get; set; }

    /// <summary>
    /// The text value of this feature
    /// </summary>
    public string Note { get; set; }
  }

  public enum IncludedFeature
  {
    NotIncluded = 0,
    Included = 1,
    PreOrderOnly = 2
  }
}