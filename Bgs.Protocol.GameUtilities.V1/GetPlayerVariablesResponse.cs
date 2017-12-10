using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class GetPlayerVariablesResponse : IMessage<GetPlayerVariablesResponse>, IEquatable<GetPlayerVariablesResponse>, IDeepCloneable<GetPlayerVariablesResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetPlayerVariablesResponse.__c __9 = new GetPlayerVariablesResponse.__c();

			internal GetPlayerVariablesResponse cctor>b__24_0()
			{
				return new GetPlayerVariablesResponse();
			}
		}

		private static readonly MessageParser<GetPlayerVariablesResponse> _parser = new MessageParser<GetPlayerVariablesResponse>(new Func<GetPlayerVariablesResponse>(GetPlayerVariablesResponse.__c.__9.<.cctor>b__24_0));

		public const int PlayerVariablesFieldNumber = 1;

		private static readonly FieldCodec<PlayerVariables> _repeated_playerVariables_codec;

		private readonly RepeatedField<PlayerVariables> playerVariables_ = new RepeatedField<PlayerVariables>();

		public static MessageParser<GetPlayerVariablesResponse> Parser
		{
			get
			{
				return GetPlayerVariablesResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerVariablesResponse.Descriptor;
			}
		}

		public RepeatedField<PlayerVariables> PlayerVariables
		{
			get
			{
				return this.playerVariables_;
			}
		}

		public GetPlayerVariablesResponse()
		{
		}

		public GetPlayerVariablesResponse(GetPlayerVariablesResponse other) : this()
		{
			this.playerVariables_ = other.playerVariables_.Clone();
		}

		public GetPlayerVariablesResponse Clone()
		{
			return new GetPlayerVariablesResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerVariablesResponse);
		}

		public bool Equals(GetPlayerVariablesResponse other)
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
				switch ((arg_48_0 ^ -1821048962) % 7)
				{
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					goto IL_7A;
				case 5:
					arg_48_0 = (this.playerVariables_.Equals(other.playerVariables_) ? -2071647934 : -609633962);
					continue;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -338527247;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -1277708312 : -1433226669);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ GetPlayerVariablesResponse.smethod_0(this.playerVariables_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.playerVariables_.WriteTo(output, GetPlayerVariablesResponse._repeated_playerVariables_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.playerVariables_.CalculateSize(GetPlayerVariablesResponse._repeated_playerVariables_codec);
		}

		public void MergeFrom(GetPlayerVariablesResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.playerVariables_.Add(other.playerVariables_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) == 0u) ? 2154109635u : 3860832072u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 3845951503u)) % 7u)
					{
					case 0u:
						arg_77_0 = 3860832072u;
						continue;
					case 1u:
						arg_77_0 = ((num != 10u) ? 3425798282u : 3117562333u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_77_0 = (num2 * 3785593697u ^ 1102691208u);
						continue;
					case 3u:
						goto IL_AE;
					case 4u:
						arg_77_0 = (num2 * 945352882u ^ 307359120u);
						continue;
					case 5u:
						this.playerVariables_.AddEntriesFrom(input, GetPlayerVariablesResponse._repeated_playerVariables_codec);
						arg_77_0 = 2686913716u;
						continue;
					}
					return;
				}
			}
		}

		static GetPlayerVariablesResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 67092142u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 117545711u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 2u:
						GetPlayerVariablesResponse._repeated_playerVariables_codec = FieldCodec.ForMessage<PlayerVariables>(10u, Bgs.Protocol.GameUtilities.V1.PlayerVariables.Parser);
						arg_3F_0 = (num * 2076155346u ^ 1654495655u);
						continue;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
