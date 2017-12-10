using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class ProgramTag : IMessage<ProgramTag>, IEquatable<ProgramTag>, IDeepCloneable<ProgramTag>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ProgramTag.__c __9 = new ProgramTag.__c();

			internal ProgramTag cctor>b__29_0()
			{
				return new ProgramTag();
			}
		}

		private static readonly MessageParser<ProgramTag> _parser = new MessageParser<ProgramTag>(new Func<ProgramTag>(ProgramTag.__c.__9.<.cctor>b__29_0));

		public const int ProgramFieldNumber = 1;

		private uint program_;

		public const int TagFieldNumber = 2;

		private uint tag_;

		public static MessageParser<ProgramTag> Parser
		{
			get
			{
				return ProgramTag._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgramTag.Descriptor;
			}
		}

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public uint Tag
		{
			get
			{
				return this.tag_;
			}
			set
			{
				this.tag_ = value;
			}
		}

		public ProgramTag()
		{
		}

		public ProgramTag(ProgramTag other) : this()
		{
			this.program_ = other.program_;
			this.tag_ = other.tag_;
		}

		public ProgramTag Clone()
		{
			return new ProgramTag(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ProgramTag);
		}

		public bool Equals(ProgramTag other)
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
				switch ((arg_6D_0 ^ -85915909) % 9)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_6D_0 = ((this.Tag != other.Tag) ? -169873818 : -609886302);
					continue;
				case 3:
					arg_6D_0 = ((this.Program != other.Program) ? -1606445536 : -1996343049);
					continue;
				case 4:
					return false;
				case 5:
					goto IL_AB;
				case 6:
					return true;
				case 7:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_6D_0 = -664128261;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other == this) ? -1344875209 : -420741222);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Program != 0u)
			{
				goto IL_5C;
			}
			goto IL_92;
			uint arg_66_0;
			while (true)
			{
				IL_61:
				uint num2;
				switch ((num2 = (arg_66_0 ^ 2150241310u)) % 5u)
				{
				case 0u:
					goto IL_5C;
				case 2u:
					num ^= this.Program.GetHashCode();
					arg_66_0 = (num2 * 1691252235u ^ 1696787676u);
					continue;
				case 3u:
					num ^= this.Tag.GetHashCode();
					arg_66_0 = (num2 * 3896796313u ^ 1845315858u);
					continue;
				case 4u:
					goto IL_92;
				}
				break;
			}
			return num;
			IL_5C:
			arg_66_0 = 2342576607u;
			goto IL_61;
			IL_92:
			arg_66_0 = ((this.Tag == 0u) ? 2451890172u : 2355970304u);
			goto IL_61;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Program != 0u)
			{
				goto IL_6F;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 4284759364u)) % 6u)
				{
				case 0u:
					goto IL_6F;
				case 1u:
					output.WriteRawTag(21);
					arg_79_0 = (num * 1992263865u ^ 1743149150u);
					continue;
				case 2u:
					output.WriteRawTag(13);
					output.WriteFixed32(this.Program);
					arg_79_0 = (num * 2907452528u ^ 2173175318u);
					continue;
				case 4u:
					goto IL_AC;
				case 5u:
					output.WriteFixed32(this.Tag);
					arg_79_0 = (num * 3614088906u ^ 2853858431u);
					continue;
				}
				break;
			}
			return;
			IL_6F:
			arg_79_0 = 2368588328u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.Tag == 0u) ? 3969412521u : 2976056953u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_9E:
				uint arg_7A_0 = 3586728690u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_7A_0 ^ 3978313457u)) % 6u)
					{
					case 0u:
						goto IL_9E;
					case 1u:
						num += 5;
						arg_7A_0 = (num2 * 3201902140u ^ 4191804935u);
						continue;
					case 3u:
						num += 5;
						arg_7A_0 = (num2 * 4247269375u ^ 4179181994u);
						continue;
					case 4u:
						arg_7A_0 = ((this.Tag != 0u) ? 2832067478u : 4267937827u);
						continue;
					case 5u:
						arg_7A_0 = (((this.Program != 0u) ? 442388859u : 76415454u) ^ num2 * 1060008839u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ProgramTag other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 4216252301u)) % 7u)
				{
				case 0u:
					goto IL_6C;
				case 1u:
					this.Tag = other.Tag;
					arg_76_0 = (num * 2348777924u ^ 792538497u);
					continue;
				case 3u:
					goto IL_AD;
				case 4u:
					this.Program = other.Program;
					arg_76_0 = (num * 2337946798u ^ 1957974584u);
					continue;
				case 5u:
					return;
				case 6u:
					arg_76_0 = ((other.Tag == 0u) ? 4182480101u : 4259989476u);
					continue;
				}
				break;
			}
			return;
			IL_6C:
			arg_76_0 = 3373960532u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.Program == 0u) ? 3193377898u : 2238561778u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_107:
				uint num;
				uint arg_C3_0 = ((num = input.ReadTag()) == 0u) ? 3117218342u : 2255363733u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_C3_0 ^ 2929144104u)) % 10u)
					{
					case 0u:
						this.Tag = input.ReadFixed32();
						arg_C3_0 = 3942569147u;
						continue;
					case 1u:
						arg_C3_0 = (num2 * 337833901u ^ 875229112u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_C3_0 = (num2 * 3084353214u ^ 557774423u);
						continue;
					case 3u:
						arg_C3_0 = (num2 * 1238454162u ^ 1502476157u);
						continue;
					case 4u:
						arg_C3_0 = (((num != 21u) ? 3300005478u : 3868662926u) ^ num2 * 3081583210u);
						continue;
					case 5u:
						arg_C3_0 = ((num == 13u) ? 2399725904u : 3294526732u);
						continue;
					case 7u:
						arg_C3_0 = 2255363733u;
						continue;
					case 8u:
						this.Program = input.ReadFixed32();
						arg_C3_0 = 2234669639u;
						continue;
					case 9u:
						goto IL_107;
					}
					return;
				}
			}
		}
	}
}
