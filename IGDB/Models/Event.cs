using System;

namespace IGDB.Models
{
  /// <summary>
  /// Gaming event like GamesCom, Tokyo Game Show, PAX or GSL
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#event"/> 
  public class Event : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// The description of the event
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// End time of the event in UTC
    /// </summary>
    public DateTimeOffset? EndTime { get; set; }

    /// <summary>
    /// Logo of the event
    /// </summary>
    public IdentityOrValue<EventLogo> EventLogo { get; set; }

    /// <summary>
    /// Urls associated with the event
    /// </summary>
    public IdentitiesOrValues<EventNetwork> EventNetwork { get; set; }

    /// <summary>
    /// Games featured in the event
    /// </summary>
    public IdentitiesOrValues<Game> Games { get; set; }

    /// <summary>
    /// URL to the livestream of the event
    /// </summary>
    public string LiveStreamUrl { get; set; }

    /// <summary>
    /// The name of the event
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A url-safe, unique, lower-case version of the name
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// Start time of the event in UTC
    /// </summary>
    public DateTimeOffset? StartTime { get; set; }

    /// <summary>
    /// Timezone the event is in
    /// </summary>
    public string TimeZone { get; set; }

    /// <summary>
    /// Trailers featured in the event
    /// </summary>
    public IdentitiesOrValues<GameVideo> Videos { get; set; }
  }
}