using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExploringState : State {
	private StateManager _stateManager;

	public ExploringState(StateManager stateManager) {
		this._stateManager = stateManager;
	}

	public override void PrintOptions() {
		base.PrintOptions();

		if (!string.IsNullOrEmpty(this._outputMessage)) { Console.WriteLine(this._outputMessage); };

		StringBuilder sb = new StringBuilder();
		sb.AppendLine(Game.Dungeon.CurrentRoom.GetDescription());

		if (Game.Dungeon.CurrentRoom.ContainsEnemies()) { sb.AppendLine(Game.Dungeon.CurrentRoom.GetEnemyDescription()); }

		sb.AppendLine("What would you like to do?");
		sb.AppendLine("Fight|Run|GrabItem|Rest|OpenInventory|ShowMap|ShowCharacteristics|Quit");
		Console.WriteLine(sb.ToString());

		this._outputMessage = string.Empty;
	}

	public override void HandleAction(String action) {
		string loweredAction = action.ToLower();

		switch (loweredAction) {
			case "fight":
				if (Game.Dungeon.CurrentRoom.ContainsEnemies()) {
					this._stateManager.ChangeState(this._stateManager.CombatState);
				} else {
					this._outputMessage = "No enemies to fight!";
				}
				break;
			case "run":
				// Placeholder code
				Game.Dungeon.GenerateDungeon();

				break;
			case "grabitem":
				if (Game.Dungeon.CurrentRoom.item != null) {
					Game.hero.Inventory.Add(Game.Dungeon.CurrentRoom.item);
					Game.Dungeon.CurrentRoom.item = null;
				}
				break;
			case "rest":
				this._outputMessage = "Resting is not yet implemented";
				break;
			case "openinventory":
				this._stateManager.ChangeState(this._stateManager.InventoryState);
				break;
			case "showmap":
				this._outputMessage = Game.Dungeon.DrawMap();
				break;
			case "showcharacteristics":
				this._outputMessage = Game.hero.WriteCharacteristics();
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
