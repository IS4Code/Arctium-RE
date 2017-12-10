using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class OneofDescriptorProto : IMessage<OneofDescriptorProto>, IEquatable<OneofDescriptorProto>, IDeepCloneable<OneofDescriptorProto>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly OneofDescriptorProto.__c __9 = new OneofDescriptorProto.__c();

			internal OneofDescriptorProto cctor>b__24_0()
			{
				return new OneofDescriptorProto();
			}
		}

		private static readonly MessageParser<OneofDescriptorProto> _parser = new MessageParser<OneofDescriptorProto>(new Func<OneofDescriptorProto>(OneofDescriptorProto.__c.__9.<.cctor>b__24_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public static MessageParser<OneofDescriptorProto> Parser
		{
			get
			{
				return OneofDescriptorProto._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneofDescriptorProto.Descriptor;
			}
		}

		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public OneofDescriptorProto()
		{
		}

		public OneofDescriptorProto(OneofDescriptorProto other) : this()
		{
			this.name_ = other.name_;
		}

		public OneofDescriptorProto Clone()
		{
			return new OneofDescriptorProto(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as OneofDescriptorProto);
		}

		public bool Equals(OneofDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 760303866) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					goto IL_7A;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 6:
					arg_48_0 = ((!OneofDescriptorProto.smethod_0(this.Name, other.Name)) ? 164187143 : 1511705419);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 1519880068;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 1146569014 : 1600587860);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6E:
				uint arg_52_0 = 3391022013u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_52_0 ^ 3764088767u)) % 4u)
					{
					case 0u:
						goto IL_6E;
					case 1u:
						num ^= OneofDescriptorProto.smethod_2(this.Name);
						arg_52_0 = (num2 * 81616272u ^ 1452581360u);
						continue;
					case 2u:
						arg_52_0 = (((OneofDescriptorProto.smethod_1(this.Name) != 0) ? 1447463862u : 630060248u) ^ num2 * 2157929180u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (OneofDescriptorProto.smethod_1(this.Name) != 0)
			{
				while (true)
				{
					IL_60:
					uint arg_44_0 = 1911835850u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 2022042783u)) % 4u)
						{
						case 0u:
							goto IL_60;
						case 1u:
							output.WriteRawTag(10);
							arg_44_0 = (num * 1275649596u ^ 3393519489u);
							continue;
						case 2u:
							output.WriteString(this.Name);
							arg_44_0 = (num * 4172664462u ^ 2700273104u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			if (OneofDescriptorProto.smethod_1(this.Name) != 0)
			{
				while (true)
				{
					IL_4B:
					uint arg_33_0 = 2538656730u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_33_0 ^ 2975618881u)) % 3u)
						{
						case 0u:
							goto IL_4B;
						case 1u:
							num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
							arg_33_0 = (num2 * 1253888077u ^ 654977411u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(OneofDescriptorProto other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 2506557662u)) % 5u)
				{
				case 1u:
					return;
				case 2u:
					this.Name = other.Name;
					arg_37_0 = (num * 1408225162u ^ 2861659490u);
					continue;
				case 3u:
					goto IL_12;
				case 4u:
					goto IL_63;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 3494605203u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((OneofDescriptorProto.smethod_1(other.Name) == 0) ? 3937845172u : 2958767025u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) == 0u) ? 2617520824u : 4034183063u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 2467263005u)) % 7u)
					{
					case 0u:
						arg_72_0 = 4034183063u;
						continue;
					case 1u:
						arg_72_0 = ((num != 10u) ? 3745028253u : 2491817672u);
						continue;
					case 2u:
						this.Name = input.ReadString();
						arg_72_0 = 2925856456u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_72_0 = (num2 * 2977871713u ^ 1883693947u);
						continue;
					case 5u:
						goto IL_A9;
					case 6u:
						arg_72_0 = (num2 * 1112311778u ^ 4074196420u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
