/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;
using br.ufc.mdcc.hpc.storm.binding.context.partner_kind.A2C;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImpl1NACI { 

public abstract class BaseIPartnerR1NACI<PK>: Synchronizer, BaseIPartnerR<PK>
where PK:IProviderA2C
{

private IChannelR<PK> channel = null;

protected IChannelR<PK> Channel {
	get {
		if (this.channel == null)
			this.channel = (IChannelR<PK>) Services.getPort("channel");
		return this.channel;
	}
}



}

}
