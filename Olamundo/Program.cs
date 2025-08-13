using System;
using System.Text;

class Program
{
    static void Main()
    {
        TerrainEnum[,] map =
        {
            { TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.WATER, TerrainEnum.WATER },
            { TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.SAND },
            { TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.SAND },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.GRASS },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.SAND, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.WALL, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.WALL },
            { TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.GRASS, TerrainEnum.SAND, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER, TerrainEnum.WATER }
        };

        Console.OutputEncoding = Encoding.UTF8;

        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int col = 0; col < map.GetLength(1); col++)
            {
                Console.ForegroundColor = map[row, col].GetColor();
                Console.Write(map[row, col].GetChar() + " ");
            }
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
