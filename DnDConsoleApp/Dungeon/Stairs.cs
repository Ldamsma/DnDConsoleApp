using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Stairs {

	public Enums.RoomType RoomType { get; private set; }

	public Stairs(Enums.RoomType roomType) {
		this.RoomType = roomType;
	}

	public void UseStairs() {
		//Game.Dungeon.SwitchFloors();
	}
}
