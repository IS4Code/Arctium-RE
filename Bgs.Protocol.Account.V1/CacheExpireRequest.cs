using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class CacheExpireRequest : IMessage<CacheExpireRequest>, IEquatable<CacheExpireRequest>, IDeepCloneable<CacheExpireRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly CacheExpireRequest.__c __9 = new CacheExpireRequest.__c();

			internal CacheExpireRequest cctor>b__34_0()
			{
				return new CacheExpireRequest();
			}
		}

		private static readonly MessageParser<CacheExpireRequest> _parser = new MessageParser<CacheExpireRequest>(new Func<CacheExpireRequest>(CacheExpireRequest.__c.__9.<.cctor>b__34_0));

		public const int AccountFieldNumber = 1;

		private static readonly FieldCodec<AccountId> _repeated_account_codec;

		private readonly RepeatedField<AccountId> account_ = new RepeatedField<AccountId>();

		public const int GameAccountFieldNumber = 2;

		private static readonly FieldCodec<GameAccountHandle> _repeated_gameAccount_codec;

		private readonly RepeatedField<GameAccountHandle> gameAccount_ = new RepeatedField<GameAccountHandle>();

		public const int EmailFieldNumber = 3;

		private static readonly FieldCodec<string> _repeated_email_codec;

		private readonly RepeatedField<string> email_ = new RepeatedField<string>();

		public static MessageParser<CacheExpireRequest> Parser
		{
			get
			{
				return CacheExpireRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CacheExpireRequest.Descriptor;
			}
		}

		public RepeatedField<AccountId> Account
		{
			get
			{
				return this.account_;
			}
		}

		public RepeatedField<GameAccountHandle> GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
		}

		public RepeatedField<string> Email
		{
			get
			{
				return this.email_;
			}
		}

		public CacheExpireRequest()
		{
		}

		public CacheExpireRequest(CacheExpireRequest other) : this()
		{
			this.account_ = other.account_.Clone();
			this.gameAccount_ = other.gameAccount_.Clone();
			this.email_ = other.email_.Clone();
		}

		public CacheExpireRequest Clone()
		{
			return new CacheExpireRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as CacheExpireRequest);
		}

		public bool Equals(CacheExpireRequest other)
		{
			if (other == null)
			{
				goto IL_9F;
			}
			goto IL_EF;
			int arg_A9_0;
			while (true)
			{
				IL_A4:
				switch ((arg_A9_0 ^ 2028384481) % 11)
				{
				case 0:
					goto IL_9F;
				case 1:
					return false;
				case 2:
					goto IL_EF;
				case 3:
					arg_A9_0 = (this.gameAccount_.Equals(other.gameAccount_) ? 1865814090 : 458481699);
					continue;
				case 4:
					arg_A9_0 = (this.account_.Equals(other.account_) ? 572908074 : 1262552959);
					continue;
				case 5:
					return true;
				case 6:
					return false;
				case 8:
					return false;
				case 9:
					arg_A9_0 = ((!this.email_.Equals(other.email_)) ? 423094484 : 643782940);
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_9F:
			arg_A9_0 = 152707476;
			goto IL_A4;
			IL_EF:
			arg_A9_0 = ((other == this) ? 1255467517 : 418096540);
			goto IL_A4;
		}

		public override int GetHashCode()
		{
			return 1 ^ CacheExpireRequest.smethod_0(this.account_) ^ CacheExpireRequest.smethod_0(this.gameAccount_) ^ CacheExpireRequest.smethod_0(this.email_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.account_.WriteTo(output, CacheExpireRequest._repeated_account_codec);
			while (true)
			{
				IL_5F:
				uint arg_47_0 = 2009168373u;
				while (true)
				{
					uint num;
					switch ((num = (arg_47_0 ^ 744888371u)) % 3u)
					{
					case 1u:
						this.gameAccount_.WriteTo(output, CacheExpireRequest._repeated_gameAccount_codec);
						this.email_.WriteTo(output, CacheExpireRequest._repeated_email_codec);
						arg_47_0 = (num * 2041371489u ^ 112111183u);
						continue;
					case 2u:
						goto IL_5F;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + this.account_.CalculateSize(CacheExpireRequest._repeated_account_codec) + this.gameAccount_.CalculateSize(CacheExpireRequest._repeated_gameAccount_codec) + this.email_.CalculateSize(CacheExpireRequest._repeated_email_codec);
		}

		public void MergeFrom(CacheExpireRequest other)
		{
			if (other == null)
			{
				goto IL_36;
			}
			goto IL_60;
			uint arg_40_0;
			while (true)
			{
				IL_3B:
				uint num;
				switch ((num = (arg_40_0 ^ 985347829u)) % 5u)
				{
				case 0u:
					goto IL_60;
				case 1u:
					return;
				case 2u:
					goto IL_36;
				case 4u:
					this.gameAccount_.Add(other.gameAccount_);
					this.email_.Add(other.email_);
					arg_40_0 = (num * 4195713929u ^ 3886400169u);
					continue;
				}
				break;
			}
			return;
			IL_36:
			arg_40_0 = 842446299u;
			goto IL_3B;
			IL_60:
			this.account_.Add(other.account_);
			arg_40_0 = 350570168u;
			goto IL_3B;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_15D:
				uint num;
				uint arg_111_0 = ((num = input.ReadTag()) == 0u) ? 3169452622u : 2560659789u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_111_0 ^ 3099243811u)) % 12u)
					{
					case 0u:
						arg_111_0 = (((num != 18u) ? 3546171126u : 4147258318u) ^ num2 * 2045544474u);
						continue;
					case 2u:
						arg_111_0 = 2560659789u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_111_0 = (num2 * 3004249600u ^ 2117010971u);
						continue;
					case 4u:
						arg_111_0 = (num2 * 4183521191u ^ 2240725661u);
						continue;
					case 5u:
						arg_111_0 = (((num == 26u) ? 2336081049u : 2185408393u) ^ num2 * 2140435021u);
						continue;
					case 6u:
						arg_111_0 = ((num == 10u) ? 2157730539u : 4164752979u);
						continue;
					case 7u:
						arg_111_0 = (num2 * 2970974849u ^ 3928661130u);
						continue;
					case 8u:
						this.account_.AddEntriesFrom(input, CacheExpireRequest._repeated_account_codec);
						arg_111_0 = 2894041365u;
						continue;
					case 9u:
						this.gameAccount_.AddEntriesFrom(input, CacheExpireRequest._repeated_gameAccount_codec);
						arg_111_0 = 3168111932u;
						continue;
					case 10u:
						goto IL_15D;
					case 11u:
						this.email_.AddEntriesFrom(input, CacheExpireRequest._repeated_email_codec);
						arg_111_0 = 2894041365u;
						continue;
					}
					return;
				}
			}
		}

		static CacheExpireRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 3682359432u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 2877718046u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 1u:
						CacheExpireRequest._repeated_account_codec = FieldCodec.ForMessage<AccountId>(10u, AccountId.Parser);
						arg_3F_0 = (num * 4250555591u ^ 321158372u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			CacheExpireRequest._repeated_gameAccount_codec = FieldCodec.ForMessage<GameAccountHandle>(18u, GameAccountHandle.Parser);
			CacheExpireRequest._repeated_email_codec = FieldCodec.ForString(26u);
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
