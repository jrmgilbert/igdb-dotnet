namespace IGDB.Models
{
  /// <summary>
  /// 
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#images"/>
  public abstract class IgdbImageEntityBase : IgdbEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public bool? AlphaChannel { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool? Animated { get; set; }

    /// <summary>
    /// The height of the image in pixels
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// The ID of the image used to construct an IGDB image link
    /// </summary>
    public string ImageId { get; set; }

    /// <summary>
    /// The website address (URL) of the item
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// The width of the image in pixels
    /// </summary>
    public int? Width { get; set; }
  }
}