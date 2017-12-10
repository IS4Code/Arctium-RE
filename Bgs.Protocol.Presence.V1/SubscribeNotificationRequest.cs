using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class SubscribeNotificationRequest : IMessage<SubscribeNotificationRequest>, IEquatable<SubscribeNotificationRequest>, IDeepCloneable<SubscribeNotificationRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SubscribeNotificationRequest.__c __9 = new SubscribeNotificationRequest.__c();

			internal SubscribeNotificationRequest cctor>b__24_0()
			{
				return new SubscribeNotificationRequest();
			}
		}

		private static readonly MessageParser<SubscribeNotificationRequest> _parser = new MessageParser<SubscribeNotificationRequest>(new Func<SubscribeNotificationRequest>(SubscribeNotificationRequest.__c.__9.<.cctor>b__24_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public static MessageParser<SubscribeNotificationRequest> Parser
		{
			get
			{
				return SubscribeNotificationRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeNotificationRequest.Descriptor;
			}
		}

		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		public SubscribeNotificationRequest()
		{
		}

		public SubscribeNotificationRequest(SubscribeNotificationRequest other) : this()
		{
			this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
		}

		public SubscribeNotificationRequest Clone()
		{
			return new SubscribeNotificationRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeNotificationRequest);
		}

		public bool Equals(SubscribeNotificationRequest other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -921622800) % 7)
				{
				case 0:
					return false;
				case 1:
					goto IL_7A;
				case 2:
					arg_48_0 = ((!SubscribeNotificationRequest.smethod_0(this.EntityId, other.EntityId)) ? -297707057 : -1661204508);
					continue;
				case 3:
					goto IL_12;
				case 5:
					return true;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -2004503289;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -1999616118 : -1955330984);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ SubscribeNotificationRequest.smethod_1(this.EntityId);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteMessage(this.EntityId);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.EntityId));
		}

		public void MergeFrom(SubscribeNotificationRequest other)
		{
			if (other == null)
			{
				goto IL_70;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 2853265707u)) % 7u)
				{
				case 0u:
					goto IL_70;
				case 1u:
					arg_7A_0 = (((this.entityId_ != null) ? 1602309380u : 997121754u) ^ num * 3752142748u);
					continue;
				case 3u:
					goto IL_B1;
				case 4u:
					return;
				case 5u:
					this.entityId_ = new EntityId();
					arg_7A_0 = (num * 742507599u ^ 936662203u);
					continue;
				case 6u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_7A_0 = 3264303925u;
					continue;
				}
				break;
			}
			return;
			IL_70:
			arg_7A_0 = 3725898397u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.entityId_ == null) ? 3264303925u : 2556748895u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_DC:
				uint num;
				uint arg_A1_0 = ((num = input.ReadTag()) == 0u) ? 314486705u : 989288645u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A1_0 ^ 1201311600u)) % 8u)
					{
					case 0u:
						arg_A1_0 = 989288645u;
						continue;
					case 2u:
						goto IL_DC;
					case 3u:
						input.ReadMessage(this.entityId_);
						arg_A1_0 = 1784322090u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_A1_0 = (num2 * 592286524u ^ 3623008314u);
						continue;
					case 5u:
						arg_A1_0 = ((num == 10u) ? 43747934u : 1804505036u);
						continue;
					case 6u:
						arg_A1_0 = ((this.entityId_ != null) ? 996608891u : 1351047359u);
						continue;
					case 7u:
						this.entityId_ = new EntityId();
						arg_A1_0 = (num2 * 4264746415u ^ 574960378u);
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
