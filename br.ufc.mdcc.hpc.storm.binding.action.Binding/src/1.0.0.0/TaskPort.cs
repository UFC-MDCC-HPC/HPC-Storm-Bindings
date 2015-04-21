using System;

namespace br.ufc.mdcc.hpc.storm.binding.action.Binding
{
	public delegate void Action();

	public interface TaskPort
	{
		// Activate an action (returns after the partner is prepared to complete the action)		 
		void perform(string action);
		// Activate the first action for which the partner is prepared, completes and returns.
		string performAny(string[] action);
		 
		// Activate an asynchronously. After completed, it executes the method "action_reaction".
		ActionHandler performAsync(string action_name, Action action_reaction);
		/* Enters in a loop, where performAsync is executed interatively until the invocation of the terminate 
		 * method of the terminating object (TerminationHandler) returned. */
		Tuple<ActionHandler,TerminationHandler> performAsyncRepeated(string action_name, Action action_reaction);

		// Asynchronous version of performAny, with a action method associated to each branch.
		ActionHandler performAnyAsync(Tuple<string, Action>[] action_list);
		// Iterative version of performaAnyAsync, return a terminating object.
		Tuple<ActionHandler,TerminationHandler> performAnyAsyncRepeated(Tuple<string, Action>[] action_list);
	}

	public interface ActionHandler
	{
		// cancel the asynchronous action performed.
		void cancel();

		// returns how many times the asynchronous action has been completed.
		int completed_count();

		// returns which action has been completed at each iteration.
		string[] completed_actions();
	}

	public interface TerminationHandler
	{
		void terminate();
		void reset();
		bool Terminated { get; }
	}

	class ActionLoopTerminateImpl : TerminationHandler
	{
		#region Terminate implementation

		bool flag = false;

		public void terminate ()
		{
			flag = true;
		}

		public void reset ()
		{
			flag = false;
		}

		public bool Terminated {
			get {
				return flag;
			}
		}

		#endregion
	}

	class ActionHandlerImpl : ActionHandler
	{
		#region ActionHandler implementation

		public void cancel ()
		{
			throw new NotImplementedException ();
		}

		public int completed_count ()
		{
			throw new NotImplementedException ();
		}

		public string[] completed_actions ()
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

