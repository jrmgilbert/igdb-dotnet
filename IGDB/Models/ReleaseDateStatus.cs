namespace IGDB.Models
{
  /// <summary>
  /// An endpoint to provide definition of all of the current release date statuses
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#release-date-status"/>
  public class ReleaseDateStatus : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The description of the release date status
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The name of the release date status
    /// </summary>
    public string Name { get; set; }
  }
}