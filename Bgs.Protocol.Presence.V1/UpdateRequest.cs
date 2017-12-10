using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class UpdateRequest : IMessage<UpdateRequest>, IEquatable<UpdateRequest>, IDeepCloneable<UpdateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UpdateRequest.__c __9 = new UpdateRequest.__c();

			internal UpdateRequest cctor>b__39_0()
			{
				return new UpdateRequest();
			}
		}

		private static readonly MessageParser<UpdateRequest> _parser = new MessageParser<UpdateRequest>(new Func<UpdateRequest>(UpdateRequest.__c.__9.<.cctor>b__39_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public const int FieldOperationFieldNumber = 2;

		private static readonly FieldCodec<FieldOperation> _repeated_fieldOperation_codec = FieldCodec.ForMessage<FieldOperation>(18u, Bgs.Protocol.Presence.V1.FieldOperation.Parser);

		private readonly RepeatedField<FieldOperation> fieldOperation_ = new RepeatedField<FieldOperation>();

		public const int NoCreateFieldNumber = 3;

		private bool noCreate_;

		public const int AgentIdFieldNumber = 4;

		private EntityId agentId_;

		public static MessageParser<UpdateRequest> Parser
		{
			get
			{
				return UpdateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRequest.Descriptor;
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

		public bool NoCreate
		{
			get
			{
				return this.noCreate_;
			}
			set
			{
				this.noCreate_ = value;
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

		public UpdateRequest()
		{
		}

		public UpdateRequest(UpdateRequest other) : this()
		{
			while (true)
			{
				IL_B3:
				uint arg_8F_0 = 68886724u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8F_0 ^ 1411109585u)) % 6u)
					{
					case 1u:
						this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
						arg_8F_0 = 1436985609u;
						continue;
					case 2u:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_8F_0 = 1572481917u;
						continue;
					case 3u:
						goto IL_B3;
					case 4u:
						this.fieldOperation_ = other.fieldOperation_.Clone();
						arg_8F_0 = (num * 111272954u ^ 2220325736u);
						continue;
					case 5u:
						this.noCreate_ = other.noCreate_;
						arg_8F_0 = (num * 345361720u ^ 1056357345u);
						continue;
					}
					return;
				}
			}
		}

		public UpdateRequest Clone()
		{
			return new UpdateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRequest);
		}

		public bool Equals(UpdateRequest other)
		{
			if (other == null)
			{
				goto IL_73;
			}
			goto IL_11E;
			int arg_D0_0;
			while (true)
			{
				IL_CB:
				switch ((arg_D0_0 ^ -670954170) % 13)
				{
				case 0:
					return true;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_11E;
				case 5:
					arg_D0_0 = ((this.NoCreate != other.NoCreate) ? -815282889 : -1752132457);
					continue;
				case 6:
					arg_D0_0 = (UpdateRequest.smethod_0(this.EntityId, other.EntityId) ? -1276029751 : -789257185);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_73;
				case 9:
					return false;
				case 10:
					arg_D0_0 = (UpdateRequest.smethod_0(this.AgentId, other.AgentId) ? -113296083 : -1021009607);
					continue;
				case 11:
					return false;
				case 12:
					arg_D0_0 = (this.fieldOperation_.Equals(other.fieldOperation_) ? -1000432066 : -856723187);
					continue;
				}
				break;
			}
			return true;
			IL_73:
			arg_D0_0 = -1519701449;
			goto IL_CB;
			IL_11E:
			arg_D0_0 = ((other != this) ? -626836944 : -510553822);
			goto IL_CB;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ UpdateRequest.smethod_1(this.EntityId);
			while (true)
			{
				IL_D1:
				uint arg_AD_0 = 2188839002u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AD_0 ^ 3859081690u)) % 6u)
					{
					case 0u:
						goto IL_D1;
					case 1u:
						num ^= this.AgentId.GetHashCode();
						arg_AD_0 = (num2 * 4059267623u ^ 2168376890u);
						continue;
					case 2u:
						arg_AD_0 = ((this.agentId_ == null) ? 2817497377u : 3783202359u);
						continue;
					case 4u:
						num ^= UpdateRequest.smethod_1(this.fieldOperation_);
						arg_AD_0 = (((!this.NoCreate) ? 3961869002u : 2740181031u) ^ num2 * 4002434650u);
						continue;
					case 5u:
						num ^= this.NoCreate.GetHashCode();
						arg_AD_0 = (num2 * 1945323051u ^ 3635167157u);
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
			output.WriteRawTag(10);
			output.WriteMessage(this.EntityId);
			while (true)
			{
				IL_10D:
				uint arg_E1_0 = 2564413229u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E1_0 ^ 3342241682u)) % 8u)
					{
					case 0u:
						goto IL_10D;
					case 1u:
						output.WriteBool(this.NoCreate);
						arg_E1_0 = (num * 469558632u ^ 1781729704u);
						continue;
					case 2u:
						arg_E1_0 = ((this.agentId_ != null) ? 3777398038u : 3663351647u);
						continue;
					case 3u:
						arg_E1_0 = (((!this.NoCreate) ? 1620325017u : 554540741u) ^ num * 1486469323u);
						continue;
					case 4u:
						output.WriteRawTag(34);
						output.WriteMessage(this.AgentId);
						arg_E1_0 = (num * 1019396768u ^ 6084063u);
						continue;
					case 6u:
						output.WriteRawTag(24);
						arg_E1_0 = (num * 341876400u ^ 871466651u);
						continue;
					case 7u:
						this.fieldOperation_.WriteTo(output, UpdateRequest._repeated_fieldOperation_codec);
						arg_E1_0 = (num * 2844087273u ^ 2423835886u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_CD:
				uint arg_A9_0 = 645756133u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A9_0 ^ 1250301802u)) % 6u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
						num += this.fieldOperation_.CalculateSize(UpdateRequest._repeated_fieldOperation_codec);
						arg_A9_0 = ((this.NoCreate ? 657582939u : 563999923u) ^ num2 * 3714346153u);
						continue;
					case 2u:
						num += 2;
						arg_A9_0 = (num2 * 281091113u ^ 1626666770u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_A9_0 = (num2 * 1004968020u ^ 4209709402u);
						continue;
					case 4u:
						arg_A9_0 = ((this.agentId_ == null) ? 2061933598u : 2076927015u);
						continue;
					case 5u:
						goto IL_CD;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(UpdateRequest other)
		{
			if (other == null)
			{
				goto IL_11D;
			}
			goto IL_1BE;
			uint arg_16A_0;
			while (true)
			{
				IL_165:
				uint num;
				switch ((num = (arg_16A_0 ^ 3774413321u)) % 14u)
				{
				case 0u:
					arg_16A_0 = (((!other.NoCreate) ? 937672445u : 675517359u) ^ num * 2452320819u);
					continue;
				case 1u:
					this.agentId_ = new EntityId();
					arg_16A_0 = (num * 1234601935u ^ 1003752257u);
					continue;
				case 2u:
					goto IL_11D;
				case 3u:
					this.fieldOperation_.Add(other.fieldOperation_);
					arg_16A_0 = 2974446445u;
					continue;
				case 4u:
					arg_16A_0 = ((other.agentId_ != null) ? 3520709639u : 2185809974u);
					continue;
				case 5u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_16A_0 = 3461672940u;
					continue;
				case 6u:
					arg_16A_0 = (((this.agentId_ == null) ? 3584186358u : 3931990352u) ^ num * 4017086534u);
					continue;
				case 7u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_16A_0 = 2185809974u;
					continue;
				case 8u:
					this.NoCreate = other.NoCreate;
					arg_16A_0 = (num * 2348197357u ^ 4077060499u);
					continue;
				case 10u:
					this.entityId_ = new EntityId();
					arg_16A_0 = (num * 976762498u ^ 2650255448u);
					continue;
				case 11u:
					return;
				case 12u:
					goto IL_1BE;
				case 13u:
					arg_16A_0 = (((this.entityId_ == null) ? 3699404460u : 2276358055u) ^ num * 1127517717u);
					continue;
				}
				break;
			}
			return;
			IL_11D:
			arg_16A_0 = 2542406220u;
			goto IL_165;
			IL_1BE:
			arg_16A_0 = ((other.entityId_ != null) ? 2543401998u : 3461672940u);
			goto IL_165;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_265:
				uint num;
				uint arg_1F9_0 = ((num = input.ReadTag()) == 0u) ? 2520023447u : 3444146955u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1F9_0 ^ 2736724222u)) % 20u)
					{
					case 0u:
						arg_1F9_0 = ((this.agentId_ != null) ? 3131718950u : 2244750913u);
						continue;
					case 1u:
						arg_1F9_0 = ((num <= 18u) ? 3860256704u : 2982901706u);
						continue;
					case 2u:
						arg_1F9_0 = (((num != 10u) ? 2251724623u : 3349989659u) ^ num2 * 2937945195u);
						continue;
					case 3u:
						arg_1F9_0 = ((this.entityId_ == null) ? 2335212308u : 2173777757u);
						continue;
					case 4u:
						input.ReadMessage(this.agentId_);
						arg_1F9_0 = 2608688055u;
						continue;
					case 5u:
						arg_1F9_0 = (num2 * 1037783235u ^ 2591386406u);
						continue;
					case 6u:
						this.entityId_ = new EntityId();
						arg_1F9_0 = (num2 * 2070523957u ^ 4019654703u);
						continue;
					case 7u:
						arg_1F9_0 = (((num != 18u) ? 544434455u : 767173560u) ^ num2 * 1757157496u);
						continue;
					case 8u:
						arg_1F9_0 = ((num != 24u) ? 4098886644u : 2947662168u);
						continue;
					case 10u:
						arg_1F9_0 = (((num != 34u) ? 3913012777u : 3751125430u) ^ num2 * 1904709774u);
						continue;
					case 11u:
						input.ReadMessage(this.entityId_);
						arg_1F9_0 = 2608688055u;
						continue;
					case 12u:
						arg_1F9_0 = (num2 * 1616808734u ^ 1165973799u);
						continue;
					case 13u:
						arg_1F9_0 = (num2 * 406352591u ^ 2132149044u);
						continue;
					case 14u:
						this.NoCreate = input.ReadBool();
						arg_1F9_0 = 2861642995u;
						continue;
					case 15u:
						input.SkipLastField();
						arg_1F9_0 = 3555059398u;
						continue;
					case 16u:
						arg_1F9_0 = 3444146955u;
						continue;
					case 17u:
						goto IL_265;
					case 18u:
						this.fieldOperation_.AddEntriesFrom(input, UpdateRequest._repeated_fieldOperation_codec);
						arg_1F9_0 = 2608688055u;
						continue;
					case 19u:
						this.agentId_ = new EntityId();
						arg_1F9_0 = (num2 * 628593577u ^ 1292758065u);
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
