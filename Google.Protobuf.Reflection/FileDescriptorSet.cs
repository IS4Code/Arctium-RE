using Google.Protobuf.Collections;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[DebuggerNonUserCode]
	internal sealed class FileDescriptorSet : IMessage, IMessage<FileDescriptorSet>, IEquatable<FileDescriptorSet>, IDeepCloneable<FileDescriptorSet>
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
			this.file_ = other.file_.Clone();
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
				switch ((arg_48_0 ^ 1005784169) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return false;
				case 2:
					arg_48_0 = (this.file_.Equals(other.file_) ? 732756913 : 303562816);
					continue;
				case 4:
					goto IL_7A;
				case 5:
					return false;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 715977448;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 384276521 : 1674580822);
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
			int arg_0D_0 = 1852508849;
			IL_08:
			switch ((arg_0D_0 ^ 1621860010) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				IL_27:
				this.file_.Add(other.file_);
				arg_0D_0 = 897118344;
				goto IL_08;
			case 3:
				return;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 2067997756u : 1467689829u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 2134981203u)) % 7u)
					{
					case 0u:
						input.SkipLastField();
						arg_77_0 = (num2 * 3303453636u ^ 1424539745u);
						continue;
					case 1u:
						arg_77_0 = ((num == 10u) ? 1941942812u : 1927614387u);
						continue;
					case 2u:
						this.file_.AddEntriesFrom(input, FileDescriptorSet._repeated_file_codec);
						arg_77_0 = 817556162u;
						continue;
					case 3u:
						arg_77_0 = (num2 * 3678640650u ^ 645686838u);
						continue;
					case 4u:
						goto IL_AE;
					case 6u:
						arg_77_0 = 2067997756u;
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
