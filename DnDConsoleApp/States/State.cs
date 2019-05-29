using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class State {

	public virtual void PrintOptions() {
		Console.WriteLine("Bad stuff, is base state.");
	}

	public virtual void HandleAction(string action) {
		Console.WriteLine("Bad stuff, is base state.");
	}
}
