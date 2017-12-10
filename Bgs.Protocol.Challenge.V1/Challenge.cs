using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class Challenge : IMessage<Challenge>, IEquatable<Challenge>, IDeepCloneable<Challenge>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Challenge.__c __9 = new Challenge.__c();

			internal Challenge cctor>b__39_0()
			{
				return new Challenge();
			}
		}

		private static readonly MessageParser<Challenge> _parser = new MessageParser<Challenge>(new Func<Challenge>(Challenge.__c.__9.<.cctor>b__39_0));

		public const int TypeFieldNumber = 1;

		private uint type_;

		public const int InfoFieldNumber = 2;

		private string info_ = "";

		public const int AnswerFieldNumber = 3;

		private string answer_ = "";

		public const int RetriesFieldNumber = 4;

		private uint retries_;

		public static MessageParser<Challenge> Parser
		{
			get
			{
				return Challenge._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Challenge.Descriptor;
			}
		}

		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		public string Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public string Answer
		{
			get
			{
				return this.answer_;
			}
			set
			{
				this.answer_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public uint Retries
		{
			get
			{
				return this.retries_;
			}
			set
			{
				this.retries_ = value;
			}
		}

		public Challenge()
		{
		}

		public Challenge(Challenge other) : this()
		{
			while (true)
			{
				IL_9E:
				uint arg_7A_0 = 905175719u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7A_0 ^ 1563902102u)) % 6u)
					{
					case 0u:
						this.retries_ = other.retries_;
						arg_7A_0 = (num * 472093204u ^ 3939865869u);
						continue;
					case 1u:
						this.type_ = other.type_;
						arg_7A_0 = (num * 801638375u ^ 3662830945u);
						continue;
					case 2u:
						this.info_ = other.info_;
						arg_7A_0 = (num * 3843288302u ^ 4156245234u);
						continue;
					case 4u:
						this.answer_ = other.answer_;
						arg_7A_0 = (num * 687102239u ^ 3076275314u);
						continue;
					case 5u:
						goto IL_9E;
					}
					return;
				}
			}
		}

		public Challenge Clone()
		{
			return new Challenge(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Challenge);
		}

		public bool Equals(Challenge other)
		{
			if (other == null)
			{
				goto IL_42;
			}
			goto IL_119;
			int arg_CB_0;
			while (true)
			{
				IL_C6:
				switch ((arg_CB_0 ^ -1675455976) % 13)
				{
				case 0:
					arg_CB_0 = ((this.Retries == other.Retries) ? -1690733428 : -866040315);
					continue;
				case 1:
					return false;
				case 2:
					goto IL_119;
				case 3:
					return false;
				case 4:
					arg_CB_0 = ((!Challenge.smethod_0(this.Answer, other.Answer)) ? -1146425575 : -1820917743);
					continue;
				case 6:
					return true;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					arg_CB_0 = (Challenge.smethod_0(this.Info, other.Info) ? -1630173037 : -1309947702);
					continue;
				case 10:
					goto IL_42;
				case 11:
					return false;
				case 12:
					arg_CB_0 = ((this.Type != other.Type) ? -1440909631 : -1380756587);
					continue;
				}
				break;
			}
			return true;
			IL_42:
			arg_CB_0 = -98337878;
			goto IL_C6;
			IL_119:
			arg_CB_0 = ((other == this) ? -567449474 : -1376668207);
			goto IL_C6;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_119:
				uint arg_ED_0 = 450068637u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_ED_0 ^ 547790272u)) % 8u)
					{
					case 0u:
						num ^= this.Answer.GetHashCode();
						arg_ED_0 = (num2 * 2276955974u ^ 4048944654u);
						continue;
					case 1u:
						arg_ED_0 = ((this.Answer.Length != 0) ? 1455013200u : 787622254u);
						continue;
					case 2u:
						num ^= this.Info.GetHashCode();
						arg_ED_0 = (num2 * 554577516u ^ 3698992849u);
						continue;
					case 3u:
						num ^= this.Retries.GetHashCode();
						arg_ED_0 = (num2 * 3286601492u ^ 4183716576u);
						continue;
					case 5u:
						num ^= this.Type.GetHashCode();
						arg_ED_0 = (((this.Info.Length == 0) ? 2437328491u : 3990832112u) ^ num2 * 45289354u);
						continue;
					case 6u:
						arg_ED_0 = ((this.Retries == 0u) ? 864683548u : 420381939u);
						continue;
					case 7u:
						goto IL_119;
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
			output.WriteRawTag(13);
			output.WriteFixed32(this.Type);
			if (Challenge.smethod_1(this.Info) != 0)
			{
				goto IL_36;
			}
			goto IL_12E;
			uint arg_EE_0;
			while (true)
			{
				IL_E9:
				uint num;
				switch ((num = (arg_EE_0 ^ 4111191043u)) % 9u)
				{
				case 0u:
					arg_EE_0 = ((this.Retries == 0u) ? 2735922105u : 3844168837u);
					continue;
				case 1u:
					output.WriteString(this.Info);
					arg_EE_0 = (num * 805652000u ^ 2130626979u);
					continue;
				case 2u:
					output.WriteRawTag(18);
					arg_EE_0 = (num * 2046745914u ^ 1140229615u);
					continue;
				case 3u:
					output.WriteRawTag(32);
					arg_EE_0 = (num * 2541211503u ^ 1953492169u);
					continue;
				case 4u:
					output.WriteUInt32(this.Retries);
					arg_EE_0 = (num * 2733493127u ^ 710902281u);
					continue;
				case 5u:
					output.WriteRawTag(26);
					output.WriteString(this.Answer);
					arg_EE_0 = (num * 4153763114u ^ 451432512u);
					continue;
				case 6u:
					goto IL_36;
				case 7u:
					goto IL_12E;
				}
				break;
			}
			return;
			IL_36:
			arg_EE_0 = 3276487357u;
			goto IL_E9;
			IL_12E:
			arg_EE_0 = ((Challenge.smethod_1(this.Answer) == 0) ? 2819679088u : 2537892155u);
			goto IL_E9;
		}

		public int CalculateSize()
		{
			int num = 5;
			if (Challenge.smethod_1(this.Info) != 0)
			{
				goto IL_A7;
			}
			goto IL_E8;
			uint arg_B1_0;
			while (true)
			{
				IL_AC:
				uint num2;
				switch ((num2 = (arg_B1_0 ^ 1650604115u)) % 7u)
				{
				case 0u:
					goto IL_A7;
				case 1u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Info);
					arg_B1_0 = (num2 * 3535685119u ^ 609103902u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retries);
					arg_B1_0 = (num2 * 533561051u ^ 2929029727u);
					continue;
				case 3u:
					arg_B1_0 = ((this.Retries == 0u) ? 2085153039u : 947016355u);
					continue;
				case 4u:
					goto IL_E8;
				case 5u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Answer);
					arg_B1_0 = (num2 * 4093125172u ^ 1408280092u);
					continue;
				}
				break;
			}
			return num;
			IL_A7:
			arg_B1_0 = 248825369u;
			goto IL_AC;
			IL_E8:
			arg_B1_0 = ((Challenge.smethod_1(this.Answer) != 0) ? 1613690056u : 1377731424u);
			goto IL_AC;
		}

		public void MergeFrom(Challenge other)
		{
			if (other == null)
			{
				goto IL_C7;
			}
			goto IL_14F;
			uint arg_107_0;
			while (true)
			{
				IL_102:
				uint num;
				switch ((num = (arg_107_0 ^ 1027814355u)) % 11u)
				{
				case 0u:
					this.Type = other.Type;
					arg_107_0 = (num * 4283474406u ^ 1771106757u);
					continue;
				case 1u:
					this.Info = other.Info;
					arg_107_0 = (num * 3061905897u ^ 3479315219u);
					continue;
				case 2u:
					goto IL_C7;
				case 3u:
					arg_107_0 = ((Challenge.smethod_1(other.Answer) == 0) ? 917901759u : 1602427094u);
					continue;
				case 5u:
					return;
				case 6u:
					arg_107_0 = ((other.Retries != 0u) ? 941151980u : 275480317u);
					continue;
				case 7u:
					goto IL_14F;
				case 8u:
					arg_107_0 = ((Challenge.smethod_1(other.Info) != 0) ? 1289079827u : 1850910419u);
					continue;
				case 9u:
					this.Answer = other.Answer;
					arg_107_0 = (num * 1990012044u ^ 2386260739u);
					continue;
				case 10u:
					this.Retries = other.Retries;
					arg_107_0 = (num * 3662567364u ^ 3290338241u);
					continue;
				}
				break;
			}
			return;
			IL_C7:
			arg_107_0 = 1856299412u;
			goto IL_102;
			IL_14F:
			arg_107_0 = ((other.Type != 0u) ? 521836576u : 1664401047u);
			goto IL_102;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1DE:
				uint num;
				uint arg_17E_0 = ((num = input.ReadTag()) != 0u) ? 2501644425u : 2147969630u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_17E_0 ^ 3373022479u)) % 17u)
					{
					case 0u:
						this.Answer = input.ReadString();
						arg_17E_0 = 3696594752u;
						continue;
					case 1u:
						arg_17E_0 = (((num == 32u) ? 4140407217u : 2978665872u) ^ num2 * 2061232237u);
						continue;
					case 2u:
						this.Type = input.ReadFixed32();
						arg_17E_0 = 3868917373u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_17E_0 = 3342081546u;
						continue;
					case 4u:
						arg_17E_0 = ((num != 26u) ? 2179447816u : 2680330212u);
						continue;
					case 5u:
						arg_17E_0 = (num2 * 2288126843u ^ 1171177126u);
						continue;
					case 6u:
						this.Info = input.ReadString();
						arg_17E_0 = 3502139827u;
						continue;
					case 7u:
						arg_17E_0 = (((num != 13u) ? 145375986u : 2122975277u) ^ num2 * 1486374912u);
						continue;
					case 8u:
						arg_17E_0 = (num2 * 3483566139u ^ 2022042714u);
						continue;
					case 9u:
						arg_17E_0 = (((num == 18u) ? 3485832636u : 3673566772u) ^ num2 * 1038292188u);
						continue;
					case 10u:
						arg_17E_0 = (num2 * 1746813491u ^ 3095535040u);
						continue;
					case 11u:
						this.Retries = input.ReadUInt32();
						arg_17E_0 = 3868917373u;
						continue;
					case 12u:
						arg_17E_0 = 2501644425u;
						continue;
					case 13u:
						goto IL_1DE;
					case 15u:
						arg_17E_0 = ((num <= 18u) ? 4018200022u : 3725557977u);
						continue;
					case 16u:
						arg_17E_0 = (num2 * 569868523u ^ 1492072169u);
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
	}
}
