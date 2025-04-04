using System;
using Newtonsoft.Json;

namespace IGDB.Models
{
  /// <summary>
  /// A handy endpoint that extends game release dates. Used to dig deeper into release dates, platforms and versions
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#release-date"/>
  public class ReleaseDate : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// DEPRECATED! Use <see cref="DateFormat"> instead
    /// </summary>
    [Obsolete("Use DateFormat instead", error: false)]
    public Enums.ReleaseDateCategory? Category { get; set; }

    /// <summary>
    /// The date of the release
    /// </summary>
    public DateTimeOffset? Date { get; set; }

    /// <summary>
    /// The format of the change date
    /// </summary>
    public IdentityOrValue<DateFormat> DateFormat { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// A human readable representation of the date
    /// </summary>
    public string Human { get; set; }

    /// <summary>
    /// The month as an integer starting at 1 (January)
    /// </summary>
    [JsonProperty("m")]
    public int? Month { get; set; }

    /// <summary>
    /// The platform of the release
    /// </summary>
    public IdentityOrValue<Platform> Platform { get; set; }

    /// <summary>
    /// DEPRECATED! Use ReleaseRegion instead
    /// </summary>
    [Obsolete("Use ReleaseRegion instead", error: false)]
    public Enums.ReleaseDateRegion? Region { get; set; }

    /// <summary>
    /// The region of the release
    /// </summary>
    public IdentityOrValue<ReleaseDateRegion> ReleaseRegion { get; set; }

    /// <summary>
    /// The status of the release
    /// </summary>
    public IdentityOrValue<ReleaseDateStatus> Status { get; set; }

    /// <summary>
    /// The year in full (2018)
    /// </summary>
    [JsonProperty("y")]
    public int? Year { get; set; }
  }
}