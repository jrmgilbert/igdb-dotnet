namespace IGDB.Models
{
  /// <summary>
  /// Social networks related to the event like twitter, facebook and youtube
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#network-type"/>
  public class NetworkType : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// Urls associated with the event type
    /// </summary>
    public IdentitiesOrValues<EventNetwork> EventNetworks { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
  }
}