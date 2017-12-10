using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Duration : IMessage<Duration>, IEquatable<Duration>, IDeepCloneable<Duration>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Duration.__c __9 = new Duration.__c();

			internal Duration cctor>b__39_0()
			{
				return new Duration();
			}
		}

		private static readonly MessageParser<Duration> _parser = new MessageParser<Duration>(new Func<Duration>(Duration.__c.__9.<.cctor>b__39_0));

		public const int SecondsFieldNumber = 1;

		private long seconds_;

		public const int NanosFieldNumber = 2;

		private int nanos_;

		public const int NanosecondsPerSecond = 1000000000;

		public const int NanosecondsPerTick = 100;

		public const long MaxSeconds = 315576000000L;

		public const long MinSeconds = -315576000000L;

		public static MessageParser<Duration> Parser
		{
			get
			{
				return Duration._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DurationReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Duration.Descriptor;
			}
		}

		public long Seconds
		{
			get
			{
				return this.seconds_;
			}
			set
			{
				this.seconds_ = value;
			}
		}

		public int Nanos
		{
			get
			{
				return this.nanos_;
			}
			set
			{
				this.nanos_ = value;
			}
		}

		public Duration()
		{
		}

		public Duration(Duration other) : this()
		{
			this.seconds_ = other.seconds_;
			this.nanos_ = other.nanos_;
		}

		public Duration Clone()
		{
			return new Duration(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Duration);
		}

		public bool Equals(Duration other)
		{
			if (other == null)
			{
				goto IL_63;
			}
			goto IL_AB;
			int arg_6D_0;
			while (true)
			{
				IL_68:
				switch ((arg_6D_0 ^ -822716801) % 9)
				{
				case 0:
					goto IL_63;
				case 1:
					arg_6D_0 = ((this.Nanos == other.Nanos) ? -1889582540 : -1031598279);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					arg_6D_0 = ((this.Seconds == other.Seconds) ? -1607104054 : -315849016);
					continue;
				case 6:
					return false;
				case 7:
					goto IL_AB;
				}
				break;
			}
			return true;
			IL_63:
			arg_6D_0 = -1237393219;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other != this) ? -2102175788 : -851502069);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B8:
				uint arg_94_0 = 3589131854u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_94_0 ^ 3896750523u)) % 6u)
					{
					case 0u:
						num ^= this.Seconds.GetHashCode();
						arg_94_0 = (num2 * 2651281000u ^ 3407511537u);
						continue;
					case 1u:
						arg_94_0 = (((this.Seconds == 0L) ? 4133384583u : 3204986851u) ^ num2 * 2629093230u);
						continue;
					case 3u:
						num ^= this.Nanos.GetHashCode();
						arg_94_0 = (num2 * 2610127473u ^ 4049640222u);
						continue;
					case 4u:
						arg_94_0 = ((this.Nanos != 0) ? 4072392642u : 3202418295u);
						continue;
					case 5u:
						goto IL_B8;
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
			if (this.Seconds != 0L)
			{
				goto IL_4C;
			}
			goto IL_AB;
			uint arg_78_0;
			while (true)
			{
				IL_73:
				uint num;
				switch ((num = (arg_78_0 ^ 3954907304u)) % 6u)
				{
				case 0u:
					goto IL_AB;
				case 1u:
					output.WriteRawTag(8);
					output.WriteInt64(this.Seconds);
					arg_78_0 = (num * 2275524094u ^ 1130047906u);
					continue;
				case 2u:
					goto IL_4C;
				case 4u:
					output.WriteRawTag(16);
					arg_78_0 = (num * 2048335197u ^ 1784696699u);
					continue;
				case 5u:
					output.WriteInt32(this.Nanos);
					arg_78_0 = (num * 3492899611u ^ 459278314u);
					continue;
				}
				break;
			}
			return;
			IL_4C:
			arg_78_0 = 2803527439u;
			goto IL_73;
			IL_AB:
			arg_78_0 = ((this.Nanos == 0) ? 3877533863u : 2952532252u);
			goto IL_73;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Seconds != 0L)
			{
				goto IL_5A;
			}
			goto IL_90;
			uint arg_64_0;
			while (true)
			{
				IL_5F:
				uint num2;
				switch ((num2 = (arg_64_0 ^ 568531787u)) % 5u)
				{
				case 0u:
					goto IL_5A;
				case 2u:
					goto IL_90;
				case 3u:
					num += 1 + CodedOutputStream.ComputeInt32Size(this.Nanos);
					arg_64_0 = (num2 * 484218555u ^ 211908431u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeInt64Size(this.Seconds);
					arg_64_0 = (num2 * 818329190u ^ 2502904544u);
					continue;
				}
				break;
			}
			return num;
			IL_5A:
			arg_64_0 = 51306289u;
			goto IL_5F;
			IL_90:
			arg_64_0 = ((this.Nanos != 0) ? 40895790u : 1471354504u);
			goto IL_5F;
		}

		public void MergeFrom(Duration other)
		{
			if (other == null)
			{
				goto IL_51;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 3603750728u)) % 7u)
				{
				case 0u:
					this.Nanos = other.Nanos;
					arg_76_0 = (num * 3278455818u ^ 1761901619u);
					continue;
				case 1u:
					return;
				case 3u:
					goto IL_51;
				case 4u:
					goto IL_AD;
				case 5u:
					this.Seconds = other.Seconds;
					arg_76_0 = (num * 698656165u ^ 3033618027u);
					continue;
				case 6u:
					arg_76_0 = ((other.Nanos != 0) ? 3183702140u : 3095319611u);
					continue;
				}
				break;
			}
			return;
			IL_51:
			arg_76_0 = 3178366053u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.Seconds == 0L) ? 2970826122u : 2728581061u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_103:
				uint num;
				uint arg_BF_0 = ((num = input.ReadTag()) != 0u) ? 2033728869u : 1229172373u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BF_0 ^ 1103088744u)) % 10u)
					{
					case 0u:
						this.Nanos = input.ReadInt32();
						arg_BF_0 = 1128464945u;
						continue;
					case 2u:
						arg_BF_0 = (((num == 16u) ? 3747183322u : 4214757864u) ^ num2 * 3309133003u);
						continue;
					case 3u:
						arg_BF_0 = (num2 * 1925888860u ^ 1258598285u);
						continue;
					case 4u:
						input.SkipLastField();
						arg_BF_0 = (num2 * 3338416488u ^ 608443663u);
						continue;
					case 5u:
						arg_BF_0 = ((num == 8u) ? 534398182u : 10231084u);
						continue;
					case 6u:
						arg_BF_0 = 2033728869u;
						continue;
					case 7u:
						arg_BF_0 = (num2 * 3311575051u ^ 168001020u);
						continue;
					case 8u:
						this.Seconds = input.ReadInt64();
						arg_BF_0 = 186302785u;
						continue;
					case 9u:
						goto IL_103;
					}
					return;
				}
			}
		}

		public TimeSpan ToTimeSpan()
		{
			return TimeSpan.FromTicks(checked(this.Seconds * 10000000L + unchecked((long)(this.Nanos / 100))));
		}

		public static Duration FromTimeSpan(TimeSpan timeSpan)
		{
			long expr_07 = timeSpan.Ticks;
			long seconds = expr_07 / 10000000L;
			int nanos = checked((int)(expr_07 % 10000000L) * 100);
			return new Duration
			{
				Seconds = seconds,
				Nanos = nanos
			};
		}

		public static Duration operator -(Duration value)
		{
			Preconditions.CheckNotNull<Duration>(value, Module.smethod_36<string>(1095253436u));
			return checked(Duration.Normalize(0L - value.Seconds, 0 - value.Nanos));
		}

		public static Duration operator +(Duration lhs, Duration rhs)
		{
			Preconditions.CheckNotNull<Duration>(lhs, Module.smethod_37<string>(609340966u));
			Preconditions.CheckNotNull<Duration>(rhs, Module.smethod_33<string>(3930884737u));
			return checked(Duration.Normalize(lhs.Seconds + rhs.Seconds, lhs.Nanos + rhs.Nanos));
		}

		public static Duration operator -(Duration lhs, Duration rhs)
		{
			Preconditions.CheckNotNull<Duration>(lhs, Module.smethod_33<string>(287819511u));
			Preconditions.CheckNotNull<Duration>(rhs, Module.smethod_37<string>(1339777180u));
			return checked(Duration.Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
		}

		internal static Duration Normalize(long seconds, int nanoseconds)
		{
			int num = nanoseconds / 1000000000;
			seconds += (long)num;
			while (true)
			{
				IL_150:
				uint arg_11F_0 = 2478481759u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_11F_0 ^ 3818056266u)) % 9u)
					{
					case 0u:
						seconds += 1L;
						arg_11F_0 = (num2 * 1055736548u ^ 2346364461u);
						continue;
					case 2u:
						nanoseconds -= num * 1000000000;
						arg_11F_0 = (((seconds >= 0L) ? 3094736784u : 2654501620u) ^ num2 * 1375927109u);
						continue;
					case 3u:
						arg_11F_0 = (((nanoseconds < 0) ? 974085794u : 1116137840u) ^ num2 * 303522645u);
						continue;
					case 4u:
						arg_11F_0 = ((seconds <= 0L) ? 2706682594u : 4161403648u);
						continue;
					case 5u:
						nanoseconds -= 1000000000;
						arg_11F_0 = (num2 * 1553824198u ^ 1656070296u);
						continue;
					case 6u:
						seconds -= 1L;
						nanoseconds += 1000000000;
						arg_11F_0 = (num2 * 3589620177u ^ 965135992u);
						continue;
					case 7u:
						goto IL_150;
					case 8u:
						arg_11F_0 = (((nanoseconds <= 0) ? 1597989633u : 1070954060u) ^ num2 * 2479947144u);
						continue;
					}
					goto Block_5;
				}
			}
			Block_5:
			return new Duration
			{
				Seconds = seconds,
				Nanos = nanoseconds
			};
		}
	}
}
