using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountCredential : IMessage<AccountCredential>, IEquatable<AccountCredential>, IDeepCloneable<AccountCredential>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountCredential.__c __9 = new AccountCredential.__c();

			internal AccountCredential cctor>b__29_0()
			{
				return new AccountCredential();
			}
		}

		private static readonly MessageParser<AccountCredential> _parser = new MessageParser<AccountCredential>(new Func<AccountCredential>(AccountCredential.__c.__9.<.cctor>b__29_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public const int DataFieldNumber = 2;

		private ByteString data_ = ByteString.Empty;

		public static MessageParser<AccountCredential> Parser
		{
			get
			{
				return AccountCredential._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountCredential.Descriptor;
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

		public ByteString Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public AccountCredential()
		{
		}

		public AccountCredential(AccountCredential other) : this()
		{
			this.id_ = other.id_;
			this.data_ = other.data_;
		}

		public AccountCredential Clone()
		{
			return new AccountCredential(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountCredential);
		}

		public bool Equals(AccountCredential other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 1301330652) % 9)
				{
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					arg_72_0 = ((!(this.Data != other.Data)) ? 463586078 : 578019829);
					continue;
				case 4:
					arg_72_0 = ((this.Id != other.Id) ? 1990367688 : 1201850521);
					continue;
				case 5:
					return false;
				case 6:
					goto IL_B0;
				case 7:
					goto IL_15;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 1505792619;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? 138969868 : 487249605);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ this.Id.GetHashCode();
			while (true)
			{
				IL_7F:
				uint arg_63_0 = 2762091007u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_63_0 ^ 2981472420u)) % 4u)
					{
					case 0u:
						num ^= this.Data.GetHashCode();
						arg_63_0 = (num2 * 3903132381u ^ 3866303001u);
						continue;
					case 2u:
						goto IL_7F;
					case 3u:
						arg_63_0 = (((this.Data.Length != 0) ? 486216914u : 823889471u) ^ num2 * 3369690278u);
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
			while (true)
			{
				IL_AE:
				uint arg_8A_0 = 4131202870u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8A_0 ^ 3297975006u)) % 6u)
					{
					case 0u:
						arg_8A_0 = (((this.Data.Length == 0) ? 2067490566u : 848297299u) ^ num * 2805652259u);
						continue;
					case 1u:
						output.WriteBytes(this.Data);
						arg_8A_0 = (num * 1633866392u ^ 1840690462u);
						continue;
					case 3u:
						output.WriteRawTag(18);
						arg_8A_0 = (num * 2343186053u ^ 1434077856u);
						continue;
					case 4u:
						output.WriteUInt32(this.Id);
						arg_8A_0 = (num * 2509878102u ^ 2108892030u);
						continue;
					case 5u:
						goto IL_AE;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeUInt32Size(this.Id));
			if (this.Data.Length != 0)
			{
				while (true)
				{
					IL_5B:
					uint arg_43_0 = 3366715382u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_43_0 ^ 3788487584u)) % 3u)
						{
						case 0u:
							goto IL_5B;
						case 1u:
							num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
							arg_43_0 = (num2 * 315193483u ^ 3763364306u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(AccountCredential other)
		{
			if (other == null)
			{
				goto IL_30;
			}
			goto IL_B2;
			uint arg_7B_0;
			while (true)
			{
				IL_76:
				uint num;
				switch ((num = (arg_7B_0 ^ 3092555228u)) % 7u)
				{
				case 0u:
					this.Id = other.Id;
					arg_7B_0 = (num * 2194060406u ^ 838332066u);
					continue;
				case 1u:
					goto IL_B2;
				case 2u:
					arg_7B_0 = ((other.Data.Length != 0) ? 3089151992u : 2701767299u);
					continue;
				case 3u:
					goto IL_30;
				case 4u:
					this.Data = other.Data;
					arg_7B_0 = (num * 55436372u ^ 3323703635u);
					continue;
				case 5u:
					return;
				}
				break;
			}
			return;
			IL_30:
			arg_7B_0 = 3231267595u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((other.Id == 0u) ? 3202307292u : 2411016465u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_D9:
				uint num;
				uint arg_9E_0 = ((num = input.ReadTag()) == 0u) ? 1783579315u : 127002473u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9E_0 ^ 1166373552u)) % 8u)
					{
					case 0u:
						this.Data = input.ReadBytes();
						arg_9E_0 = 1293149237u;
						continue;
					case 1u:
						arg_9E_0 = ((num != 8u) ? 1325952615u : 593959724u);
						continue;
					case 2u:
						arg_9E_0 = 127002473u;
						continue;
					case 4u:
						this.Id = input.ReadUInt32();
						arg_9E_0 = 1293149237u;
						continue;
					case 5u:
						goto IL_D9;
					case 6u:
						input.SkipLastField();
						arg_9E_0 = (num2 * 3366742753u ^ 3990586243u);
						continue;
					case 7u:
						arg_9E_0 = (((num == 18u) ? 3316239684u : 3870816282u) ^ num2 * 1714827396u);
						continue;
					}
					return;
				}
			}
		}
	}
}
