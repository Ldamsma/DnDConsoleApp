using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Equipment : BaseItem {
	private string _itemEffect = "add 5 damage";

	public Equipment() {
		SetDescription();
	}

	protected override void SetDescription() {
		Description = "Glorious sword";
	}

	public override void UseItem() {
		base.UseItem();
	}

	public override String CreateItemDescription() {
		StringBuilder sb = new StringBuilder();
		sb.AppendLine(Description);
		sb.AppendLine($"Effects: {_itemEffect}");

		return sb.ToString();
	}
}
