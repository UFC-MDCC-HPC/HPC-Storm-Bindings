using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.partner_kind.A2C;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.channel.impl.BindingImplA2C { 

public class IChannel2ImplA2C<PK> : BaseIChannel2ImplA2C<PK>, IChannelR<PK>
where PK:IProviderA2C
{

public IChannel2ImplA2C() { 

} 

public override void main() { 

}

}

}
