using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

class Game{
	public static bool _keepRunning = true;
	public static Dungeon Dungeon;
	public static Hero hero;

	static void Main(string[] args)
	{
		StateManager manager = new StateManager();

		do
		{
			manager.PrintOptions();
			manager.HandleAction(Console.ReadLine());
			//_gameDungeon.DrawMap();

		} while ( _keepRunning);
		// Present options: Start new game, Load game, Options, Quit game

		// Options pressed:
		// Aantal lagen, breedte, hoogte, Number tweaking?

		// Load Game Pressed:
		// Get character & Dungeon + existing point

		// Start New game pressed:
		// Generate dungeon and translate that to a Map class, which can be called from MAIN body
		//_gameDungeon.DrawMap();
			
		// Action Pressed:
		// Call action routine


		// Quit game pressed: 
		// Dispose all resources and close console app.
	}
}
