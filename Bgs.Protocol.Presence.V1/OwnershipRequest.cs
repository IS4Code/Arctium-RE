using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class OwnershipRequest : IMessage<OwnershipRequest>, IEquatable<OwnershipRequest>, IDeepCloneable<OwnershipRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly OwnershipRequest.__c __9 = new OwnershipRequest.__c();

			internal OwnershipRequest cctor>b__29_0()
			{
				return new OwnershipRequest();
			}
		}

		private static readonly MessageParser<OwnershipRequest> _parser = new MessageParser<OwnershipRequest>(new Func<OwnershipRequest>(OwnershipRequest.__c.__9.<.cctor>b__29_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public const int ReleaseOwnershipFieldNumber = 2;

		private bool releaseOwnership_;

		public static MessageParser<OwnershipRequest> Parser
		{
			get
			{
				return OwnershipRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OwnershipRequest.Descriptor;
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

		public bool ReleaseOwnership
		{
			get
			{
				return this.releaseOwnership_;
			}
			set
			{
				this.releaseOwnership_ = value;
			}
		}

		public OwnershipRequest()
		{
		}

		public OwnershipRequest(OwnershipRequest other) : this()
		{
			while (true)
			{
				IL_65:
				uint arg_49_0 = 1386085487u;
				while (true)
				{
					uint num;
					switch ((num = (arg_49_0 ^ 24892521u)) % 4u)
					{
					case 1u:
						this.releaseOwnership_ = other.releaseOwnership_;
						arg_49_0 = (num * 3427454858u ^ 3922417811u);
						continue;
					case 2u:
						this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
						arg_49_0 = 694930936u;
						continue;
					case 3u:
						goto IL_65;
					}
					return;
				}
			}
		}

		public OwnershipRequest Clone()
		{
			return new OwnershipRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as OwnershipRequest);
		}

		public bool Equals(OwnershipRequest other)
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
				switch ((arg_72_0 ^ -628947378) % 9)
				{
				case 0:
					goto IL_68;
				case 1:
					arg_72_0 = (OwnershipRequest.smethod_0(this.EntityId, other.EntityId) ? -1048091625 : -259257764);
					continue;
				case 2:
					return false;
				case 4:
					return false;
				case 5:
					arg_72_0 = ((this.ReleaseOwnership != other.ReleaseOwnership) ? -1703152499 : -1830007610);
					continue;
				case 6:
					return false;
				case 7:
					return true;
				case 8:
					goto IL_B0;
				}
				break;
			}
			return true;
			IL_68:
			arg_72_0 = -1336479038;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? -80381928 : -507212336);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_90:
				uint arg_70_0 = 19319895u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_70_0 ^ 1509125674u)) % 5u)
					{
					case 0u:
						goto IL_90;
					case 1u:
						num ^= this.ReleaseOwnership.GetHashCode();
						arg_70_0 = (num2 * 1759895168u ^ 281423987u);
						continue;
					case 2u:
						arg_70_0 = ((this.ReleaseOwnership ? 1565467478u : 1905985969u) ^ num2 * 3564412098u);
						continue;
					case 3u:
						num ^= OwnershipRequest.smethod_1(this.EntityId);
						arg_70_0 = (num2 * 3145157657u ^ 3545582366u);
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
			output.WriteMessage(this.EntityId);
			while (true)
			{
				IL_94:
				uint arg_74_0 = 108822597u;
				while (true)
				{
					uint num;
					switch ((num = (arg_74_0 ^ 1427593465u)) % 5u)
					{
					case 0u:
						goto IL_94;
					case 2u:
						output.WriteBool(this.ReleaseOwnership);
						arg_74_0 = (num * 2113839640u ^ 133559216u);
						continue;
					case 3u:
						output.WriteRawTag(16);
						arg_74_0 = (num * 4214762446u ^ 3258248645u);
						continue;
					case 4u:
						arg_74_0 = (((!this.ReleaseOwnership) ? 4136785612u : 3816575923u) ^ num * 1051227201u);
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
				IL_82:
				uint arg_62_0 = 499299914u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_62_0 ^ 2049717449u)) % 5u)
					{
					case 0u:
						num += 2;
						arg_62_0 = (num2 * 2544396049u ^ 1700872687u);
						continue;
					case 1u:
						arg_62_0 = (((!this.ReleaseOwnership) ? 4048805570u : 2910922164u) ^ num2 * 3446204578u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
						arg_62_0 = (num2 * 2344764876u ^ 215116005u);
						continue;
					case 4u:
						goto IL_82;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(OwnershipRequest other)
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
				switch ((num = (arg_BC_0 ^ 297499611u)) % 9u)
				{
				case 0u:
					this.entityId_ = new EntityId();
					arg_BC_0 = (num * 3955547626u ^ 242513386u);
					continue;
				case 1u:
					goto IL_FC;
				case 2u:
					arg_BC_0 = ((!other.ReleaseOwnership) ? 1172965711u : 1164771119u);
					continue;
				case 3u:
					this.ReleaseOwnership = other.ReleaseOwnership;
					arg_BC_0 = (num * 3660147101u ^ 3307377899u);
					continue;
				case 5u:
					return;
				case 6u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_BC_0 = 1564063050u;
					continue;
				case 7u:
					arg_BC_0 = (((this.entityId_ != null) ? 2600781807u : 2168664346u) ^ num * 3073111857u);
					continue;
				case 8u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_BC_0 = 633445819u;
			goto IL_B7;
			IL_FC:
			arg_BC_0 = ((other.entityId_ != null) ? 618114678u : 1564063050u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13D:
				uint num;
				uint arg_F5_0 = ((num = input.ReadTag()) != 0u) ? 4071765425u : 2148123763u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F5_0 ^ 3438222453u)) % 11u)
					{
					case 0u:
						this.entityId_ = new EntityId();
						arg_F5_0 = (num2 * 124635687u ^ 1325476647u);
						continue;
					case 1u:
						arg_F5_0 = (((num == 16u) ? 2048733064u : 771141040u) ^ num2 * 1600740985u);
						continue;
					case 3u:
						arg_F5_0 = ((num == 10u) ? 2805578170u : 3992346182u);
						continue;
					case 4u:
						arg_F5_0 = (num2 * 3738612383u ^ 3869373126u);
						continue;
					case 5u:
						goto IL_13D;
					case 6u:
						arg_F5_0 = ((this.entityId_ == null) ? 2352545510u : 4165183810u);
						continue;
					case 7u:
						arg_F5_0 = 4071765425u;
						continue;
					case 8u:
						input.ReadMessage(this.entityId_);
						arg_F5_0 = 3098750295u;
						continue;
					case 9u:
						this.ReleaseOwnership = input.ReadBool();
						arg_F5_0 = 3098750295u;
						continue;
					case 10u:
						input.SkipLastField();
						arg_F5_0 = (num2 * 4255643215u ^ 3438247992u);
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
