namespace IGDB.Models
{
  /// <summary>
  /// Character Genders
  /// </summary>
  /// <seealso href="https://api-docs.igdb.com/#character-gender"/>
  public class CharacterGender : IgdbTimestampedEntityBase
  {
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
  }
}