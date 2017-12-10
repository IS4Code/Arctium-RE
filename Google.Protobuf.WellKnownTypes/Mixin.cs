using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Mixin : IMessage<Mixin>, IEquatable<Mixin>, IDeepCloneable<Mixin>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Mixin.__c __9 = new Mixin.__c();

			internal Mixin cctor>b__29_0()
			{
				return new Mixin();
			}
		}

		private static readonly MessageParser<Mixin> _parser = new MessageParser<Mixin>(new Func<Mixin>(Mixin.__c.__9.<.cctor>b__29_0));

		public const int NameFieldNumber = 1;

		private string name_ = "";

		public const int RootFieldNumber = 2;

		private string root_ = "";

		public static MessageParser<Mixin> Parser
		{
			get
			{
				return Mixin._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ApiReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Mixin.Descriptor;
			}
		}

		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public string Root
		{
			get
			{
				return this.root_;
			}
			set
			{
				this.root_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public Mixin()
		{
		}

		public Mixin(Mixin other) : this()
		{
			this.name_ = other.name_;
			this.root_ = other.root_;
		}

		public Mixin Clone()
		{
			return new Mixin(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Mixin);
		}

		public bool Equals(Mixin other)
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
				switch ((arg_77_0 ^ 171421768) % 9)
				{
				case 0:
					goto IL_6D;
				case 1:
					goto IL_B5;
				case 2:
					return true;
				case 3:
					arg_77_0 = ((!Mixin.smethod_0(this.Name, other.Name)) ? 694751098 : 1039140074);
					continue;
				case 4:
					arg_77_0 = (Mixin.smethod_0(this.Root, other.Root) ? 1400334823 : 801810516);
					continue;
				case 5:
					return false;
				case 7:
					return false;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = 1131937810;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? 453941896 : 1698603891);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_BC:
				uint arg_98_0 = 1859862458u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_98_0 ^ 2114016073u)) % 6u)
					{
					case 1u:
						arg_98_0 = ((Mixin.smethod_1(this.Root) != 0) ? 1100364891u : 68989251u);
						continue;
					case 2u:
						num ^= Mixin.smethod_2(this.Name);
						arg_98_0 = (num2 * 2141705660u ^ 4084696480u);
						continue;
					case 3u:
						arg_98_0 = (((Mixin.smethod_1(this.Name) != 0) ? 3482210938u : 3707982931u) ^ num2 * 196494337u);
						continue;
					case 4u:
						num ^= Mixin.smethod_2(this.Root);
						arg_98_0 = (num2 * 2131226396u ^ 1218659003u);
						continue;
					case 5u:
						goto IL_BC;
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
			if (Mixin.smethod_1(this.Name) != 0)
			{
				goto IL_36;
			}
			goto IL_B1;
			uint arg_7E_0;
			while (true)
			{
				IL_79:
				uint num;
				switch ((num = (arg_7E_0 ^ 4050726112u)) % 6u)
				{
				case 0u:
					output.WriteString(this.Root);
					arg_7E_0 = (num * 3206021508u ^ 1602284501u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					output.WriteString(this.Name);
					arg_7E_0 = (num * 53150773u ^ 1871299191u);
					continue;
				case 2u:
					goto IL_B1;
				case 3u:
					goto IL_36;
				case 4u:
					output.WriteRawTag(18);
					arg_7E_0 = (num * 2485965044u ^ 3235344308u);
					continue;
				}
				break;
			}
			return;
			IL_36:
			arg_7E_0 = 3870243183u;
			goto IL_79;
			IL_B1:
			arg_7E_0 = ((Mixin.smethod_1(this.Root) == 0) ? 4292466949u : 4106378904u);
			goto IL_79;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (Mixin.smethod_1(this.Name) != 0)
			{
				goto IL_5F;
			}
			goto IL_95;
			uint arg_69_0;
			while (true)
			{
				IL_64:
				uint num2;
				switch ((num2 = (arg_69_0 ^ 1715180091u)) % 5u)
				{
				case 0u:
					goto IL_5F;
				case 1u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Root);
					arg_69_0 = (num2 * 3764921619u ^ 3428854711u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
					arg_69_0 = (num2 * 3996097482u ^ 2721686621u);
					continue;
				case 3u:
					goto IL_95;
				}
				break;
			}
			return num;
			IL_5F:
			arg_69_0 = 1725115502u;
			goto IL_64;
			IL_95:
			arg_69_0 = ((Mixin.smethod_1(this.Root) == 0) ? 664810613u : 46227789u);
			goto IL_64;
		}

		public void MergeFrom(Mixin other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_B2;
			uint arg_7B_0;
			while (true)
			{
				IL_76:
				uint num;
				switch ((num = (arg_7B_0 ^ 3420864661u)) % 7u)
				{
				case 0u:
					goto IL_71;
				case 1u:
					return;
				case 2u:
					this.Name = other.Name;
					arg_7B_0 = (num * 3004981485u ^ 408027057u);
					continue;
				case 3u:
					arg_7B_0 = ((Mixin.smethod_1(other.Root) == 0) ? 3192039092u : 2514908272u);
					continue;
				case 4u:
					goto IL_B2;
				case 6u:
					this.Root = other.Root;
					arg_7B_0 = (num * 315293344u ^ 1963778964u);
					continue;
				}
				break;
			}
			return;
			IL_71:
			arg_7B_0 = 4175921205u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((Mixin.smethod_1(other.Name) != 0) ? 2666235522u : 3218930938u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_101:
				uint num;
				uint arg_BD_0 = ((num = input.ReadTag()) == 0u) ? 1427470634u : 1114621791u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BD_0 ^ 1045141300u)) % 10u)
					{
					case 0u:
						arg_BD_0 = 1114621791u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_BD_0 = (num2 * 3919988851u ^ 210890761u);
						continue;
					case 2u:
						this.Root = input.ReadString();
						arg_BD_0 = 379734757u;
						continue;
					case 3u:
						goto IL_101;
					case 5u:
						arg_BD_0 = (num2 * 1282089942u ^ 701528339u);
						continue;
					case 6u:
						this.Name = input.ReadString();
						arg_BD_0 = 1220154117u;
						continue;
					case 7u:
						arg_BD_0 = ((num == 10u) ? 1114609904u : 639406277u);
						continue;
					case 8u:
						arg_BD_0 = (num2 * 2859027321u ^ 2344329675u);
						continue;
					case 9u:
						arg_BD_0 = (((num == 18u) ? 4257329964u : 2533140407u) ^ num2 * 3213505586u);
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
