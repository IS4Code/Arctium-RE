using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengeCancelledRequest : IMessage<ChallengeCancelledRequest>, IEquatable<ChallengeCancelledRequest>, IDeepCloneable<ChallengeCancelledRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengeCancelledRequest.__c __9 = new ChallengeCancelledRequest.__c();

			internal ChallengeCancelledRequest cctor>b__24_0()
			{
				return new ChallengeCancelledRequest();
			}
		}

		private static readonly MessageParser<ChallengeCancelledRequest> _parser = new MessageParser<ChallengeCancelledRequest>(new Func<ChallengeCancelledRequest>(ChallengeCancelledRequest.__c.__9.<.cctor>b__24_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public static MessageParser<ChallengeCancelledRequest> Parser
		{
			get
			{
				return ChallengeCancelledRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeCancelledRequest.Descriptor;
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

		public ChallengeCancelledRequest()
		{
		}

		public ChallengeCancelledRequest(ChallengeCancelledRequest other) : this()
		{
			this.id_ = other.id_;
		}

		public ChallengeCancelledRequest Clone()
		{
			return new ChallengeCancelledRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeCancelledRequest);
		}

		public bool Equals(ChallengeCancelledRequest other)
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
				switch ((arg_43_0 ^ 241104865) % 7)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					goto IL_75;
				case 3:
					goto IL_39;
				case 5:
					return false;
				case 6:
					arg_43_0 = ((this.Id == other.Id) ? 1131993302 : 3147858);
					continue;
				}
				break;
			}
			return true;
			IL_39:
			arg_43_0 = 951234237;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other == this) ? 889757262 : 204800317);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 2184797656u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_50_0 ^ 3486659821u)) % 4u)
					{
					case 1u:
						arg_50_0 = (((this.Id == 0u) ? 1849769246u : 1909448913u) ^ num2 * 85240847u);
						continue;
					case 2u:
						goto IL_6C;
					case 3u:
						num ^= this.Id.GetHashCode();
						arg_50_0 = (num2 * 210169236u ^ 2367775369u);
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
			if (this.Id != 0u)
			{
				while (true)
				{
					IL_5A:
					uint arg_3E_0 = 1262283169u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3E_0 ^ 1036645472u)) % 4u)
						{
						case 1u:
							output.WriteRawTag(8);
							arg_3E_0 = (num * 2689758659u ^ 3637868316u);
							continue;
						case 2u:
							goto IL_5A;
						case 3u:
							output.WriteUInt32(this.Id);
							arg_3E_0 = (num * 3942174684u ^ 119684624u);
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
			int num = 0;
			while (true)
			{
				IL_6B:
				uint arg_4F_0 = 3875990598u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4F_0 ^ 4222720057u)) % 4u)
					{
					case 0u:
						goto IL_6B;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
						arg_4F_0 = (num2 * 2721795132u ^ 840464028u);
						continue;
					case 3u:
						arg_4F_0 = (((this.Id != 0u) ? 2631674348u : 2454307411u) ^ num2 * 2941815881u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ChallengeCancelledRequest other)
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
				switch ((num = (arg_37_0 ^ 4203355425u)) % 5u)
				{
				case 0u:
					goto IL_63;
				case 1u:
					return;
				case 2u:
					this.Id = other.Id;
					arg_37_0 = (num * 3365294501u ^ 1889284660u);
					continue;
				case 4u:
					goto IL_12;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 3116661530u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Id != 0u) ? 3501745758u : 2962945519u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A8:
				uint num;
				uint arg_71_0 = ((num = input.ReadTag()) == 0u) ? 2934517032u : 3293995319u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_71_0 ^ 2403111718u)) % 7u)
					{
					case 0u:
						input.SkipLastField();
						arg_71_0 = (num2 * 615449007u ^ 4002120210u);
						continue;
					case 2u:
						this.Id = input.ReadUInt32();
						arg_71_0 = 2915165911u;
						continue;
					case 3u:
						goto IL_A8;
					case 4u:
						arg_71_0 = 3293995319u;
						continue;
					case 5u:
						arg_71_0 = ((num != 8u) ? 3389504443u : 2323852305u);
						continue;
					case 6u:
						arg_71_0 = (num2 * 2543446426u ^ 3439726625u);
						continue;
					}
					return;
				}
			}
		}
	}
}
