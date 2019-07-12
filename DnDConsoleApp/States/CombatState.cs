using System;
using System.Text;

class CombatState : State {
	private StateManager stateManager;

	public CombatState(StateManager stateManager) {
		this.stateManager = stateManager;
	}

	public override void PrintOptions() {
		base.PrintOptions();

		if (this._outputMessage != null) { Console.WriteLine(this._outputMessage); }

		StringBuilder sb = new StringBuilder();
		sb.AppendLine("You're doing Combat!");
		sb.AppendLine("What would you like to do?");
		sb.AppendLine("Attack|Run|UseItem");

		Console.Write(sb.ToString());

		this._outputMessage = string.Empty;
	}

	public override void HandleAction(String action) {
		string lowerdString = action.ToLower();
		switch (action) {
			case "attack":
				break;
			case "run":
				this._outputMessage = "Run is not yet implemented";

				this.stateManager.ChangeState(this.stateManager.previousState);

				break;
			case "useitem":
				break;
			default:
				Console.WriteLine("Not recognized.");
				break;
		}
	}
}
