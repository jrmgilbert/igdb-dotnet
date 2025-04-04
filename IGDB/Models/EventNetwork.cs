namespace IGDB.Models
{
  /// <summary>
  /// Urls related to the event like twitter, facebook and youtube
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#event-network"/> 
  public class EventNetwork : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The event associated with this URL.
    /// </summary>
    public IdentityOrValue<Event> Event { get; set; }

    /// <summary>
    /// Network type
    /// </summary>
    public IdentityOrValue<NetworkType> NetworkType { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }
  }
}