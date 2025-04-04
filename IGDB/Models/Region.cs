namespace IGDB.Models
{
  /// <summary>
  /// Region for game localization
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#region"/>
  public class Region : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// This can be either ’locale’ or ‘continent’
    /// </summary>
    public string Category { get; set; }

    /// <summary>
    /// This is the identifier of each region
    /// </summary>
    public string Identifier { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
  }
}