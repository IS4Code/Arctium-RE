using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Profanity.V1
{
	[DebuggerNonUserCode]
	public sealed class WordFilters : IMessage<WordFilters>, IEquatable<WordFilters>, IDeepCloneable<WordFilters>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly WordFilters.__c __9 = new WordFilters.__c();

			internal WordFilters cctor>b__24_0()
			{
				return new WordFilters();
			}
		}

		private static readonly MessageParser<WordFilters> _parser = new MessageParser<WordFilters>(new Func<WordFilters>(WordFilters.__c.__9.<.cctor>b__24_0));

		public const int FiltersFieldNumber = 1;

		private static readonly FieldCodec<WordFilter> _repeated_filters_codec;

		private readonly RepeatedField<WordFilter> filters_ = new RepeatedField<WordFilter>();

		public static MessageParser<WordFilters> Parser
		{
			get
			{
				return WordFilters._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfanityFilterConfigReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WordFilters.Descriptor;
			}
		}

		public RepeatedField<WordFilter> Filters
		{
			get
			{
				return this.filters_;
			}
		}

		public WordFilters()
		{
		}

		public WordFilters(WordFilters other) : this()
		{
			this.filters_ = other.filters_.Clone();
		}

		public WordFilters Clone()
		{
			return new WordFilters(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as WordFilters);
		}

		public bool Equals(WordFilters other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -1115541321) % 7)
				{
				case 0:
					goto IL_7A;
				case 1:
					return true;
				case 2:
					goto IL_3E;
				case 3:
					return false;
				case 5:
					arg_48_0 = (this.filters_.Equals(other.filters_) ? -1725088462 : -13371710);
					continue;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1517274203;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -2123226772 : -800374707);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ WordFilters.smethod_0(this.filters_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.filters_.WriteTo(output, WordFilters._repeated_filters_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.filters_.CalculateSize(WordFilters._repeated_filters_codec);
		}

		public void MergeFrom(WordFilters other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -1569284894;
			IL_08:
			switch ((arg_0D_0 ^ -1589129547) % 4)
			{
			case 0:
				IL_27:
				this.filters_.Add(other.filters_);
				arg_0D_0 = -628317384;
				goto IL_08;
			case 2:
				goto IL_03;
			case 3:
				return;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) != 0u) ? 4002328322u : 4267310479u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 2467492241u)) % 6u)
					{
					case 0u:
						input.SkipLastField();
						arg_68_0 = (num2 * 1325105898u ^ 4051839146u);
						continue;
					case 1u:
						goto IL_9B;
					case 2u:
						arg_68_0 = 4002328322u;
						continue;
					case 3u:
						arg_68_0 = ((num == 10u) ? 4087960464u : 3183044381u);
						continue;
					case 5u:
						this.filters_.AddEntriesFrom(input, WordFilters._repeated_filters_codec);
						arg_68_0 = 4279016274u;
						continue;
					}
					return;
				}
			}
		}

		static WordFilters()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 436654320u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 1731123610u)) % 3u)
					{
					case 1u:
						WordFilters._repeated_filters_codec = FieldCodec.ForMessage<WordFilter>(10u, WordFilter.Parser);
						arg_3F_0 = (num * 2721993810u ^ 2719931944u);
						continue;
					case 2u:
						goto IL_57;
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
