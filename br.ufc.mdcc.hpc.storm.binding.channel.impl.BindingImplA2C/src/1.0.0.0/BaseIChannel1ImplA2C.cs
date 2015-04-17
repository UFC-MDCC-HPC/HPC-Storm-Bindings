/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKind;
using br.ufc.mdcc.hpc.storm.binding.context.partner_kind.A2C;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.channel.impl.BindingImplA2C { 

public abstract class BaseIChannel1ImplA2C<PK>: Synchronizer, BaseIChannelL<PK>
where PK:IUserA2C
{

private PK partners_kind = default(PK);

protected PK Partners_kind {
	get {
		if (this.partners_kind == null)
			this.partners_kind = (PK) Services.getPort("partners_kind");
		return this.partners_kind;
	}
}



}

}
