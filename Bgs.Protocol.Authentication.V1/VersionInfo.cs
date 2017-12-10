using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class VersionInfo : IMessage<VersionInfo>, IEquatable<VersionInfo>, IDeepCloneable<VersionInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly VersionInfo.__c __9 = new VersionInfo.__c();

			internal VersionInfo cctor>b__39_0()
			{
				return new VersionInfo();
			}
		}

		private static readonly MessageParser<VersionInfo> _parser = new MessageParser<VersionInfo>(new Func<VersionInfo>(VersionInfo.__c.__9.<.cctor>b__39_0));

		public const int NumberFieldNumber = 1;

		private uint number_;

		public const int PatchFieldNumber = 2;

		private string patch_ = "";

		public const int IsOptionalFieldNumber = 3;

		private bool isOptional_;

		public const int KickTimeFieldNumber = 4;

		private ulong kickTime_;

		public static MessageParser<VersionInfo> Parser
		{
			get
			{
				return VersionInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VersionInfo.Descriptor;
			}
		}

		public uint Number
		{
			get
			{
				return this.number_;
			}
			set
			{
				this.number_ = value;
			}
		}

		public string Patch
		{
			get
			{
				return this.patch_;
			}
			set
			{
				this.patch_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public bool IsOptional
		{
			get
			{
				return this.isOptional_;
			}
			set
			{
				this.isOptional_ = value;
			}
		}

		public ulong KickTime
		{
			get
			{
				return this.kickTime_;
			}
			set
			{
				this.kickTime_ = value;
			}
		}

		public VersionInfo()
		{
		}

		public VersionInfo(VersionInfo other) : this()
		{
			while (true)
			{
				IL_9E:
				uint arg_7A_0 = 1364059622u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7A_0 ^ 1327362760u)) % 6u)
					{
					case 0u:
						goto IL_9E;
					case 1u:
						this.isOptional_ = other.isOptional_;
						arg_7A_0 = (num * 2418261567u ^ 3888371340u);
						continue;
					case 2u:
						this.number_ = other.number_;
						arg_7A_0 = (num * 3415483345u ^ 3566500437u);
						continue;
					case 3u:
						this.kickTime_ = other.kickTime_;
						arg_7A_0 = (num * 932547801u ^ 3362522313u);
						continue;
					case 5u:
						this.patch_ = other.patch_;
						arg_7A_0 = (num * 881095152u ^ 3422057807u);
						continue;
					}
					return;
				}
			}
		}

		public VersionInfo Clone()
		{
			return new VersionInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as VersionInfo);
		}

		public bool Equals(VersionInfo other)
		{
			if (other == null)
			{
				goto IL_6B;
			}
			goto IL_111;
			int arg_C3_0;
			while (true)
			{
				IL_BE:
				switch ((arg_C3_0 ^ 947650556) % 13)
				{
				case 1:
					return false;
				case 2:
					arg_C3_0 = ((this.IsOptional != other.IsOptional) ? 1647336774 : 1144041013);
					continue;
				case 3:
					return true;
				case 4:
					goto IL_111;
				case 5:
					arg_C3_0 = ((this.KickTime != other.KickTime) ? 334836107 : 342410010);
					continue;
				case 6:
					goto IL_6B;
				case 7:
					return false;
				case 8:
					arg_C3_0 = (VersionInfo.smethod_0(this.Patch, other.Patch) ? 1686937314 : 1190062709);
					continue;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					arg_C3_0 = ((this.Number != other.Number) ? 241013337 : 1876322420);
					continue;
				}
				break;
			}
			return true;
			IL_6B:
			arg_C3_0 = 292268578;
			goto IL_BE;
			IL_111:
			arg_C3_0 = ((other != this) ? 447886459 : 1455068748);
			goto IL_BE;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_15F:
				uint arg_129_0 = 2725894527u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_129_0 ^ 2988652462u)) % 10u)
					{
					case 0u:
						goto IL_15F;
					case 2u:
						num ^= this.IsOptional.GetHashCode();
						arg_129_0 = (num2 * 3591961589u ^ 791132461u);
						continue;
					case 3u:
						arg_129_0 = (((this.Number == 0u) ? 3808273424u : 2615000015u) ^ num2 * 726473389u);
						continue;
					case 4u:
						num ^= this.KickTime.GetHashCode();
						arg_129_0 = (num2 * 195102209u ^ 2176681211u);
						continue;
					case 5u:
						arg_129_0 = ((this.KickTime == 0uL) ? 3014127981u : 2637809208u);
						continue;
					case 6u:
						num ^= this.Number.GetHashCode();
						arg_129_0 = (num2 * 2677439645u ^ 3942779969u);
						continue;
					case 7u:
						arg_129_0 = (this.IsOptional ? 2418543502u : 3566490509u);
						continue;
					case 8u:
						num ^= this.Patch.GetHashCode();
						arg_129_0 = (num2 * 2861384989u ^ 637890399u);
						continue;
					case 9u:
						arg_129_0 = ((this.Patch.Length != 0) ? 4010344336u : 4145089113u);
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
			if (this.Number != 0u)
			{
				goto IL_67;
			}
			goto IL_166;
			uint arg_11E_0;
			while (true)
			{
				IL_119:
				uint num;
				switch ((num = (arg_11E_0 ^ 2793204480u)) % 11u)
				{
				case 0u:
					arg_11E_0 = ((!this.IsOptional) ? 4018151038u : 3033451932u);
					continue;
				case 1u:
					output.WriteRawTag(8);
					output.WriteUInt32(this.Number);
					arg_11E_0 = (num * 2598864537u ^ 670734575u);
					continue;
				case 2u:
					output.WriteBool(this.IsOptional);
					arg_11E_0 = (num * 149519311u ^ 4192727042u);
					continue;
				case 3u:
					output.WriteRawTag(32);
					arg_11E_0 = (num * 349717085u ^ 350822542u);
					continue;
				case 4u:
					output.WriteRawTag(24);
					arg_11E_0 = (num * 1947097179u ^ 1459629744u);
					continue;
				case 5u:
					output.WriteUInt64(this.KickTime);
					arg_11E_0 = (num * 2323908088u ^ 579814074u);
					continue;
				case 6u:
					goto IL_67;
				case 7u:
					arg_11E_0 = ((this.KickTime != 0uL) ? 2781745508u : 2204118922u);
					continue;
				case 9u:
					goto IL_166;
				case 10u:
					output.WriteRawTag(18);
					output.WriteString(this.Patch);
					arg_11E_0 = (num * 3132364488u ^ 973117414u);
					continue;
				}
				break;
			}
			return;
			IL_67:
			arg_11E_0 = 3370787593u;
			goto IL_119;
			IL_166:
			arg_11E_0 = ((VersionInfo.smethod_1(this.Patch) == 0) ? 2590781990u : 2558540920u);
			goto IL_119;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Number != 0u)
			{
				goto IL_A5;
			}
			goto IL_121;
			uint arg_E1_0;
			while (true)
			{
				IL_DC:
				uint num2;
				switch ((num2 = (arg_E1_0 ^ 3173006169u)) % 9u)
				{
				case 0u:
					num += 2;
					arg_E1_0 = (num2 * 1276926376u ^ 1019983233u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Number);
					arg_E1_0 = (num2 * 432604733u ^ 1147630583u);
					continue;
				case 2u:
					goto IL_A5;
				case 3u:
					goto IL_121;
				case 4u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.Patch);
					arg_E1_0 = (num2 * 3846567858u ^ 619180344u);
					continue;
				case 5u:
					arg_E1_0 = ((this.KickTime == 0uL) ? 2618721213u : 3667209930u);
					continue;
				case 6u:
					arg_E1_0 = (this.IsOptional ? 4272053065u : 3732877057u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.KickTime);
					arg_E1_0 = (num2 * 703044044u ^ 2093059993u);
					continue;
				}
				break;
			}
			return num;
			IL_A5:
			arg_E1_0 = 4181186983u;
			goto IL_DC;
			IL_121:
			arg_E1_0 = ((VersionInfo.smethod_1(this.Patch) == 0) ? 3998983444u : 2518892639u);
			goto IL_DC;
		}

		public void MergeFrom(VersionInfo other)
		{
			if (other == null)
			{
				goto IL_78;
			}
			goto IL_147;
			uint arg_FF_0;
			while (true)
			{
				IL_FA:
				uint num;
				switch ((num = (arg_FF_0 ^ 2213373195u)) % 11u)
				{
				case 0u:
					this.Number = other.Number;
					arg_FF_0 = (num * 354893173u ^ 1573609952u);
					continue;
				case 2u:
					this.KickTime = other.KickTime;
					arg_FF_0 = (num * 2592170375u ^ 96191666u);
					continue;
				case 3u:
					arg_FF_0 = (other.IsOptional ? 2435340847u : 3157613251u);
					continue;
				case 4u:
					arg_FF_0 = ((VersionInfo.smethod_1(other.Patch) == 0) ? 2469043940u : 3785702229u);
					continue;
				case 5u:
					goto IL_78;
				case 6u:
					goto IL_147;
				case 7u:
					this.Patch = other.Patch;
					arg_FF_0 = (num * 2531104312u ^ 3782157940u);
					continue;
				case 8u:
					arg_FF_0 = ((other.KickTime != 0uL) ? 2463457192u : 4172966471u);
					continue;
				case 9u:
					this.IsOptional = other.IsOptional;
					arg_FF_0 = (num * 3312379157u ^ 1830042423u);
					continue;
				case 10u:
					return;
				}
				break;
			}
			return;
			IL_78:
			arg_FF_0 = 3445962367u;
			goto IL_FA;
			IL_147:
			arg_FF_0 = ((other.Number != 0u) ? 4291572852u : 3711296491u);
			goto IL_FA;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1CA:
				uint num;
				uint arg_16E_0 = ((num = input.ReadTag()) == 0u) ? 2226538663u : 2298826256u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_16E_0 ^ 2882684379u)) % 16u)
					{
					case 0u:
						this.Number = input.ReadUInt32();
						arg_16E_0 = 2957220115u;
						continue;
					case 1u:
						arg_16E_0 = (((num != 8u) ? 3378391704u : 3623365090u) ^ num2 * 3219491737u);
						continue;
					case 2u:
						arg_16E_0 = (((num == 32u) ? 663441937u : 1358222379u) ^ num2 * 3764751535u);
						continue;
					case 3u:
						this.IsOptional = input.ReadBool();
						arg_16E_0 = 2382688146u;
						continue;
					case 4u:
						this.KickTime = input.ReadUInt64();
						arg_16E_0 = 2382688146u;
						continue;
					case 5u:
						this.Patch = input.ReadString();
						arg_16E_0 = 2643703469u;
						continue;
					case 6u:
						arg_16E_0 = (num2 * 1860288561u ^ 166393348u);
						continue;
					case 7u:
						arg_16E_0 = (num2 * 2660228181u ^ 657254534u);
						continue;
					case 8u:
						arg_16E_0 = (num2 * 2256099300u ^ 2759620018u);
						continue;
					case 9u:
						goto IL_1CA;
					case 10u:
						arg_16E_0 = (((num != 18u) ? 704355562u : 1876631976u) ^ num2 * 3641181159u);
						continue;
					case 11u:
						arg_16E_0 = ((num <= 18u) ? 3447499834u : 3885078758u);
						continue;
					case 13u:
						arg_16E_0 = ((num == 24u) ? 3232369784u : 3164750617u);
						continue;
					case 14u:
						input.SkipLastField();
						arg_16E_0 = 2382688146u;
						continue;
					case 15u:
						arg_16E_0 = 2298826256u;
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
