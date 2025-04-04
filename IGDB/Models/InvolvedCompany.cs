namespace IGDB.Models
{
  /// <summary>
  /// 
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#involved-company"/>
  public class InvolvedCompany : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Company> Company { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Developer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Porting { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Publisher { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Supporting { get; set; }
  }
}