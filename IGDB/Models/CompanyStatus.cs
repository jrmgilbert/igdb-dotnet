namespace IGDB.Models
{
  /// <summary>
  /// Company Status
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#company-status"/>
  public class CompanyStatus : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
  }
}