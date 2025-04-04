namespace IGDB.Models
{
  /// <summary>
  /// The Date Format
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#date-format"/>
  public class DateFormat : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Format { get; set; }
  }
}