using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Enemy : Creature, ICloneable
{
	public Enemy(int xpValue, string name, int health, int level, int attacks, int hitChance, int armour, string damage) : base(xpValue, name, health, level, attacks, hitChance, armour, damage) {
	}
    public Enemy(int xpValue, string name, int health, int level) : base(xpValue, name, health, level)
    {
    }

	/// <summary>
	/// Returns shallow clone
	/// </summary>
	/// <returns></returns>
	public Object Clone() {
		return (Enemy) this.MemberwiseClone();
	}
}
