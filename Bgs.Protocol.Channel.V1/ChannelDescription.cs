using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class ChannelDescription : IMessage<ChannelDescription>, IEquatable<ChannelDescription>, IDeepCloneable<ChannelDescription>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChannelDescription.__c __9 = new ChannelDescription.__c();

			internal ChannelDescription cctor>b__34_0()
			{
				return new ChannelDescription();
			}
		}

		private static readonly MessageParser<ChannelDescription> _parser = new MessageParser<ChannelDescription>(new Func<ChannelDescription>(ChannelDescription.__c.__9.<.cctor>b__34_0));

		public const int ChannelIdFieldNumber = 1;

		private EntityId channelId_;

		public const int CurrentMembersFieldNumber = 2;

		private uint currentMembers_;

		public const int StateFieldNumber = 3;

		private ChannelState state_;

		public static MessageParser<ChannelDescription> Parser
		{
			get
			{
				return ChannelDescription._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelDescription.Descriptor;
			}
		}

		public EntityId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		public uint CurrentMembers
		{
			get
			{
				return this.currentMembers_;
			}
			set
			{
				this.currentMembers_ = value;
			}
		}

		public ChannelState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		public ChannelDescription()
		{
		}

		public ChannelDescription(ChannelDescription other) : this()
		{
			this.ChannelId = ((other.channelId_ != null) ? other.ChannelId.Clone() : null);
			this.currentMembers_ = other.currentMembers_;
			this.State = ((other.state_ != null) ? other.State.Clone() : null);
		}

		public ChannelDescription Clone()
		{
			return new ChannelDescription(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelDescription);
		}

		public bool Equals(ChannelDescription other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_EA;
			int arg_A4_0;
			while (true)
			{
				IL_9F:
				switch ((arg_A4_0 ^ 2046504799) % 11)
				{
				case 0:
					goto IL_9A;
				case 1:
					arg_A4_0 = ((this.CurrentMembers == other.CurrentMembers) ? 846915370 : 1006972619);
					continue;
				case 2:
					arg_A4_0 = ((!ChannelDescription.smethod_0(this.ChannelId, other.ChannelId)) ? 1345199882 : 456232746);
					continue;
				case 3:
					goto IL_EA;
				case 4:
					return true;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					arg_A4_0 = ((!ChannelDescription.smethod_0(this.State, other.State)) ? 601204519 : 184215589);
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = 1978584458;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other != this) ? 1321912239 : 93397407);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_C3:
				uint arg_9F_0 = 1416415433u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9F_0 ^ 450619501u)) % 6u)
					{
					case 0u:
						num ^= this.CurrentMembers.GetHashCode();
						arg_9F_0 = (num2 * 1187102004u ^ 4093682778u);
						continue;
					case 1u:
						arg_9F_0 = ((this.state_ != null) ? 1707230778u : 600245386u);
						continue;
					case 2u:
						goto IL_C3;
					case 4u:
						num ^= ChannelDescription.smethod_1(this.ChannelId);
						arg_9F_0 = (((this.CurrentMembers == 0u) ? 2263424654u : 2927953491u) ^ num2 * 3243061271u);
						continue;
					case 5u:
						num ^= this.State.GetHashCode();
						arg_9F_0 = (num2 * 3005897316u ^ 1063234422u);
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
			output.WriteRawTag(10);
			output.WriteMessage(this.ChannelId);
			while (true)
			{
				IL_E3:
				uint arg_BB_0 = 3821350917u;
				while (true)
				{
					uint num;
					switch ((num = (arg_BB_0 ^ 3568933640u)) % 7u)
					{
					case 0u:
						goto IL_E3;
					case 1u:
						arg_BB_0 = ((this.state_ == null) ? 3739044711u : 4109591429u);
						continue;
					case 2u:
						output.WriteUInt32(this.CurrentMembers);
						arg_BB_0 = (num * 2402720761u ^ 3911584534u);
						continue;
					case 3u:
						output.WriteRawTag(16);
						arg_BB_0 = (num * 3892087012u ^ 985658767u);
						continue;
					case 4u:
						output.WriteRawTag(26);
						output.WriteMessage(this.State);
						arg_BB_0 = (num * 3324236952u ^ 2504137951u);
						continue;
					case 6u:
						arg_BB_0 = (((this.CurrentMembers == 0u) ? 1480447892u : 1748754294u) ^ num * 2054891013u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_C6:
				uint arg_A2_0 = 3076204234u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A2_0 ^ 4057165412u)) % 6u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
						arg_A2_0 = (num2 * 728019647u ^ 2076669273u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
						arg_A2_0 = (((this.CurrentMembers != 0u) ? 2174749568u : 4236279133u) ^ num2 * 2674566030u);
						continue;
					case 3u:
						arg_A2_0 = ((this.state_ == null) ? 3440703544u : 2732329403u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrentMembers);
						arg_A2_0 = (num2 * 1497773107u ^ 1793820665u);
						continue;
					case 5u:
						goto IL_C6;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ChannelDescription other)
		{
			if (other == null)
			{
				goto IL_F9;
			}
			goto IL_194;
			uint arg_144_0;
			while (true)
			{
				IL_13F:
				uint num;
				switch ((num = (arg_144_0 ^ 1474351934u)) % 13u)
				{
				case 0u:
					arg_144_0 = (((this.channelId_ != null) ? 2551212750u : 3062630265u) ^ num * 1834309727u);
					continue;
				case 1u:
					this.ChannelId.MergeFrom(other.ChannelId);
					arg_144_0 = 1187251169u;
					continue;
				case 2u:
					goto IL_F9;
				case 3u:
					this.State.MergeFrom(other.State);
					arg_144_0 = 1714037548u;
					continue;
				case 4u:
					this.state_ = new ChannelState();
					arg_144_0 = (num * 4195487943u ^ 1139411475u);
					continue;
				case 5u:
					arg_144_0 = ((other.state_ == null) ? 1714037548u : 846180196u);
					continue;
				case 6u:
					this.channelId_ = new EntityId();
					arg_144_0 = (num * 1451572234u ^ 287452827u);
					continue;
				case 7u:
					arg_144_0 = (((this.state_ == null) ? 3035630396u : 2180371233u) ^ num * 3381352313u);
					continue;
				case 8u:
					return;
				case 9u:
					this.CurrentMembers = other.CurrentMembers;
					arg_144_0 = (num * 86838970u ^ 1765423418u);
					continue;
				case 10u:
					arg_144_0 = ((other.CurrentMembers == 0u) ? 155982310u : 1687855736u);
					continue;
				case 11u:
					goto IL_194;
				}
				break;
			}
			return;
			IL_F9:
			arg_144_0 = 2135228096u;
			goto IL_13F;
			IL_194:
			arg_144_0 = ((other.channelId_ != null) ? 1976941017u : 1187251169u);
			goto IL_13F;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1E0:
				uint num;
				uint arg_184_0 = ((num = input.ReadTag()) != 0u) ? 4195482220u : 3491581390u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_184_0 ^ 3536010821u)) % 16u)
					{
					case 0u:
						input.ReadMessage(this.channelId_);
						arg_184_0 = 3901412996u;
						continue;
					case 1u:
						arg_184_0 = (num2 * 1782905110u ^ 1378722686u);
						continue;
					case 2u:
						input.ReadMessage(this.state_);
						arg_184_0 = 4046199528u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_184_0 = (num2 * 1391204162u ^ 61793038u);
						continue;
					case 4u:
						arg_184_0 = (((num == 16u) ? 3904248211u : 3289105210u) ^ num2 * 2021271080u);
						continue;
					case 5u:
						arg_184_0 = ((this.channelId_ == null) ? 4093055321u : 3909445221u);
						continue;
					case 6u:
						this.CurrentMembers = input.ReadUInt32();
						arg_184_0 = 3461028031u;
						continue;
					case 7u:
						arg_184_0 = ((this.state_ == null) ? 3995700621u : 2960989895u);
						continue;
					case 8u:
						this.state_ = new ChannelState();
						arg_184_0 = (num2 * 3920718553u ^ 2530617935u);
						continue;
					case 9u:
						arg_184_0 = ((num == 10u) ? 3549746576u : 2392855777u);
						continue;
					case 10u:
						arg_184_0 = (num2 * 71520354u ^ 1654067548u);
						continue;
					case 12u:
						this.channelId_ = new EntityId();
						arg_184_0 = (num2 * 1104743643u ^ 227605137u);
						continue;
					case 13u:
						goto IL_1E0;
					case 14u:
						arg_184_0 = 4195482220u;
						continue;
					case 15u:
						arg_184_0 = (((num == 26u) ? 620678519u : 99632627u) ^ num2 * 1814017019u);
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
