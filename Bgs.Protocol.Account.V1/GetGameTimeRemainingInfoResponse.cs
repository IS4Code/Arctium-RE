using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetGameTimeRemainingInfoResponse : IMessage<GetGameTimeRemainingInfoResponse>, IEquatable<GetGameTimeRemainingInfoResponse>, IDeepCloneable<GetGameTimeRemainingInfoResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetGameTimeRemainingInfoResponse.__c __9 = new GetGameTimeRemainingInfoResponse.__c();

			internal GetGameTimeRemainingInfoResponse cctor>b__24_0()
			{
				return new GetGameTimeRemainingInfoResponse();
			}
		}

		private static readonly MessageParser<GetGameTimeRemainingInfoResponse> _parser = new MessageParser<GetGameTimeRemainingInfoResponse>(new Func<GetGameTimeRemainingInfoResponse>(GetGameTimeRemainingInfoResponse.__c.__9.<.cctor>b__24_0));

		public const int GameTimeRemainingInfoFieldNumber = 1;

		private GameTimeRemainingInfo gameTimeRemainingInfo_;

		public static MessageParser<GetGameTimeRemainingInfoResponse> Parser
		{
			get
			{
				return GetGameTimeRemainingInfoResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[22];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameTimeRemainingInfoResponse.Descriptor;
			}
		}

		public GameTimeRemainingInfo GameTimeRemainingInfo
		{
			get
			{
				return this.gameTimeRemainingInfo_;
			}
			set
			{
				this.gameTimeRemainingInfo_ = value;
			}
		}

		public GetGameTimeRemainingInfoResponse()
		{
		}

		public GetGameTimeRemainingInfoResponse(GetGameTimeRemainingInfoResponse other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = -1850193031;
				while (true)
				{
					switch ((arg_2E_0 ^ -1627385568) % 3)
					{
					case 0:
						goto IL_44;
					case 2:
						this.GameTimeRemainingInfo = ((other.gameTimeRemainingInfo_ != null) ? other.GameTimeRemainingInfo.Clone() : null);
						arg_2E_0 = -282107425;
						continue;
					}
					return;
				}
			}
		}

		public GetGameTimeRemainingInfoResponse Clone()
		{
			return new GetGameTimeRemainingInfoResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameTimeRemainingInfoResponse);
		}

		public bool Equals(GetGameTimeRemainingInfoResponse other)
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
				switch ((arg_48_0 ^ -615033511) % 7)
				{
				case 0:
					return false;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					arg_48_0 = ((!GetGameTimeRemainingInfoResponse.smethod_0(this.GameTimeRemainingInfo, other.GameTimeRemainingInfo)) ? -1845217933 : -1352124362);
					continue;
				case 4:
					goto IL_7A;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -940611869;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -667819351 : -1136738818);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.gameTimeRemainingInfo_ != null)
			{
				while (true)
				{
					IL_44:
					uint arg_2C_0 = 3084486980u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2C_0 ^ 3732806727u)) % 3u)
						{
						case 1u:
							num ^= GetGameTimeRemainingInfoResponse.smethod_1(this.GameTimeRemainingInfo);
							arg_2C_0 = (num2 * 2801914873u ^ 3239046217u);
							continue;
						case 2u:
							goto IL_44;
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
			if (this.gameTimeRemainingInfo_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 2374469297u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 3844618416u)) % 4u)
						{
						case 1u:
							output.WriteRawTag(10);
							arg_3F_0 = (num * 2294298509u ^ 3697320227u);
							continue;
						case 2u:
							output.WriteMessage(this.GameTimeRemainingInfo);
							arg_3F_0 = (num * 3505930853u ^ 4135322230u);
							continue;
						case 3u:
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
			while (true)
			{
				IL_6B:
				uint arg_4F_0 = 210524967u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4F_0 ^ 564953361u)) % 4u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameTimeRemainingInfo);
						arg_4F_0 = (num2 * 2899599596u ^ 2451172365u);
						continue;
					case 2u:
						arg_4F_0 = (((this.gameTimeRemainingInfo_ == null) ? 4189008721u : 3884964420u) ^ num2 * 2893778304u);
						continue;
					case 3u:
						goto IL_6B;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetGameTimeRemainingInfoResponse other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 331874968u)) % 7u)
				{
				case 0u:
					this.gameTimeRemainingInfo_ = new GameTimeRemainingInfo();
					arg_7A_0 = (num * 480447383u ^ 3114663512u);
					continue;
				case 2u:
					arg_7A_0 = (((this.gameTimeRemainingInfo_ == null) ? 2117536256u : 1058304792u) ^ num * 3304458052u);
					continue;
				case 3u:
					this.GameTimeRemainingInfo.MergeFrom(other.GameTimeRemainingInfo);
					arg_7A_0 = 1407983565u;
					continue;
				case 4u:
					goto IL_15;
				case 5u:
					return;
				case 6u:
					goto IL_B1;
				}
				break;
			}
			return;
			IL_15:
			arg_7A_0 = 1519580287u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.gameTimeRemainingInfo_ == null) ? 1407983565u : 1436042395u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F3:
				uint num;
				uint arg_B3_0 = ((num = input.ReadTag()) != 0u) ? 924101912u : 2061022702u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 1329840488u)) % 9u)
					{
					case 0u:
						arg_B3_0 = 924101912u;
						continue;
					case 1u:
						input.ReadMessage(this.gameTimeRemainingInfo_);
						arg_B3_0 = 1088633394u;
						continue;
					case 2u:
						arg_B3_0 = ((this.gameTimeRemainingInfo_ != null) ? 2118789215u : 962560641u);
						continue;
					case 3u:
						input.SkipLastField();
						arg_B3_0 = (num2 * 2994563450u ^ 3475800601u);
						continue;
					case 4u:
						arg_B3_0 = ((num != 10u) ? 493861634u : 1965777352u);
						continue;
					case 5u:
						this.gameTimeRemainingInfo_ = new GameTimeRemainingInfo();
						arg_B3_0 = (num2 * 17560939u ^ 1083930428u);
						continue;
					case 6u:
						goto IL_F3;
					case 7u:
						arg_B3_0 = (num2 * 1165504773u ^ 2355753723u);
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
