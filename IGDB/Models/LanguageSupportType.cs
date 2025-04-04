namespace IGDB.Models
{
  /// <summary>
  /// Language Support Types contains the identifiers for the support types that Language Support uses
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#language-support-type"/>
  public class LanguageSupportType : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
  }
}