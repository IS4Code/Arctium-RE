using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
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
				return UserManagerServiceReflection.Descriptor.MessageTypes[2];
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
			while (true)
			{
				IL_50:
				int arg_3A_0 = 53113771;
				while (true)
				{
					switch ((arg_3A_0 ^ 308823771) % 3)
					{
					case 0:
						goto IL_50;
					case 2:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.objectId_ = other.objectId_;
						arg_3A_0 = 669613438;
						continue;
					}
					return;
				}
			}
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
				switch ((arg_72_0 ^ 2011978474) % 9)
				{
				case 0:
					goto IL_68;
				case 1:
					arg_72_0 = ((!UnsubscribeRequest.smethod_0(this.AgentId, other.AgentId)) ? 899015468 : 1289550483);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_72_0 = ((this.ObjectId == other.ObjectId) ? 1402616943 : 1968628643);
					continue;
				case 5:
					goto IL_B0;
				case 6:
					return false;
				case 7:
					return true;
				}
				break;
			}
			return true;
			IL_68:
			arg_72_0 = 812173420;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? 122967666 : 819544496);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B5:
				uint arg_91_0 = 957382711u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_91_0 ^ 266380538u)) % 6u)
					{
					case 0u:
						goto IL_B5;
					case 1u:
						arg_91_0 = (((this.agentId_ != null) ? 2107970885u : 1526292114u) ^ num2 * 1607028076u);
						continue;
					case 2u:
						arg_91_0 = ((this.ObjectId != 0uL) ? 243702259u : 638901678u);
						continue;
					case 3u:
						num ^= UnsubscribeRequest.smethod_1(this.AgentId);
						arg_91_0 = (num2 * 1112384014u ^ 1419666756u);
						continue;
					case 5u:
						num ^= this.ObjectId.GetHashCode();
						arg_91_0 = (num2 * 3849047431u ^ 228178193u);
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
				goto IL_60;
			}
			goto IL_96;
			uint arg_6A_0;
			while (true)
			{
				IL_65:
				uint num;
				switch ((num = (arg_6A_0 ^ 1872623450u)) % 5u)
				{
				case 0u:
					goto IL_60;
				case 1u:
					goto IL_96;
				case 2u:
					output.WriteRawTag(16);
					output.WriteUInt64(this.ObjectId);
					arg_6A_0 = (num * 1750379039u ^ 2900124129u);
					continue;
				case 3u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentId);
					arg_6A_0 = (num * 120492324u ^ 2334261026u);
					continue;
				}
				break;
			}
			return;
			IL_60:
			arg_6A_0 = 1926634185u;
			goto IL_65;
			IL_96:
			arg_6A_0 = ((this.ObjectId != 0uL) ? 1230744603u : 1865307966u);
			goto IL_65;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_1C;
			}
			goto IL_90;
			uint arg_64_0;
			while (true)
			{
				IL_5F:
				uint num2;
				switch ((num2 = (arg_64_0 ^ 3248366680u)) % 5u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
					arg_64_0 = (num2 * 760999335u ^ 3255579595u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_64_0 = (num2 * 481811305u ^ 2340939108u);
					continue;
				case 2u:
					goto IL_1C;
				case 4u:
					goto IL_90;
				}
				break;
			}
			return num;
			IL_1C:
			arg_64_0 = 2693288099u;
			goto IL_5F;
			IL_90:
			arg_64_0 = ((this.ObjectId != 0uL) ? 2879044080u : 3282260819u);
			goto IL_5F;
		}

		public void MergeFrom(UnsubscribeRequest other)
		{
			if (other == null)
			{
				goto IL_5F;
			}
			goto IL_FC;
			uint arg_BC_0;
			while (true)
			{
				IL_B7:
				uint num;
				switch ((num = (arg_BC_0 ^ 658700164u)) % 9u)
				{
				case 0u:
					arg_BC_0 = ((other.ObjectId != 0uL) ? 1704888739u : 1902013505u);
					continue;
				case 2u:
					goto IL_FC;
				case 3u:
					this.agentId_ = new EntityId();
					arg_BC_0 = (num * 3466514115u ^ 3137619380u);
					continue;
				case 4u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_BC_0 = 2002688384u;
					continue;
				case 5u:
					goto IL_5F;
				case 6u:
					arg_BC_0 = (((this.agentId_ != null) ? 2645841760u : 2969614784u) ^ num * 2389102190u);
					continue;
				case 7u:
					this.ObjectId = other.ObjectId;
					arg_BC_0 = (num * 861942774u ^ 838636091u);
					continue;
				case 8u:
					return;
				}
				break;
			}
			return;
			IL_5F:
			arg_BC_0 = 113857904u;
			goto IL_B7;
			IL_FC:
			arg_BC_0 = ((other.agentId_ == null) ? 2002688384u : 498547382u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_14D:
				uint num;
				uint arg_101_0 = ((num = input.ReadTag()) == 0u) ? 1978932372u : 2074778328u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_101_0 ^ 1929955651u)) % 12u)
					{
					case 0u:
						arg_101_0 = ((this.agentId_ == null) ? 1106593338u : 1555752573u);
						continue;
					case 1u:
						input.SkipLastField();
						arg_101_0 = (num2 * 428860982u ^ 663949530u);
						continue;
					case 2u:
						arg_101_0 = (num2 * 436605743u ^ 2408102133u);
						continue;
					case 3u:
						arg_101_0 = ((num != 10u) ? 1786854149u : 1339859487u);
						continue;
					case 4u:
						arg_101_0 = 2074778328u;
						continue;
					case 5u:
						this.ObjectId = input.ReadUInt64();
						arg_101_0 = 153735471u;
						continue;
					case 6u:
						arg_101_0 = (((num != 16u) ? 1221705688u : 171315788u) ^ num2 * 154348623u);
						continue;
					case 7u:
						arg_101_0 = (num2 * 1295685286u ^ 2537560149u);
						continue;
					case 8u:
						goto IL_14D;
					case 9u:
						this.agentId_ = new EntityId();
						arg_101_0 = (num2 * 2822686883u ^ 3932947574u);
						continue;
					case 10u:
						input.ReadMessage(this.agentId_);
						arg_101_0 = 1859324933u;
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
