using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class CredentialUpdateRequest : IMessage<CredentialUpdateRequest>, IEquatable<CredentialUpdateRequest>, IDeepCloneable<CredentialUpdateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly CredentialUpdateRequest.__c __9 = new CredentialUpdateRequest.__c();

			internal CredentialUpdateRequest cctor>b__39_0()
			{
				return new CredentialUpdateRequest();
			}
		}

		private static readonly MessageParser<CredentialUpdateRequest> _parser = new MessageParser<CredentialUpdateRequest>(new Func<CredentialUpdateRequest>(CredentialUpdateRequest.__c.__9.<.cctor>b__39_0));

		public const int AccountFieldNumber = 1;

		private AccountId account_;

		public const int OldCredentialsFieldNumber = 2;

		private static readonly FieldCodec<AccountCredential> _repeated_oldCredentials_codec = FieldCodec.ForMessage<AccountCredential>(18u, AccountCredential.Parser);

		private readonly RepeatedField<AccountCredential> oldCredentials_ = new RepeatedField<AccountCredential>();

		public const int NewCredentialsFieldNumber = 3;

		private static readonly FieldCodec<AccountCredential> _repeated_newCredentials_codec = FieldCodec.ForMessage<AccountCredential>(26u, AccountCredential.Parser);

		private readonly RepeatedField<AccountCredential> newCredentials_ = new RepeatedField<AccountCredential>();

		public const int RegionFieldNumber = 4;

		private uint region_;

		public static MessageParser<CredentialUpdateRequest> Parser
		{
			get
			{
				return CredentialUpdateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CredentialUpdateRequest.Descriptor;
			}
		}

		public AccountId Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = value;
			}
		}

		public RepeatedField<AccountCredential> OldCredentials
		{
			get
			{
				return this.oldCredentials_;
			}
		}

		public RepeatedField<AccountCredential> NewCredentials
		{
			get
			{
				return this.newCredentials_;
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

		public CredentialUpdateRequest()
		{
		}

		public CredentialUpdateRequest(CredentialUpdateRequest other) : this()
		{
			this.Account = ((other.account_ != null) ? other.Account.Clone() : null);
			this.oldCredentials_ = other.oldCredentials_.Clone();
			this.newCredentials_ = other.newCredentials_.Clone();
			this.region_ = other.region_;
		}

		public CredentialUpdateRequest Clone()
		{
			return new CredentialUpdateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as CredentialUpdateRequest);
		}

		public bool Equals(CredentialUpdateRequest other)
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
				switch ((arg_D3_0 ^ 580603534) % 13)
				{
				case 0:
					goto IL_C9;
				case 1:
					return true;
				case 2:
					arg_D3_0 = (this.oldCredentials_.Equals(other.oldCredentials_) ? 444309964 : 711658726);
					continue;
				case 3:
					arg_D3_0 = ((this.Region != other.Region) ? 478581928 : 399106662);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_D3_0 = ((!this.newCredentials_.Equals(other.newCredentials_)) ? 476867826 : 284104870);
					continue;
				case 8:
					arg_D3_0 = (CredentialUpdateRequest.smethod_0(this.Account, other.Account) ? 1375230970 : 1805585247);
					continue;
				case 9:
					return false;
				case 10:
					goto IL_121;
				case 11:
					return false;
				}
				break;
			}
			return true;
			IL_C9:
			arg_D3_0 = 1460788887;
			goto IL_CE;
			IL_121:
			arg_D3_0 = ((other != this) ? 1709880735 : 333288246);
			goto IL_CE;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D5:
				uint arg_AD_0 = 2397202340u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AD_0 ^ 2427214325u)) % 7u)
					{
					case 1u:
						arg_AD_0 = (((this.Region == 0u) ? 1176702419u : 1775715134u) ^ num2 * 272399002u);
						continue;
					case 2u:
						num ^= CredentialUpdateRequest.smethod_1(this.oldCredentials_);
						arg_AD_0 = (num2 * 695806315u ^ 2508479793u);
						continue;
					case 3u:
						num ^= this.Region.GetHashCode();
						arg_AD_0 = (num2 * 3958505050u ^ 2003674935u);
						continue;
					case 4u:
						num ^= CredentialUpdateRequest.smethod_1(this.Account);
						arg_AD_0 = (num2 * 2232119895u ^ 208419626u);
						continue;
					case 5u:
						num ^= CredentialUpdateRequest.smethod_1(this.newCredentials_);
						arg_AD_0 = (num2 * 2390335019u ^ 2414301030u);
						continue;
					case 6u:
						goto IL_D5;
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
			output.WriteMessage(this.Account);
			while (true)
			{
				IL_CC:
				uint arg_A8_0 = 3665232257u;
				while (true)
				{
					uint num;
					switch ((num = (arg_A8_0 ^ 2918667784u)) % 6u)
					{
					case 0u:
						output.WriteRawTag(32);
						output.WriteUInt32(this.Region);
						arg_A8_0 = (num * 1718397994u ^ 2780782269u);
						continue;
					case 2u:
						goto IL_CC;
					case 3u:
						this.oldCredentials_.WriteTo(output, CredentialUpdateRequest._repeated_oldCredentials_codec);
						arg_A8_0 = (num * 2136065166u ^ 2459679780u);
						continue;
					case 4u:
						this.newCredentials_.WriteTo(output, CredentialUpdateRequest._repeated_newCredentials_codec);
						arg_A8_0 = (num * 1230570139u ^ 4131725187u);
						continue;
					case 5u:
						arg_A8_0 = (((this.Region != 0u) ? 3362370079u : 3465170030u) ^ num * 2087475543u);
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
				IL_E0:
				uint arg_B8_0 = 1328374299u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B8_0 ^ 872097984u)) % 7u)
					{
					case 0u:
						arg_B8_0 = (((this.Region != 0u) ? 3656261263u : 2613743617u) ^ num2 * 1835372426u);
						continue;
					case 1u:
						num += this.newCredentials_.CalculateSize(CredentialUpdateRequest._repeated_newCredentials_codec);
						arg_B8_0 = (num2 * 615687266u ^ 1139649045u);
						continue;
					case 2u:
						goto IL_E0;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Account);
						arg_B8_0 = (num2 * 527837355u ^ 3666649400u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
						arg_B8_0 = (num2 * 955327394u ^ 3823553889u);
						continue;
					case 6u:
						num += this.oldCredentials_.CalculateSize(CredentialUpdateRequest._repeated_oldCredentials_codec);
						arg_B8_0 = (num2 * 859459701u ^ 3415042527u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(CredentialUpdateRequest other)
		{
			if (other == null)
			{
				goto IL_FB;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 2157824175u)) % 11u)
				{
				case 0u:
					goto IL_FB;
				case 1u:
					arg_105_0 = (((this.account_ != null) ? 4224851079u : 4118080884u) ^ num * 615006745u);
					continue;
				case 3u:
					this.Account.MergeFrom(other.Account);
					arg_105_0 = 3538977361u;
					continue;
				case 4u:
					arg_105_0 = (((other.Region == 0u) ? 1483839075u : 430857790u) ^ num * 4191290252u);
					continue;
				case 5u:
					this.newCredentials_.Add(other.newCredentials_);
					arg_105_0 = (num * 3146555655u ^ 3077044455u);
					continue;
				case 6u:
					return;
				case 7u:
					this.Region = other.Region;
					arg_105_0 = (num * 2162423306u ^ 1645347589u);
					continue;
				case 8u:
					this.oldCredentials_.Add(other.oldCredentials_);
					arg_105_0 = 3306418966u;
					continue;
				case 9u:
					this.account_ = new AccountId();
					arg_105_0 = (num * 3380548451u ^ 3337191900u);
					continue;
				case 10u:
					goto IL_14D;
				}
				break;
			}
			return;
			IL_FB:
			arg_105_0 = 2691237538u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.account_ != null) ? 3436543228u : 3538977361u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_231:
				uint num;
				uint arg_1C9_0 = ((num = input.ReadTag()) == 0u) ? 4074361556u : 2389225871u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1C9_0 ^ 2832844712u)) % 19u)
					{
					case 0u:
						arg_1C9_0 = (num2 * 828437196u ^ 3618696197u);
						continue;
					case 1u:
						arg_1C9_0 = ((num == 26u) ? 2778473755u : 2916290563u);
						continue;
					case 2u:
						this.oldCredentials_.AddEntriesFrom(input, CredentialUpdateRequest._repeated_oldCredentials_codec);
						arg_1C9_0 = 3332952104u;
						continue;
					case 3u:
						arg_1C9_0 = (num2 * 2105134712u ^ 1049231147u);
						continue;
					case 4u:
						this.account_ = new AccountId();
						arg_1C9_0 = (num2 * 1749454716u ^ 1455850360u);
						continue;
					case 5u:
						goto IL_231;
					case 6u:
						arg_1C9_0 = (((num != 32u) ? 850407014u : 1720421213u) ^ num2 * 3467555319u);
						continue;
					case 7u:
						arg_1C9_0 = (((num != 18u) ? 4263518934u : 3397386366u) ^ num2 * 1260205642u);
						continue;
					case 8u:
						this.newCredentials_.AddEntriesFrom(input, CredentialUpdateRequest._repeated_newCredentials_codec);
						arg_1C9_0 = 2532571286u;
						continue;
					case 9u:
						arg_1C9_0 = 2389225871u;
						continue;
					case 10u:
						arg_1C9_0 = ((num > 18u) ? 3132722633u : 3561584671u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_1C9_0 = 2325930747u;
						continue;
					case 13u:
						arg_1C9_0 = (((num != 10u) ? 1332633145u : 1895185577u) ^ num2 * 586690565u);
						continue;
					case 14u:
						arg_1C9_0 = ((this.account_ == null) ? 3742545992u : 4236678136u);
						continue;
					case 15u:
						arg_1C9_0 = (num2 * 2822385040u ^ 782334173u);
						continue;
					case 16u:
						this.Region = input.ReadUInt32();
						arg_1C9_0 = 3640913261u;
						continue;
					case 17u:
						arg_1C9_0 = (num2 * 1662735789u ^ 4038692077u);
						continue;
					case 18u:
						input.ReadMessage(this.account_);
						arg_1C9_0 = 3640913261u;
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
