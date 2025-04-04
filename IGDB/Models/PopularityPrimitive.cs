using System;

namespace IGDB.Models
{
  /// <summary>
  /// Popularity Primitives, this endpoint lists available primitives with their source and popularity type
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#popularity-primitive"/>
  public class PopularityPrimitive : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public DateTimeOffset? CalculatedAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<ExternalGameSource> ExternalPopularitySource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int? GameId { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="ExternalPopularitySource"> instead
    /// </summary>
    [Obsolete("Use ExternalPopularitySource instead", error: false)]
    public Enums.PopularityPrimitiveSource? PopularitySource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<PopularityType> PopularityType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal? Value { get; set; }
  }

}