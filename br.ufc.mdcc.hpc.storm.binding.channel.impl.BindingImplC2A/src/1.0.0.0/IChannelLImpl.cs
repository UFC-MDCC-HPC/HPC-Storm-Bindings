using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKindComponent;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.channel.impl.BindingImplC2A { 

public class IChannelLImpl<PKL> : BaseIChannelLImpl<PKL>, IChannelL<PKL>
where PKL:IPartnerKindComponent
{

public IChannelLImpl() { 

} 

public override void main() { 

}

}

}
