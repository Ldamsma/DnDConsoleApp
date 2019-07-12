using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WelcomeState : State{

	private StateManager _statemanager;

	public WelcomeState(StateManager manager) {
		this._statemanager = manager;
	}

	public override void PrintOptions() {
		base.PrintOptions();

		StringBuilder sb = new StringBuilder();
		sb.AppendLine("STARTSCHERM");
		sb.AppendLine("What would you like to do?");
		sb.AppendLine("New Game | Load Game | Options | Quit Game");

		Console.Write(sb);
	}

	public override void HandleAction(String action) {
		string compare = action.ToLower();
		switch (compare) {
			case "new game":
				Console.WriteLine("Give your character a name:");
				string name = Console.ReadLine();

				Game.Dungeon = new Dungeon();
				Game.hero = new Hero(name: name);
				this._statemanager.ChangeState(_statemanager.ExploringState);
				break;
			case "load game":
				Console.WriteLine("Loading is not Implemented!");
				break;
			case "options":
				Console.WriteLine("Options are not Implemented!");
				break;
			case "quit game":
				Game._keepRunning = false;
				break;
			default:
				Console.WriteLine("Unknown Key pressed!");
				break;
		}
	}
}
