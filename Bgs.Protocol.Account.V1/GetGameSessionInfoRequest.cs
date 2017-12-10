using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetGameSessionInfoRequest : IMessage<GetGameSessionInfoRequest>, IEquatable<GetGameSessionInfoRequest>, IDeepCloneable<GetGameSessionInfoRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetGameSessionInfoRequest.__c __9 = new GetGameSessionInfoRequest.__c();

			internal GetGameSessionInfoRequest cctor>b__24_0()
			{
				return new GetGameSessionInfoRequest();
			}
		}

		private static readonly MessageParser<GetGameSessionInfoRequest> _parser = new MessageParser<GetGameSessionInfoRequest>(new Func<GetGameSessionInfoRequest>(GetGameSessionInfoRequest.__c.__9.<.cctor>b__24_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public static MessageParser<GetGameSessionInfoRequest> Parser
		{
			get
			{
				return GetGameSessionInfoRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[19];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameSessionInfoRequest.Descriptor;
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

		public GetGameSessionInfoRequest()
		{
		}

		public GetGameSessionInfoRequest(GetGameSessionInfoRequest other) : this()
		{
			this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
		}

		public GetGameSessionInfoRequest Clone()
		{
			return new GetGameSessionInfoRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameSessionInfoRequest);
		}

		public bool Equals(GetGameSessionInfoRequest other)
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
				switch ((arg_48_0 ^ -1738228360) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return false;
				case 3:
					return true;
				case 4:
					goto IL_7A;
				case 5:
					arg_48_0 = (GetGameSessionInfoRequest.smethod_0(this.EntityId, other.EntityId) ? -48275030 : -716682265);
					continue;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1758113270;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -1647240463 : -1468951569);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 1640396899u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 1723184338u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 1u:
						arg_4D_0 = (((this.entityId_ != null) ? 957455493u : 991493616u) ^ num2 * 4044129629u);
						continue;
					case 2u:
						num ^= GetGameSessionInfoRequest.smethod_1(this.EntityId);
						arg_4D_0 = (num2 * 2581413152u ^ 1842477565u);
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
			if (this.entityId_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 1625297930u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 80942059u)) % 4u)
						{
						case 0u:
							output.WriteMessage(this.EntityId);
							arg_3F_0 = (num * 1469074688u ^ 3665809232u);
							continue;
						case 1u:
							output.WriteRawTag(10);
							arg_3F_0 = (num * 2387460534u ^ 2376816649u);
							continue;
						case 2u:
							goto IL_5B;
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
					uint arg_2E_0 = 3383589631u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 3440446898u)) % 3u)
						{
						case 1u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
							arg_2E_0 = (num2 * 3041265804u ^ 548811897u);
							continue;
						case 2u:
							goto IL_46;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(GetGameSessionInfoRequest other)
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
				switch ((num = (arg_7A_0 ^ 1766582783u)) % 7u)
				{
				case 0u:
					goto IL_B1;
				case 2u:
					this.entityId_ = new EntityId();
					arg_7A_0 = (num * 2746760170u ^ 1424049834u);
					continue;
				case 3u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_7A_0 = 1877422110u;
					continue;
				case 4u:
					goto IL_3E;
				case 5u:
					return;
				case 6u:
					arg_7A_0 = (((this.entityId_ == null) ? 3955450797u : 2312291524u) ^ num * 1046387919u);
					continue;
				}
				break;
			}
			return;
			IL_3E:
			arg_7A_0 = 1163709466u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.entityId_ == null) ? 1877422110u : 1301536197u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F3:
				uint num;
				uint arg_B3_0 = ((num = input.ReadTag()) != 0u) ? 699207808u : 522258459u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 889944629u)) % 9u)
					{
					case 0u:
						arg_B3_0 = (num2 * 143334810u ^ 3815318663u);
						continue;
					case 2u:
						arg_B3_0 = ((this.entityId_ != null) ? 57160326u : 908967346u);
						continue;
					case 3u:
						this.entityId_ = new EntityId();
						arg_B3_0 = (num2 * 2548808453u ^ 772190245u);
						continue;
					case 4u:
						arg_B3_0 = ((num != 10u) ? 1493312204u : 1088673756u);
						continue;
					case 5u:
						arg_B3_0 = 699207808u;
						continue;
					case 6u:
						goto IL_F3;
					case 7u:
						input.SkipLastField();
						arg_B3_0 = (num2 * 1462329645u ^ 623563581u);
						continue;
					case 8u:
						input.ReadMessage(this.entityId_);
						arg_B3_0 = 2092430037u;
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
