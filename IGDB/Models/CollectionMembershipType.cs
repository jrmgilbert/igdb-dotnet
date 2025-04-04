namespace IGDB.Models
{
  /// <summary>
  /// Enums for collection membership types
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#collection-membership-type"/>
  public class CollectionMembershipType : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The allowed collection type
    /// </summary>
    public IdentityOrValue<CollectionType> AllowedCollectionType { get; set; }

    /// <summary>
    /// Description of the membership type
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The membership type name
    /// </summary>
    public string Name { get; set; }
  }
}