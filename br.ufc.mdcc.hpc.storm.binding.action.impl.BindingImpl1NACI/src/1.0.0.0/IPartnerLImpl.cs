using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.context.PartnerKindApplication;
using br.ufc.mdcc.hpc.storm.binding.action.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.action.impl.BindingImpl1NACI { 

public class IPartnerLImpl<PKL> : BaseIPartnerLImpl<PKL>, IPartnerL<PKL>
where PKL:IPartnerKindApplication
{

public IPartnerLImpl() { 

} 

public override void main() { 

}

}

}
