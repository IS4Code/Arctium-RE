using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountBlobList : IMessage<GameAccountBlobList>, IEquatable<GameAccountBlobList>, IDeepCloneable<GameAccountBlobList>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountBlobList.__c __9 = new GameAccountBlobList.__c();

			internal GameAccountBlobList cctor>b__24_0()
			{
				return new GameAccountBlobList();
			}
		}

		private static readonly MessageParser<GameAccountBlobList> _parser = new MessageParser<GameAccountBlobList>(new Func<GameAccountBlobList>(GameAccountBlobList.__c.__9.<.cctor>b__24_0));

		public const int BlobFieldNumber = 1;

		private static readonly FieldCodec<GameAccountBlob> _repeated_blob_codec = FieldCodec.ForMessage<GameAccountBlob>(10u, GameAccountBlob.Parser);

		private readonly RepeatedField<GameAccountBlob> blob_ = new RepeatedField<GameAccountBlob>();

		public static MessageParser<GameAccountBlobList> Parser
		{
			get
			{
				return GameAccountBlobList._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountBlobList.Descriptor;
			}
		}

		public RepeatedField<GameAccountBlob> Blob
		{
			get
			{
				return this.blob_;
			}
		}

		public GameAccountBlobList()
		{
		}

		public GameAccountBlobList(GameAccountBlobList other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 1571608958u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 877846825u)) % 3u)
					{
					case 1u:
						this.blob_ = other.blob_.Clone();
						arg_2B_0 = (num * 407094707u ^ 3566395288u);
						continue;
					case 2u:
						goto IL_43;
					}
					return;
				}
			}
		}

		public GameAccountBlobList Clone()
		{
			return new GameAccountBlobList(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountBlobList);
		}

		public bool Equals(GameAccountBlobList other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -763604296) % 7)
				{
				case 0:
					goto IL_3E;
				case 2:
					return false;
				case 3:
					goto IL_7A;
				case 4:
					arg_48_0 = ((!this.blob_.Equals(other.blob_)) ? -1960216800 : -989969602);
					continue;
				case 5:
					return true;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -19865949;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -723113670 : -2033815455);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ GameAccountBlobList.smethod_0(this.blob_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.blob_.WriteTo(output, GameAccountBlobList._repeated_blob_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.blob_.CalculateSize(GameAccountBlobList._repeated_blob_codec);
		}

		public void MergeFrom(GameAccountBlobList other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -823558151;
			IL_08:
			switch ((arg_0D_0 ^ -1105889322) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				IL_27:
				this.blob_.Add(other.blob_);
				arg_0D_0 = -420283196;
				goto IL_08;
			case 3:
				return;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) != 0u) ? 1473645122u : 1686812574u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 412984941u)) % 6u)
					{
					case 0u:
						arg_68_0 = 1473645122u;
						continue;
					case 1u:
						arg_68_0 = ((num == 10u) ? 2002609877u : 1055136463u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_68_0 = (num2 * 9772577u ^ 1746816190u);
						continue;
					case 3u:
						goto IL_9B;
					case 4u:
						this.blob_.AddEntriesFrom(input, GameAccountBlobList._repeated_blob_codec);
						arg_68_0 = 1812463708u;
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
