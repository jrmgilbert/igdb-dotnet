using System;

namespace IGDB.Models.Enums
{
  [Obsolete("Use CharacterSpecies instead.", error: false)]
  public enum Species
  {
    Human = 1,
    Alien = 2,
    Animal = 3,
    Android = 4,
    Unknown = 5
  }
}