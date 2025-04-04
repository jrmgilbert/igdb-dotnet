namespace IGDB.Models
{
  /// <summary>
  /// A website type, usually the name of the website
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#website-type"/>
  public class WebsiteType : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The website type
    /// </summary>
    public string Type { get; set; }
  }
}