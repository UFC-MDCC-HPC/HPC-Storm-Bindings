using br.ufc.pargo.hpe.kinds;

namespace br.ufc.mdcc.hpc.storm.binding.context.ActionInterface 
{ 
	public interface IActionInterfaceProvider : BaseIActionInterfaceProvider
	{
		// returns the list of actions.
		string[] Actions { get; }

	} // end main interface 

} // end namespace 
