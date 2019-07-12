using System;
using System.Collections.Generic;
using System.ComponentModel;
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
		[Description("S")] StartLocation,
		[Description("F")] BossRoom,
		[Description("N")] NormalRoom,
		[Description("U")] StairsUp,
		[Description("D")] StairsDown,
		[Description(".")] Undifined
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}
