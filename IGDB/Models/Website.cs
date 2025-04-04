using System;

namespace IGDB.Models
{
  /// <summary>
  /// A website url, usually associated with a game
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#website"/>
  public class Website : IgdbEntityBase
  {
    /// <summary>
    /// DEPRECATED! Use <see cref="Type"/> instead
    /// </summary>
    [Obsolete("Use Type instead", error: false)]
    public Enums.WebsiteCategory? Category { get; set; }

    /// <summary>
    /// The game this website is associated with
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Trusted { get; set; }

    /// <summary>
    /// The website type associated with the website
    /// </summary>
    public IdentityOrValue<WebsiteType> Type { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}