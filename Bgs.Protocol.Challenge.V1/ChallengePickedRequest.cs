using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengePickedRequest : IMessage<ChallengePickedRequest>, IEquatable<ChallengePickedRequest>, IDeepCloneable<ChallengePickedRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengePickedRequest.__c __9 = new ChallengePickedRequest.__c();

			internal ChallengePickedRequest cctor>b__34_0()
			{
				return new ChallengePickedRequest();
			}
		}

		private static readonly MessageParser<ChallengePickedRequest> _parser = new MessageParser<ChallengePickedRequest>(new Func<ChallengePickedRequest>(ChallengePickedRequest.__c.__9.<.cctor>b__34_0));

		public const int ChallengeFieldNumber = 1;

		private uint challenge_;

		public const int IdFieldNumber = 2;

		private uint id_;

		public const int NewChallengeProtocolFieldNumber = 3;

		private bool newChallengeProtocol_;

		public static MessageParser<ChallengePickedRequest> Parser
		{
			get
			{
				return ChallengePickedRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengePickedRequest.Descriptor;
			}
		}

		public uint Challenge
		{
			get
			{
				return this.challenge_;
			}
			set
			{
				this.challenge_ = value;
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

		public bool NewChallengeProtocol
		{
			get
			{
				return this.newChallengeProtocol_;
			}
			set
			{
				this.newChallengeProtocol_ = value;
			}
		}

		public ChallengePickedRequest()
		{
		}

		public ChallengePickedRequest(ChallengePickedRequest other) : this()
		{
			while (true)
			{
				IL_7C:
				uint arg_5C_0 = 787340036u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5C_0 ^ 1617751084u)) % 5u)
					{
					case 0u:
						goto IL_7C;
					case 1u:
						this.newChallengeProtocol_ = other.newChallengeProtocol_;
						arg_5C_0 = (num * 570324640u ^ 497551312u);
						continue;
					case 2u:
						this.challenge_ = other.challenge_;
						arg_5C_0 = (num * 3750916252u ^ 2566803220u);
						continue;
					case 3u:
						this.id_ = other.id_;
						arg_5C_0 = (num * 2731123400u ^ 293150685u);
						continue;
					}
					return;
				}
			}
		}

		public ChallengePickedRequest Clone()
		{
			return new ChallengePickedRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengePickedRequest);
		}

		public bool Equals(ChallengePickedRequest other)
		{
			if (other == null)
			{
				goto IL_63;
			}
			goto IL_DA;
			int arg_94_0;
			while (true)
			{
				IL_8F:
				switch ((arg_94_0 ^ -264335838) % 11)
				{
				case 1:
					arg_94_0 = ((this.NewChallengeProtocol == other.NewChallengeProtocol) ? -952741062 : -1106113147);
					continue;
				case 2:
					goto IL_63;
				case 3:
					goto IL_DA;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					arg_94_0 = ((this.Id == other.Id) ? -1304172160 : -408836485);
					continue;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					arg_94_0 = ((this.Challenge != other.Challenge) ? -1203227793 : -1378027675);
					continue;
				}
				break;
			}
			return true;
			IL_63:
			arg_94_0 = -1530457424;
			goto IL_8F;
			IL_DA:
			arg_94_0 = ((other != this) ? -698525770 : -875042840);
			goto IL_8F;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ this.Challenge.GetHashCode();
			while (true)
			{
				IL_C9:
				uint arg_A5_0 = 4221044449u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A5_0 ^ 2293274804u)) % 6u)
					{
					case 0u:
						goto IL_C9;
					case 1u:
						arg_A5_0 = (this.NewChallengeProtocol ? 3723508124u : 3538844487u);
						continue;
					case 2u:
						num ^= this.NewChallengeProtocol.GetHashCode();
						arg_A5_0 = (num2 * 3158106267u ^ 2188044415u);
						continue;
					case 4u:
						num ^= this.Id.GetHashCode();
						arg_A5_0 = (num2 * 3399122676u ^ 2099222533u);
						continue;
					case 5u:
						arg_A5_0 = (((this.Id == 0u) ? 3842145852u : 4185795405u) ^ num2 * 4258868053u);
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
			output.WriteRawTag(13);
			output.WriteFixed32(this.Challenge);
			if (this.Id != 0u)
			{
				goto IL_92;
			}
			goto IL_D3;
			uint arg_9C_0;
			while (true)
			{
				IL_97:
				uint num;
				switch ((num = (arg_9C_0 ^ 805749889u)) % 7u)
				{
				case 0u:
					goto IL_92;
				case 1u:
					goto IL_D3;
				case 2u:
					output.WriteRawTag(16);
					arg_9C_0 = (num * 2504931664u ^ 4246127014u);
					continue;
				case 4u:
					output.WriteUInt32(this.Id);
					arg_9C_0 = (num * 3667973881u ^ 3173587399u);
					continue;
				case 5u:
					output.WriteBool(this.NewChallengeProtocol);
					arg_9C_0 = (num * 1545494825u ^ 571139115u);
					continue;
				case 6u:
					output.WriteRawTag(24);
					arg_9C_0 = (num * 4118567838u ^ 133284570u);
					continue;
				}
				break;
			}
			return;
			IL_92:
			arg_9C_0 = 659310854u;
			goto IL_97;
			IL_D3:
			arg_9C_0 = (this.NewChallengeProtocol ? 282409239u : 1542182412u);
			goto IL_97;
		}

		public int CalculateSize()
		{
			int num = 5;
			while (true)
			{
				IL_AC:
				uint arg_88_0 = 864615046u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_88_0 ^ 871524347u)) % 6u)
					{
					case 0u:
						num += 2;
						arg_88_0 = (num2 * 3810590843u ^ 978475054u);
						continue;
					case 2u:
						goto IL_AC;
					case 3u:
						arg_88_0 = ((!this.NewChallengeProtocol) ? 1261028114u : 1845622031u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
						arg_88_0 = (num2 * 2841275697u ^ 1082342688u);
						continue;
					case 5u:
						arg_88_0 = (((this.Id != 0u) ? 1283226664u : 116091347u) ^ num2 * 1093935097u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ChallengePickedRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_F8;
			uint arg_B8_0;
			while (true)
			{
				IL_B3:
				uint num;
				switch ((num = (arg_B8_0 ^ 1071860674u)) % 9u)
				{
				case 0u:
					this.NewChallengeProtocol = other.NewChallengeProtocol;
					arg_B8_0 = (num * 1534508073u ^ 3482021823u);
					continue;
				case 1u:
					this.Challenge = other.Challenge;
					arg_B8_0 = (num * 1131901515u ^ 379830316u);
					continue;
				case 2u:
					goto IL_F8;
				case 3u:
					this.Id = other.Id;
					arg_B8_0 = (num * 1205843361u ^ 3234400259u);
					continue;
				case 4u:
					arg_B8_0 = (other.NewChallengeProtocol ? 234056625u : 2111883732u);
					continue;
				case 5u:
					return;
				case 6u:
					arg_B8_0 = ((other.Id == 0u) ? 1244229953u : 1986594240u);
					continue;
				case 7u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_B8_0 = 1666134333u;
			goto IL_B3;
			IL_F8:
			arg_B8_0 = ((other.Challenge != 0u) ? 645368211u : 1432371095u);
			goto IL_B3;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_164:
				uint num;
				uint arg_114_0 = ((num = input.ReadTag()) != 0u) ? 2049655477u : 299789529u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_114_0 ^ 1257397966u)) % 13u)
					{
					case 0u:
						input.SkipLastField();
						arg_114_0 = (num2 * 1239694717u ^ 3630768661u);
						continue;
					case 1u:
						arg_114_0 = (((num != 16u) ? 2861858533u : 3139863517u) ^ num2 * 1413228444u);
						continue;
					case 2u:
						this.Id = input.ReadUInt32();
						arg_114_0 = 1963204645u;
						continue;
					case 3u:
						this.NewChallengeProtocol = input.ReadBool();
						arg_114_0 = 1664836023u;
						continue;
					case 4u:
						arg_114_0 = (num2 * 993741627u ^ 2235635807u);
						continue;
					case 5u:
						arg_114_0 = (((num != 24u) ? 2425083457u : 2238254424u) ^ num2 * 1806185584u);
						continue;
					case 6u:
						goto IL_164;
					case 8u:
						arg_114_0 = ((num == 13u) ? 1405454947u : 1250998700u);
						continue;
					case 9u:
						this.Challenge = input.ReadFixed32();
						arg_114_0 = 174604067u;
						continue;
					case 10u:
						arg_114_0 = 2049655477u;
						continue;
					case 11u:
						arg_114_0 = (num2 * 3840428131u ^ 1497229072u);
						continue;
					case 12u:
						arg_114_0 = (num2 * 264161246u ^ 1760550269u);
						continue;
					}
					return;
				}
			}
		}
	}
}
