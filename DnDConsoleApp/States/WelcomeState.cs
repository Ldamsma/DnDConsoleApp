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

		StringBuilder sb = CreateStartScreen();

		sb.AppendLine("What would you like to do?");
		sb.AppendLine("New Game | Load Game | Options | Quit Game");

		Console.Write(sb);
	}

	private StringBuilder CreateStartScreen() {
		StringBuilder sb = new StringBuilder();

		sb.AppendLine(@"-------------------------------------------------------------------------------------------------");
		sb.AppendLine(@" _____                                                    _____                                  ");
		sb.AppendLine(@"|  __ \                                           ___    |  __ \                                 ");
		sb.AppendLine(@"| |  | |_   _ _ __   __ _  ___  ___  _ __  ___   ( _ )   | |  | |_ __ __ _  __ _  ___  _ __  ___ ");
		sb.AppendLine(@"| |  | | | | | '_ \ / _` |/ _ \/ _ \| '_ \/ __|  / _ \/\ | |  | | '__/ _` |/ _` |/ _ \| '_ \/ __|");
		sb.AppendLine(@"| |__| | |_| | | | | (_| |  __/ (_) | | | \__ \ | (_>  < | |__| | | | (_| | (_| | (_) | | | \__ \");
		sb.AppendLine(@"|_____/ \__,_|_| |_|\__, |\___|\___/|_| |_|___/  \___/\/ |_____/|_|  \__,_|\__, |\___/|_| |_|___/");
		sb.AppendLine(@"                     __/ |                                                  __/ |                ");
		sb.AppendLine(@"                    |___/                                                  |___/                 ");
		sb.AppendLine(@"-------------------------------------------------------------------------------------------------");

		return sb;
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
