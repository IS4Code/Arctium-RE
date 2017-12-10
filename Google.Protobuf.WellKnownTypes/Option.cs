using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Option : IMessage<Option>, IEquatable<Option>, IDeepCloneable<Option>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Option.__c __9 = new Option.__c();

			internal Option cctor>b__29_0()
			{
				return new Option();
			}
		}

		private static readonly MessageParser<Option> _parser = new MessageParser<Option>(new Func<Option>(Option.__c.__9.<.cctor>b__29_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int ValueFieldNumber = 2;

		private Any value_;

		public static MessageParser<Option> Parser
		{
			get
			{
				return Option._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return TypeReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Option.Descriptor;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public Any Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		public Option()
		{
		}

		public Option(Option other) : this()
		{
			this.name_ = other.name_;
			this.Value = ((other.value_ != null) ? other.Value.Clone() : null);
		}

		public Option Clone()
		{
			return new Option(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Option);
		}

		public bool Equals(Option other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 169597419) % 9)
				{
				case 0:
					return false;
				case 1:
					arg_77_0 = (Option.smethod_0(this.Name, other.Name) ? 1709475802 : 1792862078);
					continue;
				case 2:
					goto IL_B5;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					arg_77_0 = ((!Option.smethod_1(this.Value, other.Value)) ? 1742073465 : 1945617259);
					continue;
				case 6:
					goto IL_15;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = 1567911070;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? 733654072 : 54776471);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B7:
				uint arg_93_0 = 3154855486u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_93_0 ^ 2948804352u)) % 6u)
					{
					case 0u:
						goto IL_B7;
					case 1u:
						arg_93_0 = ((this.value_ != null) ? 2173846167u : 3579040126u);
						continue;
					case 2u:
						arg_93_0 = (((Option.smethod_2(this.Name) != 0) ? 3938773715u : 3810148649u) ^ num2 * 3478582543u);
						continue;
					case 3u:
						num ^= Option.smethod_3(this.Value);
						arg_93_0 = (num2 * 653797532u ^ 1381347706u);
						continue;
					case 5u:
						num ^= Option.smethod_3(this.Name);
						arg_93_0 = (num2 * 671937116u ^ 1172637463u);
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
			if (Option.smethod_2(this.Name) != 0)
			{
				goto IL_42;
			}
			goto IL_9B;
			uint arg_6F_0;
			while (true)
			{
				IL_6A:
				uint num;
				switch ((num = (arg_6F_0 ^ 877079752u)) % 5u)
				{
				case 0u:
					goto IL_9B;
				case 2u:
					output.WriteRawTag(18);
					output.WriteMessage(this.Value);
					arg_6F_0 = (num * 2504534018u ^ 4221574781u);
					continue;
				case 3u:
					goto IL_42;
				case 4u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_6F_0 = (num * 3085354764u ^ 1937371291u);
					continue;
				}
				break;
			}
			return;
			IL_42:
			arg_6F_0 = 1206940515u;
			goto IL_6A;
			IL_9B:
			arg_6F_0 = ((this.value_ != null) ? 124651853u : 825691511u);
			goto IL_6A;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (Option.smethod_2(this.Name) != 0)
			{
				goto IL_40;
			}
			goto IL_95;
			uint arg_69_0;
			while (true)
			{
				IL_64:
				uint num2;
				switch ((num2 = (arg_69_0 ^ 1382819445u)) % 5u)
				{
				case 0u:
					goto IL_95;
				case 1u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
					arg_69_0 = (num2 * 3896350370u ^ 3627944469u);
					continue;
				case 2u:
					goto IL_40;
				case 4u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Value);
					arg_69_0 = (num2 * 234555415u ^ 3367908179u);
					continue;
				}
				break;
			}
			return num;
			IL_40:
			arg_69_0 = 680242676u;
			goto IL_64;
			IL_95:
			arg_69_0 = ((this.value_ == null) ? 107246058u : 168549338u);
			goto IL_64;
		}

		public void MergeFrom(Option other)
		{
			if (other == null)
			{
				goto IL_9D;
			}
			goto IL_FF;
			uint arg_BF_0;
			while (true)
			{
				IL_BA:
				uint num;
				switch ((num = (arg_BF_0 ^ 2763792398u)) % 9u)
				{
				case 0u:
					this.Value.MergeFrom(other.Value);
					arg_BF_0 = 2261838607u;
					continue;
				case 2u:
					goto IL_9D;
				case 3u:
					this.Name = other.Name;
					arg_BF_0 = (num * 1803026089u ^ 21847576u);
					continue;
				case 4u:
					return;
				case 5u:
					arg_BF_0 = (((this.value_ != null) ? 122298191u : 584554343u) ^ num * 1513529166u);
					continue;
				case 6u:
					arg_BF_0 = ((other.value_ == null) ? 2261838607u : 2888855002u);
					continue;
				case 7u:
					goto IL_FF;
				case 8u:
					this.value_ = new Any();
					arg_BF_0 = (num * 2193707583u ^ 3414402456u);
					continue;
				}
				break;
			}
			return;
			IL_9D:
			arg_BF_0 = 2456838343u;
			goto IL_BA;
			IL_FF:
			arg_BF_0 = ((Option.smethod_2(other.Name) == 0) ? 2344952516u : 3350776690u);
			goto IL_BA;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13A:
				uint num;
				uint arg_F2_0 = ((num = input.ReadTag()) == 0u) ? 1489148489u : 1420216282u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F2_0 ^ 2044215250u)) % 11u)
					{
					case 0u:
						arg_F2_0 = ((this.value_ != null) ? 785830018u : 489585262u);
						continue;
					case 1u:
						arg_F2_0 = (num2 * 2284699776u ^ 1045631441u);
						continue;
					case 2u:
						arg_F2_0 = 1420216282u;
						continue;
					case 3u:
						arg_F2_0 = (((num == 18u) ? 1773621369u : 1348923340u) ^ num2 * 2952931518u);
						continue;
					case 5u:
						input.ReadMessage(this.value_);
						arg_F2_0 = 808848849u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_F2_0 = (num2 * 688863350u ^ 3337169706u);
						continue;
					case 7u:
						this.value_ = new Any();
						arg_F2_0 = (num2 * 3805681516u ^ 3582435282u);
						continue;
					case 8u:
						this.Name = input.ReadString();
						arg_F2_0 = 808848849u;
						continue;
					case 9u:
						goto IL_13A;
					case 10u:
						arg_F2_0 = ((num != 10u) ? 315416211u : 1084141741u);
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

		static bool smethod_1(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_3(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
