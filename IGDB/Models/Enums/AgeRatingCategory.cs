using System;

namespace IGDB.Models.Enums
{
  [Obsolete("Use AgeRatingOrganization instead", error: false)]
  public enum AgeRatingCategory
  {
    ESRB = 1,
    PEGI = 2,
    CERO = 3,
    USK = 4,
    GRAC = 5,
    CLASS_IND = 6,
    ACB = 7
  }
}