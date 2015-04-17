/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;
using br.ufc.mdcc.hpe.storm.binding.context.PartnerKindComponent;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImplMNCCD { 

public abstract class BaseIPartnerRImpl<PKR>: Synchronizer, BaseIPartnerR<PKR>
where PKR:IPartnerKindComponent
{

private IChannelR<PKR> channel = null;

protected IChannelR<PKR> Channel {
	get {
		if (this.channel == null)
			this.channel = (IChannelR<PKR>) Services.getPort("channel");
		return this.channel;
	}
}



}

}
