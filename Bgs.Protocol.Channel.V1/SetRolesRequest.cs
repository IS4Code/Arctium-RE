using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class SetRolesRequest : IMessage<SetRolesRequest>, IEquatable<SetRolesRequest>, IDeepCloneable<SetRolesRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SetRolesRequest.__c __9 = new SetRolesRequest.__c();

			internal SetRolesRequest cctor>b__34_0()
			{
				return new SetRolesRequest();
			}
		}

		private static readonly MessageParser<SetRolesRequest> _parser = new MessageParser<SetRolesRequest>(new Func<SetRolesRequest>(SetRolesRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int RoleFieldNumber = 2;

		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(18u);

		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		public const int MemberIdFieldNumber = 3;

		private static readonly FieldCodec<EntityId> _repeated_memberId_codec;

		private readonly RepeatedField<EntityId> memberId_ = new RepeatedField<EntityId>();

		public static MessageParser<SetRolesRequest> Parser
		{
			get
			{
				return SetRolesRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetRolesRequest.Descriptor;
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

		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		public RepeatedField<EntityId> MemberId
		{
			get
			{
				return this.memberId_;
			}
		}

		public SetRolesRequest()
		{
		}

		public SetRolesRequest(SetRolesRequest other) : this()
		{
			while (true)
			{
				IL_7B:
				uint arg_5F_0 = 781895752u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5F_0 ^ 877321634u)) % 4u)
					{
					case 0u:
						goto IL_7B;
					case 2u:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.role_ = other.role_.Clone();
						arg_5F_0 = 1382756633u;
						continue;
					case 3u:
						this.memberId_ = other.memberId_.Clone();
						arg_5F_0 = (num * 1834046031u ^ 3035217842u);
						continue;
					}
					return;
				}
			}
		}

		public SetRolesRequest Clone()
		{
			return new SetRolesRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SetRolesRequest);
		}

		public bool Equals(SetRolesRequest other)
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
				switch ((arg_A6_0 ^ 85955203) % 11)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					arg_A6_0 = (this.memberId_.Equals(other.memberId_) ? 1919508408 : 394562714);
					continue;
				case 3:
					goto IL_70;
				case 4:
					arg_A6_0 = ((!this.role_.Equals(other.role_)) ? 543269519 : 938799742);
					continue;
				case 5:
					return false;
				case 6:
					arg_A6_0 = ((!SetRolesRequest.smethod_0(this.AgentId, other.AgentId)) ? 1058741792 : 230303641);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_EC;
				case 9:
					return false;
				}
				break;
			}
			return true;
			IL_70:
			arg_A6_0 = 80222284;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other != this) ? 715924587 : 650029716);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_93:
				uint arg_73_0 = 1802368596u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_73_0 ^ 966552300u)) % 5u)
					{
					case 0u:
						goto IL_93;
					case 1u:
						num ^= SetRolesRequest.smethod_1(this.AgentId);
						arg_73_0 = (num2 * 1909906304u ^ 2063105828u);
						continue;
					case 3u:
						arg_73_0 = (((this.agentId_ != null) ? 303672985u : 1004195404u) ^ num2 * 2517870315u);
						continue;
					case 4u:
						num ^= SetRolesRequest.smethod_1(this.role_);
						num ^= SetRolesRequest.smethod_1(this.memberId_);
						arg_73_0 = 1432070184u;
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
			if (this.agentId_ != null)
			{
				goto IL_3C;
			}
			goto IL_66;
			uint arg_46_0;
			while (true)
			{
				IL_41:
				uint num;
				switch ((num = (arg_46_0 ^ 3495495817u)) % 5u)
				{
				case 0u:
					goto IL_3C;
				case 1u:
					output.WriteMessage(this.AgentId);
					arg_46_0 = (num * 1757427712u ^ 2783557841u);
					continue;
				case 2u:
					goto IL_66;
				case 3u:
					output.WriteRawTag(10);
					arg_46_0 = (num * 4146018325u ^ 2332849515u);
					continue;
				}
				break;
			}
			this.memberId_.WriteTo(output, SetRolesRequest._repeated_memberId_codec);
			return;
			IL_3C:
			arg_46_0 = 2316006622u;
			goto IL_41;
			IL_66:
			this.role_.WriteTo(output, SetRolesRequest._repeated_role_codec);
			arg_46_0 = 2436246591u;
			goto IL_41;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_4D;
			}
			goto IL_77;
			uint arg_57_0;
			while (true)
			{
				IL_52:
				uint num2;
				switch ((num2 = (arg_57_0 ^ 410904078u)) % 5u)
				{
				case 0u:
					goto IL_4D;
				case 1u:
					goto IL_77;
				case 2u:
					num += this.memberId_.CalculateSize(SetRolesRequest._repeated_memberId_codec);
					arg_57_0 = (num2 * 814307774u ^ 1198353049u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_57_0 = (num2 * 4200848335u ^ 1421383023u);
					continue;
				}
				break;
			}
			return num;
			IL_4D:
			arg_57_0 = 21169734u;
			goto IL_52;
			IL_77:
			num += this.role_.CalculateSize(SetRolesRequest._repeated_role_codec);
			arg_57_0 = 1176230476u;
			goto IL_52;
		}

		public void MergeFrom(SetRolesRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_E4;
			uint arg_A9_0;
			while (true)
			{
				IL_A4:
				uint num;
				switch ((num = (arg_A9_0 ^ 991983304u)) % 8u)
				{
				case 1u:
					return;
				case 2u:
					goto IL_E4;
				case 3u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_A9_0 = 1651710596u;
					continue;
				case 4u:
					this.role_.Add(other.role_);
					this.memberId_.Add(other.memberId_);
					arg_A9_0 = 941535640u;
					continue;
				case 5u:
					this.agentId_ = new EntityId();
					arg_A9_0 = (num * 597136101u ^ 513523586u);
					continue;
				case 6u:
					arg_A9_0 = (((this.agentId_ == null) ? 477747403u : 430751933u) ^ num * 1838486793u);
					continue;
				case 7u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_A9_0 = 1645392585u;
			goto IL_A4;
			IL_E4:
			arg_A9_0 = ((other.agentId_ != null) ? 1581203390u : 1651710596u);
			goto IL_A4;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_214:
				uint num;
				uint arg_1B0_0 = ((num = input.ReadTag()) == 0u) ? 3105069941u : 4137529155u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1B0_0 ^ 3830572680u)) % 18u)
					{
					case 0u:
						input.ReadMessage(this.agentId_);
						arg_1B0_0 = 2827131808u;
						continue;
					case 1u:
						arg_1B0_0 = (num2 * 700086856u ^ 1806788297u);
						continue;
					case 2u:
						arg_1B0_0 = ((num == 18u) ? 3682234304u : 3683150683u);
						continue;
					case 4u:
						arg_1B0_0 = ((this.agentId_ != null) ? 2605181488u : 4055084605u);
						continue;
					case 5u:
						goto IL_214;
					case 6u:
						input.SkipLastField();
						arg_1B0_0 = 3576906999u;
						continue;
					case 7u:
						arg_1B0_0 = (num2 * 3287791289u ^ 3862041670u);
						continue;
					case 8u:
						arg_1B0_0 = (num2 * 25342230u ^ 1543953056u);
						continue;
					case 9u:
						arg_1B0_0 = 4137529155u;
						continue;
					case 10u:
						arg_1B0_0 = (((num != 16u) ? 3177591428u : 4071339528u) ^ num2 * 3999144638u);
						continue;
					case 11u:
						this.agentId_ = new EntityId();
						arg_1B0_0 = (num2 * 2129137488u ^ 2286336416u);
						continue;
					case 12u:
						this.role_.AddEntriesFrom(input, SetRolesRequest._repeated_role_codec);
						arg_1B0_0 = 3593722089u;
						continue;
					case 13u:
						arg_1B0_0 = (((num != 10u) ? 3349281738u : 3202770274u) ^ num2 * 2115226678u);
						continue;
					case 14u:
						arg_1B0_0 = (num2 * 2640414335u ^ 2012390745u);
						continue;
					case 15u:
						arg_1B0_0 = ((num <= 16u) ? 3212594357u : 2550054518u);
						continue;
					case 16u:
						this.memberId_.AddEntriesFrom(input, SetRolesRequest._repeated_memberId_codec);
						arg_1B0_0 = 3009717121u;
						continue;
					case 17u:
						arg_1B0_0 = (((num != 26u) ? 3409277318u : 3258607788u) ^ num2 * 2958334282u);
						continue;
					}
					return;
				}
			}
		}

		static SetRolesRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_63:
				uint arg_4B_0 = 567032888u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4B_0 ^ 1701842741u)) % 3u)
					{
					case 0u:
						goto IL_63;
					case 2u:
						SetRolesRequest._repeated_memberId_codec = FieldCodec.ForMessage<EntityId>(26u, EntityId.Parser);
						arg_4B_0 = (num * 549361061u ^ 1916087246u);
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
