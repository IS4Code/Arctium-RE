using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetCAISInfoRequest : IMessage<GetCAISInfoRequest>, IEquatable<GetCAISInfoRequest>, IDeepCloneable<GetCAISInfoRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetCAISInfoRequest.__c __9 = new GetCAISInfoRequest.__c();

			internal GetCAISInfoRequest cctor>b__24_0()
			{
				return new GetCAISInfoRequest();
			}
		}

		private static readonly MessageParser<GetCAISInfoRequest> _parser = new MessageParser<GetCAISInfoRequest>(new Func<GetCAISInfoRequest>(GetCAISInfoRequest.__c.__9.<.cctor>b__24_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public static MessageParser<GetCAISInfoRequest> Parser
		{
			get
			{
				return GetCAISInfoRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[23];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCAISInfoRequest.Descriptor;
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

		public GetCAISInfoRequest()
		{
		}

		public GetCAISInfoRequest(GetCAISInfoRequest other) : this()
		{
			this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
		}

		public GetCAISInfoRequest Clone()
		{
			return new GetCAISInfoRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetCAISInfoRequest);
		}

		public bool Equals(GetCAISInfoRequest other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 39852171) % 7)
				{
				case 0:
					goto IL_7A;
				case 1:
					return false;
				case 2:
					goto IL_3E;
				case 3:
					return false;
				case 5:
					return true;
				case 6:
					arg_48_0 = (GetCAISInfoRequest.smethod_0(this.EntityId, other.EntityId) ? 60082191 : 1034273949);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 73121364;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 1968018128 : 1860485897);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityId_ != null)
			{
				while (true)
				{
					IL_44:
					uint arg_2C_0 = 2542658607u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2C_0 ^ 4061116204u)) % 3u)
						{
						case 0u:
							goto IL_44;
						case 2u:
							num ^= GetCAISInfoRequest.smethod_1(this.EntityId);
							arg_2C_0 = (num2 * 3334318442u ^ 1366253892u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
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
					IL_5B:
					uint arg_3F_0 = 4294000879u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 3078613749u)) % 4u)
						{
						case 0u:
							goto IL_5B;
						case 1u:
							output.WriteMessage(this.EntityId);
							arg_3F_0 = (num * 3499573530u ^ 3600306372u);
							continue;
						case 2u:
							output.WriteRawTag(10);
							arg_3F_0 = (num * 1870964940u ^ 2944750336u);
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
					uint arg_2E_0 = 2925305462u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 3334730307u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 1u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
							arg_2E_0 = (num2 * 660222197u ^ 2380804289u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(GetCAISInfoRequest other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 907285080u)) % 7u)
				{
				case 0u:
					this.entityId_ = new EntityId();
					arg_7A_0 = (num * 3505015282u ^ 2672358434u);
					continue;
				case 1u:
					return;
				case 2u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_7A_0 = 1350743651u;
					continue;
				case 3u:
					goto IL_3E;
				case 5u:
					arg_7A_0 = (((this.entityId_ == null) ? 1761971155u : 2042645831u) ^ num * 3016304991u);
					continue;
				case 6u:
					goto IL_B1;
				}
				break;
			}
			return;
			IL_3E:
			arg_7A_0 = 1752322176u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.entityId_ != null) ? 49165495u : 1350743651u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F0:
				uint num;
				uint arg_B0_0 = ((num = input.ReadTag()) != 0u) ? 3160579036u : 3052097194u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B0_0 ^ 3598060594u)) % 9u)
					{
					case 0u:
						arg_B0_0 = 3160579036u;
						continue;
					case 1u:
						this.entityId_ = new EntityId();
						arg_B0_0 = (num2 * 4003554419u ^ 955615351u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_B0_0 = (num2 * 3397152304u ^ 3229558868u);
						continue;
					case 4u:
						arg_B0_0 = (num2 * 1348634166u ^ 2344811220u);
						continue;
					case 5u:
						arg_B0_0 = ((this.entityId_ == null) ? 3511653299u : 3349643908u);
						continue;
					case 6u:
						goto IL_F0;
					case 7u:
						input.ReadMessage(this.entityId_);
						arg_B0_0 = 4085651280u;
						continue;
					case 8u:
						arg_B0_0 = ((num != 10u) ? 3090064594u : 4127250860u);
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
