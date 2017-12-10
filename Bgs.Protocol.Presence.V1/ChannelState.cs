using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class ChannelState : IMessage<ChannelState>, IEquatable<ChannelState>, IDeepCloneable<ChannelState>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChannelState.__c __9 = new ChannelState.__c();

			internal ChannelState cctor>b__39_0()
			{
				return new ChannelState();
			}
		}

		private static readonly MessageParser<ChannelState> _parser = new MessageParser<ChannelState>(new Func<ChannelState>(ChannelState.__c.__9.<.cctor>b__39_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public const int FieldOperationFieldNumber = 2;

		private static readonly FieldCodec<FieldOperation> _repeated_fieldOperation_codec = FieldCodec.ForMessage<FieldOperation>(18u, Bgs.Protocol.Presence.V1.FieldOperation.Parser);

		private readonly RepeatedField<FieldOperation> fieldOperation_ = new RepeatedField<FieldOperation>();

		public const int HealingFieldNumber = 3;

		private bool healing_;

		public const int PresenceFieldNumber = 101;

		private ChannelState presence_;

		public static MessageParser<ChannelState> Parser
		{
			get
			{
				return ChannelState._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelState.Descriptor;
			}
		}

		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		public RepeatedField<FieldOperation> FieldOperation
		{
			get
			{
				return this.fieldOperation_;
			}
		}

		public bool Healing
		{
			get
			{
				return this.healing_;
			}
			set
			{
				this.healing_ = value;
			}
		}

		public ChannelState Presence
		{
			get
			{
				return this.presence_;
			}
			set
			{
				this.presence_ = value;
			}
		}

		public ChannelState()
		{
		}

		public ChannelState(ChannelState other) : this()
		{
			this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
			this.fieldOperation_ = other.fieldOperation_.Clone();
			this.healing_ = other.healing_;
			this.Presence = ((other.presence_ != null) ? other.Presence.Clone() : null);
		}

		public ChannelState Clone()
		{
			return new ChannelState(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelState);
		}

		public bool Equals(ChannelState other)
		{
			if (other == null)
			{
				goto IL_C9;
			}
			goto IL_121;
			int arg_D3_0;
			while (true)
			{
				IL_CE:
				switch ((arg_D3_0 ^ -2084877239) % 13)
				{
				case 0:
					goto IL_C9;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					arg_D3_0 = ((!ChannelState.smethod_0(this.EntityId, other.EntityId)) ? -855689458 : -1699646460);
					continue;
				case 4:
					arg_D3_0 = ((!ChannelState.smethod_0(this.Presence, other.Presence)) ? -232790343 : -1607780119);
					continue;
				case 5:
					return false;
				case 6:
					arg_D3_0 = ((this.Healing != other.Healing) ? -1813452776 : -2001199808);
					continue;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					goto IL_121;
				case 11:
					return false;
				case 12:
					arg_D3_0 = ((!this.fieldOperation_.Equals(other.fieldOperation_)) ? -21362078 : -1628946934);
					continue;
				}
				break;
			}
			return true;
			IL_C9:
			arg_D3_0 = -1491084293;
			goto IL_CE;
			IL_121:
			arg_D3_0 = ((other != this) ? -1688524256 : -348717546);
			goto IL_CE;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityId_ != null)
			{
				goto IL_9D;
			}
			goto IL_DE;
			uint arg_A7_0;
			while (true)
			{
				IL_A2:
				uint num2;
				switch ((num2 = (arg_A7_0 ^ 3985266697u)) % 7u)
				{
				case 0u:
					goto IL_9D;
				case 1u:
					num ^= ChannelState.smethod_1(this.EntityId);
					arg_A7_0 = (num2 * 4293521626u ^ 3485633161u);
					continue;
				case 2u:
					goto IL_DE;
				case 3u:
					arg_A7_0 = ((this.presence_ == null) ? 3585828315u : 3933103611u);
					continue;
				case 4u:
					num ^= this.Presence.GetHashCode();
					arg_A7_0 = (num2 * 1473446294u ^ 97212439u);
					continue;
				case 5u:
					num ^= this.Healing.GetHashCode();
					arg_A7_0 = (num2 * 2983638794u ^ 2270531651u);
					continue;
				}
				break;
			}
			return num;
			IL_9D:
			arg_A7_0 = 3272757139u;
			goto IL_A2;
			IL_DE:
			num ^= ChannelState.smethod_1(this.fieldOperation_);
			arg_A7_0 = (this.Healing ? 4239717518u : 2398400005u);
			goto IL_A2;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.entityId_ != null)
			{
				goto IL_7B;
			}
			goto IL_13D;
			uint arg_104_0;
			while (true)
			{
				IL_FF:
				uint num;
				switch ((num = (arg_104_0 ^ 2010384173u)) % 11u)
				{
				case 1u:
					output.WriteRawTag(10);
					arg_104_0 = (num * 2998346218u ^ 3993676106u);
					continue;
				case 2u:
					output.WriteRawTag(24);
					arg_104_0 = (num * 477752501u ^ 1383609522u);
					continue;
				case 3u:
					output.WriteMessage(this.Presence);
					arg_104_0 = (num * 105834348u ^ 2431089940u);
					continue;
				case 4u:
					output.WriteRawTag(170, 6);
					arg_104_0 = (num * 1611077589u ^ 1365647344u);
					continue;
				case 5u:
					output.WriteMessage(this.EntityId);
					arg_104_0 = (num * 3896355006u ^ 233811782u);
					continue;
				case 6u:
					goto IL_13D;
				case 7u:
					goto IL_7B;
				case 8u:
					output.WriteBool(this.Healing);
					arg_104_0 = (num * 109296419u ^ 1675379775u);
					continue;
				case 9u:
					arg_104_0 = ((this.presence_ != null) ? 2036981913u : 419124376u);
					continue;
				case 10u:
					arg_104_0 = ((this.Healing ? 1646253164u : 14702073u) ^ num * 2864302143u);
					continue;
				}
				break;
			}
			return;
			IL_7B:
			arg_104_0 = 1401415222u;
			goto IL_FF;
			IL_13D:
			this.fieldOperation_.WriteTo(output, ChannelState._repeated_fieldOperation_codec);
			arg_104_0 = 1286856321u;
			goto IL_FF;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.entityId_ != null)
			{
				goto IL_78;
			}
			goto IL_E0;
			uint arg_B4_0;
			while (true)
			{
				IL_AF:
				uint num2;
				switch ((num2 = (arg_B4_0 ^ 2090569575u)) % 8u)
				{
				case 0u:
					num += 2 + CodedOutputStream.ComputeMessageSize(this.Presence);
					arg_B4_0 = (num2 * 3125563379u ^ 167737832u);
					continue;
				case 1u:
					num += 2;
					arg_B4_0 = (num2 * 3497260532u ^ 1063349382u);
					continue;
				case 2u:
					goto IL_E0;
				case 3u:
					goto IL_78;
				case 4u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
					arg_B4_0 = (num2 * 2723034152u ^ 2335702461u);
					continue;
				case 5u:
					arg_B4_0 = ((this.presence_ == null) ? 749193112u : 1803541687u);
					continue;
				case 6u:
					arg_B4_0 = (((!this.Healing) ? 3530570634u : 2245910990u) ^ num2 * 3145333988u);
					continue;
				}
				break;
			}
			return num;
			IL_78:
			arg_B4_0 = 1141682755u;
			goto IL_AF;
			IL_E0:
			num += this.fieldOperation_.CalculateSize(ChannelState._repeated_fieldOperation_codec);
			arg_B4_0 = 1020981529u;
			goto IL_AF;
		}

		public void MergeFrom(ChannelState other)
		{
			if (other == null)
			{
				goto IL_FF;
			}
			goto IL_1BB;
			uint arg_167_0;
			while (true)
			{
				IL_162:
				uint num;
				switch ((num = (arg_167_0 ^ 2082528366u)) % 14u)
				{
				case 0u:
					arg_167_0 = (((this.entityId_ != null) ? 222534624u : 905277163u) ^ num * 2511669426u);
					continue;
				case 2u:
					this.Healing = other.Healing;
					arg_167_0 = (num * 1764046171u ^ 2518683396u);
					continue;
				case 3u:
					this.entityId_ = new EntityId();
					arg_167_0 = (num * 2787973850u ^ 3859507634u);
					continue;
				case 4u:
					goto IL_FF;
				case 5u:
					this.fieldOperation_.Add(other.fieldOperation_);
					arg_167_0 = 822977840u;
					continue;
				case 6u:
					this.presence_ = new ChannelState();
					arg_167_0 = (num * 161848235u ^ 118436515u);
					continue;
				case 7u:
					this.Presence.MergeFrom(other.Presence);
					arg_167_0 = 597716615u;
					continue;
				case 8u:
					arg_167_0 = ((other.presence_ != null) ? 1479211045u : 597716615u);
					continue;
				case 9u:
					arg_167_0 = (((this.presence_ != null) ? 2637654772u : 3060848749u) ^ num * 488705395u);
					continue;
				case 10u:
					arg_167_0 = (((!other.Healing) ? 3552290902u : 3358796956u) ^ num * 3013785615u);
					continue;
				case 11u:
					return;
				case 12u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_167_0 = 2020350961u;
					continue;
				case 13u:
					goto IL_1BB;
				}
				break;
			}
			return;
			IL_FF:
			arg_167_0 = 1077197505u;
			goto IL_162;
			IL_1BB:
			arg_167_0 = ((other.entityId_ != null) ? 1778218454u : 2020350961u);
			goto IL_162;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_262:
				uint num;
				uint arg_1F6_0 = ((num = input.ReadTag()) == 0u) ? 4009014016u : 4100333146u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1F6_0 ^ 3620854301u)) % 20u)
					{
					case 0u:
						arg_1F6_0 = 4100333146u;
						continue;
					case 1u:
						arg_1F6_0 = (((num != 810u) ? 2466332448u : 2825767655u) ^ num2 * 3401501954u);
						continue;
					case 2u:
						arg_1F6_0 = (num2 * 1827953477u ^ 4133203479u);
						continue;
					case 3u:
						arg_1F6_0 = (((num == 18u) ? 3660508541u : 3450826377u) ^ num2 * 3951641555u);
						continue;
					case 4u:
						this.Healing = input.ReadBool();
						arg_1F6_0 = 2190275987u;
						continue;
					case 5u:
						arg_1F6_0 = (num2 * 1140447973u ^ 3138392451u);
						continue;
					case 6u:
						this.entityId_ = new EntityId();
						arg_1F6_0 = (num2 * 2375827887u ^ 1445062814u);
						continue;
					case 7u:
						this.presence_ = new ChannelState();
						arg_1F6_0 = (num2 * 608104194u ^ 521115093u);
						continue;
					case 8u:
						goto IL_262;
					case 9u:
						this.fieldOperation_.AddEntriesFrom(input, ChannelState._repeated_fieldOperation_codec);
						arg_1F6_0 = 2869355857u;
						continue;
					case 10u:
						arg_1F6_0 = (num2 * 747759675u ^ 2455317247u);
						continue;
					case 11u:
						arg_1F6_0 = (((num != 10u) ? 3357823420u : 2780891301u) ^ num2 * 2747142798u);
						continue;
					case 12u:
						arg_1F6_0 = ((num == 24u) ? 2234766445u : 2900444100u);
						continue;
					case 14u:
						input.ReadMessage(this.presence_);
						arg_1F6_0 = 2869355857u;
						continue;
					case 15u:
						arg_1F6_0 = ((num > 18u) ? 2939885913u : 3678375298u);
						continue;
					case 16u:
						arg_1F6_0 = ((this.presence_ != null) ? 3717402459u : 3751654106u);
						continue;
					case 17u:
						input.ReadMessage(this.entityId_);
						arg_1F6_0 = 3321370679u;
						continue;
					case 18u:
						arg_1F6_0 = ((this.entityId_ != null) ? 2385032892u : 2627062883u);
						continue;
					case 19u:
						input.SkipLastField();
						arg_1F6_0 = 2869355857u;
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
