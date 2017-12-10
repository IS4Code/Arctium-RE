using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class EnumValueDescriptor : DescriptorBase
	{
		private readonly EnumDescriptor enumDescriptor;

		private readonly EnumValueDescriptorProto proto;

		internal EnumValueDescriptorProto Proto
		{
			get
			{
				return this.proto;
			}
		}

		public override string Name
		{
			get
			{
				return this.proto.Name;
			}
		}

		public int Number
		{
			get
			{
				return this.Proto.Number;
			}
		}

		public EnumDescriptor EnumDescriptor
		{
			get
			{
				return this.enumDescriptor;
			}
		}

		internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index) : base(file, EnumValueDescriptor.smethod_0(parent.FullName, Module.smethod_34<string>(3349943853u), proto.Name), index)
		{
			while (true)
			{
				IL_90:
				uint arg_70_0 = 3117200364u;
				while (true)
				{
					uint num;
					switch ((num = (arg_70_0 ^ 2941281634u)) % 5u)
					{
					case 0u:
						goto IL_90;
					case 1u:
						file.DescriptorPool.AddSymbol(this);
						arg_70_0 = (num * 4059409295u ^ 1121610279u);
						continue;
					case 3u:
						this.enumDescriptor = parent;
						arg_70_0 = (num * 2476227708u ^ 3235142323u);
						continue;
					case 4u:
						this.proto = proto;
						arg_70_0 = (num * 3737544868u ^ 4180488678u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			file.DescriptorPool.AddEnumValueByNumber(this);
		}

		static string smethod_0(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}
	}
}
