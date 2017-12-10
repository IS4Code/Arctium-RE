using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class SourceContext : IMessage<SourceContext>, IEquatable<SourceContext>, IDeepCloneable<SourceContext>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SourceContext.__c __9 = new SourceContext.__c();

			internal SourceContext cctor>b__24_0()
			{
				return new SourceContext();
			}
		}

		private static readonly MessageParser<SourceContext> _parser = new MessageParser<SourceContext>(new Func<SourceContext>(SourceContext.__c.__9.<.cctor>b__24_0));

		public const int FileNameFieldNumber = 1;

		private string fileName_ = "";

		public static MessageParser<SourceContext> Parser
		{
			get
			{
				return SourceContext._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return SourceContextReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SourceContext.Descriptor;
			}
		}

		public string FileName
		{
			get
			{
				return this.fileName_;
			}
			set
			{
				this.fileName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public SourceContext()
		{
		}

		public SourceContext(SourceContext other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 1299396674u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 367262834u)) % 3u)
					{
					case 0u:
						goto IL_3E;
					case 2u:
						this.fileName_ = other.fileName_;
						arg_26_0 = (num * 2075090329u ^ 3107215238u);
						continue;
					}
					return;
				}
			}
		}

		public SourceContext Clone()
		{
			return new SourceContext(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SourceContext);
		}

		public bool Equals(SourceContext other)
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
				switch ((arg_48_0 ^ -848514144) % 7)
				{
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_48_0 = ((!SourceContext.smethod_0(this.FileName, other.FileName)) ? -293538425 : -1065215165);
					continue;
				case 4:
					return true;
				case 5:
					goto IL_12;
				case 6:
					goto IL_7A;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -1768662209;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -107216803 : -945466951);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6E:
				uint arg_52_0 = 1016427086u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_52_0 ^ 1150699827u)) % 4u)
					{
					case 0u:
						num ^= SourceContext.smethod_2(this.FileName);
						arg_52_0 = (num2 * 2731910619u ^ 3810306340u);
						continue;
					case 1u:
						arg_52_0 = (((SourceContext.smethod_1(this.FileName) != 0) ? 2989820395u : 2830572180u) ^ num2 * 224591180u);
						continue;
					case 2u:
						goto IL_6E;
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
			if (SourceContext.smethod_1(this.FileName) != 0)
			{
				while (true)
				{
					IL_4D:
					uint arg_35_0 = 1923217443u;
					while (true)
					{
						uint num;
						switch ((num = (arg_35_0 ^ 1930876169u)) % 3u)
						{
						case 0u:
							goto IL_4D;
						case 1u:
							output.WriteRawTag(10);
							output.WriteString(this.FileName);
							arg_35_0 = (num * 2588046334u ^ 3849043600u);
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
			if (SourceContext.smethod_1(this.FileName) != 0)
			{
				while (true)
				{
					IL_4B:
					uint arg_33_0 = 1784989464u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_33_0 ^ 1266556161u)) % 3u)
						{
						case 0u:
							goto IL_4B;
						case 2u:
							num += 1 + CodedOutputStream.ComputeStringSize(this.FileName);
							arg_33_0 = (num2 * 1743729836u ^ 1235133431u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(SourceContext other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 1138024573u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					return;
				case 2u:
					this.FileName = other.FileName;
					arg_37_0 = (num * 4103704563u ^ 1542311052u);
					continue;
				case 4u:
					goto IL_63;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 1260396369u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((SourceContext.smethod_1(other.FileName) == 0) ? 1240945136u : 1198106601u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) != 0u) ? 139025062u : 276816383u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 841605153u)) % 7u)
					{
					case 0u:
						arg_72_0 = (num2 * 65442860u ^ 4061785469u);
						continue;
					case 1u:
						this.FileName = input.ReadString();
						arg_72_0 = 1486940085u;
						continue;
					case 2u:
						arg_72_0 = ((num == 10u) ? 1132349571u : 1142120174u);
						continue;
					case 3u:
						goto IL_A9;
					case 4u:
						input.SkipLastField();
						arg_72_0 = (num2 * 502177937u ^ 4035149896u);
						continue;
					case 6u:
						arg_72_0 = 139025062u;
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

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
