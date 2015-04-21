using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKindComponent;
using br.ufc.mdcc.hpc.storm.binding.context.ActionInterface;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImpl1NACI { 

public class IPartnerRImpl<PKR, A> : BaseIPartnerRImpl<PKR, A>, IPartnerR<PKR, A>
where PKR:IPartnerKindComponent
where A:IActionInterfaceProvider
{

public IPartnerRImpl() { 

} 

public override void main() { 

}

}

}
