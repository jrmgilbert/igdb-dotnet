using System;

namespace IGDB.Models
{
  /// <summary>
  /// The hardware used to run the game or game delivery network
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#platform"/>
  public class Platform : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// An abbreviation of the platform name
    /// </summary>
    public string Abbreviation { get; set; }

    /// <summary>
    /// An alternative name for the platform
    /// </summary>
    public string AlternativeName { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="PlatformType"/> instead
    /// </summary>
    [Obsolete("Use PlatformType instead", error: false)]
    public Enums.PlatformCategory? Category { get; set; }

    /// <summary>
    /// The generation of the platform
    /// </summary>
    public int? Generation { get; set; }

    /// <summary>
    /// The name of the platform
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The family of platforms this one belongs to
    /// </summary>
    public IdentityOrValue<PlatformFamily> PlatformFamily { get; set; }

    /// <summary>
    /// The logo of the first Version of this platform
    /// </summary>
    public IdentityOrValue<PlatformLogo> PlatformLogo { get; set; }

    /// <summary>
    /// The type of the platform
    /// </summary>
    public IdentityOrValue<PlatformType> PlatformType { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// The summary of the first Version of this platform
    /// </summary>
    public string Summary { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Associated versions of this platform
    /// </summary>
    public IdentitiesOrValues<PlatformVersion> Versions { get; set; }

    /// <summary>
    /// The main website
    /// </summary>
    public IdentitiesOrValues<PlatformWebsite> Websites { get; set; }
  }
}