using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class SendMessageRequest : IMessage<SendMessageRequest>, IEquatable<SendMessageRequest>, IDeepCloneable<SendMessageRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SendMessageRequest.__c __9 = new SendMessageRequest.__c();

			internal SendMessageRequest cctor>b__34_0()
			{
				return new SendMessageRequest();
			}
		}

		private static readonly MessageParser<SendMessageRequest> _parser = new MessageParser<SendMessageRequest>(new Func<SendMessageRequest>(SendMessageRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int MessageFieldNumber = 2;

		private Message message_;

		public const int RequiredPrivilegesFieldNumber = 3;

		private ulong requiredPrivileges_;

		public static MessageParser<SendMessageRequest> Parser
		{
			get
			{
				return SendMessageRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMessageRequest.Descriptor;
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

		public Message Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = value;
			}
		}

		public ulong RequiredPrivileges
		{
			get
			{
				return this.requiredPrivileges_;
			}
			set
			{
				this.requiredPrivileges_ = value;
			}
		}

		public SendMessageRequest()
		{
		}

		public SendMessageRequest(SendMessageRequest other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = 266522114;
				while (true)
				{
					switch ((arg_2E_0 ^ 1005237260) % 3)
					{
					case 0:
						goto IL_44;
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_2E_0 = 990239952;
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.Message = ((other.message_ != null) ? other.Message.Clone() : null);
			this.requiredPrivileges_ = other.requiredPrivileges_;
		}

		public SendMessageRequest Clone()
		{
			return new SendMessageRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SendMessageRequest);
		}

		public bool Equals(SendMessageRequest other)
		{
			if (other == null)
			{
				goto IL_70;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ -1583525091) % 11)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					goto IL_E7;
				case 7:
					arg_A1_0 = ((this.RequiredPrivileges != other.RequiredPrivileges) ? -1740342186 : -1959881042);
					continue;
				case 8:
					goto IL_70;
				case 9:
					arg_A1_0 = ((!SendMessageRequest.smethod_0(this.Message, other.Message)) ? -1863358508 : -1846240042);
					continue;
				case 10:
					arg_A1_0 = ((!SendMessageRequest.smethod_0(this.AgentId, other.AgentId)) ? -801550044 : -102431483);
					continue;
				}
				break;
			}
			return true;
			IL_70:
			arg_A1_0 = -327996046;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other != this) ? -1204952479 : -1684305012);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D6:
				uint arg_AE_0 = 676007855u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AE_0 ^ 984884557u)) % 7u)
					{
					case 0u:
						num ^= SendMessageRequest.smethod_1(this.AgentId);
						arg_AE_0 = (num2 * 2126002137u ^ 2716784138u);
						continue;
					case 1u:
						num ^= this.RequiredPrivileges.GetHashCode();
						arg_AE_0 = (num2 * 986554025u ^ 3531406050u);
						continue;
					case 2u:
						arg_AE_0 = (((this.RequiredPrivileges == 0uL) ? 334329096u : 669660727u) ^ num2 * 1223590576u);
						continue;
					case 3u:
						goto IL_D6;
					case 4u:
						num ^= SendMessageRequest.smethod_1(this.Message);
						arg_AE_0 = 1878150154u;
						continue;
					case 5u:
						arg_AE_0 = (((this.agentId_ != null) ? 3136385702u : 3337085273u) ^ num2 * 842271026u);
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
			if (this.agentId_ != null)
			{
				goto IL_0B;
			}
			goto IL_CA;
			uint arg_A2_0;
			while (true)
			{
				IL_9D:
				uint num;
				switch ((num = (arg_A2_0 ^ 1782303621u)) % 7u)
				{
				case 0u:
					arg_A2_0 = (((this.RequiredPrivileges != 0uL) ? 2177429440u : 2593236431u) ^ num * 1235946409u);
					continue;
				case 1u:
					goto IL_CA;
				case 2u:
					output.WriteMessage(this.Message);
					arg_A2_0 = (num * 218227085u ^ 2694536156u);
					continue;
				case 3u:
					output.WriteRawTag(24);
					output.WriteUInt64(this.RequiredPrivileges);
					arg_A2_0 = (num * 1400583811u ^ 253602730u);
					continue;
				case 5u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_A2_0 = (num * 3963316187u ^ 2582225057u);
					continue;
				case 6u:
					goto IL_0B;
				}
				break;
			}
			return;
			IL_0B:
			arg_A2_0 = 775054889u;
			goto IL_9D;
			IL_CA:
			output.WriteRawTag(18);
			arg_A2_0 = 1112156865u;
			goto IL_9D;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_C6:
				uint arg_A2_0 = 893019063u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A2_0 ^ 1884856701u)) % 6u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.RequiredPrivileges);
						arg_A2_0 = (num2 * 1117551205u ^ 1085620938u);
						continue;
					case 2u:
						arg_A2_0 = (((this.agentId_ != null) ? 4199071330u : 3005391315u) ^ num2 * 930728166u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_A2_0 = (num2 * 2775389816u ^ 2817798343u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
						arg_A2_0 = ((this.RequiredPrivileges == 0uL) ? 349027085u : 2056489926u);
						continue;
					case 5u:
						goto IL_C6;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(SendMessageRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_197;
			uint arg_147_0;
			while (true)
			{
				IL_142:
				uint num;
				switch ((num = (arg_147_0 ^ 1243363372u)) % 13u)
				{
				case 0u:
					this.message_ = new Message();
					arg_147_0 = (num * 2705335856u ^ 592598316u);
					continue;
				case 1u:
					this.RequiredPrivileges = other.RequiredPrivileges;
					arg_147_0 = (num * 1562832033u ^ 896592453u);
					continue;
				case 2u:
					arg_147_0 = (((this.message_ == null) ? 1293515090u : 1712829918u) ^ num * 373304734u);
					continue;
				case 3u:
					return;
				case 4u:
					arg_147_0 = (((this.agentId_ == null) ? 3482074292u : 4001597118u) ^ num * 1658911751u);
					continue;
				case 6u:
					arg_147_0 = ((other.RequiredPrivileges == 0uL) ? 572172745u : 1403491360u);
					continue;
				case 7u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_147_0 = 233231300u;
					continue;
				case 8u:
					goto IL_197;
				case 9u:
					arg_147_0 = ((other.message_ == null) ? 1639949992u : 744135035u);
					continue;
				case 10u:
					this.agentId_ = new EntityId();
					arg_147_0 = (num * 3270607941u ^ 1407333534u);
					continue;
				case 11u:
					this.Message.MergeFrom(other.Message);
					arg_147_0 = 1639949992u;
					continue;
				case 12u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_147_0 = 1660656625u;
			goto IL_142;
			IL_197:
			arg_147_0 = ((other.agentId_ != null) ? 361132878u : 233231300u);
			goto IL_142;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1E0:
				uint num;
				uint arg_184_0 = ((num = input.ReadTag()) != 0u) ? 2246317013u : 3999639208u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_184_0 ^ 3356173597u)) % 16u)
					{
					case 0u:
						input.SkipLastField();
						arg_184_0 = (num2 * 1758878166u ^ 4278471827u);
						continue;
					case 1u:
						goto IL_1E0;
					case 2u:
						arg_184_0 = (((num == 18u) ? 3290685772u : 3736280544u) ^ num2 * 3187791723u);
						continue;
					case 3u:
						this.RequiredPrivileges = input.ReadUInt64();
						arg_184_0 = 3151027820u;
						continue;
					case 4u:
						arg_184_0 = 2246317013u;
						continue;
					case 6u:
						input.ReadMessage(this.agentId_);
						arg_184_0 = 3151027820u;
						continue;
					case 7u:
						arg_184_0 = ((this.message_ == null) ? 3957426740u : 3022716226u);
						continue;
					case 8u:
						arg_184_0 = ((num == 10u) ? 3319867920u : 4064901343u);
						continue;
					case 9u:
						this.message_ = new Message();
						arg_184_0 = (num2 * 3899215463u ^ 1085344317u);
						continue;
					case 10u:
						arg_184_0 = (num2 * 3277961218u ^ 1189039320u);
						continue;
					case 11u:
						arg_184_0 = (((num == 24u) ? 3336785952u : 3412380291u) ^ num2 * 3509728330u);
						continue;
					case 12u:
						this.agentId_ = new EntityId();
						arg_184_0 = (num2 * 2910710945u ^ 1679507015u);
						continue;
					case 13u:
						arg_184_0 = ((this.agentId_ != null) ? 3579485115u : 4128583009u);
						continue;
					case 14u:
						arg_184_0 = (num2 * 3384859555u ^ 794813734u);
						continue;
					case 15u:
						input.ReadMessage(this.message_);
						arg_184_0 = 2234864711u;
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
