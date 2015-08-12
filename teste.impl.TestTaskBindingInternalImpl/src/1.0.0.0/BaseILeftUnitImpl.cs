/* Automatically Generated Code */

using System;
using br.ufc.pargo.hpe.backend.DGAC;
using br.ufc.pargo.hpe.basic;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.task.TaskBindingExample;
using br.ufc.mdcc.hpc.storm.binding.task.TaskBindingBase;
using br.ufc.mdcc.hpc.storm.binding.task.TaskPortTypeExample;
using teste.TestTaskBindingInternal;

namespace teste.impl.TestTaskBindingInternalImpl 
{
	public abstract class BaseILeftUnitImpl: Application, BaseILeftUnit
	{
		private ITaskPortExample task_binding = null;

		protected ITaskPortExample Task_binding
		{
			get
			{
				if (this.task_binding == null)
					this.task_binding = (ITaskPortExample) Services.getPort("task_binding");
				return this.task_binding;
			}
		}
		private ITaskPort<ITaskPortTypeExample> task_port = null;

		protected ITaskPort<ITaskPortTypeExample> Task_port
		{
			get
			{
				if (this.task_port == null)
					this.task_port = (ITaskPort<ITaskPortTypeExample>) Services.getPort("task_port");
				return this.task_port;
			}
		}
	}
}