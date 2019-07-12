using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

class Dungeon {
	public Floor[] Floors { get; private set; }
	public int Width { get; private set; }
	public int Height { get; private set; }
	public ConsoleColor BorderColor { get; set; }
	public Room CurrentRoom { get; private set; }

	private Floor _currentFloor;
	private Byte _floors;

	public Dungeon()
	{
		this.Height = 10;
		this.Width = 10;
		this._floors = 3;
		this.Floors = new Floor[_floors];
		GenerateDungeon();
		CurrentRoom = GetStartPosition();
	}

	private Room GetStartPosition() {
		return _currentFloor.GetStartPosition();
	}

	public void GenerateDungeon()
	{
		for (int i = 0; i < _floors; i++) {
			Floors[i] = new Floor(Width, Height);
		}
		_currentFloor = Floors[0];
	}

	public String DrawMap()
	{
		StringBuilder currentFloor =  _currentFloor.DrawFloor();

		AddLegend(ref currentFloor);

		return currentFloor.ToString();
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
		// Implementation pending.
	}
}
