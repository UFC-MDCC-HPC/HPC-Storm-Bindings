using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.Protocol;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;
using br.ufc.mdcc.hpc.storm.binding.context.EnvironmentInterface;

namespace br.ufc.mdcc.hpc.storm.binding.enviroment.Binding { 

public interface IProvider<IP, PKProvider, PI> : BaseIProvider<IP, PKProvider, PI>
where IP:IProviderProtocol
where PKProvider:IPartnerKind
where PI:IEnvironmentInterface
{


} // end main interface 

} // end namespace 
