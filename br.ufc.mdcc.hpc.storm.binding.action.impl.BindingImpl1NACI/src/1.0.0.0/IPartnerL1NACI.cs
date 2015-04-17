using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.partner_kind.A2C;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImpl1NACI { 

public class IPartnerL1NACI<PK> : BaseIPartnerL1NACI<PK>, IPartnerL<PK>
where PK:IUserA2C
{

public IPartnerL1NACI() { 

} 

public override void main() { 

}

}

}
