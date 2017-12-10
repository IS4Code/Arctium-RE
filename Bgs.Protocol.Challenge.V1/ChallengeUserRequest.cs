using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengeUserRequest : IMessage<ChallengeUserRequest>, IEquatable<ChallengeUserRequest>, IDeepCloneable<ChallengeUserRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengeUserRequest.__c __9 = new ChallengeUserRequest.__c();

			internal ChallengeUserRequest cctor>b__49_0()
			{
				return new ChallengeUserRequest();
			}
		}

		private static readonly MessageParser<ChallengeUserRequest> _parser = new MessageParser<ChallengeUserRequest>(new Func<ChallengeUserRequest>(ChallengeUserRequest.__c.__9.<.cctor>b__49_0));

		public const int ChallengesFieldNumber = 1;

		private static readonly FieldCodec<Challenge> _repeated_challenges_codec;

		private readonly RepeatedField<Challenge> challenges_ = new RepeatedField<Challenge>();

		public const int ContextFieldNumber = 2;

		private uint context_;

		public const int IdFieldNumber = 3;

		private uint id_;

		public const int DeadlineFieldNumber = 4;

		private ulong deadline_;

		public const int AttributesFieldNumber = 5;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attributes_codec;

		private readonly RepeatedField<Bgs.Protocol.Attribute> attributes_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int GameAccountIdFieldNumber = 6;

		private EntityId gameAccountId_;

		public static MessageParser<ChallengeUserRequest> Parser
		{
			get
			{
				return ChallengeUserRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeUserRequest.Descriptor;
			}
		}

		public RepeatedField<Challenge> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		public uint Context
		{
			get
			{
				return this.context_;
			}
			set
			{
				this.context_ = value;
			}
		}

		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		public ulong Deadline
		{
			get
			{
				return this.deadline_;
			}
			set
			{
				this.deadline_ = value;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		public ChallengeUserRequest()
		{
		}

		public ChallengeUserRequest(ChallengeUserRequest other) : this()
		{
			while (true)
			{
				IL_DE:
				uint arg_B6_0 = 229254168u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B6_0 ^ 1271269179u)) % 7u)
					{
					case 0u:
						this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
						arg_B6_0 = 947561244u;
						continue;
					case 1u:
						this.id_ = other.id_;
						this.deadline_ = other.deadline_;
						arg_B6_0 = (num * 3991094323u ^ 630526029u);
						continue;
					case 2u:
						this.attributes_ = other.attributes_.Clone();
						arg_B6_0 = (num * 2358047220u ^ 2818621137u);
						continue;
					case 4u:
						goto IL_DE;
					case 5u:
						this.context_ = other.context_;
						arg_B6_0 = (num * 4146722923u ^ 2660060192u);
						continue;
					case 6u:
						this.challenges_ = other.challenges_.Clone();
						arg_B6_0 = (num * 3971548888u ^ 2645110455u);
						continue;
					}
					return;
				}
			}
		}

		public ChallengeUserRequest Clone()
		{
			return new ChallengeUserRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeUserRequest);
		}

		public bool Equals(ChallengeUserRequest other)
		{
			if (other == null)
			{
				goto IL_11D;
			}
			goto IL_185;
			int arg_127_0;
			while (true)
			{
				IL_122:
				switch ((arg_127_0 ^ 858837617) % 17)
				{
				case 0:
					goto IL_11D;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_127_0 = ((!ChallengeUserRequest.smethod_0(this.GameAccountId, other.GameAccountId)) ? 1224345360 : 1422345378);
					continue;
				case 5:
					arg_127_0 = ((this.Context != other.Context) ? 262287171 : 1291426536);
					continue;
				case 6:
					return false;
				case 7:
					arg_127_0 = ((!this.challenges_.Equals(other.challenges_)) ? 1751376430 : 682624620);
					continue;
				case 8:
					arg_127_0 = ((this.Deadline != other.Deadline) ? 1790901358 : 120535380);
					continue;
				case 9:
					arg_127_0 = ((this.Id != other.Id) ? 82072354 : 1804740707);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					goto IL_185;
				case 13:
					return true;
				case 15:
					arg_127_0 = (this.attributes_.Equals(other.attributes_) ? 1908038076 : 39378118);
					continue;
				case 16:
					return false;
				}
				break;
			}
			return true;
			IL_11D:
			arg_127_0 = 2009102167;
			goto IL_122;
			IL_185:
			arg_127_0 = ((other == this) ? 1357807438 : 1114146993);
			goto IL_122;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_15E:
				uint arg_129_0 = 953549573u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_129_0 ^ 81860428u)) % 10u)
					{
					case 1u:
						num ^= this.attributes_.GetHashCode();
						arg_129_0 = ((this.gameAccountId_ == null) ? 668879852u : 1736171649u);
						continue;
					case 2u:
						arg_129_0 = ((this.Deadline != 0uL) ? 1079037797u : 475941467u);
						continue;
					case 3u:
						num ^= ChallengeUserRequest.smethod_1(this.challenges_);
						arg_129_0 = (num2 * 2699092310u ^ 162514878u);
						continue;
					case 4u:
						num ^= this.Id.GetHashCode();
						arg_129_0 = (num2 * 717187007u ^ 3088793976u);
						continue;
					case 5u:
						num ^= this.GameAccountId.GetHashCode();
						arg_129_0 = (num2 * 392259091u ^ 1429690843u);
						continue;
					case 6u:
						arg_129_0 = (((this.Id == 0u) ? 3777737210u : 3987378098u) ^ num2 * 4231024633u);
						continue;
					case 7u:
						num ^= this.Deadline.GetHashCode();
						arg_129_0 = (num2 * 1582248228u ^ 1784116383u);
						continue;
					case 8u:
						num ^= this.Context.GetHashCode();
						arg_129_0 = (num2 * 2767103040u ^ 3562014408u);
						continue;
					case 9u:
						goto IL_15E;
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
			this.challenges_.WriteTo(output, ChallengeUserRequest._repeated_challenges_codec);
			output.WriteRawTag(21);
			while (true)
			{
				IL_19A:
				uint arg_15D_0 = 522842017u;
				while (true)
				{
					uint num;
					switch ((num = (arg_15D_0 ^ 1805320541u)) % 12u)
					{
					case 1u:
						output.WriteRawTag(50);
						output.WriteMessage(this.GameAccountId);
						arg_15D_0 = (num * 3018143777u ^ 3275503568u);
						continue;
					case 2u:
						arg_15D_0 = (((this.gameAccountId_ != null) ? 2170439992u : 4024776149u) ^ num * 1309831780u);
						continue;
					case 3u:
						output.WriteRawTag(32);
						arg_15D_0 = (num * 1726065625u ^ 1949175078u);
						continue;
					case 4u:
						output.WriteFixed32(this.Context);
						arg_15D_0 = (num * 412516272u ^ 2754815154u);
						continue;
					case 5u:
						output.WriteRawTag(24);
						arg_15D_0 = (num * 1951865049u ^ 669293214u);
						continue;
					case 6u:
						this.attributes_.WriteTo(output, ChallengeUserRequest._repeated_attributes_codec);
						arg_15D_0 = 324668495u;
						continue;
					case 7u:
						goto IL_19A;
					case 8u:
						output.WriteUInt64(this.Deadline);
						arg_15D_0 = (num * 1938654658u ^ 2471973843u);
						continue;
					case 9u:
						arg_15D_0 = ((this.Deadline == 0uL) ? 1594144195u : 49949302u);
						continue;
					case 10u:
						output.WriteUInt32(this.Id);
						arg_15D_0 = (num * 4243226738u ^ 3135843180u);
						continue;
					case 11u:
						arg_15D_0 = (((this.Id == 0u) ? 2765761576u : 3654472296u) ^ num * 4252842808u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + this.challenges_.CalculateSize(ChallengeUserRequest._repeated_challenges_codec);
			while (true)
			{
				IL_145:
				uint arg_114_0 = 3162608546u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_114_0 ^ 2701028312u)) % 9u)
					{
					case 0u:
						goto IL_145;
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Deadline);
						arg_114_0 = (num2 * 2530084115u ^ 1565093126u);
						continue;
					case 2u:
						num += this.attributes_.CalculateSize(ChallengeUserRequest._repeated_attributes_codec);
						arg_114_0 = 2458664968u;
						continue;
					case 4u:
						arg_114_0 = (((this.gameAccountId_ != null) ? 44364881u : 266060663u) ^ num2 * 3643872155u);
						continue;
					case 5u:
						arg_114_0 = ((this.Deadline == 0uL) ? 2532657924u : 3112007662u);
						continue;
					case 6u:
						num += 5;
						arg_114_0 = (((this.Id != 0u) ? 3602439411u : 2569309920u) ^ num2 * 1496811588u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
						arg_114_0 = (num2 * 2894325080u ^ 3152752768u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_114_0 = (num2 * 3522744847u ^ 957498768u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ChallengeUserRequest other)
		{
			if (other == null)
			{
				goto IL_57;
			}
			goto IL_1B7;
			uint arg_163_0;
			while (true)
			{
				IL_15E:
				uint num;
				switch ((num = (arg_163_0 ^ 1203381116u)) % 14u)
				{
				case 0u:
					this.Deadline = other.Deadline;
					arg_163_0 = (num * 3962570585u ^ 3321897997u);
					continue;
				case 1u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_163_0 = 1521961964u;
					continue;
				case 2u:
					this.Context = other.Context;
					arg_163_0 = (num * 303712998u ^ 4039849318u);
					continue;
				case 3u:
					arg_163_0 = (((this.gameAccountId_ != null) ? 2888578746u : 2623220786u) ^ num * 75474941u);
					continue;
				case 4u:
					this.Id = other.Id;
					arg_163_0 = (num * 2923783211u ^ 1751893247u);
					continue;
				case 5u:
					arg_163_0 = ((other.Deadline != 0uL) ? 1435431782u : 82651911u);
					continue;
				case 7u:
					goto IL_1B7;
				case 8u:
					arg_163_0 = (((other.gameAccountId_ != null) ? 555258729u : 1267324812u) ^ num * 2129435312u);
					continue;
				case 9u:
					this.gameAccountId_ = new EntityId();
					arg_163_0 = (num * 1654886745u ^ 399573772u);
					continue;
				case 10u:
					goto IL_57;
				case 11u:
					this.attributes_.Add(other.attributes_);
					arg_163_0 = 381997102u;
					continue;
				case 12u:
					arg_163_0 = ((other.Id != 0u) ? 695376134u : 1528512129u);
					continue;
				case 13u:
					return;
				}
				break;
			}
			return;
			IL_57:
			arg_163_0 = 735999595u;
			goto IL_15E;
			IL_1B7:
			this.challenges_.Add(other.challenges_);
			arg_163_0 = ((other.Context == 0u) ? 480948778u : 271406910u);
			goto IL_15E;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2AC:
				uint num;
				uint arg_238_0 = ((num = input.ReadTag()) != 0u) ? 1861797852u : 328693633u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_238_0 ^ 1661044335u)) % 22u)
					{
					case 1u:
						arg_238_0 = (num2 * 3851548275u ^ 2692400307u);
						continue;
					case 2u:
						arg_238_0 = (((num == 24u) ? 3544563086u : 3005075516u) ^ num2 * 1354580321u);
						continue;
					case 3u:
						arg_238_0 = ((num != 32u) ? 1967276945u : 1429323329u);
						continue;
					case 4u:
						this.gameAccountId_ = new EntityId();
						arg_238_0 = (num2 * 477622374u ^ 761234845u);
						continue;
					case 5u:
						this.attributes_.AddEntriesFrom(input, ChallengeUserRequest._repeated_attributes_codec);
						arg_238_0 = 341371847u;
						continue;
					case 6u:
						arg_238_0 = (((num != 50u) ? 2243287798u : 3552492846u) ^ num2 * 4073867439u);
						continue;
					case 7u:
						arg_238_0 = ((num <= 24u) ? 1781526746u : 999529946u);
						continue;
					case 8u:
						arg_238_0 = (((num == 21u) ? 1489078201u : 1832520429u) ^ num2 * 1104463356u);
						continue;
					case 9u:
						arg_238_0 = 1861797852u;
						continue;
					case 10u:
						goto IL_2AC;
					case 11u:
						input.SkipLastField();
						arg_238_0 = 448398246u;
						continue;
					case 12u:
						input.ReadMessage(this.gameAccountId_);
						arg_238_0 = 341371847u;
						continue;
					case 13u:
						this.Id = input.ReadUInt32();
						arg_238_0 = 1092294630u;
						continue;
					case 14u:
						this.Deadline = input.ReadUInt64();
						arg_238_0 = 341371847u;
						continue;
					case 15u:
						arg_238_0 = (((num == 10u) ? 945742589u : 858495243u) ^ num2 * 1388290096u);
						continue;
					case 16u:
						this.Context = input.ReadFixed32();
						arg_238_0 = 341371847u;
						continue;
					case 17u:
						arg_238_0 = (num2 * 753172457u ^ 2455212342u);
						continue;
					case 18u:
						arg_238_0 = (((num == 42u) ? 3705632798u : 2436743137u) ^ num2 * 715210206u);
						continue;
					case 19u:
						arg_238_0 = (num2 * 1888686479u ^ 1182043968u);
						continue;
					case 20u:
						this.challenges_.AddEntriesFrom(input, ChallengeUserRequest._repeated_challenges_codec);
						arg_238_0 = 341371847u;
						continue;
					case 21u:
						arg_238_0 = ((this.gameAccountId_ != null) ? 1865161785u : 1391555465u);
						continue;
					}
					return;
				}
			}
		}

		static ChallengeUserRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 2163374874u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 3006805296u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 1u:
						ChallengeUserRequest._repeated_challenges_codec = FieldCodec.ForMessage<Challenge>(10u, Challenge.Parser);
						arg_3F_0 = (num * 2237696814u ^ 2743889092u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			ChallengeUserRequest._repeated_attributes_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(42u, Bgs.Protocol.Attribute.Parser);
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
