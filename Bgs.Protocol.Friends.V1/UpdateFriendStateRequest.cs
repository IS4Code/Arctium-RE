using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class UpdateFriendStateRequest : IMessage<UpdateFriendStateRequest>, IEquatable<UpdateFriendStateRequest>, IDeepCloneable<UpdateFriendStateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UpdateFriendStateRequest.__c __9 = new UpdateFriendStateRequest.__c();

			internal UpdateFriendStateRequest cctor>b__39_0()
			{
				return new UpdateFriendStateRequest();
			}
		}

		private static readonly MessageParser<UpdateFriendStateRequest> _parser = new MessageParser<UpdateFriendStateRequest>(new Func<UpdateFriendStateRequest>(UpdateFriendStateRequest.__c.__9.<.cctor>b__39_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public const int AttributeFieldNumber = 3;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(26u, Bgs.Protocol.Attribute.Parser);

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int AttributesEpochFieldNumber = 4;

		private ulong attributesEpoch_;

		public static MessageParser<UpdateFriendStateRequest> Parser
		{
			get
			{
				return UpdateFriendStateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFriendStateRequest.Descriptor;
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

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public ulong AttributesEpoch
		{
			get
			{
				return this.attributesEpoch_;
			}
			set
			{
				this.attributesEpoch_ = value;
			}
		}

		public UpdateFriendStateRequest()
		{
		}

		public UpdateFriendStateRequest(UpdateFriendStateRequest other) : this()
		{
			while (true)
			{
				IL_71:
				int arg_5B_0 = 138197937;
				while (true)
				{
					switch ((arg_5B_0 ^ 1969178045) % 3)
					{
					case 0:
						goto IL_71;
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
						this.attribute_ = other.attribute_.Clone();
						arg_5B_0 = 990959739;
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			this.attributesEpoch_ = other.attributesEpoch_;
		}

		public UpdateFriendStateRequest Clone()
		{
			return new UpdateFriendStateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFriendStateRequest);
		}

		public bool Equals(UpdateFriendStateRequest other)
		{
			if (other == null)
			{
				goto IL_9D;
			}
			goto IL_121;
			int arg_D3_0;
			while (true)
			{
				IL_CE:
				switch ((arg_D3_0 ^ -1744303010) % 13)
				{
				case 0:
					return false;
				case 1:
					arg_D3_0 = (UpdateFriendStateRequest.smethod_0(this.AgentId, other.AgentId) ? -367357248 : -1182270221);
					continue;
				case 2:
					return false;
				case 3:
					goto IL_9D;
				case 4:
					return false;
				case 5:
					goto IL_121;
				case 6:
					arg_D3_0 = ((!UpdateFriendStateRequest.smethod_0(this.TargetId, other.TargetId)) ? -1053466276 : -1931448835);
					continue;
				case 7:
					return false;
				case 8:
					arg_D3_0 = ((this.AttributesEpoch == other.AttributesEpoch) ? -2037267707 : -829539027);
					continue;
				case 9:
					return true;
				case 10:
					arg_D3_0 = (this.attribute_.Equals(other.attribute_) ? -1418002173 : -846892585);
					continue;
				case 11:
					return false;
				}
				break;
			}
			return true;
			IL_9D:
			arg_D3_0 = -1250883148;
			goto IL_CE;
			IL_121:
			arg_D3_0 = ((other != this) ? -490091127 : -459482617);
			goto IL_CE;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_4C;
			}
			goto IL_B1;
			uint arg_8D_0;
			while (true)
			{
				IL_88:
				uint num2;
				switch ((num2 = (arg_8D_0 ^ 3673112673u)) % 6u)
				{
				case 1u:
					num ^= UpdateFriendStateRequest.smethod_1(this.attribute_);
					arg_8D_0 = (((this.AttributesEpoch != 0uL) ? 3441392688u : 2304809195u) ^ num2 * 3418237658u);
					continue;
				case 2u:
					goto IL_4C;
				case 3u:
					num ^= this.AttributesEpoch.GetHashCode();
					arg_8D_0 = (num2 * 3144632720u ^ 3493593837u);
					continue;
				case 4u:
					num ^= UpdateFriendStateRequest.smethod_1(this.AgentId);
					arg_8D_0 = (num2 * 2975703401u ^ 2390940476u);
					continue;
				case 5u:
					goto IL_B1;
				}
				break;
			}
			return num;
			IL_4C:
			arg_8D_0 = 3962648551u;
			goto IL_88;
			IL_B1:
			num ^= UpdateFriendStateRequest.smethod_1(this.TargetId);
			arg_8D_0 = 3193435110u;
			goto IL_88;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_2B;
			}
			goto IL_107;
			uint arg_D6_0;
			while (true)
			{
				IL_D1:
				uint num;
				switch ((num = (arg_D6_0 ^ 2297569733u)) % 9u)
				{
				case 1u:
					output.WriteMessage(this.AgentId);
					arg_D6_0 = (num * 489847472u ^ 2009233427u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					arg_D6_0 = (num * 44108021u ^ 430178756u);
					continue;
				case 3u:
					output.WriteRawTag(32);
					arg_D6_0 = (num * 3054711198u ^ 85011882u);
					continue;
				case 4u:
					output.WriteUInt64(this.AttributesEpoch);
					arg_D6_0 = (num * 1420928030u ^ 2254976809u);
					continue;
				case 5u:
					this.attribute_.WriteTo(output, UpdateFriendStateRequest._repeated_attribute_codec);
					arg_D6_0 = (((this.AttributesEpoch == 0uL) ? 1706750650u : 1578081427u) ^ num * 940206737u);
					continue;
				case 6u:
					goto IL_2B;
				case 7u:
					goto IL_107;
				case 8u:
					output.WriteMessage(this.TargetId);
					arg_D6_0 = (num * 4174769364u ^ 2497432248u);
					continue;
				}
				break;
			}
			return;
			IL_2B:
			arg_D6_0 = 3894385544u;
			goto IL_D1;
			IL_107:
			output.WriteRawTag(18);
			arg_D6_0 = 3168805495u;
			goto IL_D1;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_EF:
				uint arg_C7_0 = 2952557868u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C7_0 ^ 2855555594u)) % 7u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.AttributesEpoch);
						arg_C7_0 = (num2 * 3277525720u ^ 2981143680u);
						continue;
					case 2u:
						arg_C7_0 = (((this.AttributesEpoch != 0uL) ? 3949298729u : 3585021286u) ^ num2 * 122314675u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_C7_0 = (num2 * 3995431770u ^ 123008760u);
						continue;
					case 4u:
						arg_C7_0 = (((this.agentId_ != null) ? 101371693u : 1707490576u) ^ num2 * 3523334303u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
						num += this.attribute_.CalculateSize(UpdateFriendStateRequest._repeated_attribute_codec);
						arg_C7_0 = 2172676064u;
						continue;
					case 6u:
						goto IL_EF;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(UpdateFriendStateRequest other)
		{
			if (other == null)
			{
				goto IL_7D;
			}
			goto IL_1BB;
			uint arg_167_0;
			while (true)
			{
				IL_162:
				uint num;
				switch ((num = (arg_167_0 ^ 4033578344u)) % 14u)
				{
				case 0u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_167_0 = 3120567902u;
					continue;
				case 1u:
					arg_167_0 = ((other.targetId_ == null) ? 3120567902u : 2937769436u);
					continue;
				case 2u:
					arg_167_0 = (((this.agentId_ == null) ? 2810436113u : 2858136429u) ^ num * 1263126810u);
					continue;
				case 3u:
					this.targetId_ = new EntityId();
					arg_167_0 = (num * 542081306u ^ 1050733782u);
					continue;
				case 4u:
					arg_167_0 = (((other.AttributesEpoch != 0uL) ? 3524541772u : 2617335865u) ^ num * 3253687053u);
					continue;
				case 5u:
					this.agentId_ = new EntityId();
					arg_167_0 = (num * 1421639247u ^ 3446453658u);
					continue;
				case 6u:
					this.attribute_.Add(other.attribute_);
					arg_167_0 = 2163636080u;
					continue;
				case 7u:
					goto IL_7D;
				case 8u:
					this.AttributesEpoch = other.AttributesEpoch;
					arg_167_0 = (num * 1390216915u ^ 2203960085u);
					continue;
				case 9u:
					goto IL_1BB;
				case 10u:
					return;
				case 11u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_167_0 = 2944760849u;
					continue;
				case 12u:
					arg_167_0 = (((this.targetId_ != null) ? 3473917956u : 3294514847u) ^ num * 2338902375u);
					continue;
				}
				break;
			}
			return;
			IL_7D:
			arg_167_0 = 3372186654u;
			goto IL_162;
			IL_1BB:
			arg_167_0 = ((other.agentId_ == null) ? 2944760849u : 3686297322u);
			goto IL_162;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_262:
				uint num;
				uint arg_1F6_0 = ((num = input.ReadTag()) != 0u) ? 3788085689u : 2409127402u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1F6_0 ^ 3693909572u)) % 20u)
					{
					case 0u:
						arg_1F6_0 = 3788085689u;
						continue;
					case 1u:
						arg_1F6_0 = ((this.targetId_ != null) ? 3332044670u : 2903467373u);
						continue;
					case 2u:
						arg_1F6_0 = (((num != 32u) ? 1389340984u : 786263566u) ^ num2 * 1735052582u);
						continue;
					case 3u:
						arg_1F6_0 = ((this.agentId_ == null) ? 3657556252u : 4248260315u);
						continue;
					case 4u:
						arg_1F6_0 = ((num == 26u) ? 2467712628u : 4036331210u);
						continue;
					case 5u:
						arg_1F6_0 = (((num != 18u) ? 3971195589u : 2805828785u) ^ num2 * 2406439664u);
						continue;
					case 6u:
						this.AttributesEpoch = input.ReadUInt64();
						arg_1F6_0 = 3764528815u;
						continue;
					case 7u:
						arg_1F6_0 = (((num != 10u) ? 179541607u : 359374357u) ^ num2 * 448373366u);
						continue;
					case 8u:
						this.agentId_ = new EntityId();
						arg_1F6_0 = (num2 * 1353132457u ^ 1270853571u);
						continue;
					case 9u:
						arg_1F6_0 = (num2 * 3350685996u ^ 3749103168u);
						continue;
					case 11u:
						arg_1F6_0 = (num2 * 772906691u ^ 2799111034u);
						continue;
					case 12u:
						input.SkipLastField();
						arg_1F6_0 = 3764528815u;
						continue;
					case 13u:
						arg_1F6_0 = ((num <= 18u) ? 3050284999u : 2947723572u);
						continue;
					case 14u:
						arg_1F6_0 = (num2 * 2166039190u ^ 1435099115u);
						continue;
					case 15u:
						input.ReadMessage(this.agentId_);
						arg_1F6_0 = 2290282947u;
						continue;
					case 16u:
						this.attribute_.AddEntriesFrom(input, UpdateFriendStateRequest._repeated_attribute_codec);
						arg_1F6_0 = 2414544098u;
						continue;
					case 17u:
						this.targetId_ = new EntityId();
						arg_1F6_0 = (num2 * 3893482996u ^ 3419871082u);
						continue;
					case 18u:
						input.ReadMessage(this.targetId_);
						arg_1F6_0 = 3764528815u;
						continue;
					case 19u:
						goto IL_262;
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
