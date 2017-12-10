using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class BoundService : IMessage<BoundService>, IEquatable<BoundService>, IDeepCloneable<BoundService>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BoundService.__c __9 = new BoundService.__c();

			internal BoundService cctor>b__29_0()
			{
				return new BoundService();
			}
		}

		private static readonly MessageParser<BoundService> _parser = new MessageParser<BoundService>(new Func<BoundService>(BoundService.__c.__9.<.cctor>b__29_0));

		public const int HashFieldNumber = 1;

		private uint hash_;

		public const int IdFieldNumber = 2;

		private uint id_;

		public static MessageParser<BoundService> Parser
		{
			get
			{
				return BoundService._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoundService.Descriptor;
			}
		}

		public uint Hash
		{
			get
			{
				return this.hash_;
			}
			set
			{
				this.hash_ = value;
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

		public BoundService()
		{
		}

		public BoundService(BoundService other) : this()
		{
			this.hash_ = other.hash_;
			this.id_ = other.id_;
		}

		public BoundService Clone()
		{
			return new BoundService(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BoundService);
		}

		public bool Equals(BoundService other)
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
				switch ((arg_6D_0 ^ -685027930) % 9)
				{
				case 0:
					arg_6D_0 = ((this.Id != other.Id) ? -2077502264 : -1452285885);
					continue;
				case 1:
					return false;
				case 3:
					arg_6D_0 = ((this.Hash != other.Hash) ? -490203966 : -12120435);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					goto IL_15;
				case 7:
					return true;
				case 8:
					goto IL_AB;
				}
				break;
			}
			return true;
			IL_15:
			arg_6D_0 = -1254148950;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other != this) ? -1563571498 : -709629016);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			return 1 ^ this.Hash.GetHashCode() ^ this.Id.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(13);
			while (true)
			{
				IL_7A:
				uint arg_5A_0 = 2856121441u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5A_0 ^ 3332188710u)) % 5u)
					{
					case 0u:
						goto IL_7A;
					case 1u:
						output.WriteRawTag(16);
						arg_5A_0 = (num * 2958493769u ^ 548844073u);
						continue;
					case 2u:
						output.WriteFixed32(this.Hash);
						arg_5A_0 = (num * 847207614u ^ 1578644832u);
						continue;
					case 3u:
						output.WriteUInt32(this.Id);
						arg_5A_0 = (num * 1166415623u ^ 3886748304u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 5 + (1 + CodedOutputStream.ComputeUInt32Size(this.Id));
		}

		public void MergeFrom(BoundService other)
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
				switch ((num = (arg_76_0 ^ 544624223u)) % 7u)
				{
				case 0u:
					goto IL_6C;
				case 1u:
					this.Id = other.Id;
					arg_76_0 = (num * 509238429u ^ 979555725u);
					continue;
				case 3u:
					this.Hash = other.Hash;
					arg_76_0 = (num * 1480263588u ^ 1664441488u);
					continue;
				case 4u:
					return;
				case 5u:
					arg_76_0 = ((other.Id != 0u) ? 304426085u : 313966623u);
					continue;
				case 6u:
					goto IL_AD;
				}
				break;
			}
			return;
			IL_6C:
			arg_76_0 = 397989840u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.Hash == 0u) ? 205754316u : 354649824u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_EE:
				uint num;
				uint arg_AE_0 = ((num = input.ReadTag()) != 0u) ? 1520448950u : 592013579u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AE_0 ^ 1147502709u)) % 9u)
					{
					case 0u:
						arg_AE_0 = (num2 * 2524167239u ^ 2661722260u);
						continue;
					case 1u:
						arg_AE_0 = (((num != 16u) ? 2851969788u : 3199013322u) ^ num2 * 1308703155u);
						continue;
					case 3u:
						goto IL_EE;
					case 4u:
						arg_AE_0 = 1520448950u;
						continue;
					case 5u:
						this.Id = input.ReadUInt32();
						arg_AE_0 = 477278463u;
						continue;
					case 6u:
						arg_AE_0 = ((num == 13u) ? 1654802669u : 173280932u);
						continue;
					case 7u:
						this.Hash = input.ReadFixed32();
						arg_AE_0 = 477278463u;
						continue;
					case 8u:
						input.SkipLastField();
						arg_AE_0 = (num2 * 1391919479u ^ 900836046u);
						continue;
					}
					return;
				}
			}
		}
	}
}
