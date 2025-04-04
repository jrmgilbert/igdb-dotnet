using System;

namespace IGDB.Models.Enums
{
  [Obsolete("Use GameStatus instead", error: false)]
  public enum GameStatus
  {
    Released = 0,
    Alpha = 2,
    Beta = 3,
    EarlyAccess = 4,
    Offline = 5,
    Cancelled = 6,
    Rumored = 7,
    Delisted = 8
  }
}