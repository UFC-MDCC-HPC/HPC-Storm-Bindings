/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKindComponent;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.channel.impl.BindingImplC2C { 

	public abstract class BaseIChannelRImpl<PKR>: IntercommunicatorImpl, BaseIChannelR<PKR>
where PKR:IPartnerKindComponent
{

private PKR partner_kind_right = default(PKR);

protected PKR Partner_kind_right {
	get {
		if (this.partner_kind_right == null)
			this.partner_kind_right = (PKR) Services.getPort("partner_kind_right");
		return this.partner_kind_right;
	}
}



}

}
