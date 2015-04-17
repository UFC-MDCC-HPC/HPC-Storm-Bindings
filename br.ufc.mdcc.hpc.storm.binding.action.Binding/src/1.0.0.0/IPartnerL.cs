using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;

namespace br.ufc.mdcc.hpc.storm.binding.action.Binding { 

public interface IPartnerL<PKL> : BaseIPartnerL<PKL>
where PKL:IPartnerKind
{


} // end main interface 

} // end namespace 
