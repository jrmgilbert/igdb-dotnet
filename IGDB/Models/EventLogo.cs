using System;

namespace IGDB.Models
{
  /// <summary>
  /// Logo for the event
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#event-logo"/> 
  public class EventLogo : IgdbImageEntityBase, ITimestamps
  {
    /// <summary>
    /// Date this was initially added to the IGDB database
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// The event associated with this logo.
    /// </summary>
    public IdentityOrValue<Event> Event { get; set; }

    /// <summary>
    /// The last date this entry was updated in the IGDB database
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}