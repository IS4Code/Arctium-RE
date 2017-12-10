using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountStateTagged : IMessage<AccountStateTagged>, IEquatable<AccountStateTagged>, IDeepCloneable<AccountStateTagged>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountStateTagged.__c __9 = new AccountStateTagged.__c();

			internal AccountStateTagged cctor>b__29_0()
			{
				return new AccountStateTagged();
			}
		}

		private static readonly MessageParser<AccountStateTagged> _parser = new MessageParser<AccountStateTagged>(new Func<AccountStateTagged>(AccountStateTagged.__c.__9.<.cctor>b__29_0));

		public const int AccountStateFieldNumber = 1;

		private AccountState accountState_;

		public const int AccountTagsFieldNumber = 2;

		private AccountFieldTags accountTags_;

		public static MessageParser<AccountStateTagged> Parser
		{
			get
			{
				return AccountStateTagged._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[32];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountStateTagged.Descriptor;
			}
		}

		public AccountState AccountState
		{
			get
			{
				return this.accountState_;
			}
			set
			{
				this.accountState_ = value;
			}
		}

		public AccountFieldTags AccountTags
		{
			get
			{
				return this.accountTags_;
			}
			set
			{
				this.accountTags_ = value;
			}
		}

		public AccountStateTagged()
		{
		}

		public AccountStateTagged(AccountStateTagged other) : this()
		{
			while (true)
			{
				IL_6B:
				int arg_51_0 = -1367725675;
				while (true)
				{
					switch ((arg_51_0 ^ -393299392) % 4)
					{
					case 0:
						this.AccountTags = ((other.accountTags_ != null) ? other.AccountTags.Clone() : null);
						arg_51_0 = -128194961;
						continue;
					case 1:
						this.AccountState = ((other.accountState_ != null) ? other.AccountState.Clone() : null);
						arg_51_0 = -705763784;
						continue;
					case 2:
						goto IL_6B;
					}
					return;
				}
			}
		}

		public AccountStateTagged Clone()
		{
			return new AccountStateTagged(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountStateTagged);
		}

		public bool Equals(AccountStateTagged other)
		{
			if (other == null)
			{
				goto IL_6D;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -1065032306) % 9)
				{
				case 0:
					goto IL_6D;
				case 1:
					arg_77_0 = ((!AccountStateTagged.smethod_0(this.AccountTags, other.AccountTags)) ? -1356559502 : -1061962619);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 6:
					return false;
				case 7:
					goto IL_B5;
				case 8:
					arg_77_0 = ((!AccountStateTagged.smethod_0(this.AccountState, other.AccountState)) ? -343819474 : -1854343766);
					continue;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = -1415315741;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -334717245 : -208732495);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.accountState_ != null)
			{
				goto IL_19;
			}
			goto IL_89;
			uint arg_5D_0;
			while (true)
			{
				IL_58:
				uint num2;
				switch ((num2 = (arg_5D_0 ^ 2078887461u)) % 5u)
				{
				case 1u:
					num ^= AccountStateTagged.smethod_1(this.AccountState);
					arg_5D_0 = (num2 * 3287096701u ^ 1385051508u);
					continue;
				case 2u:
					goto IL_89;
				case 3u:
					num ^= AccountStateTagged.smethod_1(this.AccountTags);
					arg_5D_0 = (num2 * 1335891318u ^ 2831423082u);
					continue;
				case 4u:
					goto IL_19;
				}
				break;
			}
			return num;
			IL_19:
			arg_5D_0 = 1010758090u;
			goto IL_58;
			IL_89:
			arg_5D_0 = ((this.accountTags_ == null) ? 2007221764u : 709204112u);
			goto IL_58;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.accountState_ != null)
			{
				goto IL_7E;
			}
			goto IL_BF;
			uint arg_88_0;
			while (true)
			{
				IL_83:
				uint num;
				switch ((num = (arg_88_0 ^ 3645186398u)) % 7u)
				{
				case 0u:
					goto IL_7E;
				case 1u:
					output.WriteRawTag(10);
					arg_88_0 = (num * 2825923017u ^ 3889110834u);
					continue;
				case 2u:
					output.WriteMessage(this.AccountTags);
					arg_88_0 = (num * 2861560723u ^ 1731604973u);
					continue;
				case 3u:
					goto IL_BF;
				case 5u:
					output.WriteMessage(this.AccountState);
					arg_88_0 = (num * 1126806568u ^ 991643224u);
					continue;
				case 6u:
					output.WriteRawTag(18);
					arg_88_0 = (num * 1877049487u ^ 813565000u);
					continue;
				}
				break;
			}
			return;
			IL_7E:
			arg_88_0 = 3167558101u;
			goto IL_83;
			IL_BF:
			arg_88_0 = ((this.accountTags_ != null) ? 2837354707u : 3462437026u);
			goto IL_83;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 893414563u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 2002907972u)) % 6u)
					{
					case 1u:
						arg_92_0 = ((this.accountTags_ == null) ? 622155378u : 138568932u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountTags);
						arg_92_0 = (num2 * 1080250790u ^ 1945675698u);
						continue;
					case 3u:
						arg_92_0 = (((this.accountState_ == null) ? 3319418888u : 3009189381u) ^ num2 * 3602118805u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountState);
						arg_92_0 = (num2 * 1513793806u ^ 4234266055u);
						continue;
					case 5u:
						goto IL_B6;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountStateTagged other)
		{
			if (other == null)
			{
				goto IL_82;
			}
			goto IL_147;
			uint arg_FF_0;
			while (true)
			{
				IL_FA:
				uint num;
				switch ((num = (arg_FF_0 ^ 53694967u)) % 11u)
				{
				case 1u:
					return;
				case 2u:
					this.AccountState.MergeFrom(other.AccountState);
					arg_FF_0 = 2129170001u;
					continue;
				case 3u:
					this.accountState_ = new AccountState();
					arg_FF_0 = (num * 192644297u ^ 1771015179u);
					continue;
				case 4u:
					goto IL_147;
				case 5u:
					this.AccountTags.MergeFrom(other.AccountTags);
					arg_FF_0 = 1533868001u;
					continue;
				case 6u:
					arg_FF_0 = (((this.accountTags_ != null) ? 4098970194u : 2703138181u) ^ num * 2228702443u);
					continue;
				case 7u:
					goto IL_82;
				case 8u:
					this.accountTags_ = new AccountFieldTags();
					arg_FF_0 = (num * 642756574u ^ 4265683150u);
					continue;
				case 9u:
					arg_FF_0 = (((this.accountState_ == null) ? 69905190u : 2047797234u) ^ num * 967211495u);
					continue;
				case 10u:
					arg_FF_0 = ((other.accountTags_ == null) ? 1533868001u : 194837943u);
					continue;
				}
				break;
			}
			return;
			IL_82:
			arg_FF_0 = 1594834299u;
			goto IL_FA;
			IL_147:
			arg_FF_0 = ((other.accountState_ == null) ? 2129170001u : 2104736337u);
			goto IL_FA;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_183:
				uint num;
				uint arg_133_0 = ((num = input.ReadTag()) == 0u) ? 1596593153u : 397404980u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_133_0 ^ 603696359u)) % 13u)
					{
					case 0u:
						arg_133_0 = 397404980u;
						continue;
					case 1u:
						input.ReadMessage(this.accountTags_);
						arg_133_0 = 789569758u;
						continue;
					case 2u:
						this.accountState_ = new AccountState();
						arg_133_0 = (num2 * 3071308703u ^ 2217605743u);
						continue;
					case 3u:
						goto IL_183;
					case 4u:
						arg_133_0 = (((num == 18u) ? 4158239141u : 3356345441u) ^ num2 * 1106054806u);
						continue;
					case 5u:
						arg_133_0 = ((this.accountTags_ == null) ? 1531906712u : 1320074991u);
						continue;
					case 6u:
						this.accountTags_ = new AccountFieldTags();
						arg_133_0 = (num2 * 1061439014u ^ 2243808821u);
						continue;
					case 7u:
						arg_133_0 = ((this.accountState_ != null) ? 351259321u : 548381581u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_133_0 = (num2 * 2510450477u ^ 2341366795u);
						continue;
					case 9u:
						input.ReadMessage(this.accountState_);
						arg_133_0 = 789569758u;
						continue;
					case 10u:
						arg_133_0 = ((num == 10u) ? 2002387230u : 270548858u);
						continue;
					case 12u:
						arg_133_0 = (num2 * 765490691u ^ 4259253762u);
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
