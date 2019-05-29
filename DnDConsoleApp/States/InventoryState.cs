using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InventoryState : State {
	private StateManager stateManager;

	public InventoryState(StateManager stateManager) {
		this.stateManager = stateManager;
	}

	public override void PrintOptions() {
		StringBuilder sb = new StringBuilder();
		sb.AppendLine("Your inventory currently contains:");
		sb.AppendLine(CreateInventoryString());
		sb.AppendLine("What would you like to do?");
		sb.AppendLine("");
		Console.WriteLine(sb.ToString());
	}

	public override void HandleAction(String action) {
		string loweredAction = action.ToLower();
		switch (loweredAction) {
			case "":
				break;
		}
	}

	private String CreateInventoryString() {
		string inventoryString = "Nothing";
		Boolean isFirst = true;
		if (Game.hero.Inventory.Count > 0) {
			inventoryString = "";
			foreach (BaseItem item in Game.hero.Inventory) {
				if (isFirst) {
					inventoryString = item.Description;
				} else {
					inventoryString += $" | {item.Description}";
				}
			}
		}
		return inventoryString;

	}


}
