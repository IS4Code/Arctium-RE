using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class MessageOptions : IMessage, IMessage<MessageOptions>, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MessageOptions.__c __9 = new MessageOptions.__c();

			internal MessageOptions cctor>b__44_0()
			{
				return new MessageOptions();
			}
		}

		private static readonly MessageParser<MessageOptions> _parser = new MessageParser<MessageOptions>(new Func<MessageOptions>(MessageOptions.__c.__9.<.cctor>b__44_0));

		public const int MessageSetWireFormatFieldNumber = 1;

		private bool messageSetWireFormat_;

		public const int NoStandardDescriptorAccessorFieldNumber = 2;

		private bool noStandardDescriptorAccessor_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int MapEntryFieldNumber = 7;

		private bool mapEntry_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

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

		public bool MapEntry
		{
			get
			{
				return this.mapEntry_;
			}
			set
			{
				this.mapEntry_ = value;
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
			this.messageSetWireFormat_ = other.messageSetWireFormat_;
			this.noStandardDescriptorAccessor_ = other.noStandardDescriptorAccessor_;
			this.deprecated_ = other.deprecated_;
			this.mapEntry_ = other.mapEntry_;
			this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
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
				goto IL_BF;
			}
			goto IL_146;
			int arg_F0_0;
			while (true)
			{
				IL_EB:
				switch ((arg_F0_0 ^ 129061972) % 15)
				{
				case 0:
					return false;
				case 1:
					arg_F0_0 = ((this.MessageSetWireFormat != other.MessageSetWireFormat) ? 1143277538 : 293193125);
					continue;
				case 2:
					goto IL_BF;
				case 3:
					return false;
				case 4:
					arg_F0_0 = ((this.MapEntry == other.MapEntry) ? 188161069 : 418308042);
					continue;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					arg_F0_0 = ((this.NoStandardDescriptorAccessor == other.NoStandardDescriptorAccessor) ? 835511718 : 610945513);
					continue;
				case 9:
					arg_F0_0 = (this.uninterpretedOption_.Equals(other.uninterpretedOption_) ? 145537365 : 1601676194);
					continue;
				case 10:
					return false;
				case 11:
					goto IL_146;
				case 13:
					arg_F0_0 = ((this.Deprecated == other.Deprecated) ? 1973854612 : 1306739759);
					continue;
				case 14:
					return false;
				}
				break;
			}
			return true;
			IL_BF:
			arg_F0_0 = 178283921;
			goto IL_EB;
			IL_146:
			arg_F0_0 = ((other != this) ? 1772637099 : 1242292813);
			goto IL_EB;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_173:
				uint arg_13A_0 = 3601003430u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_13A_0 ^ 2893664131u)) % 11u)
					{
					case 0u:
						arg_13A_0 = (this.MapEntry ? 2862238555u : 4252389209u);
						continue;
					case 1u:
						num ^= this.MapEntry.GetHashCode();
						arg_13A_0 = (num2 * 2823033378u ^ 261659625u);
						continue;
					case 2u:
						num ^= this.Deprecated.GetHashCode();
						arg_13A_0 = (num2 * 2637011675u ^ 2603965016u);
						continue;
					case 4u:
						arg_13A_0 = (((!this.MessageSetWireFormat) ? 2207165731u : 2536552230u) ^ num2 * 357695350u);
						continue;
					case 5u:
						num ^= this.MessageSetWireFormat.GetHashCode();
						arg_13A_0 = (num2 * 2472637877u ^ 2688762570u);
						continue;
					case 6u:
						goto IL_173;
					case 7u:
						arg_13A_0 = (this.Deprecated ? 3308289404u : 3669613693u);
						continue;
					case 8u:
						num ^= this.NoStandardDescriptorAccessor.GetHashCode();
						arg_13A_0 = (num2 * 2550384430u ^ 3335414055u);
						continue;
					case 9u:
						num ^= this.uninterpretedOption_.GetHashCode();
						arg_13A_0 = 2317778736u;
						continue;
					case 10u:
						arg_13A_0 = (this.NoStandardDescriptorAccessor ? 4004307022u : 3339948273u);
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
			if (this.MessageSetWireFormat)
			{
				goto IL_79;
			}
			goto IL_198;
			uint arg_148_0;
			while (true)
			{
				IL_143:
				uint num;
				switch ((num = (arg_148_0 ^ 2861861006u)) % 13u)
				{
				case 0u:
					arg_148_0 = ((!this.MapEntry) ? 2869423946u : 3900091774u);
					continue;
				case 1u:
					output.WriteBool(this.MapEntry);
					arg_148_0 = (num * 1962923183u ^ 1680019624u);
					continue;
				case 2u:
					output.WriteRawTag(8);
					arg_148_0 = (num * 2526939653u ^ 3701647225u);
					continue;
				case 4u:
					output.WriteRawTag(56);
					arg_148_0 = (num * 1354141248u ^ 2516758064u);
					continue;
				case 5u:
					this.uninterpretedOption_.WriteTo(output, MessageOptions._repeated_uninterpretedOption_codec);
					arg_148_0 = 2581372634u;
					continue;
				case 6u:
					output.WriteBool(this.NoStandardDescriptorAccessor);
					arg_148_0 = (num * 689629506u ^ 429407760u);
					continue;
				case 7u:
					output.WriteRawTag(24);
					output.WriteBool(this.Deprecated);
					arg_148_0 = (num * 2711552234u ^ 3807633186u);
					continue;
				case 8u:
					goto IL_79;
				case 9u:
					output.WriteBool(this.MessageSetWireFormat);
					arg_148_0 = (num * 2133100045u ^ 1608349690u);
					continue;
				case 10u:
					goto IL_198;
				case 11u:
					output.WriteRawTag(16);
					arg_148_0 = (num * 3629660958u ^ 3459846665u);
					continue;
				case 12u:
					arg_148_0 = (this.Deprecated ? 3871238144u : 2274402030u);
					continue;
				}
				break;
			}
			return;
			IL_79:
			arg_148_0 = 3989120349u;
			goto IL_143;
			IL_198:
			arg_148_0 = ((!this.NoStandardDescriptorAccessor) ? 2361273514u : 3629109853u);
			goto IL_143;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_120:
				uint arg_EB_0 = 2672977064u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_EB_0 ^ 2313346712u)) % 10u)
					{
					case 0u:
						num += 2;
						arg_EB_0 = (num2 * 2631670652u ^ 590750990u);
						continue;
					case 1u:
						num += 2;
						arg_EB_0 = (num2 * 3017527088u ^ 2989012407u);
						continue;
					case 2u:
						arg_EB_0 = (((!this.MessageSetWireFormat) ? 1284146519u : 566721713u) ^ num2 * 504832295u);
						continue;
					case 3u:
						arg_EB_0 = (this.Deprecated ? 2423381410u : 2399723116u);
						continue;
					case 4u:
						arg_EB_0 = (this.MapEntry ? 2498378192u : 2174925806u);
						continue;
					case 5u:
						goto IL_120;
					case 7u:
						num += 2;
						arg_EB_0 = (num2 * 3336194984u ^ 2776993917u);
						continue;
					case 8u:
						num += 2;
						arg_EB_0 = (num2 * 3671120592u ^ 1952111948u);
						continue;
					case 9u:
						arg_EB_0 = ((!this.NoStandardDescriptorAccessor) ? 3559163637u : 2734961397u);
						continue;
					}
					goto Block_5;
				}
			}
			Block_5:
			return num + this.uninterpretedOption_.CalculateSize(MessageOptions._repeated_uninterpretedOption_codec);
		}

		public void MergeFrom(MessageOptions other)
		{
			if (other == null)
			{
				goto IL_F0;
			}
			goto IL_142;
			uint arg_FA_0;
			while (true)
			{
				IL_F5:
				uint num;
				switch ((num = (arg_FA_0 ^ 808311907u)) % 11u)
				{
				case 0u:
					goto IL_F0;
				case 1u:
					this.MessageSetWireFormat = other.MessageSetWireFormat;
					arg_FA_0 = (num * 3246275114u ^ 1612692251u);
					continue;
				case 2u:
					this.NoStandardDescriptorAccessor = other.NoStandardDescriptorAccessor;
					arg_FA_0 = (num * 2506065365u ^ 2356993201u);
					continue;
				case 3u:
					arg_FA_0 = ((!other.NoStandardDescriptorAccessor) ? 402864360u : 1618873878u);
					continue;
				case 4u:
					return;
				case 5u:
					goto IL_142;
				case 6u:
					this.Deprecated = other.Deprecated;
					arg_FA_0 = (num * 2233122381u ^ 2429029434u);
					continue;
				case 7u:
					arg_FA_0 = (other.Deprecated ? 1997045737u : 863932600u);
					continue;
				case 9u:
					this.MapEntry = other.MapEntry;
					arg_FA_0 = (num * 55876113u ^ 3079603292u);
					continue;
				case 10u:
					arg_FA_0 = ((!other.MapEntry) ? 878065272u : 1486919559u);
					continue;
				}
				break;
			}
			this.uninterpretedOption_.Add(other.uninterpretedOption_);
			return;
			IL_F0:
			arg_FA_0 = 403572051u;
			goto IL_F5;
			IL_142:
			arg_FA_0 = (other.MessageSetWireFormat ? 1384417060u : 1651946685u);
			goto IL_F5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_229:
				uint num;
				uint arg_1C1_0 = ((num = input.ReadTag()) != 0u) ? 3469620998u : 3630242310u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1C1_0 ^ 2243419113u)) % 19u)
					{
					case 0u:
						this.Deprecated = input.ReadBool();
						arg_1C1_0 = 4234244018u;
						continue;
					case 1u:
						arg_1C1_0 = (num2 * 1644263179u ^ 1170768354u);
						continue;
					case 2u:
						goto IL_229;
					case 3u:
						input.SkipLastField();
						arg_1C1_0 = 2369499066u;
						continue;
					case 4u:
						arg_1C1_0 = (((num == 16u) ? 2225045656u : 2169105142u) ^ num2 * 1051808150u);
						continue;
					case 5u:
						this.NoStandardDescriptorAccessor = input.ReadBool();
						arg_1C1_0 = 2208996371u;
						continue;
					case 6u:
						arg_1C1_0 = 3469620998u;
						continue;
					case 7u:
						this.uninterpretedOption_.AddEntriesFrom(input, MessageOptions._repeated_uninterpretedOption_codec);
						arg_1C1_0 = 2369499066u;
						continue;
					case 8u:
						arg_1C1_0 = (((num == 7994u) ? 138419680u : 227237099u) ^ num2 * 1910417148u);
						continue;
					case 9u:
						this.MapEntry = input.ReadBool();
						arg_1C1_0 = 2369499066u;
						continue;
					case 10u:
						arg_1C1_0 = (((num == 8u) ? 3686731008u : 3021766251u) ^ num2 * 3755396946u);
						continue;
					case 12u:
						arg_1C1_0 = (num2 * 370407906u ^ 961682190u);
						continue;
					case 13u:
						arg_1C1_0 = ((num != 24u) ? 4272774463u : 3566958352u);
						continue;
					case 14u:
						arg_1C1_0 = (num2 * 3078376082u ^ 1948281938u);
						continue;
					case 15u:
						this.MessageSetWireFormat = input.ReadBool();
						arg_1C1_0 = 2728242621u;
						continue;
					case 16u:
						arg_1C1_0 = ((num > 16u) ? 3204990346u : 2966243978u);
						continue;
					case 17u:
						arg_1C1_0 = (((num == 56u) ? 3181980743u : 2795719428u) ^ num2 * 3530361039u);
						continue;
					case 18u:
						arg_1C1_0 = (num2 * 1415060401u ^ 821814353u);
						continue;
					}
					return;
				}
			}
		}
	}
}
