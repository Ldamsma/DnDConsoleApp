using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StateManager {

	private State state;
	internal State previousState { get; private set; }

	internal State ExploringState { get; }
	internal State CombatState { get; }
	internal State InventoryState { get; }
	internal State WelcomeState { get; }

	public StateManager() {
		this.ExploringState = new ExploringState(this);
		this.CombatState = new CombatState(this);
		this.InventoryState = new InventoryState(this);
		this.WelcomeState = new WelcomeState(this);

		this.state = this.WelcomeState;
	}

	public void HandleAction(string action) {
		this.state.HandleAction(action);
	} 

	public void PrintOptions() {
		this.state.PrintOptions();
	}
	public void ChangeState(State state) {
		this.previousState = this.state;
		this.state = state;
	}

}
