using System;

namespace IGDB.Models
{
  /// <summary>
  /// Age Rating according to various rating organisations
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#age-rating"/>
  public class AgeRating : IgdbEntityBase
  {
    /// <summary>
    /// DEPRECATED! Use <see cref="Organization"/> instead
    /// </summary>
    [Obsolete("Use Organization instead", error: false)]
    public Enums.AgeRatingCategory? Category { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentitiesOrValues<AgeRatingContentDescription> ContentDescriptions { get; set; }

    /// <summary>
    /// The organization that has issued a specific rating
    /// </summary>
    public IdentityOrValue<AgeRatingOrganization> Organization { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="RatingCategory"> instead
    /// </summary>
    [Obsolete("Use RatingCategory instead", error: false)]
    public Enums.AgeRatingTitle? Rating { get; set; }

    /// <summary>
    /// The category of a rating
    /// </summary>
    public IdentityOrValue<AgeRatingCategory> RatingCategory { get; set; }

    /// <summary>
    /// The rating content descriptions
    /// </summary>
    public IdentitiesOrValues<AgeRatingContentDescriptionV2> RatingContentDescriptions { get; set; }

    /// <summary>
    /// The url for the image of a age rating
    /// </summary>
    public string RatingCoverUrl { get; set; }

    /// <summary>
    /// A free text motivating a rating
    /// </summary>
    public string Synopsis { get; set; }
  }
}