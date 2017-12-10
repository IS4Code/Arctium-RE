using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class InvitationParams : IMessage<InvitationParams>, IEquatable<InvitationParams>, IDeepCloneable<InvitationParams>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly InvitationParams.__c __9 = new InvitationParams.__c();

			internal InvitationParams cctor>b__29_0()
			{
				return new InvitationParams();
			}
		}

		private static readonly MessageParser<InvitationParams> _parser = new MessageParser<InvitationParams>(new Func<InvitationParams>(InvitationParams.__c.__9.<.cctor>b__29_0));

		public const int InvitationMessageFieldNumber = 1;

		private string invitationMessage_ = "";

		public const int ExpirationTimeFieldNumber = 2;

		private ulong expirationTime_;

		public static MessageParser<InvitationParams> Parser
		{
			get
			{
				return InvitationParams._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationParams.Descriptor;
			}
		}

		public string InvitationMessage
		{
			get
			{
				return this.invitationMessage_;
			}
			set
			{
				this.invitationMessage_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public ulong ExpirationTime
		{
			get
			{
				return this.expirationTime_;
			}
			set
			{
				this.expirationTime_ = value;
			}
		}

		public InvitationParams()
		{
		}

		public InvitationParams(InvitationParams other) : this()
		{
			this.invitationMessage_ = other.invitationMessage_;
			this.expirationTime_ = other.expirationTime_;
		}

		public InvitationParams Clone()
		{
			return new InvitationParams(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationParams);
		}

		public bool Equals(InvitationParams other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ -107313734) % 9)
				{
				case 0:
					arg_72_0 = ((this.ExpirationTime != other.ExpirationTime) ? -2002573600 : -1674311352);
					continue;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_B0;
				case 5:
					arg_72_0 = (InvitationParams.smethod_0(this.InvitationMessage, other.InvitationMessage) ? -902451664 : -1743884255);
					continue;
				case 7:
					return true;
				case 8:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = -27987925;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? -1109324125 : -842911115);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (InvitationParams.smethod_1(this.InvitationMessage) != 0)
			{
				goto IL_21;
			}
			goto IL_94;
			uint arg_68_0;
			while (true)
			{
				IL_63:
				uint num2;
				switch ((num2 = (arg_68_0 ^ 1631379956u)) % 5u)
				{
				case 0u:
					num ^= this.ExpirationTime.GetHashCode();
					arg_68_0 = (num2 * 2889417313u ^ 3932574999u);
					continue;
				case 2u:
					num ^= InvitationParams.smethod_2(this.InvitationMessage);
					arg_68_0 = (num2 * 3685224022u ^ 3269138852u);
					continue;
				case 3u:
					goto IL_21;
				case 4u:
					goto IL_94;
				}
				break;
			}
			return num;
			IL_21:
			arg_68_0 = 257392083u;
			goto IL_63;
			IL_94:
			arg_68_0 = ((this.ExpirationTime == 0uL) ? 1106693482u : 827318889u);
			goto IL_63;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (InvitationParams.smethod_1(this.InvitationMessage) != 0)
			{
				goto IL_83;
			}
			goto IL_C4;
			uint arg_8D_0;
			while (true)
			{
				IL_88:
				uint num;
				switch ((num = (arg_8D_0 ^ 1155849619u)) % 7u)
				{
				case 0u:
					goto IL_83;
				case 1u:
					output.WriteRawTag(10);
					arg_8D_0 = (num * 3537722672u ^ 2382564016u);
					continue;
				case 2u:
					output.WriteString(this.InvitationMessage);
					arg_8D_0 = (num * 3599473146u ^ 986192409u);
					continue;
				case 3u:
					output.WriteRawTag(16);
					arg_8D_0 = (num * 3670887463u ^ 1931730184u);
					continue;
				case 4u:
					goto IL_C4;
				case 6u:
					output.WriteUInt64(this.ExpirationTime);
					arg_8D_0 = (num * 963990612u ^ 434398963u);
					continue;
				}
				break;
			}
			return;
			IL_83:
			arg_8D_0 = 1817358936u;
			goto IL_88;
			IL_C4:
			arg_8D_0 = ((this.ExpirationTime == 0uL) ? 1332430635u : 2106880224u);
			goto IL_88;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_BB:
				uint arg_97_0 = 1160657995u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_97_0 ^ 992238010u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.InvitationMessage);
						arg_97_0 = (num2 * 2045348977u ^ 2510845339u);
						continue;
					case 1u:
						arg_97_0 = (((InvitationParams.smethod_1(this.InvitationMessage) != 0) ? 3864931929u : 3680179032u) ^ num2 * 1995252049u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationTime);
						arg_97_0 = (num2 * 1255176711u ^ 3421865119u);
						continue;
					case 4u:
						goto IL_BB;
					case 5u:
						arg_97_0 = ((this.ExpirationTime == 0uL) ? 1749807923u : 1848251982u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(InvitationParams other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 1216588428u)) % 7u)
				{
				case 0u:
					goto IL_6C;
				case 1u:
					goto IL_AD;
				case 2u:
					arg_76_0 = ((other.ExpirationTime == 0uL) ? 1330759525u : 2032971207u);
					continue;
				case 3u:
					this.InvitationMessage = other.InvitationMessage;
					arg_76_0 = (num * 1413834978u ^ 2685557099u);
					continue;
				case 5u:
					this.ExpirationTime = other.ExpirationTime;
					arg_76_0 = (num * 969803350u ^ 319025751u);
					continue;
				case 6u:
					return;
				}
				break;
			}
			return;
			IL_6C:
			arg_76_0 = 2134808782u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((InvitationParams.smethod_1(other.InvitationMessage) == 0) ? 965257921u : 957863721u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_104:
				uint num;
				uint arg_C0_0 = ((num = input.ReadTag()) != 0u) ? 1241687099u : 1820168618u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C0_0 ^ 891652911u)) % 10u)
					{
					case 0u:
						this.InvitationMessage = input.ReadString();
						arg_C0_0 = 1901855847u;
						continue;
					case 2u:
						arg_C0_0 = (((num == 16u) ? 2620015022u : 3483785403u) ^ num2 * 4205640007u);
						continue;
					case 3u:
						arg_C0_0 = 1241687099u;
						continue;
					case 4u:
						arg_C0_0 = (num2 * 3344264864u ^ 2162965900u);
						continue;
					case 5u:
						arg_C0_0 = (num2 * 3484173251u ^ 3506630805u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_C0_0 = (num2 * 3644733421u ^ 938578886u);
						continue;
					case 7u:
						goto IL_104;
					case 8u:
						arg_C0_0 = ((num == 10u) ? 1392693279u : 216610901u);
						continue;
					case 9u:
						this.ExpirationTime = input.ReadUInt64();
						arg_C0_0 = 312361100u;
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
