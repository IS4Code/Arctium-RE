using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class ProcessId : IMessage<ProcessId>, IEquatable<ProcessId>, IDeepCloneable<ProcessId>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ProcessId.__c __9 = new ProcessId.__c();

			internal ProcessId cctor>b__29_0()
			{
				return new ProcessId();
			}
		}

		private static readonly MessageParser<ProcessId> _parser = new MessageParser<ProcessId>(new Func<ProcessId>(ProcessId.__c.__9.<.cctor>b__29_0));

		public const int LabelFieldNumber = 1;

		private uint label_;

		public const int EpochFieldNumber = 2;

		private uint epoch_;

		public static MessageParser<ProcessId> Parser
		{
			get
			{
				return ProcessId._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessId.Descriptor;
			}
		}

		public uint Label
		{
			get
			{
				return this.label_;
			}
			set
			{
				this.label_ = value;
			}
		}

		public uint Epoch
		{
			get
			{
				return this.epoch_;
			}
			set
			{
				this.epoch_ = value;
			}
		}

		public ProcessId()
		{
		}

		public ProcessId(ProcessId other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 3063290638u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 2436499432u)) % 3u)
					{
					case 1u:
						this.label_ = other.label_;
						arg_26_0 = (num * 584904251u ^ 2122595840u);
						continue;
					case 2u:
						goto IL_3E;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.epoch_ = other.epoch_;
		}

		public ProcessId Clone()
		{
			return new ProcessId(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessId);
		}

		public bool Equals(ProcessId other)
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
				switch ((arg_6D_0 ^ 206117669) % 9)
				{
				case 0:
					arg_6D_0 = ((this.Epoch != other.Epoch) ? 1501679079 : 594287445);
					continue;
				case 1:
					goto IL_AB;
				case 2:
					return false;
				case 3:
					arg_6D_0 = ((this.Label == other.Label) ? 1590624097 : 1733647903);
					continue;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_6D_0 = 2057605337;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other == this) ? 539630939 : 1390132602);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			return 1 ^ this.Label.GetHashCode() ^ this.Epoch.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(this.Label);
			output.WriteRawTag(16);
			output.WriteUInt32(this.Epoch);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeUInt32Size(this.Label)) + (1 + CodedOutputStream.ComputeUInt32Size(this.Epoch));
		}

		public void MergeFrom(ProcessId other)
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
				switch ((num = (arg_76_0 ^ 3071542993u)) % 7u)
				{
				case 0u:
					this.Epoch = other.Epoch;
					arg_76_0 = (num * 2122077845u ^ 3853770081u);
					continue;
				case 1u:
					arg_76_0 = ((other.Epoch == 0u) ? 2493328637u : 2614089469u);
					continue;
				case 2u:
					goto IL_AD;
				case 4u:
					return;
				case 5u:
					this.Label = other.Label;
					arg_76_0 = (num * 1885469232u ^ 321180858u);
					continue;
				case 6u:
					goto IL_15;
				}
				break;
			}
			return;
			IL_15:
			arg_76_0 = 2420299156u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.Label != 0u) ? 3583963357u : 3150253818u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_D9:
				uint num;
				uint arg_9E_0 = ((num = input.ReadTag()) != 0u) ? 1012932227u : 877148087u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9E_0 ^ 1541073719u)) % 8u)
					{
					case 1u:
						this.Epoch = input.ReadUInt32();
						arg_9E_0 = 286447628u;
						continue;
					case 2u:
						this.Label = input.ReadUInt32();
						arg_9E_0 = 286447628u;
						continue;
					case 3u:
						goto IL_D9;
					case 4u:
						arg_9E_0 = ((num == 8u) ? 713114029u : 1071426098u);
						continue;
					case 5u:
						arg_9E_0 = (((num != 16u) ? 3689775795u : 4151018444u) ^ num2 * 2006267818u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_9E_0 = (num2 * 2801947723u ^ 804626878u);
						continue;
					case 7u:
						arg_9E_0 = 1012932227u;
						continue;
					}
					return;
				}
			}
		}
	}
}
