using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class GenericInvitationRequest : IMessage<GenericInvitationRequest>, IEquatable<GenericInvitationRequest>, IDeepCloneable<GenericInvitationRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GenericInvitationRequest.__c __9 = new GenericInvitationRequest.__c();

			internal GenericInvitationRequest cctor>b__59_0()
			{
				return new GenericInvitationRequest();
			}
		}

		private static readonly MessageParser<GenericInvitationRequest> _parser = new MessageParser<GenericInvitationRequest>(new Func<GenericInvitationRequest>(GenericInvitationRequest.__c.__9.<.cctor>b__59_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public const int InvitationIdFieldNumber = 3;

		private ulong invitationId_;

		public const int InviteeNameFieldNumber = 4;

		private string inviteeName_ = "";

		public const int InviterNameFieldNumber = 5;

		private string inviterName_ = "";

		public const int PreviousRoleFieldNumber = 6;

		private static readonly FieldCodec<uint> _repeated_previousRole_codec = FieldCodec.ForUInt32(50u);

		private readonly RepeatedField<uint> previousRole_ = new RepeatedField<uint>();

		public const int DesiredRoleFieldNumber = 7;

		private static readonly FieldCodec<uint> _repeated_desiredRole_codec;

		private readonly RepeatedField<uint> desiredRole_ = new RepeatedField<uint>();

		public const int ReasonFieldNumber = 8;

		private uint reason_;

		public static MessageParser<GenericInvitationRequest> Parser
		{
			get
			{
				return GenericInvitationRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenericInvitationRequest.Descriptor;
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

		public ulong InvitationId
		{
			get
			{
				return this.invitationId_;
			}
			set
			{
				this.invitationId_ = value;
			}
		}

		public string InviteeName
		{
			get
			{
				return this.inviteeName_;
			}
			set
			{
				this.inviteeName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public string InviterName
		{
			get
			{
				return this.inviterName_;
			}
			set
			{
				this.inviterName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public RepeatedField<uint> PreviousRole
		{
			get
			{
				return this.previousRole_;
			}
		}

		public RepeatedField<uint> DesiredRole
		{
			get
			{
				return this.desiredRole_;
			}
		}

		public uint Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		public GenericInvitationRequest()
		{
		}

		public GenericInvitationRequest(GenericInvitationRequest other) : this()
		{
			while (true)
			{
				IL_11F:
				uint arg_F3_0 = 1056684561u;
				while (true)
				{
					uint num;
					switch ((num = (arg_F3_0 ^ 656536760u)) % 8u)
					{
					case 1u:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
						this.invitationId_ = other.invitationId_;
						arg_F3_0 = 1803462748u;
						continue;
					case 2u:
						goto IL_11F;
					case 3u:
						this.previousRole_ = other.previousRole_.Clone();
						arg_F3_0 = (num * 1614153759u ^ 518473834u);
						continue;
					case 4u:
						this.inviteeName_ = other.inviteeName_;
						arg_F3_0 = (num * 2436642343u ^ 3638323978u);
						continue;
					case 5u:
						this.reason_ = other.reason_;
						arg_F3_0 = (num * 1624885727u ^ 1307742075u);
						continue;
					case 6u:
						this.inviterName_ = other.inviterName_;
						arg_F3_0 = (num * 396772190u ^ 645146175u);
						continue;
					case 7u:
						this.desiredRole_ = other.desiredRole_.Clone();
						arg_F3_0 = (num * 1961823554u ^ 636699227u);
						continue;
					}
					return;
				}
			}
		}

		public GenericInvitationRequest Clone()
		{
			return new GenericInvitationRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GenericInvitationRequest);
		}

		public bool Equals(GenericInvitationRequest other)
		{
			if (other == null)
			{
				goto IL_156;
			}
			goto IL_1F5;
			int arg_187_0;
			while (true)
			{
				IL_182:
				switch ((arg_187_0 ^ 2554769) % 21)
				{
				case 0:
					arg_187_0 = ((this.InvitationId == other.InvitationId) ? 1187341796 : 597252070);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					goto IL_156;
				case 9:
					return false;
				case 10:
					arg_187_0 = ((!this.previousRole_.Equals(other.previousRole_)) ? 385775927 : 1269190162);
					continue;
				case 11:
					arg_187_0 = ((this.Reason != other.Reason) ? 85917337 : 1472101041);
					continue;
				case 12:
					arg_187_0 = (GenericInvitationRequest.smethod_0(this.AgentId, other.AgentId) ? 860405672 : 2030615852);
					continue;
				case 13:
					return false;
				case 14:
					arg_187_0 = ((!GenericInvitationRequest.smethod_1(this.InviterName, other.InviterName)) ? 1111203385 : 2017946232);
					continue;
				case 15:
					return false;
				case 16:
					goto IL_1F5;
				case 17:
					arg_187_0 = (this.desiredRole_.Equals(other.desiredRole_) ? 847388837 : 543668250);
					continue;
				case 18:
					return false;
				case 19:
					arg_187_0 = ((!GenericInvitationRequest.smethod_0(this.TargetId, other.TargetId)) ? 573941248 : 1794205833);
					continue;
				case 20:
					arg_187_0 = ((!GenericInvitationRequest.smethod_1(this.InviteeName, other.InviteeName)) ? 496920135 : 641249287);
					continue;
				}
				break;
			}
			return true;
			IL_156:
			arg_187_0 = 1688067022;
			goto IL_182;
			IL_1F5:
			arg_187_0 = ((other == this) ? 979624104 : 1268568741);
			goto IL_182;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_80;
			}
			goto IL_1FF;
			uint arg_1AB_0;
			while (true)
			{
				IL_1A6:
				uint num2;
				switch ((num2 = (arg_1AB_0 ^ 3668793923u)) % 14u)
				{
				case 0u:
					num ^= this.InviterName.GetHashCode();
					arg_1AB_0 = (num2 * 3105119018u ^ 1920523225u);
					continue;
				case 1u:
					num ^= this.InvitationId.GetHashCode();
					arg_1AB_0 = (num2 * 2907974843u ^ 1138296540u);
					continue;
				case 2u:
					num ^= GenericInvitationRequest.smethod_2(this.AgentId);
					arg_1AB_0 = (num2 * 978015023u ^ 1227427652u);
					continue;
				case 3u:
					goto IL_1FF;
				case 4u:
					arg_1AB_0 = ((this.InviteeName.Length != 0) ? 3648582635u : 3405715959u);
					continue;
				case 5u:
					num ^= this.desiredRole_.GetHashCode();
					arg_1AB_0 = (((this.Reason != 0u) ? 1760534979u : 1338576209u) ^ num2 * 3086973475u);
					continue;
				case 6u:
					num ^= this.InviteeName.GetHashCode();
					arg_1AB_0 = (num2 * 2654621065u ^ 3146795807u);
					continue;
				case 7u:
					num ^= this.Reason.GetHashCode();
					arg_1AB_0 = (num2 * 1350606940u ^ 1824336156u);
					continue;
				case 8u:
					arg_1AB_0 = ((this.InvitationId != 0uL) ? 3800659734u : 3368206283u);
					continue;
				case 9u:
					goto IL_80;
				case 10u:
					num ^= this.previousRole_.GetHashCode();
					arg_1AB_0 = 3373854648u;
					continue;
				case 12u:
					arg_1AB_0 = ((this.InviterName.Length == 0) ? 2295113529u : 2777158387u);
					continue;
				case 13u:
					num ^= GenericInvitationRequest.smethod_2(this.TargetId);
					arg_1AB_0 = (num2 * 3841540767u ^ 3996508988u);
					continue;
				}
				break;
			}
			return num;
			IL_80:
			arg_1AB_0 = 2696048645u;
			goto IL_1A6;
			IL_1FF:
			arg_1AB_0 = ((this.targetId_ != null) ? 3632359544u : 3422325657u);
			goto IL_1A6;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_EA;
			}
			goto IL_266;
			uint arg_206_0;
			while (true)
			{
				IL_201:
				uint num;
				switch ((num = (arg_206_0 ^ 2703804494u)) % 17u)
				{
				case 0u:
					arg_206_0 = ((this.InvitationId != 0uL) ? 2741164820u : 3807102200u);
					continue;
				case 1u:
					output.WriteRawTag(42);
					arg_206_0 = (num * 4224070976u ^ 3240480962u);
					continue;
				case 3u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_206_0 = (num * 65370587u ^ 4211546450u);
					continue;
				case 4u:
					output.WriteString(this.InviterName);
					arg_206_0 = (num * 1174136751u ^ 250991848u);
					continue;
				case 5u:
					this.previousRole_.WriteTo(output, GenericInvitationRequest._repeated_previousRole_codec);
					this.desiredRole_.WriteTo(output, GenericInvitationRequest._repeated_desiredRole_codec);
					arg_206_0 = 3746839194u;
					continue;
				case 6u:
					output.WriteString(this.InviteeName);
					arg_206_0 = (num * 2912679448u ^ 2832240144u);
					continue;
				case 7u:
					arg_206_0 = (((this.Reason == 0u) ? 975868653u : 1069592898u) ^ num * 1875812251u);
					continue;
				case 8u:
					output.WriteRawTag(18);
					output.WriteMessage(this.TargetId);
					arg_206_0 = (num * 2883106574u ^ 953586593u);
					continue;
				case 9u:
					goto IL_266;
				case 10u:
					goto IL_EA;
				case 11u:
					output.WriteRawTag(34);
					arg_206_0 = (num * 3992346642u ^ 1492483036u);
					continue;
				case 12u:
					output.WriteFixed64(this.InvitationId);
					arg_206_0 = (num * 2431067256u ^ 3630880472u);
					continue;
				case 13u:
					arg_206_0 = ((GenericInvitationRequest.smethod_3(this.InviterName) == 0) ? 2663977436u : 2990680904u);
					continue;
				case 14u:
					arg_206_0 = ((GenericInvitationRequest.smethod_3(this.InviteeName) != 0) ? 3080624631u : 3603039120u);
					continue;
				case 15u:
					output.WriteRawTag(25);
					arg_206_0 = (num * 992336864u ^ 1053321202u);
					continue;
				case 16u:
					output.WriteRawTag(64);
					output.WriteUInt32(this.Reason);
					arg_206_0 = (num * 3277241106u ^ 2916850449u);
					continue;
				}
				break;
			}
			return;
			IL_EA:
			arg_206_0 = 3146441540u;
			goto IL_201;
			IL_266:
			arg_206_0 = ((this.targetId_ == null) ? 2617991701u : 2684588696u);
			goto IL_201;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_F7;
			}
			goto IL_21D;
			uint arg_1C5_0;
			while (true)
			{
				IL_1C0:
				uint num2;
				switch ((num2 = (arg_1C5_0 ^ 23272793u)) % 15u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
					arg_1C5_0 = (num2 * 3362377834u ^ 708245417u);
					continue;
				case 1u:
					arg_1C5_0 = ((this.InvitationId != 0uL) ? 1527262505u : 1070347458u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InviteeName);
					arg_1C5_0 = (num2 * 28089224u ^ 2158905755u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.InviterName);
					arg_1C5_0 = (num2 * 758822467u ^ 1367341420u);
					continue;
				case 4u:
					arg_1C5_0 = ((GenericInvitationRequest.smethod_3(this.InviterName) == 0) ? 1077254645u : 1778755754u);
					continue;
				case 5u:
					num += this.previousRole_.CalculateSize(GenericInvitationRequest._repeated_previousRole_codec);
					arg_1C5_0 = 697265797u;
					continue;
				case 7u:
					goto IL_F7;
				case 8u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
					arg_1C5_0 = (num2 * 723041901u ^ 1776770218u);
					continue;
				case 9u:
					goto IL_21D;
				case 10u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_1C5_0 = (num2 * 673275115u ^ 2135025303u);
					continue;
				case 11u:
					num += this.desiredRole_.CalculateSize(GenericInvitationRequest._repeated_desiredRole_codec);
					arg_1C5_0 = (num2 * 1645559483u ^ 3344800299u);
					continue;
				case 12u:
					num += 9;
					arg_1C5_0 = (num2 * 3512338350u ^ 3846293730u);
					continue;
				case 13u:
					arg_1C5_0 = ((GenericInvitationRequest.smethod_3(this.InviteeName) == 0) ? 97184011u : 620582251u);
					continue;
				case 14u:
					arg_1C5_0 = (((this.Reason != 0u) ? 1601743729u : 1109968714u) ^ num2 * 2695303349u);
					continue;
				}
				break;
			}
			return num;
			IL_F7:
			arg_1C5_0 = 1198483859u;
			goto IL_1C0;
			IL_21D:
			arg_1C5_0 = ((this.targetId_ != null) ? 169500618u : 1185871735u);
			goto IL_1C0;
		}

		public void MergeFrom(GenericInvitationRequest other)
		{
			if (other == null)
			{
				goto IL_33;
			}
			goto IL_2A1;
			uint arg_239_0;
			while (true)
			{
				IL_234:
				uint num;
				switch ((num = (arg_239_0 ^ 3157404293u)) % 19u)
				{
				case 0u:
					arg_239_0 = ((GenericInvitationRequest.smethod_3(other.InviterName) == 0) ? 2569888407u : 3610149296u);
					continue;
				case 1u:
					return;
				case 2u:
					arg_239_0 = ((GenericInvitationRequest.smethod_3(other.InviteeName) != 0) ? 3023486354u : 3054335556u);
					continue;
				case 3u:
					this.Reason = other.Reason;
					arg_239_0 = (num * 3168351478u ^ 1038929435u);
					continue;
				case 4u:
					arg_239_0 = (((this.targetId_ != null) ? 1582581301u : 1280135609u) ^ num * 2657863670u);
					continue;
				case 5u:
					goto IL_2A1;
				case 6u:
					arg_239_0 = ((other.targetId_ != null) ? 3935460446u : 4142315601u);
					continue;
				case 7u:
					arg_239_0 = ((other.InvitationId != 0uL) ? 3459002342u : 4017967055u);
					continue;
				case 8u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_239_0 = 4142315601u;
					continue;
				case 9u:
					this.InvitationId = other.InvitationId;
					arg_239_0 = (num * 3509536708u ^ 1843059459u);
					continue;
				case 10u:
					arg_239_0 = (((this.agentId_ != null) ? 1108786303u : 1490211736u) ^ num * 3027869808u);
					continue;
				case 11u:
					this.InviterName = other.InviterName;
					arg_239_0 = (num * 3131967730u ^ 2673140365u);
					continue;
				case 12u:
					this.agentId_ = new EntityId();
					arg_239_0 = (num * 1600749415u ^ 1266821332u);
					continue;
				case 13u:
					this.targetId_ = new EntityId();
					arg_239_0 = (num * 415070105u ^ 748424665u);
					continue;
				case 14u:
					this.InviteeName = other.InviteeName;
					arg_239_0 = (num * 2950567290u ^ 1200330162u);
					continue;
				case 16u:
					this.previousRole_.Add(other.previousRole_);
					this.desiredRole_.Add(other.desiredRole_);
					arg_239_0 = ((other.Reason == 0u) ? 4025871447u : 2820742935u);
					continue;
				case 17u:
					goto IL_33;
				case 18u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_239_0 = 2594855818u;
					continue;
				}
				break;
			}
			return;
			IL_33:
			arg_239_0 = 3537964763u;
			goto IL_234;
			IL_2A1:
			arg_239_0 = ((other.agentId_ != null) ? 2998704206u : 2594855818u);
			goto IL_234;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_492:
				uint num;
				uint arg_3E2_0 = ((num = input.ReadTag()) == 0u) ? 3734054344u : 2188668987u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_3E2_0 ^ 2705356212u)) % 37u)
					{
					case 0u:
						arg_3E2_0 = (num2 * 637882916u ^ 3122549969u);
						continue;
					case 2u:
						this.agentId_ = new EntityId();
						arg_3E2_0 = (num2 * 2109008875u ^ 3977866597u);
						continue;
					case 3u:
						goto IL_492;
					case 4u:
						input.ReadMessage(this.agentId_);
						arg_3E2_0 = 3043883513u;
						continue;
					case 5u:
						arg_3E2_0 = (num2 * 3543989649u ^ 4033832630u);
						continue;
					case 6u:
						this.previousRole_.AddEntriesFrom(input, GenericInvitationRequest._repeated_previousRole_codec);
						arg_3E2_0 = 2270013140u;
						continue;
					case 7u:
						arg_3E2_0 = (((num != 58u) ? 1358985436u : 520083246u) ^ num2 * 4109305085u);
						continue;
					case 8u:
						arg_3E2_0 = (((num == 50u) ? 1186804065u : 111521762u) ^ num2 * 3816462622u);
						continue;
					case 9u:
						arg_3E2_0 = ((num == 25u) ? 3159300094u : 3763790057u);
						continue;
					case 10u:
						arg_3E2_0 = ((num != 56u) ? 3492098633u : 3784625703u);
						continue;
					case 11u:
						arg_3E2_0 = ((num > 50u) ? 2348462024u : 2333708677u);
						continue;
					case 12u:
						arg_3E2_0 = ((this.targetId_ == null) ? 3754495089u : 2351214613u);
						continue;
					case 13u:
						arg_3E2_0 = (((num == 34u) ? 790681514u : 892105291u) ^ num2 * 3166465151u);
						continue;
					case 14u:
						arg_3E2_0 = (num2 * 2895216382u ^ 3252839771u);
						continue;
					case 15u:
						arg_3E2_0 = (((num == 18u) ? 3220326863u : 3169650041u) ^ num2 * 2610532248u);
						continue;
					case 16u:
						arg_3E2_0 = (num2 * 308218081u ^ 3141739586u);
						continue;
					case 17u:
						arg_3E2_0 = (((num <= 18u) ? 2677893560u : 3010007428u) ^ num2 * 1239125738u);
						continue;
					case 18u:
						arg_3E2_0 = (((num != 42u) ? 3680361911u : 2538337726u) ^ num2 * 1828639801u);
						continue;
					case 19u:
						arg_3E2_0 = (((num == 64u) ? 2756916513u : 3258915250u) ^ num2 * 1537021519u);
						continue;
					case 20u:
						this.InvitationId = input.ReadFixed64();
						arg_3E2_0 = 3043883513u;
						continue;
					case 21u:
						arg_3E2_0 = ((num > 42u) ? 2242478956u : 2288404060u);
						continue;
					case 22u:
						arg_3E2_0 = (((num == 10u) ? 1074440454u : 1943805218u) ^ num2 * 2788466931u);
						continue;
					case 23u:
						this.InviterName = input.ReadString();
						arg_3E2_0 = 3229706190u;
						continue;
					case 24u:
						arg_3E2_0 = ((this.agentId_ != null) ? 3023503839u : 2757495834u);
						continue;
					case 25u:
						this.desiredRole_.AddEntriesFrom(input, GenericInvitationRequest._repeated_desiredRole_codec);
						arg_3E2_0 = 2255526898u;
						continue;
					case 26u:
						input.SkipLastField();
						arg_3E2_0 = 3043883513u;
						continue;
					case 27u:
						arg_3E2_0 = (num2 * 2722281082u ^ 226042637u);
						continue;
					case 28u:
						arg_3E2_0 = 2188668987u;
						continue;
					case 29u:
						arg_3E2_0 = (num2 * 628235850u ^ 3319417229u);
						continue;
					case 30u:
						arg_3E2_0 = (num2 * 1142854635u ^ 597497275u);
						continue;
					case 31u:
						arg_3E2_0 = (((num != 48u) ? 4022198477u : 2853759047u) ^ num2 * 2554071608u);
						continue;
					case 32u:
						input.ReadMessage(this.targetId_);
						arg_3E2_0 = 2662233782u;
						continue;
					case 33u:
						this.targetId_ = new EntityId();
						arg_3E2_0 = (num2 * 2306144477u ^ 2295088900u);
						continue;
					case 34u:
						arg_3E2_0 = (num2 * 873541815u ^ 3783909465u);
						continue;
					case 35u:
						this.InviteeName = input.ReadString();
						arg_3E2_0 = 2304682859u;
						continue;
					case 36u:
						this.Reason = input.ReadUInt32();
						arg_3E2_0 = 3043883513u;
						continue;
					}
					return;
				}
			}
		}

		static GenericInvitationRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_5E:
				uint arg_46_0 = 2658251277u;
				while (true)
				{
					uint num;
					switch ((num = (arg_46_0 ^ 2625550034u)) % 3u)
					{
					case 1u:
						GenericInvitationRequest._repeated_desiredRole_codec = FieldCodec.ForUInt32(58u);
						arg_46_0 = (num * 2668332511u ^ 3230558338u);
						continue;
					case 2u:
						goto IL_5E;
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
