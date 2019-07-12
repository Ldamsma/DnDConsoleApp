using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class State {
	protected String _outputMessage;

	public virtual void PrintOptions() {
		Console.Clear();
	}

	public virtual void HandleAction(string action) {
		Console.WriteLine("Bad stuff, is base state.");
	}
}
