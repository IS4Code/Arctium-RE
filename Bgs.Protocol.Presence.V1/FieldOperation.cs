using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class FieldOperation : IMessage<FieldOperation>, IEquatable<FieldOperation>, IDeepCloneable<FieldOperation>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum OperationType
			{
				SET,
				CLEAR
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FieldOperation.__c __9 = new FieldOperation.__c();

			internal FieldOperation cctor>b__30_0()
			{
				return new FieldOperation();
			}
		}

		private static readonly MessageParser<FieldOperation> _parser = new MessageParser<FieldOperation>(new Func<FieldOperation>(FieldOperation.__c.__9.<.cctor>b__30_0));

		public const int FieldFieldNumber = 1;

		private Field field_;

		public const int OperationFieldNumber = 2;

		private FieldOperation.Types.OperationType operation_;

		public static MessageParser<FieldOperation> Parser
		{
			get
			{
				return FieldOperation._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldOperation.Descriptor;
			}
		}

		public Field Field
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

		public FieldOperation.Types.OperationType Operation
		{
			get
			{
				return this.operation_;
			}
			set
			{
				this.operation_ = value;
			}
		}

		public FieldOperation()
		{
		}

		public FieldOperation(FieldOperation other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = 792048638;
				while (true)
				{
					switch ((arg_2E_0 ^ 279942385) % 3)
					{
					case 0:
						goto IL_44;
					case 1:
						this.Field = ((other.field_ != null) ? other.Field.Clone() : null);
						arg_2E_0 = 434642937;
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.operation_ = other.operation_;
		}

		public FieldOperation Clone()
		{
			return new FieldOperation(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FieldOperation);
		}

		public bool Equals(FieldOperation other)
		{
			if (other == null)
			{
				goto IL_68;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ -1364698782) % 9)
				{
				case 0:
					goto IL_68;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					arg_72_0 = ((!FieldOperation.smethod_0(this.Field, other.Field)) ? -1694221359 : -1827282237);
					continue;
				case 4:
					goto IL_B0;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					arg_72_0 = ((this.Operation == other.Operation) ? -1421417736 : -902022713);
					continue;
				}
				break;
			}
			return true;
			IL_68:
			arg_72_0 = -1828527938;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? -1401101305 : -1349094892);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.field_ != null)
			{
				goto IL_1C;
			}
			goto IL_95;
			uint arg_69_0;
			while (true)
			{
				IL_64:
				uint num2;
				switch ((num2 = (arg_69_0 ^ 1873885475u)) % 5u)
				{
				case 0u:
					goto IL_95;
				case 1u:
					num ^= FieldOperation.smethod_1(this.Field);
					arg_69_0 = (num2 * 1344886881u ^ 433652895u);
					continue;
				case 2u:
					num ^= this.Operation.GetHashCode();
					arg_69_0 = (num2 * 2457124083u ^ 3655143396u);
					continue;
				case 3u:
					goto IL_1C;
				}
				break;
			}
			return num;
			IL_1C:
			arg_69_0 = 1401975424u;
			goto IL_64;
			IL_95:
			arg_69_0 = ((this.Operation != FieldOperation.Types.OperationType.SET) ? 1645487698u : 836426663u);
			goto IL_64;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.field_ != null)
			{
				goto IL_6F;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 1819362836u)) % 6u)
				{
				case 0u:
					goto IL_6F;
				case 1u:
					output.WriteEnum((int)this.Operation);
					arg_79_0 = (num * 1383902254u ^ 1847120498u);
					continue;
				case 2u:
					output.WriteRawTag(16);
					arg_79_0 = (num * 1805371482u ^ 2491418039u);
					continue;
				case 3u:
					goto IL_AC;
				case 5u:
					output.WriteRawTag(10);
					output.WriteMessage(this.Field);
					arg_79_0 = (num * 1392217118u ^ 994341101u);
					continue;
				}
				break;
			}
			return;
			IL_6F:
			arg_79_0 = 1456141589u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.Operation != FieldOperation.Types.OperationType.SET) ? 1317239346u : 772319136u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 435474633u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 321161722u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Field);
						arg_92_0 = (num2 * 2551021771u ^ 2596119188u);
						continue;
					case 1u:
						arg_92_0 = (((this.field_ != null) ? 3816497794u : 3273134788u) ^ num2 * 1955878028u);
						continue;
					case 2u:
						arg_92_0 = ((this.Operation != FieldOperation.Types.OperationType.SET) ? 126196643u : 495229763u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Operation);
						arg_92_0 = (num2 * 1787907356u ^ 4010761727u);
						continue;
					case 4u:
						goto IL_B6;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(FieldOperation other)
		{
			if (other == null)
			{
				goto IL_B5;
			}
			goto IL_FF;
			uint arg_BF_0;
			while (true)
			{
				IL_BA:
				uint num;
				switch ((num = (arg_BF_0 ^ 3077115569u)) % 9u)
				{
				case 0u:
					goto IL_B5;
				case 1u:
					arg_BF_0 = ((other.Operation != FieldOperation.Types.OperationType.SET) ? 2240675928u : 3387827426u);
					continue;
				case 2u:
					arg_BF_0 = (((this.field_ != null) ? 3679974538u : 3006596628u) ^ num * 1693189795u);
					continue;
				case 3u:
					this.Operation = other.Operation;
					arg_BF_0 = (num * 3736260364u ^ 1779121422u);
					continue;
				case 4u:
					this.field_ = new Field();
					arg_BF_0 = (num * 2846617018u ^ 3061706463u);
					continue;
				case 5u:
					goto IL_FF;
				case 6u:
					return;
				case 7u:
					this.Field.MergeFrom(other.Field);
					arg_BF_0 = 3824244900u;
					continue;
				}
				break;
			}
			return;
			IL_B5:
			arg_BF_0 = 3573181412u;
			goto IL_BA;
			IL_FF:
			arg_BF_0 = ((other.field_ == null) ? 3824244900u : 3172937142u);
			goto IL_BA;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13A:
				uint num;
				uint arg_F2_0 = ((num = input.ReadTag()) != 0u) ? 554946449u : 1318784839u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F2_0 ^ 1226781366u)) % 11u)
					{
					case 0u:
						arg_F2_0 = 554946449u;
						continue;
					case 1u:
						this.field_ = new Field();
						arg_F2_0 = (num2 * 1429008446u ^ 4210447663u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_F2_0 = (num2 * 3967077280u ^ 3786076113u);
						continue;
					case 3u:
						arg_F2_0 = ((this.field_ == null) ? 2119586572u : 1202347555u);
						continue;
					case 4u:
						arg_F2_0 = (((num != 16u) ? 949926187u : 1513085884u) ^ num2 * 2332716175u);
						continue;
					case 5u:
						input.ReadMessage(this.field_);
						arg_F2_0 = 1330177293u;
						continue;
					case 6u:
						goto IL_13A;
					case 7u:
						arg_F2_0 = ((num == 10u) ? 277593767u : 13730100u);
						continue;
					case 9u:
						this.operation_ = (FieldOperation.Types.OperationType)input.ReadEnum();
						arg_F2_0 = 1330177293u;
						continue;
					case 10u:
						arg_F2_0 = (num2 * 706034641u ^ 1025138490u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
