namespace IGDB.Models
{
  /// <summary>
  /// Age Rating according to various rating organisations
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#age-rating-organization"/>
  public class AgeRatingOrganization : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The title of an age rating organization
    /// </summary>
    public string Name { get; set; }
  }
}