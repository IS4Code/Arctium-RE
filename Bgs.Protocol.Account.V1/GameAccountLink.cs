using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountLink : IMessage<GameAccountLink>, IEquatable<GameAccountLink>, IDeepCloneable<GameAccountLink>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountLink.__c __9 = new GameAccountLink.__c();

			internal GameAccountLink cctor>b__29_0()
			{
				return new GameAccountLink();
			}
		}

		private static readonly MessageParser<GameAccountLink> _parser = new MessageParser<GameAccountLink>(new Func<GameAccountLink>(GameAccountLink.__c.__9.<.cctor>b__29_0));

		public const int GameAccountFieldNumber = 1;

		private GameAccountHandle gameAccount_;

		public const int NameFieldNumber = 2;

		private string name_ = "";

		public static MessageParser<GameAccountLink> Parser
		{
			get
			{
				return GameAccountLink._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountLink.Descriptor;
			}
		}

		public GameAccountHandle GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
			set
			{
				this.gameAccount_ = value;
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
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public GameAccountLink()
		{
		}

		public GameAccountLink(GameAccountLink other) : this()
		{
			while (true)
			{
				IL_50:
				int arg_3A_0 = 1057617480;
				while (true)
				{
					switch ((arg_3A_0 ^ 1981008821) % 3)
					{
					case 0:
						goto IL_50;
					case 2:
						this.GameAccount = ((other.gameAccount_ != null) ? other.GameAccount.Clone() : null);
						this.name_ = other.name_;
						arg_3A_0 = 299742382;
						continue;
					}
					return;
				}
			}
		}

		public GameAccountLink Clone()
		{
			return new GameAccountLink(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountLink);
		}

		public bool Equals(GameAccountLink other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -306153) % 9)
				{
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_77_0 = ((!GameAccountLink.smethod_0(this.GameAccount, other.GameAccount)) ? -134471677 : -330961647);
					continue;
				case 5:
					return true;
				case 6:
					goto IL_B5;
				case 7:
					arg_77_0 = ((!GameAccountLink.smethod_1(this.Name, other.Name)) ? -2116292834 : -1013655447);
					continue;
				case 8:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = -1091742355;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -1513340893 : -944615950);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			return 1 ^ GameAccountLink.smethod_2(this.GameAccount) ^ GameAccountLink.smethod_2(this.Name);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteMessage(this.GameAccount);
			output.WriteRawTag(18);
			output.WriteString(this.Name);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.GameAccount)) + (1 + CodedOutputStream.ComputeStringSize(this.Name));
		}

		public void MergeFrom(GameAccountLink other)
		{
			if (other == null)
			{
				goto IL_33;
			}
			goto IL_104;
			uint arg_C4_0;
			while (true)
			{
				IL_BF:
				uint num;
				switch ((num = (arg_C4_0 ^ 2447213208u)) % 9u)
				{
				case 1u:
					arg_C4_0 = (((this.gameAccount_ == null) ? 3809899326u : 2580556978u) ^ num * 1884504251u);
					continue;
				case 2u:
					goto IL_104;
				case 3u:
					this.Name = other.Name;
					arg_C4_0 = (num * 2231240636u ^ 3726397127u);
					continue;
				case 4u:
					arg_C4_0 = ((GameAccountLink.smethod_3(other.Name) == 0) ? 3256506507u : 3974170629u);
					continue;
				case 5u:
					this.gameAccount_ = new GameAccountHandle();
					arg_C4_0 = (num * 320988585u ^ 1613382628u);
					continue;
				case 6u:
					goto IL_33;
				case 7u:
					return;
				case 8u:
					this.GameAccount.MergeFrom(other.GameAccount);
					arg_C4_0 = 2828807110u;
					continue;
				}
				break;
			}
			return;
			IL_33:
			arg_C4_0 = 2343129335u;
			goto IL_BF;
			IL_104:
			arg_C4_0 = ((other.gameAccount_ == null) ? 2828807110u : 3473509060u);
			goto IL_BF;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_150:
				uint num;
				uint arg_104_0 = ((num = input.ReadTag()) != 0u) ? 1263759345u : 1026721800u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_104_0 ^ 299233212u)) % 12u)
					{
					case 1u:
						this.Name = input.ReadString();
						arg_104_0 = 312939332u;
						continue;
					case 2u:
						arg_104_0 = (((num == 18u) ? 3456330147u : 3319321697u) ^ num2 * 1098055265u);
						continue;
					case 3u:
						input.ReadMessage(this.gameAccount_);
						arg_104_0 = 663850117u;
						continue;
					case 4u:
						arg_104_0 = 1263759345u;
						continue;
					case 5u:
						arg_104_0 = (num2 * 662480298u ^ 3378426782u);
						continue;
					case 6u:
						arg_104_0 = ((this.gameAccount_ != null) ? 1407832311u : 586964199u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_104_0 = (num2 * 2548030558u ^ 178052300u);
						continue;
					case 8u:
						goto IL_150;
					case 9u:
						arg_104_0 = ((num != 10u) ? 1569440210u : 116850166u);
						continue;
					case 10u:
						arg_104_0 = (num2 * 1867220121u ^ 2965949054u);
						continue;
					case 11u:
						this.gameAccount_ = new GameAccountHandle();
						arg_104_0 = (num2 * 1928057513u ^ 1977146852u);
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
