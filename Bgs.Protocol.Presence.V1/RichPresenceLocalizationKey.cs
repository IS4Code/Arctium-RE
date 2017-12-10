using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class RichPresenceLocalizationKey : IMessage<RichPresenceLocalizationKey>, IEquatable<RichPresenceLocalizationKey>, IDeepCloneable<RichPresenceLocalizationKey>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RichPresenceLocalizationKey.__c __9 = new RichPresenceLocalizationKey.__c();

			internal RichPresenceLocalizationKey cctor>b__34_0()
			{
				return new RichPresenceLocalizationKey();
			}
		}

		private static readonly MessageParser<RichPresenceLocalizationKey> _parser = new MessageParser<RichPresenceLocalizationKey>(new Func<RichPresenceLocalizationKey>(RichPresenceLocalizationKey.__c.__9.<.cctor>b__34_0));

		public const int ProgramFieldNumber = 1;

		private uint program_;

		public const int StreamFieldNumber = 2;

		private uint stream_;

		public const int LocalizationIdFieldNumber = 3;

		private uint localizationId_;

		public static MessageParser<RichPresenceLocalizationKey> Parser
		{
			get
			{
				return RichPresenceLocalizationKey._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RichPresenceLocalizationKey.Descriptor;
			}
		}

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public uint Stream
		{
			get
			{
				return this.stream_;
			}
			set
			{
				this.stream_ = value;
			}
		}

		public uint LocalizationId
		{
			get
			{
				return this.localizationId_;
			}
			set
			{
				this.localizationId_ = value;
			}
		}

		public RichPresenceLocalizationKey()
		{
		}

		public RichPresenceLocalizationKey(RichPresenceLocalizationKey other) : this()
		{
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 239885877u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4D_0 ^ 773763000u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 1u:
						this.program_ = other.program_;
						this.stream_ = other.stream_;
						arg_4D_0 = (num * 1072491153u ^ 4056259878u);
						continue;
					case 3u:
						this.localizationId_ = other.localizationId_;
						arg_4D_0 = (num * 959145683u ^ 117072523u);
						continue;
					}
					return;
				}
			}
		}

		public RichPresenceLocalizationKey Clone()
		{
			return new RichPresenceLocalizationKey(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RichPresenceLocalizationKey);
		}

		public bool Equals(RichPresenceLocalizationKey other)
		{
			if (other == null)
			{
				goto IL_8D;
			}
			goto IL_DD;
			int arg_97_0;
			while (true)
			{
				IL_92:
				switch ((arg_97_0 ^ 576687500) % 11)
				{
				case 0:
					goto IL_DD;
				case 2:
					goto IL_8D;
				case 3:
					arg_97_0 = ((this.Stream != other.Stream) ? 2124313502 : 512397732);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return true;
				case 9:
					arg_97_0 = ((this.LocalizationId == other.LocalizationId) ? 181879571 : 2060700508);
					continue;
				case 10:
					arg_97_0 = ((this.Program == other.Program) ? 1886013209 : 1448009172);
					continue;
				}
				break;
			}
			return true;
			IL_8D:
			arg_97_0 = 813544752;
			goto IL_92;
			IL_DD:
			arg_97_0 = ((other == this) ? 870519627 : 401727521);
			goto IL_92;
		}

		public override int GetHashCode()
		{
			return 1 ^ this.Program.GetHashCode() ^ this.Stream.GetHashCode() ^ this.LocalizationId.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(13);
			output.WriteFixed32(this.Program);
			output.WriteRawTag(21);
			while (true)
			{
				IL_7B:
				uint arg_5F_0 = 2850599417u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5F_0 ^ 2995968122u)) % 4u)
					{
					case 0u:
						output.WriteRawTag(24);
						output.WriteUInt32(this.LocalizationId);
						arg_5F_0 = (num * 3219801557u ^ 2218691467u);
						continue;
					case 2u:
						goto IL_7B;
					case 3u:
						output.WriteFixed32(this.Stream);
						arg_5F_0 = (num * 1458481434u ^ 758832032u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 10 + (1 + CodedOutputStream.ComputeUInt32Size(this.LocalizationId));
		}

		public void MergeFrom(RichPresenceLocalizationKey other)
		{
			if (other == null)
			{
				goto IL_AE;
			}
			goto IL_F8;
			uint arg_B8_0;
			while (true)
			{
				IL_B3:
				uint num;
				switch ((num = (arg_B8_0 ^ 1708817992u)) % 9u)
				{
				case 0u:
					goto IL_AE;
				case 1u:
					this.Program = other.Program;
					arg_B8_0 = (num * 1916846542u ^ 273097496u);
					continue;
				case 2u:
					this.LocalizationId = other.LocalizationId;
					arg_B8_0 = (num * 276069211u ^ 3382884434u);
					continue;
				case 3u:
					arg_B8_0 = ((other.LocalizationId != 0u) ? 308172124u : 136270926u);
					continue;
				case 4u:
					goto IL_F8;
				case 5u:
					arg_B8_0 = ((other.Stream != 0u) ? 1838522673u : 1523068740u);
					continue;
				case 7u:
					return;
				case 8u:
					this.Stream = other.Stream;
					arg_B8_0 = (num * 850757200u ^ 1353974932u);
					continue;
				}
				break;
			}
			return;
			IL_AE:
			arg_B8_0 = 456140179u;
			goto IL_B3;
			IL_F8:
			arg_B8_0 = ((other.Program != 0u) ? 1416861052u : 373970112u);
			goto IL_B3;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_161:
				uint num;
				uint arg_111_0 = ((num = input.ReadTag()) != 0u) ? 3090308640u : 2159441283u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_111_0 ^ 4234662460u)) % 13u)
					{
					case 0u:
						this.Program = input.ReadFixed32();
						arg_111_0 = 4260328896u;
						continue;
					case 2u:
						arg_111_0 = 3090308640u;
						continue;
					case 3u:
						goto IL_161;
					case 4u:
						this.LocalizationId = input.ReadUInt32();
						arg_111_0 = 3030596175u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_111_0 = (num2 * 2496723678u ^ 1422802717u);
						continue;
					case 6u:
						arg_111_0 = (num2 * 868087834u ^ 1997149655u);
						continue;
					case 7u:
						arg_111_0 = (num2 * 1145510764u ^ 1832105835u);
						continue;
					case 8u:
						arg_111_0 = (((num != 24u) ? 1076641526u : 457953535u) ^ num2 * 1351267445u);
						continue;
					case 9u:
						arg_111_0 = (num2 * 1988115869u ^ 2613469643u);
						continue;
					case 10u:
						this.Stream = input.ReadFixed32();
						arg_111_0 = 4051281512u;
						continue;
					case 11u:
						arg_111_0 = (((num != 21u) ? 1128002247u : 875038072u) ^ num2 * 1109825437u);
						continue;
					case 12u:
						arg_111_0 = ((num == 13u) ? 2430476546u : 2818590370u);
						continue;
					}
					return;
				}
			}
		}
	}
}
