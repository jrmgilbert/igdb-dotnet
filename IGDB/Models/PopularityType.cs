using System;

namespace IGDB.Models
{
  /// <summary>
  /// This describes what type of popularity primitive or popularity indicator the popularity value is
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#popularity-type"/>
  public class PopularityType : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<ExternalGameSource> ExternalPopularitySource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="ExternalPopularitySource"> instead
    /// </summary>
    [Obsolete("Use ExternalPopularitySource instead", error: false)]
    public Enums.PopularityTypeSource? PopularitySource { get; set; }
  }
}