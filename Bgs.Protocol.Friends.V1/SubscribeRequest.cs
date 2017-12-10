using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
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
				return FriendsServiceReflection.Descriptor.MessageTypes[0];
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
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.objectId_ = other.objectId_;
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
				goto IL_68;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ -767932746) % 9)
				{
				case 0:
					goto IL_68;
				case 1:
					arg_72_0 = ((this.ObjectId == other.ObjectId) ? -844865021 : -37511448);
					continue;
				case 2:
					arg_72_0 = (SubscribeRequest.smethod_0(this.AgentId, other.AgentId) ? -2126675638 : -2029675882);
					continue;
				case 3:
					return false;
				case 5:
					return true;
				case 6:
					goto IL_B0;
				case 7:
					return false;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_68:
			arg_72_0 = -1104389290;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? -561566070 : -1099859703);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B5:
				uint arg_91_0 = 254318555u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_91_0 ^ 127725062u)) % 6u)
					{
					case 0u:
						goto IL_B5;
					case 1u:
						arg_91_0 = ((this.ObjectId == 0uL) ? 908218046u : 860804914u);
						continue;
					case 2u:
						num ^= this.ObjectId.GetHashCode();
						arg_91_0 = (num2 * 563241025u ^ 2757642378u);
						continue;
					case 3u:
						num ^= SubscribeRequest.smethod_1(this.AgentId);
						arg_91_0 = (num2 * 1619528985u ^ 2412429730u);
						continue;
					case 5u:
						arg_91_0 = (((this.agentId_ == null) ? 3806130951u : 2557538763u) ^ num2 * 4031132772u);
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
				goto IL_1A;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 2990073722u)) % 6u)
				{
				case 0u:
					output.WriteRawTag(16);
					output.WriteUInt64(this.ObjectId);
					arg_79_0 = (num * 3464924077u ^ 3784390207u);
					continue;
				case 1u:
					output.WriteMessage(this.AgentId);
					arg_79_0 = (num * 2522487963u ^ 537492435u);
					continue;
				case 2u:
					goto IL_AC;
				case 3u:
					output.WriteRawTag(10);
					arg_79_0 = (num * 1509271991u ^ 687069666u);
					continue;
				case 4u:
					goto IL_1A;
				}
				break;
			}
			return;
			IL_1A:
			arg_79_0 = 3510113675u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.ObjectId == 0uL) ? 2414118411u : 3051966718u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 1051643815u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 1576812146u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
						arg_92_0 = (num2 * 312372767u ^ 1385872725u);
						continue;
					case 2u:
						arg_92_0 = ((this.ObjectId == 0uL) ? 331369561u : 1318824710u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_92_0 = (num2 * 783139522u ^ 4087739690u);
						continue;
					case 4u:
						goto IL_B6;
					case 5u:
						arg_92_0 = (((this.agentId_ == null) ? 2594494480u : 3643665195u) ^ num2 * 1990411992u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(SubscribeRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_FC;
			uint arg_BC_0;
			while (true)
			{
				IL_B7:
				uint num;
				switch ((num = (arg_BC_0 ^ 1032384965u)) % 9u)
				{
				case 0u:
					this.ObjectId = other.ObjectId;
					arg_BC_0 = (num * 2803386881u ^ 1578066571u);
					continue;
				case 1u:
					arg_BC_0 = (((this.agentId_ == null) ? 1462361895u : 643624556u) ^ num * 1261594336u);
					continue;
				case 2u:
					goto IL_FC;
				case 3u:
					this.agentId_ = new EntityId();
					arg_BC_0 = (num * 3313175982u ^ 462008208u);
					continue;
				case 4u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_BC_0 = 420667591u;
					continue;
				case 5u:
					arg_BC_0 = ((other.ObjectId != 0uL) ? 2019098587u : 280746133u);
					continue;
				case 6u:
					return;
				case 8u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_BC_0 = 974038732u;
			goto IL_B7;
			IL_FC:
			arg_BC_0 = ((other.agentId_ == null) ? 420667591u : 1483508802u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13A:
				uint num;
				uint arg_F2_0 = ((num = input.ReadTag()) == 0u) ? 4261659711u : 2204474475u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F2_0 ^ 3517126273u)) % 11u)
					{
					case 0u:
						arg_F2_0 = (num2 * 1455483933u ^ 1353165317u);
						continue;
					case 1u:
						this.ObjectId = input.ReadUInt64();
						arg_F2_0 = 3708605286u;
						continue;
					case 2u:
						arg_F2_0 = ((num != 10u) ? 4078289788u : 3579663696u);
						continue;
					case 3u:
						input.SkipLastField();
						arg_F2_0 = (num2 * 2229875154u ^ 1490325928u);
						continue;
					case 4u:
						goto IL_13A;
					case 5u:
						arg_F2_0 = (((num == 16u) ? 791106952u : 901800982u) ^ num2 * 928290872u);
						continue;
					case 6u:
						input.ReadMessage(this.agentId_);
						arg_F2_0 = 3673757182u;
						continue;
					case 7u:
						arg_F2_0 = 2204474475u;
						continue;
					case 8u:
						this.agentId_ = new EntityId();
						arg_F2_0 = (num2 * 1655512653u ^ 965723657u);
						continue;
					case 10u:
						arg_F2_0 = ((this.agentId_ == null) ? 3756717918u : 3488338970u);
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
