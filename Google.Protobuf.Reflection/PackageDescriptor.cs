using System;

namespace Google.Protobuf.Reflection
{
	internal sealed class PackageDescriptor : IDescriptor
	{
		private readonly string name;

		private readonly string fullName;

		private readonly FileDescriptor file;

		public string Name
		{
			get
			{
				return this.name;
			}
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

		internal PackageDescriptor(string name, string fullName, FileDescriptor file)
		{
			while (true)
			{
				IL_5A:
				uint arg_3E_0 = 3937908074u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3E_0 ^ 4070265288u)) % 4u)
					{
					case 1u:
						this.name = name;
						arg_3E_0 = (num * 2943632721u ^ 491079365u);
						continue;
					case 2u:
						this.file = file;
						this.fullName = fullName;
						arg_3E_0 = (num * 2262279830u ^ 2710158405u);
						continue;
					case 3u:
						goto IL_5A;
					}
					return;
				}
			}
		}
	}
}
