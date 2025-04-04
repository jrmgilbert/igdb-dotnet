namespace IGDB.Models
{
  /// <summary>
  /// Languages that are used in the Language Support endpoint.
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#language"/>
  public class Language : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The combination of Language code and Country code
    /// </summary>
    public string Locale { get; set; }

    /// <summary>
    /// The English name of the Language
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Native Name of the Language
    /// </summary>
    public string NativeName { get; set; }
  }
}