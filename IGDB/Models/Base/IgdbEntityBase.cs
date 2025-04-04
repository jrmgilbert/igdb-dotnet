namespace IGDB.Models
{
  public abstract class IgdbEntityBase : IIdentifier, IHasChecksum
  {
    /// <summary>
    /// 
    /// </summary>
    public long? Id { get; set; }

    /// <summary>
    /// Hash of the object
    /// </summary>
    public string Checksum { get; set; }
  }
}