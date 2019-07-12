using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Consumable :BaseItem {

	private string _itemEffect = "add 5 hp";
	public Consumable() {
		SetDescription();
	}

	protected override void SetDescription() {
		Description = "Health potion";
	}

	public override void UseItem() {
		base.UseItem();
		Game.hero.Inventory.Remove(this);
	}

	public override String CreateItemDescription() {
		StringBuilder sb = new StringBuilder();
		sb.AppendLine(Description);
		sb.AppendLine($"Effect: {this._itemEffect}");

		return sb.ToString();
	}
}
