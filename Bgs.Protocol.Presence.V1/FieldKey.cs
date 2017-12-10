using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class FieldKey : IMessage<FieldKey>, IEquatable<FieldKey>, IDeepCloneable<FieldKey>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FieldKey.__c __9 = new FieldKey.__c();

			internal FieldKey cctor>b__39_0()
			{
				return new FieldKey();
			}
		}

		private static readonly MessageParser<FieldKey> _parser = new MessageParser<FieldKey>(new Func<FieldKey>(FieldKey.__c.__9.<.cctor>b__39_0));

		public const int ProgramFieldNumber = 1;

		private uint program_;

		public const int GroupFieldNumber = 2;

		private uint group_;

		public const int FieldFieldNumber = 3;

		private uint field_;

		public const int UniqueIdFieldNumber = 4;

		private ulong uniqueId_;

		public static MessageParser<FieldKey> Parser
		{
			get
			{
				return FieldKey._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldKey.Descriptor;
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

		public uint Group
		{
			get
			{
				return this.group_;
			}
			set
			{
				this.group_ = value;
			}
		}

		public uint Field
		{
			get
			{
				return this.field_;
			}
			set
			{
				this.field_ = value;
			}
		}

		public ulong UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		public FieldKey()
		{
		}

		public FieldKey(FieldKey other) : this()
		{
			this.program_ = other.program_;
			this.group_ = other.group_;
			this.field_ = other.field_;
			this.uniqueId_ = other.uniqueId_;
		}

		public FieldKey Clone()
		{
			return new FieldKey(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FieldKey);
		}

		public bool Equals(FieldKey other)
		{
			if (other == null)
			{
				goto IL_66;
			}
			goto IL_10C;
			int arg_BE_0;
			while (true)
			{
				IL_B9:
				switch ((arg_BE_0 ^ -1945981397) % 13)
				{
				case 0:
					return false;
				case 1:
					arg_BE_0 = ((this.Field != other.Field) ? -296246589 : -1724363297);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					arg_BE_0 = ((this.Program == other.Program) ? -1035847895 : -235361727);
					continue;
				case 6:
					goto IL_10C;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					goto IL_66;
				case 10:
					return true;
				case 11:
					arg_BE_0 = ((this.Group != other.Group) ? -183271994 : -731353487);
					continue;
				case 12:
					arg_BE_0 = ((this.UniqueId == other.UniqueId) ? -1712269828 : -1292657692);
					continue;
				}
				break;
			}
			return true;
			IL_66:
			arg_BE_0 = -1124533097;
			goto IL_B9;
			IL_10C:
			arg_BE_0 = ((other != this) ? -1237338681 : -1800938118);
			goto IL_B9;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_DE:
				uint arg_B6_0 = 4017449496u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B6_0 ^ 2360746480u)) % 7u)
					{
					case 0u:
						num ^= this.Field.GetHashCode();
						arg_B6_0 = (num2 * 2285650989u ^ 3461434915u);
						continue;
					case 2u:
						num ^= this.Group.GetHashCode();
						arg_B6_0 = (num2 * 1077905925u ^ 3267391487u);
						continue;
					case 3u:
						goto IL_DE;
					case 4u:
						arg_B6_0 = (((this.UniqueId == 0uL) ? 1503050965u : 992345363u) ^ num2 * 2177141497u);
						continue;
					case 5u:
						num ^= this.UniqueId.GetHashCode();
						arg_B6_0 = (num2 * 4133319517u ^ 277118358u);
						continue;
					case 6u:
						num ^= this.Program.GetHashCode();
						arg_B6_0 = (num2 * 3329726482u ^ 1849153555u);
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
			output.WriteRawTag(8);
			while (true)
			{
				IL_111:
				uint arg_E0_0 = 1157904819u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E0_0 ^ 467479888u)) % 9u)
					{
					case 0u:
						goto IL_111;
					case 1u:
						output.WriteRawTag(32);
						output.WriteUInt64(this.UniqueId);
						arg_E0_0 = (num * 663807890u ^ 141047044u);
						continue;
					case 2u:
						output.WriteRawTag(24);
						arg_E0_0 = (num * 1152349119u ^ 2449291716u);
						continue;
					case 3u:
						output.WriteUInt32(this.Program);
						arg_E0_0 = (num * 2346277929u ^ 561594654u);
						continue;
					case 4u:
						arg_E0_0 = (((this.UniqueId != 0uL) ? 1793733222u : 1711878664u) ^ num * 4260744256u);
						continue;
					case 5u:
						output.WriteUInt32(this.Field);
						arg_E0_0 = (num * 1551564995u ^ 811026937u);
						continue;
					case 6u:
						output.WriteUInt32(this.Group);
						arg_E0_0 = (num * 669904672u ^ 3851692484u);
						continue;
					case 8u:
						output.WriteRawTag(16);
						arg_E0_0 = (num * 753962784u ^ 2820837299u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B1:
				uint arg_91_0 = 3532926061u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_91_0 ^ 2708501774u)) % 5u)
					{
					case 0u:
						goto IL_B1;
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
						arg_91_0 = (num2 * 3190269928u ^ 3184607141u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Group);
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Field);
						arg_91_0 = (((this.UniqueId != 0uL) ? 46055387u : 1444317967u) ^ num2 * 3093268280u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
						arg_91_0 = (num2 * 368700993u ^ 3998530330u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(FieldKey other)
		{
			if (other == null)
			{
				goto IL_F3;
			}
			goto IL_145;
			uint arg_FD_0;
			while (true)
			{
				IL_F8:
				uint num;
				switch ((num = (arg_FD_0 ^ 1684565293u)) % 11u)
				{
				case 0u:
					goto IL_F3;
				case 2u:
					this.UniqueId = other.UniqueId;
					arg_FD_0 = (num * 1375906450u ^ 1466106239u);
					continue;
				case 3u:
					arg_FD_0 = ((other.Field == 0u) ? 2114476295u : 994710479u);
					continue;
				case 4u:
					arg_FD_0 = ((other.UniqueId != 0uL) ? 1884026171u : 202660339u);
					continue;
				case 5u:
					arg_FD_0 = ((other.Group != 0u) ? 732699988u : 1593377318u);
					continue;
				case 6u:
					this.Program = other.Program;
					arg_FD_0 = (num * 3584599342u ^ 519440853u);
					continue;
				case 7u:
					goto IL_145;
				case 8u:
					return;
				case 9u:
					this.Group = other.Group;
					arg_FD_0 = (num * 3885761744u ^ 3303031926u);
					continue;
				case 10u:
					this.Field = other.Field;
					arg_FD_0 = (num * 2616293697u ^ 3228913765u);
					continue;
				}
				break;
			}
			return;
			IL_F3:
			arg_FD_0 = 1468032242u;
			goto IL_F8;
			IL_145:
			arg_FD_0 = ((other.Program != 0u) ? 717847544u : 931621523u);
			goto IL_F8;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1C4:
				uint num;
				uint arg_168_0 = ((num = input.ReadTag()) == 0u) ? 29722375u : 1951478127u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_168_0 ^ 1173279654u)) % 16u)
					{
					case 0u:
						this.Group = input.ReadUInt32();
						arg_168_0 = 1497022467u;
						continue;
					case 2u:
						arg_168_0 = (num2 * 787707759u ^ 313354610u);
						continue;
					case 3u:
						arg_168_0 = ((num != 24u) ? 953055726u : 135232701u);
						continue;
					case 4u:
						arg_168_0 = (num2 * 1993115784u ^ 299730211u);
						continue;
					case 5u:
						goto IL_1C4;
					case 6u:
						this.Program = input.ReadUInt32();
						arg_168_0 = 1497022467u;
						continue;
					case 7u:
						arg_168_0 = 1951478127u;
						continue;
					case 8u:
						arg_168_0 = (((num != 32u) ? 878382252u : 1841749595u) ^ num2 * 1142073620u);
						continue;
					case 9u:
						arg_168_0 = ((num <= 16u) ? 2106295161u : 1471446229u);
						continue;
					case 10u:
						input.SkipLastField();
						arg_168_0 = 1303249304u;
						continue;
					case 11u:
						this.Field = input.ReadUInt32();
						arg_168_0 = 787647938u;
						continue;
					case 12u:
						arg_168_0 = (((num == 16u) ? 1507770278u : 930319028u) ^ num2 * 1665075364u);
						continue;
					case 13u:
						this.UniqueId = input.ReadUInt64();
						arg_168_0 = 1497022467u;
						continue;
					case 14u:
						arg_168_0 = (num2 * 4191496827u ^ 2349068233u);
						continue;
					case 15u:
						arg_168_0 = (((num == 8u) ? 3728999284u : 2849422334u) ^ num2 * 3077587932u);
						continue;
					}
					return;
				}
			}
		}
	}
}
