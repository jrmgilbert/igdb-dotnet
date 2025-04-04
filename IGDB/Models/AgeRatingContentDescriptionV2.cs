namespace IGDB.Models
{
  /// <summary>
  /// Age Rating Content Descriptors
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#age-rating-content-description-v2"/>
  public class AgeRatingContentDescriptionV2 : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    ///	The rating organization
    /// </summary>
    public IdentityOrValue<AgeRatingOrganization> Organization { get; set; }
  }
}