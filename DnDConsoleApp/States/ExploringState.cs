using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExploringState : State {
	private StateManager stateManager;

	public ExploringState(StateManager stateManager) {
		this.stateManager = stateManager;
	}

	public override void PrintOptions() {
		StringBuilder sb = new StringBuilder();
		sb.AppendLine(Game.Dungeon.CurrentRoom.GetDescription());
		sb.AppendLine("What would you like to do?");
		sb.AppendLine("Fight|Run|GrabItem|Rest|OpenInventory|ShowMap|ShowCharacteristics|Quit");
		Console.WriteLine(sb.ToString());
	}

	public override void HandleAction(String action) {
		string loweredAction = action.ToLower();

		switch (loweredAction) {
			case "fight":
				break;
			case "run":
				break;
			case "grabitem":
				if (Game.Dungeon.CurrentRoom.item != null) {
					Game.hero.Inventory.Add(Game.Dungeon.CurrentRoom.item);
					Game.Dungeon.CurrentRoom.item = null;
				}
				break;
			case "rest":
				break;
			case "openinventory":
				this.stateManager.ChangeState(this.stateManager.InventoryState);
				break;
			case "showmap":
				Game.Dungeon.DrawMap();
				break;
			case "characteristics":
				break;
			case "quit":
				Console.WriteLine("Are you sure you want to quit? Y/N");
				if (Console.ReadLine().ToLower() == "y") {
					Game._keepRunning = false;
				}
				// Want to save / save options / just quit.
				break;
			default:
				Console.WriteLine("Not recognized!");
				break;
		}
	}
}
