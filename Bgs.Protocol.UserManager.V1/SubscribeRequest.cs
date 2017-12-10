using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SubscribeRequest.__c __9 = new SubscribeRequest.__c();

			internal SubscribeRequest cctor>b__29_0()
			{
				return new SubscribeRequest();
			}
		}

		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(new Func<SubscribeRequest>(SubscribeRequest.__c.__9.<.cctor>b__29_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int ObjectIdFieldNumber = 2;

		private ulong objectId_;

		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
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

		public ulong ObjectId
		{
			get
			{
				return this.objectId_;
			}
			set
			{
				this.objectId_ = value;
			}
		}

		public SubscribeRequest()
		{
		}

		public SubscribeRequest(SubscribeRequest other) : this()
		{
			while (true)
			{
				IL_50:
				int arg_3A_0 = 1325818509;
				while (true)
				{
					switch ((arg_3A_0 ^ 1722233783) % 3)
					{
					case 0:
						goto IL_50;
					case 2:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.objectId_ = other.objectId_;
						arg_3A_0 = 2059141532;
						continue;
					}
					return;
				}
			}
		}

		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		public bool Equals(SubscribeRequest other)
		{
			if (other == null)
			{
				goto IL_3C;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 2019778344) % 9)
				{
				case 0:
					arg_72_0 = ((!SubscribeRequest.smethod_0(this.AgentId, other.AgentId)) ? 1675316897 : 1906118553);
					continue;
				case 1:
					return false;
				case 2:
					goto IL_3C;
				case 3:
					return false;
				case 4:
					return true;
				case 6:
					goto IL_B0;
				case 7:
					arg_72_0 = ((this.ObjectId != other.ObjectId) ? 1750934126 : 533689540);
					continue;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_3C:
			arg_72_0 = 417158981;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 1060011869 : 1149474132);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_1C;
			}
			goto IL_8F;
			uint arg_63_0;
			while (true)
			{
				IL_5E:
				uint num2;
				switch ((num2 = (arg_63_0 ^ 22176443u)) % 5u)
				{
				case 0u:
					num ^= this.ObjectId.GetHashCode();
					arg_63_0 = (num2 * 1502067326u ^ 627368492u);
					continue;
				case 1u:
					goto IL_8F;
				case 2u:
					num ^= SubscribeRequest.smethod_1(this.AgentId);
					arg_63_0 = (num2 * 2355863833u ^ 1455070418u);
					continue;
				case 3u:
					goto IL_1C;
				}
				break;
			}
			return num;
			IL_1C:
			arg_63_0 = 115642044u;
			goto IL_5E;
			IL_8F:
			arg_63_0 = ((this.ObjectId != 0uL) ? 303948121u : 1078460176u);
			goto IL_5E;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_31;
			}
			goto IL_BF;
			uint arg_88_0;
			while (true)
			{
				IL_83:
				uint num;
				switch ((num = (arg_88_0 ^ 1610250301u)) % 7u)
				{
				case 0u:
					output.WriteMessage(this.AgentId);
					arg_88_0 = (num * 3067201397u ^ 177649650u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					arg_88_0 = (num * 1828263635u ^ 2266489483u);
					continue;
				case 2u:
					output.WriteUInt64(this.ObjectId);
					arg_88_0 = (num * 2675546485u ^ 680815964u);
					continue;
				case 4u:
					goto IL_31;
				case 5u:
					output.WriteRawTag(16);
					arg_88_0 = (num * 956693876u ^ 2647628511u);
					continue;
				case 6u:
					goto IL_BF;
				}
				break;
			}
			return;
			IL_31:
			arg_88_0 = 325527202u;
			goto IL_83;
			IL_BF:
			arg_88_0 = ((this.ObjectId == 0uL) ? 1786984054u : 574807733u);
			goto IL_83;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_5A;
			}
			goto IL_90;
			uint arg_64_0;
			while (true)
			{
				IL_5F:
				uint num2;
				switch ((num2 = (arg_64_0 ^ 1725752255u)) % 5u)
				{
				case 0u:
					goto IL_5A;
				case 2u:
					goto IL_90;
				case 3u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
					arg_64_0 = (num2 * 216804516u ^ 2754658768u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_64_0 = (num2 * 2961482916u ^ 3377906006u);
					continue;
				}
				break;
			}
			return num;
			IL_5A:
			arg_64_0 = 1535131317u;
			goto IL_5F;
			IL_90:
			arg_64_0 = ((this.ObjectId == 0uL) ? 1166866632u : 1962658153u);
			goto IL_5F;
		}

		public void MergeFrom(SubscribeRequest other)
		{
			if (other == null)
			{
				goto IL_50;
			}
			goto IL_FC;
			uint arg_BC_0;
			while (true)
			{
				IL_B7:
				uint num;
				switch ((num = (arg_BC_0 ^ 1613038748u)) % 9u)
				{
				case 0u:
					arg_BC_0 = (((this.agentId_ == null) ? 2696871119u : 3863776363u) ^ num * 730437386u);
					continue;
				case 1u:
					goto IL_FC;
				case 2u:
					arg_BC_0 = ((other.ObjectId != 0uL) ? 1820283195u : 1328700931u);
					continue;
				case 3u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_BC_0 = 1037800758u;
					continue;
				case 4u:
					goto IL_50;
				case 5u:
					this.agentId_ = new EntityId();
					arg_BC_0 = (num * 185032861u ^ 2202331692u);
					continue;
				case 6u:
					this.ObjectId = other.ObjectId;
					arg_BC_0 = (num * 2202523278u ^ 3677635233u);
					continue;
				case 8u:
					return;
				}
				break;
			}
			return;
			IL_50:
			arg_BC_0 = 257167904u;
			goto IL_B7;
			IL_FC:
			arg_BC_0 = ((other.agentId_ == null) ? 1037800758u : 1339467640u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_150:
				uint num;
				uint arg_104_0 = ((num = input.ReadTag()) == 0u) ? 3564687619u : 3343265375u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_104_0 ^ 3835491450u)) % 12u)
					{
					case 0u:
						arg_104_0 = ((this.agentId_ == null) ? 3061718889u : 3253921165u);
						continue;
					case 1u:
						arg_104_0 = ((num != 10u) ? 2787350185u : 2963529898u);
						continue;
					case 2u:
						arg_104_0 = 3343265375u;
						continue;
					case 3u:
						input.ReadMessage(this.agentId_);
						arg_104_0 = 2519614212u;
						continue;
					case 4u:
						goto IL_150;
					case 6u:
						arg_104_0 = (num2 * 3156006502u ^ 3986710830u);
						continue;
					case 7u:
						this.agentId_ = new EntityId();
						arg_104_0 = (num2 * 2660217962u ^ 690574419u);
						continue;
					case 8u:
						this.ObjectId = input.ReadUInt64();
						arg_104_0 = 3344877026u;
						continue;
					case 9u:
						input.SkipLastField();
						arg_104_0 = (num2 * 4208392855u ^ 2299771867u);
						continue;
					case 10u:
						arg_104_0 = (num2 * 1428999783u ^ 2456416848u);
						continue;
					case 11u:
						arg_104_0 = (((num == 16u) ? 3538324494u : 2607476127u) ^ num2 * 2482393104u);
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
