using System;

namespace IGDB.Models
{
  /// <summary>
  /// Video game companies. Both publishers & developers
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#company"/> 
  public class Company : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The date when a company got a new ID
    /// </summary>
    public DateTimeOffset? ChangeDate { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="ChangeDateFormat"/> instead
    /// </summary>
    [Obsolete("Use ChangeDateFormat instead", error: false)]
    public Enums.ChangeDateCategory? ChangeDateCategory { get; set; }

    /// <summary>
    /// The format of the change date
    /// </summary>
    public IdentityOrValue<DateFormat> ChangeDateFormat { get; set; }

    /// <summary>
    /// The new ID for a company that has gone through a merger or restructuring
    /// </summary>
    public IdentityOrValue<Company> ChangedCompanyId { get; set; }

    /// <summary>
    /// ISO 3166-1 country code
    /// </summary>
    public int? Country { get; set; }

    /// <summary>
    /// A free text description of a company
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// An array of games that a company has developed
    /// </summary>
    public IdentitiesOrValues<Game> Developed { get; set; }

    /// <summary>
    /// The company’s logo
    /// </summary>
    public IdentityOrValue<CompanyLogo> Logo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A company with a controlling interest in a specific company
    /// </summary>
    public IdentityOrValue<Company> Parent { get; set; }

    /// <summary>
    /// An array of games that a company has published
    /// </summary>
    public IdentitiesOrValues<Game> Published { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// The date a company was founded
    /// </summary>
    public DateTimeOffset? StartDate { get; set; }

    /// <summary>
    /// DEPRECATED! Use <see cref="StartDateFormat"> instead
    /// </summary>
    [Obsolete("Use StartDateFormat instead", error: false)]
    public Enums.StartDateCategory? StartDateCategory { get; set; }

    /// <summary>
    /// The format of the start date
    /// </summary>
    public IdentityOrValue<DateFormat> StartDateFormat { get; set; }

    /// <summary>
    /// The status of the company
    /// </summary>
    public IdentityOrValue<CompanyStatus> Status { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// The companies official websites
    /// </summary>
    public IdentitiesOrValues<CompanyWebsite> Websites { get; set; }
  }
}