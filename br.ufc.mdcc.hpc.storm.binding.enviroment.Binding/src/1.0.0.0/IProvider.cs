using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.Protocol;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;

namespace br.ufc.mdcc.hpc.storm.binding.enviroment.Binding { 

public interface IProvider<IP, PKProvider> : BaseIProvider<IP, PKProvider>
where IP:IProviderProtocol
where PKProvider:IPartnerKind
{


} // end main interface 

} // end namespace 
