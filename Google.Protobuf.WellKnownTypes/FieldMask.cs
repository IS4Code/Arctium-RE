using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class FieldMask : IMessage<FieldMask>, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FieldMask.__c __9 = new FieldMask.__c();

			internal FieldMask cctor>b__24_0()
			{
				return new FieldMask();
			}
		}

		private static readonly MessageParser<FieldMask> _parser = new MessageParser<FieldMask>(new Func<FieldMask>(FieldMask.__c.__9.<.cctor>b__24_0));

		public const int PathsFieldNumber = 1;

		private static readonly FieldCodec<string> _repeated_paths_codec;

		private readonly RepeatedField<string> paths_ = new RepeatedField<string>();

		public static MessageParser<FieldMask> Parser
		{
			get
			{
				return FieldMask._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldMaskReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldMask.Descriptor;
			}
		}

		public RepeatedField<string> Paths
		{
			get
			{
				return this.paths_;
			}
		}

		public FieldMask()
		{
		}

		public FieldMask(FieldMask other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 3624769307u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 2963693231u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 2u:
						this.paths_ = other.paths_.Clone();
						arg_2B_0 = (num * 3630993511u ^ 1445836109u);
						continue;
					}
					return;
				}
			}
		}

		public FieldMask Clone()
		{
			return new FieldMask(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FieldMask);
		}

		public bool Equals(FieldMask other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -355241706) % 7)
				{
				case 1:
					arg_48_0 = (this.paths_.Equals(other.paths_) ? -781780053 : -42101117);
					continue;
				case 2:
					return false;
				case 3:
					goto IL_12;
				case 4:
					return false;
				case 5:
					goto IL_7A;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -1539772282;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -103837231 : -608284565);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ FieldMask.smethod_0(this.paths_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.paths_.WriteTo(output, FieldMask._repeated_paths_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.paths_.CalculateSize(FieldMask._repeated_paths_codec);
		}

		public void MergeFrom(FieldMask other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 518233939;
			IL_08:
			switch ((arg_0D_0 ^ 1199302996) % 4)
			{
			case 0:
				goto IL_03;
			case 2:
				IL_27:
				this.paths_.Add(other.paths_);
				arg_0D_0 = 273004453;
				goto IL_08;
			case 3:
				return;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_9B:
				uint num;
				uint arg_68_0 = ((num = input.ReadTag()) != 0u) ? 95386564u : 939242783u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_68_0 ^ 1534798109u)) % 6u)
					{
					case 0u:
						arg_68_0 = 95386564u;
						continue;
					case 1u:
						this.paths_.AddEntriesFrom(input, FieldMask._repeated_paths_codec);
						arg_68_0 = 469237416u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_68_0 = (num2 * 3530706062u ^ 2880211464u);
						continue;
					case 3u:
						goto IL_9B;
					case 5u:
						arg_68_0 = ((num == 10u) ? 1857937980u : 110731821u);
						continue;
					}
					return;
				}
			}
		}

		static FieldMask()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_52:
				uint arg_3A_0 = 2175406454u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3A_0 ^ 3807717273u)) % 3u)
					{
					case 0u:
						goto IL_52;
					case 1u:
						FieldMask._repeated_paths_codec = FieldCodec.ForString(10u);
						arg_3A_0 = (num * 902393939u ^ 2492974704u);
						continue;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
