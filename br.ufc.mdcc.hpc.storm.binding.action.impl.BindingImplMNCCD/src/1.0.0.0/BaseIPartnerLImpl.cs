/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKindComponent;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImplMNCCD { 

public abstract class BaseIPartnerLImpl<PKL>: Synchronizer, BaseIPartnerL<PKL>
where PKL:IPartnerKindComponent
{

private IChannelL<PKL> channel = null;

protected IChannelL<PKL> Channel {
	get {
		if (this.channel == null)
			this.channel = (IChannelL<PKL>) Services.getPort("channel");
		return this.channel;
	}
}



}

}
