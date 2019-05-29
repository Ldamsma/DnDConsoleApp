using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CombatState : State {
	private StateManager stateManager;

	public CombatState(StateManager stateManager) {
		this.stateManager = stateManager;
	}

	public override void PrintOptions() {
		StringBuilder sb = new StringBuilder();
		sb.AppendLine("You're doing Combat!");
		sb.AppendLine("What would you like to do?");
		sb.AppendLine("Attack|Run|UseItem");
		Console.Write(sb.ToString());
	}

	public override void HandleAction(String action) {
		string lowerdString = action.ToLower();
		switch (action) {
			case "attack":
				break;
			case "run":
				break;
			case "useitem":
				break;
			default:
				Console.WriteLine("Not recognized.");
				break;
		}
	}
}
