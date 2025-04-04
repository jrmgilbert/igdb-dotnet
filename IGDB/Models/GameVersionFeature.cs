namespace IGDB.Models
{
  /// <summary>
  /// Features and descriptions of what makes each version/edition different from the main game
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#game-version-feature"/>
  public class GameVersionFeature : IgdbEntityBase
  {
    /// <summary>
    /// The category of the feature description
    /// </summary>
    public GameVersionFeatureCategory Category { get; set; }

    /// <summary>
    /// The description of the feature
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Position of this feature in the list of features
    /// </summary>
    public int? Position { get; set; }

    /// <summary>
    /// The title of the feature
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The bool/text value of the feature
    /// </summary>
    public IdentitiesOrValues<GameVersionFeatureValue> Values { get; set; }
  }

  public enum GameVersionFeatureCategory
  {
    Boolean = 0,
    Description = 1
  }
}