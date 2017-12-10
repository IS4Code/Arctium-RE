using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.WellKnownTypes
{
	[DebuggerNonUserCode, ComVisible(true)]
	public sealed class Struct : IMessage<Struct>, IEquatable<Struct>, IDeepCloneable<Struct>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Struct.__c __9 = new Struct.__c();

			internal Struct cctor>b__24_0()
			{
				return new Struct();
			}
		}

		private static readonly MessageParser<Struct> _parser = new MessageParser<Struct>(new Func<Struct>(Struct.__c.__9.<.cctor>b__24_0));

		public const int FieldsFieldNumber = 1;

		private static readonly MapField<string, Value>.Codec _map_fields_codec = new MapField<string, Value>.Codec(FieldCodec.ForString(10u), FieldCodec.ForMessage<Value>(18u, Value.Parser), 10u);

		private readonly MapField<string, Value> fields_ = new MapField<string, Value>();

		public static MessageParser<Struct> Parser
		{
			get
			{
				return Struct._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return StructReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Struct.Descriptor;
			}
		}

		public MapField<string, Value> Fields
		{
			get
			{
				return this.fields_;
			}
		}

		public Struct()
		{
		}

		public Struct(Struct other) : this()
		{
			this.fields_ = other.fields_.Clone();
		}

		public Struct Clone()
		{
			return new Struct(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Struct);
		}

		public bool Equals(Struct other)
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
				switch ((arg_48_0 ^ -678569526) % 7)
				{
				case 0:
					arg_48_0 = ((!this.Fields.Equals(other.Fields)) ? -2017316130 : -738402119);
					continue;
				case 1:
					return false;
				case 2:
					goto IL_7A;
				case 3:
					return false;
				case 4:
					goto IL_12;
				case 5:
					return true;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -1081432966;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -1509403308 : -1338302477);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ Struct.smethod_0(this.Fields);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.fields_.WriteTo(output, Struct._map_fields_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.fields_.CalculateSize(Struct._map_fields_codec);
		}

		public void MergeFrom(Struct other)
		{
			if (other == null)
			{
				return;
			}
			this.fields_.Add(other.fields_);
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) == 0u) ? 3549203535u : 4033922203u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 3285916908u)) % 7u)
					{
					case 0u:
						arg_77_0 = 4033922203u;
						continue;
					case 1u:
						this.fields_.AddEntriesFrom(input, Struct._map_fields_codec);
						arg_77_0 = 3690910909u;
						continue;
					case 2u:
						input.SkipLastField();
						arg_77_0 = (num2 * 668889924u ^ 1131644761u);
						continue;
					case 3u:
						arg_77_0 = (num2 * 935097955u ^ 1600727358u);
						continue;
					case 4u:
						arg_77_0 = ((num == 10u) ? 3564299018u : 3977425289u);
						continue;
					case 6u:
						goto IL_AE;
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
