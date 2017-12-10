using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class AddMemberRequest : IMessage<AddMemberRequest>, IEquatable<AddMemberRequest>, IDeepCloneable<AddMemberRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AddMemberRequest.__c __9 = new AddMemberRequest.__c();

			internal AddMemberRequest cctor>b__44_0()
			{
				return new AddMemberRequest();
			}
		}

		private static readonly MessageParser<AddMemberRequest> _parser = new MessageParser<AddMemberRequest>(new Func<AddMemberRequest>(AddMemberRequest.__c.__9.<.cctor>b__44_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int MemberIdentityFieldNumber = 2;

		private Identity memberIdentity_;

		public const int MemberStateFieldNumber = 3;

		private MemberState memberState_;

		public const int ObjectIdFieldNumber = 4;

		private ulong objectId_;

		public const int SubscribeFieldNumber = 5;

		private bool subscribe_;

		public static MessageParser<AddMemberRequest> Parser
		{
			get
			{
				return AddMemberRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddMemberRequest.Descriptor;
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

		public Identity MemberIdentity
		{
			get
			{
				return this.memberIdentity_;
			}
			set
			{
				this.memberIdentity_ = value;
			}
		}

		public MemberState MemberState
		{
			get
			{
				return this.memberState_;
			}
			set
			{
				this.memberState_ = value;
			}
		}

		public ulong ObjectId
		{
			get
			{
				return this.objectId_;
			}
			set
			{
				this.objectId_ = value;
			}
		}

		public bool Subscribe
		{
			get
			{
				return this.subscribe_;
			}
			set
			{
				this.subscribe_ = value;
			}
		}

		public AddMemberRequest()
		{
		}

		public AddMemberRequest(AddMemberRequest other) : this()
		{
			while (true)
			{
				IL_C2:
				uint arg_9E_0 = 4199530086u;
				while (true)
				{
					uint num;
					switch ((num = (arg_9E_0 ^ 2463711453u)) % 6u)
					{
					case 0u:
						goto IL_C2;
					case 1u:
						this.MemberIdentity = ((other.memberIdentity_ != null) ? other.MemberIdentity.Clone() : null);
						arg_9E_0 = 2999657564u;
						continue;
					case 3u:
						this.MemberState = ((other.memberState_ != null) ? other.MemberState.Clone() : null);
						this.objectId_ = other.objectId_;
						arg_9E_0 = 2964175625u;
						continue;
					case 4u:
						this.subscribe_ = other.subscribe_;
						arg_9E_0 = (num * 2500937776u ^ 3020702041u);
						continue;
					case 5u:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_9E_0 = 3303005976u;
						continue;
					}
					return;
				}
			}
		}

		public AddMemberRequest Clone()
		{
			return new AddMemberRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AddMemberRequest);
		}

		public bool Equals(AddMemberRequest other)
		{
			if (other == null)
			{
				goto IL_F0;
			}
			goto IL_150;
			int arg_FA_0;
			while (true)
			{
				IL_F5:
				switch ((arg_FA_0 ^ -1463370366) % 15)
				{
				case 0:
					goto IL_F0;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_150;
				case 5:
					arg_FA_0 = (AddMemberRequest.smethod_0(this.MemberIdentity, other.MemberIdentity) ? -1028416299 : -1817098158);
					continue;
				case 6:
					return false;
				case 7:
					arg_FA_0 = ((this.Subscribe != other.Subscribe) ? -1488586723 : -793323907);
					continue;
				case 8:
					return false;
				case 10:
					arg_FA_0 = ((this.ObjectId != other.ObjectId) ? -661804099 : -2132724780);
					continue;
				case 11:
					arg_FA_0 = ((!AddMemberRequest.smethod_0(this.AgentId, other.AgentId)) ? -1226450445 : -1354017406);
					continue;
				case 12:
					return true;
				case 13:
					arg_FA_0 = (AddMemberRequest.smethod_0(this.MemberState, other.MemberState) ? -389696256 : -1472451839);
					continue;
				case 14:
					return false;
				}
				break;
			}
			return true;
			IL_F0:
			arg_FA_0 = -80871651;
			goto IL_F5;
			IL_150:
			arg_FA_0 = ((other != this) ? -638530721 : -1246317582);
			goto IL_F5;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_CA;
			}
			goto IL_100;
			uint arg_D4_0;
			while (true)
			{
				IL_CF:
				uint num2;
				switch ((num2 = (arg_D4_0 ^ 4077004151u)) % 8u)
				{
				case 0u:
					goto IL_CA;
				case 1u:
					goto IL_100;
				case 2u:
					arg_D4_0 = ((!this.Subscribe) ? 3097673776u : 2743228468u);
					continue;
				case 3u:
					num ^= this.Subscribe.GetHashCode();
					arg_D4_0 = (num2 * 2284038362u ^ 795173694u);
					continue;
				case 4u:
					num ^= AddMemberRequest.smethod_1(this.MemberState);
					arg_D4_0 = (((this.ObjectId != 0uL) ? 774594277u : 542021297u) ^ num2 * 4216593201u);
					continue;
				case 5u:
					num ^= AddMemberRequest.smethod_1(this.AgentId);
					arg_D4_0 = (num2 * 792477970u ^ 3460712012u);
					continue;
				case 6u:
					num ^= this.ObjectId.GetHashCode();
					arg_D4_0 = (num2 * 671531449u ^ 595499571u);
					continue;
				}
				break;
			}
			return num;
			IL_CA:
			arg_D4_0 = 2432507834u;
			goto IL_CF;
			IL_100:
			num ^= AddMemberRequest.smethod_1(this.MemberIdentity);
			arg_D4_0 = 3612315915u;
			goto IL_CF;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_80;
			}
			goto IL_11C;
			uint arg_EB_0;
			while (true)
			{
				IL_E6:
				uint num;
				switch ((num = (arg_EB_0 ^ 950128983u)) % 9u)
				{
				case 0u:
					output.WriteMessage(this.MemberState);
					arg_EB_0 = (num * 2127887172u ^ 1999254983u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_EB_0 = (num * 2896687767u ^ 17973319u);
					continue;
				case 2u:
					goto IL_11C;
				case 3u:
					output.WriteRawTag(32);
					output.WriteUInt64(this.ObjectId);
					arg_EB_0 = (num * 4180436527u ^ 1172770194u);
					continue;
				case 4u:
					goto IL_80;
				case 5u:
					arg_EB_0 = ((!this.Subscribe) ? 1358532228u : 1600741311u);
					continue;
				case 7u:
					arg_EB_0 = (((this.ObjectId != 0uL) ? 2151069278u : 2301379765u) ^ num * 4134163416u);
					continue;
				case 8u:
					output.WriteRawTag(40);
					output.WriteBool(this.Subscribe);
					arg_EB_0 = (num * 2543029296u ^ 1509958916u);
					continue;
				}
				break;
			}
			return;
			IL_80:
			arg_EB_0 = 202131074u;
			goto IL_E6;
			IL_11C:
			output.WriteRawTag(18);
			output.WriteMessage(this.MemberIdentity);
			output.WriteRawTag(26);
			arg_EB_0 = 136643094u;
			goto IL_E6;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_25;
			}
			goto IL_10D;
			uint arg_DC_0;
			while (true)
			{
				IL_D7:
				uint num2;
				switch ((num2 = (arg_DC_0 ^ 3536497418u)) % 9u)
				{
				case 0u:
					arg_DC_0 = ((!this.Subscribe) ? 3767949233u : 3188609461u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_DC_0 = (num2 * 2197476750u ^ 2671605598u);
					continue;
				case 2u:
					arg_DC_0 = (((this.ObjectId == 0uL) ? 3786373400u : 3077605362u) ^ num2 * 1134939575u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
					arg_DC_0 = (num2 * 3369199893u ^ 2321647504u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberState);
					arg_DC_0 = (num2 * 551273994u ^ 695132476u);
					continue;
				case 5u:
					goto IL_10D;
				case 6u:
					goto IL_25;
				case 7u:
					num += 2;
					arg_DC_0 = (num2 * 589679588u ^ 2353631405u);
					continue;
				}
				break;
			}
			return num;
			IL_25:
			arg_DC_0 = 3441522556u;
			goto IL_D7;
			IL_10D:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberIdentity);
			arg_DC_0 = 3017059907u;
			goto IL_D7;
		}

		public void MergeFrom(AddMemberRequest other)
		{
			if (other == null)
			{
				goto IL_188;
			}
			goto IL_279;
			uint arg_211_0;
			while (true)
			{
				IL_20C:
				uint num;
				switch ((num = (arg_211_0 ^ 2052682461u)) % 19u)
				{
				case 0u:
					arg_211_0 = (((this.memberState_ == null) ? 1565603552u : 370065611u) ^ num * 2747308528u);
					continue;
				case 1u:
					this.Subscribe = other.Subscribe;
					arg_211_0 = (num * 4268931568u ^ 3029951486u);
					continue;
				case 2u:
					this.memberState_ = new MemberState();
					arg_211_0 = (num * 3219484646u ^ 1939053877u);
					continue;
				case 3u:
					arg_211_0 = ((other.ObjectId == 0uL) ? 128639170u : 758551176u);
					continue;
				case 4u:
					goto IL_188;
				case 5u:
					this.MemberState.MergeFrom(other.MemberState);
					arg_211_0 = 116563233u;
					continue;
				case 6u:
					arg_211_0 = (((this.agentId_ != null) ? 4055168835u : 3440704929u) ^ num * 2793921173u);
					continue;
				case 7u:
					return;
				case 8u:
					this.agentId_ = new EntityId();
					arg_211_0 = (num * 863328188u ^ 2991313252u);
					continue;
				case 9u:
					arg_211_0 = ((other.memberIdentity_ == null) ? 894764752u : 957869894u);
					continue;
				case 10u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_211_0 = 1376955000u;
					continue;
				case 11u:
					this.memberIdentity_ = new Identity();
					arg_211_0 = (num * 1849129419u ^ 2262866658u);
					continue;
				case 12u:
					goto IL_279;
				case 13u:
					this.MemberIdentity.MergeFrom(other.MemberIdentity);
					arg_211_0 = 894764752u;
					continue;
				case 14u:
					arg_211_0 = (((this.memberIdentity_ == null) ? 2737729289u : 2663897074u) ^ num * 404005354u);
					continue;
				case 15u:
					arg_211_0 = (other.Subscribe ? 802581312u : 2030902222u);
					continue;
				case 16u:
					this.ObjectId = other.ObjectId;
					arg_211_0 = (num * 1639626544u ^ 2528260658u);
					continue;
				case 17u:
					arg_211_0 = ((other.memberState_ == null) ? 116563233u : 2026546586u);
					continue;
				}
				break;
			}
			return;
			IL_188:
			arg_211_0 = 1307486605u;
			goto IL_20C;
			IL_279:
			arg_211_0 = ((other.agentId_ == null) ? 1376955000u : 833098826u);
			goto IL_20C;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_313:
				uint num;
				uint arg_28F_0 = ((num = input.ReadTag()) != 0u) ? 4044857384u : 3188450149u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_28F_0 ^ 3450192181u)) % 26u)
					{
					case 0u:
						this.Subscribe = input.ReadBool();
						arg_28F_0 = 3908897725u;
						continue;
					case 1u:
						arg_28F_0 = ((num <= 18u) ? 3643332990u : 2148535249u);
						continue;
					case 2u:
						arg_28F_0 = (num2 * 67528310u ^ 1014273677u);
						continue;
					case 3u:
						arg_28F_0 = 4044857384u;
						continue;
					case 4u:
						this.ObjectId = input.ReadUInt64();
						arg_28F_0 = 3908897725u;
						continue;
					case 5u:
						input.ReadMessage(this.memberIdentity_);
						arg_28F_0 = 2871858045u;
						continue;
					case 6u:
						goto IL_313;
					case 7u:
						arg_28F_0 = ((this.memberState_ != null) ? 2184772726u : 3896127464u);
						continue;
					case 8u:
						this.agentId_ = new EntityId();
						arg_28F_0 = (num2 * 2845939304u ^ 2441373573u);
						continue;
					case 9u:
						input.ReadMessage(this.memberState_);
						arg_28F_0 = 2562854363u;
						continue;
					case 10u:
						arg_28F_0 = (((num == 18u) ? 3160819718u : 2502408746u) ^ num2 * 1615286741u);
						continue;
					case 11u:
						arg_28F_0 = (((num == 40u) ? 890523941u : 234865853u) ^ num2 * 2892750678u);
						continue;
					case 12u:
						input.SkipLastField();
						arg_28F_0 = 2942753811u;
						continue;
					case 13u:
						arg_28F_0 = (num2 * 330336019u ^ 2574405672u);
						continue;
					case 14u:
						arg_28F_0 = ((num != 26u) ? 3381744572u : 4228047026u);
						continue;
					case 15u:
						arg_28F_0 = (num2 * 529335448u ^ 2154970399u);
						continue;
					case 16u:
						input.ReadMessage(this.agentId_);
						arg_28F_0 = 3313196674u;
						continue;
					case 17u:
						this.memberState_ = new MemberState();
						arg_28F_0 = (num2 * 1058249188u ^ 3080793506u);
						continue;
					case 18u:
						arg_28F_0 = ((this.agentId_ != null) ? 3232505797u : 3884079645u);
						continue;
					case 19u:
						arg_28F_0 = (((num == 10u) ? 190592725u : 405607525u) ^ num2 * 1172827208u);
						continue;
					case 20u:
						arg_28F_0 = (num2 * 446623897u ^ 597229579u);
						continue;
					case 21u:
						this.memberIdentity_ = new Identity();
						arg_28F_0 = (num2 * 1508193639u ^ 453540233u);
						continue;
					case 23u:
						arg_28F_0 = ((this.memberIdentity_ != null) ? 2454435738u : 3551619904u);
						continue;
					case 24u:
						arg_28F_0 = (num2 * 1210349602u ^ 699255841u);
						continue;
					case 25u:
						arg_28F_0 = (((num != 32u) ? 1309180414u : 1814013509u) ^ num2 * 3118835236u);
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
