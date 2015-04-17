using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpe.storm.binding.context.PartnerKindComponent;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImpl1NACI { 

public class IPartnerRImpl<PKR> : BaseIPartnerRImpl<PKR>, IPartnerR<PKR>
where PKR:IPartnerKindComponent
{

public IPartnerRImpl() { 

} 

public override void main() { 

}

}

}
