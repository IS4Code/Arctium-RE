using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[DebuggerNonUserCode]
	internal sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IEquatable<FileDescriptorSet>, IDeepCloneable<FileDescriptorSet>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FileDescriptorSet.__c __9 = new FileDescriptorSet.__c();

			internal FileDescriptorSet cctor>b__24_0()
			{
				return new FileDescriptorSet();
			}
		}

		private static readonly MessageParser<FileDescriptorSet> _parser = new MessageParser<FileDescriptorSet>(new Func<FileDescriptorSet>(FileDescriptorSet.__c.__9.<.cctor>b__24_0));

		public const int FileFieldNumber = 1;

		private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec = FieldCodec.ForMessage<FileDescriptorProto>(10u, FileDescriptorProto.Parser);

		private readonly RepeatedField<FileDescriptorProto> file_ = new RepeatedField<FileDescriptorProto>();

		public static MessageParser<FileDescriptorSet> Parser
		{
			get
			{
				return FileDescriptorSet._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return DescriptorReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FileDescriptorSet.Descriptor;
			}
		}

		public RepeatedField<FileDescriptorProto> File
		{
			get
			{
				return this.file_;
			}
		}

		public FileDescriptorSet()
		{
		}

		public FileDescriptorSet(FileDescriptorSet other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 3548440207u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 2425686678u)) % 3u)
					{
					case 1u:
						this.file_ = other.file_.Clone();
						arg_2B_0 = (num * 2170661392u ^ 321912427u);
						continue;
					case 2u:
						goto IL_43;
					}
					return;
				}
			}
		}

		public FileDescriptorSet Clone()
		{
			return new FileDescriptorSet(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FileDescriptorSet);
		}

		public bool Equals(FileDescriptorSet other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -1338975685) % 7)
				{
				case 0:
					goto IL_7A;
				case 2:
					goto IL_3E;
				case 3:
					return true;
				case 4:
					arg_48_0 = (this.file_.Equals(other.file_) ? -1533420591 : -117273595);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1643539297;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -1355999964 : -455949319);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ FileDescriptorSet.smethod_0(this.file_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.file_.WriteTo(output, FileDescriptorSet._repeated_file_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.file_.CalculateSize(FileDescriptorSet._repeated_file_codec);
		}

		public void MergeFrom(FileDescriptorSet other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -573429460;
			IL_08:
			switch ((arg_0D_0 ^ -1837249430) % 4)
			{
			case 1:
				IL_27:
				this.file_.Add(other.file_);
				arg_0D_0 = -1498754402;
				goto IL_08;
			case 2:
				return;
			case 3:
				goto IL_03;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 1123319483u : 350785980u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 2099139927u)) % 7u)
					{
					case 0u:
						this.file_.AddEntriesFrom(input, FileDescriptorSet._repeated_file_codec);
						arg_77_0 = 1921356769u;
						continue;
					case 1u:
						arg_77_0 = ((num != 10u) ? 166295916u : 339905823u);
						continue;
					case 2u:
						arg_77_0 = 1123319483u;
						continue;
					case 3u:
						arg_77_0 = (num2 * 3868359886u ^ 1953589469u);
						continue;
					case 4u:
						goto IL_AE;
					case 5u:
						input.SkipLastField();
						arg_77_0 = (num2 * 3409509696u ^ 3755138597u);
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
