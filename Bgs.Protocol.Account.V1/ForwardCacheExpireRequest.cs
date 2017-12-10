using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class ForwardCacheExpireRequest : IMessage<ForwardCacheExpireRequest>, IEquatable<ForwardCacheExpireRequest>, IDeepCloneable<ForwardCacheExpireRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ForwardCacheExpireRequest.__c __9 = new ForwardCacheExpireRequest.__c();

			internal ForwardCacheExpireRequest cctor>b__24_0()
			{
				return new ForwardCacheExpireRequest();
			}
		}

		private static readonly MessageParser<ForwardCacheExpireRequest> _parser = new MessageParser<ForwardCacheExpireRequest>(new Func<ForwardCacheExpireRequest>(ForwardCacheExpireRequest.__c.__9.<.cctor>b__24_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public static MessageParser<ForwardCacheExpireRequest> Parser
		{
			get
			{
				return ForwardCacheExpireRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[25];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForwardCacheExpireRequest.Descriptor;
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

		public ForwardCacheExpireRequest()
		{
		}

		public ForwardCacheExpireRequest(ForwardCacheExpireRequest other) : this()
		{
			this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
		}

		public ForwardCacheExpireRequest Clone()
		{
			return new ForwardCacheExpireRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ForwardCacheExpireRequest);
		}

		public bool Equals(ForwardCacheExpireRequest other)
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
				switch ((arg_48_0 ^ 1611346443) % 7)
				{
				case 0:
					return true;
				case 2:
					goto IL_7A;
				case 3:
					arg_48_0 = ((!ForwardCacheExpireRequest.smethod_0(this.EntityId, other.EntityId)) ? 1534079076 : 1610333304);
					continue;
				case 4:
					return false;
				case 5:
					goto IL_12;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 771897043;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 863906029 : 557957915);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 4068150082u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 3043727923u)) % 4u)
					{
					case 1u:
						arg_4D_0 = (((this.entityId_ == null) ? 4242375370u : 2943138728u) ^ num2 * 1876932989u);
						continue;
					case 2u:
						num ^= ForwardCacheExpireRequest.smethod_1(this.EntityId);
						arg_4D_0 = (num2 * 617761903u ^ 3318031629u);
						continue;
					case 3u:
						goto IL_69;
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
			if (this.entityId_ != null)
			{
				while (true)
				{
					IL_48:
					uint arg_30_0 = 1386522014u;
					while (true)
					{
						uint num;
						switch ((num = (arg_30_0 ^ 1997645551u)) % 3u)
						{
						case 0u:
							goto IL_48;
						case 1u:
							output.WriteRawTag(10);
							output.WriteMessage(this.EntityId);
							arg_30_0 = (num * 1671790901u ^ 2331246893u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.entityId_ != null)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 2412393596u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 2399062368u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 1u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
							arg_2E_0 = (num2 * 733966444u ^ 4254990383u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(ForwardCacheExpireRequest other)
		{
			if (other == null)
			{
				goto IL_47;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 3647742593u)) % 7u)
				{
				case 0u:
					arg_7A_0 = (((this.entityId_ == null) ? 3053438032u : 2437084696u) ^ num * 2684458512u);
					continue;
				case 2u:
					goto IL_47;
				case 3u:
					goto IL_B1;
				case 4u:
					return;
				case 5u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_7A_0 = 3228552102u;
					continue;
				case 6u:
					this.entityId_ = new EntityId();
					arg_7A_0 = (num * 2641672158u ^ 1155011670u);
					continue;
				}
				break;
			}
			return;
			IL_47:
			arg_7A_0 = 2600449039u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.entityId_ == null) ? 3228552102u : 2732718368u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F3:
				uint num;
				uint arg_B3_0 = ((num = input.ReadTag()) != 0u) ? 3703930342u : 2431168309u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 3959514386u)) % 9u)
					{
					case 0u:
						input.SkipLastField();
						arg_B3_0 = (num2 * 602029382u ^ 468582113u);
						continue;
					case 2u:
						arg_B3_0 = 3703930342u;
						continue;
					case 3u:
						goto IL_F3;
					case 4u:
						input.ReadMessage(this.entityId_);
						arg_B3_0 = 2378764297u;
						continue;
					case 5u:
						arg_B3_0 = ((num == 10u) ? 3393466963u : 2781042052u);
						continue;
					case 6u:
						this.entityId_ = new EntityId();
						arg_B3_0 = (num2 * 2250349120u ^ 1700964317u);
						continue;
					case 7u:
						arg_B3_0 = ((this.entityId_ != null) ? 2459112157u : 2768312486u);
						continue;
					case 8u:
						arg_B3_0 = (num2 * 4187959098u ^ 3323394303u);
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
