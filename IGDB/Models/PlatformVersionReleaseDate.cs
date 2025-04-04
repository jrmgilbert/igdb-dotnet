using System;
using Newtonsoft.Json;

namespace IGDB.Models
{
  /// <summary>
  /// A handy endpoint that extends platform release dates. Used to dig deeper into release dates, platforms and versions.
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#platform-version-release-date"/>
  public class PlatformVersionReleaseDate : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// DEPRECATED! Use <see cref="DateFormat"> instead
    /// </summary>
    [Obsolete("Use DateFormat instead", error: false)]
    public Enums.ReleaseDateCategory? Category { get; set; }

    /// <summary>
    /// The release date
    /// </summary>
    public DateTimeOffset? Date { get; set; }

    /// <summary>
    /// The format of the change date
    /// </summary>
    public IdentityOrValue<DateFormat> DateFormat { get; set; }

    /// <summary>
    /// A human readable version of the release date
    /// </summary>
    public string Human { get; set; }

    /// <summary>
    /// The month as an integer starting at 1 (January)
    /// </summary>
    [JsonProperty("m")]
    public int? Month { get; set; }

    /// <summary>
    /// The platform this release date is for
    /// </summary>
    public IdentityOrValue<PlatformVersion> PlatformVersion { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="ReleaseRegion"/> instead
    /// </summary>
    [Obsolete("Use ReleaseRegion instead", error: false)]
    public Enums.ReleaseDateRegion? Region { get; set; }

    /// <summary>
    /// The region of the release
    /// </summary>
    public IdentityOrValue<ReleaseDateRegion> ReleaseRegion { get; set; }

    /// <summary>
    /// The year in full (2018)
    /// </summary>
    [JsonProperty("y")]
    public int? Year { get; set; }
  }
}