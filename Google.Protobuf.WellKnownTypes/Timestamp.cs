using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Timestamp : IMessage<Timestamp>, IEquatable<Timestamp>, IDeepCloneable<Timestamp>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Timestamp.__c __9 = new Timestamp.__c();

			internal Timestamp cctor>b__41_0()
			{
				return new Timestamp();
			}
		}

		private static readonly MessageParser<Timestamp> _parser = new MessageParser<Timestamp>(new Func<Timestamp>(Timestamp.__c.__9.<.cctor>b__41_0));

		public const int SecondsFieldNumber = 1;

		private long seconds_;

		public const int NanosFieldNumber = 2;

		private int nanos_;

		private static readonly DateTime UnixEpoch;

		private static readonly long BclSecondsAtUnixEpoch;

		internal static readonly long UnixSecondsAtBclMinValue;

		internal static readonly long UnixSecondsAtBclMaxValue;

		public static MessageParser<Timestamp> Parser
		{
			get
			{
				return Timestamp._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return TimestampReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Timestamp.Descriptor;
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

		public Timestamp()
		{
		}

		public Timestamp(Timestamp other) : this()
		{
			this.seconds_ = other.seconds_;
			this.nanos_ = other.nanos_;
		}

		public Timestamp Clone()
		{
			return new Timestamp(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Timestamp);
		}

		public bool Equals(Timestamp other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_AB;
			int arg_6D_0;
			while (true)
			{
				IL_68:
				switch ((arg_6D_0 ^ -1105935621) % 9)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 3:
					arg_6D_0 = ((this.Seconds == other.Seconds) ? -1599928251 : -256015206);
					continue;
				case 4:
					return true;
				case 5:
					arg_6D_0 = ((this.Nanos != other.Nanos) ? -789486440 : -318907503);
					continue;
				case 6:
					goto IL_15;
				case 7:
					goto IL_AB;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_6D_0 = -149202933;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other != this) ? -112188169 : -2070322413);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Seconds != 0L)
			{
				goto IL_1C;
			}
			goto IL_92;
			uint arg_66_0;
			while (true)
			{
				IL_61:
				uint num2;
				switch ((num2 = (arg_66_0 ^ 4209271202u)) % 5u)
				{
				case 0u:
					num ^= this.Nanos.GetHashCode();
					arg_66_0 = (num2 * 1612087655u ^ 3586496705u);
					continue;
				case 2u:
					num ^= this.Seconds.GetHashCode();
					arg_66_0 = (num2 * 3227999504u ^ 3032321690u);
					continue;
				case 3u:
					goto IL_1C;
				case 4u:
					goto IL_92;
				}
				break;
			}
			return num;
			IL_1C:
			arg_66_0 = 3191810418u;
			goto IL_61;
			IL_92:
			arg_66_0 = ((this.Nanos == 0) ? 2945756888u : 3331210717u);
			goto IL_61;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Seconds != 0L)
			{
				goto IL_3C;
			}
			goto IL_AB;
			uint arg_78_0;
			while (true)
			{
				IL_73:
				uint num;
				switch ((num = (arg_78_0 ^ 3331514368u)) % 6u)
				{
				case 0u:
					output.WriteRawTag(16);
					arg_78_0 = (num * 488847302u ^ 2310371461u);
					continue;
				case 1u:
					output.WriteInt32(this.Nanos);
					arg_78_0 = (num * 1790572481u ^ 1055528423u);
					continue;
				case 3u:
					goto IL_3C;
				case 4u:
					goto IL_AB;
				case 5u:
					output.WriteRawTag(8);
					output.WriteInt64(this.Seconds);
					arg_78_0 = (num * 2062721162u ^ 3815613788u);
					continue;
				}
				break;
			}
			return;
			IL_3C:
			arg_78_0 = 2542253343u;
			goto IL_73;
			IL_AB:
			arg_78_0 = ((this.Nanos != 0) ? 2704264906u : 3550514590u);
			goto IL_73;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 2306621565u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 2267353836u)) % 6u)
					{
					case 0u:
						goto IL_B6;
					case 2u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Nanos);
						arg_92_0 = (num2 * 2628540604u ^ 596052875u);
						continue;
					case 3u:
						arg_92_0 = (((this.Seconds == 0L) ? 1456134848u : 654942607u) ^ num2 * 841381087u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeInt64Size(this.Seconds);
						arg_92_0 = (num2 * 1622232830u ^ 2789611303u);
						continue;
					case 5u:
						arg_92_0 = ((this.Nanos == 0) ? 4170189787u : 2798650048u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Timestamp other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 437624264u)) % 7u)
				{
				case 0u:
					arg_76_0 = ((other.Nanos == 0) ? 96772549u : 548634700u);
					continue;
				case 1u:
					this.Nanos = other.Nanos;
					arg_76_0 = (num * 3552550232u ^ 3748968613u);
					continue;
				case 3u:
					this.Seconds = other.Seconds;
					arg_76_0 = (num * 1276971452u ^ 3373765809u);
					continue;
				case 4u:
					goto IL_15;
				case 5u:
					return;
				case 6u:
					goto IL_AD;
				}
				break;
			}
			return;
			IL_15:
			arg_76_0 = 517709175u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.Seconds == 0L) ? 979099609u : 2022457870u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_106:
				uint num;
				uint arg_C2_0 = ((num = input.ReadTag()) != 0u) ? 2888686981u : 2761910801u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C2_0 ^ 4029492457u)) % 10u)
					{
					case 1u:
						arg_C2_0 = (num2 * 3553691144u ^ 2487151499u);
						continue;
					case 2u:
						arg_C2_0 = (((num == 16u) ? 2371306162u : 2168529145u) ^ num2 * 1595294522u);
						continue;
					case 3u:
						arg_C2_0 = (num2 * 4042333155u ^ 3443394352u);
						continue;
					case 4u:
						goto IL_106;
					case 5u:
						this.Nanos = input.ReadInt32();
						arg_C2_0 = 3108242179u;
						continue;
					case 6u:
						arg_C2_0 = ((num != 8u) ? 3685197319u : 3833938444u);
						continue;
					case 7u:
						this.Seconds = input.ReadInt64();
						arg_C2_0 = 3924143000u;
						continue;
					case 8u:
						input.SkipLastField();
						arg_C2_0 = (num2 * 2144122492u ^ 3186870952u);
						continue;
					case 9u:
						arg_C2_0 = 2888686981u;
						continue;
					}
					return;
				}
			}
		}

		public static Duration operator -(Timestamp lhs, Timestamp rhs)
		{
			Preconditions.CheckNotNull<Timestamp>(lhs, Module.smethod_35<string>(1863472618u));
			Preconditions.CheckNotNull<Timestamp>(rhs, Module.smethod_33<string>(3930884737u));
			return checked(Duration.Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
		}

		public static Timestamp operator +(Timestamp lhs, Duration rhs)
		{
			Preconditions.CheckNotNull<Timestamp>(lhs, Module.smethod_36<string>(4262632730u));
			while (true)
			{
				IL_4E:
				uint arg_36_0 = 2548782806u;
				while (true)
				{
					uint num;
					switch ((num = (arg_36_0 ^ 3573228391u)) % 3u)
					{
					case 0u:
						goto IL_4E;
					case 2u:
						Preconditions.CheckNotNull<Duration>(rhs, Module.smethod_36<string>(992200600u));
						arg_36_0 = (num * 3929087969u ^ 2970693231u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return checked(Timestamp.Normalize(lhs.Seconds + rhs.Seconds, lhs.Nanos + rhs.Nanos));
		}

		public static Timestamp operator -(Timestamp lhs, Duration rhs)
		{
			Preconditions.CheckNotNull<Timestamp>(lhs, Module.smethod_35<string>(1863472618u));
			Preconditions.CheckNotNull<Duration>(rhs, Module.smethod_35<string>(1080031352u));
			return checked(Timestamp.Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
		}

		public DateTime ToDateTime()
		{
			DateTime dateTime = Timestamp.UnixEpoch;
			while (true)
			{
				IL_41:
				uint arg_29_0 = 3434036289u;
				while (true)
				{
					uint num;
					switch ((num = (arg_29_0 ^ 2901336283u)) % 3u)
					{
					case 1u:
						dateTime = dateTime.AddSeconds((double)this.Seconds);
						arg_29_0 = (num * 4144795151u ^ 3942889573u);
						continue;
					case 2u:
						goto IL_41;
					}
					goto Block_1;
				}
			}
			Block_1:
			return dateTime.AddTicks((long)(this.Nanos / 100));
		}

		public DateTimeOffset ToDateTimeOffset()
		{
			return new DateTimeOffset(this.ToDateTime(), TimeSpan.Zero);
		}

		public static Timestamp FromDateTime(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				goto IL_2E;
			}
			IL_0A:
			int arg_14_0 = -675111661;
			IL_0F:
			long num;
			int nanos;
			switch ((arg_14_0 ^ -417967718) % 4)
			{
			case 0:
				IL_2E:
				num = dateTime.Ticks / 10000000L;
				nanos = (int)(dateTime.Ticks % 10000000L) * 100;
				arg_14_0 = -1623257116;
				goto IL_0F;
			case 1:
				throw new ArgumentException(Module.smethod_34<string>(3248912248u), Module.smethod_37<string>(3238811135u));
			case 3:
				goto IL_0A;
			}
			return new Timestamp
			{
				Seconds = num - Timestamp.BclSecondsAtUnixEpoch,
				Nanos = nanos
			};
		}

		public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset)
		{
			return Timestamp.FromDateTime(dateTimeOffset.UtcDateTime);
		}

		internal static Timestamp Normalize(long seconds, int nanoseconds)
		{
			int num = nanoseconds / 1000000000;
			while (true)
			{
				IL_84:
				uint arg_68_0 = 1070302856u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 1496102549u)) % 4u)
					{
					case 0u:
						goto IL_84;
					case 1u:
						seconds += (long)num;
						nanoseconds -= num * 1000000000;
						arg_68_0 = (((nanoseconds < 0) ? 3041678510u : 2446566947u) ^ num2 * 1027905645u);
						continue;
					case 2u:
						nanoseconds += 1000000000;
						seconds -= 1L;
						arg_68_0 = (num2 * 2586930818u ^ 2748640190u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			return new Timestamp
			{
				Seconds = seconds,
				Nanos = nanoseconds
			};
		}

		static Timestamp()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_B7:
				uint arg_9B_0 = 1608512577u;
				while (true)
				{
					uint num;
					switch ((num = (arg_9B_0 ^ 451714620u)) % 4u)
					{
					case 1u:
						Timestamp.UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
						Timestamp.BclSecondsAtUnixEpoch = Timestamp.UnixEpoch.Ticks / 10000000L;
						arg_9B_0 = (num * 2101686026u ^ 3060946912u);
						continue;
					case 2u:
						Timestamp.UnixSecondsAtBclMinValue = -Timestamp.BclSecondsAtUnixEpoch;
						Timestamp.UnixSecondsAtBclMaxValue = DateTime.MaxValue.Ticks / 10000000L - Timestamp.BclSecondsAtUnixEpoch;
						arg_9B_0 = (num * 2213172070u ^ 2058793308u);
						continue;
					case 3u:
						goto IL_B7;
					}
					return;
				}
			}
		}
	}
}
