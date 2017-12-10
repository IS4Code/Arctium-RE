using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Profanity.V1
{
	[DebuggerNonUserCode]
	public sealed class WordFilter : IMessage<WordFilter>, IEquatable<WordFilter>, IDeepCloneable<WordFilter>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly WordFilter.__c __9 = new WordFilter.__c();

			internal WordFilter cctor>b__29_0()
			{
				return new WordFilter();
			}
		}

		private static readonly MessageParser<WordFilter> _parser = new MessageParser<WordFilter>(new Func<WordFilter>(WordFilter.__c.__9.<.cctor>b__29_0));

		public const int TypeFieldNumber = 1;

		private string type_ = "";

		public const int RegexFieldNumber = 2;

		private string regex_ = "";

		public static MessageParser<WordFilter> Parser
		{
			get
			{
				return WordFilter._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfanityFilterConfigReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WordFilter.Descriptor;
			}
		}

		public string Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public string Regex
		{
			get
			{
				return this.regex_;
			}
			set
			{
				this.regex_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public WordFilter()
		{
		}

		public WordFilter(WordFilter other) : this()
		{
			this.type_ = other.type_;
			this.regex_ = other.regex_;
		}

		public WordFilter Clone()
		{
			return new WordFilter(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as WordFilter);
		}

		public bool Equals(WordFilter other)
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
				switch ((arg_77_0 ^ 1180649682) % 9)
				{
				case 0:
					goto IL_6D;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					arg_77_0 = (WordFilter.smethod_0(this.Regex, other.Regex) ? 1141495469 : 2135546674);
					continue;
				case 4:
					return false;
				case 5:
					goto IL_B5;
				case 7:
					arg_77_0 = ((!WordFilter.smethod_0(this.Type, other.Type)) ? 1320976021 : 555786837);
					continue;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = 2131538239;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? 1705903226 : 1941087765);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			return 1 ^ WordFilter.smethod_1(this.Type) ^ WordFilter.smethod_1(this.Regex);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			while (true)
			{
				IL_54:
				uint arg_3C_0 = 792696616u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3C_0 ^ 1438615281u)) % 3u)
					{
					case 1u:
						output.WriteString(this.Type);
						output.WriteRawTag(18);
						output.WriteString(this.Regex);
						arg_3C_0 = (num * 707227727u ^ 1752250088u);
						continue;
					case 2u:
						goto IL_54;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeStringSize(this.Type)) + (1 + CodedOutputStream.ComputeStringSize(this.Regex));
		}

		public void MergeFrom(WordFilter other)
		{
			if (other == null)
			{
				goto IL_4B;
			}
			goto IL_B2;
			uint arg_7B_0;
			while (true)
			{
				IL_76:
				uint num;
				switch ((num = (arg_7B_0 ^ 2338810362u)) % 7u)
				{
				case 0u:
					arg_7B_0 = ((WordFilter.smethod_2(other.Regex) != 0) ? 2193237106u : 2729027723u);
					continue;
				case 2u:
					return;
				case 3u:
					goto IL_B2;
				case 4u:
					goto IL_4B;
				case 5u:
					this.Type = other.Type;
					arg_7B_0 = (num * 2532217204u ^ 1136756226u);
					continue;
				case 6u:
					this.Regex = other.Regex;
					arg_7B_0 = (num * 2477747733u ^ 1556505763u);
					continue;
				}
				break;
			}
			return;
			IL_4B:
			arg_7B_0 = 2799063862u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((WordFilter.smethod_2(other.Type) != 0) ? 2810757993u : 2434861982u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_EE:
				uint num;
				uint arg_AE_0 = ((num = input.ReadTag()) == 0u) ? 4223179575u : 3386969625u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AE_0 ^ 4068419742u)) % 9u)
					{
					case 0u:
						this.Regex = input.ReadString();
						arg_AE_0 = 2891915470u;
						continue;
					case 2u:
						arg_AE_0 = (num2 * 800110882u ^ 601764642u);
						continue;
					case 3u:
						arg_AE_0 = ((num != 10u) ? 3682255026u : 3650804832u);
						continue;
					case 4u:
						arg_AE_0 = (((num != 18u) ? 160971757u : 1462786302u) ^ num2 * 2038564213u);
						continue;
					case 5u:
						this.Type = input.ReadString();
						arg_AE_0 = 3983594760u;
						continue;
					case 6u:
						arg_AE_0 = 3386969625u;
						continue;
					case 7u:
						goto IL_EE;
					case 8u:
						input.SkipLastField();
						arg_AE_0 = (num2 * 4092212776u ^ 3225097110u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}
	}
}
