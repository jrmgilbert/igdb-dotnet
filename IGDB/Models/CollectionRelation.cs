namespace IGDB.Models
{
  /// <summary>
  /// Describes Relationship between Collections
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#collection-relation"/>
  public class CollectionRelation : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The child collection of this collection
    /// </summary>
    public IdentityOrValue<Collection> ChildCollection { get; set; }

    /// <summary>
    /// The parent collection of this collection
    /// </summary>
    public IdentityOrValue<Collection> ParentCollection { get; set; }

    /// <summary>
    /// The collection relationship type
    /// </summary>
    public IdentityOrValue<CollectionRelationType> Type { get; set; }
  }
}