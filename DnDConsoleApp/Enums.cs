using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Enums
{
    public enum GameOptions
    {
        StartNewGame = 1,
        LoadGame = 2,
        Options = 3,
        QuitGame = 4
    }

    public enum RoomType
    {
        StartLocation,
        BossRoom,
        NormalRoom,
        StairsUp,
        StairsDown,
        Undifined
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}
