using System;

namespace IGDB.Models
{
  /// <summary>
  /// 
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#search"/>
  public class Search : IHasChecksum
  {
    /// <summary>
    /// 
    /// </summary>
    public string AlternativeName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Character> Character { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Checksum { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Collection> Collection { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Company> Company { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Platform> Platform { get; set; }

    /// <summary>
    /// The date this item was initially published by the third party
    /// </summary>
    public DateTimeOffset? PublishedAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentityOrValue<Theme> Theme { get; set; }
  }
}