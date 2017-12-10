using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Any : IMessage<Any>, IEquatable<Any>, IDeepCloneable<Any>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Any.__c __9 = new Any.__c();

			internal Any cctor>b__32_0()
			{
				return new Any();
			}
		}

		private static readonly MessageParser<Any> _parser = new MessageParser<Any>(new Func<Any>(Any.__c.__9.<.cctor>b__32_0));

		public const int TypeUrlFieldNumber = 1;

		private string typeUrl_ = "";

		public const int ValueFieldNumber = 2;

		private ByteString value_ = ByteString.Empty;

		public static MessageParser<Any> Parser
		{
			get
			{
				return Any._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AnyReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Any.Descriptor;
			}
		}

		public string TypeUrl
		{
			get
			{
				return this.typeUrl_;
			}
			set
			{
				this.typeUrl_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public ByteString Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public Any()
		{
		}

		public Any(Any other) : this()
		{
			this.typeUrl_ = other.typeUrl_;
			this.value_ = other.value_;
		}

		public Any Clone()
		{
			return new Any(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Any);
		}

		public bool Equals(Any other)
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
				switch ((arg_77_0 ^ -266947875) % 9)
				{
				case 0:
					goto IL_6D;
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					arg_77_0 = ((!Any.smethod_0(this.TypeUrl, other.TypeUrl)) ? -49924200 : -1634714796);
					continue;
				case 5:
					return false;
				case 6:
					arg_77_0 = ((!(this.Value != other.Value)) ? -1501110427 : -1202618130);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_B5;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = -1733635347;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? -1856424846 : -1557946227);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_BC:
				uint arg_98_0 = 3238189062u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_98_0 ^ 2582109860u)) % 6u)
					{
					case 0u:
						goto IL_BC;
					case 1u:
						arg_98_0 = ((this.Value.Length == 0) ? 3739400481u : 3153666163u);
						continue;
					case 2u:
						arg_98_0 = (((Any.smethod_1(this.TypeUrl) == 0) ? 1718208019u : 613206384u) ^ num2 * 3704984589u);
						continue;
					case 4u:
						num ^= Any.smethod_2(this.TypeUrl);
						arg_98_0 = (num2 * 1357708642u ^ 1179581237u);
						continue;
					case 5u:
						num ^= Any.smethod_2(this.Value);
						arg_98_0 = (num2 * 2537426074u ^ 1565251703u);
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
			if (Any.smethod_1(this.TypeUrl) != 0)
			{
				goto IL_3A;
			}
			goto IL_C4;
			uint arg_8D_0;
			while (true)
			{
				IL_88:
				uint num;
				switch ((num = (arg_8D_0 ^ 3542651897u)) % 7u)
				{
				case 0u:
					output.WriteBytes(this.Value);
					arg_8D_0 = (num * 3096950004u ^ 1550694974u);
					continue;
				case 1u:
					output.WriteRawTag(18);
					arg_8D_0 = (num * 3759571440u ^ 4103770029u);
					continue;
				case 3u:
					goto IL_C4;
				case 4u:
					output.WriteRawTag(10);
					arg_8D_0 = (num * 668947384u ^ 1936825636u);
					continue;
				case 5u:
					goto IL_3A;
				case 6u:
					output.WriteString(this.TypeUrl);
					arg_8D_0 = (num * 4247973150u ^ 3768294887u);
					continue;
				}
				break;
			}
			return;
			IL_3A:
			arg_8D_0 = 2936706576u;
			goto IL_88;
			IL_C4:
			arg_8D_0 = ((this.Value.Length != 0) ? 2348183275u : 3168545198u);
			goto IL_88;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_C0:
				uint arg_9C_0 = 627454731u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9C_0 ^ 1964764111u)) % 6u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.TypeUrl);
						arg_9C_0 = (num2 * 4205353441u ^ 3643455519u);
						continue;
					case 2u:
						arg_9C_0 = (((Any.smethod_1(this.TypeUrl) != 0) ? 871222102u : 890700454u) ^ num2 * 4125686318u);
						continue;
					case 3u:
						arg_9C_0 = ((this.Value.Length != 0) ? 1812534943u : 296351795u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.Value);
						arg_9C_0 = (num2 * 1702148799u ^ 3370051203u);
						continue;
					case 5u:
						goto IL_C0;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Any other)
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
				switch ((num = (arg_7B_0 ^ 3619588254u)) % 7u)
				{
				case 0u:
					arg_7B_0 = ((other.Value.Length != 0) ? 2690639846u : 4017128255u);
					continue;
				case 2u:
					goto IL_B2;
				case 3u:
					goto IL_4B;
				case 4u:
					this.TypeUrl = other.TypeUrl;
					arg_7B_0 = (num * 667143161u ^ 3625366420u);
					continue;
				case 5u:
					return;
				case 6u:
					this.Value = other.Value;
					arg_7B_0 = (num * 1706520041u ^ 4028370695u);
					continue;
				}
				break;
			}
			return;
			IL_4B:
			arg_7B_0 = 2995681125u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((Any.smethod_1(other.TypeUrl) != 0) ? 3546046839u : 2210067765u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_104:
				uint num;
				uint arg_C0_0 = ((num = input.ReadTag()) == 0u) ? 2525882889u : 4083236235u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C0_0 ^ 2907843882u)) % 10u)
					{
					case 0u:
						goto IL_104;
					case 2u:
						this.Value = input.ReadBytes();
						arg_C0_0 = 3282640910u;
						continue;
					case 3u:
						arg_C0_0 = (num2 * 949591935u ^ 1293658861u);
						continue;
					case 4u:
						this.TypeUrl = input.ReadString();
						arg_C0_0 = 2903211081u;
						continue;
					case 5u:
						arg_C0_0 = 4083236235u;
						continue;
					case 6u:
						arg_C0_0 = (((num != 18u) ? 1706837388u : 341647534u) ^ num2 * 3560770054u);
						continue;
					case 7u:
						arg_C0_0 = ((num == 10u) ? 2877676408u : 3509322910u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_C0_0 = (num2 * 3800174213u ^ 2397004705u);
						continue;
					case 9u:
						arg_C0_0 = (num2 * 522163179u ^ 2954866415u);
						continue;
					}
					return;
				}
			}
		}

		private static string GetTypeUrl(MessageDescriptor descriptor)
		{
			return Any.smethod_3(Module.smethod_37<string>(3472318492u), descriptor.FullName);
		}

		public T Unpack<T>() where T : IMessage, new()
		{
			T t = Activator.CreateInstance<T>();
			string typeUrl = Any.GetTypeUrl(t.Descriptor);
			if (Any.smethod_0(this.TypeUrl, typeUrl))
			{
				throw new InvalidProtocolBufferException(Any.smethod_4(Module.smethod_37<string>(1690318190u), new object[]
				{
					t.Descriptor.Name,
					typeUrl,
					this.TypeUrl
				}));
			}
			t.MergeFrom(this.Value);
			return t;
		}

		public static Any Pack(IMessage message)
		{
			Preconditions.CheckNotNull<IMessage>(message, Module.smethod_35<string>(2616444679u));
			return new Any
			{
				TypeUrl = Any.GetTypeUrl(message.Descriptor),
				Value = message.ToByteString()
			};
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}

		static string smethod_3(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static string smethod_4(string string_0, object[] object_0)
		{
			return string.Format(string_0, object_0);
		}
	}
}
