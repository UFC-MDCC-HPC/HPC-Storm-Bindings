/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.ActionInterface;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKindApplication;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImpl1NACI { 

public abstract class BaseIPartnerLImpl<PKL, A>: Synchronizer, BaseIPartnerL<PKL, A>
where PKL:IPartnerKindApplication
where A:IActionInterfaceProvider
{

private A action_interface = default(A);

protected A Action_interface {
	get {
		if (this.action_interface == null)
			this.action_interface = (A) Services.getPort("action_interface");
		return this.action_interface;
	}
}

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
