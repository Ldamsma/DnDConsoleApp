using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Consumable :BaseItem {

	public Consumable() {
		SetDescription();
	}

	protected override void SetDescription() {
		Description = "Health potion";
	}
}
