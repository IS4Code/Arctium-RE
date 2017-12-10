using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Report.V1
{
	[DebuggerNonUserCode]
	public sealed class Report : IMessage<Report>, IEquatable<Report>, IDeepCloneable<Report>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Report.__c __9 = new Report.__c();

			internal Report cctor>b__49_0()
			{
				return new Report();
			}
		}

		private static readonly MessageParser<Report> _parser = new MessageParser<Report>(new Func<Report>(Report.__c.__9.<.cctor>b__49_0));

		public const int ReportTypeFieldNumber = 1;

		private string reportType_ = "";

		public const int AttributeFieldNumber = 2;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec;

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int ReportQosFieldNumber = 3;

		private int reportQos_;

		public const int ReportingAccountFieldNumber = 4;

		private EntityId reportingAccount_;

		public const int ReportingGameAccountFieldNumber = 5;

		private EntityId reportingGameAccount_;

		public const int ReportTimestampFieldNumber = 6;

		private ulong reportTimestamp_;

		public static MessageParser<Report> Parser
		{
			get
			{
				return Report._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Report.Descriptor;
			}
		}

		public string ReportType
		{
			get
			{
				return this.reportType_;
			}
			set
			{
				this.reportType_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public int ReportQos
		{
			get
			{
				return this.reportQos_;
			}
			set
			{
				this.reportQos_ = value;
			}
		}

		public EntityId ReportingAccount
		{
			get
			{
				return this.reportingAccount_;
			}
			set
			{
				this.reportingAccount_ = value;
			}
		}

		public EntityId ReportingGameAccount
		{
			get
			{
				return this.reportingGameAccount_;
			}
			set
			{
				this.reportingGameAccount_ = value;
			}
		}

		public ulong ReportTimestamp
		{
			get
			{
				return this.reportTimestamp_;
			}
			set
			{
				this.reportTimestamp_ = value;
			}
		}

		public Report()
		{
		}

		public Report(Report other) : this()
		{
			while (true)
			{
				IL_D2:
				uint arg_AA_0 = 2884127066u;
				while (true)
				{
					uint num;
					switch ((num = (arg_AA_0 ^ 4017192551u)) % 7u)
					{
					case 0u:
						this.reportQos_ = other.reportQos_;
						arg_AA_0 = (num * 372270476u ^ 565279991u);
						continue;
					case 1u:
						this.ReportingAccount = ((other.reportingAccount_ != null) ? other.ReportingAccount.Clone() : null);
						arg_AA_0 = 3926804672u;
						continue;
					case 3u:
						goto IL_D2;
					case 4u:
						this.reportType_ = other.reportType_;
						arg_AA_0 = (num * 1712965841u ^ 4123766709u);
						continue;
					case 5u:
						this.ReportingGameAccount = ((other.reportingGameAccount_ != null) ? other.ReportingGameAccount.Clone() : null);
						arg_AA_0 = 3071690161u;
						continue;
					case 6u:
						this.attribute_ = other.attribute_.Clone();
						arg_AA_0 = (num * 3189991420u ^ 454437110u);
						continue;
					}
					goto Block_3;
				}
			}
			Block_3:
			this.reportTimestamp_ = other.reportTimestamp_;
		}

		public Report Clone()
		{
			return new Report(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Report);
		}

		public bool Equals(Report other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_187;
			int arg_129_0;
			while (true)
			{
				IL_124:
				switch ((arg_129_0 ^ 1586279599) % 17)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_129_0 = ((this.ReportTimestamp != other.ReportTimestamp) ? 2066627078 : 1404626470);
					continue;
				case 3:
					arg_129_0 = (Report.smethod_1(this.ReportingGameAccount, other.ReportingGameAccount) ? 1170414672 : 1927926586);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_129_0 = ((!Report.smethod_1(this.ReportingAccount, other.ReportingAccount)) ? 206219572 : 1787112519);
					continue;
				case 8:
					arg_129_0 = (this.attribute_.Equals(other.attribute_) ? 1449181731 : 880422618);
					continue;
				case 9:
					arg_129_0 = ((this.ReportQos != other.ReportQos) ? 1997131049 : 2037650469);
					continue;
				case 10:
					return true;
				case 11:
					return false;
				case 13:
					goto IL_187;
				case 14:
					return false;
				case 15:
					arg_129_0 = (Report.smethod_0(this.ReportType, other.ReportType) ? 1910215212 : 619424062);
					continue;
				case 16:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_129_0 = 1013011120;
			goto IL_124;
			IL_187:
			arg_129_0 = ((other == this) ? 1436263048 : 1092755243);
			goto IL_124;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_180:
				uint arg_147_0 = 2725777644u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_147_0 ^ 3992640369u)) % 11u)
					{
					case 0u:
						num ^= this.ReportingGameAccount.GetHashCode();
						arg_147_0 = (num2 * 4180927499u ^ 4126234949u);
						continue;
					case 1u:
						arg_147_0 = ((this.reportingGameAccount_ == null) ? 4145480388u : 4168323410u);
						continue;
					case 2u:
						arg_147_0 = ((this.reportingAccount_ == null) ? 2528778989u : 2992374565u);
						continue;
					case 4u:
						arg_147_0 = ((this.ReportTimestamp != 0uL) ? 3046394720u : 4124302964u);
						continue;
					case 5u:
						num ^= this.ReportQos.GetHashCode();
						arg_147_0 = (num2 * 2202502833u ^ 1926342104u);
						continue;
					case 6u:
						num ^= this.ReportingAccount.GetHashCode();
						arg_147_0 = (num2 * 3189505204u ^ 832885245u);
						continue;
					case 7u:
						goto IL_180;
					case 8u:
						num ^= Report.smethod_2(this.attribute_);
						arg_147_0 = (((this.ReportQos == 0) ? 2869673969u : 3170117720u) ^ num2 * 2876868997u);
						continue;
					case 9u:
						num ^= this.ReportTimestamp.GetHashCode();
						arg_147_0 = (num2 * 591375281u ^ 805841077u);
						continue;
					case 10u:
						num ^= Report.smethod_2(this.ReportType);
						arg_147_0 = (num2 * 4066708685u ^ 1463271597u);
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
			while (true)
			{
				IL_1DE:
				uint arg_199_0 = 2123621616u;
				while (true)
				{
					uint num;
					switch ((num = (arg_199_0 ^ 1212145759u)) % 14u)
					{
					case 0u:
						arg_199_0 = ((this.reportingAccount_ != null) ? 1985982313u : 372082353u);
						continue;
					case 1u:
						output.WriteString(this.ReportType);
						this.attribute_.WriteTo(output, Report._repeated_attribute_codec);
						arg_199_0 = (num * 2471916897u ^ 1370405386u);
						continue;
					case 2u:
						output.WriteMessage(this.ReportingGameAccount);
						arg_199_0 = (num * 3087899038u ^ 633098964u);
						continue;
					case 3u:
						arg_199_0 = ((this.ReportTimestamp != 0uL) ? 66282650u : 103326526u);
						continue;
					case 4u:
						output.WriteRawTag(42);
						arg_199_0 = (num * 3857038700u ^ 1346154861u);
						continue;
					case 5u:
						output.WriteInt32(this.ReportQos);
						arg_199_0 = (num * 62691689u ^ 2027207436u);
						continue;
					case 6u:
						arg_199_0 = ((this.reportingGameAccount_ == null) ? 867832616u : 1223520691u);
						continue;
					case 7u:
						goto IL_1DE;
					case 8u:
						output.WriteRawTag(34);
						output.WriteMessage(this.ReportingAccount);
						arg_199_0 = (num * 1103997818u ^ 622941965u);
						continue;
					case 9u:
						output.WriteRawTag(24);
						arg_199_0 = (num * 1363739134u ^ 228022268u);
						continue;
					case 10u:
						arg_199_0 = (((this.ReportQos != 0) ? 3022792582u : 2196283463u) ^ num * 156289641u);
						continue;
					case 11u:
						output.WriteRawTag(49);
						arg_199_0 = (num * 1616477336u ^ 1967122035u);
						continue;
					case 12u:
						output.WriteFixed64(this.ReportTimestamp);
						arg_199_0 = (num * 1150393268u ^ 3784084014u);
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
				IL_168:
				uint arg_133_0 = 235284450u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_133_0 ^ 813398057u)) % 10u)
					{
					case 0u:
						num += 9;
						arg_133_0 = (num2 * 2365320437u ^ 3795305492u);
						continue;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ReportingGameAccount);
						arg_133_0 = (num2 * 3477848489u ^ 2581940384u);
						continue;
					case 2u:
						arg_133_0 = ((this.reportingGameAccount_ != null) ? 1234499662u : 1878205023u);
						continue;
					case 4u:
						arg_133_0 = ((this.ReportTimestamp != 0uL) ? 1848311063u : 345270338u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.ReportType);
						num += this.attribute_.CalculateSize(Report._repeated_attribute_codec);
						arg_133_0 = (((this.ReportQos != 0) ? 550951949u : 848104838u) ^ num2 * 2032105517u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ReportingAccount);
						arg_133_0 = (num2 * 1993512787u ^ 897151977u);
						continue;
					case 7u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.ReportQos);
						arg_133_0 = (num2 * 796681666u ^ 2611578751u);
						continue;
					case 8u:
						arg_133_0 = ((this.reportingAccount_ == null) ? 1919449757u : 476093973u);
						continue;
					case 9u:
						goto IL_168;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Report other)
		{
			if (other == null)
			{
				goto IL_1E1;
			}
			goto IL_24F;
			uint arg_1EB_0;
			while (true)
			{
				IL_1E6:
				uint num;
				switch ((num = (arg_1EB_0 ^ 3233792412u)) % 18u)
				{
				case 0u:
					goto IL_1E1;
				case 1u:
					this.ReportingGameAccount.MergeFrom(other.ReportingGameAccount);
					arg_1EB_0 = 2914559519u;
					continue;
				case 2u:
					this.attribute_.Add(other.attribute_);
					arg_1EB_0 = 2901701511u;
					continue;
				case 3u:
					arg_1EB_0 = ((other.reportingGameAccount_ == null) ? 2914559519u : 3218721711u);
					continue;
				case 4u:
					arg_1EB_0 = ((other.reportingAccount_ != null) ? 3619290954u : 3828981013u);
					continue;
				case 5u:
					arg_1EB_0 = (((this.reportingGameAccount_ != null) ? 794792566u : 573119972u) ^ num * 1825637469u);
					continue;
				case 6u:
					return;
				case 7u:
					this.ReportTimestamp = other.ReportTimestamp;
					arg_1EB_0 = (num * 2013422388u ^ 4085231762u);
					continue;
				case 8u:
					goto IL_24F;
				case 9u:
					this.reportingGameAccount_ = new EntityId();
					arg_1EB_0 = (num * 1769653787u ^ 2850298388u);
					continue;
				case 11u:
					this.ReportQos = other.ReportQos;
					arg_1EB_0 = (num * 683352361u ^ 4180714413u);
					continue;
				case 12u:
					this.ReportingAccount.MergeFrom(other.ReportingAccount);
					arg_1EB_0 = 3828981013u;
					continue;
				case 13u:
					arg_1EB_0 = (((other.ReportQos == 0) ? 4058684351u : 2319787590u) ^ num * 829470317u);
					continue;
				case 14u:
					arg_1EB_0 = (((this.reportingAccount_ == null) ? 657121329u : 1913703480u) ^ num * 1837213196u);
					continue;
				case 15u:
					this.reportingAccount_ = new EntityId();
					arg_1EB_0 = (num * 490886339u ^ 1943198879u);
					continue;
				case 16u:
					this.ReportType = other.ReportType;
					arg_1EB_0 = (num * 544348301u ^ 2137122564u);
					continue;
				case 17u:
					arg_1EB_0 = ((other.ReportTimestamp == 0uL) ? 2553359678u : 4024328331u);
					continue;
				}
				break;
			}
			return;
			IL_1E1:
			arg_1EB_0 = 3776788708u;
			goto IL_1E6;
			IL_24F:
			arg_1EB_0 = ((Report.smethod_3(other.ReportType) == 0) ? 3509463102u : 4028964670u);
			goto IL_1E6;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_306:
				uint num;
				uint arg_286_0 = ((num = input.ReadTag()) != 0u) ? 3084961494u : 4176633363u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_286_0 ^ 2717540428u)) % 25u)
					{
					case 0u:
						arg_286_0 = (((num == 10u) ? 128336849u : 854970612u) ^ num2 * 537534596u);
						continue;
					case 1u:
						arg_286_0 = (((num == 24u) ? 882264683u : 2049863096u) ^ num2 * 3749405071u);
						continue;
					case 2u:
						arg_286_0 = 3084961494u;
						continue;
					case 3u:
						arg_286_0 = (num2 * 3441031575u ^ 1590676399u);
						continue;
					case 5u:
						arg_286_0 = ((this.reportingAccount_ == null) ? 2757710192u : 3992815443u);
						continue;
					case 6u:
						this.ReportQos = input.ReadInt32();
						arg_286_0 = 3673206653u;
						continue;
					case 7u:
						arg_286_0 = (num2 * 2561498265u ^ 1429658614u);
						continue;
					case 8u:
						arg_286_0 = (((num == 49u) ? 447005027u : 666273143u) ^ num2 * 838991127u);
						continue;
					case 9u:
						this.attribute_.AddEntriesFrom(input, Report._repeated_attribute_codec);
						arg_286_0 = 3973580722u;
						continue;
					case 10u:
						input.ReadMessage(this.reportingAccount_);
						arg_286_0 = 4163057742u;
						continue;
					case 11u:
						arg_286_0 = ((this.reportingGameAccount_ == null) ? 2281572103u : 2964235497u);
						continue;
					case 12u:
						input.ReadMessage(this.reportingGameAccount_);
						arg_286_0 = 3607815914u;
						continue;
					case 13u:
						arg_286_0 = ((num <= 24u) ? 2350903161u : 4277886781u);
						continue;
					case 14u:
						this.ReportTimestamp = input.ReadFixed64();
						arg_286_0 = 3673206653u;
						continue;
					case 15u:
						this.ReportType = input.ReadString();
						arg_286_0 = 3673206653u;
						continue;
					case 16u:
						arg_286_0 = (num2 * 2819059275u ^ 3027962859u);
						continue;
					case 17u:
						input.SkipLastField();
						arg_286_0 = 3673206653u;
						continue;
					case 18u:
						arg_286_0 = (((num == 42u) ? 316968336u : 1895516420u) ^ num2 * 3478163015u);
						continue;
					case 19u:
						goto IL_306;
					case 20u:
						this.reportingGameAccount_ = new EntityId();
						arg_286_0 = (num2 * 4094353424u ^ 255373401u);
						continue;
					case 21u:
						arg_286_0 = (((num != 18u) ? 641026581u : 423511223u) ^ num2 * 4231916658u);
						continue;
					case 22u:
						arg_286_0 = ((num == 34u) ? 3341257861u : 4286741190u);
						continue;
					case 23u:
						arg_286_0 = (num2 * 3895559210u ^ 1683554369u);
						continue;
					case 24u:
						this.reportingAccount_ = new EntityId();
						arg_286_0 = (num2 * 121994974u ^ 4048928091u);
						continue;
					}
					return;
				}
			}
		}

		static Report()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 3175067485u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 3756938318u)) % 3u)
					{
					case 1u:
						Report._repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(18u, Bgs.Protocol.Attribute.Parser);
						arg_3F_0 = (num * 1497132829u ^ 2073047797u);
						continue;
					case 2u:
						goto IL_57;
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
