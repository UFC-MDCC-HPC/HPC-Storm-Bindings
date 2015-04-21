using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;
using br.ufc.mdcc.hpc.storm.binding.context.ActionInterface;

namespace br.ufc.mdcc.hpc.storm.binding.action.Binding { 

public interface IPartnerL<PKL, A> : BaseIPartnerL<PKL, A>, TaskPort
where PKL:IPartnerKind
where A:IActionInterfaceProvider
{


} // end main interface 

} // end namespace 
