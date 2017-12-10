using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class RecentPlayer : IMessage<RecentPlayer>, IEquatable<RecentPlayer>, IDeepCloneable<RecentPlayer>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RecentPlayer.__c __9 = new RecentPlayer.__c();

			internal RecentPlayer cctor>b__49_0()
			{
				return new RecentPlayer();
			}
		}

		private static readonly MessageParser<RecentPlayer> _parser = new MessageParser<RecentPlayer>(new Func<RecentPlayer>(RecentPlayer.__c.__9.<.cctor>b__49_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public const int ProgramFieldNumber = 2;

		private string program_ = "";

		public const int TimestampPlayedFieldNumber = 3;

		private ulong timestampPlayed_;

		public const int AttributesFieldNumber = 4;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attributes_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(34u, Bgs.Protocol.Attribute.Parser);

		private readonly RepeatedField<Bgs.Protocol.Attribute> attributes_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int IdFieldNumber = 5;

		private uint id_;

		public const int CounterFieldNumber = 6;

		private uint counter_;

		public static MessageParser<RecentPlayer> Parser
		{
			get
			{
				return RecentPlayer._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayer.Descriptor;
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

		public string Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public ulong TimestampPlayed
		{
			get
			{
				return this.timestampPlayed_;
			}
			set
			{
				this.timestampPlayed_ = value;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attributes
		{
			get
			{
				return this.attributes_;
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

		public uint Counter
		{
			get
			{
				return this.counter_;
			}
			set
			{
				this.counter_ = value;
			}
		}

		public RecentPlayer()
		{
		}

		public RecentPlayer(RecentPlayer other) : this()
		{
			this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
			this.program_ = other.program_;
			this.timestampPlayed_ = other.timestampPlayed_;
			this.attributes_ = other.attributes_.Clone();
			this.id_ = other.id_;
			this.counter_ = other.counter_;
		}

		public RecentPlayer Clone()
		{
			return new RecentPlayer(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayer);
		}

		public bool Equals(RecentPlayer other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_182;
			int arg_124_0;
			while (true)
			{
				IL_11F:
				switch ((arg_124_0 ^ 1528374495) % 17)
				{
				case 0:
					arg_124_0 = ((!this.attributes_.Equals(other.attributes_)) ? 2123096710 : 1236673159);
					continue;
				case 1:
					return false;
				case 2:
					arg_124_0 = ((this.Counter == other.Counter) ? 536516678 : 1095108825);
					continue;
				case 3:
					goto IL_182;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 8:
					arg_124_0 = ((this.TimestampPlayed != other.TimestampPlayed) ? 1289880461 : 704382841);
					continue;
				case 9:
					return false;
				case 10:
					return true;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					arg_124_0 = (RecentPlayer.smethod_0(this.EntityId, other.EntityId) ? 1611040530 : 2101626143);
					continue;
				case 14:
					goto IL_71;
				case 15:
					arg_124_0 = ((this.Id != other.Id) ? 2085063803 : 1030343108);
					continue;
				case 16:
					arg_124_0 = (RecentPlayer.smethod_1(this.Program, other.Program) ? 1729473078 : 1102240289);
					continue;
				}
				break;
			}
			return true;
			IL_71:
			arg_124_0 = 2108094579;
			goto IL_11F;
			IL_182:
			arg_124_0 = ((other == this) ? 114652429 : 918467404);
			goto IL_11F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_18B:
				uint arg_152_0 = 51874705u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_152_0 ^ 1417904044u)) % 11u)
					{
					case 0u:
						num ^= this.Id.GetHashCode();
						arg_152_0 = (num2 * 3209373693u ^ 1171646058u);
						continue;
					case 1u:
						num ^= this.TimestampPlayed.GetHashCode();
						arg_152_0 = (num2 * 2468686814u ^ 3784275685u);
						continue;
					case 2u:
						num ^= this.Counter.GetHashCode();
						arg_152_0 = (num2 * 709410214u ^ 2230761807u);
						continue;
					case 3u:
						arg_152_0 = (((RecentPlayer.smethod_3(this.Program) != 0) ? 1321284844u : 1910728777u) ^ num2 * 1385784450u);
						continue;
					case 4u:
						arg_152_0 = ((this.TimestampPlayed == 0uL) ? 1788260067u : 1669988481u);
						continue;
					case 5u:
						arg_152_0 = ((this.Counter != 0u) ? 1575946302u : 1096477667u);
						continue;
					case 6u:
						num ^= this.attributes_.GetHashCode();
						arg_152_0 = ((this.Id == 0u) ? 2128522536u : 1625188678u);
						continue;
					case 8u:
						num ^= RecentPlayer.smethod_2(this.EntityId);
						arg_152_0 = (num2 * 1293404417u ^ 2349941943u);
						continue;
					case 9u:
						goto IL_18B;
					case 10u:
						num ^= RecentPlayer.smethod_2(this.Program);
						arg_152_0 = (num2 * 2759240439u ^ 2761570449u);
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
				IL_1F6:
				uint arg_1AD_0 = 3842380095u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1AD_0 ^ 3859340503u)) % 15u)
					{
					case 0u:
						output.WriteRawTag(45);
						arg_1AD_0 = (num * 1122453479u ^ 364703633u);
						continue;
					case 1u:
						output.WriteFixed32(this.Id);
						arg_1AD_0 = (num * 2177376469u ^ 3134857059u);
						continue;
					case 2u:
						arg_1AD_0 = ((this.TimestampPlayed != 0uL) ? 3589613257u : 3232084480u);
						continue;
					case 3u:
						arg_1AD_0 = ((this.Counter == 0u) ? 2271492671u : 2915362004u);
						continue;
					case 4u:
						arg_1AD_0 = (((RecentPlayer.smethod_3(this.Program) != 0) ? 3469559251u : 3586038133u) ^ num * 2432769214u);
						continue;
					case 5u:
						output.WriteFixed32(this.Counter);
						arg_1AD_0 = (num * 2568598246u ^ 1754301711u);
						continue;
					case 6u:
						goto IL_1F6;
					case 8u:
						output.WriteRawTag(53);
						arg_1AD_0 = (num * 1777853276u ^ 1353845451u);
						continue;
					case 9u:
						output.WriteString(this.Program);
						arg_1AD_0 = (num * 3116816295u ^ 2656556352u);
						continue;
					case 10u:
						arg_1AD_0 = (((this.Id != 0u) ? 966498935u : 1078246265u) ^ num * 2213851186u);
						continue;
					case 11u:
						this.attributes_.WriteTo(output, RecentPlayer._repeated_attributes_codec);
						arg_1AD_0 = 2744478648u;
						continue;
					case 12u:
						output.WriteRawTag(18);
						arg_1AD_0 = (num * 484315659u ^ 1010363800u);
						continue;
					case 13u:
						output.WriteFixed64(this.TimestampPlayed);
						arg_1AD_0 = (num * 1504205820u ^ 1045189476u);
						continue;
					case 14u:
						output.WriteRawTag(25);
						arg_1AD_0 = (num * 2437077524u ^ 254493224u);
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
				IL_16B:
				uint arg_132_0 = 4248073214u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_132_0 ^ 2626976041u)) % 11u)
					{
					case 0u:
						num += 5;
						arg_132_0 = (num2 * 3408626564u ^ 624713925u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Program);
						arg_132_0 = (num2 * 3170625849u ^ 2913037788u);
						continue;
					case 2u:
						goto IL_16B;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
						arg_132_0 = (num2 * 2705715825u ^ 719601252u);
						continue;
					case 4u:
						arg_132_0 = ((this.TimestampPlayed != 0uL) ? 3095267635u : 2423629567u);
						continue;
					case 5u:
						arg_132_0 = ((this.Counter == 0u) ? 2777491101u : 3921411967u);
						continue;
					case 6u:
						arg_132_0 = (((RecentPlayer.smethod_3(this.Program) == 0) ? 643458575u : 1392808946u) ^ num2 * 2783636702u);
						continue;
					case 8u:
						num += 9;
						arg_132_0 = (num2 * 1277683194u ^ 526065051u);
						continue;
					case 9u:
						num += this.attributes_.CalculateSize(RecentPlayer._repeated_attributes_codec);
						arg_132_0 = ((this.Id != 0u) ? 4063614214u : 3193586484u);
						continue;
					case 10u:
						num += 5;
						arg_132_0 = (num2 * 3584757243u ^ 1929213473u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(RecentPlayer other)
		{
			if (other == null)
			{
				goto IL_129;
			}
			goto IL_206;
			uint arg_1AA_0;
			while (true)
			{
				IL_1A5:
				uint num;
				switch ((num = (arg_1AA_0 ^ 320149970u)) % 16u)
				{
				case 0u:
					this.Program = other.Program;
					arg_1AA_0 = (num * 2272838418u ^ 4056778992u);
					continue;
				case 1u:
					arg_1AA_0 = ((other.Counter == 0u) ? 249147517u : 86267967u);
					continue;
				case 2u:
					arg_1AA_0 = ((other.TimestampPlayed != 0uL) ? 325507300u : 1614261710u);
					continue;
				case 3u:
					return;
				case 4u:
					this.entityId_ = new EntityId();
					arg_1AA_0 = (num * 3075307735u ^ 1362203241u);
					continue;
				case 5u:
					goto IL_129;
				case 6u:
					this.TimestampPlayed = other.TimestampPlayed;
					arg_1AA_0 = (num * 3906875270u ^ 2580783498u);
					continue;
				case 7u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_1AA_0 = 1799671995u;
					continue;
				case 8u:
					arg_1AA_0 = (((this.entityId_ == null) ? 4241575774u : 3676291645u) ^ num * 1824707637u);
					continue;
				case 9u:
					arg_1AA_0 = ((RecentPlayer.smethod_3(other.Program) != 0) ? 1097725074u : 787867248u);
					continue;
				case 10u:
					arg_1AA_0 = (((other.Id == 0u) ? 2591935009u : 3742175371u) ^ num * 4238873773u);
					continue;
				case 11u:
					this.Id = other.Id;
					arg_1AA_0 = (num * 1176469634u ^ 3767990197u);
					continue;
				case 12u:
					this.attributes_.Add(other.attributes_);
					arg_1AA_0 = 2133685240u;
					continue;
				case 13u:
					this.Counter = other.Counter;
					arg_1AA_0 = (num * 3655671729u ^ 601028512u);
					continue;
				case 14u:
					goto IL_206;
				}
				break;
			}
			return;
			IL_129:
			arg_1AA_0 = 335902673u;
			goto IL_1A5;
			IL_206:
			arg_1AA_0 = ((other.entityId_ == null) ? 1799671995u : 1954926506u);
			goto IL_1A5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2D0:
				uint num;
				uint arg_254_0 = ((num = input.ReadTag()) != 0u) ? 1379269688u : 832680804u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_254_0 ^ 1787985161u)) % 24u)
					{
					case 0u:
						arg_254_0 = (num2 * 4134492851u ^ 1987169630u);
						continue;
					case 1u:
						this.Program = input.ReadString();
						arg_254_0 = 706861194u;
						continue;
					case 2u:
						arg_254_0 = (((num != 45u) ? 94209562u : 2101094320u) ^ num2 * 2232627248u);
						continue;
					case 3u:
						this.entityId_ = new EntityId();
						arg_254_0 = (num2 * 2992904187u ^ 3745653551u);
						continue;
					case 4u:
						this.Counter = input.ReadFixed32();
						arg_254_0 = 1358714390u;
						continue;
					case 5u:
						arg_254_0 = (num2 * 1651914266u ^ 1064099244u);
						continue;
					case 6u:
						arg_254_0 = (((num == 25u) ? 3946446213u : 3887840884u) ^ num2 * 2112067812u);
						continue;
					case 7u:
						input.ReadMessage(this.entityId_);
						arg_254_0 = 1358714390u;
						continue;
					case 8u:
						this.attributes_.AddEntriesFrom(input, RecentPlayer._repeated_attributes_codec);
						arg_254_0 = 1358714390u;
						continue;
					case 9u:
						this.Id = input.ReadFixed32();
						arg_254_0 = 1795671697u;
						continue;
					case 10u:
						arg_254_0 = ((this.entityId_ == null) ? 806203850u : 394095390u);
						continue;
					case 11u:
						arg_254_0 = (num2 * 1555171874u ^ 2509590384u);
						continue;
					case 12u:
						this.TimestampPlayed = input.ReadFixed64();
						arg_254_0 = 182088108u;
						continue;
					case 14u:
						arg_254_0 = (num2 * 1698262046u ^ 3374941922u);
						continue;
					case 15u:
						input.SkipLastField();
						arg_254_0 = 395855087u;
						continue;
					case 16u:
						arg_254_0 = ((num == 34u) ? 1611923993u : 416495643u);
						continue;
					case 17u:
						arg_254_0 = ((num > 25u) ? 853455777u : 1063608707u);
						continue;
					case 18u:
						arg_254_0 = (((num != 10u) ? 3961573507u : 3273210727u) ^ num2 * 3342328598u);
						continue;
					case 19u:
						arg_254_0 = (((num != 53u) ? 2575968661u : 3731063246u) ^ num2 * 3489808473u);
						continue;
					case 20u:
						arg_254_0 = 1379269688u;
						continue;
					case 21u:
						arg_254_0 = (num2 * 1652631990u ^ 3600301144u);
						continue;
					case 22u:
						arg_254_0 = (((num != 18u) ? 951480197u : 1123706106u) ^ num2 * 2010946351u);
						continue;
					case 23u:
						goto IL_2D0;
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
