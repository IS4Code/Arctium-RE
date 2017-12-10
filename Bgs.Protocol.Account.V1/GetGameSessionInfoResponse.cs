using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetGameSessionInfoResponse : IMessage<GetGameSessionInfoResponse>, IEquatable<GetGameSessionInfoResponse>, IDeepCloneable<GetGameSessionInfoResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetGameSessionInfoResponse.__c __9 = new GetGameSessionInfoResponse.__c();

			internal GetGameSessionInfoResponse cctor>b__24_0()
			{
				return new GetGameSessionInfoResponse();
			}
		}

		private static readonly MessageParser<GetGameSessionInfoResponse> _parser = new MessageParser<GetGameSessionInfoResponse>(new Func<GetGameSessionInfoResponse>(GetGameSessionInfoResponse.__c.__9.<.cctor>b__24_0));

		public const int SessionInfoFieldNumber = 2;

		private GameSessionInfo sessionInfo_;

		public static MessageParser<GetGameSessionInfoResponse> Parser
		{
			get
			{
				return GetGameSessionInfoResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[20];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameSessionInfoResponse.Descriptor;
			}
		}

		public GameSessionInfo SessionInfo
		{
			get
			{
				return this.sessionInfo_;
			}
			set
			{
				this.sessionInfo_ = value;
			}
		}

		public GetGameSessionInfoResponse()
		{
		}

		public GetGameSessionInfoResponse(GetGameSessionInfoResponse other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = -1149408739;
				while (true)
				{
					switch ((arg_2E_0 ^ -837304154) % 3)
					{
					case 0:
						goto IL_44;
					case 1:
						this.SessionInfo = ((other.sessionInfo_ != null) ? other.SessionInfo.Clone() : null);
						arg_2E_0 = -287329346;
						continue;
					}
					return;
				}
			}
		}

		public GetGameSessionInfoResponse Clone()
		{
			return new GetGameSessionInfoResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameSessionInfoResponse);
		}

		public bool Equals(GetGameSessionInfoResponse other)
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
				switch ((arg_48_0 ^ 774071892) % 7)
				{
				case 1:
					arg_48_0 = ((!GetGameSessionInfoResponse.smethod_0(this.SessionInfo, other.SessionInfo)) ? 837568973 : 137284689);
					continue;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					goto IL_7A;
				case 5:
					return false;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 1740017153;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 1078868686 : 987075472);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 3524161766u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 2444975324u)) % 4u)
					{
					case 1u:
						num ^= GetGameSessionInfoResponse.smethod_1(this.SessionInfo);
						arg_4D_0 = (num2 * 2622892187u ^ 867431307u);
						continue;
					case 2u:
						arg_4D_0 = (((this.sessionInfo_ == null) ? 810359432u : 988662373u) ^ num2 * 2404589168u);
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
			if (this.sessionInfo_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 2155718327u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 2251071386u)) % 4u)
						{
						case 0u:
							goto IL_5B;
						case 1u:
							output.WriteRawTag(18);
							arg_3F_0 = (num * 1154671195u ^ 1260777099u);
							continue;
						case 2u:
							output.WriteMessage(this.SessionInfo);
							arg_3F_0 = (num * 3961980151u ^ 1526855739u);
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
			if (this.sessionInfo_ != null)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 998331941u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 39996306u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 1u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionInfo);
							arg_2E_0 = (num2 * 910116637u ^ 940230898u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(GetGameSessionInfoResponse other)
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
				switch ((num = (arg_7A_0 ^ 2310062949u)) % 7u)
				{
				case 1u:
					goto IL_B1;
				case 2u:
					return;
				case 3u:
					goto IL_70;
				case 4u:
					this.SessionInfo.MergeFrom(other.SessionInfo);
					arg_7A_0 = 2942680112u;
					continue;
				case 5u:
					arg_7A_0 = (((this.sessionInfo_ != null) ? 1905370475u : 278533951u) ^ num * 4270842110u);
					continue;
				case 6u:
					this.sessionInfo_ = new GameSessionInfo();
					arg_7A_0 = (num * 676447517u ^ 3097312865u);
					continue;
				}
				break;
			}
			return;
			IL_70:
			arg_7A_0 = 4053134634u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.sessionInfo_ == null) ? 2942680112u : 2584701872u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F3:
				uint num;
				uint arg_B3_0 = ((num = input.ReadTag()) == 0u) ? 4229433777u : 3151085554u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 2977955129u)) % 9u)
					{
					case 0u:
						this.sessionInfo_ = new GameSessionInfo();
						arg_B3_0 = (num2 * 2265532613u ^ 991414316u);
						continue;
					case 1u:
						input.ReadMessage(this.sessionInfo_);
						arg_B3_0 = 2543542583u;
						continue;
					case 3u:
						arg_B3_0 = ((num != 18u) ? 3595292320u : 4068540691u);
						continue;
					case 4u:
						goto IL_F3;
					case 5u:
						input.SkipLastField();
						arg_B3_0 = (num2 * 2867864367u ^ 3356863122u);
						continue;
					case 6u:
						arg_B3_0 = ((this.sessionInfo_ != null) ? 3943595190u : 2555501291u);
						continue;
					case 7u:
						arg_B3_0 = (num2 * 1965624523u ^ 1111471907u);
						continue;
					case 8u:
						arg_B3_0 = 3151085554u;
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
