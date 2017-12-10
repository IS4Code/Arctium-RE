using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UnsubscribeRequest.__c __9 = new UnsubscribeRequest.__c();

			internal UnsubscribeRequest cctor>b__29_0()
			{
				return new UnsubscribeRequest();
			}
		}

		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(new Func<UnsubscribeRequest>(UnsubscribeRequest.__c.__9.<.cctor>b__29_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int ObjectIdFieldNumber = 2;

		private ulong objectId_;

		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
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

		public UnsubscribeRequest()
		{
		}

		public UnsubscribeRequest(UnsubscribeRequest other) : this()
		{
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.objectId_ = other.objectId_;
		}

		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		public bool Equals(UnsubscribeRequest other)
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
				switch ((arg_72_0 ^ -304877262) % 9)
				{
				case 0:
					goto IL_68;
				case 1:
					return false;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					arg_72_0 = (UnsubscribeRequest.smethod_0(this.AgentId, other.AgentId) ? -1573996996 : -33617732);
					continue;
				case 6:
					arg_72_0 = ((this.ObjectId != other.ObjectId) ? -1497858698 : -1968092609);
					continue;
				case 7:
					goto IL_B0;
				case 8:
					return true;
				}
				break;
			}
			return true;
			IL_68:
			arg_72_0 = -1232442463;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? -33235590 : -1892949402);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_59;
			}
			goto IL_8F;
			uint arg_63_0;
			while (true)
			{
				IL_5E:
				uint num2;
				switch ((num2 = (arg_63_0 ^ 2124936921u)) % 5u)
				{
				case 0u:
					goto IL_59;
				case 2u:
					num ^= this.ObjectId.GetHashCode();
					arg_63_0 = (num2 * 2810306144u ^ 2864027254u);
					continue;
				case 3u:
					num ^= UnsubscribeRequest.smethod_1(this.AgentId);
					arg_63_0 = (num2 * 438756323u ^ 553925360u);
					continue;
				case 4u:
					goto IL_8F;
				}
				break;
			}
			return num;
			IL_59:
			arg_63_0 = 430220685u;
			goto IL_5E;
			IL_8F:
			arg_63_0 = ((this.ObjectId != 0uL) ? 1724913187u : 1018347446u);
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
				goto IL_54;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 797955594u)) % 6u)
				{
				case 0u:
					output.WriteUInt64(this.ObjectId);
					arg_79_0 = (num * 4220964830u ^ 3976816034u);
					continue;
				case 1u:
					goto IL_AC;
				case 3u:
					goto IL_54;
				case 4u:
					output.WriteRawTag(16);
					arg_79_0 = (num * 1770370025u ^ 2717452892u);
					continue;
				case 5u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_79_0 = (num * 3968430777u ^ 2683497116u);
					continue;
				}
				break;
			}
			return;
			IL_54:
			arg_79_0 = 1058741007u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.ObjectId == 0uL) ? 42350722u : 47242556u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 2320889073u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 3657885092u)) % 6u)
					{
					case 0u:
						arg_92_0 = ((this.ObjectId != 0uL) ? 3040273037u : 2498949952u);
						continue;
					case 1u:
						arg_92_0 = (((this.agentId_ != null) ? 2849537220u : 2424113324u) ^ num2 * 3546509296u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
						arg_92_0 = (num2 * 501309544u ^ 2328476648u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_92_0 = (num2 * 2187746761u ^ 1783700556u);
						continue;
					case 5u:
						goto IL_B6;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(UnsubscribeRequest other)
		{
			if (other == null)
			{
				goto IL_36;
			}
			goto IL_FC;
			uint arg_BC_0;
			while (true)
			{
				IL_B7:
				uint num;
				switch ((num = (arg_BC_0 ^ 2929278214u)) % 9u)
				{
				case 1u:
					this.agentId_ = new EntityId();
					arg_BC_0 = (num * 82848877u ^ 2149784941u);
					continue;
				case 2u:
					return;
				case 3u:
					arg_BC_0 = ((other.ObjectId != 0uL) ? 2757303966u : 3557770087u);
					continue;
				case 4u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_BC_0 = 2400598654u;
					continue;
				case 5u:
					arg_BC_0 = (((this.agentId_ != null) ? 3780531261u : 3991805982u) ^ num * 204345534u);
					continue;
				case 6u:
					goto IL_FC;
				case 7u:
					goto IL_36;
				case 8u:
					this.ObjectId = other.ObjectId;
					arg_BC_0 = (num * 3742347177u ^ 991634495u);
					continue;
				}
				break;
			}
			return;
			IL_36:
			arg_BC_0 = 3407347836u;
			goto IL_B7;
			IL_FC:
			arg_BC_0 = ((other.agentId_ != null) ? 4133289711u : 2400598654u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13D:
				uint num;
				uint arg_F5_0 = ((num = input.ReadTag()) == 0u) ? 2686190629u : 2656074695u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F5_0 ^ 3152596353u)) % 11u)
					{
					case 0u:
						input.SkipLastField();
						arg_F5_0 = (num2 * 889023639u ^ 3962272604u);
						continue;
					case 1u:
						arg_F5_0 = (((num == 16u) ? 1396525188u : 2104148930u) ^ num2 * 1474336065u);
						continue;
					case 2u:
						goto IL_13D;
					case 3u:
						input.ReadMessage(this.agentId_);
						arg_F5_0 = 3961758934u;
						continue;
					case 4u:
						arg_F5_0 = ((num == 10u) ? 2604372474u : 3108732788u);
						continue;
					case 5u:
						arg_F5_0 = ((this.agentId_ == null) ? 3620003948u : 3814360187u);
						continue;
					case 6u:
						arg_F5_0 = 2656074695u;
						continue;
					case 8u:
						arg_F5_0 = (num2 * 4023428208u ^ 2483273670u);
						continue;
					case 9u:
						this.ObjectId = input.ReadUInt64();
						arg_F5_0 = 3961758934u;
						continue;
					case 10u:
						this.agentId_ = new EntityId();
						arg_F5_0 = (num2 * 572067144u ^ 1136424915u);
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
