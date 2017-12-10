using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class SendInvitationRequest : IMessage<SendInvitationRequest>, IEquatable<SendInvitationRequest>, IDeepCloneable<SendInvitationRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SendInvitationRequest.__c __9 = new SendInvitationRequest.__c();

			internal SendInvitationRequest cctor>b__44_0()
			{
				return new SendInvitationRequest();
			}
		}

		private static readonly MessageParser<SendInvitationRequest> _parser = new MessageParser<SendInvitationRequest>(new Func<SendInvitationRequest>(SendInvitationRequest.__c.__9.<.cctor>b__44_0));

		public const int AgentIdentityFieldNumber = 1;

		private Identity agentIdentity_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public const int ParamsFieldNumber = 3;

		private InvitationParams params_;

		public const int AgentInfoFieldNumber = 4;

		private AccountInfo agentInfo_;

		public const int TargetFieldNumber = 5;

		private InvitationTarget target_;

		public static MessageParser<SendInvitationRequest> Parser
		{
			get
			{
				return SendInvitationRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendInvitationRequest.Descriptor;
			}
		}

		public Identity AgentIdentity
		{
			get
			{
				return this.agentIdentity_;
			}
			set
			{
				this.agentIdentity_ = value;
			}
		}

		[Obsolete]
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

		public InvitationParams Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = value;
			}
		}

		public AccountInfo AgentInfo
		{
			get
			{
				return this.agentInfo_;
			}
			set
			{
				this.agentInfo_ = value;
			}
		}

		public InvitationTarget Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		public SendInvitationRequest()
		{
		}

		public SendInvitationRequest(SendInvitationRequest other) : this()
		{
			while (true)
			{
				IL_CD:
				int arg_AF_0 = 1510290348;
				while (true)
				{
					switch ((arg_AF_0 ^ 808385605) % 5)
					{
					case 0:
						goto IL_CD;
					case 1:
						this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
						this.Params = ((other.params_ != null) ? other.Params.Clone() : null);
						this.AgentInfo = ((other.agentInfo_ != null) ? other.AgentInfo.Clone() : null);
						arg_AF_0 = 750766957;
						continue;
					case 3:
						this.Target = ((other.target_ != null) ? other.Target.Clone() : null);
						arg_AF_0 = 695563032;
						continue;
					case 4:
						this.AgentIdentity = ((other.agentIdentity_ != null) ? other.AgentIdentity.Clone() : null);
						arg_AF_0 = 1498553803;
						continue;
					}
					return;
				}
			}
		}

		public SendInvitationRequest Clone()
		{
			return new SendInvitationRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SendInvitationRequest);
		}

		public bool Equals(SendInvitationRequest other)
		{
			if (other == null)
			{
				goto IL_47;
			}
			goto IL_15D;
			int arg_107_0;
			while (true)
			{
				IL_102:
				switch ((arg_107_0 ^ 2025144914) % 15)
				{
				case 0:
					arg_107_0 = ((!SendInvitationRequest.smethod_0(this.Params, other.Params)) ? 1667160873 : 1346969776);
					continue;
				case 1:
					arg_107_0 = (SendInvitationRequest.smethod_0(this.AgentInfo, other.AgentInfo) ? 1414472183 : 909666928);
					continue;
				case 2:
					arg_107_0 = ((!SendInvitationRequest.smethod_0(this.TargetId, other.TargetId)) ? 257175677 : 409028160);
					continue;
				case 3:
					arg_107_0 = ((!SendInvitationRequest.smethod_0(this.Target, other.Target)) ? 56716883 : 1470353683);
					continue;
				case 4:
					goto IL_47;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_15D;
				case 8:
					return false;
				case 9:
					return true;
				case 10:
					return false;
				case 12:
					arg_107_0 = (SendInvitationRequest.smethod_0(this.AgentIdentity, other.AgentIdentity) ? 1479593920 : 1667803999);
					continue;
				case 13:
					return false;
				case 14:
					return false;
				}
				break;
			}
			return true;
			IL_47:
			arg_107_0 = 1044157969;
			goto IL_102;
			IL_15D:
			arg_107_0 = ((other != this) ? 323797573 : 1619594161);
			goto IL_102;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_197:
				uint arg_15A_0 = 132576702u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_15A_0 ^ 721519708u)) % 12u)
					{
					case 1u:
						num ^= SendInvitationRequest.smethod_1(this.Target);
						arg_15A_0 = (num2 * 3591505444u ^ 2590354304u);
						continue;
					case 2u:
						arg_15A_0 = (((this.agentIdentity_ == null) ? 2883825382u : 3242720783u) ^ num2 * 2389658381u);
						continue;
					case 3u:
						goto IL_197;
					case 4u:
						arg_15A_0 = ((this.targetId_ != null) ? 479017691u : 2125998910u);
						continue;
					case 5u:
						num ^= SendInvitationRequest.smethod_1(this.AgentIdentity);
						arg_15A_0 = (num2 * 2579382234u ^ 208597366u);
						continue;
					case 6u:
						arg_15A_0 = ((this.params_ != null) ? 153581790u : 1855625453u);
						continue;
					case 7u:
						num ^= SendInvitationRequest.smethod_1(this.TargetId);
						arg_15A_0 = (num2 * 140823852u ^ 2613506314u);
						continue;
					case 8u:
						arg_15A_0 = ((this.target_ != null) ? 985846097u : 1980098644u);
						continue;
					case 9u:
						arg_15A_0 = ((this.agentInfo_ != null) ? 682911575u : 2058676340u);
						continue;
					case 10u:
						num ^= SendInvitationRequest.smethod_1(this.Params);
						arg_15A_0 = (num2 * 452643471u ^ 3479386227u);
						continue;
					case 11u:
						num ^= SendInvitationRequest.smethod_1(this.AgentInfo);
						arg_15A_0 = (num2 * 291770556u ^ 4189815904u);
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
			if (this.agentIdentity_ != null)
			{
				goto IL_13C;
			}
			goto IL_1D2;
			uint arg_17E_0;
			while (true)
			{
				IL_179:
				uint num;
				switch ((num = (arg_17E_0 ^ 93951081u)) % 14u)
				{
				case 0u:
					arg_17E_0 = ((this.params_ != null) ? 1354056076u : 1300611552u);
					continue;
				case 1u:
					output.WriteRawTag(26);
					arg_17E_0 = (num * 1292232891u ^ 2388628713u);
					continue;
				case 2u:
					goto IL_13C;
				case 3u:
					arg_17E_0 = ((this.agentInfo_ == null) ? 2007736377u : 640617459u);
					continue;
				case 5u:
					output.WriteRawTag(18);
					output.WriteMessage(this.TargetId);
					arg_17E_0 = (num * 1956241553u ^ 1289860594u);
					continue;
				case 6u:
					output.WriteRawTag(34);
					arg_17E_0 = (num * 2479696975u ^ 2149333973u);
					continue;
				case 7u:
					output.WriteMessage(this.Target);
					arg_17E_0 = (num * 3361381666u ^ 2660859795u);
					continue;
				case 8u:
					output.WriteMessage(this.AgentInfo);
					arg_17E_0 = (num * 2676317065u ^ 3394612275u);
					continue;
				case 9u:
					output.WriteRawTag(42);
					arg_17E_0 = (num * 2216577608u ^ 3338513376u);
					continue;
				case 10u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentIdentity);
					arg_17E_0 = (num * 1329313313u ^ 206451496u);
					continue;
				case 11u:
					goto IL_1D2;
				case 12u:
					arg_17E_0 = ((this.target_ != null) ? 1929301048u : 276872241u);
					continue;
				case 13u:
					output.WriteMessage(this.Params);
					arg_17E_0 = (num * 3577197065u ^ 1828821791u);
					continue;
				}
				break;
			}
			return;
			IL_13C:
			arg_17E_0 = 446011563u;
			goto IL_179;
			IL_1D2:
			arg_17E_0 = ((this.targetId_ != null) ? 410210752u : 1477402955u);
			goto IL_179;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentIdentity_ != null)
			{
				goto IL_65;
			}
			goto IL_17B;
			uint arg_133_0;
			while (true)
			{
				IL_12E:
				uint num2;
				switch ((num2 = (arg_133_0 ^ 111159404u)) % 11u)
				{
				case 0u:
					arg_133_0 = ((this.params_ == null) ? 462074162u : 1317347740u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
					arg_133_0 = (num2 * 2806112365u ^ 453569849u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Params);
					arg_133_0 = (num2 * 2269289643u ^ 4179710562u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
					arg_133_0 = (num2 * 742826197u ^ 2651154801u);
					continue;
				case 5u:
					arg_133_0 = ((this.target_ == null) ? 1690791881u : 1780953308u);
					continue;
				case 6u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentIdentity);
					arg_133_0 = (num2 * 3022224040u ^ 530834084u);
					continue;
				case 7u:
					goto IL_17B;
				case 8u:
					goto IL_65;
				case 9u:
					arg_133_0 = ((this.agentInfo_ != null) ? 355011069u : 133043382u);
					continue;
				case 10u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentInfo);
					arg_133_0 = (num2 * 1050150931u ^ 3485208949u);
					continue;
				}
				break;
			}
			return num;
			IL_65:
			arg_133_0 = 494755867u;
			goto IL_12E;
			IL_17B:
			arg_133_0 = ((this.targetId_ != null) ? 860627451u : 1755919314u);
			goto IL_12E;
		}

		public void MergeFrom(SendInvitationRequest other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_312;
			uint arg_29A_0;
			while (true)
			{
				IL_295:
				uint num;
				switch ((num = (arg_29A_0 ^ 3855063469u)) % 23u)
				{
				case 0u:
					this.Target.MergeFrom(other.Target);
					arg_29A_0 = 2880268281u;
					continue;
				case 1u:
					goto IL_312;
				case 2u:
					this.Params.MergeFrom(other.Params);
					arg_29A_0 = 3711966001u;
					continue;
				case 3u:
					return;
				case 4u:
					this.AgentIdentity.MergeFrom(other.AgentIdentity);
					arg_29A_0 = 4290884941u;
					continue;
				case 5u:
					arg_29A_0 = (((this.agentIdentity_ == null) ? 2620838903u : 3964011838u) ^ num * 2231507777u);
					continue;
				case 6u:
					arg_29A_0 = (((this.targetId_ == null) ? 972949639u : 1503292489u) ^ num * 4195906360u);
					continue;
				case 7u:
					arg_29A_0 = ((other.agentInfo_ == null) ? 4274579723u : 3486769970u);
					continue;
				case 8u:
					arg_29A_0 = ((other.targetId_ == null) ? 2951070316u : 3974400856u);
					continue;
				case 9u:
					arg_29A_0 = ((other.target_ == null) ? 2880268281u : 4005848807u);
					continue;
				case 10u:
					arg_29A_0 = ((other.params_ == null) ? 3711966001u : 3326848307u);
					continue;
				case 11u:
					this.target_ = new InvitationTarget();
					arg_29A_0 = (num * 1969860531u ^ 2024440218u);
					continue;
				case 12u:
					arg_29A_0 = (((this.params_ != null) ? 4089411133u : 2337163710u) ^ num * 3009200040u);
					continue;
				case 13u:
					arg_29A_0 = (((this.target_ == null) ? 825548741u : 283697562u) ^ num * 1794732214u);
					continue;
				case 14u:
					this.agentIdentity_ = new Identity();
					arg_29A_0 = (num * 2713943221u ^ 3561919088u);
					continue;
				case 15u:
					this.AgentInfo.MergeFrom(other.AgentInfo);
					arg_29A_0 = 4274579723u;
					continue;
				case 16u:
					this.params_ = new InvitationParams();
					arg_29A_0 = (num * 535890340u ^ 1494726881u);
					continue;
				case 17u:
					this.targetId_ = new EntityId();
					arg_29A_0 = (num * 3718407566u ^ 729774701u);
					continue;
				case 18u:
					this.agentInfo_ = new AccountInfo();
					arg_29A_0 = (num * 3717961086u ^ 1535166717u);
					continue;
				case 20u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_29A_0 = 2951070316u;
					continue;
				case 21u:
					goto IL_44;
				case 22u:
					arg_29A_0 = (((this.agentInfo_ != null) ? 1194985119u : 1560729160u) ^ num * 3443651636u);
					continue;
				}
				break;
			}
			return;
			IL_44:
			arg_29A_0 = 2846958446u;
			goto IL_295;
			IL_312:
			arg_29A_0 = ((other.agentIdentity_ != null) ? 2279287320u : 4290884941u);
			goto IL_295;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_392:
				uint num;
				uint arg_302_0 = ((num = input.ReadTag()) == 0u) ? 1827693986u : 1469439775u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_302_0 ^ 905885067u)) % 29u)
					{
					case 1u:
						arg_302_0 = (num2 * 1798701549u ^ 2086939658u);
						continue;
					case 2u:
						arg_302_0 = (num2 * 3853523296u ^ 1334526413u);
						continue;
					case 3u:
						arg_302_0 = (((num == 42u) ? 2727641399u : 2204326410u) ^ num2 * 3120627748u);
						continue;
					case 4u:
						arg_302_0 = ((this.agentInfo_ == null) ? 976764193u : 1906129476u);
						continue;
					case 5u:
						this.targetId_ = new EntityId();
						arg_302_0 = (num2 * 2757415859u ^ 1760966827u);
						continue;
					case 6u:
						arg_302_0 = ((this.params_ != null) ? 542498549u : 333971998u);
						continue;
					case 7u:
						arg_302_0 = ((this.agentIdentity_ != null) ? 3790383u : 785040497u);
						continue;
					case 8u:
						input.ReadMessage(this.target_);
						arg_302_0 = 1415627085u;
						continue;
					case 9u:
						this.target_ = new InvitationTarget();
						arg_302_0 = (num2 * 2278391978u ^ 809566600u);
						continue;
					case 10u:
						arg_302_0 = 1469439775u;
						continue;
					case 11u:
						input.SkipLastField();
						arg_302_0 = 1695621128u;
						continue;
					case 12u:
						arg_302_0 = (((num == 34u) ? 1635764665u : 1247907174u) ^ num2 * 63367510u);
						continue;
					case 13u:
						this.agentInfo_ = new AccountInfo();
						arg_302_0 = (num2 * 4004443549u ^ 3968186374u);
						continue;
					case 14u:
						arg_302_0 = ((num != 26u) ? 871441180u : 898466470u);
						continue;
					case 15u:
						arg_302_0 = (num2 * 3025530379u ^ 798160760u);
						continue;
					case 16u:
						arg_302_0 = ((this.targetId_ == null) ? 190933231u : 446627911u);
						continue;
					case 17u:
						this.agentIdentity_ = new Identity();
						arg_302_0 = (num2 * 904625972u ^ 3985242855u);
						continue;
					case 18u:
						arg_302_0 = (num2 * 1435642916u ^ 3318478842u);
						continue;
					case 19u:
						arg_302_0 = ((num <= 18u) ? 849371784u : 154595906u);
						continue;
					case 20u:
						input.ReadMessage(this.agentIdentity_);
						arg_302_0 = 1415627085u;
						continue;
					case 21u:
						input.ReadMessage(this.agentInfo_);
						arg_302_0 = 933532167u;
						continue;
					case 22u:
						this.params_ = new InvitationParams();
						arg_302_0 = (num2 * 157977909u ^ 2262223916u);
						continue;
					case 23u:
						input.ReadMessage(this.params_);
						arg_302_0 = 1251008820u;
						continue;
					case 24u:
						arg_302_0 = (((num != 18u) ? 1387505185u : 39668938u) ^ num2 * 2671652771u);
						continue;
					case 25u:
						input.ReadMessage(this.targetId_);
						arg_302_0 = 1415627085u;
						continue;
					case 26u:
						arg_302_0 = (((num != 10u) ? 2793474131u : 3068879583u) ^ num2 * 2360764993u);
						continue;
					case 27u:
						goto IL_392;
					case 28u:
						arg_302_0 = ((this.target_ != null) ? 2046244436u : 1437128637u);
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
