using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengeResultRequest : IMessage<ChallengeResultRequest>, IEquatable<ChallengeResultRequest>, IDeepCloneable<ChallengeResultRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengeResultRequest.__c __9 = new ChallengeResultRequest.__c();

			internal ChallengeResultRequest cctor>b__39_0()
			{
				return new ChallengeResultRequest();
			}
		}

		private static readonly MessageParser<ChallengeResultRequest> _parser = new MessageParser<ChallengeResultRequest>(new Func<ChallengeResultRequest>(ChallengeResultRequest.__c.__9.<.cctor>b__39_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public const int TypeFieldNumber = 2;

		private uint type_;

		public const int ErrorIdFieldNumber = 3;

		private uint errorId_;

		public const int AnswerFieldNumber = 4;

		private ByteString answer_ = ByteString.Empty;

		public static MessageParser<ChallengeResultRequest> Parser
		{
			get
			{
				return ChallengeResultRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeResultRequest.Descriptor;
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

		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		public uint ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		public ByteString Answer
		{
			get
			{
				return this.answer_;
			}
			set
			{
				this.answer_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public ChallengeResultRequest()
		{
		}

		public ChallengeResultRequest(ChallengeResultRequest other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.errorId_ = other.errorId_;
			this.answer_ = other.answer_;
		}

		public ChallengeResultRequest Clone()
		{
			return new ChallengeResultRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeResultRequest);
		}

		public bool Equals(ChallengeResultRequest other)
		{
			if (other == null)
			{
				goto IL_BC;
			}
			goto IL_114;
			int arg_C6_0;
			while (true)
			{
				IL_C1:
				switch ((arg_C6_0 ^ -74341912) % 13)
				{
				case 0:
					goto IL_BC;
				case 1:
					arg_C6_0 = ((this.Type != other.Type) ? -945178309 : -1599524225);
					continue;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					arg_C6_0 = ((this.ErrorId == other.ErrorId) ? -1371320658 : -1208873822);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_C6_0 = ((this.Id == other.Id) ? -2054423641 : -1474850972);
					continue;
				case 8:
					return false;
				case 10:
					goto IL_114;
				case 11:
					arg_C6_0 = ((!(this.Answer != other.Answer)) ? -1239051734 : -1622042382);
					continue;
				case 12:
					return false;
				}
				break;
			}
			return true;
			IL_BC:
			arg_C6_0 = -2011518234;
			goto IL_C1;
			IL_114:
			arg_C6_0 = ((other == this) ? -1088499930 : -943423464);
			goto IL_C1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_159:
				uint arg_124_0 = 2263963628u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_124_0 ^ 4214752878u)) % 10u)
					{
					case 0u:
						arg_124_0 = ((this.ErrorId == 0u) ? 2282106472u : 2308100730u);
						continue;
					case 1u:
						num ^= this.Answer.GetHashCode();
						arg_124_0 = (num2 * 3640089748u ^ 1948888856u);
						continue;
					case 2u:
						arg_124_0 = (((this.Id == 0u) ? 2581344769u : 3408945223u) ^ num2 * 208780468u);
						continue;
					case 3u:
						arg_124_0 = ((this.Type == 0u) ? 3066077084u : 2291256939u);
						continue;
					case 5u:
						goto IL_159;
					case 6u:
						num ^= this.ErrorId.GetHashCode();
						arg_124_0 = (num2 * 1849991879u ^ 2722737636u);
						continue;
					case 7u:
						num ^= this.Id.GetHashCode();
						arg_124_0 = (num2 * 3593806716u ^ 1154485013u);
						continue;
					case 8u:
						arg_124_0 = ((this.Answer.Length != 0) ? 2355791911u : 4083339564u);
						continue;
					case 9u:
						num ^= this.Type.GetHashCode();
						arg_124_0 = (num2 * 3558625177u ^ 1065257569u);
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
				goto IL_37;
			}
			goto IL_158;
			uint arg_114_0;
			while (true)
			{
				IL_10F:
				uint num;
				switch ((num = (arg_114_0 ^ 170396988u)) % 10u)
				{
				case 0u:
					arg_114_0 = ((this.Answer.Length == 0) ? 123908568u : 934255645u);
					continue;
				case 1u:
					output.WriteRawTag(21);
					output.WriteFixed32(this.Type);
					arg_114_0 = (num * 2090538074u ^ 137232722u);
					continue;
				case 2u:
					arg_114_0 = ((this.ErrorId != 0u) ? 1889987553u : 75126502u);
					continue;
				case 3u:
					output.WriteRawTag(8);
					output.WriteUInt32(this.Id);
					arg_114_0 = (num * 3721799915u ^ 594379369u);
					continue;
				case 4u:
					output.WriteBytes(this.Answer);
					arg_114_0 = (num * 1666243921u ^ 1450664066u);
					continue;
				case 5u:
					output.WriteRawTag(24);
					output.WriteUInt32(this.ErrorId);
					arg_114_0 = (num * 1148742426u ^ 484673428u);
					continue;
				case 6u:
					goto IL_158;
				case 7u:
					goto IL_37;
				case 9u:
					output.WriteRawTag(34);
					arg_114_0 = (num * 2513857255u ^ 1980763841u);
					continue;
				}
				break;
			}
			return;
			IL_37:
			arg_114_0 = 1971277189u;
			goto IL_10F;
			IL_158:
			arg_114_0 = ((this.Type != 0u) ? 1006726797u : 1454367080u);
			goto IL_10F;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0u)
			{
				goto IL_DF;
			}
			goto IL_129;
			uint arg_E9_0;
			while (true)
			{
				IL_E4:
				uint num2;
				switch ((num2 = (arg_E9_0 ^ 260387667u)) % 9u)
				{
				case 0u:
					goto IL_DF;
				case 1u:
					num += 1 + CodedOutputStream.ComputeBytesSize(this.Answer);
					arg_E9_0 = (num2 * 1481708893u ^ 1462142542u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
					arg_E9_0 = (num2 * 3490669960u ^ 1967721265u);
					continue;
				case 4u:
					arg_E9_0 = ((this.Answer.Length == 0) ? 817397070u : 1814889555u);
					continue;
				case 5u:
					arg_E9_0 = ((this.ErrorId == 0u) ? 1050453992u : 2143227429u);
					continue;
				case 6u:
					num += 5;
					arg_E9_0 = (num2 * 2236882882u ^ 2751968047u);
					continue;
				case 7u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorId);
					arg_E9_0 = (num2 * 1660794401u ^ 4132272094u);
					continue;
				case 8u:
					goto IL_129;
				}
				break;
			}
			return num;
			IL_DF:
			arg_E9_0 = 476080422u;
			goto IL_E4;
			IL_129:
			arg_E9_0 = ((this.Type == 0u) ? 210328841u : 2033567264u);
			goto IL_E4;
		}

		public void MergeFrom(ChallengeResultRequest other)
		{
			if (other == null)
			{
				goto IL_3C;
			}
			goto IL_147;
			uint arg_FF_0;
			while (true)
			{
				IL_FA:
				uint num;
				switch ((num = (arg_FF_0 ^ 2051489699u)) % 11u)
				{
				case 0u:
					arg_FF_0 = ((other.ErrorId == 0u) ? 1167687955u : 416304537u);
					continue;
				case 1u:
					arg_FF_0 = ((other.Answer.Length != 0) ? 972184533u : 1625739093u);
					continue;
				case 2u:
					this.Type = other.Type;
					arg_FF_0 = (num * 598319970u ^ 1877601520u);
					continue;
				case 3u:
					this.Id = other.Id;
					arg_FF_0 = (num * 265056435u ^ 2932706774u);
					continue;
				case 5u:
					this.ErrorId = other.ErrorId;
					arg_FF_0 = (num * 478346064u ^ 3764326707u);
					continue;
				case 6u:
					this.Answer = other.Answer;
					arg_FF_0 = (num * 2380539388u ^ 902643069u);
					continue;
				case 7u:
					goto IL_3C;
				case 8u:
					return;
				case 9u:
					arg_FF_0 = ((other.Type == 0u) ? 940288952u : 1492401479u);
					continue;
				case 10u:
					goto IL_147;
				}
				break;
			}
			return;
			IL_3C:
			arg_FF_0 = 1481351491u;
			goto IL_FA;
			IL_147:
			arg_FF_0 = ((other.Id != 0u) ? 2029384052u : 655703427u);
			goto IL_FA;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1CA:
				uint num;
				uint arg_16E_0 = ((num = input.ReadTag()) == 0u) ? 1644130248u : 194600046u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_16E_0 ^ 895291309u)) % 16u)
					{
					case 0u:
						arg_16E_0 = 194600046u;
						continue;
					case 1u:
						arg_16E_0 = (((num == 8u) ? 4041703137u : 3993972910u) ^ num2 * 2615583169u);
						continue;
					case 2u:
						arg_16E_0 = (((num != 21u) ? 29471139u : 2145722662u) ^ num2 * 4190716785u);
						continue;
					case 3u:
						arg_16E_0 = ((num > 21u) ? 308841157u : 1423818620u);
						continue;
					case 4u:
						goto IL_1CA;
					case 6u:
						arg_16E_0 = (((num != 34u) ? 1320683156u : 263894545u) ^ num2 * 2652968675u);
						continue;
					case 7u:
						arg_16E_0 = (num2 * 1055757233u ^ 2007543502u);
						continue;
					case 8u:
						arg_16E_0 = ((num == 24u) ? 1814248226u : 820225083u);
						continue;
					case 9u:
						this.Type = input.ReadFixed32();
						arg_16E_0 = 1207175081u;
						continue;
					case 10u:
						arg_16E_0 = (num2 * 2947941792u ^ 4210894825u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_16E_0 = 1717519162u;
						continue;
					case 12u:
						arg_16E_0 = (num2 * 1943727450u ^ 556485902u);
						continue;
					case 13u:
						this.Id = input.ReadUInt32();
						arg_16E_0 = 1207175081u;
						continue;
					case 14u:
						this.Answer = input.ReadBytes();
						arg_16E_0 = 1207175081u;
						continue;
					case 15u:
						this.ErrorId = input.ReadUInt32();
						arg_16E_0 = 792937447u;
						continue;
					}
					return;
				}
			}
		}
	}
}
