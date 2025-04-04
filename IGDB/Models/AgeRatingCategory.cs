namespace IGDB.Models
{
  /// <summary>
  /// The rating category from the organization
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#age-rating-category"/>
  public class AgeRatingCategory : IgdbTimestampedEntityBase
  {
    /// <summary>
    ///	The rating organization
    /// </summary>
    public IdentityOrValue<AgeRatingOrganization> Organization { get; set; }

    /// <summary>
    /// The rating name
    /// </summary>
    public string Rating { get; set; }
  }
}