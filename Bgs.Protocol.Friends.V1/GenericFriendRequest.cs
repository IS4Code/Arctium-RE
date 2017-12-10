using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class GenericFriendRequest : IMessage<GenericFriendRequest>, IEquatable<GenericFriendRequest>, IDeepCloneable<GenericFriendRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GenericFriendRequest.__c __9 = new GenericFriendRequest.__c();

			internal GenericFriendRequest cctor>b__29_0()
			{
				return new GenericFriendRequest();
			}
		}

		private static readonly MessageParser<GenericFriendRequest> _parser = new MessageParser<GenericFriendRequest>(new Func<GenericFriendRequest>(GenericFriendRequest.__c.__9.<.cctor>b__29_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public static MessageParser<GenericFriendRequest> Parser
		{
			get
			{
				return GenericFriendRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenericFriendRequest.Descriptor;
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

		public GenericFriendRequest()
		{
		}

		public GenericFriendRequest(GenericFriendRequest other) : this()
		{
			while (true)
			{
				IL_6B:
				int arg_51_0 = -1769167465;
				while (true)
				{
					switch ((arg_51_0 ^ -1061202310) % 4)
					{
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_51_0 = -1525466811;
						continue;
					case 2:
						goto IL_6B;
					case 3:
						this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
						arg_51_0 = -545987710;
						continue;
					}
					return;
				}
			}
		}

		public GenericFriendRequest Clone()
		{
			return new GenericFriendRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GenericFriendRequest);
		}

		public bool Equals(GenericFriendRequest other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -1860283739) % 9)
				{
				case 0:
					arg_77_0 = (GenericFriendRequest.smethod_0(this.TargetId, other.TargetId) ? -98439076 : -346671962);
					continue;
				case 1:
					arg_77_0 = (GenericFriendRequest.smethod_0(this.AgentId, other.AgentId) ? -1907050549 : -62759731);
					continue;
				case 2:
					return false;
				case 3:
					goto IL_15;
				case 4:
					return false;
				case 6:
					goto IL_B5;
				case 7:
					return true;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = -801990966;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -1403838190 : -954584787);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_82:
				uint arg_62_0 = 3158628982u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_62_0 ^ 2731630826u)) % 5u)
					{
					case 1u:
						arg_62_0 = (((this.agentId_ != null) ? 3265966908u : 3041553322u) ^ num2 * 15132194u);
						continue;
					case 2u:
						num ^= GenericFriendRequest.smethod_1(this.TargetId);
						arg_62_0 = 2288898611u;
						continue;
					case 3u:
						goto IL_82;
					case 4u:
						num ^= GenericFriendRequest.smethod_1(this.AgentId);
						arg_62_0 = (num2 * 941641243u ^ 574282632u);
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
				while (true)
				{
					IL_48:
					uint arg_30_0 = 277281187u;
					while (true)
					{
						uint num;
						switch ((num = (arg_30_0 ^ 1485119358u)) % 3u)
						{
						case 0u:
							goto IL_48;
						case 1u:
							output.WriteRawTag(10);
							output.WriteMessage(this.AgentId);
							arg_30_0 = (num * 873180222u ^ 3904595473u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			output.WriteRawTag(18);
			output.WriteMessage(this.TargetId);
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_89:
				uint arg_69_0 = 4274343253u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_69_0 ^ 3099769084u)) % 5u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
						arg_69_0 = 3033845632u;
						continue;
					case 1u:
						arg_69_0 = (((this.agentId_ == null) ? 3400025064u : 3863435819u) ^ num2 * 320257852u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_69_0 = (num2 * 1147961950u ^ 2558937342u);
						continue;
					case 4u:
						goto IL_89;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GenericFriendRequest other)
		{
			if (other == null)
			{
				goto IL_B8;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 1770346009u)) % 11u)
				{
				case 0u:
					arg_105_0 = (((this.targetId_ == null) ? 2803641358u : 3123181053u) ^ num * 3041475787u);
					continue;
				case 1u:
					this.targetId_ = new EntityId();
					arg_105_0 = (num * 439228546u ^ 3024869890u);
					continue;
				case 2u:
					goto IL_B8;
				case 4u:
					arg_105_0 = ((other.targetId_ != null) ? 74644244u : 1544751990u);
					continue;
				case 5u:
					arg_105_0 = (((this.agentId_ == null) ? 1567005567u : 349602231u) ^ num * 3524414844u);
					continue;
				case 6u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_105_0 = 244454445u;
					continue;
				case 7u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_105_0 = 1544751990u;
					continue;
				case 8u:
					return;
				case 9u:
					this.agentId_ = new EntityId();
					arg_105_0 = (num * 4184888894u ^ 307986255u);
					continue;
				case 10u:
					goto IL_14D;
				}
				break;
			}
			return;
			IL_B8:
			arg_105_0 = 1434804335u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.agentId_ != null) ? 997766454u : 244454445u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) != 0u) ? 2929253875u : 3003513306u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 3314063892u)) % 14u)
					{
					case 0u:
						arg_145_0 = (num2 * 1545253477u ^ 2982706438u);
						continue;
					case 1u:
						input.SkipLastField();
						arg_145_0 = (num2 * 4253323229u ^ 820297330u);
						continue;
					case 2u:
						goto IL_199;
					case 3u:
						arg_145_0 = ((num != 10u) ? 2218615678u : 3065377141u);
						continue;
					case 4u:
						this.targetId_ = new EntityId();
						arg_145_0 = (num2 * 208808799u ^ 1272487332u);
						continue;
					case 5u:
						arg_145_0 = 2929253875u;
						continue;
					case 6u:
						arg_145_0 = ((this.targetId_ != null) ? 3817645340u : 2850234460u);
						continue;
					case 7u:
						this.agentId_ = new EntityId();
						arg_145_0 = (num2 * 4030176011u ^ 2883531536u);
						continue;
					case 9u:
						arg_145_0 = (num2 * 3439069674u ^ 1475273204u);
						continue;
					case 10u:
						arg_145_0 = (((num != 18u) ? 2200407999u : 3502114538u) ^ num2 * 2582940554u);
						continue;
					case 11u:
						input.ReadMessage(this.agentId_);
						arg_145_0 = 3069001684u;
						continue;
					case 12u:
						input.ReadMessage(this.targetId_);
						arg_145_0 = 3088161222u;
						continue;
					case 13u:
						arg_145_0 = ((this.agentId_ == null) ? 2269593761u : 3471036375u);
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
