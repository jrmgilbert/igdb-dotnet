namespace IGDB.Models
{
  /// <summary>
  /// Regions for release dates
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#release-date-region"/>
  public class ReleaseDateRegion : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Region { get; set; }
  }
}