using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Creature
{
	public virtual int XPValue { get; protected set; }
	public int Level { get; protected set; }

	public String Name { get; protected set; }
	public int Health { get; internal set; }
	public int HitChance { get; protected set; }
	public int Attacks { get; protected set; }
	public int Armour { get; protected set; }
	public int MinimumDamage { get; protected set; }
	public int MaximumDamage { get; protected set; }

	public Creature() {
		Level = 1;
	}

	public Creature(int xpValue, String name, int health, int level)
	{
		XPValue = xpValue;
		Name = name;
		Health = health;
		Level = level;
	}

	protected int CalculateDamage() {
		Random random = new Random();
		return random.Next(MinimumDamage, MaximumDamage);
	}
}
