using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class FieldOptions : IMessage, IMessage<FieldOptions>, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum CType
			{
				STRING,
				CORD,
				STRING_PIECE
			}

			internal enum JSType
			{
				JS_NORMAL,
				JS_STRING,
				JS_NUMBER
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FieldOptions.__c __9 = new FieldOptions.__c();

			internal FieldOptions cctor>b__55_0()
			{
				return new FieldOptions();
			}
		}

		private static readonly MessageParser<FieldOptions> _parser = new MessageParser<FieldOptions>(new Func<FieldOptions>(FieldOptions.__c.__9.<.cctor>b__55_0));

		public const int CtypeFieldNumber = 1;

		private FieldOptions.Types.CType ctype_;

		public const int PackedFieldNumber = 2;

		private bool packed_;

		public const int JstypeFieldNumber = 6;

		private FieldOptions.Types.JSType jstype_;

		public const int LazyFieldNumber = 5;

		private bool lazy_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int WeakFieldNumber = 10;

		private bool weak_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

		public static MessageParser<FieldOptions> Parser
		{
			get
			{
				return FieldOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldOptions.Descriptor;
			}
		}

		public FieldOptions.Types.CType Ctype
		{
			get
			{
				return this.ctype_;
			}
			set
			{
				this.ctype_ = value;
			}
		}

		public bool Packed
		{
			get
			{
				return this.packed_;
			}
			set
			{
				this.packed_ = value;
			}
		}

		public FieldOptions.Types.JSType Jstype
		{
			get
			{
				return this.jstype_;
			}
			set
			{
				this.jstype_ = value;
			}
		}

		public bool Lazy
		{
			get
			{
				return this.lazy_;
			}
			set
			{
				this.lazy_ = value;
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

		public bool Weak
		{
			get
			{
				return this.weak_;
			}
			set
			{
				this.weak_ = value;
			}
		}

		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			get
			{
				return this.uninterpretedOption_;
			}
		}

		public FieldOptions()
		{
			this.OnConstruction();
		}

		private void OnConstruction()
		{
			this.Packed = true;
		}

		public FieldOptions(FieldOptions other) : this()
		{
			while (true)
			{
				IL_DA:
				uint arg_B2_0 = 808513109u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B2_0 ^ 1673929259u)) % 7u)
					{
					case 0u:
						this.lazy_ = other.lazy_;
						this.deprecated_ = other.deprecated_;
						arg_B2_0 = (num * 1133508417u ^ 1906076001u);
						continue;
					case 1u:
						this.packed_ = other.packed_;
						arg_B2_0 = (num * 1815268208u ^ 3651080080u);
						continue;
					case 3u:
						this.jstype_ = other.jstype_;
						arg_B2_0 = (num * 3730434426u ^ 754207911u);
						continue;
					case 4u:
						goto IL_DA;
					case 5u:
						this.ctype_ = other.ctype_;
						arg_B2_0 = (num * 4141407866u ^ 3946025637u);
						continue;
					case 6u:
						this.weak_ = other.weak_;
						this.uninterpretedOption_ = other.uninterpretedOption_.Clone();
						arg_B2_0 = (num * 114519735u ^ 3987153241u);
						continue;
					}
					return;
				}
			}
		}

		public FieldOptions Clone()
		{
			return new FieldOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FieldOptions);
		}

		public bool Equals(FieldOptions other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_1AA;
			int arg_144_0;
			while (true)
			{
				IL_13F:
				switch ((arg_144_0 ^ 1677661686) % 19)
				{
				case 0:
					arg_144_0 = ((this.Lazy == other.Lazy) ? 723003155 : 474187183);
					continue;
				case 1:
					arg_144_0 = ((this.Deprecated == other.Deprecated) ? 540824740 : 1452804520);
					continue;
				case 2:
					arg_144_0 = ((this.Weak == other.Weak) ? 1148384309 : 2106197812);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					arg_144_0 = ((!this.uninterpretedOption_.Equals(other.uninterpretedOption_)) ? 2145323254 : 1839087411);
					continue;
				case 7:
					arg_144_0 = ((this.Jstype != other.Jstype) ? 1269046770 : 994806066);
					continue;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					goto IL_6C;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					arg_144_0 = ((this.Ctype == other.Ctype) ? 50995162 : 1332910505);
					continue;
				case 15:
					goto IL_1AA;
				case 16:
					return false;
				case 17:
					arg_144_0 = ((this.Packed != other.Packed) ? 1087975950 : 2136696893);
					continue;
				}
				break;
			}
			return true;
			IL_6C:
			arg_144_0 = 403586235;
			goto IL_13F;
			IL_1AA:
			arg_144_0 = ((other != this) ? 775640992 : 1930160596);
			goto IL_13F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_225:
				uint arg_1DB_0 = 4046111446u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1DB_0 ^ 3220408252u)) % 15u)
					{
					case 0u:
						goto IL_225;
					case 2u:
						arg_1DB_0 = (this.Weak ? 2799619124u : 3851482077u);
						continue;
					case 3u:
						arg_1DB_0 = ((this.Jstype != FieldOptions.Types.JSType.JS_NORMAL) ? 2500702552u : 3530990958u);
						continue;
					case 4u:
						num ^= this.Ctype.GetHashCode();
						arg_1DB_0 = (num2 * 2444289584u ^ 238364999u);
						continue;
					case 5u:
						arg_1DB_0 = (((this.Ctype == FieldOptions.Types.CType.STRING) ? 2753426405u : 2905759143u) ^ num2 * 228232453u);
						continue;
					case 6u:
						arg_1DB_0 = (this.Lazy ? 2864276380u : 2386267677u);
						continue;
					case 7u:
						num ^= this.Deprecated.GetHashCode();
						arg_1DB_0 = (num2 * 4171427001u ^ 350107936u);
						continue;
					case 8u:
						num ^= this.Jstype.GetHashCode();
						arg_1DB_0 = (num2 * 55930598u ^ 333049270u);
						continue;
					case 9u:
						num ^= this.Packed.GetHashCode();
						arg_1DB_0 = (num2 * 3779669471u ^ 729510438u);
						continue;
					case 10u:
						num ^= this.Lazy.GetHashCode();
						arg_1DB_0 = (num2 * 2598487431u ^ 303129341u);
						continue;
					case 11u:
						num ^= this.Weak.GetHashCode();
						arg_1DB_0 = (num2 * 162405353u ^ 707912981u);
						continue;
					case 12u:
						num ^= this.uninterpretedOption_.GetHashCode();
						arg_1DB_0 = 2263293982u;
						continue;
					case 13u:
						arg_1DB_0 = ((!this.Packed) ? 2532064640u : 4139630246u);
						continue;
					case 14u:
						arg_1DB_0 = ((!this.Deprecated) ? 2966496898u : 3252598798u);
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
			if (this.Ctype != FieldOptions.Types.CType.STRING)
			{
				goto IL_38;
			}
			goto IL_255;
			uint arg_1F1_0;
			while (true)
			{
				IL_1EC:
				uint num;
				switch ((num = (arg_1F1_0 ^ 112622770u)) % 18u)
				{
				case 0u:
					output.WriteBool(this.Deprecated);
					arg_1F1_0 = (num * 1735206152u ^ 3607075555u);
					continue;
				case 1u:
					arg_1F1_0 = ((!this.Lazy) ? 986132828u : 133581530u);
					continue;
				case 2u:
					arg_1F1_0 = ((this.Jstype == FieldOptions.Types.JSType.JS_NORMAL) ? 1508206835u : 750506624u);
					continue;
				case 3u:
					goto IL_255;
				case 4u:
					output.WriteRawTag(40);
					arg_1F1_0 = (num * 417846806u ^ 2667861130u);
					continue;
				case 5u:
					output.WriteEnum((int)this.Jstype);
					arg_1F1_0 = (num * 1959736267u ^ 2906137754u);
					continue;
				case 6u:
					output.WriteRawTag(48);
					arg_1F1_0 = (num * 43651066u ^ 620409981u);
					continue;
				case 7u:
					output.WriteRawTag(16);
					arg_1F1_0 = (num * 843428670u ^ 746818609u);
					continue;
				case 8u:
					output.WriteRawTag(8);
					output.WriteEnum((int)this.Ctype);
					arg_1F1_0 = (num * 3679862888u ^ 1990182193u);
					continue;
				case 9u:
					output.WriteBool(this.Packed);
					arg_1F1_0 = (num * 2613794982u ^ 3213554680u);
					continue;
				case 10u:
					output.WriteBool(this.Lazy);
					arg_1F1_0 = (num * 3928531342u ^ 3868934060u);
					continue;
				case 11u:
					arg_1F1_0 = ((!this.Weak) ? 1173751509u : 1598910769u);
					continue;
				case 12u:
					arg_1F1_0 = (this.Deprecated ? 669054027u : 717399811u);
					continue;
				case 13u:
					output.WriteRawTag(80);
					output.WriteBool(this.Weak);
					arg_1F1_0 = (num * 3246052724u ^ 2660767881u);
					continue;
				case 15u:
					output.WriteRawTag(24);
					arg_1F1_0 = (num * 2569592853u ^ 3829707491u);
					continue;
				case 16u:
					goto IL_38;
				case 17u:
					this.uninterpretedOption_.WriteTo(output, FieldOptions._repeated_uninterpretedOption_codec);
					arg_1F1_0 = 417261098u;
					continue;
				}
				break;
			}
			return;
			IL_38:
			arg_1F1_0 = 1048730324u;
			goto IL_1EC;
			IL_255:
			arg_1F1_0 = ((!this.Packed) ? 1399092230u : 720838271u);
			goto IL_1EC;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Ctype != FieldOptions.Types.CType.STRING)
			{
				goto IL_8C;
			}
			goto IL_1BA;
			uint arg_166_0;
			while (true)
			{
				IL_161:
				uint num2;
				switch ((num2 = (arg_166_0 ^ 2216341055u)) % 14u)
				{
				case 0u:
					num += 2;
					arg_166_0 = (num2 * 2210841885u ^ 1303415503u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Jstype);
					arg_166_0 = (num2 * 3021538482u ^ 2799871695u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Ctype);
					arg_166_0 = (num2 * 145702162u ^ 966589614u);
					continue;
				case 3u:
					num += 2;
					arg_166_0 = (num2 * 1654030685u ^ 647672885u);
					continue;
				case 4u:
					arg_166_0 = ((this.Jstype != FieldOptions.Types.JSType.JS_NORMAL) ? 3922037432u : 4161414929u);
					continue;
				case 5u:
					goto IL_1BA;
				case 7u:
					arg_166_0 = (this.Deprecated ? 3316210611u : 3731788443u);
					continue;
				case 8u:
					arg_166_0 = ((!this.Lazy) ? 2667153800u : 3886066142u);
					continue;
				case 9u:
					goto IL_8C;
				case 10u:
					num += 2;
					arg_166_0 = (num2 * 2873872320u ^ 3773222811u);
					continue;
				case 11u:
					num += this.uninterpretedOption_.CalculateSize(FieldOptions._repeated_uninterpretedOption_codec);
					arg_166_0 = 2595162795u;
					continue;
				case 12u:
					arg_166_0 = (this.Weak ? 2639522660u : 2799949384u);
					continue;
				case 13u:
					num += 2;
					arg_166_0 = (num2 * 2543969490u ^ 3992528622u);
					continue;
				}
				break;
			}
			return num;
			IL_8C:
			arg_166_0 = 4244226189u;
			goto IL_161;
			IL_1BA:
			arg_166_0 = ((!this.Packed) ? 3433666033u : 3599090665u);
			goto IL_161;
		}

		public void MergeFrom(FieldOptions other)
		{
			if (other == null)
			{
				goto IL_18F;
			}
			goto IL_1F5;
			uint arg_199_0;
			while (true)
			{
				IL_194:
				uint num;
				switch ((num = (arg_199_0 ^ 3668595373u)) % 16u)
				{
				case 0u:
					goto IL_18F;
				case 2u:
					this.Packed = other.Packed;
					arg_199_0 = (num * 3363954266u ^ 1141912438u);
					continue;
				case 3u:
					return;
				case 4u:
					this.Ctype = other.Ctype;
					arg_199_0 = (num * 3099798110u ^ 3572956235u);
					continue;
				case 5u:
					this.Weak = other.Weak;
					arg_199_0 = (num * 1074779969u ^ 666552031u);
					continue;
				case 6u:
					arg_199_0 = (other.Lazy ? 4032626144u : 3960941857u);
					continue;
				case 7u:
					this.uninterpretedOption_.Add(other.uninterpretedOption_);
					arg_199_0 = 2619398844u;
					continue;
				case 8u:
					arg_199_0 = (other.Weak ? 2345773608u : 3125152282u);
					continue;
				case 9u:
					goto IL_1F5;
				case 10u:
					this.Deprecated = other.Deprecated;
					arg_199_0 = (num * 65348797u ^ 3966278039u);
					continue;
				case 11u:
					this.Jstype = other.Jstype;
					arg_199_0 = (num * 2395785374u ^ 2363568961u);
					continue;
				case 12u:
					arg_199_0 = (other.Deprecated ? 4009625927u : 2582534741u);
					continue;
				case 13u:
					this.Lazy = other.Lazy;
					arg_199_0 = (num * 3911880552u ^ 4224849769u);
					continue;
				case 14u:
					arg_199_0 = ((!other.Packed) ? 3924386402u : 2998174303u);
					continue;
				case 15u:
					arg_199_0 = ((other.Jstype != FieldOptions.Types.JSType.JS_NORMAL) ? 3436809366u : 3200545579u);
					continue;
				}
				break;
			}
			return;
			IL_18F:
			arg_199_0 = 2257808430u;
			goto IL_194;
			IL_1F5:
			arg_199_0 = ((other.Ctype != FieldOptions.Types.CType.STRING) ? 3459379481u : 4176173139u);
			goto IL_194;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2C6:
				uint num;
				uint arg_24E_0 = ((num = input.ReadTag()) == 0u) ? 3577994024u : 2900136090u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_24E_0 ^ 3940398529u)) % 23u)
					{
					case 0u:
						this.Deprecated = input.ReadBool();
						arg_24E_0 = 3598919458u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_24E_0 = 4066581966u;
						continue;
					case 2u:
						goto IL_2C6;
					case 3u:
						arg_24E_0 = (num2 * 4119144919u ^ 2508302955u);
						continue;
					case 4u:
						this.Packed = input.ReadBool();
						arg_24E_0 = 4066581966u;
						continue;
					case 5u:
						arg_24E_0 = (((num == 48u) ? 512079659u : 1892605707u) ^ num2 * 2804962785u);
						continue;
					case 7u:
						arg_24E_0 = (num2 * 423148375u ^ 3853171181u);
						continue;
					case 8u:
						arg_24E_0 = ((num > 24u) ? 3950198473u : 2516790018u);
						continue;
					case 9u:
						arg_24E_0 = (((num != 40u) ? 1557120368u : 418334193u) ^ num2 * 1501125555u);
						continue;
					case 10u:
						arg_24E_0 = ((num != 80u) ? 3549521329u : 4042494146u);
						continue;
					case 11u:
						this.Weak = input.ReadBool();
						arg_24E_0 = 4066581966u;
						continue;
					case 12u:
						arg_24E_0 = (((num != 8u) ? 4235403621u : 3955850366u) ^ num2 * 390384741u);
						continue;
					case 13u:
						arg_24E_0 = (((num == 24u) ? 3742356801u : 3570614176u) ^ num2 * 2459507463u);
						continue;
					case 14u:
						this.jstype_ = (FieldOptions.Types.JSType)input.ReadEnum();
						arg_24E_0 = 4066581966u;
						continue;
					case 15u:
						arg_24E_0 = (((num != 7994u) ? 2850221438u : 3858242592u) ^ num2 * 434354732u);
						continue;
					case 16u:
						arg_24E_0 = (((num != 16u) ? 694792793u : 2054021774u) ^ num2 * 3402682316u);
						continue;
					case 17u:
						arg_24E_0 = ((num <= 48u) ? 3670737637u : 3443182464u);
						continue;
					case 18u:
						arg_24E_0 = (num2 * 1380117418u ^ 2547356600u);
						continue;
					case 19u:
						arg_24E_0 = 2900136090u;
						continue;
					case 20u:
						this.uninterpretedOption_.AddEntriesFrom(input, FieldOptions._repeated_uninterpretedOption_codec);
						arg_24E_0 = 4066581966u;
						continue;
					case 21u:
						this.ctype_ = (FieldOptions.Types.CType)input.ReadEnum();
						arg_24E_0 = 4066581966u;
						continue;
					case 22u:
						this.Lazy = input.ReadBool();
						arg_24E_0 = 4066581966u;
						continue;
					}
					return;
				}
			}
		}

		static FieldOptions()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_5A:
				uint arg_42_0 = 537177894u;
				while (true)
				{
					uint num;
					switch ((num = (arg_42_0 ^ 974030318u)) % 3u)
					{
					case 0u:
						goto IL_5A;
					case 2u:
						FieldOptions._repeated_uninterpretedOption_codec = FieldCodec.ForMessage<UninterpretedOption>(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);
						arg_42_0 = (num * 3539671116u ^ 3074555809u);
						continue;
					}
					return;
				}
			}
		}
	}
}
