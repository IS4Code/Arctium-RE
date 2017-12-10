using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class GenerateSSOTokenResponse : IMessage<GenerateSSOTokenResponse>, IEquatable<GenerateSSOTokenResponse>, IDeepCloneable<GenerateSSOTokenResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GenerateSSOTokenResponse.__c __9 = new GenerateSSOTokenResponse.__c();

			internal GenerateSSOTokenResponse cctor>b__29_0()
			{
				return new GenerateSSOTokenResponse();
			}
		}

		private static readonly MessageParser<GenerateSSOTokenResponse> _parser = new MessageParser<GenerateSSOTokenResponse>(new Func<GenerateSSOTokenResponse>(GenerateSSOTokenResponse.__c.__9.<.cctor>b__29_0));

		public const int SsoIdFieldNumber = 1;

		private ByteString ssoId_ = ByteString.Empty;

		public const int SsoSecretFieldNumber = 2;

		private ByteString ssoSecret_ = ByteString.Empty;

		public static MessageParser<GenerateSSOTokenResponse> Parser
		{
			get
			{
				return GenerateSSOTokenResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateSSOTokenResponse.Descriptor;
			}
		}

		public ByteString SsoId
		{
			get
			{
				return this.ssoId_;
			}
			set
			{
				this.ssoId_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public ByteString SsoSecret
		{
			get
			{
				return this.ssoSecret_;
			}
			set
			{
				this.ssoSecret_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public GenerateSSOTokenResponse()
		{
		}

		public GenerateSSOTokenResponse(GenerateSSOTokenResponse other) : this()
		{
			while (true)
			{
				IL_4A:
				uint arg_32_0 = 1482045540u;
				while (true)
				{
					uint num;
					switch ((num = (arg_32_0 ^ 1994678771u)) % 3u)
					{
					case 0u:
						goto IL_4A;
					case 2u:
						this.ssoId_ = other.ssoId_;
						this.ssoSecret_ = other.ssoSecret_;
						arg_32_0 = (num * 1835675730u ^ 3430762727u);
						continue;
					}
					return;
				}
			}
		}

		public GenerateSSOTokenResponse Clone()
		{
			return new GenerateSSOTokenResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateSSOTokenResponse);
		}

		public bool Equals(GenerateSSOTokenResponse other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 711765672) % 9)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					goto IL_B5;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					arg_77_0 = ((this.SsoSecret != other.SsoSecret) ? 594370519 : 844436430);
					continue;
				case 7:
					goto IL_41;
				case 8:
					arg_77_0 = ((this.SsoId != other.SsoId) ? 1005038691 : 573248186);
					continue;
				}
				break;
			}
			return true;
			IL_41:
			arg_77_0 = 539041465;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? 1963992318 : 306518208);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.SsoId.Length != 0)
			{
				goto IL_58;
			}
			goto IL_8E;
			uint arg_62_0;
			while (true)
			{
				IL_5D:
				uint num2;
				switch ((num2 = (arg_62_0 ^ 1561005036u)) % 5u)
				{
				case 0u:
					goto IL_58;
				case 1u:
					goto IL_8E;
				case 3u:
					num ^= GenerateSSOTokenResponse.smethod_0(this.SsoId);
					arg_62_0 = (num2 * 4021015553u ^ 3233888778u);
					continue;
				case 4u:
					num ^= GenerateSSOTokenResponse.smethod_0(this.SsoSecret);
					arg_62_0 = (num2 * 2417445672u ^ 2491701601u);
					continue;
				}
				break;
			}
			return num;
			IL_58:
			arg_62_0 = 343712879u;
			goto IL_5D;
			IL_8E:
			arg_62_0 = ((this.SsoSecret.Length == 0) ? 1831729025u : 1075864896u);
			goto IL_5D;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.SsoId.Length != 0)
			{
				goto IL_5D;
			}
			goto IL_B1;
			uint arg_7E_0;
			while (true)
			{
				IL_79:
				uint num;
				switch ((num = (arg_7E_0 ^ 423600484u)) % 6u)
				{
				case 1u:
					output.WriteRawTag(10);
					arg_7E_0 = (num * 2907994506u ^ 1529198111u);
					continue;
				case 2u:
					goto IL_5D;
				case 3u:
					goto IL_B1;
				case 4u:
					output.WriteRawTag(18);
					output.WriteBytes(this.SsoSecret);
					arg_7E_0 = (num * 457886960u ^ 3573352830u);
					continue;
				case 5u:
					output.WriteBytes(this.SsoId);
					arg_7E_0 = (num * 2317270511u ^ 2714632348u);
					continue;
				}
				break;
			}
			return;
			IL_5D:
			arg_7E_0 = 2083937047u;
			goto IL_79;
			IL_B1:
			arg_7E_0 = ((this.SsoSecret.Length != 0) ? 1231143644u : 534320638u);
			goto IL_79;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_C0:
				uint arg_9C_0 = 3512620918u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9C_0 ^ 2476875105u)) % 6u)
					{
					case 0u:
						goto IL_C0;
					case 1u:
						arg_9C_0 = (((this.SsoId.Length != 0) ? 1447886262u : 1787173029u) ^ num2 * 2748678068u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.SsoSecret);
						arg_9C_0 = (num2 * 3301904398u ^ 977283400u);
						continue;
					case 4u:
						arg_9C_0 = ((this.SsoSecret.Length != 0) ? 3476082677u : 3902598480u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.SsoId);
						arg_9C_0 = (num2 * 3690301719u ^ 3226974468u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GenerateSSOTokenResponse other)
		{
			if (other == null)
			{
				goto IL_3B;
			}
			goto IL_B2;
			uint arg_7B_0;
			while (true)
			{
				IL_76:
				uint num;
				switch ((num = (arg_7B_0 ^ 421240551u)) % 7u)
				{
				case 0u:
					this.SsoSecret = other.SsoSecret;
					arg_7B_0 = (num * 1424743615u ^ 290105704u);
					continue;
				case 2u:
					goto IL_B2;
				case 3u:
					return;
				case 4u:
					this.SsoId = other.SsoId;
					arg_7B_0 = (num * 845027319u ^ 2357486188u);
					continue;
				case 5u:
					goto IL_3B;
				case 6u:
					arg_7B_0 = ((other.SsoSecret.Length != 0) ? 1523669165u : 903159902u);
					continue;
				}
				break;
			}
			return;
			IL_3B:
			arg_7B_0 = 1488212743u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((other.SsoId.Length != 0) ? 1097860040u : 1823572789u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F1:
				uint num;
				uint arg_B1_0 = ((num = input.ReadTag()) != 0u) ? 2437974588u : 4279548387u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B1_0 ^ 4165014924u)) % 9u)
					{
					case 0u:
						arg_B1_0 = (((num != 18u) ? 486518728u : 1752602802u) ^ num2 * 1521196738u);
						continue;
					case 1u:
						arg_B1_0 = ((num != 10u) ? 3062444248u : 3233553058u);
						continue;
					case 2u:
						goto IL_F1;
					case 3u:
						arg_B1_0 = (num2 * 2734270329u ^ 437922431u);
						continue;
					case 4u:
						arg_B1_0 = 2437974588u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_B1_0 = (num2 * 1142279484u ^ 2330195963u);
						continue;
					case 7u:
						this.SsoId = input.ReadBytes();
						arg_B1_0 = 3005885944u;
						continue;
					case 8u:
						this.SsoSecret = input.ReadBytes();
						arg_B1_0 = 4065292459u;
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
