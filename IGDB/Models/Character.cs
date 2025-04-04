using System;

namespace IGDB.Models
{
  /// <summary>
  /// Video game characters
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#character"/>
  public class Character : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// Alternative names for a character
    /// </summary>
    public string[] Akas { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<CharacterGender> CharacterGender { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<CharacterSpecies> CharacterSpecies { get; set; }

    /// <summary>
    /// A characters country of origin
    /// </summary>
    public string CountryName { get; set; }

    /// <summary>
    /// A text describing a character
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentitiesOrValues<Game> Games { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="CharacterGender"/> instead
    /// </summary>
    [Obsolete("Use CharacterGender instead", error: false)]
    public Enums.Gender? Gender { get; set; }

    /// <summary>
    /// An image depicting a character
    /// </summary>
    public IdentityOrValue<CharacterMugShot> MugShot { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="CharacterSpecies"/> instead
    /// </summary>
    [Obsolete("Use CharacterSpecies instead", error: false)]
    public Enums.Species? Species { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}