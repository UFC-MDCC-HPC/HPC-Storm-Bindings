using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.Protocol;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;

namespace br.ufc.mdcc.hpc.storm.binding.enviroment.Binding { 

public interface IUser<IP, PKUser> : BaseIUser<IP, PKUser>
where IP:IUserProtocol
where PKUser:IPartnerKind
{


} // end main interface 

} // end namespace 
