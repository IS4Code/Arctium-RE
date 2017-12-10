using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAccountStateRequest : IMessage<GetAccountStateRequest>, IEquatable<GetAccountStateRequest>, IDeepCloneable<GetAccountStateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAccountStateRequest.__c __9 = new GetAccountStateRequest.__c();

			internal GetAccountStateRequest cctor>b__44_0()
			{
				return new GetAccountStateRequest();
			}
		}

		private static readonly MessageParser<GetAccountStateRequest> _parser = new MessageParser<GetAccountStateRequest>(new Func<GetAccountStateRequest>(GetAccountStateRequest.__c.__9.<.cctor>b__44_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public const int ProgramFieldNumber = 2;

		private uint program_;

		public const int RegionFieldNumber = 3;

		private uint region_;

		public const int OptionsFieldNumber = 10;

		private AccountFieldOptions options_;

		public const int TagsFieldNumber = 11;

		private AccountFieldTags tags_;

		public static MessageParser<GetAccountStateRequest> Parser
		{
			get
			{
				return GetAccountStateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAccountStateRequest.Descriptor;
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

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public uint Region
		{
			get
			{
				return this.region_;
			}
			set
			{
				this.region_ = value;
			}
		}

		public AccountFieldOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		public AccountFieldTags Tags
		{
			get
			{
				return this.tags_;
			}
			set
			{
				this.tags_ = value;
			}
		}

		public GetAccountStateRequest()
		{
		}

		public GetAccountStateRequest(GetAccountStateRequest other) : this()
		{
			while (true)
			{
				IL_9B:
				uint arg_7B_0 = 3185153777u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7B_0 ^ 2189968757u)) % 5u)
					{
					case 1u:
						this.program_ = other.program_;
						this.region_ = other.region_;
						arg_7B_0 = (num * 937141220u ^ 3104874349u);
						continue;
					case 2u:
						this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
						arg_7B_0 = 4238903149u;
						continue;
					case 3u:
						this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
						arg_7B_0 = 4127048671u;
						continue;
					case 4u:
						goto IL_9B;
					}
					goto Block_3;
				}
			}
			Block_3:
			this.Tags = ((other.tags_ != null) ? other.Tags.Clone() : null);
		}

		public GetAccountStateRequest Clone()
		{
			return new GetAccountStateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAccountStateRequest);
		}

		public bool Equals(GetAccountStateRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_150;
			int arg_FA_0;
			while (true)
			{
				IL_F5:
				switch ((arg_FA_0 ^ 509820043) % 15)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					arg_FA_0 = ((this.Region != other.Region) ? 338551696 : 1840814264);
					continue;
				case 3:
					arg_FA_0 = (GetAccountStateRequest.smethod_0(this.Tags, other.Tags) ? 620917283 : 855196445);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_FA_0 = ((this.Program == other.Program) ? 2064180615 : 1388599069);
					continue;
				case 7:
					arg_FA_0 = ((!GetAccountStateRequest.smethod_0(this.EntityId, other.EntityId)) ? 1124891671 : 284328869);
					continue;
				case 8:
					return false;
				case 9:
					arg_FA_0 = (GetAccountStateRequest.smethod_0(this.Options, other.Options) ? 373789921 : 1128884145);
					continue;
				case 10:
					return false;
				case 11:
					goto IL_18;
				case 13:
					goto IL_150;
				case 14:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_FA_0 = 1955657675;
			goto IL_F5;
			IL_150:
			arg_FA_0 = ((other != this) ? 495632611 : 1679811994);
			goto IL_F5;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_19A:
				uint arg_15D_0 = 3156102275u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_15D_0 ^ 2642968452u)) % 12u)
					{
					case 0u:
						num ^= this.Tags.GetHashCode();
						arg_15D_0 = (num2 * 666505655u ^ 2209365810u);
						continue;
					case 1u:
						arg_15D_0 = ((this.tags_ != null) ? 2574844852u : 2668546402u);
						continue;
					case 3u:
						arg_15D_0 = ((this.options_ == null) ? 3054113437u : 3045327617u);
						continue;
					case 4u:
						arg_15D_0 = ((this.Program == 0u) ? 3222252234u : 4217849309u);
						continue;
					case 5u:
						num ^= this.Program.GetHashCode();
						arg_15D_0 = (num2 * 3866741232u ^ 522731194u);
						continue;
					case 6u:
						arg_15D_0 = ((this.Region != 0u) ? 4217823615u : 3268537563u);
						continue;
					case 7u:
						arg_15D_0 = (((this.entityId_ != null) ? 3447208383u : 3726963707u) ^ num2 * 2095739845u);
						continue;
					case 8u:
						num ^= GetAccountStateRequest.smethod_1(this.EntityId);
						arg_15D_0 = (num2 * 1856627800u ^ 1358511320u);
						continue;
					case 9u:
						num ^= this.Options.GetHashCode();
						arg_15D_0 = (num2 * 1827153836u ^ 1978269377u);
						continue;
					case 10u:
						goto IL_19A;
					case 11u:
						num ^= this.Region.GetHashCode();
						arg_15D_0 = (num2 * 1703066511u ^ 1295240174u);
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
			if (this.entityId_ != null)
			{
				goto IL_6F;
			}
			goto IL_1FB;
			uint arg_19F_0;
			while (true)
			{
				IL_19A:
				uint num;
				switch ((num = (arg_19F_0 ^ 4281627737u)) % 16u)
				{
				case 0u:
					output.WriteUInt32(this.Region);
					arg_19F_0 = (num * 2642522764u ^ 1824023711u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					arg_19F_0 = (num * 3383883043u ^ 1324876290u);
					continue;
				case 3u:
					arg_19F_0 = ((this.Region == 0u) ? 2694011743u : 3817244224u);
					continue;
				case 4u:
					output.WriteMessage(this.Options);
					arg_19F_0 = (num * 2615825850u ^ 2470807723u);
					continue;
				case 5u:
					output.WriteRawTag(16);
					arg_19F_0 = (num * 1675054498u ^ 2026090747u);
					continue;
				case 6u:
					arg_19F_0 = ((this.options_ != null) ? 2489185733u : 3890524355u);
					continue;
				case 7u:
					output.WriteMessage(this.Tags);
					arg_19F_0 = (num * 3144402047u ^ 2068152497u);
					continue;
				case 8u:
					output.WriteUInt32(this.Program);
					arg_19F_0 = (num * 382373836u ^ 1801887098u);
					continue;
				case 9u:
					output.WriteRawTag(24);
					arg_19F_0 = (num * 4132293460u ^ 2519615549u);
					continue;
				case 10u:
					arg_19F_0 = ((this.tags_ == null) ? 2215732760u : 2518987622u);
					continue;
				case 11u:
					goto IL_6F;
				case 12u:
					output.WriteRawTag(82);
					arg_19F_0 = (num * 2095396764u ^ 1363790989u);
					continue;
				case 13u:
					output.WriteMessage(this.EntityId);
					arg_19F_0 = (num * 3416933930u ^ 3039597733u);
					continue;
				case 14u:
					goto IL_1FB;
				case 15u:
					output.WriteRawTag(90);
					arg_19F_0 = (num * 139255573u ^ 2527948197u);
					continue;
				}
				break;
			}
			return;
			IL_6F:
			arg_19F_0 = 2909104987u;
			goto IL_19A;
			IL_1FB:
			arg_19F_0 = ((this.Program == 0u) ? 4094485146u : 3244467308u);
			goto IL_19A;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_19E:
				uint arg_161_0 = 4004087904u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_161_0 ^ 2190765423u)) % 12u)
					{
					case 0u:
						goto IL_19E;
					case 1u:
						arg_161_0 = ((this.Region == 0u) ? 2171147921u : 3343002059u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
						arg_161_0 = (num2 * 3547404523u ^ 2724681216u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
						arg_161_0 = (num2 * 212537703u ^ 2929565063u);
						continue;
					case 4u:
						arg_161_0 = ((this.tags_ == null) ? 3680740329u : 3952501584u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_161_0 = (num2 * 2477076513u ^ 1125856406u);
						continue;
					case 6u:
						arg_161_0 = ((this.options_ != null) ? 3626952018u : 3271347019u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Tags);
						arg_161_0 = (num2 * 1896001279u ^ 828023080u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
						arg_161_0 = (num2 * 3166629417u ^ 1169187029u);
						continue;
					case 9u:
						arg_161_0 = ((this.Program != 0u) ? 2857320452u : 4130471050u);
						continue;
					case 11u:
						arg_161_0 = (((this.entityId_ != null) ? 3824111820u : 3888144503u) ^ num2 * 2179830355u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetAccountStateRequest other)
		{
			if (other == null)
			{
				goto IL_145;
			}
			goto IL_27C;
			uint arg_214_0;
			while (true)
			{
				IL_20F:
				uint num;
				switch ((num = (arg_214_0 ^ 2698280669u)) % 19u)
				{
				case 0u:
					arg_214_0 = ((other.Region != 0u) ? 3307744925u : 2356790581u);
					continue;
				case 1u:
					arg_214_0 = ((other.Program == 0u) ? 2408408692u : 4190895294u);
					continue;
				case 2u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_214_0 = 2643370001u;
					continue;
				case 3u:
					arg_214_0 = (((this.entityId_ != null) ? 3301849894u : 4093426917u) ^ num * 738730037u);
					continue;
				case 4u:
					return;
				case 6u:
					this.Options.MergeFrom(other.Options);
					arg_214_0 = 3971993964u;
					continue;
				case 7u:
					arg_214_0 = ((other.tags_ == null) ? 3826406247u : 2454155488u);
					continue;
				case 8u:
					goto IL_145;
				case 9u:
					goto IL_27C;
				case 10u:
					arg_214_0 = ((other.options_ == null) ? 3971993964u : 2929902590u);
					continue;
				case 11u:
					arg_214_0 = (((this.options_ == null) ? 3131770217u : 2214929556u) ^ num * 2004984220u);
					continue;
				case 12u:
					this.Tags.MergeFrom(other.Tags);
					arg_214_0 = 3826406247u;
					continue;
				case 13u:
					this.options_ = new AccountFieldOptions();
					arg_214_0 = (num * 1833850559u ^ 3944909024u);
					continue;
				case 14u:
					this.Program = other.Program;
					arg_214_0 = (num * 3188246397u ^ 5830947u);
					continue;
				case 15u:
					this.Region = other.Region;
					arg_214_0 = (num * 3230130036u ^ 3716536373u);
					continue;
				case 16u:
					this.tags_ = new AccountFieldTags();
					arg_214_0 = (num * 1116005221u ^ 3567059782u);
					continue;
				case 17u:
					this.entityId_ = new EntityId();
					arg_214_0 = (num * 1720205715u ^ 2901513884u);
					continue;
				case 18u:
					arg_214_0 = (((this.tags_ == null) ? 3884663403u : 2396983544u) ^ num * 1761791092u);
					continue;
				}
				break;
			}
			return;
			IL_145:
			arg_214_0 = 2469690419u;
			goto IL_20F;
			IL_27C:
			arg_214_0 = ((other.entityId_ == null) ? 2643370001u : 2246807742u);
			goto IL_20F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_32C:
				uint num;
				uint arg_2A4_0 = ((num = input.ReadTag()) != 0u) ? 4145127098u : 3888646798u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_2A4_0 ^ 4235279557u)) % 27u)
					{
					case 0u:
						this.Region = input.ReadUInt32();
						arg_2A4_0 = 2713486460u;
						continue;
					case 1u:
						arg_2A4_0 = (num2 * 605509692u ^ 3769149016u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_2A4_0 = 2443815128u;
						continue;
					case 3u:
						arg_2A4_0 = (((num == 10u) ? 2224262639u : 2285948494u) ^ num2 * 3323258547u);
						continue;
					case 4u:
						this.tags_ = new AccountFieldTags();
						arg_2A4_0 = (num2 * 1839842093u ^ 3744167011u);
						continue;
					case 5u:
						arg_2A4_0 = (((num != 90u) ? 3884637873u : 4063013200u) ^ num2 * 1075468009u);
						continue;
					case 6u:
						input.ReadMessage(this.options_);
						arg_2A4_0 = 3292667974u;
						continue;
					case 7u:
						arg_2A4_0 = (num2 * 1438973025u ^ 3607771924u);
						continue;
					case 8u:
						arg_2A4_0 = (num2 * 50659220u ^ 3506683320u);
						continue;
					case 9u:
						arg_2A4_0 = (num2 * 2185841933u ^ 368108187u);
						continue;
					case 10u:
						input.ReadMessage(this.entityId_);
						arg_2A4_0 = 2448655573u;
						continue;
					case 11u:
						arg_2A4_0 = 4145127098u;
						continue;
					case 12u:
						this.Program = input.ReadUInt32();
						arg_2A4_0 = 2728552606u;
						continue;
					case 13u:
						arg_2A4_0 = (num2 * 4007243895u ^ 2968671647u);
						continue;
					case 14u:
						arg_2A4_0 = (((num == 16u) ? 3487963938u : 3880613474u) ^ num2 * 1942093258u);
						continue;
					case 15u:
						this.options_ = new AccountFieldOptions();
						arg_2A4_0 = (num2 * 132619674u ^ 1870271167u);
						continue;
					case 16u:
						this.entityId_ = new EntityId();
						arg_2A4_0 = (num2 * 129761754u ^ 222396513u);
						continue;
					case 17u:
						arg_2A4_0 = (((num != 82u) ? 3961585146u : 2257448568u) ^ num2 * 3852570557u);
						continue;
					case 18u:
						arg_2A4_0 = ((num <= 16u) ? 3352071322u : 3290024174u);
						continue;
					case 19u:
						arg_2A4_0 = (num2 * 1384166295u ^ 573759775u);
						continue;
					case 21u:
						arg_2A4_0 = ((num == 24u) ? 3658587913u : 3458827425u);
						continue;
					case 22u:
						arg_2A4_0 = ((this.entityId_ != null) ? 3109715407u : 4142335638u);
						continue;
					case 23u:
						goto IL_32C;
					case 24u:
						input.ReadMessage(this.tags_);
						arg_2A4_0 = 2969388292u;
						continue;
					case 25u:
						arg_2A4_0 = ((this.options_ == null) ? 3472492955u : 3996176947u);
						continue;
					case 26u:
						arg_2A4_0 = ((this.tags_ != null) ? 3887824200u : 3137284210u);
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
