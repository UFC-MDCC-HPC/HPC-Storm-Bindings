using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKindComponent;
using br.ufc.mdcc.hpc.storm.binding.context.ActionInterface;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImplMNCCD { 

public class IPartnerLImpl<PKL, A> : BaseIPartnerLImpl<PKL, A>, IPartnerL<PKL, A>
where PKL:IPartnerKindComponent
where A:IActionInterfaceProvider
{

public IPartnerLImpl() { 

} 

public override void main() { 

}

}

}
