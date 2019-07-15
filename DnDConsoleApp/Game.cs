using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

class Game{
	public static bool _keepRunning = true;
	public static Dungeon Dungeon;
	public static Hero hero;

	internal static List<Enemy> MonsterList = new List<Enemy>();

	private enum MonsterInfoColumns {
		Name,
		Level,
		Attack,
		Damage,
		Armour,
		Health
	}

	static void Main(string[] args)
	{
		StateManager manager = new StateManager();
		ReadMonsterList();
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

	static void ReadMonsterList() {
		if (MonsterList.Count == 0) {
			string line;
			StreamReader reader = new StreamReader("E:\\monsters.txt");
			while ((line = reader.ReadLine()) != null) {
				if (line.StartsWith("[")){
					string enemyString = line.Substring(1, line.Length - 2);
					String[] enemyStats = enemyString.Split(char.Parse(";"));
					String[] hitInfo = enemyStats.GetValue((int)MonsterInfoColumns.Attack).ToString().Split(Char.Parse("x"));

					int res = 0;
					int level = 99;
					if (int.TryParse(enemyStats.GetValue((int)MonsterInfoColumns.Level).ToString(), out res)) { level = res; }

					MonsterList.Add(new Enemy(0, enemyStats.GetValue((int)MonsterInfoColumns.Name).ToString(),
												 int.Parse(enemyStats.GetValue((int)MonsterInfoColumns.Health).ToString()),
												 level,
												 int.Parse(hitInfo.GetValue(0).ToString()),
												 int.Parse(hitInfo.GetValue(1).ToString()),
												 int.Parse(enemyStats.GetValue((int)MonsterInfoColumns.Armour).ToString()),
												 enemyStats.GetValue((int)MonsterInfoColumns.Damage).ToString()));
				}
			}
		}
	}
}