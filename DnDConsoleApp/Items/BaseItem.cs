using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class BaseItem {
	public String Description { get; protected set; }

	protected virtual void SetDescription() {
		Description = "Standard itemdescription";
	}
}
