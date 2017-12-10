using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class EnumDescriptor : DescriptorBase
	{
		private readonly EnumDescriptorProto proto;

		private readonly MessageDescriptor containingType;

		private readonly IList<EnumValueDescriptor> values;

		private readonly Type clrType;

		internal EnumDescriptorProto Proto
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

		public Type ClrType
		{
			get
			{
				return this.clrType;
			}
		}

		public MessageDescriptor ContainingType
		{
			get
			{
				return this.containingType;
			}
		}

		public IList<EnumValueDescriptor> Values
		{
			get
			{
				return this.values;
			}
		}

		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, Type clrType) : base(file, file.ComputeFullName(parent, proto.Name), index)
		{
			EnumDescriptor __4__this;
			while (true)
			{
				IL_E8:
				uint arg_BC_0 = 4109983820u;
				while (true)
				{
					uint num;
					switch ((num = (arg_BC_0 ^ 3766774863u)) % 8u)
					{
					case 0u:
						goto IL_E8;
					case 1u:
						this.clrType = clrType;
						arg_BC_0 = (num * 1684544113u ^ 3373526018u);
						continue;
					case 3u:
						__4__this = this;
						arg_BC_0 = (num * 2337484923u ^ 1148379752u);
						continue;
					case 4u:
						this.containingType = parent;
						arg_BC_0 = (num * 1220569408u ^ 3140952130u);
						continue;
					case 5u:
						arg_BC_0 = (((proto.Value.Count == 0) ? 1596062239u : 198363322u) ^ num * 3295210363u);
						continue;
					case 6u:
						this.proto = proto;
						arg_BC_0 = (num * 3344172837u ^ 841144240u);
						continue;
					case 7u:
						goto IL_EF;
					}
					goto Block_2;
				}
			}
			Block_2:
			goto IL_100;
			IL_EF:
			throw new DescriptorValidationException(this, Module.smethod_34<string>(1600269481u));
			IL_100:
			this.values = DescriptorUtil.ConvertAndMakeReadOnly<EnumValueDescriptorProto, EnumValueDescriptor>(proto.Value, (EnumValueDescriptorProto value, int i) => new EnumValueDescriptor(value, file, __4__this, i));
			base.File.DescriptorPool.AddSymbol(this);
		}

		public EnumValueDescriptor FindValueByNumber(int number)
		{
			return base.File.DescriptorPool.FindEnumValueByNumber(this, number);
		}

		public EnumValueDescriptor FindValueByName(string name)
		{
			return base.File.DescriptorPool.FindSymbol<EnumValueDescriptor>(EnumDescriptor.smethod_0(base.FullName, Module.smethod_34<string>(3349943853u), name));
		}

		static string smethod_0(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}
	}
}
