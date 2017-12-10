using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Notification.V1
{
	[DebuggerNonUserCode]
	public sealed class Target : IMessage<Target>, IEquatable<Target>, IDeepCloneable<Target>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Target.__c __9 = new Target.__c();

			internal Target cctor>b__29_0()
			{
				return new Target();
			}
		}

		private static readonly MessageParser<Target> _parser = new MessageParser<Target>(new Func<Target>(Target.__c.__9.<.cctor>b__29_0));

		public const int IdentityFieldNumber = 1;

		private Bgs.Protocol.Account.V1.Identity identity_;

		public const int TypeFieldNumber = 2;

		private string type_ = "";

		public static MessageParser<Target> Parser
		{
			get
			{
				return Target._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Target.Descriptor;
			}
		}

		public Bgs.Protocol.Account.V1.Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		public string Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public Target()
		{
		}

		public Target(Target other) : this()
		{
			while (true)
			{
				IL_65:
				uint arg_49_0 = 1777176534u;
				while (true)
				{
					uint num;
					switch ((num = (arg_49_0 ^ 1967312820u)) % 4u)
					{
					case 0u:
						goto IL_65;
					case 2u:
						this.Identity = ((other.identity_ != null) ? other.Identity.Clone() : null);
						arg_49_0 = 258649327u;
						continue;
					case 3u:
						this.type_ = other.type_;
						arg_49_0 = (num * 4241704958u ^ 2734360631u);
						continue;
					}
					return;
				}
			}
		}

		public Target Clone()
		{
			return new Target(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Target);
		}

		public bool Equals(Target other)
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
				switch ((arg_77_0 ^ -1053671825) % 9)
				{
				case 0:
					return false;
				case 2:
					arg_77_0 = (Target.smethod_0(this.Identity, other.Identity) ? -1044088159 : -778816376);
					continue;
				case 3:
					return false;
				case 4:
					arg_77_0 = (Target.smethod_1(this.Type, other.Type) ? -1241782737 : -206869732);
					continue;
				case 5:
					goto IL_15;
				case 6:
					return true;
				case 7:
					goto IL_B5;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = -1532578059;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? -268378260 : -1400464729);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B7:
				uint arg_93_0 = 2710838543u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_93_0 ^ 3040355140u)) % 6u)
					{
					case 0u:
						goto IL_B7;
					case 1u:
						arg_93_0 = ((Target.smethod_3(this.Type) == 0) ? 3638306381u : 3194459768u);
						continue;
					case 2u:
						num ^= Target.smethod_2(this.Type);
						arg_93_0 = (num2 * 1073620627u ^ 2327830329u);
						continue;
					case 4u:
						num ^= Target.smethod_2(this.Identity);
						arg_93_0 = (num2 * 3699518002u ^ 4110837783u);
						continue;
					case 5u:
						arg_93_0 = (((this.identity_ == null) ? 3406664015u : 3545468664u) ^ num2 * 1593965920u);
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
			if (this.identity_ != null)
			{
				goto IL_60;
			}
			goto IL_96;
			uint arg_6A_0;
			while (true)
			{
				IL_65:
				uint num;
				switch ((num = (arg_6A_0 ^ 2988344685u)) % 5u)
				{
				case 0u:
					goto IL_60;
				case 1u:
					goto IL_96;
				case 2u:
					output.WriteRawTag(18);
					output.WriteString(this.Type);
					arg_6A_0 = (num * 1707311403u ^ 2659616384u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					output.WriteMessage(this.Identity);
					arg_6A_0 = (num * 2687905356u ^ 2869615604u);
					continue;
				}
				break;
			}
			return;
			IL_60:
			arg_6A_0 = 2670931665u;
			goto IL_65;
			IL_96:
			arg_6A_0 = ((Target.smethod_3(this.Type) != 0) ? 3532665867u : 3767055522u);
			goto IL_65;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_BB:
				uint arg_97_0 = 4205108779u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_97_0 ^ 2580130552u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
						arg_97_0 = (num2 * 1034766070u ^ 3176379096u);
						continue;
					case 1u:
						arg_97_0 = (((this.identity_ == null) ? 3754839564u : 3082807960u) ^ num2 * 157822420u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
						arg_97_0 = (num2 * 1164276654u ^ 1111587545u);
						continue;
					case 3u:
						goto IL_BB;
					case 4u:
						arg_97_0 = ((Target.smethod_3(this.Type) != 0) ? 2191041468u : 3058737889u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Target other)
		{
			if (other == null)
			{
				goto IL_5E;
			}
			goto IL_101;
			uint arg_C1_0;
			while (true)
			{
				IL_BC:
				uint num;
				switch ((num = (arg_C1_0 ^ 2528184266u)) % 9u)
				{
				case 0u:
					arg_C1_0 = ((Target.smethod_3(other.Type) == 0) ? 3914750300u : 3565150234u);
					continue;
				case 1u:
					this.Identity.MergeFrom(other.Identity);
					arg_C1_0 = 3622876507u;
					continue;
				case 3u:
					this.Type = other.Type;
					arg_C1_0 = (num * 2236184200u ^ 3997392860u);
					continue;
				case 4u:
					goto IL_5E;
				case 5u:
					return;
				case 6u:
					arg_C1_0 = (((this.identity_ != null) ? 1003750692u : 1573537598u) ^ num * 1651758285u);
					continue;
				case 7u:
					goto IL_101;
				case 8u:
					this.identity_ = new Bgs.Protocol.Account.V1.Identity();
					arg_C1_0 = (num * 1767630233u ^ 4194895728u);
					continue;
				}
				break;
			}
			return;
			IL_5E:
			arg_C1_0 = 3355666259u;
			goto IL_BC;
			IL_101:
			arg_C1_0 = ((other.identity_ == null) ? 3622876507u : 4005585754u);
			goto IL_BC;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_153:
				uint num;
				uint arg_107_0 = ((num = input.ReadTag()) != 0u) ? 3003240675u : 2561579674u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_107_0 ^ 3535258562u)) % 12u)
					{
					case 1u:
						arg_107_0 = ((num == 10u) ? 2894677545u : 3237487434u);
						continue;
					case 2u:
						this.Type = input.ReadString();
						arg_107_0 = 3466546820u;
						continue;
					case 3u:
						input.ReadMessage(this.identity_);
						arg_107_0 = 3784530477u;
						continue;
					case 4u:
						arg_107_0 = (((num == 18u) ? 125828176u : 1877636172u) ^ num2 * 2090296605u);
						continue;
					case 5u:
						this.identity_ = new Bgs.Protocol.Account.V1.Identity();
						arg_107_0 = (num2 * 2241793223u ^ 4017869218u);
						continue;
					case 6u:
						goto IL_153;
					case 7u:
						arg_107_0 = ((this.identity_ != null) ? 2922594613u : 3650596467u);
						continue;
					case 8u:
						arg_107_0 = 3003240675u;
						continue;
					case 9u:
						arg_107_0 = (num2 * 1702860003u ^ 3246154535u);
						continue;
					case 10u:
						input.SkipLastField();
						arg_107_0 = (num2 * 2315806593u ^ 918912613u);
						continue;
					case 11u:
						arg_107_0 = (num2 * 2803539781u ^ 3240206575u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_3(string string_0)
		{
			return string_0.Length;
		}
	}
}
