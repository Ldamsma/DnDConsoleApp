using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Equipment : BaseItem {

	public Equipment() {
		SetDescription();
	}

	protected override void SetDescription() {
		Description = "Glorious sword";
	}
}
