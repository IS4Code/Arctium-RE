using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAccountStateResponse : IMessage<GetAccountStateResponse>, IEquatable<GetAccountStateResponse>, IDeepCloneable<GetAccountStateResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAccountStateResponse.__c __9 = new GetAccountStateResponse.__c();

			internal GetAccountStateResponse cctor>b__29_0()
			{
				return new GetAccountStateResponse();
			}
		}

		private static readonly MessageParser<GetAccountStateResponse> _parser = new MessageParser<GetAccountStateResponse>(new Func<GetAccountStateResponse>(GetAccountStateResponse.__c.__9.<.cctor>b__29_0));

		public const int StateFieldNumber = 1;

		private AccountState state_;

		public const int TagsFieldNumber = 2;

		private AccountFieldTags tags_;

		public static MessageParser<GetAccountStateResponse> Parser
		{
			get
			{
				return GetAccountStateResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[14];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAccountStateResponse.Descriptor;
			}
		}

		public AccountState State
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

		public AccountFieldTags Tags
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

		public GetAccountStateResponse()
		{
		}

		public GetAccountStateResponse(GetAccountStateResponse other) : this()
		{
			this.State = ((other.state_ != null) ? other.State.Clone() : null);
			this.Tags = ((other.tags_ != null) ? other.Tags.Clone() : null);
		}

		public GetAccountStateResponse Clone()
		{
			return new GetAccountStateResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAccountStateResponse);
		}

		public bool Equals(GetAccountStateResponse other)
		{
			if (other == null)
			{
				goto IL_6D;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -1687552726) % 9)
				{
				case 0:
					return true;
				case 2:
					return false;
				case 3:
					goto IL_B5;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					goto IL_6D;
				case 7:
					arg_77_0 = ((!GetAccountStateResponse.smethod_0(this.Tags, other.Tags)) ? -233046160 : -305317679);
					continue;
				case 8:
					arg_77_0 = ((!GetAccountStateResponse.smethod_0(this.State, other.State)) ? -56909209 : -1851734415);
					continue;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = -1111408515;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -827428232 : -1044642426);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B2:
				uint arg_8E_0 = 1192141269u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_8E_0 ^ 825847480u)) % 6u)
					{
					case 0u:
						goto IL_B2;
					case 1u:
						num ^= GetAccountStateResponse.smethod_1(this.State);
						arg_8E_0 = (num2 * 2630304918u ^ 729230510u);
						continue;
					case 2u:
						arg_8E_0 = ((this.tags_ == null) ? 1737483728u : 1804657041u);
						continue;
					case 3u:
						arg_8E_0 = (((this.state_ != null) ? 3277158962u : 2397436403u) ^ num2 * 566643607u);
						continue;
					case 5u:
						num ^= GetAccountStateResponse.smethod_1(this.Tags);
						arg_8E_0 = (num2 * 1791276164u ^ 3941941492u);
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
			if (this.state_ != null)
			{
				goto IL_4C;
			}
			goto IL_BF;
			uint arg_88_0;
			while (true)
			{
				IL_83:
				uint num;
				switch ((num = (arg_88_0 ^ 1328244346u)) % 7u)
				{
				case 0u:
					output.WriteRawTag(18);
					arg_88_0 = (num * 3972944297u ^ 828451658u);
					continue;
				case 1u:
					output.WriteMessage(this.Tags);
					arg_88_0 = (num * 2224951266u ^ 941293645u);
					continue;
				case 2u:
					goto IL_BF;
				case 3u:
					goto IL_4C;
				case 4u:
					output.WriteMessage(this.State);
					arg_88_0 = (num * 1355784573u ^ 2313651708u);
					continue;
				case 6u:
					output.WriteRawTag(10);
					arg_88_0 = (num * 2869527048u ^ 1637614084u);
					continue;
				}
				break;
			}
			return;
			IL_4C:
			arg_88_0 = 1886400662u;
			goto IL_83;
			IL_BF:
			arg_88_0 = ((this.tags_ == null) ? 1124087951u : 1165490339u);
			goto IL_83;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 790206393u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 64087238u)) % 6u)
					{
					case 0u:
						goto IL_B6;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
						arg_92_0 = (num2 * 3480751528u ^ 1570012290u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Tags);
						arg_92_0 = (num2 * 912821537u ^ 3561609765u);
						continue;
					case 3u:
						arg_92_0 = (((this.state_ != null) ? 555743008u : 1423926863u) ^ num2 * 2146729675u);
						continue;
					case 4u:
						arg_92_0 = ((this.tags_ != null) ? 1113776218u : 213147193u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetAccountStateResponse other)
		{
			if (other == null)
			{
				goto IL_A0;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 970913399u)) % 11u)
				{
				case 0u:
					arg_105_0 = (((this.state_ != null) ? 1816053164u : 157240523u) ^ num * 3615220267u);
					continue;
				case 1u:
					return;
				case 2u:
					this.tags_ = new AccountFieldTags();
					arg_105_0 = (num * 4078457186u ^ 2395646500u);
					continue;
				case 3u:
					goto IL_14D;
				case 4u:
					this.State.MergeFrom(other.State);
					arg_105_0 = 144421123u;
					continue;
				case 6u:
					goto IL_A0;
				case 7u:
					arg_105_0 = ((other.tags_ == null) ? 2017395288u : 921466645u);
					continue;
				case 8u:
					this.Tags.MergeFrom(other.Tags);
					arg_105_0 = 2017395288u;
					continue;
				case 9u:
					arg_105_0 = (((this.tags_ == null) ? 1773767056u : 1860118328u) ^ num * 254695015u);
					continue;
				case 10u:
					this.state_ = new AccountState();
					arg_105_0 = (num * 3897954854u ^ 4212685177u);
					continue;
				}
				break;
			}
			return;
			IL_A0:
			arg_105_0 = 1793264017u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.state_ == null) ? 144421123u : 21849362u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) == 0u) ? 2551808155u : 2666383639u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 3701454866u)) % 14u)
					{
					case 0u:
						arg_145_0 = 2666383639u;
						continue;
					case 1u:
						arg_145_0 = (num2 * 199873194u ^ 2699360040u);
						continue;
					case 2u:
						arg_145_0 = ((this.state_ == null) ? 2674879392u : 2786218461u);
						continue;
					case 3u:
						input.ReadMessage(this.state_);
						arg_145_0 = 2576809839u;
						continue;
					case 4u:
						this.tags_ = new AccountFieldTags();
						arg_145_0 = (num2 * 3931299784u ^ 2090356866u);
						continue;
					case 5u:
						arg_145_0 = ((this.tags_ == null) ? 3898931468u : 4114108914u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_145_0 = (num2 * 1359421668u ^ 848988169u);
						continue;
					case 7u:
						arg_145_0 = (((num != 18u) ? 2229604346u : 3520760637u) ^ num2 * 756836570u);
						continue;
					case 8u:
						this.state_ = new AccountState();
						arg_145_0 = (num2 * 4281969333u ^ 3228152071u);
						continue;
					case 9u:
						arg_145_0 = ((num == 10u) ? 3802219304u : 3057195187u);
						continue;
					case 10u:
						goto IL_199;
					case 12u:
						input.ReadMessage(this.tags_);
						arg_145_0 = 2883582646u;
						continue;
					case 13u:
						arg_145_0 = (num2 * 3009794267u ^ 2676575577u);
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
