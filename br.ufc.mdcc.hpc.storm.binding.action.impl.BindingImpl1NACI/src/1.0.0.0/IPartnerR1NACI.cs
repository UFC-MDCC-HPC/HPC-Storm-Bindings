using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.partner_kind.A2C;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImpl1NACI { 

public class IPartnerR1NACI<PK> : BaseIPartnerR1NACI<PK>, IPartnerR<PK>
where PK:IProviderA2C
{

public IPartnerR1NACI() { 

} 

public override void main() { 

}

}

}
