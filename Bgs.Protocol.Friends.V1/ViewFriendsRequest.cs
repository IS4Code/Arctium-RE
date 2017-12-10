using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class ViewFriendsRequest : IMessage<ViewFriendsRequest>, IEquatable<ViewFriendsRequest>, IDeepCloneable<ViewFriendsRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ViewFriendsRequest.__c __9 = new ViewFriendsRequest.__c();

			internal ViewFriendsRequest cctor>b__34_0()
			{
				return new ViewFriendsRequest();
			}
		}

		private static readonly MessageParser<ViewFriendsRequest> _parser = new MessageParser<ViewFriendsRequest>(new Func<ViewFriendsRequest>(ViewFriendsRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public const int RoleFieldNumber = 3;

		private static readonly FieldCodec<uint> _repeated_role_codec;

		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		public static MessageParser<ViewFriendsRequest> Parser
		{
			get
			{
				return ViewFriendsRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ViewFriendsRequest.Descriptor;
			}
		}

		public EntityId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		public EntityId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		public ViewFriendsRequest()
		{
		}

		public ViewFriendsRequest(ViewFriendsRequest other) : this()
		{
			while (true)
			{
				IL_71:
				int arg_5B_0 = 830563187;
				while (true)
				{
					switch ((arg_5B_0 ^ 38527621) % 3)
					{
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
						this.role_ = other.role_.Clone();
						arg_5B_0 = 957425184;
						continue;
					case 2:
						goto IL_71;
					}
					return;
				}
			}
		}

		public ViewFriendsRequest Clone()
		{
			return new ViewFriendsRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ViewFriendsRequest);
		}

		public bool Equals(ViewFriendsRequest other)
		{
			if (other == null)
			{
				goto IL_70;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ -2128832251) % 11)
				{
				case 0:
					return false;
				case 1:
					arg_A6_0 = ((!this.role_.Equals(other.role_)) ? -148819915 : -411667621);
					continue;
				case 2:
					goto IL_EC;
				case 3:
					return false;
				case 4:
					goto IL_70;
				case 6:
					return false;
				case 7:
					arg_A6_0 = (ViewFriendsRequest.smethod_0(this.TargetId, other.TargetId) ? -1474841505 : -1224500517);
					continue;
				case 8:
					return true;
				case 9:
					arg_A6_0 = (ViewFriendsRequest.smethod_0(this.AgentId, other.AgentId) ? -1284404463 : -204166657);
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_70:
			arg_A6_0 = -1823551675;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other != this) ? -309028623 : -929117797);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_53;
			}
			goto IL_89;
			uint arg_5D_0;
			while (true)
			{
				IL_58:
				uint num2;
				switch ((num2 = (arg_5D_0 ^ 3057239186u)) % 5u)
				{
				case 0u:
					goto IL_53;
				case 2u:
					num ^= ViewFriendsRequest.smethod_1(this.AgentId);
					arg_5D_0 = (num2 * 1732604161u ^ 2809072907u);
					continue;
				case 3u:
					num ^= ViewFriendsRequest.smethod_1(this.TargetId);
					arg_5D_0 = (num2 * 692986329u ^ 489880796u);
					continue;
				case 4u:
					goto IL_89;
				}
				break;
			}
			return num ^ ViewFriendsRequest.smethod_1(this.role_);
			IL_53:
			arg_5D_0 = 3927777670u;
			goto IL_58;
			IL_89:
			arg_5D_0 = ((this.targetId_ != null) ? 3199862587u : 4283785117u);
			goto IL_58;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_87;
			}
			goto IL_C8;
			uint arg_91_0;
			while (true)
			{
				IL_8C:
				uint num;
				switch ((num = (arg_91_0 ^ 4216496526u)) % 7u)
				{
				case 0u:
					goto IL_87;
				case 1u:
					this.role_.WriteTo(output, ViewFriendsRequest._repeated_role_codec);
					arg_91_0 = 3752050463u;
					continue;
				case 2u:
					goto IL_C8;
				case 3u:
					output.WriteMessage(this.AgentId);
					arg_91_0 = (num * 3349460964u ^ 740484430u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					arg_91_0 = (num * 3161935329u ^ 182660182u);
					continue;
				case 5u:
					output.WriteRawTag(18);
					output.WriteMessage(this.TargetId);
					arg_91_0 = (num * 486212450u ^ 1818396439u);
					continue;
				}
				break;
			}
			return;
			IL_87:
			arg_91_0 = 2258914373u;
			goto IL_8C;
			IL_C8:
			arg_91_0 = ((this.targetId_ != null) ? 4049334404u : 3962610883u);
			goto IL_8C;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 2027518720u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 2093499469u)) % 6u)
					{
					case 0u:
						arg_92_0 = ((this.targetId_ != null) ? 805273769u : 2136364738u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_92_0 = (num2 * 1333621778u ^ 1436659853u);
						continue;
					case 3u:
						goto IL_B6;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
						arg_92_0 = (num2 * 463906400u ^ 1765538626u);
						continue;
					case 5u:
						arg_92_0 = (((this.agentId_ == null) ? 2698927809u : 4016867311u) ^ num2 * 1983316024u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			return num + this.role_.CalculateSize(ViewFriendsRequest._repeated_role_codec);
		}

		public void MergeFrom(ViewFriendsRequest other)
		{
			if (other == null)
			{
				goto IL_33;
			}
			goto IL_14A;
			uint arg_102_0;
			while (true)
			{
				IL_FD:
				uint num;
				switch ((num = (arg_102_0 ^ 1191653078u)) % 11u)
				{
				case 0u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_102_0 = 952057765u;
					continue;
				case 1u:
					arg_102_0 = (((this.targetId_ != null) ? 2140693247u : 479562822u) ^ num * 2447436232u);
					continue;
				case 2u:
					this.targetId_ = new EntityId();
					arg_102_0 = (num * 3205973762u ^ 1151193527u);
					continue;
				case 3u:
					goto IL_14A;
				case 5u:
					return;
				case 6u:
					this.agentId_ = new EntityId();
					arg_102_0 = (num * 1357459244u ^ 3351312432u);
					continue;
				case 7u:
					arg_102_0 = (((this.agentId_ != null) ? 3310089488u : 2277518543u) ^ num * 1298028245u);
					continue;
				case 8u:
					arg_102_0 = ((other.targetId_ == null) ? 952057765u : 363615557u);
					continue;
				case 9u:
					goto IL_33;
				case 10u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_102_0 = 807405967u;
					continue;
				}
				break;
			}
			this.role_.Add(other.role_);
			return;
			IL_33:
			arg_102_0 = 1825304945u;
			goto IL_FD;
			IL_14A:
			arg_102_0 = ((other.agentId_ != null) ? 161436506u : 807405967u);
			goto IL_FD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_235:
				uint num;
				uint arg_1D1_0 = ((num = input.ReadTag()) != 0u) ? 3798320823u : 2699038397u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1D1_0 ^ 3199339238u)) % 18u)
					{
					case 0u:
						arg_1D1_0 = (((num == 18u) ? 3804597845u : 2399411763u) ^ num2 * 3710419518u);
						continue;
					case 1u:
						arg_1D1_0 = ((num > 18u) ? 2544347862u : 3864890642u);
						continue;
					case 2u:
						arg_1D1_0 = ((this.agentId_ != null) ? 2937213038u : 2260977933u);
						continue;
					case 3u:
						arg_1D1_0 = ((this.targetId_ == null) ? 2963192075u : 3667748296u);
						continue;
					case 4u:
						input.ReadMessage(this.agentId_);
						arg_1D1_0 = 4013741389u;
						continue;
					case 5u:
						arg_1D1_0 = (num2 * 3081502412u ^ 3410129138u);
						continue;
					case 6u:
						this.role_.AddEntriesFrom(input, ViewFriendsRequest._repeated_role_codec);
						arg_1D1_0 = 2830931638u;
						continue;
					case 7u:
						arg_1D1_0 = (((num != 26u) ? 3309878434u : 3113696613u) ^ num2 * 3770197099u);
						continue;
					case 8u:
						arg_1D1_0 = 3798320823u;
						continue;
					case 10u:
						input.ReadMessage(this.targetId_);
						arg_1D1_0 = 2830931638u;
						continue;
					case 11u:
						input.SkipLastField();
						arg_1D1_0 = 2830931638u;
						continue;
					case 12u:
						arg_1D1_0 = ((num != 24u) ? 3484299631u : 3204422438u);
						continue;
					case 13u:
						arg_1D1_0 = (num2 * 1546222842u ^ 2381362667u);
						continue;
					case 14u:
						goto IL_235;
					case 15u:
						this.targetId_ = new EntityId();
						arg_1D1_0 = (num2 * 712203429u ^ 846022153u);
						continue;
					case 16u:
						arg_1D1_0 = (((num == 10u) ? 1725675046u : 1151457520u) ^ num2 * 1429403721u);
						continue;
					case 17u:
						this.agentId_ = new EntityId();
						arg_1D1_0 = (num2 * 3883295361u ^ 4139253509u);
						continue;
					}
					return;
				}
			}
		}

		static ViewFriendsRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_52:
				uint arg_3A_0 = 2450646179u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3A_0 ^ 3642600596u)) % 3u)
					{
					case 1u:
						ViewFriendsRequest._repeated_role_codec = FieldCodec.ForUInt32(26u);
						arg_3A_0 = (num * 3803794232u ^ 1951300325u);
						continue;
					case 2u:
						goto IL_52;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
