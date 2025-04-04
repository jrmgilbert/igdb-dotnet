using System;

namespace IGDB.Models
{
  public abstract class IgdbTimestampedEntityBase : IgdbEntityBase, ITimestamps
  {
    /// <summary>
    /// Date this was initially added to the IGDB database
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// The last date this entry was updated in the IGDB database
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}