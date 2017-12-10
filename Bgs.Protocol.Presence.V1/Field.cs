using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class Field : IMessage<Field>, IEquatable<Field>, IDeepCloneable<Field>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Field.__c __9 = new Field.__c();

			internal Field cctor>b__29_0()
			{
				return new Field();
			}
		}

		private static readonly MessageParser<Field> _parser = new MessageParser<Field>(new Func<Field>(Field.__c.__9.<.cctor>b__29_0));

		public const int KeyFieldNumber = 1;

		private FieldKey key_;

		public const int ValueFieldNumber = 2;

		private Variant value_;

		public static MessageParser<Field> Parser
		{
			get
			{
				return Field._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Field.Descriptor;
			}
		}

		public FieldKey Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		public Variant Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		public Field()
		{
		}

		public Field(Field other) : this()
		{
			while (true)
			{
				IL_6B:
				int arg_51_0 = -655235716;
				while (true)
				{
					switch ((arg_51_0 ^ -1463197333) % 4)
					{
					case 0:
						goto IL_6B;
					case 2:
						this.Value = ((other.value_ != null) ? other.Value.Clone() : null);
						arg_51_0 = -1382608502;
						continue;
					case 3:
						this.Key = ((other.key_ != null) ? other.Key.Clone() : null);
						arg_51_0 = -1428572403;
						continue;
					}
					return;
				}
			}
		}

		public Field Clone()
		{
			return new Field(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Field);
		}

		public bool Equals(Field other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ -1785209479) % 9)
				{
				case 0:
					return true;
				case 1:
					goto IL_B5;
				case 3:
					return false;
				case 4:
					arg_77_0 = ((!Field.smethod_0(this.Key, other.Key)) ? -247270079 : -1114730203);
					continue;
				case 5:
					goto IL_41;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					arg_77_0 = ((!Field.smethod_0(this.Value, other.Value)) ? -8977420 : -354520573);
					continue;
				}
				break;
			}
			return true;
			IL_41:
			arg_77_0 = -314474265;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -2092759061 : -45625214);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			return 1 ^ Field.smethod_1(this.Key) ^ Field.smethod_1(this.Value);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			while (true)
			{
				IL_54:
				uint arg_3C_0 = 3080384962u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3C_0 ^ 2667596624u)) % 3u)
					{
					case 1u:
						output.WriteMessage(this.Key);
						output.WriteRawTag(18);
						output.WriteMessage(this.Value);
						arg_3C_0 = (num * 486055783u ^ 2402509282u);
						continue;
					case 2u:
						goto IL_54;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.Key)) + (1 + CodedOutputStream.ComputeMessageSize(this.Value));
		}

		public void MergeFrom(Field other)
		{
			if (other == null)
			{
				goto IL_91;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 1168484668u)) % 11u)
				{
				case 0u:
					this.Key.MergeFrom(other.Key);
					arg_105_0 = 1357949136u;
					continue;
				case 1u:
					arg_105_0 = (((this.value_ != null) ? 1894472449u : 2054688808u) ^ num * 2331677748u);
					continue;
				case 3u:
					arg_105_0 = (((this.key_ == null) ? 1786776794u : 1069343464u) ^ num * 3643861115u);
					continue;
				case 4u:
					goto IL_91;
				case 5u:
					this.Value.MergeFrom(other.Value);
					arg_105_0 = 362283141u;
					continue;
				case 6u:
					this.value_ = new Variant();
					arg_105_0 = (num * 3662084530u ^ 615643029u);
					continue;
				case 7u:
					return;
				case 8u:
					goto IL_14D;
				case 9u:
					arg_105_0 = ((other.value_ != null) ? 1220239493u : 362283141u);
					continue;
				case 10u:
					this.key_ = new FieldKey();
					arg_105_0 = (num * 687029405u ^ 2073845966u);
					continue;
				}
				break;
			}
			return;
			IL_91:
			arg_105_0 = 1012410645u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.key_ == null) ? 1357949136u : 2056015198u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_183:
				uint num;
				uint arg_133_0 = ((num = input.ReadTag()) != 0u) ? 3697655801u : 2863410337u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_133_0 ^ 3402333857u)) % 13u)
					{
					case 0u:
						input.ReadMessage(this.value_);
						arg_133_0 = 3766663436u;
						continue;
					case 1u:
						arg_133_0 = ((this.value_ != null) ? 3843323186u : 3116820485u);
						continue;
					case 2u:
						goto IL_183;
					case 3u:
						arg_133_0 = ((num == 10u) ? 2378105952u : 2949465862u);
						continue;
					case 4u:
						this.value_ = new Variant();
						arg_133_0 = (num2 * 269274921u ^ 1556072822u);
						continue;
					case 5u:
						arg_133_0 = (num2 * 3470981307u ^ 1138991992u);
						continue;
					case 6u:
						arg_133_0 = (((num == 18u) ? 3764012119u : 2673503176u) ^ num2 * 2896441053u);
						continue;
					case 7u:
						arg_133_0 = ((this.key_ == null) ? 3695020784u : 2525018058u);
						continue;
					case 8u:
						this.key_ = new FieldKey();
						arg_133_0 = (num2 * 3166300714u ^ 484419712u);
						continue;
					case 9u:
						arg_133_0 = 3697655801u;
						continue;
					case 10u:
						input.ReadMessage(this.key_);
						arg_133_0 = 3766663436u;
						continue;
					case 11u:
						input.SkipLastField();
						arg_133_0 = (num2 * 455015917u ^ 1480248743u);
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
