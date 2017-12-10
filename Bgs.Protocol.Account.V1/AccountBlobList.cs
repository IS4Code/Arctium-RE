using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AccountBlobList : IMessage<AccountBlobList>, IEquatable<AccountBlobList>, IDeepCloneable<AccountBlobList>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AccountBlobList.__c __9 = new AccountBlobList.__c();

			internal AccountBlobList cctor>b__24_0()
			{
				return new AccountBlobList();
			}
		}

		private static readonly MessageParser<AccountBlobList> _parser = new MessageParser<AccountBlobList>(new Func<AccountBlobList>(AccountBlobList.__c.__9.<.cctor>b__24_0));

		public const int BlobFieldNumber = 1;

		private static readonly FieldCodec<AccountBlob> _repeated_blob_codec;

		private readonly RepeatedField<AccountBlob> blob_ = new RepeatedField<AccountBlob>();

		public static MessageParser<AccountBlobList> Parser
		{
			get
			{
				return AccountBlobList._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountBlobList.Descriptor;
			}
		}

		public RepeatedField<AccountBlob> Blob
		{
			get
			{
				return this.blob_;
			}
		}

		public AccountBlobList()
		{
		}

		public AccountBlobList(AccountBlobList other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 2385764343u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 4181721037u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 2u:
						this.blob_ = other.blob_.Clone();
						arg_2B_0 = (num * 2868982528u ^ 2844640007u);
						continue;
					}
					return;
				}
			}
		}

		public AccountBlobList Clone()
		{
			return new AccountBlobList(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AccountBlobList);
		}

		public bool Equals(AccountBlobList other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 58012458) % 7)
				{
				case 1:
					return false;
				case 2:
					arg_48_0 = ((!this.blob_.Equals(other.blob_)) ? 1058023751 : 105884064);
					continue;
				case 3:
					goto IL_7A;
				case 4:
					goto IL_12;
				case 5:
					return true;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 268651382;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 199223765 : 1010067029);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ AccountBlobList.smethod_0(this.blob_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.blob_.WriteTo(output, AccountBlobList._repeated_blob_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.blob_.CalculateSize(AccountBlobList._repeated_blob_codec);
		}

		public void MergeFrom(AccountBlobList other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -1623131470;
			IL_08:
			switch ((arg_0D_0 ^ -517914749) % 4)
			{
			case 1:
				return;
			case 2:
				goto IL_03;
			case 3:
				IL_27:
				this.blob_.Add(other.blob_);
				arg_0D_0 = -1093195945;
				goto IL_08;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 1239801988u : 342473591u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 251472072u)) % 7u)
					{
					case 0u:
						this.blob_.AddEntriesFrom(input, AccountBlobList._repeated_blob_codec);
						arg_77_0 = 172750721u;
						continue;
					case 1u:
						arg_77_0 = ((num != 10u) ? 803060006u : 877210794u);
						continue;
					case 3u:
						goto IL_AE;
					case 4u:
						arg_77_0 = 1239801988u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_77_0 = (num2 * 2219790825u ^ 1860858599u);
						continue;
					case 6u:
						arg_77_0 = (num2 * 467369281u ^ 328460656u);
						continue;
					}
					return;
				}
			}
		}

		static AccountBlobList()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 242133910u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 528168004u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 2u:
						AccountBlobList._repeated_blob_codec = FieldCodec.ForMessage<AccountBlob>(10u, AccountBlob.Parser);
						arg_3F_0 = (num * 35462412u ^ 3436232208u);
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
