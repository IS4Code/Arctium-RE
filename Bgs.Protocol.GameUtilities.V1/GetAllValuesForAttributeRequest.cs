using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAllValuesForAttributeRequest : IMessage<GetAllValuesForAttributeRequest>, IEquatable<GetAllValuesForAttributeRequest>, IDeepCloneable<GetAllValuesForAttributeRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAllValuesForAttributeRequest.__c __9 = new GetAllValuesForAttributeRequest.__c();

			internal GetAllValuesForAttributeRequest cctor>b__34_0()
			{
				return new GetAllValuesForAttributeRequest();
			}
		}

		private static readonly MessageParser<GetAllValuesForAttributeRequest> _parser = new MessageParser<GetAllValuesForAttributeRequest>(new Func<GetAllValuesForAttributeRequest>(GetAllValuesForAttributeRequest.__c.__9.<.cctor>b__34_0));

		public const int AttributeKeyFieldNumber = 1;

		private string attributeKey_ = "";

		public const int AgentIdFieldNumber = 2;

		private EntityId agentId_;

		public const int ProgramFieldNumber = 5;

		private uint program_;

		public static MessageParser<GetAllValuesForAttributeRequest> Parser
		{
			get
			{
				return GetAllValuesForAttributeRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllValuesForAttributeRequest.Descriptor;
			}
		}

		public string AttributeKey
		{
			get
			{
				return this.attributeKey_;
			}
			set
			{
				this.attributeKey_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public EntityId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
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

		public GetAllValuesForAttributeRequest()
		{
		}

		public GetAllValuesForAttributeRequest(GetAllValuesForAttributeRequest other) : this()
		{
			this.attributeKey_ = other.attributeKey_;
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.program_ = other.program_;
		}

		public GetAllValuesForAttributeRequest Clone()
		{
			return new GetAllValuesForAttributeRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllValuesForAttributeRequest);
		}

		public bool Equals(GetAllValuesForAttributeRequest other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ -1940671593) % 11)
				{
				case 0:
					arg_A1_0 = ((this.Program != other.Program) ? -1852295654 : -188445995);
					continue;
				case 1:
					goto IL_E7;
				case 2:
					arg_A1_0 = (GetAllValuesForAttributeRequest.smethod_1(this.AgentId, other.AgentId) ? -1402713956 : -824677356);
					continue;
				case 3:
					goto IL_44;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 8:
					arg_A1_0 = ((!GetAllValuesForAttributeRequest.smethod_0(this.AttributeKey, other.AttributeKey)) ? -256939012 : -1383186324);
					continue;
				case 9:
					return true;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_44:
			arg_A1_0 = -221128457;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other != this) ? -1757988094 : -1519304498);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_106:
				uint arg_DA_0 = 1240929540u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_DA_0 ^ 1973254597u)) % 8u)
					{
					case 0u:
						goto IL_106;
					case 1u:
						arg_DA_0 = (((GetAllValuesForAttributeRequest.smethod_2(this.AttributeKey) != 0) ? 1816699917u : 1627383126u) ^ num2 * 275600070u);
						continue;
					case 2u:
						num ^= GetAllValuesForAttributeRequest.smethod_3(this.AgentId);
						arg_DA_0 = (num2 * 40219652u ^ 4016968969u);
						continue;
					case 4u:
						arg_DA_0 = ((this.Program != 0u) ? 709829018u : 624879430u);
						continue;
					case 5u:
						arg_DA_0 = ((this.agentId_ != null) ? 127722447u : 757687585u);
						continue;
					case 6u:
						num ^= GetAllValuesForAttributeRequest.smethod_3(this.AttributeKey);
						arg_DA_0 = (num2 * 1847297003u ^ 3663272010u);
						continue;
					case 7u:
						num ^= this.Program.GetHashCode();
						arg_DA_0 = (num2 * 1487777448u ^ 527660830u);
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
			if (GetAllValuesForAttributeRequest.smethod_2(this.AttributeKey) != 0)
			{
				goto IL_D0;
			}
			goto IL_11A;
			uint arg_DA_0;
			while (true)
			{
				IL_D5:
				uint num;
				switch ((num = (arg_DA_0 ^ 3587750386u)) % 9u)
				{
				case 0u:
					goto IL_D0;
				case 1u:
					arg_DA_0 = ((this.Program != 0u) ? 3251863161u : 2346731980u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					arg_DA_0 = (num * 3381043683u ^ 749097303u);
					continue;
				case 3u:
					goto IL_11A;
				case 4u:
					output.WriteMessage(this.AgentId);
					arg_DA_0 = (num * 1406821031u ^ 858017266u);
					continue;
				case 6u:
					output.WriteRawTag(45);
					output.WriteFixed32(this.Program);
					arg_DA_0 = (num * 1642519795u ^ 2473301309u);
					continue;
				case 7u:
					output.WriteString(this.AttributeKey);
					arg_DA_0 = (num * 398374308u ^ 3962018921u);
					continue;
				case 8u:
					output.WriteRawTag(18);
					arg_DA_0 = (num * 652084338u ^ 4190677401u);
					continue;
				}
				break;
			}
			return;
			IL_D0:
			arg_DA_0 = 3298870528u;
			goto IL_D5;
			IL_11A:
			arg_DA_0 = ((this.agentId_ == null) ? 2663585341u : 2262813875u);
			goto IL_D5;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_FD:
				uint arg_D1_0 = 2375468129u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_D1_0 ^ 3834579723u)) % 8u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_D1_0 = (num2 * 2147078886u ^ 2775949210u);
						continue;
					case 1u:
						arg_D1_0 = ((this.Program != 0u) ? 2974277861u : 3281393191u);
						continue;
					case 2u:
						arg_D1_0 = (((GetAllValuesForAttributeRequest.smethod_2(this.AttributeKey) == 0) ? 2852270174u : 3268661556u) ^ num2 * 598540681u);
						continue;
					case 3u:
						goto IL_FD;
					case 5u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.AttributeKey);
						arg_D1_0 = (num2 * 578200184u ^ 563546556u);
						continue;
					case 6u:
						num += 5;
						arg_D1_0 = (num2 * 507217110u ^ 1357113043u);
						continue;
					case 7u:
						arg_D1_0 = ((this.agentId_ != null) ? 2743595699u : 4287943882u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetAllValuesForAttributeRequest other)
		{
			if (other == null)
			{
				goto IL_5A;
			}
			goto IL_146;
			uint arg_FE_0;
			while (true)
			{
				IL_F9:
				uint num;
				switch ((num = (arg_FE_0 ^ 1402284499u)) % 11u)
				{
				case 0u:
					goto IL_146;
				case 1u:
					arg_FE_0 = (((this.agentId_ == null) ? 1329621753u : 681888985u) ^ num * 1238041926u);
					continue;
				case 2u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_FE_0 = 898140066u;
					continue;
				case 3u:
					arg_FE_0 = ((other.agentId_ != null) ? 1708964544u : 898140066u);
					continue;
				case 4u:
					this.agentId_ = new EntityId();
					arg_FE_0 = (num * 11089816u ^ 697103531u);
					continue;
				case 6u:
					this.Program = other.Program;
					arg_FE_0 = (num * 1072385817u ^ 2450994955u);
					continue;
				case 7u:
					goto IL_5A;
				case 8u:
					return;
				case 9u:
					arg_FE_0 = ((other.Program != 0u) ? 1485678008u : 1910803576u);
					continue;
				case 10u:
					this.AttributeKey = other.AttributeKey;
					arg_FE_0 = (num * 3455952380u ^ 3633180051u);
					continue;
				}
				break;
			}
			return;
			IL_5A:
			arg_FE_0 = 342820052u;
			goto IL_F9;
			IL_146:
			arg_FE_0 = ((GetAllValuesForAttributeRequest.smethod_2(other.AttributeKey) != 0) ? 1301796738u : 1935958319u);
			goto IL_F9;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1AD:
				uint num;
				uint arg_155_0 = ((num = input.ReadTag()) != 0u) ? 149787098u : 2022853604u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_155_0 ^ 441694570u)) % 15u)
					{
					case 1u:
						input.SkipLastField();
						arg_155_0 = (num2 * 569317955u ^ 2697977327u);
						continue;
					case 2u:
						arg_155_0 = (((num == 18u) ? 1858013426u : 1379932160u) ^ num2 * 218002110u);
						continue;
					case 3u:
						arg_155_0 = (num2 * 2670130033u ^ 2796434995u);
						continue;
					case 4u:
						arg_155_0 = ((num != 10u) ? 206145004u : 824761142u);
						continue;
					case 5u:
						arg_155_0 = (num2 * 3364306379u ^ 1498788459u);
						continue;
					case 6u:
						this.Program = input.ReadFixed32();
						arg_155_0 = 1834656318u;
						continue;
					case 7u:
						arg_155_0 = (num2 * 411110116u ^ 1009074354u);
						continue;
					case 8u:
						input.ReadMessage(this.agentId_);
						arg_155_0 = 1474993973u;
						continue;
					case 9u:
						arg_155_0 = (((num != 45u) ? 1827356368u : 1769742374u) ^ num2 * 4203097368u);
						continue;
					case 10u:
						arg_155_0 = ((this.agentId_ == null) ? 246554252u : 456967371u);
						continue;
					case 11u:
						this.AttributeKey = input.ReadString();
						arg_155_0 = 1111874871u;
						continue;
					case 12u:
						this.agentId_ = new EntityId();
						arg_155_0 = (num2 * 1119923637u ^ 1639901013u);
						continue;
					case 13u:
						arg_155_0 = 149787098u;
						continue;
					case 14u:
						goto IL_1AD;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static bool smethod_1(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_3(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
