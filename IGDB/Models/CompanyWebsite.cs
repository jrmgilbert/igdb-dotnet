using System;

namespace IGDB.Models
{
  /// <summary>
  /// Company Website
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#company-website"/>
  public class CompanyWebsite : IgdbEntityBase
  {
    /// <summary>
    /// DEPRECATED! Use <see cref="Type"> instead
    /// </summary>
    [Obsolete("Use Type instead", error: false)]
    public Enums.CompanyWebsiteCategory? Category { get; set; }

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