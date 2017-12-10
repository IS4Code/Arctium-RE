using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class ServerStateChangeRequest : IMessage<ServerStateChangeRequest>, IEquatable<ServerStateChangeRequest>, IDeepCloneable<ServerStateChangeRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ServerStateChangeRequest.__c __9 = new ServerStateChangeRequest.__c();

			internal ServerStateChangeRequest cctor>b__29_0()
			{
				return new ServerStateChangeRequest();
			}
		}

		private static readonly MessageParser<ServerStateChangeRequest> _parser = new MessageParser<ServerStateChangeRequest>(new Func<ServerStateChangeRequest>(ServerStateChangeRequest.__c.__9.<.cctor>b__29_0));

		public const int StateFieldNumber = 1;

		private uint state_;

		public const int EventTimeFieldNumber = 2;

		private ulong eventTime_;

		public static MessageParser<ServerStateChangeRequest> Parser
		{
			get
			{
				return ServerStateChangeRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerStateChangeRequest.Descriptor;
			}
		}

		public uint State
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

		public ulong EventTime
		{
			get
			{
				return this.eventTime_;
			}
			set
			{
				this.eventTime_ = value;
			}
		}

		public ServerStateChangeRequest()
		{
		}

		public ServerStateChangeRequest(ServerStateChangeRequest other) : this()
		{
			this.state_ = other.state_;
			this.eventTime_ = other.eventTime_;
		}

		public ServerStateChangeRequest Clone()
		{
			return new ServerStateChangeRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ServerStateChangeRequest);
		}

		public bool Equals(ServerStateChangeRequest other)
		{
			if (other == null)
			{
				goto IL_63;
			}
			goto IL_AB;
			int arg_6D_0;
			while (true)
			{
				IL_68:
				switch ((arg_6D_0 ^ -766521251) % 9)
				{
				case 0:
					goto IL_63;
				case 1:
					arg_6D_0 = ((this.EventTime == other.EventTime) ? -976614896 : -537790860);
					continue;
				case 2:
					return false;
				case 3:
					return true;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_AB;
				case 8:
					arg_6D_0 = ((this.State != other.State) ? -185141077 : -454472011);
					continue;
				}
				break;
			}
			return true;
			IL_63:
			arg_6D_0 = -913275660;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other == this) ? -1314109242 : -1986532506);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ this.State.GetHashCode();
			while (true)
			{
				IL_7D:
				uint arg_61_0 = 1933829920u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_61_0 ^ 1310892299u)) % 4u)
					{
					case 0u:
						goto IL_7D;
					case 2u:
						num ^= this.EventTime.GetHashCode();
						arg_61_0 = (num2 * 3849305158u ^ 1705997890u);
						continue;
					case 3u:
						arg_61_0 = (((this.EventTime != 0uL) ? 2506352908u : 2429052387u) ^ num2 * 2011229303u);
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
			output.WriteRawTag(8);
			while (true)
			{
				IL_80:
				uint arg_64_0 = 3682491963u;
				while (true)
				{
					uint num;
					switch ((num = (arg_64_0 ^ 3008260438u)) % 4u)
					{
					case 1u:
						output.WriteUInt32(this.State);
						arg_64_0 = (((this.EventTime != 0uL) ? 835662229u : 839037182u) ^ num * 4255600372u);
						continue;
					case 2u:
						goto IL_80;
					case 3u:
						output.WriteRawTag(16);
						output.WriteUInt64(this.EventTime);
						arg_64_0 = (num * 151044193u ^ 1776043741u);
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
				IL_7B:
				uint arg_5F_0 = 822434406u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5F_0 ^ 1700782576u)) % 4u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.EventTime);
						arg_5F_0 = (num2 * 2947593424u ^ 458467596u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.State);
						arg_5F_0 = (((this.EventTime != 0uL) ? 4164915779u : 3494540670u) ^ num2 * 1791304275u);
						continue;
					case 3u:
						goto IL_7B;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ServerStateChangeRequest other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 1463706737u)) % 7u)
				{
				case 0u:
					goto IL_AD;
				case 2u:
					this.EventTime = other.EventTime;
					arg_76_0 = (num * 952900555u ^ 2799166500u);
					continue;
				case 3u:
					arg_76_0 = ((other.EventTime == 0uL) ? 569441771u : 350119420u);
					continue;
				case 4u:
					this.State = other.State;
					arg_76_0 = (num * 450246728u ^ 1779397740u);
					continue;
				case 5u:
					goto IL_15;
				case 6u:
					return;
				}
				break;
			}
			return;
			IL_15:
			arg_76_0 = 796026943u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.State != 0u) ? 602192139u : 804490812u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_ED:
				uint num;
				uint arg_AD_0 = ((num = input.ReadTag()) != 0u) ? 3948936863u : 2166709905u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AD_0 ^ 3886217839u)) % 9u)
					{
					case 0u:
						goto IL_ED;
					case 1u:
						input.SkipLastField();
						arg_AD_0 = (num2 * 3005060835u ^ 662387702u);
						continue;
					case 2u:
						arg_AD_0 = 3948936863u;
						continue;
					case 3u:
						this.State = input.ReadUInt32();
						arg_AD_0 = 3285781335u;
						continue;
					case 5u:
						arg_AD_0 = ((num == 8u) ? 2871882118u : 3355946462u);
						continue;
					case 6u:
						arg_AD_0 = (num2 * 2693540768u ^ 965975511u);
						continue;
					case 7u:
						this.EventTime = input.ReadUInt64();
						arg_AD_0 = 3285781335u;
						continue;
					case 8u:
						arg_AD_0 = (((num == 16u) ? 728833844u : 878954145u) ^ num2 * 1101177153u);
						continue;
					}
					return;
				}
			}
		}
	}
}
