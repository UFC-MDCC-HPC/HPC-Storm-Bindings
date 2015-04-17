using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;

namespace br.ufc.mdcc.hpc.storm.binding.action.Binding { 

public interface IPartnerR<PKR> : BaseIPartnerR<PKR>
where PKR:IPartnerKind
{


} // end main interface 

} // end namespace 
