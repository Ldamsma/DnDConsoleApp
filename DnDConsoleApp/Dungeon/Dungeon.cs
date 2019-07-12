using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

class Dungeon {
	public Floor[] Floors { get; private set; }
	public int Width { get; set; }
	public int Height { get; set; }
	public ConsoleColor BorderColor { get; set; }
	public Room CurrentRoom { get; private set; }

	public Dungeon()
	{
		this.Height = 10;
		this.Width = 10;
		GenerateDungeon();
	}

	public void GenerateDungeon()
	{
		Room[,] myRooms = new Room[Width, Height];
		for (int i = 0; i< Width; i++){
			for (int j = 0; j< Height; j++)
			{
				myRooms[i, j] = new Room(Enums.RoomType.NormalRoom);
			}
		}
		CurrentRoom = myRooms[0, 0];
	}

	public String DrawMap()
	{
		StringBuilder totalMap = new StringBuilder();
		string emptySpace = " ";
		string unvisitedRoom = ".";

		totalMap.AppendLine("Dungeon Map:");
		for (int i = 0; i < this.Height; i++)
		{
			for (int j = 0; j < this.Width; j++)
			{
				totalMap.Append(emptySpace);
				totalMap.Append(unvisitedRoom);
				totalMap.Append(emptySpace);
			}
			totalMap.Append("\n");
		}

		totalMap.AppendLine();
		AddLegend(ref totalMap);

		return totalMap.ToString();
	}

	private void AddLegend(ref StringBuilder totalMap) {
		totalMap.AppendLine("|- : Hallway");
		totalMap.AppendLine("S  : Start location");
		totalMap.AppendLine("F  : Final boss");
		totalMap.AppendLine("N  : Normal room");
		totalMap.AppendLine("D  : Stairs down");
		totalMap.AppendLine("U  : Stairs up");
		totalMap.AppendLine(".  : Not visited room");
	}

	public void Shuffle() {
		// Implementation pendig.
	}
}
