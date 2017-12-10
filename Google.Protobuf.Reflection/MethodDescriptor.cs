using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class MethodDescriptor : DescriptorBase
	{
		private readonly MethodDescriptorProto proto;

		private readonly ServiceDescriptor service;

		private MessageDescriptor inputType;

		private MessageDescriptor outputType;

		public ServiceDescriptor Service
		{
			get
			{
				return this.service;
			}
		}

		public MessageDescriptor InputType
		{
			get
			{
				return this.inputType;
			}
		}

		public MessageDescriptor OutputType
		{
			get
			{
				return this.outputType;
			}
		}

		public bool IsClientStreaming
		{
			get
			{
				return this.proto.ClientStreaming;
			}
		}

		public bool IsServerStreaming
		{
			get
			{
				return this.proto.ServerStreaming;
			}
		}

		internal MethodDescriptorProto Proto
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

		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index) : base(file, MethodDescriptor.smethod_0(parent.FullName, Module.smethod_35<string>(3143151842u), proto.Name), index)
		{
			while (true)
			{
				IL_5E:
				uint arg_46_0 = 243061988u;
				while (true)
				{
					uint num;
					switch ((num = (arg_46_0 ^ 209767462u)) % 3u)
					{
					case 1u:
						this.proto = proto;
						this.service = parent;
						arg_46_0 = (num * 333704512u ^ 868198461u);
						continue;
					case 2u:
						goto IL_5E;
					}
					goto Block_1;
				}
			}
			Block_1:
			file.DescriptorPool.AddSymbol(this);
		}

		internal void CrossLink()
		{
			IDescriptor descriptor = base.File.DescriptorPool.LookupSymbol(this.Proto.InputType, this);
			while (true)
			{
				IL_FA:
				uint arg_C9_0 = 1325031413u;
				while (true)
				{
					uint num;
					switch ((num = (arg_C9_0 ^ 1162977085u)) % 9u)
					{
					case 0u:
						goto IL_101;
					case 1u:
						this.outputType = (MessageDescriptor)descriptor;
						arg_C9_0 = 629215157u;
						continue;
					case 2u:
						arg_C9_0 = (((descriptor is MessageDescriptor) ? 1793996950u : 1340472884u) ^ num * 3377966943u);
						continue;
					case 3u:
						this.inputType = (MessageDescriptor)descriptor;
						arg_C9_0 = 927331778u;
						continue;
					case 4u:
						goto IL_FA;
					case 6u:
						descriptor = base.File.DescriptorPool.LookupSymbol(this.Proto.OutputType, this);
						arg_C9_0 = (num * 1183744827u ^ 2149459337u);
						continue;
					case 7u:
						arg_C9_0 = (((!(descriptor is MessageDescriptor)) ? 119396225u : 1532768422u) ^ num * 307037310u);
						continue;
					case 8u:
						goto IL_12C;
					}
					goto Block_3;
				}
			}
			Block_3:
			return;
			IL_101:
			throw new DescriptorValidationException(this, MethodDescriptor.smethod_0(Module.smethod_34<string>(1801001672u), this.Proto.InputType, Module.smethod_33<string>(206307083u)));
			IL_12C:
			throw new DescriptorValidationException(this, MethodDescriptor.smethod_0(Module.smethod_34<string>(1801001672u), this.Proto.OutputType, Module.smethod_34<string>(4088171961u)));
		}

		static string smethod_0(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}
	}
}
