using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountHandle : IMessage<GameAccountHandle>, IEquatable<GameAccountHandle>, IDeepCloneable<GameAccountHandle>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountHandle.__c __9 = new GameAccountHandle.__c();

			internal GameAccountHandle cctor>b__34_0()
			{
				return new GameAccountHandle();
			}
		}

		private static readonly MessageParser<GameAccountHandle> _parser = new MessageParser<GameAccountHandle>(new Func<GameAccountHandle>(GameAccountHandle.__c.__9.<.cctor>b__34_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public const int ProgramFieldNumber = 2;

		private uint program_;

		public const int RegionFieldNumber = 3;

		private uint region_;

		public static MessageParser<GameAccountHandle> Parser
		{
			get
			{
				return GameAccountHandle._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountHandle.Descriptor;
			}
		}

		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
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

		public uint Region
		{
			get
			{
				return this.region_;
			}
			set
			{
				this.region_ = value;
			}
		}

		public GameAccountHandle()
		{
		}

		public GameAccountHandle(GameAccountHandle other) : this()
		{
			this.id_ = other.id_;
			this.program_ = other.program_;
			this.region_ = other.region_;
		}

		public GameAccountHandle Clone()
		{
			return new GameAccountHandle(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountHandle);
		}

		public bool Equals(GameAccountHandle other)
		{
			if (other == null)
			{
				goto IL_63;
			}
			goto IL_DA;
			int arg_94_0;
			while (true)
			{
				IL_8F:
				switch ((arg_94_0 ^ 1647739770) % 11)
				{
				case 0:
					return true;
				case 2:
					return false;
				case 3:
					arg_94_0 = ((this.Program == other.Program) ? 478190360 : 1423706175);
					continue;
				case 4:
					goto IL_63;
				case 5:
					return false;
				case 6:
					goto IL_DA;
				case 7:
					arg_94_0 = ((this.Region != other.Region) ? 2026218469 : 490430371);
					continue;
				case 8:
					arg_94_0 = ((this.Id == other.Id) ? 1683505394 : 862191327);
					continue;
				case 9:
					return false;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_63:
			arg_94_0 = 1558907728;
			goto IL_8F;
			IL_DA:
			arg_94_0 = ((other != this) ? 1239919129 : 728912531);
			goto IL_8F;
		}

		public override int GetHashCode()
		{
			return 1 ^ this.Id.GetHashCode() ^ this.Program.GetHashCode() ^ this.Region.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(13);
			output.WriteFixed32(this.Id);
			output.WriteRawTag(21);
			while (true)
			{
				IL_68:
				uint arg_50_0 = 2280320138u;
				while (true)
				{
					uint num;
					switch ((num = (arg_50_0 ^ 3513225793u)) % 3u)
					{
					case 1u:
						output.WriteFixed32(this.Program);
						output.WriteRawTag(24);
						output.WriteUInt32(this.Region);
						arg_50_0 = (num * 915199142u ^ 2439915390u);
						continue;
					case 2u:
						goto IL_68;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 10 + (1 + CodedOutputStream.ComputeUInt32Size(this.Region));
		}

		public void MergeFrom(GameAccountHandle other)
		{
			if (other == null)
			{
				goto IL_AE;
			}
			goto IL_F8;
			uint arg_B8_0;
			while (true)
			{
				IL_B3:
				uint num;
				switch ((num = (arg_B8_0 ^ 4020953324u)) % 9u)
				{
				case 0u:
					goto IL_AE;
				case 2u:
					this.Id = other.Id;
					arg_B8_0 = (num * 669862586u ^ 3021158761u);
					continue;
				case 3u:
					arg_B8_0 = ((other.Region != 0u) ? 3267553764u : 3976939042u);
					continue;
				case 4u:
					this.Program = other.Program;
					arg_B8_0 = (num * 876692524u ^ 1297193058u);
					continue;
				case 5u:
					return;
				case 6u:
					goto IL_F8;
				case 7u:
					this.Region = other.Region;
					arg_B8_0 = (num * 3314831185u ^ 878646698u);
					continue;
				case 8u:
					arg_B8_0 = ((other.Program == 0u) ? 3669362650u : 2432125030u);
					continue;
				}
				break;
			}
			return;
			IL_AE:
			arg_B8_0 = 3268791917u;
			goto IL_B3;
			IL_F8:
			arg_B8_0 = ((other.Id != 0u) ? 4000722834u : 3424392421u);
			goto IL_B3;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_148:
				uint num;
				uint arg_FC_0 = ((num = input.ReadTag()) != 0u) ? 2673013858u : 2823313124u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_FC_0 ^ 2210839519u)) % 12u)
					{
					case 0u:
						arg_FC_0 = 2673013858u;
						continue;
					case 1u:
						arg_FC_0 = (num2 * 1184337201u ^ 1120384252u);
						continue;
					case 2u:
						goto IL_148;
					case 3u:
						this.Id = input.ReadFixed32();
						arg_FC_0 = 2371660337u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_FC_0 = (num2 * 3438703135u ^ 2781545629u);
						continue;
					case 5u:
						this.Program = input.ReadFixed32();
						arg_FC_0 = 2216261298u;
						continue;
					case 6u:
						arg_FC_0 = (num2 * 707130932u ^ 1517139577u);
						continue;
					case 8u:
						this.Region = input.ReadUInt32();
						arg_FC_0 = 4253150753u;
						continue;
					case 9u:
						arg_FC_0 = ((num == 13u) ? 2393229056u : 3695480992u);
						continue;
					case 10u:
						arg_FC_0 = (((num != 24u) ? 1235265309u : 552543845u) ^ num2 * 1838112559u);
						continue;
					case 11u:
						arg_FC_0 = (((num == 21u) ? 3578763110u : 4199841489u) ^ num2 * 3503081772u);
						continue;
					}
					return;
				}
			}
		}
	}
}
