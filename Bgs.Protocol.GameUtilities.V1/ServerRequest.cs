using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class ServerRequest : IMessage<ServerRequest>, IEquatable<ServerRequest>, IDeepCloneable<ServerRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ServerRequest.__c __9 = new ServerRequest.__c();

			internal ServerRequest cctor>b__34_0()
			{
				return new ServerRequest();
			}
		}

		private static readonly MessageParser<ServerRequest> _parser = new MessageParser<ServerRequest>(new Func<ServerRequest>(ServerRequest.__c.__9.<.cctor>b__34_0));

		public const int AttributeFieldNumber = 1;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(10u, Bgs.Protocol.Attribute.Parser);

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int ProgramFieldNumber = 2;

		private uint program_;

		public const int HostFieldNumber = 3;

		private ProcessId host_;

		public static MessageParser<ServerRequest> Parser
		{
			get
			{
				return ServerRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerRequest.Descriptor;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		public ServerRequest()
		{
		}

		public ServerRequest(ServerRequest other) : this()
		{
			while (true)
			{
				IL_76:
				uint arg_5A_0 = 2040386870u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5A_0 ^ 3474747u)) % 4u)
					{
					case 1u:
						this.attribute_ = other.attribute_.Clone();
						arg_5A_0 = (num * 1765612473u ^ 4218950288u);
						continue;
					case 2u:
						this.program_ = other.program_;
						this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
						arg_5A_0 = 1182037311u;
						continue;
					case 3u:
						goto IL_76;
					}
					return;
				}
			}
		}

		public ServerRequest Clone()
		{
			return new ServerRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ServerRequest);
		}

		public bool Equals(ServerRequest other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_EA;
			int arg_A4_0;
			while (true)
			{
				IL_9F:
				switch ((arg_A4_0 ^ 929691685) % 11)
				{
				case 0:
					goto IL_9A;
				case 1:
					arg_A4_0 = ((this.Program == other.Program) ? 1480930003 : 1407039856);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					arg_A4_0 = (this.attribute_.Equals(other.attribute_) ? 1022370600 : 2116416971);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					goto IL_EA;
				case 10:
					arg_A4_0 = (ServerRequest.smethod_0(this.Host, other.Host) ? 211583313 : 1404064658);
					continue;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = 2140424844;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other != this) ? 444281671 : 351301836);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B1:
				uint arg_8D_0 = 973180549u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_8D_0 ^ 1186233418u)) % 6u)
					{
					case 0u:
						goto IL_B1;
					case 1u:
						num ^= ServerRequest.smethod_1(this.attribute_);
						arg_8D_0 = (num2 * 2532842395u ^ 1011640732u);
						continue;
					case 3u:
						arg_8D_0 = (((this.host_ == null) ? 3391534744u : 2508938192u) ^ num2 * 3130995702u);
						continue;
					case 4u:
						num ^= this.Host.GetHashCode();
						arg_8D_0 = (num2 * 1997216298u ^ 4116880258u);
						continue;
					case 5u:
						num ^= this.Program.GetHashCode();
						arg_8D_0 = (num2 * 2648156988u ^ 1011927401u);
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
			this.attribute_.WriteTo(output, ServerRequest._repeated_attribute_codec);
			while (true)
			{
				IL_BB:
				uint arg_97_0 = 1249036017u;
				while (true)
				{
					uint num;
					switch ((num = (arg_97_0 ^ 132765987u)) % 6u)
					{
					case 0u:
						output.WriteRawTag(26);
						arg_97_0 = (num * 3710208701u ^ 1633098242u);
						continue;
					case 1u:
						output.WriteFixed32(this.Program);
						arg_97_0 = (((this.host_ != null) ? 3930212206u : 2240230596u) ^ num * 2195330277u);
						continue;
					case 2u:
						output.WriteRawTag(21);
						arg_97_0 = (num * 3241844311u ^ 2670050834u);
						continue;
					case 3u:
						goto IL_BB;
					case 5u:
						output.WriteMessage(this.Host);
						arg_97_0 = (num * 2814829955u ^ 3670406882u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + this.attribute_.CalculateSize(ServerRequest._repeated_attribute_codec);
			while (true)
			{
				IL_82:
				uint arg_66_0 = 816438206u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_66_0 ^ 206481579u)) % 4u)
					{
					case 1u:
						num += 5;
						arg_66_0 = (((this.host_ != null) ? 1254997895u : 1272463133u) ^ num2 * 1386868558u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
						arg_66_0 = (num2 * 3750314313u ^ 1656614753u);
						continue;
					case 3u:
						goto IL_82;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ServerRequest other)
		{
			if (other == null)
			{
				goto IL_9B;
			}
			goto IL_FF;
			uint arg_BF_0;
			while (true)
			{
				IL_BA:
				uint num;
				switch ((num = (arg_BF_0 ^ 3919815011u)) % 9u)
				{
				case 0u:
					this.host_ = new ProcessId();
					arg_BF_0 = (num * 2095367369u ^ 2174696444u);
					continue;
				case 2u:
					goto IL_FF;
				case 3u:
					goto IL_9B;
				case 4u:
					arg_BF_0 = ((other.host_ == null) ? 3731713364u : 3299074489u);
					continue;
				case 5u:
					this.Host.MergeFrom(other.Host);
					arg_BF_0 = 3731713364u;
					continue;
				case 6u:
					arg_BF_0 = (((this.host_ != null) ? 1325735820u : 1283186515u) ^ num * 1247460596u);
					continue;
				case 7u:
					this.Program = other.Program;
					arg_BF_0 = (num * 1332821086u ^ 1395504469u);
					continue;
				case 8u:
					return;
				}
				break;
			}
			return;
			IL_9B:
			arg_BF_0 = 3518075723u;
			goto IL_BA;
			IL_FF:
			this.attribute_.Add(other.attribute_);
			arg_BF_0 = ((other.Program == 0u) ? 2457106667u : 3560826674u);
			goto IL_BA;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_19F:
				uint num;
				uint arg_14B_0 = ((num = input.ReadTag()) == 0u) ? 1531611307u : 16953550u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_14B_0 ^ 1622673014u)) % 14u)
					{
					case 0u:
						arg_14B_0 = (num2 * 2388410718u ^ 960140366u);
						continue;
					case 1u:
						arg_14B_0 = (((num != 21u) ? 1825100456u : 2033089830u) ^ num2 * 197161075u);
						continue;
					case 2u:
						arg_14B_0 = ((num != 10u) ? 79902305u : 1630817975u);
						continue;
					case 3u:
						arg_14B_0 = ((this.host_ == null) ? 2111428758u : 30829095u);
						continue;
					case 4u:
						goto IL_19F;
					case 5u:
						this.Program = input.ReadFixed32();
						arg_14B_0 = 1161756426u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_14B_0 = (num2 * 13055048u ^ 125023914u);
						continue;
					case 7u:
						arg_14B_0 = (((num == 26u) ? 1279808236u : 154719259u) ^ num2 * 833785077u);
						continue;
					case 8u:
						arg_14B_0 = 16953550u;
						continue;
					case 10u:
						arg_14B_0 = (num2 * 1895685272u ^ 4268126250u);
						continue;
					case 11u:
						input.ReadMessage(this.host_);
						arg_14B_0 = 1161756426u;
						continue;
					case 12u:
						this.host_ = new ProcessId();
						arg_14B_0 = (num2 * 1494734443u ^ 4286647687u);
						continue;
					case 13u:
						this.attribute_.AddEntriesFrom(input, ServerRequest._repeated_attribute_codec);
						arg_14B_0 = 1173929608u;
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
