using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class OneofDescriptorProto : IMessage, IMessage<OneofDescriptorProto>, IEquatable<OneofDescriptorProto>, IDeepCloneable<OneofDescriptorProto>
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
				switch ((arg_48_0 ^ 160548853) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return false;
				case 2:
					arg_48_0 = (OneofDescriptorProto.smethod_0(this.Name, other.Name) ? 740380643 : 1997557812);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_7A;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 906011499;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 1147039028 : 1837833880);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6E:
				uint arg_52_0 = 4093631835u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_52_0 ^ 2849004273u)) % 4u)
					{
					case 0u:
						goto IL_6E;
					case 1u:
						num ^= OneofDescriptorProto.smethod_2(this.Name);
						arg_52_0 = (num2 * 1397723935u ^ 3537854193u);
						continue;
					case 2u:
						arg_52_0 = (((OneofDescriptorProto.smethod_1(this.Name) == 0) ? 1533380660u : 1176197354u) ^ num2 * 2745841641u);
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
					uint arg_44_0 = 886597418u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 1922158505u)) % 4u)
						{
						case 0u:
							goto IL_60;
						case 2u:
							output.WriteString(this.Name);
							arg_44_0 = (num * 1607138035u ^ 2103952198u);
							continue;
						case 3u:
							output.WriteRawTag(10);
							arg_44_0 = (num * 240653117u ^ 115277656u);
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
			while (true)
			{
				IL_70:
				uint arg_54_0 = 821718222u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_54_0 ^ 931918383u)) % 4u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_54_0 = (num2 * 2816127389u ^ 323497593u);
						continue;
					case 1u:
						arg_54_0 = (((OneofDescriptorProto.smethod_1(this.Name) == 0) ? 2810243550u : 4039763144u) ^ num2 * 1205480599u);
						continue;
					case 3u:
						goto IL_70;
					}
					return num;
				}
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
				switch ((num = (arg_37_0 ^ 529495116u)) % 5u)
				{
				case 1u:
					return;
				case 2u:
					goto IL_63;
				case 3u:
					this.Name = other.Name;
					arg_37_0 = (num * 3529934907u ^ 661019711u);
					continue;
				case 4u:
					goto IL_12;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 1089835390u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((OneofDescriptorProto.smethod_1(other.Name) != 0) ? 871025922u : 831617221u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_96:
				uint num;
				uint arg_63_0 = ((num = input.ReadTag()) == 0u) ? 1966173920u : 1765919479u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_63_0 ^ 1825018052u)) % 6u)
					{
					case 1u:
						arg_63_0 = ((num == 10u) ? 1199675965u : 733240905u);
						continue;
					case 2u:
						goto IL_96;
					case 3u:
						this.Name = input.ReadString();
						arg_63_0 = 801006046u;
						continue;
					case 4u:
						arg_63_0 = 1765919479u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_63_0 = (num2 * 2370429378u ^ 1379865092u);
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
