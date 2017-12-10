using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class EchoRequest : IMessage<EchoRequest>, IEquatable<EchoRequest>, IDeepCloneable<EchoRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EchoRequest.__c __9 = new EchoRequest.__c();

			internal EchoRequest cctor>b__34_0()
			{
				return new EchoRequest();
			}
		}

		private static readonly MessageParser<EchoRequest> _parser = new MessageParser<EchoRequest>(new Func<EchoRequest>(EchoRequest.__c.__9.<.cctor>b__34_0));

		public const int TimeFieldNumber = 1;

		private ulong time_;

		public const int NetworkOnlyFieldNumber = 2;

		private bool networkOnly_;

		public const int PayloadFieldNumber = 3;

		private ByteString payload_ = ByteString.Empty;

		public static MessageParser<EchoRequest> Parser
		{
			get
			{
				return EchoRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EchoRequest.Descriptor;
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

		public bool NetworkOnly
		{
			get
			{
				return this.networkOnly_;
			}
			set
			{
				this.networkOnly_ = value;
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
				this.payload_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public EchoRequest()
		{
		}

		public EchoRequest(EchoRequest other) : this()
		{
			this.time_ = other.time_;
			this.networkOnly_ = other.networkOnly_;
			this.payload_ = other.payload_;
		}

		public EchoRequest Clone()
		{
			return new EchoRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EchoRequest);
		}

		public bool Equals(EchoRequest other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_DF;
			int arg_99_0;
			while (true)
			{
				IL_94:
				switch ((arg_99_0 ^ -86601140) % 11)
				{
				case 0:
					return false;
				case 2:
					arg_99_0 = ((!(this.Payload != other.Payload)) ? -1496505094 : -660761723);
					continue;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_99_0 = ((this.NetworkOnly != other.NetworkOnly) ? -1204440064 : -362744824);
					continue;
				case 7:
					arg_99_0 = ((this.Time != other.Time) ? -978869173 : -874239043);
					continue;
				case 8:
					return false;
				case 9:
					goto IL_15;
				case 10:
					goto IL_DF;
				}
				break;
			}
			return true;
			IL_15:
			arg_99_0 = -1021715310;
			goto IL_94;
			IL_DF:
			arg_99_0 = ((other == this) ? -1878058905 : -819457030);
			goto IL_94;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_109:
				uint arg_DD_0 = 2742806335u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_DD_0 ^ 3318800813u)) % 8u)
					{
					case 0u:
						goto IL_109;
					case 1u:
						arg_DD_0 = ((this.Payload.Length == 0) ? 3065420483u : 2455775334u);
						continue;
					case 2u:
						arg_DD_0 = (((this.Time != 0uL) ? 1296366448u : 2052750729u) ^ num2 * 578801108u);
						continue;
					case 3u:
						num ^= this.Payload.GetHashCode();
						arg_DD_0 = (num2 * 1853651204u ^ 1355710703u);
						continue;
					case 4u:
						arg_DD_0 = (this.NetworkOnly ? 3239212954u : 3400639428u);
						continue;
					case 5u:
						num ^= this.Time.GetHashCode();
						arg_DD_0 = (num2 * 3174483862u ^ 1984492911u);
						continue;
					case 7u:
						num ^= this.NetworkOnly.GetHashCode();
						arg_DD_0 = (num2 * 3678027102u ^ 4161134838u);
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
			if (this.Time != 0uL)
			{
				goto IL_1D;
			}
			goto IL_11A;
			uint arg_DA_0;
			while (true)
			{
				IL_D5:
				uint num;
				switch ((num = (arg_DA_0 ^ 2369891926u)) % 9u)
				{
				case 0u:
					output.WriteRawTag(16);
					output.WriteBool(this.NetworkOnly);
					arg_DA_0 = (num * 2328731504u ^ 51158440u);
					continue;
				case 1u:
					output.WriteRawTag(26);
					arg_DA_0 = (num * 2577548374u ^ 1406499449u);
					continue;
				case 2u:
					output.WriteFixed64(this.Time);
					arg_DA_0 = (num * 2573797471u ^ 3390794940u);
					continue;
				case 4u:
					output.WriteBytes(this.Payload);
					arg_DA_0 = (num * 1378202675u ^ 3864943733u);
					continue;
				case 5u:
					output.WriteRawTag(9);
					arg_DA_0 = (num * 45590544u ^ 3355449483u);
					continue;
				case 6u:
					arg_DA_0 = ((this.Payload.Length == 0) ? 3226059858u : 2819865805u);
					continue;
				case 7u:
					goto IL_11A;
				case 8u:
					goto IL_1D;
				}
				break;
			}
			return;
			IL_1D:
			arg_DA_0 = 3434816539u;
			goto IL_D5;
			IL_11A:
			arg_DA_0 = ((!this.NetworkOnly) ? 2771003368u : 4209395242u);
			goto IL_D5;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_EF:
				uint arg_C3_0 = 48651325u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C3_0 ^ 1487710768u)) % 8u)
					{
					case 0u:
						arg_C3_0 = (this.NetworkOnly ? 340409030u : 1206308055u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
						arg_C3_0 = (num2 * 863509632u ^ 1330359785u);
						continue;
					case 3u:
						goto IL_EF;
					case 4u:
						num += 9;
						arg_C3_0 = (num2 * 2714362176u ^ 132992912u);
						continue;
					case 5u:
						arg_C3_0 = (((this.Time != 0uL) ? 2079520242u : 1095932862u) ^ num2 * 2162987622u);
						continue;
					case 6u:
						num += 2;
						arg_C3_0 = (num2 * 1005998740u ^ 167270127u);
						continue;
					case 7u:
						arg_C3_0 = ((this.Payload.Length == 0) ? 85520617u : 455918266u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(EchoRequest other)
		{
			if (other == null)
			{
				goto IL_59;
			}
			goto IL_FA;
			uint arg_BA_0;
			while (true)
			{
				IL_B5:
				uint num;
				switch ((num = (arg_BA_0 ^ 388129929u)) % 9u)
				{
				case 0u:
					this.Payload = other.Payload;
					arg_BA_0 = (num * 2014430499u ^ 791063982u);
					continue;
				case 1u:
					arg_BA_0 = ((!other.NetworkOnly) ? 1009707794u : 1512697668u);
					continue;
				case 2u:
					this.Time = other.Time;
					arg_BA_0 = (num * 3123831087u ^ 4113661539u);
					continue;
				case 3u:
					return;
				case 4u:
					goto IL_FA;
				case 5u:
					goto IL_59;
				case 6u:
					this.NetworkOnly = other.NetworkOnly;
					arg_BA_0 = (num * 576467681u ^ 1278280255u);
					continue;
				case 8u:
					arg_BA_0 = ((other.Payload.Length == 0) ? 1779730331u : 367083598u);
					continue;
				}
				break;
			}
			return;
			IL_59:
			arg_BA_0 = 34636884u;
			goto IL_B5;
			IL_FA:
			arg_BA_0 = ((other.Time == 0uL) ? 340478398u : 772479034u);
			goto IL_B5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_14E:
				uint num;
				uint arg_102_0 = ((num = input.ReadTag()) != 0u) ? 1696349830u : 903281157u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_102_0 ^ 51017516u)) % 12u)
					{
					case 0u:
						arg_102_0 = (num2 * 2997527282u ^ 612303853u);
						continue;
					case 1u:
						arg_102_0 = (((num != 26u) ? 745249153u : 1673626474u) ^ num2 * 2765996049u);
						continue;
					case 2u:
						arg_102_0 = (((num != 16u) ? 517702679u : 1134912561u) ^ num2 * 1009225847u);
						continue;
					case 3u:
						this.Payload = input.ReadBytes();
						arg_102_0 = 747996333u;
						continue;
					case 4u:
						arg_102_0 = (num2 * 4002428173u ^ 3511105957u);
						continue;
					case 5u:
						goto IL_14E;
					case 6u:
						arg_102_0 = 1696349830u;
						continue;
					case 7u:
						this.NetworkOnly = input.ReadBool();
						arg_102_0 = 29192076u;
						continue;
					case 8u:
						input.SkipLastField();
						arg_102_0 = (num2 * 3488423075u ^ 3955419457u);
						continue;
					case 10u:
						arg_102_0 = ((num == 9u) ? 1962422171u : 1341186274u);
						continue;
					case 11u:
						this.Time = input.ReadFixed64();
						arg_102_0 = 932644868u;
						continue;
					}
					return;
				}
			}
		}
	}
}
