namespace IGDB.Models
{
  /// <summary>
  /// Alternative and international game titles
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#alternative-name"/>
  public class AlternativeName : IgdbEntityBase
  {
    /// <summary>
    /// A description of what kind of alternative name it is (Acronym, Working title, Japanese title etc)
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// The game this alternative name is associated with
    /// </summary>
    public IdentityOrValue<Game> Game { get; set; }

    /// <summary>
    /// An alternative name
    /// </summary>
    public string Name { get; set; }
  }
}