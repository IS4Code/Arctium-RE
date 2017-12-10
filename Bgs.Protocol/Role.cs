using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class Role : IMessage<Role>, IEquatable<Role>, IDeepCloneable<Role>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Role.__c __9 = new Role.__c();

			internal Role cctor>b__69_0()
			{
				return new Role();
			}
		}

		private static readonly MessageParser<Role> _parser = new MessageParser<Role>(new Func<Role>(Role.__c.__9.<.cctor>b__69_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public const int NameFieldNumber = 2;

		private string name_ = "";

		public const int PrivilegeFieldNumber = 3;

		private static readonly FieldCodec<string> _repeated_privilege_codec;

		private readonly RepeatedField<string> privilege_ = new RepeatedField<string>();

		public const int AssignableRoleFieldNumber = 4;

		private static readonly FieldCodec<uint> _repeated_assignableRole_codec;

		private readonly RepeatedField<uint> assignableRole_ = new RepeatedField<uint>();

		public const int RequiredFieldNumber = 5;

		private bool required_;

		public const int UniqueFieldNumber = 6;

		private bool unique_;

		public const int RelegationRoleFieldNumber = 7;

		private uint relegationRole_;

		public const int AttributeFieldNumber = 8;

		private static readonly FieldCodec<Attribute> _repeated_attribute_codec;

		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		public const int KickableRoleFieldNumber = 9;

		private static readonly FieldCodec<uint> _repeated_kickableRole_codec;

		private readonly RepeatedField<uint> kickableRole_ = new RepeatedField<uint>();

		public const int RemovableRoleFieldNumber = 10;

		private static readonly FieldCodec<uint> _repeated_removableRole_codec;

		private readonly RepeatedField<uint> removableRole_ = new RepeatedField<uint>();

		public static MessageParser<Role> Parser
		{
			get
			{
				return Role._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RoleTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Role.Descriptor;
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

		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public RepeatedField<string> Privilege
		{
			get
			{
				return this.privilege_;
			}
		}

		public RepeatedField<uint> AssignableRole
		{
			get
			{
				return this.assignableRole_;
			}
		}

		public bool Required
		{
			get
			{
				return this.required_;
			}
			set
			{
				this.required_ = value;
			}
		}

		public bool Unique
		{
			get
			{
				return this.unique_;
			}
			set
			{
				this.unique_ = value;
			}
		}

		public uint RelegationRole
		{
			get
			{
				return this.relegationRole_;
			}
			set
			{
				this.relegationRole_ = value;
			}
		}

		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public RepeatedField<uint> KickableRole
		{
			get
			{
				return this.kickableRole_;
			}
		}

		public RepeatedField<uint> RemovableRole
		{
			get
			{
				return this.removableRole_;
			}
		}

		public Role()
		{
		}

		public Role(Role other) : this()
		{
			while (true)
			{
				IL_155:
				uint arg_120_0 = 2750803760u;
				while (true)
				{
					uint num;
					switch ((num = (arg_120_0 ^ 4276379795u)) % 10u)
					{
					case 0u:
						this.required_ = other.required_;
						arg_120_0 = (num * 3527570097u ^ 1362470637u);
						continue;
					case 1u:
						this.id_ = other.id_;
						arg_120_0 = (num * 17804372u ^ 2909655824u);
						continue;
					case 2u:
						this.unique_ = other.unique_;
						arg_120_0 = (num * 3953481028u ^ 3119153057u);
						continue;
					case 3u:
						this.name_ = other.name_;
						arg_120_0 = (num * 520231665u ^ 1894993683u);
						continue;
					case 4u:
						goto IL_155;
					case 5u:
						this.attribute_ = other.attribute_.Clone();
						arg_120_0 = (num * 1302334675u ^ 854755355u);
						continue;
					case 6u:
						this.relegationRole_ = other.relegationRole_;
						arg_120_0 = (num * 839803219u ^ 643061396u);
						continue;
					case 7u:
						this.privilege_ = other.privilege_.Clone();
						this.assignableRole_ = other.assignableRole_.Clone();
						arg_120_0 = (num * 4086130012u ^ 1078124559u);
						continue;
					case 9u:
						this.kickableRole_ = other.kickableRole_.Clone();
						this.removableRole_ = other.removableRole_.Clone();
						arg_120_0 = (num * 3855341870u ^ 3906954289u);
						continue;
					}
					return;
				}
			}
		}

		public Role Clone()
		{
			return new Role(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Role);
		}

		public bool Equals(Role other)
		{
			if (other == null)
			{
				goto IL_A3;
			}
			goto IL_25C;
			int arg_1DE_0;
			while (true)
			{
				IL_1D9:
				switch ((arg_1DE_0 ^ 1618090448) % 25)
				{
				case 0:
					return false;
				case 1:
					arg_1DE_0 = ((!this.attribute_.Equals(other.attribute_)) ? 3192222 : 1325585834);
					continue;
				case 2:
					arg_1DE_0 = ((this.Id == other.Id) ? 576223733 : 1440698807);
					continue;
				case 3:
					arg_1DE_0 = ((this.RelegationRole != other.RelegationRole) ? 2011591835 : 1215400645);
					continue;
				case 4:
					return false;
				case 5:
					arg_1DE_0 = (this.kickableRole_.Equals(other.kickableRole_) ? 58949371 : 1325288917);
					continue;
				case 6:
					arg_1DE_0 = (Role.smethod_0(this.Name, other.Name) ? 80001538 : 1408377419);
					continue;
				case 7:
					arg_1DE_0 = ((this.Required != other.Required) ? 1069724708 : 588033886);
					continue;
				case 8:
					arg_1DE_0 = ((!this.privilege_.Equals(other.privilege_)) ? 1580595351 : 930336357);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					return true;
				case 15:
					return false;
				case 16:
					goto IL_A3;
				case 17:
					arg_1DE_0 = ((this.Unique == other.Unique) ? 1094641394 : 1928165038);
					continue;
				case 18:
					return false;
				case 19:
					return false;
				case 20:
					return false;
				case 21:
					arg_1DE_0 = ((!this.removableRole_.Equals(other.removableRole_)) ? 1920535709 : 880392953);
					continue;
				case 22:
					return false;
				case 23:
					goto IL_25C;
				case 24:
					arg_1DE_0 = (this.assignableRole_.Equals(other.assignableRole_) ? 274196013 : 1069009527);
					continue;
				}
				break;
			}
			return true;
			IL_A3:
			arg_1DE_0 = 915023132;
			goto IL_1D9;
			IL_25C:
			arg_1DE_0 = ((other != this) ? 379999354 : 1171231999);
			goto IL_1D9;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_23B:
				uint arg_1EE_0 = 2282674892u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1EE_0 ^ 2437381402u)) % 16u)
					{
					case 0u:
						goto IL_23B;
					case 1u:
						num ^= this.RelegationRole.GetHashCode();
						arg_1EE_0 = (num2 * 3185657539u ^ 565387275u);
						continue;
					case 2u:
						num ^= this.attribute_.GetHashCode();
						arg_1EE_0 = 3768097232u;
						continue;
					case 3u:
						arg_1EE_0 = ((this.Name.Length == 0) ? 3088559390u : 3934013791u);
						continue;
					case 4u:
						num ^= this.privilege_.GetHashCode();
						num ^= this.assignableRole_.GetHashCode();
						arg_1EE_0 = 3878885524u;
						continue;
					case 5u:
						num ^= this.Name.GetHashCode();
						arg_1EE_0 = (num2 * 3420380964u ^ 1235671466u);
						continue;
					case 6u:
						arg_1EE_0 = (((this.Id != 0u) ? 3883093353u : 3288304293u) ^ num2 * 2246729466u);
						continue;
					case 7u:
						arg_1EE_0 = (this.Unique ? 4043175939u : 3492667303u);
						continue;
					case 9u:
						num ^= this.Unique.GetHashCode();
						arg_1EE_0 = (num2 * 2180661542u ^ 2697512209u);
						continue;
					case 10u:
						num ^= this.kickableRole_.GetHashCode();
						arg_1EE_0 = (num2 * 336037523u ^ 701110760u);
						continue;
					case 11u:
						num ^= this.Required.GetHashCode();
						arg_1EE_0 = (num2 * 2718080471u ^ 1377715232u);
						continue;
					case 12u:
						num ^= this.removableRole_.GetHashCode();
						arg_1EE_0 = (num2 * 2809808463u ^ 1897089030u);
						continue;
					case 13u:
						arg_1EE_0 = ((this.RelegationRole != 0u) ? 2507652715u : 2555766040u);
						continue;
					case 14u:
						arg_1EE_0 = ((this.Required ? 1278074949u : 1239481289u) ^ num2 * 565799934u);
						continue;
					case 15u:
						num ^= this.Id.GetHashCode();
						arg_1EE_0 = (num2 * 924074179u ^ 1211595444u);
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
			if (this.Id != 0u)
			{
				goto IL_41;
			}
			goto IL_24A;
			uint arg_1EE_0;
			while (true)
			{
				IL_1E9:
				uint num;
				switch ((num = (arg_1EE_0 ^ 2796933705u)) % 16u)
				{
				case 0u:
					output.WriteRawTag(40);
					output.WriteBool(this.Required);
					arg_1EE_0 = (num * 1610629102u ^ 2884988528u);
					continue;
				case 1u:
					goto IL_24A;
				case 2u:
					this.privilege_.WriteTo(output, Role._repeated_privilege_codec);
					arg_1EE_0 = 3907389009u;
					continue;
				case 3u:
					output.WriteString(this.Name);
					arg_1EE_0 = (num * 3135631177u ^ 3009501776u);
					continue;
				case 4u:
					this.kickableRole_.WriteTo(output, Role._repeated_kickableRole_codec);
					this.removableRole_.WriteTo(output, Role._repeated_removableRole_codec);
					arg_1EE_0 = (num * 1665994315u ^ 167614555u);
					continue;
				case 5u:
					output.WriteUInt32(this.Id);
					arg_1EE_0 = (num * 2051358770u ^ 131037106u);
					continue;
				case 6u:
					output.WriteRawTag(8);
					arg_1EE_0 = (num * 3843591733u ^ 3028864066u);
					continue;
				case 7u:
					output.WriteRawTag(18);
					arg_1EE_0 = (num * 2096581532u ^ 1075785406u);
					continue;
				case 8u:
					this.assignableRole_.WriteTo(output, Role._repeated_assignableRole_codec);
					arg_1EE_0 = (((!this.Required) ? 3826759976u : 2453196609u) ^ num * 1737881509u);
					continue;
				case 9u:
					arg_1EE_0 = ((!this.Unique) ? 2333262550u : 4167878325u);
					continue;
				case 10u:
					output.WriteRawTag(56);
					output.WriteUInt32(this.RelegationRole);
					arg_1EE_0 = (num * 2294507803u ^ 1134671916u);
					continue;
				case 11u:
					this.attribute_.WriteTo(output, Role._repeated_attribute_codec);
					arg_1EE_0 = 2940955917u;
					continue;
				case 12u:
					output.WriteRawTag(48);
					output.WriteBool(this.Unique);
					arg_1EE_0 = (num * 1576658447u ^ 129785874u);
					continue;
				case 13u:
					goto IL_41;
				case 15u:
					arg_1EE_0 = ((this.RelegationRole != 0u) ? 3340185235u : 3428166866u);
					continue;
				}
				break;
			}
			return;
			IL_41:
			arg_1EE_0 = 2732920143u;
			goto IL_1E9;
			IL_24A:
			arg_1EE_0 = ((Role.smethod_1(this.Name) == 0) ? 2805429787u : 4263428382u);
			goto IL_1E9;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1E5:
				uint arg_1A4_0 = 4069802421u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1A4_0 ^ 2523925552u)) % 13u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
						arg_1A4_0 = (num2 * 2362712871u ^ 1834182994u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.RelegationRole);
						arg_1A4_0 = (num2 * 527993018u ^ 3400085765u);
						continue;
					case 2u:
						arg_1A4_0 = ((this.RelegationRole != 0u) ? 3656474764u : 2336608669u);
						continue;
					case 4u:
						num += 2;
						arg_1A4_0 = (num2 * 3498251098u ^ 1337523647u);
						continue;
					case 5u:
						goto IL_1E5;
					case 6u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
						arg_1A4_0 = (num2 * 443805911u ^ 4279321022u);
						continue;
					case 7u:
						arg_1A4_0 = ((Role.smethod_1(this.Name) == 0) ? 4067008006u : 3000573628u);
						continue;
					case 8u:
						arg_1A4_0 = (this.Unique ? 2610717588u : 2401930670u);
						continue;
					case 9u:
						num += this.privilege_.CalculateSize(Role._repeated_privilege_codec);
						num += this.assignableRole_.CalculateSize(Role._repeated_assignableRole_codec);
						arg_1A4_0 = ((!this.Required) ? 3203432757u : 3959375305u);
						continue;
					case 10u:
						num += this.attribute_.CalculateSize(Role._repeated_attribute_codec);
						num += this.kickableRole_.CalculateSize(Role._repeated_kickableRole_codec);
						arg_1A4_0 = 2905377924u;
						continue;
					case 11u:
						arg_1A4_0 = (((this.Id != 0u) ? 4131103051u : 3915141577u) ^ num2 * 341043405u);
						continue;
					case 12u:
						num += 2;
						arg_1A4_0 = (num2 * 472924454u ^ 1998306294u);
						continue;
					}
					goto Block_6;
				}
			}
			Block_6:
			return num + this.removableRole_.CalculateSize(Role._repeated_removableRole_codec);
		}

		public void MergeFrom(Role other)
		{
			if (other == null)
			{
				goto IL_183;
			}
			goto IL_228;
			uint arg_1C8_0;
			while (true)
			{
				IL_1C3:
				uint num;
				switch ((num = (arg_1C8_0 ^ 1508787429u)) % 17u)
				{
				case 0u:
					this.assignableRole_.Add(other.assignableRole_);
					arg_1C8_0 = (num * 3832648980u ^ 846389822u);
					continue;
				case 1u:
					this.Required = other.Required;
					arg_1C8_0 = (num * 2065462373u ^ 874305834u);
					continue;
				case 2u:
					goto IL_183;
				case 3u:
					arg_1C8_0 = ((Role.smethod_1(other.Name) == 0) ? 803495441u : 1522577671u);
					continue;
				case 4u:
					this.kickableRole_.Add(other.kickableRole_);
					arg_1C8_0 = (num * 1494548506u ^ 3958707778u);
					continue;
				case 6u:
					this.Unique = other.Unique;
					arg_1C8_0 = (num * 2243563u ^ 2911238176u);
					continue;
				case 7u:
					this.privilege_.Add(other.privilege_);
					arg_1C8_0 = 2096078865u;
					continue;
				case 8u:
					return;
				case 9u:
					this.Id = other.Id;
					arg_1C8_0 = (num * 4071844074u ^ 3267950335u);
					continue;
				case 10u:
					this.Name = other.Name;
					arg_1C8_0 = (num * 883443844u ^ 843712153u);
					continue;
				case 11u:
					this.RelegationRole = other.RelegationRole;
					arg_1C8_0 = (num * 1705395640u ^ 2848565857u);
					continue;
				case 12u:
					goto IL_228;
				case 13u:
					arg_1C8_0 = ((other.RelegationRole != 0u) ? 141276922u : 1147915049u);
					continue;
				case 14u:
					arg_1C8_0 = ((other.Required ? 4126288059u : 2220704336u) ^ num * 467323619u);
					continue;
				case 15u:
					arg_1C8_0 = ((!other.Unique) ? 1198179687u : 2096463344u);
					continue;
				case 16u:
					this.attribute_.Add(other.attribute_);
					arg_1C8_0 = 1560456346u;
					continue;
				}
				break;
			}
			this.removableRole_.Add(other.removableRole_);
			return;
			IL_183:
			arg_1C8_0 = 1905897388u;
			goto IL_1C3;
			IL_228:
			arg_1C8_0 = ((other.Id == 0u) ? 1458775373u : 1779132336u);
			goto IL_1C3;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_4F1:
				uint num;
				uint arg_439_0 = ((num = input.ReadTag()) != 0u) ? 3370127047u : 2202903852u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_439_0 ^ 4204185252u)) % 39u)
					{
					case 0u:
						arg_439_0 = (num2 * 209064284u ^ 20798933u);
						continue;
					case 1u:
						arg_439_0 = (((num != 56u) ? 1533700052u : 99630514u) ^ num2 * 1253072719u);
						continue;
					case 2u:
						arg_439_0 = ((num > 40u) ? 4214644297u : 2463858076u);
						continue;
					case 3u:
						arg_439_0 = (((num == 66u) ? 3575273115u : 2798052536u) ^ num2 * 4104041714u);
						continue;
					case 4u:
						this.attribute_.AddEntriesFrom(input, Role._repeated_attribute_codec);
						arg_439_0 = 3267769041u;
						continue;
					case 5u:
						arg_439_0 = (((num != 72u) ? 2473628166u : 2715016544u) ^ num2 * 1428096712u);
						continue;
					case 6u:
						this.privilege_.AddEntriesFrom(input, Role._repeated_privilege_codec);
						arg_439_0 = 3876577291u;
						continue;
					case 7u:
						arg_439_0 = (((num <= 26u) ? 2080350122u : 36066956u) ^ num2 * 2895778110u);
						continue;
					case 8u:
						arg_439_0 = (((num == 34u) ? 4066433630u : 4109887366u) ^ num2 * 39939200u);
						continue;
					case 9u:
						arg_439_0 = (((num != 8u) ? 1713205979u : 1411563252u) ^ num2 * 107862865u);
						continue;
					case 10u:
						input.SkipLastField();
						arg_439_0 = 3876577291u;
						continue;
					case 12u:
						arg_439_0 = (num2 * 490144081u ^ 2526805984u);
						continue;
					case 13u:
						arg_439_0 = (((num != 74u) ? 683813603u : 1221476328u) ^ num2 * 3451468940u);
						continue;
					case 14u:
						arg_439_0 = (((num == 26u) ? 1321416629u : 482926387u) ^ num2 * 4253466010u);
						continue;
					case 15u:
						this.Id = input.ReadUInt32();
						arg_439_0 = 2838738183u;
						continue;
					case 16u:
						arg_439_0 = (num2 * 1240709006u ^ 2206407287u);
						continue;
					case 17u:
						goto IL_4F1;
					case 18u:
						arg_439_0 = ((num <= 74u) ? 4240978318u : 3158325000u);
						continue;
					case 19u:
						arg_439_0 = ((num <= 66u) ? 3192051328u : 3147066230u);
						continue;
					case 20u:
						arg_439_0 = (num2 * 1517658603u ^ 1832383799u);
						continue;
					case 21u:
						arg_439_0 = (((num == 40u) ? 2029882928u : 1934476663u) ^ num2 * 3353503225u);
						continue;
					case 22u:
						arg_439_0 = (num2 * 2856855776u ^ 3321360907u);
						continue;
					case 23u:
						this.Required = input.ReadBool();
						arg_439_0 = 3395208276u;
						continue;
					case 24u:
						arg_439_0 = ((num == 32u) ? 2651172190u : 4193515322u);
						continue;
					case 25u:
						this.assignableRole_.AddEntriesFrom(input, Role._repeated_assignableRole_codec);
						arg_439_0 = 3876577291u;
						continue;
					case 26u:
						arg_439_0 = (((num != 48u) ? 3667771521u : 4227812979u) ^ num2 * 158570183u);
						continue;
					case 27u:
						this.kickableRole_.AddEntriesFrom(input, Role._repeated_kickableRole_codec);
						arg_439_0 = 3876577291u;
						continue;
					case 28u:
						this.Name = input.ReadString();
						arg_439_0 = 3811406352u;
						continue;
					case 29u:
						this.Unique = input.ReadBool();
						arg_439_0 = 3876577291u;
						continue;
					case 30u:
						arg_439_0 = (((num == 18u) ? 2244045815u : 3713845180u) ^ num2 * 283092773u);
						continue;
					case 31u:
						arg_439_0 = 3370127047u;
						continue;
					case 32u:
						this.removableRole_.AddEntriesFrom(input, Role._repeated_removableRole_codec);
						arg_439_0 = 3876577291u;
						continue;
					case 33u:
						arg_439_0 = (num2 * 254731675u ^ 749394503u);
						continue;
					case 34u:
						arg_439_0 = (num2 * 2475391671u ^ 3790452622u);
						continue;
					case 35u:
						arg_439_0 = (num2 * 651313657u ^ 3720780486u);
						continue;
					case 36u:
						arg_439_0 = (((num != 82u) ? 1975548639u : 1572114559u) ^ num2 * 1507116615u);
						continue;
					case 37u:
						arg_439_0 = ((num == 80u) ? 2794112337u : 3807765702u);
						continue;
					case 38u:
						this.RelegationRole = input.ReadUInt32();
						arg_439_0 = 3876577291u;
						continue;
					}
					return;
				}
			}
		}

		static Role()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_8E:
				uint arg_72_0 = 367187079u;
				while (true)
				{
					uint num;
					switch ((num = (arg_72_0 ^ 1334128992u)) % 4u)
					{
					case 0u:
						goto IL_8E;
					case 2u:
						Role._repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(66u, Bgs.Protocol.Attribute.Parser);
						Role._repeated_kickableRole_codec = FieldCodec.ForUInt32(74u);
						arg_72_0 = (num * 4112454304u ^ 1379539457u);
						continue;
					case 3u:
						Role._repeated_privilege_codec = FieldCodec.ForString(26u);
						Role._repeated_assignableRole_codec = FieldCodec.ForUInt32(34u);
						arg_72_0 = (num * 3174530060u ^ 674672746u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			Role._repeated_removableRole_codec = FieldCodec.ForUInt32(82u);
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}
	}
}
