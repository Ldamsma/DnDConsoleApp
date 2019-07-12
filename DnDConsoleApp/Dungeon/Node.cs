using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Node {

	public Room room;

	public Node() {
		CreateRoom();
	}

	public Node(Enums.RoomType roomType) {
		this.room = new Room(roomType);
	}

	private void CreateRoom() {
		this.room = new Room();
	}
}

