using System;

namespace IGDB.Models.Enums
{
  [Obsolete("Use ExternalGameSource instead", error: false)]
  public enum PopularityTypeSource
  {
    Steam = 1,
    Igdb = 121
  }
}