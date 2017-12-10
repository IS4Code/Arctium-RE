using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.UserManager.V1
{
	[DebuggerNonUserCode]
	public sealed class UnblockPlayerRequest : IMessage<UnblockPlayerRequest>, IEquatable<UnblockPlayerRequest>, IDeepCloneable<UnblockPlayerRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UnblockPlayerRequest.__c __9 = new UnblockPlayerRequest.__c();

			internal UnblockPlayerRequest cctor>b__29_0()
			{
				return new UnblockPlayerRequest();
			}
		}

		private static readonly MessageParser<UnblockPlayerRequest> _parser = new MessageParser<UnblockPlayerRequest>(new Func<UnblockPlayerRequest>(UnblockPlayerRequest.__c.__9.<.cctor>b__29_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public static MessageParser<UnblockPlayerRequest> Parser
		{
			get
			{
				return UnblockPlayerRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerRequest.Descriptor;
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

		public UnblockPlayerRequest()
		{
		}

		public UnblockPlayerRequest(UnblockPlayerRequest other) : this()
		{
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
			this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
		}

		public UnblockPlayerRequest Clone()
		{
			return new UnblockPlayerRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerRequest);
		}

		public bool Equals(UnblockPlayerRequest other)
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
				switch ((arg_77_0 ^ -1080615615) % 9)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 3:
					goto IL_B5;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_77_0 = ((!UnblockPlayerRequest.smethod_0(this.AgentId, other.AgentId)) ? -312585794 : -826697765);
					continue;
				case 7:
					arg_77_0 = (UnblockPlayerRequest.smethod_0(this.TargetId, other.TargetId) ? -2032231917 : -1181181148);
					continue;
				case 8:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = -1650485538;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -12730107 : -19833636);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_29;
			}
			goto IL_4F;
			uint arg_33_0;
			while (true)
			{
				IL_2E:
				uint num2;
				switch ((num2 = (arg_33_0 ^ 1620014433u)) % 4u)
				{
				case 0u:
					goto IL_29;
				case 2u:
					num ^= UnblockPlayerRequest.smethod_1(this.AgentId);
					arg_33_0 = (num2 * 2251536248u ^ 1420371394u);
					continue;
				case 3u:
					goto IL_4F;
				}
				break;
			}
			return num;
			IL_29:
			arg_33_0 = 1616755947u;
			goto IL_2E;
			IL_4F:
			num ^= UnblockPlayerRequest.smethod_1(this.TargetId);
			arg_33_0 = 1191853104u;
			goto IL_2E;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_08;
			}
			goto IL_64;
			uint arg_44_0;
			while (true)
			{
				IL_3F:
				uint num;
				switch ((num = (arg_44_0 ^ 3818996573u)) % 5u)
				{
				case 0u:
					goto IL_64;
				case 1u:
					output.WriteMessage(this.AgentId);
					arg_44_0 = (num * 1685288199u ^ 205657285u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					arg_44_0 = (num * 3268352852u ^ 1790908187u);
					continue;
				case 4u:
					goto IL_08;
				}
				break;
			}
			return;
			IL_08:
			arg_44_0 = 3741533015u;
			goto IL_3F;
			IL_64:
			output.WriteRawTag(18);
			output.WriteMessage(this.TargetId);
			arg_44_0 = 3836568719u;
			goto IL_3F;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_89:
				uint arg_69_0 = 4054574935u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_69_0 ^ 4113039442u)) % 5u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
						arg_69_0 = 3998998006u;
						continue;
					case 1u:
						arg_69_0 = (((this.agentId_ != null) ? 2305943896u : 3445942961u) ^ num2 * 527398160u);
						continue;
					case 3u:
						goto IL_89;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_69_0 = (num2 * 3211236060u ^ 373830329u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(UnblockPlayerRequest other)
		{
			if (other == null)
			{
				goto IL_91;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 4073878292u)) % 11u)
				{
				case 1u:
					return;
				case 2u:
					goto IL_14D;
				case 3u:
					arg_105_0 = (((this.agentId_ != null) ? 2727454233u : 3818587217u) ^ num * 789661808u);
					continue;
				case 4u:
					arg_105_0 = (((this.targetId_ != null) ? 147897639u : 625241341u) ^ num * 3599588614u);
					continue;
				case 5u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_105_0 = 2594769802u;
					continue;
				case 6u:
					goto IL_91;
				case 7u:
					this.agentId_ = new EntityId();
					arg_105_0 = (num * 612123116u ^ 1907294005u);
					continue;
				case 8u:
					this.targetId_ = new EntityId();
					arg_105_0 = (num * 1527872263u ^ 4151860904u);
					continue;
				case 9u:
					arg_105_0 = ((other.targetId_ == null) ? 2594769802u : 2354487072u);
					continue;
				case 10u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_105_0 = 4042079019u;
					continue;
				}
				break;
			}
			return;
			IL_91:
			arg_105_0 = 2498169340u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.agentId_ == null) ? 4042079019u : 3263671373u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) == 0u) ? 972304537u : 161256247u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 1821294324u)) % 14u)
					{
					case 0u:
						arg_145_0 = (num2 * 3794158447u ^ 2338210060u);
						continue;
					case 1u:
						arg_145_0 = ((num == 10u) ? 1071710385u : 1244105189u);
						continue;
					case 2u:
						input.ReadMessage(this.targetId_);
						arg_145_0 = 2082989480u;
						continue;
					case 3u:
						this.agentId_ = new EntityId();
						arg_145_0 = (num2 * 2369666255u ^ 1487535753u);
						continue;
					case 4u:
						arg_145_0 = ((this.targetId_ != null) ? 811884166u : 2019190460u);
						continue;
					case 6u:
						input.ReadMessage(this.agentId_);
						arg_145_0 = 1961590120u;
						continue;
					case 7u:
						arg_145_0 = ((this.agentId_ != null) ? 546579686u : 881888917u);
						continue;
					case 8u:
						this.targetId_ = new EntityId();
						arg_145_0 = (num2 * 1636628465u ^ 3087617358u);
						continue;
					case 9u:
						input.SkipLastField();
						arg_145_0 = (num2 * 2570660886u ^ 803232924u);
						continue;
					case 10u:
						arg_145_0 = (num2 * 518106187u ^ 1924697322u);
						continue;
					case 11u:
						arg_145_0 = (((num == 18u) ? 717810490u : 844991121u) ^ num2 * 2726541984u);
						continue;
					case 12u:
						goto IL_199;
					case 13u:
						arg_145_0 = 161256247u;
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
