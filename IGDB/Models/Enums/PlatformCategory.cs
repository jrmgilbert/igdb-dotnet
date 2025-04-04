using System;

namespace IGDB.Models.Enums
{
  [Obsolete("Use PlatformType instead", error: false)]
  public enum PlatformCategory
  {
    Console = 1,
    Arcade = 2,
    Platform = 3,
    OperatingSystem = 4,
    PortableConsole = 5,
    Computer = 6
  }
}