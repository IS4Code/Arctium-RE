using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class BindResponse : IMessage<BindResponse>, IEquatable<BindResponse>, IDeepCloneable<BindResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BindResponse.__c __9 = new BindResponse.__c();

			internal BindResponse cctor>b__24_0()
			{
				return new BindResponse();
			}
		}

		private static readonly MessageParser<BindResponse> _parser = new MessageParser<BindResponse>(new Func<BindResponse>(BindResponse.__c.__9.<.cctor>b__24_0));

		public const int ImportedServiceIdFieldNumber = 1;

		private static readonly FieldCodec<uint> _repeated_importedServiceId_codec = FieldCodec.ForUInt32(10u);

		private readonly RepeatedField<uint> importedServiceId_ = new RepeatedField<uint>();

		public static MessageParser<BindResponse> Parser
		{
			get
			{
				return BindResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BindResponse.Descriptor;
			}
		}

		[Obsolete]
		public RepeatedField<uint> ImportedServiceId
		{
			get
			{
				return this.importedServiceId_;
			}
		}

		public BindResponse()
		{
		}

		public BindResponse(BindResponse other) : this()
		{
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 1414751206u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 1877406728u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 2u:
						this.importedServiceId_ = other.importedServiceId_.Clone();
						arg_2B_0 = (num * 765050725u ^ 3391727072u);
						continue;
					}
					return;
				}
			}
		}

		public BindResponse Clone()
		{
			return new BindResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BindResponse);
		}

		public bool Equals(BindResponse other)
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
				switch ((arg_48_0 ^ -248536483) % 7)
				{
				case 0:
					arg_48_0 = (this.importedServiceId_.Equals(other.importedServiceId_) ? -922105921 : -913677395);
					continue;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					goto IL_7A;
				case 4:
					goto IL_12;
				case 5:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -1156645952;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -561771128 : -43741944);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ BindResponse.smethod_0(this.importedServiceId_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.importedServiceId_.WriteTo(output, BindResponse._repeated_importedServiceId_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.importedServiceId_.CalculateSize(BindResponse._repeated_importedServiceId_codec);
		}

		public void MergeFrom(BindResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.importedServiceId_.Add(other.importedServiceId_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_C4:
				uint num;
				uint arg_8D_0 = ((num = input.ReadTag()) != 0u) ? 1300552149u : 269162068u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_8D_0 ^ 1546232617u)) % 7u)
					{
					case 0u:
						arg_8D_0 = (((num == 10u) ? 3317978614u : 2267561918u) ^ num2 * 3302392959u);
						continue;
					case 1u:
						this.importedServiceId_.AddEntriesFrom(input, BindResponse._repeated_importedServiceId_codec);
						arg_8D_0 = 1794276607u;
						continue;
					case 2u:
						goto IL_C4;
					case 3u:
						input.SkipLastField();
						arg_8D_0 = (num2 * 4029200252u ^ 291996231u);
						continue;
					case 4u:
						arg_8D_0 = ((num == 8u) ? 657175411u : 784638418u);
						continue;
					case 5u:
						arg_8D_0 = 1300552149u;
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
