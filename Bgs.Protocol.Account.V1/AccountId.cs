using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountId : IMessage<AccountId>, IEquatable<AccountId>, IDeepCloneable<AccountId>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountId.__c __9 = new AccountId.__c();

			internal AccountId cctor>b__24_0()
			{
				return new AccountId();
			}
		}

		private static readonly MessageParser<AccountId> _parser = new MessageParser<AccountId>(new Func<AccountId>(AccountId.__c.__9.<.cctor>b__24_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public static MessageParser<AccountId> Parser
		{
			get
			{
				return AccountId._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountId.Descriptor;
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

		public AccountId()
		{
		}

		public AccountId(AccountId other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 1420377901u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 806724433u)) % 3u)
					{
					case 0u:
						goto IL_3E;
					case 1u:
						this.id_ = other.id_;
						arg_26_0 = (num * 722425864u ^ 3941151986u);
						continue;
					}
					return;
				}
			}
		}

		public AccountId Clone()
		{
			return new AccountId(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountId);
		}

		public bool Equals(AccountId other)
		{
			if (other == null)
			{
				goto IL_39;
			}
			goto IL_75;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ -588218370) % 7)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					goto IL_75;
				case 3:
					goto IL_39;
				case 4:
					return false;
				case 6:
					arg_43_0 = ((this.Id != other.Id) ? -883189917 : -604283066);
					continue;
				}
				break;
			}
			return true;
			IL_39:
			arg_43_0 = -584177146;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other == this) ? -1973207545 : -596683304);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			return 1 ^ this.Id.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(13);
			output.WriteFixed32(this.Id);
		}

		public int CalculateSize()
		{
			return 5;
		}

		public void MergeFrom(AccountId other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 3888823554u)) % 5u)
				{
				case 0u:
					this.Id = other.Id;
					arg_37_0 = (num * 3896966108u ^ 3781907488u);
					continue;
				case 2u:
					return;
				case 3u:
					goto IL_12;
				case 4u:
					goto IL_63;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 3725062200u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Id == 0u) ? 4103062768u : 3895832942u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_96:
				uint num;
				uint arg_63_0 = ((num = input.ReadTag()) == 0u) ? 3009266232u : 2890103984u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_63_0 ^ 3985682078u)) % 6u)
					{
					case 1u:
						goto IL_96;
					case 2u:
						input.SkipLastField();
						arg_63_0 = (num2 * 4123913881u ^ 2375664723u);
						continue;
					case 3u:
						this.Id = input.ReadFixed32();
						arg_63_0 = 3522139301u;
						continue;
					case 4u:
						arg_63_0 = ((num != 13u) ? 3526094584u : 3677347835u);
						continue;
					case 5u:
						arg_63_0 = 2890103984u;
						continue;
					}
					return;
				}
			}
		}
	}
}
