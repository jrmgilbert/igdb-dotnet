namespace IGDB.Models
{
  /// <summary>
  /// The Collection Memberships
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#collection-membership"/>
  public class CollectionMembership : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The collection that is associated with this membership
    /// </summary>
    public IdentityOrValue<Collection> Collection { get; set; }

    /// <summary>
    /// The game that is associated with this membership
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// The Collection Membership Type
    /// </summary>
    public IdentityOrValue<CollectionMembershipType> Type { get; set; }
  }
}