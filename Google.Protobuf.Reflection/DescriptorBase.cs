using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public abstract class DescriptorBase : IDescriptor
	{
		private readonly FileDescriptor file;

		private readonly string fullName;

		private readonly int index;

		public int Index
		{
			get
			{
				return this.index;
			}
		}

		public abstract string Name
		{
			get;
		}

		public string FullName
		{
			get
			{
				return this.fullName;
			}
		}

		public FileDescriptor File
		{
			get
			{
				return this.file;
			}
		}

		internal DescriptorBase(FileDescriptor file, string fullName, int index)
		{
			this.file = file;
			this.fullName = fullName;
			this.index = index;
		}
	}
}
