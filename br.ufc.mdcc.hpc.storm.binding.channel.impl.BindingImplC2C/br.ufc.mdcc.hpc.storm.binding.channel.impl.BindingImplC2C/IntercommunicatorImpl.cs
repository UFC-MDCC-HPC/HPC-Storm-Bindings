using System;
using br.ufc.pargo.hpe.kinds;
using br.ufc.mdcc.hpc.storm.binding.channel.Binding;

namespace br.ufc.mdcc.hpc.storm.binding.channel.impl.BindingImplC2C
{
	public abstract class IntercommunicatorImpl : Synchronizer, Intercommunicator
	{
		public const int Root = default(int);
		public const int Null = default(int);

		public int RemoteSize
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		#region Intercommunicator implementation

		public void Send<T> (T value, int dest, int tag)
		{
			throw new NotImplementedException ();
		}
		/*
		public void SendReceive<T> (T inValue, int dest, int tag, out T outValue)
		{
			CompletedStatus status;
			SendReceive(inValue, dest, tag, dest, tag, out outValue, out status);
		}

		public void SendReceive<T> (T inValue, int dest, int sendTag, int source, int recvTag, out T outValue)
		{
			CompletedStatus status;
			SendReceive(inValue, dest, sendTag, source, recvTag, out outValue, out status);
		}

		public void SendReceive<T> (T inValue, int dest, int sendTag, int source, int recvTag, out T outValue, out CompletedStatus status)
		{
			throw new NotImplementedException ();
		}

		public void SendReceive<T> (T[] inValues, int dest, int tag, ref T[] outValues)
		{
			CompletedStatus status;
			SendReceive(inValues, dest, tag, dest, tag, ref outValues, out status);
		}

		public void SendReceive<T> (T[] inValues, int dest, int sendTag, int source, int recvTag, ref T[] outValues)
		{
			CompletedStatus status;
			SendReceive(inValues, dest, sendTag, source, recvTag, ref outValues, out status);
		}

		public void SendReceive<T> (T[] inValues, int dest, int sendTag, int source, int recvTag, ref T[] outValues, out CompletedStatus status)
		{
			throw new NotImplementedException ();
		}
       */
	
		public T Receive<T> (int source, int tag)
		{
			T result;
			Receive(source, tag, out result);
			return result;
		}

		public void Receive<T> (int source, int tag, out T value)
		{
			CompletedStatus status;
			Receive(source, tag, out value, out status);
		}

		public void Receive<T> (int source, int tag, out T value, out CompletedStatus status)
		{
			throw new NotImplementedException ();
		}

		public void Send<T> (T[] values, int dest, int tag)
		{
			throw new NotImplementedException ();
		}

		public void Receive<T> (int source, int tag, ref T[] values)
		{
			CompletedStatus status;
			Receive(source, tag, ref values, out status);
		}

		public void Receive<T> (int source, int tag, ref T[] values, out CompletedStatus status)
		{
			throw new NotImplementedException ();
		}

		public Request ImmediateSend<T> (T value, int dest, int tag)
		{
			throw new NotImplementedException ();
		}

		public Request ImmediateSend<T> (T[] values, int dest, int tag)
		{
			throw new NotImplementedException ();
		}

		public ReceiveRequest ImmediateReceive<T> (int source, int tag)
		{
			throw new NotImplementedException ();
		}

		public ReceiveRequest ImmediateReceive<T> (int source, int tag, T[] values)
		{
			throw new NotImplementedException ();
		}

		public Status Probe (int source, int tag)
		{
			throw new NotImplementedException ();
		}

		public Status ImmediateProbe (int source, int tag)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.Allgather<T> (T value)
		{
			throw new NotImplementedException ();
		}

		T Intercommunicator.Allreduce<T> (T value, ReductionOperation<T> op)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.Allreduce<T> (T[] values, ReductionOperation<T> op)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.Alltoall<T> (T[] values)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.ReduceScatter<T> (T[] values, ReductionOperation<T> op, int[] counts)
		{
			throw new NotImplementedException ();
		}

		T Intercommunicator.Scatter<T> (int root)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.Gather<T> (T value, int root)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.Gather<T> (int root)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.GatherFlattened<T> (int count)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.GatherFlattened<T> (int[] counts)
		{
			throw new NotImplementedException ();
		}

		T Intercommunicator.Reduce<T> (T value, ReductionOperation<T> op, int root)
		{
			throw new NotImplementedException ();
		}

		T[] Intercommunicator.Reduce<T> (T[] values, ReductionOperation<T> op, int root)
		{
			throw new NotImplementedException ();
		}

		#endregion

		#region Intercommunicator implementation

		public T[] Allgather<T> (T value)
		{
			T[] result = null;
			Allgather(value, ref result);
			return result;
		}

		public void Allgather<T> (T inValue, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		public void AllgatherFlattened<T> (T[] inValues, int count, ref T[] outValues)
		{
			int[] counts = new int[Size];
			for (int i = 0; i < Size; i++)
				counts[i] = count;
			AllgatherFlattened(inValues, counts, ref outValues);
		}

		public void AllgatherFlattened<T> (T[] inValues, int[] counts, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		public T Allreduce<T> (T value, ReductionOperation<T> op)
		{
			throw new NotImplementedException ();
		}

		public T[] Allreduce<T> (T[] values, ReductionOperation<T> op)
		{
			T[] result = null;
			Allreduce(values, op, ref result);
			return result;
		}

		public void Allreduce<T> (T[] inValues, ReductionOperation<T> op, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		public T[] Alltoall<T> (T[] values)
		{
			T[] result = null;
			Alltoall(values, ref result);
			return result;
		}

		public void Alltoall<T> (T[] inValues, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		public void AlltoallFlattened<T> (T[] inValues, int[] sendCounts, int[] recvCounts, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		public T[] ReduceScatter<T> (T[] values, ReductionOperation<T> op, int[] counts)
		{
			T[] result = null;
			ReduceScatter(values, op, counts, ref result);
			return result;
		}

		public void ReduceScatter<T> (T[] inValues, ReductionOperation<T> op, int[] counts, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		public void Broadcast<T> (ref T value, int root)
		{
			throw new NotImplementedException ();
		}

		public void Broadcast<T> (ref T[] values, int root)
		{
			throw new NotImplementedException ();
		}

		public void Scatter<T> (T[] values)
		{
			throw new NotImplementedException ();
		}

		public T Scatter<T> (int root)
		{
			throw new NotImplementedException ();
		}

		public void Scatter<T> ()
		{
			throw new NotImplementedException ();
		}

		public void ScatterFromFlattened<T> (T[] inValues, int count)
		{
			T[] temp = new T[0];
			ScatterFromFlattened<T>(inValues, count, Root, ref temp);
		}

		public void ScatterFromFlattened<T> (T[] inValues, int[] counts)
		{
			T[] temp = new T[0];
			ScatterFromFlattened<T>(inValues, counts, Root, ref temp);
		}

		public void ScatterFromFlattened<T> (int count, int root, ref T[] outValues)
		{
			ScatterFromFlattened<T>(null, count, root, ref outValues);
		}

		public void ScatterFromFlattened<T> (int[] counts, int root, ref T[] outValues)
		{
			ScatterFromFlattened<T>(null, counts, root, ref outValues);
		}

		public void ScatterFromFlattened<T> ()
		{
			T[] temp = new T[0];
			ScatterFromFlattened<T>(null, new int[0], Null, ref temp);
		}

		public void ScatterFromFlattened<T> (T[] inValues, int count, int root, ref T[] outValues)
		{
			int[] counts = new int[Size];
			for (int i = 0; i < Size; i++)
				counts[i] = count;
			ScatterFromFlattened<T>(inValues, counts, root, ref outValues);
		}

		public void ScatterFromFlattened<T> (T[] inValues, int[] counts, int root, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		public T[] Gather<T> (T value, int root)
		{
			T[] result = null;
			Gather(value, root, ref result);
			return result;
		}

		public T[] Gather<T> (int root)
		{
			T value = default(T);
			T[] result = null;
			Gather(value, Root, ref result);
			return result;
		}

		public void Gather<T> ()
		{
			T value = default(T);
			T[] result = null;
			Gather(value, Null, ref result);
		}

		public void Gather<T> (T inValue, int root, ref T[] outValues)
		{
			Gather_impl<T>((root == Root), RemoteSize, inValue, root, ref outValues);
		}

		internal void Gather_impl<T>(bool isRoot, int size, T inValue, int root, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		public void GatherFlattened<T> (int count, ref T[] outValues)
		{
			if (outValues == null || outValues.Length != count * RemoteSize)
				outValues = new T[count * RemoteSize];


			int[] counts = new int[Size];
			for (int i = 0; i < Size; i++)
				counts[i] = count;

			GatherFlattened_impl<T>(true, RemoteSize, new T[0], counts, Root, ref outValues);
		}

		public T[] GatherFlattened<T> (int count)
		{
			T[] outValues = new T[RemoteSize * count];

			int[] counts = new int[Size];
			for (int i = 0; i < Size; i++)
				counts[i] = count;

			GatherFlattened_impl<T>(true, RemoteSize, new T[0], counts, Root, ref outValues);

			return outValues;
		}

		public void GatherFlattened<T> (T[] inValues, int root)
		{
			T[] temp = new T[0];
			GatherFlattened_impl<T>(false, Size, inValues, new int[0], root, ref temp);
		}

		public void GatherFlattened<T> ()
		{
			T[] temp = new T[0];
			GatherFlattened_impl<T>(false, RemoteSize, new T[0], new int[0], Null, ref temp);
		}

		public void GatherFlattened<T> (int[] counts, ref T[] outValues)
		{
			int totalCounts = 0;
			for (int i = 0; i < counts.Length; i++)
				totalCounts += counts[i];

			if (outValues == null || outValues.Length != totalCounts * RemoteSize)
				outValues = new T[totalCounts * RemoteSize];

			GatherFlattened_impl<T>(true, RemoteSize, new T[0], counts, Root, ref outValues);
		}

		public T[] GatherFlattened<T> (int[] counts)
		{ 
		    int totalCounts = 0;
            for (int i = 0; i < counts.Length; i++)
                totalCounts += counts[i];
            T[] outValues = new T[totalCounts];

            GatherFlattened_impl<T>(true, RemoteSize, new T[0], counts, Root, ref outValues);
            
            return outValues;

		}

		internal void GatherFlattened_impl<T>(bool isRoot, int size, T[] inValues, int[] counts, int root, ref T[] outValues)
		{ 
			throw new NotImplementedException ();
		}

		public T Reduce<T> (T value, ReductionOperation<T> op, int root)
		{
			return Reduce_impl<T>((root == Root), RemoteSize, value, op, root);
		}

		public T[] Reduce<T> (T[] values, ReductionOperation<T> op, int root)
		{
			T[] result = null;
			Reduce(values, op, root, ref result);
			return result;
		}

		public void Reduce<T> (T[] inValues, ReductionOperation<T> op, int root, ref T[] outValues)
		{
			throw new NotImplementedException ();
		}

		internal T Reduce_impl<T>(bool isRoot, int size, T value, ReductionOperation<T> op, int root)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

