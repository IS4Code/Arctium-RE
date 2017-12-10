using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class EchoResponse : IMessage<EchoResponse>, IEquatable<EchoResponse>, IDeepCloneable<EchoResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EchoResponse.__c __9 = new EchoResponse.__c();

			internal EchoResponse cctor>b__29_0()
			{
				return new EchoResponse();
			}
		}

		private static readonly MessageParser<EchoResponse> _parser = new MessageParser<EchoResponse>(new Func<EchoResponse>(EchoResponse.__c.__9.<.cctor>b__29_0));

		public const int TimeFieldNumber = 1;

		private ulong time_;

		public const int PayloadFieldNumber = 2;

		private ByteString payload_ = ByteString.Empty;

		public static MessageParser<EchoResponse> Parser
		{
			get
			{
				return EchoResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EchoResponse.Descriptor;
			}
		}

		public ulong Time
		{
			get
			{
				return this.time_;
			}
			set
			{
				this.time_ = value;
			}
		}

		public ByteString Payload
		{
			get
			{
				return this.payload_;
			}
			set
			{
				this.payload_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public EchoResponse()
		{
		}

		public EchoResponse(EchoResponse other) : this()
		{
			while (true)
			{
				IL_5D:
				uint arg_41_0 = 2129217044u;
				while (true)
				{
					uint num;
					switch ((num = (arg_41_0 ^ 1170019837u)) % 4u)
					{
					case 1u:
						this.time_ = other.time_;
						arg_41_0 = (num * 1735054449u ^ 3661618562u);
						continue;
					case 2u:
						this.payload_ = other.payload_;
						arg_41_0 = (num * 3619675198u ^ 1720885857u);
						continue;
					case 3u:
						goto IL_5D;
					}
					return;
				}
			}
		}

		public EchoResponse Clone()
		{
			return new EchoResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EchoResponse);
		}

		public bool Equals(EchoResponse other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 118378076) % 9)
				{
				case 0:
					return false;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					arg_72_0 = ((this.Time == other.Time) ? 341599353 : 1486273892);
					continue;
				case 5:
					goto IL_41;
				case 6:
					arg_72_0 = ((!(this.Payload != other.Payload)) ? 1315546260 : 1854012773);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_B0;
				}
				break;
			}
			return true;
			IL_41:
			arg_72_0 = 809211462;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? 40519268 : 1034180901);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Time != 0uL)
			{
				goto IL_1C;
			}
			goto IL_8F;
			uint arg_63_0;
			while (true)
			{
				IL_5E:
				uint num2;
				switch ((num2 = (arg_63_0 ^ 986755501u)) % 5u)
				{
				case 0u:
					num ^= this.Payload.GetHashCode();
					arg_63_0 = (num2 * 3132198145u ^ 2878240988u);
					continue;
				case 1u:
					num ^= this.Time.GetHashCode();
					arg_63_0 = (num2 * 2177532905u ^ 2013997508u);
					continue;
				case 2u:
					goto IL_1C;
				case 4u:
					goto IL_8F;
				}
				break;
			}
			return num;
			IL_1C:
			arg_63_0 = 1150298440u;
			goto IL_5E;
			IL_8F:
			arg_63_0 = ((this.Payload.Length == 0) ? 1492373497u : 1856432008u);
			goto IL_5E;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Time != 0uL)
			{
				goto IL_35;
			}
			goto IL_BF;
			uint arg_88_0;
			while (true)
			{
				IL_83:
				uint num;
				switch ((num = (arg_88_0 ^ 671938111u)) % 7u)
				{
				case 0u:
					output.WriteRawTag(18);
					arg_88_0 = (num * 1908935735u ^ 136287585u);
					continue;
				case 1u:
					goto IL_BF;
				case 2u:
					output.WriteRawTag(9);
					arg_88_0 = (num * 2896459660u ^ 4263582130u);
					continue;
				case 4u:
					output.WriteBytes(this.Payload);
					arg_88_0 = (num * 1179028644u ^ 1235951364u);
					continue;
				case 5u:
					goto IL_35;
				case 6u:
					output.WriteFixed64(this.Time);
					arg_88_0 = (num * 2171986711u ^ 3006320400u);
					continue;
				}
				break;
			}
			return;
			IL_35:
			arg_88_0 = 2114550505u;
			goto IL_83;
			IL_BF:
			arg_88_0 = ((this.Payload.Length != 0) ? 1381710732u : 499918984u);
			goto IL_83;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Time != 0uL)
			{
				goto IL_2D;
			}
			goto IL_82;
			uint arg_56_0;
			while (true)
			{
				IL_51:
				uint num2;
				switch ((num2 = (arg_56_0 ^ 186291250u)) % 5u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
					arg_56_0 = (num2 * 178156544u ^ 1345509848u);
					continue;
				case 2u:
					goto IL_2D;
				case 3u:
					num += 9;
					arg_56_0 = (num2 * 2921953415u ^ 524117699u);
					continue;
				case 4u:
					goto IL_82;
				}
				break;
			}
			return num;
			IL_2D:
			arg_56_0 = 1598375308u;
			goto IL_51;
			IL_82:
			arg_56_0 = ((this.Payload.Length == 0) ? 1196824024u : 181299005u);
			goto IL_51;
		}

		public void MergeFrom(EchoResponse other)
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
				switch ((num = (arg_7B_0 ^ 1790018939u)) % 7u)
				{
				case 1u:
					return;
				case 2u:
					arg_7B_0 = ((other.Payload.Length == 0) ? 415345458u : 1050200812u);
					continue;
				case 3u:
					this.Payload = other.Payload;
					arg_7B_0 = (num * 1970653424u ^ 2536128162u);
					continue;
				case 4u:
					goto IL_B2;
				case 5u:
					goto IL_30;
				case 6u:
					this.Time = other.Time;
					arg_7B_0 = (num * 2151963121u ^ 3042708259u);
					continue;
				}
				break;
			}
			return;
			IL_30:
			arg_7B_0 = 386447915u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((other.Time != 0uL) ? 973491258u : 1646003218u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_104:
				uint num;
				uint arg_C0_0 = ((num = input.ReadTag()) != 0u) ? 1011520207u : 322394009u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C0_0 ^ 899064999u)) % 10u)
					{
					case 0u:
						arg_C0_0 = 1011520207u;
						continue;
					case 1u:
						this.Payload = input.ReadBytes();
						arg_C0_0 = 961886132u;
						continue;
					case 2u:
						arg_C0_0 = ((num != 9u) ? 1357122537u : 1420313652u);
						continue;
					case 3u:
						goto IL_104;
					case 5u:
						this.Time = input.ReadFixed64();
						arg_C0_0 = 873703662u;
						continue;
					case 6u:
						arg_C0_0 = (num2 * 2533005694u ^ 3352397528u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_C0_0 = (num2 * 1209805796u ^ 1221861361u);
						continue;
					case 8u:
						arg_C0_0 = (((num != 18u) ? 4236935970u : 2676765500u) ^ num2 * 1153778379u);
						continue;
					case 9u:
						arg_C0_0 = (num2 * 349921068u ^ 3786736696u);
						continue;
					}
					return;
				}
			}
		}
	}
}
