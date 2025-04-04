using System;

namespace IGDB.Models
{
  /// <summary>
  /// DEPRECATED! Use <see cref="AgeRatingContentDescriptionV2"/> instead
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#age-rating-content-description"/>
  [Obsolete("Use AgeRatingContentDescriptionV2 instead", error: false)]
  public class AgeRatingContentDescription : IgdbEntityBase
  {
    /// <summary>
    /// DEPRECATED!
    /// </summary>
    [Obsolete("DEPRECATED", error: false)]
    public Enums.AgeRatingContentDescriptionCategory? Category { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Description { get; set; }
  }
}