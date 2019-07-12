using System;
using System.Text;

class InventoryState : State {
	private StateManager _stateManager;

	public InventoryState(StateManager stateManager) {
		this._stateManager = stateManager;
	}

	public override void PrintOptions() {
		base.PrintOptions();

		if (!string.IsNullOrEmpty(this._outputMessage)) { Console.WriteLine(this._outputMessage); };

		StringBuilder sb = new StringBuilder();
		sb.AppendLine("Your inventory currently contains:");
		sb.AppendLine(CreateInventoryString());
		sb.AppendLine("What would you like to do?");
		sb.AppendLine("Use [Item] | Check [Item] | Return");
		Console.WriteLine(sb.ToString());

		this._outputMessage = string.Empty;
	}

	public override void HandleAction(String action) {
		string[] input = action.ToLower().Split(char.Parse(" "));
		if (input != null && input[0] != "return") {
			string loweredAction = input[0];
			string itemName = action.Replace(input[0], "").Trim().ToLower();

			BaseItem foundItem = Game.hero.Inventory.Find(x => x.Description.ToLower().Equals(itemName));
			if (foundItem != null) {
				switch (loweredAction) {
					case "use":
						foundItem.UseItem();

						break;
					case "check":
						_outputMessage = foundItem.CreateItemDescription();

						break;
				}
			} else {
				Console.WriteLine($"Inventory does not contain: {itemName}");
			}
		} else if(input[0] == "return")	{
			this._stateManager.ChangeState(this._stateManager.previousState);
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
					isFirst = false;
				} else {
					inventoryString += $" | {item.Description}";
				}
			}
		}

		return inventoryString;
	}
}
