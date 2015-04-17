using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.partner_kind.C2C;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImplMNCCD { 

public class IPartnerRMNCCD<PK> : BaseIPartnerRMNCCD<PK>, IPartnerR<PK>
where PK:IProviderC2C
{

public IPartnerRMNCCD() { 

} 

public override void main() { 

}

}

}
