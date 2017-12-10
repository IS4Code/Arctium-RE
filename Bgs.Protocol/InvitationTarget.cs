using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class InvitationTarget : IMessage<InvitationTarget>, IEquatable<InvitationTarget>, IDeepCloneable<InvitationTarget>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly InvitationTarget.__c __9 = new InvitationTarget.__c();

			internal InvitationTarget cctor>b__34_0()
			{
				return new InvitationTarget();
			}
		}

		private static readonly MessageParser<InvitationTarget> _parser = new MessageParser<InvitationTarget>(new Func<InvitationTarget>(InvitationTarget.__c.__9.<.cctor>b__34_0));

		public const int IdentityFieldNumber = 1;

		private Identity identity_;

		public const int EmailFieldNumber = 2;

		private string email_ = "";

		public const int BattleTagFieldNumber = 3;

		private string battleTag_ = "";

		public static MessageParser<InvitationTarget> Parser
		{
			get
			{
				return InvitationTarget._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationTarget.Descriptor;
			}
		}

		public Identity Identity
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

		public string Email
		{
			get
			{
				return this.email_;
			}
			set
			{
				this.email_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public string BattleTag
		{
			get
			{
				return this.battleTag_;
			}
			set
			{
				this.battleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public InvitationTarget()
		{
		}

		public InvitationTarget(InvitationTarget other) : this()
		{
			while (true)
			{
				IL_84:
				uint arg_64_0 = 1293158970u;
				while (true)
				{
					uint num;
					switch ((num = (arg_64_0 ^ 581874021u)) % 5u)
					{
					case 0u:
						goto IL_84;
					case 2u:
						this.battleTag_ = other.battleTag_;
						arg_64_0 = (num * 2534233388u ^ 2105641391u);
						continue;
					case 3u:
						this.email_ = other.email_;
						arg_64_0 = (num * 370127091u ^ 2989491841u);
						continue;
					case 4u:
						this.Identity = ((other.identity_ != null) ? other.Identity.Clone() : null);
						arg_64_0 = 1053271994u;
						continue;
					}
					return;
				}
			}
		}

		public InvitationTarget Clone()
		{
			return new InvitationTarget(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationTarget);
		}

		public bool Equals(InvitationTarget other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_EF;
			int arg_A9_0;
			while (true)
			{
				IL_A4:
				switch ((arg_A9_0 ^ -1464697841) % 11)
				{
				case 1:
					arg_A9_0 = (InvitationTarget.smethod_0(this.Identity, other.Identity) ? -815569005 : -182179835);
					continue;
				case 2:
					arg_A9_0 = ((!InvitationTarget.smethod_1(this.BattleTag, other.BattleTag)) ? -438962322 : -2041126269);
					continue;
				case 3:
					return false;
				case 4:
					arg_A9_0 = ((!InvitationTarget.smethod_1(this.Email, other.Email)) ? -142131300 : -911325721);
					continue;
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					return false;
				case 8:
					goto IL_18;
				case 9:
					return false;
				case 10:
					goto IL_EF;
				}
				break;
			}
			return true;
			IL_18:
			arg_A9_0 = -1143796936;
			goto IL_A4;
			IL_EF:
			arg_A9_0 = ((other == this) ? -1017652279 : -226030094);
			goto IL_A4;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.identity_ != null)
			{
				goto IL_1F;
			}
			goto IL_DD;
			uint arg_A6_0;
			while (true)
			{
				IL_A1:
				uint num2;
				switch ((num2 = (arg_A6_0 ^ 542063503u)) % 7u)
				{
				case 0u:
					arg_A6_0 = ((InvitationTarget.smethod_3(this.BattleTag) == 0) ? 234027055u : 235004355u);
					continue;
				case 1u:
					num ^= InvitationTarget.smethod_2(this.Identity);
					arg_A6_0 = (num2 * 2812839430u ^ 2203635570u);
					continue;
				case 2u:
					num ^= InvitationTarget.smethod_2(this.BattleTag);
					arg_A6_0 = (num2 * 1812412790u ^ 3807736615u);
					continue;
				case 3u:
					num ^= InvitationTarget.smethod_2(this.Email);
					arg_A6_0 = (num2 * 521890068u ^ 454696927u);
					continue;
				case 4u:
					goto IL_1F;
				case 6u:
					goto IL_DD;
				}
				break;
			}
			return num;
			IL_1F:
			arg_A6_0 = 1183323723u;
			goto IL_A1;
			IL_DD:
			arg_A6_0 = ((InvitationTarget.smethod_3(this.Email) == 0) ? 1737555347u : 1641061240u);
			goto IL_A1;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.identity_ != null)
			{
				goto IL_43;
			}
			goto IL_11A;
			uint arg_DA_0;
			while (true)
			{
				IL_D5:
				uint num;
				switch ((num = (arg_DA_0 ^ 3104834726u)) % 9u)
				{
				case 0u:
					output.WriteString(this.Email);
					arg_DA_0 = (num * 3895185694u ^ 1904042383u);
					continue;
				case 1u:
					goto IL_11A;
				case 2u:
					arg_DA_0 = ((InvitationTarget.smethod_3(this.BattleTag) == 0) ? 3284107111u : 2321937597u);
					continue;
				case 3u:
					output.WriteRawTag(26);
					arg_DA_0 = (num * 94161486u ^ 636072543u);
					continue;
				case 4u:
					output.WriteRawTag(18);
					arg_DA_0 = (num * 4260277304u ^ 572739764u);
					continue;
				case 5u:
					output.WriteString(this.BattleTag);
					arg_DA_0 = (num * 4205741005u ^ 4169816640u);
					continue;
				case 6u:
					goto IL_43;
				case 8u:
					output.WriteRawTag(10);
					output.WriteMessage(this.Identity);
					arg_DA_0 = (num * 124134465u ^ 977088389u);
					continue;
				}
				break;
			}
			return;
			IL_43:
			arg_DA_0 = 3717389813u;
			goto IL_D5;
			IL_11A:
			arg_DA_0 = ((InvitationTarget.smethod_3(this.Email) == 0) ? 2537043891u : 2188869768u);
			goto IL_D5;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_10E:
				uint arg_E2_0 = 1965375945u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_E2_0 ^ 870622999u)) % 8u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
						arg_E2_0 = (num2 * 4285220991u ^ 3355189899u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
						arg_E2_0 = (num2 * 2046767665u ^ 1442256636u);
						continue;
					case 3u:
						arg_E2_0 = ((InvitationTarget.smethod_3(this.Email) == 0) ? 1868316115u : 1489359807u);
						continue;
					case 4u:
						arg_E2_0 = ((InvitationTarget.smethod_3(this.BattleTag) != 0) ? 1044742662u : 1609792701u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
						arg_E2_0 = (num2 * 65253591u ^ 2992012327u);
						continue;
					case 6u:
						arg_E2_0 = (((this.identity_ != null) ? 3595774630u : 3858071312u) ^ num2 * 219496698u);
						continue;
					case 7u:
						goto IL_10E;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(InvitationTarget other)
		{
			if (other == null)
			{
				goto IL_101;
			}
			goto IL_153;
			uint arg_10B_0;
			while (true)
			{
				IL_106:
				uint num;
				switch ((num = (arg_10B_0 ^ 128429106u)) % 11u)
				{
				case 0u:
					goto IL_101;
				case 1u:
					arg_10B_0 = ((InvitationTarget.smethod_3(other.Email) == 0) ? 1264449550u : 1578303999u);
					continue;
				case 2u:
					goto IL_153;
				case 3u:
					this.Identity.MergeFrom(other.Identity);
					arg_10B_0 = 373572617u;
					continue;
				case 4u:
					this.identity_ = new Identity();
					arg_10B_0 = (num * 2843593886u ^ 1921193449u);
					continue;
				case 5u:
					arg_10B_0 = ((InvitationTarget.smethod_3(other.BattleTag) == 0) ? 13464445u : 1835787145u);
					continue;
				case 6u:
					this.Email = other.Email;
					arg_10B_0 = (num * 3559346774u ^ 197457104u);
					continue;
				case 7u:
					this.BattleTag = other.BattleTag;
					arg_10B_0 = (num * 1895651964u ^ 704655337u);
					continue;
				case 8u:
					arg_10B_0 = (((this.identity_ != null) ? 3641390961u : 3226621156u) ^ num * 615036505u);
					continue;
				case 9u:
					return;
				}
				break;
			}
			return;
			IL_101:
			arg_10B_0 = 1230129158u;
			goto IL_106;
			IL_153:
			arg_10B_0 = ((other.identity_ != null) ? 1548669078u : 373572617u);
			goto IL_106;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1AA:
				uint num;
				uint arg_152_0 = ((num = input.ReadTag()) != 0u) ? 4120374329u : 2412510818u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_152_0 ^ 3114483619u)) % 15u)
					{
					case 0u:
						arg_152_0 = 4120374329u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_152_0 = (num2 * 2611984491u ^ 1185075762u);
						continue;
					case 2u:
						arg_152_0 = (num2 * 3932401031u ^ 4144928171u);
						continue;
					case 3u:
						arg_152_0 = (num2 * 2314201282u ^ 403021835u);
						continue;
					case 5u:
						goto IL_1AA;
					case 6u:
						arg_152_0 = (((num == 26u) ? 819288335u : 876085805u) ^ num2 * 564671746u);
						continue;
					case 7u:
						this.identity_ = new Identity();
						arg_152_0 = (num2 * 2287522231u ^ 1684420270u);
						continue;
					case 8u:
						arg_152_0 = (num2 * 2958989048u ^ 2504780945u);
						continue;
					case 9u:
						input.ReadMessage(this.identity_);
						arg_152_0 = 3990377482u;
						continue;
					case 10u:
						arg_152_0 = ((this.identity_ == null) ? 4286373039u : 3136171834u);
						continue;
					case 11u:
						arg_152_0 = (((num == 18u) ? 4220038924u : 2868102749u) ^ num2 * 967795452u);
						continue;
					case 12u:
						this.BattleTag = input.ReadString();
						arg_152_0 = 3403292185u;
						continue;
					case 13u:
						arg_152_0 = ((num != 10u) ? 3383413984u : 3127068585u);
						continue;
					case 14u:
						this.Email = input.ReadString();
						arg_152_0 = 3291983005u;
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
