namespace IGDB.Models
{
  /// <summary>
  /// Collection Relation Types
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#collection-relation-type"/>
  public class CollectionRelationType : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The allowed child collection type
    /// </summary>
    public IdentityOrValue<CollectionType> AllowedChildType { get; set; }

    /// <summary>
    /// The allowed parent collection type
    /// </summary>
    public IdentityOrValue<CollectionType> AllowedParentType { get; set; }

    /// <summary>
    /// The relationship type description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The relationship type name
    /// </summary>
    public string Name { get; set; }
  }
}