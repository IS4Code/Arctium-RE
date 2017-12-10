using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class ParentalControlInfo : IMessage<ParentalControlInfo>, IEquatable<ParentalControlInfo>, IDeepCloneable<ParentalControlInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ParentalControlInfo.__c __9 = new ParentalControlInfo.__c();

			internal ParentalControlInfo cctor>b__49_0()
			{
				return new ParentalControlInfo();
			}
		}

		private static readonly MessageParser<ParentalControlInfo> _parser = new MessageParser<ParentalControlInfo>(new Func<ParentalControlInfo>(ParentalControlInfo.__c.__9.<.cctor>b__49_0));

		public const int TimezoneFieldNumber = 3;

		private string timezone_ = "";

		public const int MinutesPerDayFieldNumber = 4;

		private uint minutesPerDay_;

		public const int MinutesPerWeekFieldNumber = 5;

		private uint minutesPerWeek_;

		public const int CanReceiveVoiceFieldNumber = 6;

		private bool canReceiveVoice_;

		public const int CanSendVoiceFieldNumber = 7;

		private bool canSendVoice_;

		public const int PlayScheduleFieldNumber = 8;

		private static readonly FieldCodec<bool> _repeated_playSchedule_codec = FieldCodec.ForBool(66u);

		private readonly RepeatedField<bool> playSchedule_ = new RepeatedField<bool>();

		public static MessageParser<ParentalControlInfo> Parser
		{
			get
			{
				return ParentalControlInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[20];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParentalControlInfo.Descriptor;
			}
		}

		public string Timezone
		{
			get
			{
				return this.timezone_;
			}
			set
			{
				this.timezone_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public uint MinutesPerDay
		{
			get
			{
				return this.minutesPerDay_;
			}
			set
			{
				this.minutesPerDay_ = value;
			}
		}

		public uint MinutesPerWeek
		{
			get
			{
				return this.minutesPerWeek_;
			}
			set
			{
				this.minutesPerWeek_ = value;
			}
		}

		public bool CanReceiveVoice
		{
			get
			{
				return this.canReceiveVoice_;
			}
			set
			{
				this.canReceiveVoice_ = value;
			}
		}

		public bool CanSendVoice
		{
			get
			{
				return this.canSendVoice_;
			}
			set
			{
				this.canSendVoice_ = value;
			}
		}

		public RepeatedField<bool> PlaySchedule
		{
			get
			{
				return this.playSchedule_;
			}
		}

		public ParentalControlInfo()
		{
		}

		public ParentalControlInfo(ParentalControlInfo other) : this()
		{
			this.timezone_ = other.timezone_;
			this.minutesPerDay_ = other.minutesPerDay_;
			this.minutesPerWeek_ = other.minutesPerWeek_;
			this.canReceiveVoice_ = other.canReceiveVoice_;
			this.canSendVoice_ = other.canSendVoice_;
			this.playSchedule_ = other.playSchedule_.Clone();
		}

		public ParentalControlInfo Clone()
		{
			return new ParentalControlInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ParentalControlInfo);
		}

		public bool Equals(ParentalControlInfo other)
		{
			if (other == null)
			{
				goto IL_115;
			}
			goto IL_17D;
			int arg_11F_0;
			while (true)
			{
				IL_11A:
				switch ((arg_11F_0 ^ 590114685) % 17)
				{
				case 0:
					goto IL_115;
				case 1:
					return false;
				case 2:
					arg_11F_0 = ((this.CanSendVoice != other.CanSendVoice) ? 1214919115 : 1192928218);
					continue;
				case 4:
					goto IL_17D;
				case 5:
					arg_11F_0 = ((this.MinutesPerDay != other.MinutesPerDay) ? 374827048 : 1706902480);
					continue;
				case 6:
					return true;
				case 7:
					arg_11F_0 = ((this.MinutesPerWeek != other.MinutesPerWeek) ? 971962667 : 1674710957);
					continue;
				case 8:
					return false;
				case 9:
					arg_11F_0 = ((!ParentalControlInfo.smethod_0(this.Timezone, other.Timezone)) ? 1246296646 : 296200013);
					continue;
				case 10:
					arg_11F_0 = ((this.CanReceiveVoice != other.CanReceiveVoice) ? 936810417 : 1184159197);
					continue;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					return false;
				case 15:
					arg_11F_0 = ((!this.playSchedule_.Equals(other.playSchedule_)) ? 549947237 : 2058981451);
					continue;
				case 16:
					return false;
				}
				break;
			}
			return true;
			IL_115:
			arg_11F_0 = 1748777605;
			goto IL_11A;
			IL_17D:
			arg_11F_0 = ((other != this) ? 1724628259 : 1016446481);
			goto IL_11A;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_1A5:
				uint arg_168_0 = 3647482608u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_168_0 ^ 3195490826u)) % 12u)
					{
					case 0u:
						arg_168_0 = ((this.MinutesPerWeek == 0u) ? 3822180434u : 3284059363u);
						continue;
					case 1u:
						num ^= this.MinutesPerWeek.GetHashCode();
						arg_168_0 = (num2 * 531901601u ^ 4149882075u);
						continue;
					case 2u:
						goto IL_1A5;
					case 3u:
						num ^= this.CanReceiveVoice.GetHashCode();
						arg_168_0 = (num2 * 2266529235u ^ 996498664u);
						continue;
					case 4u:
						num ^= this.CanSendVoice.GetHashCode();
						arg_168_0 = (num2 * 2040237371u ^ 3000413052u);
						continue;
					case 5u:
						num ^= ParentalControlInfo.smethod_2(this.Timezone);
						arg_168_0 = (num2 * 1540116650u ^ 3472773795u);
						continue;
					case 6u:
						arg_168_0 = (((ParentalControlInfo.smethod_1(this.Timezone) != 0) ? 472042909u : 551401503u) ^ num2 * 3215141543u);
						continue;
					case 7u:
						arg_168_0 = ((this.MinutesPerDay == 0u) ? 2711656986u : 2889430191u);
						continue;
					case 8u:
						arg_168_0 = (this.CanReceiveVoice ? 3533426489u : 3404342497u);
						continue;
					case 9u:
						num ^= this.MinutesPerDay.GetHashCode();
						arg_168_0 = (num2 * 455801386u ^ 1854628616u);
						continue;
					case 11u:
						arg_168_0 = ((!this.CanSendVoice) ? 3829195064u : 4207220870u);
						continue;
					}
					goto Block_6;
				}
			}
			Block_6:
			return num ^ this.playSchedule_.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (ParentalControlInfo.smethod_1(this.Timezone) != 0)
			{
				goto IL_56;
			}
			goto IL_209;
			uint arg_1AD_0;
			while (true)
			{
				IL_1A8:
				uint num;
				switch ((num = (arg_1AD_0 ^ 1574715142u)) % 16u)
				{
				case 1u:
					arg_1AD_0 = ((!this.CanReceiveVoice) ? 1222008722u : 1781754219u);
					continue;
				case 2u:
					output.WriteRawTag(32);
					arg_1AD_0 = (num * 1629211168u ^ 4007944533u);
					continue;
				case 3u:
					output.WriteUInt32(this.MinutesPerDay);
					arg_1AD_0 = (num * 3645485639u ^ 1895908649u);
					continue;
				case 4u:
					arg_1AD_0 = ((!this.CanSendVoice) ? 1696171037u : 1642940175u);
					continue;
				case 5u:
					output.WriteRawTag(26);
					output.WriteString(this.Timezone);
					arg_1AD_0 = (num * 334410219u ^ 363822830u);
					continue;
				case 6u:
					output.WriteBool(this.CanSendVoice);
					arg_1AD_0 = (num * 2282995271u ^ 1118507319u);
					continue;
				case 7u:
					output.WriteUInt32(this.MinutesPerWeek);
					arg_1AD_0 = (num * 391538023u ^ 2573500022u);
					continue;
				case 8u:
					output.WriteBool(this.CanReceiveVoice);
					arg_1AD_0 = (num * 3120009563u ^ 2608578810u);
					continue;
				case 9u:
					output.WriteRawTag(56);
					arg_1AD_0 = (num * 3205255015u ^ 2509179167u);
					continue;
				case 10u:
					arg_1AD_0 = ((this.MinutesPerWeek == 0u) ? 1641669639u : 185673736u);
					continue;
				case 11u:
					this.playSchedule_.WriteTo(output, ParentalControlInfo._repeated_playSchedule_codec);
					arg_1AD_0 = 1966133942u;
					continue;
				case 12u:
					goto IL_56;
				case 13u:
					output.WriteRawTag(48);
					arg_1AD_0 = (num * 941950124u ^ 4208896130u);
					continue;
				case 14u:
					output.WriteRawTag(40);
					arg_1AD_0 = (num * 1524009932u ^ 3979002953u);
					continue;
				case 15u:
					goto IL_209;
				}
				break;
			}
			return;
			IL_56:
			arg_1AD_0 = 1383915731u;
			goto IL_1A8;
			IL_209:
			arg_1AD_0 = ((this.MinutesPerDay == 0u) ? 472653932u : 1020174116u);
			goto IL_1A8;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1AC:
				uint arg_16B_0 = 2052727058u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_16B_0 ^ 309256277u)) % 13u)
					{
					case 0u:
						num += 2;
						arg_16B_0 = (num2 * 2787715206u ^ 1970590729u);
						continue;
					case 1u:
						arg_16B_0 = (((ParentalControlInfo.smethod_1(this.Timezone) != 0) ? 3669823085u : 3457920944u) ^ num2 * 1929386028u);
						continue;
					case 2u:
						arg_16B_0 = ((this.MinutesPerDay != 0u) ? 455915211u : 399285947u);
						continue;
					case 3u:
						num += 2;
						arg_16B_0 = (num2 * 2000718395u ^ 3637693186u);
						continue;
					case 4u:
						arg_16B_0 = ((this.MinutesPerWeek != 0u) ? 1159863798u : 413954004u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Timezone);
						arg_16B_0 = (num2 * 2686566504u ^ 240057188u);
						continue;
					case 6u:
						arg_16B_0 = ((!this.CanReceiveVoice) ? 587508915u : 1922880138u);
						continue;
					case 7u:
						arg_16B_0 = (this.CanSendVoice ? 1165828815u : 740693628u);
						continue;
					case 8u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinutesPerDay);
						arg_16B_0 = (num2 * 1148177609u ^ 3209786549u);
						continue;
					case 10u:
						goto IL_1AC;
					case 11u:
						num += this.playSchedule_.CalculateSize(ParentalControlInfo._repeated_playSchedule_codec);
						arg_16B_0 = 1439370935u;
						continue;
					case 12u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinutesPerWeek);
						arg_16B_0 = (num2 * 3583145685u ^ 2101495115u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ParentalControlInfo other)
		{
			if (other == null)
			{
				goto IL_36;
			}
			goto IL_1AB;
			uint arg_157_0;
			while (true)
			{
				IL_152:
				uint num;
				switch ((num = (arg_157_0 ^ 1809358090u)) % 14u)
				{
				case 0u:
					arg_157_0 = ((other.MinutesPerDay == 0u) ? 948620773u : 492566147u);
					continue;
				case 1u:
					arg_157_0 = ((other.MinutesPerWeek != 0u) ? 1619891145u : 346839762u);
					continue;
				case 2u:
					this.Timezone = other.Timezone;
					arg_157_0 = (num * 4257192246u ^ 1177094038u);
					continue;
				case 3u:
					arg_157_0 = ((!other.CanSendVoice) ? 1704779604u : 1081862775u);
					continue;
				case 4u:
					this.playSchedule_.Add(other.playSchedule_);
					arg_157_0 = 1109604156u;
					continue;
				case 5u:
					this.MinutesPerWeek = other.MinutesPerWeek;
					arg_157_0 = (num * 905152202u ^ 3428642060u);
					continue;
				case 6u:
					arg_157_0 = (other.CanReceiveVoice ? 1922510623u : 1345312441u);
					continue;
				case 7u:
					this.MinutesPerDay = other.MinutesPerDay;
					arg_157_0 = (num * 2375591585u ^ 909359820u);
					continue;
				case 8u:
					goto IL_1AB;
				case 9u:
					return;
				case 11u:
					this.CanSendVoice = other.CanSendVoice;
					arg_157_0 = (num * 317462288u ^ 1051946372u);
					continue;
				case 12u:
					goto IL_36;
				case 13u:
					this.CanReceiveVoice = other.CanReceiveVoice;
					arg_157_0 = (num * 3419557464u ^ 3889056641u);
					continue;
				}
				break;
			}
			return;
			IL_36:
			arg_157_0 = 808439477u;
			goto IL_152;
			IL_1AB:
			arg_157_0 = ((ParentalControlInfo.smethod_1(other.Timezone) == 0) ? 619479394u : 647427076u);
			goto IL_152;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2C3:
				uint num;
				uint arg_24B_0 = ((num = input.ReadTag()) == 0u) ? 1984139637u : 1123701344u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_24B_0 ^ 573256886u)) % 23u)
					{
					case 0u:
						arg_24B_0 = ((num <= 56u) ? 632744017u : 86148862u);
						continue;
					case 1u:
						arg_24B_0 = (((num != 26u) ? 4187821568u : 2916113960u) ^ num2 * 2486801257u);
						continue;
					case 2u:
						arg_24B_0 = ((num <= 40u) ? 1049279737u : 1143870636u);
						continue;
					case 3u:
						arg_24B_0 = (num2 * 1007816354u ^ 1504240553u);
						continue;
					case 4u:
						input.SkipLastField();
						arg_24B_0 = 952203335u;
						continue;
					case 5u:
						this.playSchedule_.AddEntriesFrom(input, ParentalControlInfo._repeated_playSchedule_codec);
						arg_24B_0 = 952203335u;
						continue;
					case 6u:
						this.CanSendVoice = input.ReadBool();
						arg_24B_0 = 952203335u;
						continue;
					case 8u:
						arg_24B_0 = (num2 * 4189374392u ^ 821109415u);
						continue;
					case 9u:
						arg_24B_0 = (((num != 48u) ? 790097828u : 391876710u) ^ num2 * 2491149709u);
						continue;
					case 10u:
						this.MinutesPerWeek = input.ReadUInt32();
						arg_24B_0 = 304907315u;
						continue;
					case 11u:
						goto IL_2C3;
					case 12u:
						arg_24B_0 = 1123701344u;
						continue;
					case 13u:
						arg_24B_0 = (((num != 66u) ? 2683426271u : 2351141245u) ^ num2 * 1160768817u);
						continue;
					case 14u:
						this.MinutesPerDay = input.ReadUInt32();
						arg_24B_0 = 831097457u;
						continue;
					case 15u:
						arg_24B_0 = ((num == 64u) ? 2139566973u : 1257600694u);
						continue;
					case 16u:
						this.Timezone = input.ReadString();
						arg_24B_0 = 952203335u;
						continue;
					case 17u:
						arg_24B_0 = (((num != 40u) ? 2310571755u : 3650618439u) ^ num2 * 4013685679u);
						continue;
					case 18u:
						arg_24B_0 = (((num == 32u) ? 1372918167u : 2065382129u) ^ num2 * 1456317273u);
						continue;
					case 19u:
						arg_24B_0 = (num2 * 3518533243u ^ 4109561248u);
						continue;
					case 20u:
						arg_24B_0 = (num2 * 1495766471u ^ 1554189590u);
						continue;
					case 21u:
						this.CanReceiveVoice = input.ReadBool();
						arg_24B_0 = 952203335u;
						continue;
					case 22u:
						arg_24B_0 = (((num == 56u) ? 3315413200u : 3460361274u) ^ num2 * 944023037u);
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

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
