namespace IGDB.Models
{
  /// <summary>
  /// Games can be played with different languages for voice acting, subtitles, or the interface language
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#language-support"/>
  public class LanguageSupport : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Language> Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<LanguageSupportType> LanguageSupportType { get; set; }
  }
}