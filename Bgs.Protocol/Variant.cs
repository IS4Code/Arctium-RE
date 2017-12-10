using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class Variant : IMessage<Variant>, IEquatable<Variant>, IDeepCloneable<Variant>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Variant.__c __9 = new Variant.__c();

			internal Variant cctor>b__64_0()
			{
				return new Variant();
			}
		}

		private static readonly MessageParser<Variant> _parser = new MessageParser<Variant>(new Func<Variant>(Variant.__c.__9.<.cctor>b__64_0));

		public const int BoolValueFieldNumber = 2;

		private bool boolValue_;

		public const int IntValueFieldNumber = 3;

		private long intValue_;

		public const int FloatValueFieldNumber = 4;

		private double floatValue_;

		public const int StringValueFieldNumber = 5;

		private string stringValue_ = "";

		public const int BlobValueFieldNumber = 6;

		private ByteString blobValue_ = ByteString.Empty;

		public const int MessageValueFieldNumber = 7;

		private ByteString messageValue_ = ByteString.Empty;

		public const int FourccValueFieldNumber = 8;

		private string fourccValue_ = "";

		public const int UintValueFieldNumber = 9;

		private ulong uintValue_;

		public const int EntityIdValueFieldNumber = 10;

		private EntityId entityIdValue_;

		public static MessageParser<Variant> Parser
		{
			get
			{
				return Variant._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Variant.Descriptor;
			}
		}

		public bool BoolValue
		{
			get
			{
				return this.boolValue_;
			}
			set
			{
				this.boolValue_ = value;
			}
		}

		public long IntValue
		{
			get
			{
				return this.intValue_;
			}
			set
			{
				this.intValue_ = value;
			}
		}

		public double FloatValue
		{
			get
			{
				return this.floatValue_;
			}
			set
			{
				this.floatValue_ = value;
			}
		}

		public string StringValue
		{
			get
			{
				return this.stringValue_;
			}
			set
			{
				this.stringValue_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public ByteString BlobValue
		{
			get
			{
				return this.blobValue_;
			}
			set
			{
				this.blobValue_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public ByteString MessageValue
		{
			get
			{
				return this.messageValue_;
			}
			set
			{
				this.messageValue_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public string FourccValue
		{
			get
			{
				return this.fourccValue_;
			}
			set
			{
				this.fourccValue_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public ulong UintValue
		{
			get
			{
				return this.uintValue_;
			}
			set
			{
				this.uintValue_ = value;
			}
		}

		public EntityId EntityIdValue
		{
			get
			{
				return this.entityIdValue_;
			}
			set
			{
				this.entityIdValue_ = value;
			}
		}

		public Variant()
		{
		}

		public Variant(Variant other) : this()
		{
			while (true)
			{
				IL_FB:
				uint arg_D3_0 = 3227849183u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D3_0 ^ 3962983158u)) % 7u)
					{
					case 0u:
						this.fourccValue_ = other.fourccValue_;
						this.uintValue_ = other.uintValue_;
						this.EntityIdValue = ((other.entityIdValue_ != null) ? other.EntityIdValue.Clone() : null);
						arg_D3_0 = 3023060101u;
						continue;
					case 1u:
						this.boolValue_ = other.boolValue_;
						arg_D3_0 = (num * 2646842623u ^ 3843969777u);
						continue;
					case 2u:
						this.intValue_ = other.intValue_;
						this.floatValue_ = other.floatValue_;
						this.stringValue_ = other.stringValue_;
						arg_D3_0 = (num * 943808406u ^ 253914440u);
						continue;
					case 3u:
						goto IL_FB;
					case 5u:
						this.blobValue_ = other.blobValue_;
						arg_D3_0 = (num * 1862349328u ^ 3970802121u);
						continue;
					case 6u:
						this.messageValue_ = other.messageValue_;
						arg_D3_0 = (num * 1661979544u ^ 762448033u);
						continue;
					}
					return;
				}
			}
		}

		public Variant Clone()
		{
			return new Variant(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Variant);
		}

		public bool Equals(Variant other)
		{
			if (other == null)
			{
				goto IL_42;
			}
			goto IL_222;
			int arg_1AC_0;
			while (true)
			{
				IL_1A7:
				switch ((arg_1AC_0 ^ -54105850) % 23)
				{
				case 0:
					arg_1AC_0 = ((!Variant.smethod_1(this.EntityIdValue, other.EntityIdValue)) ? -2108927586 : -1242989308);
					continue;
				case 1:
					arg_1AC_0 = ((this.FloatValue != other.FloatValue) ? -342473545 : -235243041);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_1AC_0 = ((!(this.BlobValue != other.BlobValue)) ? -240746287 : -151669868);
					continue;
				case 5:
					return false;
				case 6:
					arg_1AC_0 = (Variant.smethod_0(this.StringValue, other.StringValue) ? -1619171625 : -627620797);
					continue;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					arg_1AC_0 = ((!Variant.smethod_0(this.FourccValue, other.FourccValue)) ? -1775614774 : -769541536);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					arg_1AC_0 = ((this.UintValue != other.UintValue) ? -744800500 : -2025069504);
					continue;
				case 13:
					arg_1AC_0 = ((this.MessageValue != other.MessageValue) ? -1939683886 : -431997904);
					continue;
				case 14:
					arg_1AC_0 = ((this.IntValue != other.IntValue) ? -1175567608 : -1228880735);
					continue;
				case 15:
					goto IL_222;
				case 16:
					goto IL_42;
				case 17:
					return false;
				case 19:
					return false;
				case 20:
					return false;
				case 21:
					arg_1AC_0 = ((this.BoolValue == other.BoolValue) ? -1755885413 : -376013397);
					continue;
				case 22:
					return true;
				}
				break;
			}
			return true;
			IL_42:
			arg_1AC_0 = -1020310148;
			goto IL_1A7;
			IL_222:
			arg_1AC_0 = ((other == this) ? -842461942 : -1398813259);
			goto IL_1A7;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_2FC:
				uint arg_29E_0 = 3830850681u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_29E_0 ^ 2843628116u)) % 20u)
					{
					case 0u:
						num ^= this.FourccValue.GetHashCode();
						arg_29E_0 = (num2 * 3509291386u ^ 1190225146u);
						continue;
					case 1u:
						num ^= this.EntityIdValue.GetHashCode();
						arg_29E_0 = (num2 * 3874677155u ^ 4027017292u);
						continue;
					case 2u:
						num ^= this.UintValue.GetHashCode();
						arg_29E_0 = (num2 * 3794677293u ^ 3696394442u);
						continue;
					case 3u:
						arg_29E_0 = ((this.FloatValue == 0.0) ? 3313619750u : 3047535191u);
						continue;
					case 4u:
						arg_29E_0 = ((this.BlobValue.Length == 0) ? 4257470714u : 3785344600u);
						continue;
					case 5u:
						arg_29E_0 = ((this.BoolValue ? 2021413208u : 1300337610u) ^ num2 * 4235765709u);
						continue;
					case 6u:
						arg_29E_0 = ((this.StringValue.Length != 0) ? 2177898065u : 4070020044u);
						continue;
					case 8u:
						arg_29E_0 = ((this.entityIdValue_ == null) ? 3086193943u : 2841883325u);
						continue;
					case 9u:
						num ^= this.BoolValue.GetHashCode();
						arg_29E_0 = (num2 * 247983131u ^ 4127393860u);
						continue;
					case 10u:
						arg_29E_0 = ((this.MessageValue.Length != 0) ? 3740787728u : 2781542737u);
						continue;
					case 11u:
						arg_29E_0 = ((this.IntValue != 0L) ? 2661949127u : 3923706111u);
						continue;
					case 12u:
						num ^= this.BlobValue.GetHashCode();
						arg_29E_0 = (num2 * 3434930952u ^ 1809882266u);
						continue;
					case 13u:
						arg_29E_0 = ((this.FourccValue.Length != 0) ? 3908764248u : 2308175170u);
						continue;
					case 14u:
						goto IL_2FC;
					case 15u:
						num ^= this.IntValue.GetHashCode();
						arg_29E_0 = (num2 * 1851247311u ^ 819324962u);
						continue;
					case 16u:
						num ^= this.MessageValue.GetHashCode();
						arg_29E_0 = (num2 * 1679181158u ^ 1562118729u);
						continue;
					case 17u:
						num ^= this.StringValue.GetHashCode();
						arg_29E_0 = (num2 * 1097834624u ^ 4131893580u);
						continue;
					case 18u:
						arg_29E_0 = ((this.UintValue == 0uL) ? 2580545964u : 2981166826u);
						continue;
					case 19u:
						num ^= this.FloatValue.GetHashCode();
						arg_29E_0 = (num2 * 3924349100u ^ 49619234u);
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
			if (this.BoolValue)
			{
				goto IL_B2;
			}
			goto IL_33A;
			uint arg_2C6_0;
			while (true)
			{
				IL_2C1:
				uint num;
				switch ((num = (arg_2C6_0 ^ 1263290485u)) % 22u)
				{
				case 0u:
					output.WriteRawTag(82);
					output.WriteMessage(this.EntityIdValue);
					arg_2C6_0 = (num * 4135731666u ^ 669519993u);
					continue;
				case 1u:
					output.WriteRawTag(72);
					output.WriteUInt64(this.UintValue);
					arg_2C6_0 = (num * 3349898673u ^ 1016667616u);
					continue;
				case 2u:
					goto IL_33A;
				case 3u:
					arg_2C6_0 = ((this.MessageValue.Length == 0) ? 1422403104u : 631689657u);
					continue;
				case 4u:
					output.WriteRawTag(50);
					output.WriteBytes(this.BlobValue);
					arg_2C6_0 = (num * 3727053964u ^ 1967605776u);
					continue;
				case 5u:
					output.WriteInt64(this.IntValue);
					arg_2C6_0 = (num * 2511567238u ^ 3907557089u);
					continue;
				case 7u:
					output.WriteRawTag(24);
					arg_2C6_0 = (num * 33209801u ^ 50529819u);
					continue;
				case 8u:
					output.WriteRawTag(58);
					output.WriteBytes(this.MessageValue);
					arg_2C6_0 = (num * 609988493u ^ 2232749948u);
					continue;
				case 9u:
					arg_2C6_0 = ((Variant.smethod_2(this.FourccValue) != 0) ? 682229857u : 1441095832u);
					continue;
				case 10u:
					arg_2C6_0 = ((this.FloatValue != 0.0) ? 239783823u : 70114482u);
					continue;
				case 11u:
					output.WriteRawTag(42);
					arg_2C6_0 = (num * 323275730u ^ 3287013917u);
					continue;
				case 12u:
					arg_2C6_0 = ((this.entityIdValue_ == null) ? 974269981u : 1603984919u);
					continue;
				case 13u:
					output.WriteRawTag(16);
					output.WriteBool(this.BoolValue);
					arg_2C6_0 = (num * 2115509340u ^ 772468775u);
					continue;
				case 14u:
					output.WriteString(this.StringValue);
					arg_2C6_0 = (num * 3228202067u ^ 2785110500u);
					continue;
				case 15u:
					arg_2C6_0 = ((this.UintValue == 0uL) ? 1978653815u : 1396575666u);
					continue;
				case 16u:
					output.WriteDouble(this.FloatValue);
					arg_2C6_0 = (num * 287558033u ^ 993837710u);
					continue;
				case 17u:
					goto IL_B2;
				case 18u:
					output.WriteRawTag(66);
					output.WriteString(this.FourccValue);
					arg_2C6_0 = (num * 3555944853u ^ 712066876u);
					continue;
				case 19u:
					arg_2C6_0 = ((Variant.smethod_2(this.StringValue) == 0) ? 722227322u : 1956424716u);
					continue;
				case 20u:
					output.WriteRawTag(33);
					arg_2C6_0 = (num * 4252776055u ^ 90572095u);
					continue;
				case 21u:
					arg_2C6_0 = ((this.BlobValue.Length != 0) ? 1074231769u : 364171776u);
					continue;
				}
				break;
			}
			return;
			IL_B2:
			arg_2C6_0 = 691226022u;
			goto IL_2C1;
			IL_33A:
			arg_2C6_0 = ((this.IntValue != 0L) ? 944367248u : 336723635u);
			goto IL_2C1;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.BoolValue)
			{
				goto IL_1FE;
			}
			goto IL_2BC;
			uint arg_254_0;
			while (true)
			{
				IL_24F:
				uint num2;
				switch ((num2 = (arg_254_0 ^ 499240077u)) % 19u)
				{
				case 0u:
					arg_254_0 = ((this.MessageValue.Length != 0) ? 558317677u : 171852120u);
					continue;
				case 1u:
					arg_254_0 = ((this.BlobValue.Length != 0) ? 1498624447u : 1015593644u);
					continue;
				case 2u:
					goto IL_1FE;
				case 3u:
					goto IL_2BC;
				case 4u:
					arg_254_0 = ((Variant.smethod_2(this.StringValue) == 0) ? 1666377095u : 51526280u);
					continue;
				case 6u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityIdValue);
					arg_254_0 = (num2 * 3592979854u ^ 1987358397u);
					continue;
				case 7u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.StringValue);
					arg_254_0 = (num2 * 687251466u ^ 3179960757u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.UintValue);
					arg_254_0 = (num2 * 503497281u ^ 2012557513u);
					continue;
				case 9u:
					num += 1 + CodedOutputStream.ComputeBytesSize(this.MessageValue);
					arg_254_0 = (num2 * 916158088u ^ 2989774424u);
					continue;
				case 10u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.FourccValue);
					arg_254_0 = (num2 * 2333635345u ^ 2011783446u);
					continue;
				case 11u:
					arg_254_0 = ((Variant.smethod_2(this.FourccValue) != 0) ? 2135165772u : 1599903687u);
					continue;
				case 12u:
					arg_254_0 = ((this.UintValue == 0uL) ? 351686069u : 1789274865u);
					continue;
				case 13u:
					num += 1 + CodedOutputStream.ComputeInt64Size(this.IntValue);
					arg_254_0 = (num2 * 1534765100u ^ 2437165929u);
					continue;
				case 14u:
					arg_254_0 = ((this.FloatValue != 0.0) ? 1017578876u : 466996950u);
					continue;
				case 15u:
					num += 2;
					arg_254_0 = (num2 * 666141736u ^ 3512591731u);
					continue;
				case 16u:
					arg_254_0 = ((this.entityIdValue_ != null) ? 1656465662u : 1451219063u);
					continue;
				case 17u:
					num += 9;
					arg_254_0 = (num2 * 4245224248u ^ 2295773550u);
					continue;
				case 18u:
					num += 1 + CodedOutputStream.ComputeBytesSize(this.BlobValue);
					arg_254_0 = (num2 * 4291063247u ^ 2356789186u);
					continue;
				}
				break;
			}
			return num;
			IL_1FE:
			arg_254_0 = 1780184973u;
			goto IL_24F;
			IL_2BC:
			arg_254_0 = ((this.IntValue == 0L) ? 464873849u : 622597761u);
			goto IL_24F;
		}

		public void MergeFrom(Variant other)
		{
			if (other == null)
			{
				goto IL_143;
			}
			goto IL_322;
			uint arg_2AA_0;
			while (true)
			{
				IL_2A5:
				uint num;
				switch ((num = (arg_2AA_0 ^ 3200371198u)) % 23u)
				{
				case 1u:
					this.entityIdValue_ = new EntityId();
					arg_2AA_0 = (num * 3596421724u ^ 1938521091u);
					continue;
				case 2u:
					arg_2AA_0 = ((other.MessageValue.Length == 0) ? 3240235866u : 3500866752u);
					continue;
				case 3u:
					this.EntityIdValue.MergeFrom(other.EntityIdValue);
					arg_2AA_0 = 4225250175u;
					continue;
				case 4u:
					arg_2AA_0 = ((other.BlobValue.Length != 0) ? 3921792170u : 2568708558u);
					continue;
				case 5u:
					arg_2AA_0 = ((other.entityIdValue_ == null) ? 4225250175u : 3373408773u);
					continue;
				case 6u:
					arg_2AA_0 = ((Variant.smethod_2(other.StringValue) != 0) ? 3467534335u : 2486172930u);
					continue;
				case 7u:
					arg_2AA_0 = ((other.FloatValue == 0.0) ? 2858090446u : 3083716025u);
					continue;
				case 8u:
					return;
				case 9u:
					goto IL_322;
				case 10u:
					this.BlobValue = other.BlobValue;
					arg_2AA_0 = (num * 1232605776u ^ 987427726u);
					continue;
				case 11u:
					arg_2AA_0 = ((Variant.smethod_2(other.FourccValue) == 0) ? 2989264056u : 3509943830u);
					continue;
				case 12u:
					this.StringValue = other.StringValue;
					arg_2AA_0 = (num * 3241709812u ^ 3957093878u);
					continue;
				case 13u:
					goto IL_143;
				case 14u:
					this.MessageValue = other.MessageValue;
					arg_2AA_0 = (num * 46558936u ^ 611025674u);
					continue;
				case 15u:
					this.IntValue = other.IntValue;
					arg_2AA_0 = (num * 4175570544u ^ 3914742059u);
					continue;
				case 16u:
					this.UintValue = other.UintValue;
					arg_2AA_0 = (num * 4193601475u ^ 2445588420u);
					continue;
				case 17u:
					this.FourccValue = other.FourccValue;
					arg_2AA_0 = (num * 3321359258u ^ 1154225448u);
					continue;
				case 18u:
					this.BoolValue = other.BoolValue;
					arg_2AA_0 = (num * 1259002889u ^ 3804047429u);
					continue;
				case 19u:
					arg_2AA_0 = (((this.entityIdValue_ == null) ? 2222443836u : 2243468298u) ^ num * 1673249847u);
					continue;
				case 20u:
					arg_2AA_0 = ((other.UintValue == 0uL) ? 2396879741u : 4250895405u);
					continue;
				case 21u:
					this.FloatValue = other.FloatValue;
					arg_2AA_0 = (num * 334984610u ^ 4075276320u);
					continue;
				case 22u:
					arg_2AA_0 = ((other.IntValue != 0L) ? 2842458438u : 2415827371u);
					continue;
				}
				break;
			}
			return;
			IL_143:
			arg_2AA_0 = 2571502662u;
			goto IL_2A5;
			IL_322:
			arg_2AA_0 = (other.BoolValue ? 2718268990u : 2632867205u);
			goto IL_2A5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_42F:
				uint num;
				uint arg_387_0 = ((num = input.ReadTag()) == 0u) ? 1328010304u : 1132277169u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_387_0 ^ 825030641u)) % 35u)
					{
					case 0u:
						arg_387_0 = (((num == 42u) ? 3622140776u : 2759317602u) ^ num2 * 3058642106u);
						continue;
					case 1u:
						arg_387_0 = ((num != 66u) ? 1051971966u : 2089244539u);
						continue;
					case 2u:
						this.MessageValue = input.ReadBytes();
						arg_387_0 = 893606639u;
						continue;
					case 3u:
						goto IL_42F;
					case 4u:
						this.entityIdValue_ = new EntityId();
						arg_387_0 = (num2 * 533263456u ^ 3913683740u);
						continue;
					case 5u:
						arg_387_0 = (((num == 72u) ? 3826460554u : 2998181416u) ^ num2 * 3706159964u);
						continue;
					case 6u:
						arg_387_0 = (num2 * 2154465028u ^ 3232089191u);
						continue;
					case 7u:
						this.BoolValue = input.ReadBool();
						arg_387_0 = 644214632u;
						continue;
					case 8u:
						this.StringValue = input.ReadString();
						arg_387_0 = 1133389740u;
						continue;
					case 9u:
						input.ReadMessage(this.entityIdValue_);
						arg_387_0 = 893606639u;
						continue;
					case 10u:
						arg_387_0 = (num2 * 3812909665u ^ 1331131081u);
						continue;
					case 11u:
						arg_387_0 = (((num != 16u) ? 2204255846u : 4248753160u) ^ num2 * 2605765193u);
						continue;
					case 12u:
						arg_387_0 = (num2 * 1716587701u ^ 2668492590u);
						continue;
					case 13u:
						arg_387_0 = ((num != 33u) ? 1619681234u : 30266775u);
						continue;
					case 14u:
						arg_387_0 = (((num > 24u) ? 2275365090u : 2334203010u) ^ num2 * 2480296389u);
						continue;
					case 15u:
						arg_387_0 = (((num == 24u) ? 2505743752u : 3722621680u) ^ num2 * 3537180693u);
						continue;
					case 16u:
						this.IntValue = input.ReadInt64();
						arg_387_0 = 893606639u;
						continue;
					case 17u:
						arg_387_0 = (num2 * 3766965473u ^ 3491091133u);
						continue;
					case 18u:
						this.BlobValue = input.ReadBytes();
						arg_387_0 = 952654636u;
						continue;
					case 19u:
						input.SkipLastField();
						arg_387_0 = 893606639u;
						continue;
					case 20u:
						arg_387_0 = ((num > 58u) ? 600373153u : 1990573756u);
						continue;
					case 21u:
						this.FourccValue = input.ReadString();
						arg_387_0 = 893606639u;
						continue;
					case 22u:
						arg_387_0 = ((num <= 42u) ? 1676412055u : 603619269u);
						continue;
					case 23u:
						this.UintValue = input.ReadUInt64();
						arg_387_0 = 164617171u;
						continue;
					case 25u:
						arg_387_0 = 1132277169u;
						continue;
					case 26u:
						arg_387_0 = ((this.entityIdValue_ != null) ? 913976028u : 2001820715u);
						continue;
					case 27u:
						arg_387_0 = (num2 * 2836613746u ^ 3146019208u);
						continue;
					case 28u:
						arg_387_0 = (((num != 50u) ? 723316174u : 469037180u) ^ num2 * 3570063527u);
						continue;
					case 29u:
						this.FloatValue = input.ReadDouble();
						arg_387_0 = 306030461u;
						continue;
					case 30u:
						arg_387_0 = (num2 * 1732386205u ^ 1099847270u);
						continue;
					case 31u:
						arg_387_0 = (((num == 58u) ? 389540576u : 1411377102u) ^ num2 * 3567013520u);
						continue;
					case 32u:
						arg_387_0 = (num2 * 3446135516u ^ 1351559871u);
						continue;
					case 33u:
						arg_387_0 = (num2 * 2661509097u ^ 2224335022u);
						continue;
					case 34u:
						arg_387_0 = (((num != 82u) ? 632282126u : 1525438124u) ^ num2 * 4070784156u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static bool smethod_1(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
