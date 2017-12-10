using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetLicensesRequest : IMessage<GetLicensesRequest>, IEquatable<GetLicensesRequest>, IDeepCloneable<GetLicensesRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetLicensesRequest.__c __9 = new GetLicensesRequest.__c();

			internal GetLicensesRequest cctor>b__49_0()
			{
				return new GetLicensesRequest();
			}
		}

		private static readonly MessageParser<GetLicensesRequest> _parser = new MessageParser<GetLicensesRequest>(new Func<GetLicensesRequest>(GetLicensesRequest.__c.__9.<.cctor>b__49_0));

		public const int TargetIdFieldNumber = 1;

		private EntityId targetId_;

		public const int FetchAccountLicensesFieldNumber = 2;

		private bool fetchAccountLicenses_;

		public const int FetchGameAccountLicensesFieldNumber = 3;

		private bool fetchGameAccountLicenses_;

		public const int FetchDynamicAccountLicensesFieldNumber = 4;

		private bool fetchDynamicAccountLicenses_;

		public const int ProgramFieldNumber = 5;

		private uint program_;

		public const int ExcludeUnknownProgramFieldNumber = 6;

		private bool excludeUnknownProgram_;

		public static MessageParser<GetLicensesRequest> Parser
		{
			get
			{
				return GetLicensesRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[17];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLicensesRequest.Descriptor;
			}
		}

		public EntityId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		public bool FetchAccountLicenses
		{
			get
			{
				return this.fetchAccountLicenses_;
			}
			set
			{
				this.fetchAccountLicenses_ = value;
			}
		}

		public bool FetchGameAccountLicenses
		{
			get
			{
				return this.fetchGameAccountLicenses_;
			}
			set
			{
				this.fetchGameAccountLicenses_ = value;
			}
		}

		public bool FetchDynamicAccountLicenses
		{
			get
			{
				return this.fetchDynamicAccountLicenses_;
			}
			set
			{
				this.fetchDynamicAccountLicenses_ = value;
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

		public bool ExcludeUnknownProgram
		{
			get
			{
				return this.excludeUnknownProgram_;
			}
			set
			{
				this.excludeUnknownProgram_ = value;
			}
		}

		public GetLicensesRequest()
		{
		}

		public GetLicensesRequest(GetLicensesRequest other) : this()
		{
			this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
			this.fetchAccountLicenses_ = other.fetchAccountLicenses_;
			this.fetchGameAccountLicenses_ = other.fetchGameAccountLicenses_;
			this.fetchDynamicAccountLicenses_ = other.fetchDynamicAccountLicenses_;
			this.program_ = other.program_;
			this.excludeUnknownProgram_ = other.excludeUnknownProgram_;
		}

		public GetLicensesRequest Clone()
		{
			return new GetLicensesRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetLicensesRequest);
		}

		public bool Equals(GetLicensesRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_178;
			int arg_11A_0;
			while (true)
			{
				IL_115:
				switch ((arg_11A_0 ^ 1634938800) % 17)
				{
				case 0:
					goto IL_178;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_11A_0 = ((this.ExcludeUnknownProgram != other.ExcludeUnknownProgram) ? 1988959255 : 645541320);
					continue;
				case 4:
					arg_11A_0 = ((this.FetchAccountLicenses == other.FetchAccountLicenses) ? 1909608254 : 614951453);
					continue;
				case 5:
					return false;
				case 6:
					arg_11A_0 = ((this.FetchDynamicAccountLicenses == other.FetchDynamicAccountLicenses) ? 1817957003 : 2018019609);
					continue;
				case 7:
					arg_11A_0 = ((this.FetchGameAccountLicenses == other.FetchGameAccountLicenses) ? 1634409685 : 721753335);
					continue;
				case 8:
					arg_11A_0 = ((this.Program != other.Program) ? 1412998296 : 184555650);
					continue;
				case 9:
					arg_11A_0 = ((!GetLicensesRequest.smethod_0(this.TargetId, other.TargetId)) ? 90119017 : 395409961);
					continue;
				case 10:
					goto IL_18;
				case 11:
					return false;
				case 12:
					return true;
				case 13:
					return false;
				case 14:
					return false;
				case 16:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_11A_0 = 66315895;
			goto IL_115;
			IL_178:
			arg_11A_0 = ((other != this) ? 636483416 : 741646273);
			goto IL_115;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_1F2:
				uint arg_1AD_0 = 3812404799u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1AD_0 ^ 2457905015u)) % 14u)
					{
					case 0u:
						num ^= this.Program.GetHashCode();
						arg_1AD_0 = (num2 * 1328469349u ^ 883571346u);
						continue;
					case 1u:
						num ^= this.FetchDynamicAccountLicenses.GetHashCode();
						arg_1AD_0 = (num2 * 2730256200u ^ 741429309u);
						continue;
					case 2u:
						arg_1AD_0 = (((this.targetId_ != null) ? 3161885406u : 3877843329u) ^ num2 * 1356340007u);
						continue;
					case 3u:
						num ^= GetLicensesRequest.smethod_1(this.TargetId);
						arg_1AD_0 = (num2 * 2615055118u ^ 3701858071u);
						continue;
					case 4u:
						num ^= this.ExcludeUnknownProgram.GetHashCode();
						arg_1AD_0 = (num2 * 2386606221u ^ 1223795827u);
						continue;
					case 5u:
						num ^= this.FetchAccountLicenses.GetHashCode();
						arg_1AD_0 = (num2 * 122463881u ^ 750198965u);
						continue;
					case 7u:
						num ^= this.FetchGameAccountLicenses.GetHashCode();
						arg_1AD_0 = (num2 * 2390326107u ^ 2505749968u);
						continue;
					case 8u:
						arg_1AD_0 = (this.FetchAccountLicenses ? 3130127592u : 4110809762u);
						continue;
					case 9u:
						arg_1AD_0 = ((!this.FetchGameAccountLicenses) ? 3729574285u : 3953716176u);
						continue;
					case 10u:
						arg_1AD_0 = ((this.Program != 0u) ? 2413107357u : 2837730240u);
						continue;
					case 11u:
						goto IL_1F2;
					case 12u:
						arg_1AD_0 = ((!this.FetchDynamicAccountLicenses) ? 3202820901u : 4065459484u);
						continue;
					case 13u:
						arg_1AD_0 = (this.ExcludeUnknownProgram ? 2428025037u : 3804663041u);
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
			if (this.targetId_ != null)
			{
				goto IL_DE;
			}
			goto IL_224;
			uint arg_1C8_0;
			while (true)
			{
				IL_1C3:
				uint num;
				switch ((num = (arg_1C8_0 ^ 459029054u)) % 16u)
				{
				case 0u:
					output.WriteRawTag(48);
					arg_1C8_0 = (num * 1496251010u ^ 1865155090u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					arg_1C8_0 = (num * 3042465422u ^ 440095643u);
					continue;
				case 3u:
					arg_1C8_0 = ((!this.FetchGameAccountLicenses) ? 1802285738u : 1288596355u);
					continue;
				case 4u:
					arg_1C8_0 = (this.FetchDynamicAccountLicenses ? 844097032u : 295302201u);
					continue;
				case 5u:
					goto IL_224;
				case 6u:
					output.WriteRawTag(32);
					output.WriteBool(this.FetchDynamicAccountLicenses);
					arg_1C8_0 = (num * 353757068u ^ 4050047921u);
					continue;
				case 7u:
					arg_1C8_0 = ((this.Program != 0u) ? 100206422u : 218930401u);
					continue;
				case 8u:
					output.WriteRawTag(45);
					output.WriteFixed32(this.Program);
					arg_1C8_0 = (num * 615577166u ^ 4225120593u);
					continue;
				case 9u:
					goto IL_DE;
				case 10u:
					output.WriteRawTag(16);
					arg_1C8_0 = (num * 1525529708u ^ 1345113080u);
					continue;
				case 11u:
					output.WriteMessage(this.TargetId);
					arg_1C8_0 = (num * 1097024544u ^ 2781391803u);
					continue;
				case 12u:
					output.WriteBool(this.ExcludeUnknownProgram);
					arg_1C8_0 = (num * 2690889106u ^ 1082359972u);
					continue;
				case 13u:
					output.WriteRawTag(24);
					output.WriteBool(this.FetchGameAccountLicenses);
					arg_1C8_0 = (num * 866856587u ^ 2081285429u);
					continue;
				case 14u:
					output.WriteBool(this.FetchAccountLicenses);
					arg_1C8_0 = (num * 2439745219u ^ 3123695591u);
					continue;
				case 15u:
					arg_1C8_0 = (this.ExcludeUnknownProgram ? 1669995774u : 1344501948u);
					continue;
				}
				break;
			}
			return;
			IL_DE:
			arg_1C8_0 = 2028054015u;
			goto IL_1C3;
			IL_224:
			arg_1C8_0 = (this.FetchAccountLicenses ? 829587972u : 1833785437u);
			goto IL_1C3;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_1AD:
				uint arg_168_0 = 1044554235u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_168_0 ^ 1984616261u)) % 14u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
						arg_168_0 = (num2 * 3337958475u ^ 2770400893u);
						continue;
					case 1u:
						num += 5;
						arg_168_0 = (num2 * 2066090613u ^ 559105124u);
						continue;
					case 2u:
						arg_168_0 = (this.ExcludeUnknownProgram ? 1228168912u : 1612166766u);
						continue;
					case 3u:
						num += 2;
						arg_168_0 = (num2 * 2376897924u ^ 3653144054u);
						continue;
					case 4u:
						goto IL_1AD;
					case 5u:
						num += 2;
						arg_168_0 = (num2 * 4253883115u ^ 3052735705u);
						continue;
					case 6u:
						num += 2;
						arg_168_0 = (num2 * 2550035644u ^ 3990374415u);
						continue;
					case 7u:
						arg_168_0 = (this.FetchGameAccountLicenses ? 1756291628u : 223067578u);
						continue;
					case 8u:
						arg_168_0 = (((this.targetId_ == null) ? 459119181u : 1957359793u) ^ num2 * 3936674969u);
						continue;
					case 10u:
						arg_168_0 = ((this.Program != 0u) ? 1348909604u : 615154481u);
						continue;
					case 11u:
						num += 2;
						arg_168_0 = (num2 * 782539393u ^ 1726824571u);
						continue;
					case 12u:
						arg_168_0 = (this.FetchAccountLicenses ? 1922098680u : 1773709186u);
						continue;
					case 13u:
						arg_168_0 = ((!this.FetchDynamicAccountLicenses) ? 218157783u : 2074141807u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetLicensesRequest other)
		{
			if (other == null)
			{
				goto IL_184;
			}
			goto IL_224;
			uint arg_1C4_0;
			while (true)
			{
				IL_1BF:
				uint num;
				switch ((num = (arg_1C4_0 ^ 3432304045u)) % 17u)
				{
				case 0u:
					this.FetchAccountLicenses = other.FetchAccountLicenses;
					arg_1C4_0 = (num * 2888740375u ^ 491835904u);
					continue;
				case 1u:
					this.Program = other.Program;
					arg_1C4_0 = (num * 3651235179u ^ 1762253361u);
					continue;
				case 2u:
					goto IL_184;
				case 3u:
					arg_1C4_0 = ((!other.FetchDynamicAccountLicenses) ? 3947526731u : 3997248950u);
					continue;
				case 4u:
					this.FetchGameAccountLicenses = other.FetchGameAccountLicenses;
					arg_1C4_0 = (num * 4059091531u ^ 2459262670u);
					continue;
				case 5u:
					this.FetchDynamicAccountLicenses = other.FetchDynamicAccountLicenses;
					arg_1C4_0 = (num * 1934285537u ^ 1288998896u);
					continue;
				case 6u:
					goto IL_224;
				case 7u:
					arg_1C4_0 = (other.ExcludeUnknownProgram ? 2799962412u : 4200578116u);
					continue;
				case 9u:
					return;
				case 10u:
					this.targetId_ = new EntityId();
					arg_1C4_0 = (num * 1588993469u ^ 1345271249u);
					continue;
				case 11u:
					arg_1C4_0 = ((other.Program == 0u) ? 2910871700u : 3146523010u);
					continue;
				case 12u:
					arg_1C4_0 = (((this.targetId_ == null) ? 1547184944u : 1838636888u) ^ num * 1627482345u);
					continue;
				case 13u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_1C4_0 = 2716812973u;
					continue;
				case 14u:
					arg_1C4_0 = (other.FetchAccountLicenses ? 4270335551u : 2309141534u);
					continue;
				case 15u:
					arg_1C4_0 = (other.FetchGameAccountLicenses ? 2220822498u : 2427708907u);
					continue;
				case 16u:
					this.ExcludeUnknownProgram = other.ExcludeUnknownProgram;
					arg_1C4_0 = (num * 3807555738u ^ 3367983582u);
					continue;
				}
				break;
			}
			return;
			IL_184:
			arg_1C4_0 = 3683549381u;
			goto IL_1BF;
			IL_224:
			arg_1C4_0 = ((other.targetId_ != null) ? 3479717451u : 2716812973u);
			goto IL_1BF;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2E1:
				uint num;
				uint arg_261_0 = ((num = input.ReadTag()) == 0u) ? 2074549775u : 1748539018u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_261_0 ^ 1787905598u)) % 25u)
					{
					case 0u:
						arg_261_0 = (((num == 45u) ? 3444103044u : 4171305269u) ^ num2 * 2153779732u);
						continue;
					case 1u:
						arg_261_0 = (num2 * 1181505676u ^ 1112510807u);
						continue;
					case 2u:
						arg_261_0 = (num2 * 37888102u ^ 3341244039u);
						continue;
					case 3u:
						arg_261_0 = (((num == 10u) ? 4253111375u : 2885227160u) ^ num2 * 1168468816u);
						continue;
					case 4u:
						arg_261_0 = (num2 * 1135134428u ^ 387240919u);
						continue;
					case 5u:
						arg_261_0 = (num2 * 1529240705u ^ 322606858u);
						continue;
					case 6u:
						this.Program = input.ReadFixed32();
						arg_261_0 = 1402020928u;
						continue;
					case 7u:
						this.FetchAccountLicenses = input.ReadBool();
						arg_261_0 = 225885631u;
						continue;
					case 8u:
						arg_261_0 = (((num != 16u) ? 976059913u : 1343233416u) ^ num2 * 310534278u);
						continue;
					case 9u:
						arg_261_0 = 1748539018u;
						continue;
					case 10u:
						this.targetId_ = new EntityId();
						arg_261_0 = (num2 * 201434159u ^ 86127576u);
						continue;
					case 11u:
						this.FetchDynamicAccountLicenses = input.ReadBool();
						arg_261_0 = 905158408u;
						continue;
					case 12u:
						arg_261_0 = ((this.targetId_ != null) ? 856543824u : 1898588870u);
						continue;
					case 13u:
						input.ReadMessage(this.targetId_);
						arg_261_0 = 888701203u;
						continue;
					case 14u:
						this.ExcludeUnknownProgram = input.ReadBool();
						arg_261_0 = 225885631u;
						continue;
					case 15u:
						arg_261_0 = (num2 * 1980238207u ^ 3188560082u);
						continue;
					case 16u:
						this.FetchGameAccountLicenses = input.ReadBool();
						arg_261_0 = 1556750794u;
						continue;
					case 17u:
						arg_261_0 = ((num == 32u) ? 2092421456u : 668075455u);
						continue;
					case 19u:
						arg_261_0 = ((num <= 24u) ? 734382658u : 341695910u);
						continue;
					case 20u:
						input.SkipLastField();
						arg_261_0 = 1610105355u;
						continue;
					case 21u:
						arg_261_0 = (((num != 24u) ? 1431043742u : 1050345064u) ^ num2 * 1904115291u);
						continue;
					case 22u:
						arg_261_0 = (((num == 48u) ? 1666471845u : 776804383u) ^ num2 * 2153898030u);
						continue;
					case 23u:
						arg_261_0 = (num2 * 4037724462u ^ 1966121641u);
						continue;
					case 24u:
						goto IL_2E1;
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
