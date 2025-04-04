namespace IGDB.Models
{
  /// <summary>
  /// Enums for collection types.
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#collection-type"/>
  public class CollectionType : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// Description of the collection type
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The name of the collection type
    /// </summary>
    public string Name { get; set; }
  }
}