using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountLicense : IMessage<AccountLicense>, IEquatable<AccountLicense>, IDeepCloneable<AccountLicense>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountLicense.__c __9 = new AccountLicense.__c();

			internal AccountLicense cctor>b__29_0()
			{
				return new AccountLicense();
			}
		}

		private static readonly MessageParser<AccountLicense> _parser = new MessageParser<AccountLicense>(new Func<AccountLicense>(AccountLicense.__c.__9.<.cctor>b__29_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public const int ExpiresFieldNumber = 2;

		private ulong expires_;

		public static MessageParser<AccountLicense> Parser
		{
			get
			{
				return AccountLicense._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountLicense.Descriptor;
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

		public ulong Expires
		{
			get
			{
				return this.expires_;
			}
			set
			{
				this.expires_ = value;
			}
		}

		public AccountLicense()
		{
		}

		public AccountLicense(AccountLicense other) : this()
		{
			this.id_ = other.id_;
			this.expires_ = other.expires_;
		}

		public AccountLicense Clone()
		{
			return new AccountLicense(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountLicense);
		}

		public bool Equals(AccountLicense other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_AB;
			int arg_6D_0;
			while (true)
			{
				IL_68:
				switch ((arg_6D_0 ^ -1180756443) % 9)
				{
				case 0:
					return false;
				case 1:
					arg_6D_0 = ((this.Id != other.Id) ? -1864786606 : -484805815);
					continue;
				case 2:
					return false;
				case 3:
					arg_6D_0 = ((this.Expires == other.Expires) ? -753025849 : -1975680182);
					continue;
				case 4:
					goto IL_AB;
				case 6:
					goto IL_15;
				case 7:
					return false;
				case 8:
					return true;
				}
				break;
			}
			return true;
			IL_15:
			arg_6D_0 = -290181201;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other != this) ? -500829014 : -726770842);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_7D:
				uint arg_61_0 = 2558093402u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_61_0 ^ 2776248913u)) % 4u)
					{
					case 0u:
						goto IL_7D;
					case 2u:
						num ^= this.Expires.GetHashCode();
						arg_61_0 = (num2 * 1600149917u ^ 1133180214u);
						continue;
					case 3u:
						num ^= this.Id.GetHashCode();
						arg_61_0 = (((this.Expires != 0uL) ? 239484435u : 1415933660u) ^ num2 * 3937902156u);
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
			output.WriteRawTag(8);
			output.WriteUInt32(this.Id);
			if (this.Expires != 0uL)
			{
				while (true)
				{
					IL_6E:
					uint arg_52_0 = 3372202503u;
					while (true)
					{
						uint num;
						switch ((num = (arg_52_0 ^ 3740367770u)) % 4u)
						{
						case 1u:
							output.WriteRawTag(16);
							arg_52_0 = (num * 1821424267u ^ 1607142198u);
							continue;
						case 2u:
							goto IL_6E;
						case 3u:
							output.WriteUInt64(this.Expires);
							arg_52_0 = (num * 2070367988u ^ 3841396834u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeUInt32Size(this.Id));
			while (true)
			{
				IL_7B:
				uint arg_5F_0 = 2920853647u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5F_0 ^ 2501156964u)) % 4u)
					{
					case 0u:
						goto IL_7B;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Expires);
						arg_5F_0 = (num2 * 982290601u ^ 2847063387u);
						continue;
					case 3u:
						arg_5F_0 = (((this.Expires != 0uL) ? 1949247706u : 1371498421u) ^ num2 * 3515010004u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AccountLicense other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 2219899486u)) % 7u)
				{
				case 0u:
					goto IL_6C;
				case 1u:
					this.Expires = other.Expires;
					arg_76_0 = (num * 670358187u ^ 3938767684u);
					continue;
				case 2u:
					goto IL_AD;
				case 3u:
					return;
				case 5u:
					arg_76_0 = ((other.Expires != 0uL) ? 2342656272u : 4024603230u);
					continue;
				case 6u:
					this.Id = other.Id;
					arg_76_0 = (num * 786352966u ^ 1053542874u);
					continue;
				}
				break;
			}
			return;
			IL_6C:
			arg_76_0 = 2299733868u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.Id != 0u) ? 3373464260u : 2530836934u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_D9:
				uint num;
				uint arg_9E_0 = ((num = input.ReadTag()) == 0u) ? 1860555628u : 1161473552u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9E_0 ^ 1270590758u)) % 8u)
					{
					case 0u:
						arg_9E_0 = (((num == 16u) ? 3297148547u : 2943091829u) ^ num2 * 2411161889u);
						continue;
					case 1u:
						goto IL_D9;
					case 3u:
						input.SkipLastField();
						arg_9E_0 = (num2 * 1274975282u ^ 2772229321u);
						continue;
					case 4u:
						this.Id = input.ReadUInt32();
						arg_9E_0 = 295517727u;
						continue;
					case 5u:
						this.Expires = input.ReadUInt64();
						arg_9E_0 = 295517727u;
						continue;
					case 6u:
						arg_9E_0 = ((num != 8u) ? 519714390u : 1934378770u);
						continue;
					case 7u:
						arg_9E_0 = 1161473552u;
						continue;
					}
					return;
				}
			}
		}
	}
}
