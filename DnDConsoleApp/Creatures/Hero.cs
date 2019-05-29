using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hero : Creature
{
	private int _heroXP;
	public List<BaseItem> Inventory;
	//private List<Item> Items { get; set; }
	public override int XPValue {
		get {
			return _heroXP;
		}
		protected set {
			_heroXP = _heroXP + value;

			// Level up?
			if (_heroXP >= Level)
			{
				// level berekening
			}
		}
	}

	public Hero() : base() {
		base.Health = 8;
		this._heroXP = 0;
		this.Inventory = new List<BaseItem>();
	}

	public Hero(int xpValue, string name, int health, int level) : base(xpValue, name, health, level)
	{
		
	}

}
