using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Floor {
	private Int32 _width;
	private Int32 _height;
	private Node[,] _nodes;
	private Point _startPoint;

	public Floor(int width, int height) {
		this._width = width;
		this._height = height;
		SetRandomStartingPoint();
		GenerateFloor();
	}

	private void SetRandomStartingPoint() {
		Random random = new Random();
		this._startPoint.X = random.Next(0, this._width);
		this._startPoint.Y = random.Next(0, this._height);
	}

	private void GenerateFloor() {
		// Wanneer er een verdieping wordt gegenereerd moet er worden berekend dat alle kamers in de dungeon bezocht kunnen worden.
		this._nodes = new Node[this._width, this._height];
		for (int i = 0; i < this._width; i++) {
			for (int j = 0; j < this._height; j++) {
				if (i == this._startPoint.X && j == this._startPoint.Y) {
					this._nodes[i, j] = new Node(Enums.RoomType.StartLocation);
				} else {
					this._nodes[i, j] = new Node();
				}
			}
		}
	}

	internal StringBuilder DrawFloor() {
		StringBuilder totalMap = new StringBuilder();
		string emptySpace = " ";

		totalMap.AppendLine("Dungeon Map:");
		for (int i = 0; i < this._height; i++) {
			for (int j = 0; j < this._width; j++) {
				totalMap.Append(emptySpace);

				totalMap.Append(this._nodes[i, j].room.GetRoomTypeDescription());

				totalMap.Append(emptySpace);
			}
			totalMap.Append("\n");
		}

		totalMap.AppendLine();

		return totalMap;
	}

	internal Room GetStartPosition() {
		return this._nodes[this._startPoint.X, this._startPoint.Y].room;
	}
}
