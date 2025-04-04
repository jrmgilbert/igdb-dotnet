using System;

namespace IGDB.Models.Enums
{
  [Obsolete("Use ExternalGameSource instead", error: false)]
  public enum ExternalCategory
  {
    Steam = 1,
    GOG = 5,
    YouTube = 10,
    Microsoft = 11,
    Apple = 13,
    Twitch = 14,
    Android = 15,
    AmazonAsin = 20,
    AmazonLuna = 22,
    AmazonAdg = 23,
    EpicGameStore = 26,
    Oculus = 28,
    Utomik = 29,
    ItchIO = 30,
    XboxMarketplace = 31,
    Kartridge = 32,
    PlaystationStoreUS = 36,
    FocusEntertainment = 37,
    XboxGamePassUltimateCloud = 54,
    Gamejolt = 55
  }
}