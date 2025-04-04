namespace IGDB.Models
{
  /// <summary>
  /// Collection, AKA Series
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#collection"/>
  public class Collection : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public IdentitiesOrValues<CollectionRelation> AsChildRelations { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IdentitiesOrValues<CollectionRelation> AsParentRelations { get; set; }

    /// <summary>
    /// The games that are associated with this collection
    /// </summary>
    public IdentitiesOrValues<Game> Games { get; set; }

    /// <summary>
    /// Umbrella term for a collection of games
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// The type of collection
    /// </summary>
    public IdentityOrValue<CollectionType> Type { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}