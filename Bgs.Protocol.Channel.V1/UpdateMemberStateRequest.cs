using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class UpdateMemberStateRequest : IMessage<UpdateMemberStateRequest>, IEquatable<UpdateMemberStateRequest>, IDeepCloneable<UpdateMemberStateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UpdateMemberStateRequest.__c __9 = new UpdateMemberStateRequest.__c();

			internal UpdateMemberStateRequest cctor>b__34_0()
			{
				return new UpdateMemberStateRequest();
			}
		}

		private static readonly MessageParser<UpdateMemberStateRequest> _parser = new MessageParser<UpdateMemberStateRequest>(new Func<UpdateMemberStateRequest>(UpdateMemberStateRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int StateChangeFieldNumber = 2;

		private static readonly FieldCodec<Member> _repeated_stateChange_codec = FieldCodec.ForMessage<Member>(18u, Member.Parser);

		private readonly RepeatedField<Member> stateChange_ = new RepeatedField<Member>();

		public const int RemovedRoleFieldNumber = 3;

		private static readonly FieldCodec<uint> _repeated_removedRole_codec = FieldCodec.ForUInt32(26u);

		private readonly RepeatedField<uint> removedRole_ = new RepeatedField<uint>();

		public static MessageParser<UpdateMemberStateRequest> Parser
		{
			get
			{
				return UpdateMemberStateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMemberStateRequest.Descriptor;
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

		public RepeatedField<Member> StateChange
		{
			get
			{
				return this.stateChange_;
			}
		}

		public RepeatedField<uint> RemovedRole
		{
			get
			{
				return this.removedRole_;
			}
		}

		public UpdateMemberStateRequest()
		{
		}

		public UpdateMemberStateRequest(UpdateMemberStateRequest other) : this()
		{
			while (true)
			{
				IL_66:
				int arg_50_0 = 850845766;
				while (true)
				{
					switch ((arg_50_0 ^ 736126315) % 3)
					{
					case 1:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						this.stateChange_ = other.stateChange_.Clone();
						this.removedRole_ = other.removedRole_.Clone();
						arg_50_0 = 554002508;
						continue;
					case 2:
						goto IL_66;
					}
					return;
				}
			}
		}

		public UpdateMemberStateRequest Clone()
		{
			return new UpdateMemberStateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMemberStateRequest);
		}

		public bool Equals(UpdateMemberStateRequest other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ -631403506) % 11)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					arg_A6_0 = (this.stateChange_.Equals(other.stateChange_) ? -828941427 : -2146904447);
					continue;
				case 5:
					arg_A6_0 = ((!UpdateMemberStateRequest.smethod_0(this.AgentId, other.AgentId)) ? -1461638918 : -1202750806);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					goto IL_EC;
				case 9:
					goto IL_44;
				case 10:
					arg_A6_0 = ((!this.removedRole_.Equals(other.removedRole_)) ? -729071986 : -765786416);
					continue;
				}
				break;
			}
			return true;
			IL_44:
			arg_A6_0 = -173499904;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other != this) ? -1435839128 : -2054833209);
			goto IL_A1;
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
				switch ((num2 = (arg_33_0 ^ 2575251654u)) % 4u)
				{
				case 0u:
					goto IL_29;
				case 1u:
					num ^= UpdateMemberStateRequest.smethod_1(this.AgentId);
					arg_33_0 = (num2 * 1771267578u ^ 693058726u);
					continue;
				case 2u:
					goto IL_4F;
				}
				break;
			}
			return num ^ UpdateMemberStateRequest.smethod_1(this.removedRole_);
			IL_29:
			arg_33_0 = 3156074159u;
			goto IL_2E;
			IL_4F:
			num ^= UpdateMemberStateRequest.smethod_1(this.stateChange_);
			arg_33_0 = 3096065537u;
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
				while (true)
				{
					IL_48:
					uint arg_30_0 = 833414229u;
					while (true)
					{
						uint num;
						switch ((num = (arg_30_0 ^ 222512655u)) % 3u)
						{
						case 0u:
							goto IL_48;
						case 2u:
							output.WriteRawTag(10);
							output.WriteMessage(this.AgentId);
							arg_30_0 = (num * 3600838038u ^ 1693871099u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			this.stateChange_.WriteTo(output, UpdateMemberStateRequest._repeated_stateChange_codec);
			this.removedRole_.WriteTo(output, UpdateMemberStateRequest._repeated_removedRole_codec);
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_0A;
			}
			goto IL_75;
			uint arg_55_0;
			while (true)
			{
				IL_50:
				uint num2;
				switch ((num2 = (arg_55_0 ^ 2237752594u)) % 5u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_55_0 = (num2 * 4209147650u ^ 2769747269u);
					continue;
				case 2u:
					goto IL_75;
				case 3u:
					num += this.removedRole_.CalculateSize(UpdateMemberStateRequest._repeated_removedRole_codec);
					arg_55_0 = (num2 * 690402857u ^ 2271886010u);
					continue;
				case 4u:
					goto IL_0A;
				}
				break;
			}
			return num;
			IL_0A:
			arg_55_0 = 4064576427u;
			goto IL_50;
			IL_75:
			num += this.stateChange_.CalculateSize(UpdateMemberStateRequest._repeated_stateChange_codec);
			arg_55_0 = 3818084292u;
			goto IL_50;
		}

		public void MergeFrom(UpdateMemberStateRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_F8;
			uint arg_B8_0;
			while (true)
			{
				IL_B3:
				uint num;
				switch ((num = (arg_B8_0 ^ 3547188952u)) % 9u)
				{
				case 0u:
					this.agentId_ = new EntityId();
					arg_B8_0 = (num * 2373240021u ^ 2613452947u);
					continue;
				case 1u:
					arg_B8_0 = (((this.agentId_ != null) ? 1906028511u : 86352164u) ^ num * 1082708184u);
					continue;
				case 2u:
					this.removedRole_.Add(other.removedRole_);
					arg_B8_0 = (num * 2512516360u ^ 1608729529u);
					continue;
				case 3u:
					this.stateChange_.Add(other.stateChange_);
					arg_B8_0 = 2698152107u;
					continue;
				case 4u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_B8_0 = 4150654416u;
					continue;
				case 5u:
					goto IL_F8;
				case 6u:
					return;
				case 7u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_B8_0 = 2818641096u;
			goto IL_B3;
			IL_F8:
			arg_B8_0 = ((other.agentId_ == null) ? 4150654416u : 3116224766u);
			goto IL_B3;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_204:
				uint num;
				uint arg_1A4_0 = ((num = input.ReadTag()) != 0u) ? 1513284915u : 1074130050u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1A4_0 ^ 222716253u)) % 17u)
					{
					case 0u:
						goto IL_204;
					case 1u:
						arg_1A4_0 = (((num != 18u) ? 3130216117u : 3447243854u) ^ num2 * 2631972990u);
						continue;
					case 2u:
						arg_1A4_0 = (((num == 26u) ? 3092510051u : 2645237550u) ^ num2 * 2388803022u);
						continue;
					case 3u:
						arg_1A4_0 = ((num > 18u) ? 1759275716u : 233478955u);
						continue;
					case 4u:
						input.ReadMessage(this.agentId_);
						arg_1A4_0 = 1412306154u;
						continue;
					case 5u:
						arg_1A4_0 = 1513284915u;
						continue;
					case 6u:
						arg_1A4_0 = (num2 * 3166653711u ^ 4068922146u);
						continue;
					case 7u:
						arg_1A4_0 = (num2 * 1815726153u ^ 1014297157u);
						continue;
					case 8u:
						this.removedRole_.AddEntriesFrom(input, UpdateMemberStateRequest._repeated_removedRole_codec);
						arg_1A4_0 = 1412306154u;
						continue;
					case 9u:
						this.stateChange_.AddEntriesFrom(input, UpdateMemberStateRequest._repeated_stateChange_codec);
						arg_1A4_0 = 1698268778u;
						continue;
					case 10u:
						this.agentId_ = new EntityId();
						arg_1A4_0 = (num2 * 4116891937u ^ 1824788916u);
						continue;
					case 11u:
						arg_1A4_0 = ((num == 24u) ? 397865155u : 672300525u);
						continue;
					case 12u:
						arg_1A4_0 = ((this.agentId_ == null) ? 2064803633u : 1744014936u);
						continue;
					case 13u:
						arg_1A4_0 = (((num == 10u) ? 1914118777u : 147718191u) ^ num2 * 2887819080u);
						continue;
					case 14u:
						input.SkipLastField();
						arg_1A4_0 = 99297063u;
						continue;
					case 16u:
						arg_1A4_0 = (num2 * 3216037854u ^ 3531441958u);
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
