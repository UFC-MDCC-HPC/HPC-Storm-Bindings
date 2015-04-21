using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.Protocol;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;
using br.ufc.mdcc.hpc.storm.binding.context.EnvironmentInterface;

namespace br.ufc.mdcc.hpc.storm.binding.enviroment.Binding { 

public interface IUser<IP, PKUser, UI> : BaseIUser<IP, PKUser, UI>
where IP:IUserProtocol
where PKUser:IPartnerKind
where UI:IEnvironmentInterface
{


} // end main interface 

} // end namespace 
