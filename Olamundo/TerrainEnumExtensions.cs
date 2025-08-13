using System;

public static class TerrainEnumExtensions
{
    public static ConsoleColor GetColor(this TerrainEnum terrain)
    {
        switch (terrain)
        {
            case TerrainEnum.GRASS: return ConsoleColor.Green;
            case TerrainEnum.SAND: return ConsoleColor.Yellow;
            case TerrainEnum.WATER: return ConsoleColor.Blue;
            default: return ConsoleColor.DarkGray; // WALL
        }
    }

    public static char GetChar(this TerrainEnum terrain)
    {
        switch (terrain)
        {
            case TerrainEnum.GRASS: return '“';   // grama
            case TerrainEnum.SAND:  return '○';   // areia
            case TerrainEnum.WATER: return '≈';   // água
            default:                return '●';   // parede
        }
    }
}
