using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class MessageOptions : IMessage<MessageOptions>, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MessageOptions.__c __9 = new MessageOptions.__c();

			internal MessageOptions cctor>b__39_0()
			{
				return new MessageOptions();
			}
		}

		private static readonly MessageParser<MessageOptions> _parser = new MessageParser<MessageOptions>(new Func<MessageOptions>(MessageOptions.__c.__9.<.cctor>b__39_0));

		public const int MessageSetWireFormatFieldNumber = 1;

		private bool messageSetWireFormat_;

		public const int NoStandardDescriptorAccessorFieldNumber = 2;

		private bool noStandardDescriptorAccessor_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.UninterpretedOption.Parser);

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		public static MessageParser<MessageOptions> Parser
		{
			get
			{
				return MessageOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageOptions.Descriptor;
			}
		}

		public bool MessageSetWireFormat
		{
			get
			{
				return this.messageSetWireFormat_;
			}
			set
			{
				this.messageSetWireFormat_ = value;
			}
		}

		public bool NoStandardDescriptorAccessor
		{
			get
			{
				return this.noStandardDescriptorAccessor_;
			}
			set
			{
				this.noStandardDescriptorAccessor_ = value;
			}
		}

		public bool Deprecated
		{
			get
			{
				return this.deprecated_;
			}
			set
			{
				this.deprecated_ = value;
			}
		}

		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			get
			{
				return this.uninterpretedOption_;
			}
		}

		public MessageOptions()
		{
		}

		public MessageOptions(MessageOptions other) : this()
		{
			while (true)
			{
				IL_A3:
				uint arg_7F_0 = 1810609710u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7F_0 ^ 1789795105u)) % 6u)
					{
					case 0u:
						goto IL_A3;
					case 1u:
						this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
						arg_7F_0 = (num * 80097078u ^ 3121442486u);
						continue;
					case 2u:
						this.deprecated_ = other.deprecated_;
						arg_7F_0 = (num * 3494916184u ^ 3015347862u);
						continue;
					case 3u:
						this.messageSetWireFormat_ = other.messageSetWireFormat_;
						arg_7F_0 = (num * 2462053270u ^ 3617191277u);
						continue;
					case 4u:
						this.noStandardDescriptorAccessor_ = other.noStandardDescriptorAccessor_;
						arg_7F_0 = (num * 2666392095u ^ 1647372255u);
						continue;
					}
					return;
				}
			}
		}

		public MessageOptions Clone()
		{
			return new MessageOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MessageOptions);
		}

		public bool Equals(MessageOptions other)
		{
			if (other == null)
			{
				goto IL_3F;
			}
			goto IL_111;
			int arg_C3_0;
			while (true)
			{
				IL_BE:
				switch ((arg_C3_0 ^ -916466922) % 13)
				{
				case 0:
					return false;
				case 1:
					arg_C3_0 = ((this.NoStandardDescriptorAccessor != other.NoStandardDescriptorAccessor) ? -1378345383 : -1284365396);
					continue;
				case 2:
					arg_C3_0 = ((!this.uninterpretedOption_.Equals(other.uninterpretedOption_)) ? -1438070114 : -694841738);
					continue;
				case 3:
					arg_C3_0 = ((this.Deprecated != other.Deprecated) ? -1689487534 : -1642349531);
					continue;
				case 4:
					goto IL_3F;
				case 5:
					goto IL_111;
				case 6:
					return false;
				case 7:
					return true;
				case 8:
					return false;
				case 9:
					return false;
				case 11:
					return false;
				case 12:
					arg_C3_0 = ((this.MessageSetWireFormat != other.MessageSetWireFormat) ? -339289710 : -380413081);
					continue;
				}
				break;
			}
			return true;
			IL_3F:
			arg_C3_0 = -16534744;
			goto IL_BE;
			IL_111:
			arg_C3_0 = ((other == this) ? -17084311 : -1555527056);
			goto IL_BE;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.MessageSetWireFormat)
			{
				goto IL_3F;
			}
			goto IL_FA;
			uint arg_BF_0;
			while (true)
			{
				IL_BA:
				uint num2;
				switch ((num2 = (arg_BF_0 ^ 2738966235u)) % 8u)
				{
				case 0u:
					num ^= this.Deprecated.GetHashCode();
					arg_BF_0 = (num2 * 1308123137u ^ 158815137u);
					continue;
				case 1u:
					num ^= this.MessageSetWireFormat.GetHashCode();
					arg_BF_0 = (num2 * 3883162257u ^ 256210676u);
					continue;
				case 2u:
					num ^= this.uninterpretedOption_.GetHashCode();
					arg_BF_0 = 3751619628u;
					continue;
				case 3u:
					arg_BF_0 = (this.Deprecated ? 4190101187u : 2838545337u);
					continue;
				case 4u:
					goto IL_3F;
				case 5u:
					num ^= this.NoStandardDescriptorAccessor.GetHashCode();
					arg_BF_0 = (num2 * 807997363u ^ 180619175u);
					continue;
				case 6u:
					goto IL_FA;
				}
				break;
			}
			return num;
			IL_3F:
			arg_BF_0 = 2487497954u;
			goto IL_BA;
			IL_FA:
			arg_BF_0 = (this.NoStandardDescriptorAccessor ? 2199124918u : 4197398928u);
			goto IL_BA;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.MessageSetWireFormat)
			{
				goto IL_5B;
			}
			goto IL_127;
			uint arg_E3_0;
			while (true)
			{
				IL_DE:
				uint num;
				switch ((num = (arg_E3_0 ^ 951963882u)) % 10u)
				{
				case 0u:
					output.WriteBool(this.Deprecated);
					arg_E3_0 = (num * 1853097621u ^ 1285350501u);
					continue;
				case 1u:
					output.WriteBool(this.NoStandardDescriptorAccessor);
					arg_E3_0 = (num * 2168742739u ^ 3881378557u);
					continue;
				case 2u:
					output.WriteRawTag(24);
					arg_E3_0 = (num * 2002657638u ^ 3034140764u);
					continue;
				case 3u:
					output.WriteBool(this.MessageSetWireFormat);
					arg_E3_0 = (num * 2523171750u ^ 1556911390u);
					continue;
				case 4u:
					goto IL_127;
				case 5u:
					output.WriteRawTag(8);
					arg_E3_0 = (num * 1118136248u ^ 949784191u);
					continue;
				case 6u:
					goto IL_5B;
				case 7u:
					output.WriteRawTag(16);
					arg_E3_0 = (num * 1752014014u ^ 2426403999u);
					continue;
				case 8u:
					arg_E3_0 = ((!this.Deprecated) ? 1706662211u : 1336236894u);
					continue;
				}
				break;
			}
			this.uninterpretedOption_.WriteTo(output, MessageOptions._repeated_uninterpretedOption_codec);
			return;
			IL_5B:
			arg_E3_0 = 1524825373u;
			goto IL_DE;
			IL_127:
			arg_E3_0 = (this.NoStandardDescriptorAccessor ? 977061835u : 1999339628u);
			goto IL_DE;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_DD:
				uint arg_B1_0 = 1785449052u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B1_0 ^ 1318596341u)) % 8u)
					{
					case 1u:
						arg_B1_0 = (((!this.MessageSetWireFormat) ? 688744089u : 1990868644u) ^ num2 * 2065000006u);
						continue;
					case 2u:
						arg_B1_0 = (this.NoStandardDescriptorAccessor ? 1531004408u : 1985520446u);
						continue;
					case 3u:
						arg_B1_0 = ((!this.Deprecated) ? 1489533717u : 1295185649u);
						continue;
					case 4u:
						num += 2;
						arg_B1_0 = (num2 * 1900658079u ^ 2641585513u);
						continue;
					case 5u:
						num += 2;
						arg_B1_0 = (num2 * 1132636427u ^ 1304792497u);
						continue;
					case 6u:
						goto IL_DD;
					case 7u:
						num += 2;
						arg_B1_0 = (num2 * 3724957919u ^ 1075891990u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			return num + this.uninterpretedOption_.CalculateSize(MessageOptions._repeated_uninterpretedOption_codec);
		}

		public void MergeFrom(MessageOptions other)
		{
			if (other == null)
			{
				goto IL_A8;
			}
			goto IL_117;
			uint arg_D3_0;
			while (true)
			{
				IL_CE:
				uint num;
				switch ((num = (arg_D3_0 ^ 4283838371u)) % 10u)
				{
				case 1u:
					arg_D3_0 = ((!other.NoStandardDescriptorAccessor) ? 3126937724u : 2516863061u);
					continue;
				case 2u:
					goto IL_A8;
				case 3u:
					return;
				case 4u:
					this.uninterpretedOption_.Add(other.uninterpretedOption_);
					arg_D3_0 = 2397152733u;
					continue;
				case 5u:
					arg_D3_0 = (other.Deprecated ? 3594499254u : 4142555761u);
					continue;
				case 6u:
					this.NoStandardDescriptorAccessor = other.NoStandardDescriptorAccessor;
					arg_D3_0 = (num * 3764584522u ^ 1603618144u);
					continue;
				case 7u:
					this.Deprecated = other.Deprecated;
					arg_D3_0 = (num * 1312232300u ^ 4034435501u);
					continue;
				case 8u:
					this.MessageSetWireFormat = other.MessageSetWireFormat;
					arg_D3_0 = (num * 2950677792u ^ 2878946870u);
					continue;
				case 9u:
					goto IL_117;
				}
				break;
			}
			return;
			IL_A8:
			arg_D3_0 = 3333535426u;
			goto IL_CE;
			IL_117:
			arg_D3_0 = ((!other.MessageSetWireFormat) ? 2829283382u : 4066280275u);
			goto IL_CE;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1CF:
				uint num;
				uint arg_173_0 = ((num = input.ReadTag()) == 0u) ? 799449716u : 679777123u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_173_0 ^ 1642442908u)) % 16u)
					{
					case 0u:
						this.MessageSetWireFormat = input.ReadBool();
						arg_173_0 = 316907623u;
						continue;
					case 1u:
						this.Deprecated = input.ReadBool();
						arg_173_0 = 785905307u;
						continue;
					case 2u:
						arg_173_0 = (num2 * 3601143989u ^ 2321672289u);
						continue;
					case 3u:
						arg_173_0 = ((num == 24u) ? 1458448077u : 67688950u);
						continue;
					case 4u:
						arg_173_0 = (((num != 16u) ? 1789142442u : 2022779985u) ^ num2 * 2113000264u);
						continue;
					case 5u:
						input.SkipLastField();
						arg_173_0 = 999829966u;
						continue;
					case 6u:
						arg_173_0 = (num2 * 453841557u ^ 3055602887u);
						continue;
					case 7u:
						goto IL_1CF;
					case 9u:
						arg_173_0 = 679777123u;
						continue;
					case 10u:
						arg_173_0 = (((num != 7994u) ? 3416903083u : 4135695410u) ^ num2 * 64727149u);
						continue;
					case 11u:
						arg_173_0 = (num2 * 4224271711u ^ 2435908286u);
						continue;
					case 12u:
						this.uninterpretedOption_.AddEntriesFrom(input, MessageOptions._repeated_uninterpretedOption_codec);
						arg_173_0 = 785905307u;
						continue;
					case 13u:
						this.NoStandardDescriptorAccessor = input.ReadBool();
						arg_173_0 = 785905307u;
						continue;
					case 14u:
						arg_173_0 = (((num != 8u) ? 3108429310u : 2737616170u) ^ num2 * 691769549u);
						continue;
					case 15u:
						arg_173_0 = ((num <= 16u) ? 1130305874u : 1526627103u);
						continue;
					}
					return;
				}
			}
		}
	}
}
