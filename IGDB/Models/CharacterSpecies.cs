namespace IGDB.Models
{
  /// <summary>
  /// Character Species
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#character-specie"/>
  public class CharacterSpecies : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
  }
}