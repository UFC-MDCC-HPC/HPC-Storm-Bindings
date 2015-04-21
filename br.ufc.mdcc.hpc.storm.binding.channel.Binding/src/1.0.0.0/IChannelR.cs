using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;

namespace br.ufc.mdcc.hpc.storm.binding.channel.Binding { 

public interface IChannelR<PKR> : BaseIChannelR<PKR>, Intercommunicator
where PKR:IPartnerKind
{


} // end main interface 

} // end namespace 
