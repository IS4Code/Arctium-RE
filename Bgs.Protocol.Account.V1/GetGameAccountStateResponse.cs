using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetGameAccountStateResponse : IMessage<GetGameAccountStateResponse>, IEquatable<GetGameAccountStateResponse>, IDeepCloneable<GetGameAccountStateResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetGameAccountStateResponse.__c __9 = new GetGameAccountStateResponse.__c();

			internal GetGameAccountStateResponse cctor>b__29_0()
			{
				return new GetGameAccountStateResponse();
			}
		}

		private static readonly MessageParser<GetGameAccountStateResponse> _parser = new MessageParser<GetGameAccountStateResponse>(new Func<GetGameAccountStateResponse>(GetGameAccountStateResponse.__c.__9.<.cctor>b__29_0));

		public const int StateFieldNumber = 1;

		private GameAccountState state_;

		public const int TagsFieldNumber = 2;

		private GameAccountFieldTags tags_;

		public static MessageParser<GetGameAccountStateResponse> Parser
		{
			get
			{
				return GetGameAccountStateResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[16];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameAccountStateResponse.Descriptor;
			}
		}

		public GameAccountState State
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

		public GameAccountFieldTags Tags
		{
			get
			{
				return this.tags_;
			}
			set
			{
				this.tags_ = value;
			}
		}

		public GetGameAccountStateResponse()
		{
		}

		public GetGameAccountStateResponse(GetGameAccountStateResponse other) : this()
		{
			this.State = ((other.state_ != null) ? other.State.Clone() : null);
			this.Tags = ((other.tags_ != null) ? other.Tags.Clone() : null);
		}

		public GetGameAccountStateResponse Clone()
		{
			return new GetGameAccountStateResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameAccountStateResponse);
		}

		public bool Equals(GetGameAccountStateResponse other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -1323597197) % 9)
				{
				case 0:
					goto IL_B5;
				case 2:
					return true;
				case 3:
					arg_77_0 = (GetGameAccountStateResponse.smethod_0(this.State, other.State) ? -908741856 : -2144884953);
					continue;
				case 4:
					return false;
				case 5:
					arg_77_0 = (GetGameAccountStateResponse.smethod_0(this.Tags, other.Tags) ? -1271037007 : -252493309);
					continue;
				case 6:
					return false;
				case 7:
					goto IL_15;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = -799288465;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? -1987024882 : -1376178654);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.state_ != null)
			{
				goto IL_53;
			}
			goto IL_89;
			uint arg_5D_0;
			while (true)
			{
				IL_58:
				uint num2;
				switch ((num2 = (arg_5D_0 ^ 972023698u)) % 5u)
				{
				case 0u:
					goto IL_53;
				case 1u:
					goto IL_89;
				case 3u:
					num ^= GetGameAccountStateResponse.smethod_1(this.Tags);
					arg_5D_0 = (num2 * 926950938u ^ 1827043958u);
					continue;
				case 4u:
					num ^= GetGameAccountStateResponse.smethod_1(this.State);
					arg_5D_0 = (num2 * 2779760331u ^ 4007843714u);
					continue;
				}
				break;
			}
			return num;
			IL_53:
			arg_5D_0 = 1570266093u;
			goto IL_58;
			IL_89:
			arg_5D_0 = ((this.tags_ == null) ? 921783432u : 1429459497u);
			goto IL_58;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.state_ != null)
			{
				goto IL_6F;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 4046368760u)) % 6u)
				{
				case 0u:
					goto IL_6F;
				case 1u:
					output.WriteRawTag(10);
					output.WriteMessage(this.State);
					arg_79_0 = (num * 2928314373u ^ 3412639442u);
					continue;
				case 2u:
					output.WriteMessage(this.Tags);
					arg_79_0 = (num * 2676238138u ^ 1980482285u);
					continue;
				case 3u:
					goto IL_AC;
				case 4u:
					output.WriteRawTag(18);
					arg_79_0 = (num * 3496199146u ^ 569635552u);
					continue;
				}
				break;
			}
			return;
			IL_6F:
			arg_79_0 = 3124948493u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.tags_ == null) ? 3100068741u : 3237923918u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 1614356893u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 1211476962u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
						arg_92_0 = (num2 * 1485459267u ^ 1874233305u);
						continue;
					case 2u:
						goto IL_B6;
					case 3u:
						arg_92_0 = ((this.tags_ == null) ? 1834386047u : 687683694u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Tags);
						arg_92_0 = (num2 * 2355269453u ^ 1593907043u);
						continue;
					case 5u:
						arg_92_0 = (((this.state_ == null) ? 1883569757u : 1645634882u) ^ num2 * 121039630u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetGameAccountStateResponse other)
		{
			if (other == null)
			{
				goto IL_33;
			}
			goto IL_14A;
			uint arg_102_0;
			while (true)
			{
				IL_FD:
				uint num;
				switch ((num = (arg_102_0 ^ 1892481791u)) % 11u)
				{
				case 0u:
					goto IL_14A;
				case 1u:
					arg_102_0 = (((this.tags_ == null) ? 2344125312u : 3916094736u) ^ num * 990128318u);
					continue;
				case 3u:
					return;
				case 4u:
					this.State.MergeFrom(other.State);
					arg_102_0 = 622981360u;
					continue;
				case 5u:
					this.state_ = new GameAccountState();
					arg_102_0 = (num * 414687475u ^ 2107910468u);
					continue;
				case 6u:
					this.tags_ = new GameAccountFieldTags();
					arg_102_0 = (num * 1821042434u ^ 664099266u);
					continue;
				case 7u:
					arg_102_0 = ((other.tags_ != null) ? 389366833u : 365133917u);
					continue;
				case 8u:
					arg_102_0 = (((this.state_ == null) ? 2308334117u : 2295583830u) ^ num * 1149619373u);
					continue;
				case 9u:
					goto IL_33;
				case 10u:
					this.Tags.MergeFrom(other.Tags);
					arg_102_0 = 365133917u;
					continue;
				}
				break;
			}
			return;
			IL_33:
			arg_102_0 = 87484127u;
			goto IL_FD;
			IL_14A:
			arg_102_0 = ((other.state_ != null) ? 1120806657u : 622981360u);
			goto IL_FD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) != 0u) ? 168354529u : 735637615u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 551286024u)) % 14u)
					{
					case 0u:
						arg_145_0 = 168354529u;
						continue;
					case 1u:
						input.ReadMessage(this.state_);
						arg_145_0 = 1725644458u;
						continue;
					case 2u:
						goto IL_199;
					case 3u:
						this.state_ = new GameAccountState();
						arg_145_0 = (num2 * 3317172354u ^ 3986807187u);
						continue;
					case 4u:
						this.tags_ = new GameAccountFieldTags();
						arg_145_0 = (num2 * 279975593u ^ 133661808u);
						continue;
					case 5u:
						arg_145_0 = ((num == 10u) ? 1859719864u : 525649361u);
						continue;
					case 6u:
						arg_145_0 = ((this.state_ != null) ? 908608733u : 356847087u);
						continue;
					case 8u:
						arg_145_0 = (num2 * 3959509594u ^ 1024563074u);
						continue;
					case 9u:
						arg_145_0 = (((num == 18u) ? 2060387172u : 175771647u) ^ num2 * 857250640u);
						continue;
					case 10u:
						arg_145_0 = ((this.tags_ != null) ? 1094487730u : 1334113018u);
						continue;
					case 11u:
						arg_145_0 = (num2 * 84601455u ^ 4261616591u);
						continue;
					case 12u:
						input.ReadMessage(this.tags_);
						arg_145_0 = 1009970550u;
						continue;
					case 13u:
						input.SkipLastField();
						arg_145_0 = (num2 * 812728783u ^ 2420013782u);
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
