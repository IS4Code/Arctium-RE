using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountSettingsNotification : IMessage<AccountSettingsNotification>, IEquatable<AccountSettingsNotification>, IDeepCloneable<AccountSettingsNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountSettingsNotification.__c __9 = new AccountSettingsNotification.__c();

			internal AccountSettingsNotification cctor>b__44_0()
			{
				return new AccountSettingsNotification();
			}
		}

		private static readonly MessageParser<AccountSettingsNotification> _parser = new MessageParser<AccountSettingsNotification>(new Func<AccountSettingsNotification>(AccountSettingsNotification.__c.__9.<.cctor>b__44_0));

		public const int LicensesFieldNumber = 1;

		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(10u, AccountLicense.Parser);

		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		public const int IsUsingRidFieldNumber = 2;

		private bool isUsingRid_;

		public const int IsPlayingFromIgrFieldNumber = 3;

		private bool isPlayingFromIgr_;

		public const int CanReceiveVoiceFieldNumber = 4;

		private bool canReceiveVoice_;

		public const int CanSendVoiceFieldNumber = 5;

		private bool canSendVoice_;

		public static MessageParser<AccountSettingsNotification> Parser
		{
			get
			{
				return AccountSettingsNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountSettingsNotification.Descriptor;
			}
		}

		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		public bool IsUsingRid
		{
			get
			{
				return this.isUsingRid_;
			}
			set
			{
				this.isUsingRid_ = value;
			}
		}

		public bool IsPlayingFromIgr
		{
			get
			{
				return this.isPlayingFromIgr_;
			}
			set
			{
				this.isPlayingFromIgr_ = value;
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

		public AccountSettingsNotification()
		{
		}

		public AccountSettingsNotification(AccountSettingsNotification other) : this()
		{
			while (true)
			{
				IL_86:
				uint arg_6A_0 = 218359194u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6A_0 ^ 1666565613u)) % 4u)
					{
					case 0u:
						goto IL_86;
					case 2u:
						this.canReceiveVoice_ = other.canReceiveVoice_;
						this.canSendVoice_ = other.canSendVoice_;
						arg_6A_0 = (num * 1687759339u ^ 205535570u);
						continue;
					case 3u:
						this.licenses_ = other.licenses_.Clone();
						this.isUsingRid_ = other.isUsingRid_;
						this.isPlayingFromIgr_ = other.isPlayingFromIgr_;
						arg_6A_0 = (num * 201548354u ^ 46454853u);
						continue;
					}
					return;
				}
			}
		}

		public AccountSettingsNotification Clone()
		{
			return new AccountSettingsNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountSettingsNotification);
		}

		public bool Equals(AccountSettingsNotification other)
		{
			if (other == null)
			{
				goto IL_69;
			}
			goto IL_143;
			int arg_ED_0;
			while (true)
			{
				IL_E8:
				switch ((arg_ED_0 ^ -1778785587) % 15)
				{
				case 0:
					arg_ED_0 = ((this.IsPlayingFromIgr != other.IsPlayingFromIgr) ? -651007002 : -704167543);
					continue;
				case 2:
					arg_ED_0 = ((!this.licenses_.Equals(other.licenses_)) ? -804974790 : -382211745);
					continue;
				case 3:
					goto IL_143;
				case 4:
					return true;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_ED_0 = ((this.IsUsingRid == other.IsUsingRid) ? -668966273 : -1511575436);
					continue;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					goto IL_69;
				case 12:
					arg_ED_0 = ((this.CanReceiveVoice != other.CanReceiveVoice) ? -8199090 : -600000608);
					continue;
				case 13:
					return false;
				case 14:
					arg_ED_0 = ((this.CanSendVoice == other.CanSendVoice) ? -1508854551 : -1892915336);
					continue;
				}
				break;
			}
			return true;
			IL_69:
			arg_ED_0 = -1925363386;
			goto IL_E8;
			IL_143:
			arg_ED_0 = ((other != this) ? -1040235890 : -456146504);
			goto IL_E8;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_165:
				uint arg_130_0 = 489533788u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_130_0 ^ 1127735010u)) % 10u)
					{
					case 0u:
						arg_130_0 = (this.CanSendVoice ? 862896278u : 733767533u);
						continue;
					case 2u:
						num ^= this.CanSendVoice.GetHashCode();
						arg_130_0 = (num2 * 292496546u ^ 2739270149u);
						continue;
					case 3u:
						num ^= this.CanReceiveVoice.GetHashCode();
						arg_130_0 = (num2 * 3761153758u ^ 1738159424u);
						continue;
					case 4u:
						arg_130_0 = (this.CanReceiveVoice ? 1237599627u : 629075534u);
						continue;
					case 5u:
						num ^= this.IsPlayingFromIgr.GetHashCode();
						arg_130_0 = (num2 * 1934430522u ^ 4274906556u);
						continue;
					case 6u:
						num ^= AccountSettingsNotification.smethod_0(this.licenses_);
						arg_130_0 = ((this.IsUsingRid ? 3990766808u : 3449943203u) ^ num2 * 1638083873u);
						continue;
					case 7u:
						goto IL_165;
					case 8u:
						num ^= this.IsUsingRid.GetHashCode();
						arg_130_0 = (num2 * 2602591381u ^ 1615029065u);
						continue;
					case 9u:
						arg_130_0 = ((!this.IsPlayingFromIgr) ? 16269650u : 1536096193u);
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
			this.licenses_.WriteTo(output, AccountSettingsNotification._repeated_licenses_codec);
			while (true)
			{
				IL_188:
				uint arg_14F_0 = 495961434u;
				while (true)
				{
					uint num;
					switch ((num = (arg_14F_0 ^ 978438041u)) % 11u)
					{
					case 1u:
						arg_14F_0 = ((!this.IsPlayingFromIgr) ? 1664259808u : 1045109861u);
						continue;
					case 2u:
						output.WriteRawTag(16);
						output.WriteBool(this.IsUsingRid);
						arg_14F_0 = (num * 3549147341u ^ 1576404271u);
						continue;
					case 3u:
						output.WriteRawTag(40);
						output.WriteBool(this.CanSendVoice);
						arg_14F_0 = (num * 972444187u ^ 2632580604u);
						continue;
					case 4u:
						goto IL_188;
					case 5u:
						output.WriteRawTag(32);
						output.WriteBool(this.CanReceiveVoice);
						arg_14F_0 = (num * 766339123u ^ 1902005302u);
						continue;
					case 6u:
						arg_14F_0 = (this.CanReceiveVoice ? 590365651u : 1702045320u);
						continue;
					case 7u:
						arg_14F_0 = ((this.IsUsingRid ? 380292207u : 1234798237u) ^ num * 2510634881u);
						continue;
					case 8u:
						output.WriteRawTag(24);
						arg_14F_0 = (num * 3116491206u ^ 3854773624u);
						continue;
					case 9u:
						output.WriteBool(this.IsPlayingFromIgr);
						arg_14F_0 = (num * 1085906633u ^ 1476803057u);
						continue;
					case 10u:
						arg_14F_0 = (this.CanSendVoice ? 1048315200u : 975893279u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + this.licenses_.CalculateSize(AccountSettingsNotification._repeated_licenses_codec);
			while (true)
			{
				IL_130:
				uint arg_FB_0 = 1622271010u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_FB_0 ^ 78467823u)) % 10u)
					{
					case 0u:
						num += 2;
						arg_FB_0 = (num2 * 4075358430u ^ 1745597744u);
						continue;
					case 1u:
						arg_FB_0 = (this.CanReceiveVoice ? 1152169692u : 1087577057u);
						continue;
					case 2u:
						num += 2;
						arg_FB_0 = (num2 * 1620761979u ^ 3726185422u);
						continue;
					case 3u:
						arg_FB_0 = (this.IsPlayingFromIgr ? 881636957u : 1809029192u);
						continue;
					case 4u:
						num += 2;
						arg_FB_0 = (num2 * 1194156111u ^ 2217954901u);
						continue;
					case 5u:
						arg_FB_0 = (((!this.IsUsingRid) ? 1456312898u : 1535203913u) ^ num2 * 1932324130u);
						continue;
					case 6u:
						arg_FB_0 = ((!this.CanSendVoice) ? 1304110639u : 1091925385u);
						continue;
					case 7u:
						goto IL_130;
					case 9u:
						num += 2;
						arg_FB_0 = (num2 * 2401873746u ^ 2484596407u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountSettingsNotification other)
		{
			if (other == null)
			{
				goto IL_10C;
			}
			goto IL_153;
			uint arg_116_0;
			while (true)
			{
				IL_111:
				uint num;
				switch ((num = (arg_116_0 ^ 3763359347u)) % 12u)
				{
				case 0u:
					goto IL_10C;
				case 1u:
					return;
				case 2u:
					this.IsUsingRid = other.IsUsingRid;
					arg_116_0 = (num * 426850819u ^ 3270016114u);
					continue;
				case 3u:
					this.CanReceiveVoice = other.CanReceiveVoice;
					arg_116_0 = (num * 906977232u ^ 1330688332u);
					continue;
				case 4u:
					goto IL_153;
				case 5u:
					this.IsPlayingFromIgr = other.IsPlayingFromIgr;
					arg_116_0 = (num * 2813059589u ^ 3067566595u);
					continue;
				case 6u:
					arg_116_0 = ((other.IsUsingRid ? 4049107635u : 4056428694u) ^ num * 2026741387u);
					continue;
				case 7u:
					arg_116_0 = (other.CanSendVoice ? 2804164725u : 2258845275u);
					continue;
				case 9u:
					arg_116_0 = (other.CanReceiveVoice ? 4219680988u : 3159158396u);
					continue;
				case 10u:
					this.CanSendVoice = other.CanSendVoice;
					arg_116_0 = (num * 1358678234u ^ 907456327u);
					continue;
				case 11u:
					arg_116_0 = (other.IsPlayingFromIgr ? 2902840426u : 3837677182u);
					continue;
				}
				break;
			}
			return;
			IL_10C:
			arg_116_0 = 3531186630u;
			goto IL_111;
			IL_153:
			this.licenses_.Add(other.licenses_);
			arg_116_0 = 2779244229u;
			goto IL_111;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_214:
				uint num;
				uint arg_1B0_0 = ((num = input.ReadTag()) != 0u) ? 3495378525u : 2413231537u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1B0_0 ^ 3154027975u)) % 18u)
					{
					case 0u:
						arg_1B0_0 = (((num == 10u) ? 2473347846u : 3470284160u) ^ num2 * 1468357766u);
						continue;
					case 1u:
						arg_1B0_0 = ((num != 24u) ? 2982846380u : 2394016742u);
						continue;
					case 2u:
						arg_1B0_0 = 3495378525u;
						continue;
					case 3u:
						arg_1B0_0 = (num2 * 1127702003u ^ 2838387814u);
						continue;
					case 4u:
						this.CanSendVoice = input.ReadBool();
						arg_1B0_0 = 3502934673u;
						continue;
					case 5u:
						this.licenses_.AddEntriesFrom(input, AccountSettingsNotification._repeated_licenses_codec);
						arg_1B0_0 = 3502934673u;
						continue;
					case 6u:
						this.IsUsingRid = input.ReadBool();
						arg_1B0_0 = 3502934673u;
						continue;
					case 7u:
						arg_1B0_0 = (((num != 40u) ? 1003771042u : 469859078u) ^ num2 * 821494993u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_1B0_0 = 3954558655u;
						continue;
					case 9u:
						this.CanReceiveVoice = input.ReadBool();
						arg_1B0_0 = 2355186218u;
						continue;
					case 11u:
						arg_1B0_0 = (((num == 32u) ? 2200797959u : 2474857797u) ^ num2 * 75774073u);
						continue;
					case 12u:
						arg_1B0_0 = ((num <= 16u) ? 2839597479u : 3983516164u);
						continue;
					case 13u:
						arg_1B0_0 = (num2 * 4068064730u ^ 2439985677u);
						continue;
					case 14u:
						arg_1B0_0 = (num2 * 3819140786u ^ 2171007969u);
						continue;
					case 15u:
						arg_1B0_0 = (((num == 16u) ? 4119688228u : 2932483101u) ^ num2 * 2048611903u);
						continue;
					case 16u:
						goto IL_214;
					case 17u:
						this.IsPlayingFromIgr = input.ReadBool();
						arg_1B0_0 = 3502934673u;
						continue;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
