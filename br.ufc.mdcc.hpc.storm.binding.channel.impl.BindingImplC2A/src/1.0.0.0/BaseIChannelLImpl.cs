/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.channel.impl.BindingImplC2A { 

public abstract class BaseIChannelLImpl<PKL>: Synchronizer, BaseIChannelL<PKL>
where PKL:IPartnerKind
{

private PKL partner_kind_left = default(PKL);

protected PKL Partner_kind_left {
	get {
		if (this.partner_kind_left == null)
			this.partner_kind_left = (PKL) Services.getPort("partner_kind_left");
		return this.partner_kind_left;
	}
}



}

}
