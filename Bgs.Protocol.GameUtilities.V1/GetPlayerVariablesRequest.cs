using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class GetPlayerVariablesRequest : IMessage<GetPlayerVariablesRequest>, IEquatable<GetPlayerVariablesRequest>, IDeepCloneable<GetPlayerVariablesRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetPlayerVariablesRequest.__c __9 = new GetPlayerVariablesRequest.__c();

			internal GetPlayerVariablesRequest cctor>b__29_0()
			{
				return new GetPlayerVariablesRequest();
			}
		}

		private static readonly MessageParser<GetPlayerVariablesRequest> _parser = new MessageParser<GetPlayerVariablesRequest>(new Func<GetPlayerVariablesRequest>(GetPlayerVariablesRequest.__c.__9.<.cctor>b__29_0));

		public const int PlayerVariablesFieldNumber = 1;

		private static readonly FieldCodec<PlayerVariables> _repeated_playerVariables_codec;

		private readonly RepeatedField<PlayerVariables> playerVariables_ = new RepeatedField<PlayerVariables>();

		public const int HostFieldNumber = 2;

		private ProcessId host_;

		public static MessageParser<GetPlayerVariablesRequest> Parser
		{
			get
			{
				return GetPlayerVariablesRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerVariablesRequest.Descriptor;
			}
		}

		public RepeatedField<PlayerVariables> PlayerVariables
		{
			get
			{
				return this.playerVariables_;
			}
		}

		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		public GetPlayerVariablesRequest()
		{
		}

		public GetPlayerVariablesRequest(GetPlayerVariablesRequest other) : this()
		{
			while (true)
			{
				IL_6A:
				uint arg_4E_0 = 2572134604u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4E_0 ^ 2897555290u)) % 4u)
					{
					case 0u:
						goto IL_6A;
					case 1u:
						this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
						arg_4E_0 = 3698898453u;
						continue;
					case 2u:
						this.playerVariables_ = other.playerVariables_.Clone();
						arg_4E_0 = (num * 2344515251u ^ 2497330949u);
						continue;
					}
					return;
				}
			}
		}

		public GetPlayerVariablesRequest Clone()
		{
			return new GetPlayerVariablesRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerVariablesRequest);
		}

		public bool Equals(GetPlayerVariablesRequest other)
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
				switch ((arg_77_0 ^ -849226111) % 9)
				{
				case 0:
					goto IL_B5;
				case 1:
					return false;
				case 2:
					goto IL_6D;
				case 3:
					return false;
				case 4:
					return false;
				case 6:
					arg_77_0 = (this.playerVariables_.Equals(other.playerVariables_) ? -381821884 : -345125594);
					continue;
				case 7:
					return true;
				case 8:
					arg_77_0 = (GetPlayerVariablesRequest.smethod_0(this.Host, other.Host) ? -1474150651 : -743203078);
					continue;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = -1200111040;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -1000121879 : -1438130399);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_8D:
				uint arg_6D_0 = 2924661399u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_6D_0 ^ 3293814767u)) % 5u)
					{
					case 0u:
						goto IL_8D;
					case 1u:
						num ^= GetPlayerVariablesRequest.smethod_1(this.Host);
						arg_6D_0 = (num2 * 3430765403u ^ 1553812306u);
						continue;
					case 2u:
						num ^= GetPlayerVariablesRequest.smethod_1(this.playerVariables_);
						arg_6D_0 = (num2 * 2155703191u ^ 2059225540u);
						continue;
					case 3u:
						arg_6D_0 = (((this.host_ != null) ? 3222998895u : 3807856328u) ^ num2 * 2683415045u);
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
			this.playerVariables_.WriteTo(output, GetPlayerVariablesRequest._repeated_playerVariables_codec);
			if (this.host_ != null)
			{
				while (true)
				{
					IL_6C:
					uint arg_50_0 = 1583625080u;
					while (true)
					{
						uint num;
						switch ((num = (arg_50_0 ^ 47732242u)) % 4u)
						{
						case 0u:
							goto IL_6C;
						case 2u:
							output.WriteRawTag(18);
							arg_50_0 = (num * 3644489457u ^ 3595027783u);
							continue;
						case 3u:
							output.WriteMessage(this.Host);
							arg_50_0 = (num * 2333882529u ^ 243588556u);
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
			while (true)
			{
				IL_94:
				uint arg_74_0 = 3285451449u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_74_0 ^ 3773032666u)) % 5u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
						arg_74_0 = (num2 * 4066612768u ^ 2424767810u);
						continue;
					case 2u:
						goto IL_94;
					case 3u:
						num += this.playerVariables_.CalculateSize(GetPlayerVariablesRequest._repeated_playerVariables_codec);
						arg_74_0 = (num2 * 1686078999u ^ 2303618140u);
						continue;
					case 4u:
						arg_74_0 = (((this.host_ == null) ? 3226837454u : 4174489624u) ^ num2 * 659209540u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetPlayerVariablesRequest other)
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
				switch ((num = (arg_7A_0 ^ 2385544521u)) % 7u)
				{
				case 0u:
					goto IL_B1;
				case 1u:
					return;
				case 2u:
					this.host_ = new ProcessId();
					arg_7A_0 = (num * 2017616548u ^ 1562276415u);
					continue;
				case 3u:
					this.Host.MergeFrom(other.Host);
					arg_7A_0 = 3366892281u;
					continue;
				case 4u:
					arg_7A_0 = (((this.host_ != null) ? 853906865u : 143455461u) ^ num * 2770162562u);
					continue;
				case 6u:
					goto IL_15;
				}
				break;
			}
			return;
			IL_15:
			arg_7A_0 = 2334319134u;
			goto IL_75;
			IL_B1:
			this.playerVariables_.Add(other.playerVariables_);
			arg_7A_0 = ((other.host_ != null) ? 3370969722u : 3366892281u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_12C:
				uint num;
				uint arg_E8_0 = ((num = input.ReadTag()) != 0u) ? 360828233u : 1169475597u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_E8_0 ^ 556826632u)) % 10u)
					{
					case 0u:
						this.host_ = new ProcessId();
						arg_E8_0 = (num2 * 2894315928u ^ 1740236250u);
						continue;
					case 1u:
						arg_E8_0 = ((num == 10u) ? 1428408440u : 1461109386u);
						continue;
					case 2u:
						arg_E8_0 = (((num == 18u) ? 151099985u : 2065229515u) ^ num2 * 4132525378u);
						continue;
					case 3u:
						goto IL_12C;
					case 4u:
						this.playerVariables_.AddEntriesFrom(input, GetPlayerVariablesRequest._repeated_playerVariables_codec);
						arg_E8_0 = 1615523431u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_E8_0 = (num2 * 2260739339u ^ 2089281386u);
						continue;
					case 6u:
						arg_E8_0 = 360828233u;
						continue;
					case 7u:
						arg_E8_0 = ((this.host_ != null) ? 374828714u : 385626834u);
						continue;
					case 8u:
						input.ReadMessage(this.host_);
						arg_E8_0 = 1615523431u;
						continue;
					}
					return;
				}
			}
		}

		static GetPlayerVariablesRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 865830122u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 732680864u)) % 3u)
					{
					case 1u:
						GetPlayerVariablesRequest._repeated_playerVariables_codec = FieldCodec.ForMessage<PlayerVariables>(10u, Bgs.Protocol.GameUtilities.V1.PlayerVariables.Parser);
						arg_3F_0 = (num * 1548562938u ^ 1718774669u);
						continue;
					case 2u:
						goto IL_57;
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
