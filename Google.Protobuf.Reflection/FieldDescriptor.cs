using Google.Protobuf.Compatibility;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
	{
		private readonly FieldDescriptorProto proto;

		private EnumDescriptor enumType;

		private MessageDescriptor messageType;

		private readonly MessageDescriptor containingType;

		private readonly OneofDescriptor containingOneof;

		private FieldType fieldType;

		private readonly string propertyName;

		private IFieldAccessor accessor;

		public override string Name
		{
			get
			{
				return this.proto.Name;
			}
		}

		internal FieldDescriptorProto Proto
		{
			get
			{
				return this.proto;
			}
		}

		public IFieldAccessor Accessor
		{
			get
			{
				return this.accessor;
			}
		}

		public bool IsRepeated
		{
			get
			{
				return this.Proto.Label == FieldDescriptorProto.Types.Label.LABEL_REPEATED;
			}
		}

		public bool IsMap
		{
			get
			{
				if (this.fieldType == FieldType.Message)
				{
					while (true)
					{
						IL_5E:
						uint arg_42_0 = 4136303111u;
						while (true)
						{
							uint num;
							switch ((num = (arg_42_0 ^ 3689864530u)) % 4u)
							{
							case 1u:
								arg_42_0 = (((this.messageType.Proto.Options == null) ? 3153850573u : 2500854299u) ^ num * 2571622187u);
								continue;
							case 2u:
								goto IL_65;
							case 3u:
								goto IL_5E;
							}
							goto Block_3;
						}
					}
					Block_3:
					return false;
					IL_65:
					return this.messageType.Proto.Options.MapEntry;
				}
				return false;
			}
		}

		public bool IsPacked
		{
			get
			{
				return this.Proto.Options == null || this.Proto.Options.Packed;
			}
		}

		public MessageDescriptor ContainingType
		{
			get
			{
				return this.containingType;
			}
		}

		public OneofDescriptor ContainingOneof
		{
			get
			{
				return this.containingOneof;
			}
		}

		public FieldType FieldType
		{
			get
			{
				return this.fieldType;
			}
		}

		public int FieldNumber
		{
			get
			{
				return this.Proto.Number;
			}
		}

		public EnumDescriptor EnumType
		{
			get
			{
				if (this.fieldType != FieldType.Enum)
				{
					throw FieldDescriptor.smethod_2(Module.smethod_33<string>(2812503171u));
				}
				return this.enumType;
			}
		}

		public MessageDescriptor MessageType
		{
			get
			{
				if (this.fieldType != FieldType.Message)
				{
					throw FieldDescriptor.smethod_2(Module.smethod_36<string>(563861317u));
				}
				return this.messageType;
			}
		}

		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName) : base(file, file.ComputeFullName(parent, proto.Name), index)
		{
			while (true)
			{
				IL_192:
				uint arg_155_0 = 668326049u;
				while (true)
				{
					uint num;
					switch ((num = (arg_155_0 ^ 1907900556u)) % 12u)
					{
					case 0u:
						this.containingOneof = parent.Oneofs[proto.OneofIndex];
						arg_155_0 = 951252349u;
						continue;
					case 2u:
						goto IL_192;
					case 3u:
						arg_155_0 = (((proto.OneofIndex != -1) ? 3178787542u : 4269045895u) ^ num * 287148678u);
						continue;
					case 4u:
						arg_155_0 = (((proto.OneofIndex < 0) ? 830153714u : 1120517676u) ^ num * 2667568972u);
						continue;
					case 5u:
						this.proto = proto;
						arg_155_0 = (((proto.Type == (FieldDescriptorProto.Types.Type)0) ? 1249293554u : 878441721u) ^ num * 64997452u);
						continue;
					case 6u:
						arg_155_0 = ((this.FieldNumber > 0) ? 416220771u : 1243880467u);
						continue;
					case 7u:
						goto IL_199;
					case 8u:
						arg_155_0 = (((proto.OneofIndex < parent.Proto.OneofDecl.Count) ? 3890232560u : 2326943442u) ^ num * 1872585197u);
						continue;
					case 9u:
						this.fieldType = FieldDescriptor.GetFieldTypeFromProtoType(proto.Type);
						arg_155_0 = (num * 2182631442u ^ 3138733388u);
						continue;
					case 10u:
						goto IL_1AA;
					case 11u:
						this.containingType = parent;
						arg_155_0 = 1386389043u;
						continue;
					}
					goto Block_6;
				}
			}
			Block_6:
			goto IL_1CF;
			IL_199:
			throw new DescriptorValidationException(this, Module.smethod_33<string>(1349002182u));
			IL_1AA:
			throw new DescriptorValidationException(this, FieldDescriptor.smethod_0(Module.smethod_37<string>(3181016348u), new object[]
			{
				parent.Name
			}));
			IL_1CF:
			file.DescriptorPool.AddSymbol(this);
			this.propertyName = propertyName;
		}

		private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type)
		{
			switch (type)
			{
			case FieldDescriptorProto.Types.Type.TYPE_DOUBLE:
				break;
			case FieldDescriptorProto.Types.Type.TYPE_FLOAT:
				return FieldType.Float;
			case FieldDescriptorProto.Types.Type.TYPE_INT64:
				return FieldType.Int64;
			case FieldDescriptorProto.Types.Type.TYPE_UINT64:
				return FieldType.UInt64;
			case FieldDescriptorProto.Types.Type.TYPE_INT32:
				return FieldType.Int32;
			case FieldDescriptorProto.Types.Type.TYPE_FIXED64:
				return FieldType.Fixed64;
			case FieldDescriptorProto.Types.Type.TYPE_FIXED32:
				return FieldType.Fixed32;
			case FieldDescriptorProto.Types.Type.TYPE_BOOL:
				return FieldType.Bool;
			case FieldDescriptorProto.Types.Type.TYPE_STRING:
				return FieldType.String;
			case FieldDescriptorProto.Types.Type.TYPE_GROUP:
				return FieldType.Group;
			case FieldDescriptorProto.Types.Type.TYPE_MESSAGE:
				return FieldType.Message;
			case FieldDescriptorProto.Types.Type.TYPE_BYTES:
				return FieldType.Bytes;
			case FieldDescriptorProto.Types.Type.TYPE_UINT32:
				return FieldType.UInt32;
			case FieldDescriptorProto.Types.Type.TYPE_ENUM:
				return FieldType.Enum;
			case FieldDescriptorProto.Types.Type.TYPE_SFIXED32:
				return FieldType.SFixed32;
			case FieldDescriptorProto.Types.Type.TYPE_SFIXED64:
				return FieldType.SFixed64;
			case FieldDescriptorProto.Types.Type.TYPE_SINT32:
				return FieldType.SInt32;
			case FieldDescriptorProto.Types.Type.TYPE_SINT64:
				return FieldType.SInt64;
			default:
				while (true)
				{
					IL_C5:
					uint arg_64_0 = 119551694u;
					while (true)
					{
						uint num;
						switch ((num = (arg_64_0 ^ 754523646u)) % 21u)
						{
						case 0u:
							return FieldType.Double;
						case 1u:
							return FieldType.SFixed64;
						case 2u:
							return FieldType.UInt64;
						case 3u:
							return FieldType.Enum;
						case 4u:
							return FieldType.Int64;
						case 5u:
							return FieldType.Int32;
						case 6u:
							goto IL_C5;
						case 7u:
							return FieldType.String;
						case 8u:
							return FieldType.Float;
						case 9u:
							return FieldType.Fixed64;
						case 10u:
							return FieldType.Message;
						case 11u:
							return FieldType.UInt32;
						case 12u:
							return FieldType.Bool;
						case 13u:
							return FieldType.Fixed32;
						case 15u:
							return FieldType.SInt64;
						case 16u:
							return FieldType.Bytes;
						case 17u:
							return FieldType.SInt32;
						case 18u:
							arg_64_0 = (num * 926929353u ^ 3080129912u);
							continue;
						case 19u:
							return FieldType.SFixed32;
						case 20u:
							return FieldType.Group;
						}
						goto Block_2;
					}
				}
				Block_2:
				throw FieldDescriptor.smethod_1(Module.smethod_37<string>(2772032189u));
			}
			return FieldType.Double;
		}

		public int CompareTo(FieldDescriptor other)
		{
			if (other.containingType != this.containingType)
			{
				throw FieldDescriptor.smethod_1(Module.smethod_35<string>(4167100992u));
			}
			return this.FieldNumber - other.FieldNumber;
		}

		internal void CrossLink()
		{
			if (FieldDescriptor.smethod_3(this.Proto.TypeName, ""))
			{
				goto IL_191;
			}
			goto IL_3CA;
			uint arg_333_0;
			while (true)
			{
				IL_32E:
				uint num;
				switch ((num = (arg_333_0 ^ 3013306013u)) % 30u)
				{
				case 0u:
				{
					IDescriptor descriptor;
					arg_333_0 = ((descriptor is EnumDescriptor) ? 2821381071u : 2537082698u);
					continue;
				}
				case 1u:
					arg_333_0 = (((!FieldDescriptor.smethod_3(this.Proto.DefaultValue, "")) ? 3504232881u : 4081425330u) ^ num * 3450336043u);
					continue;
				case 2u:
				{
					IDescriptor descriptor;
					this.messageType = (MessageDescriptor)descriptor;
					arg_333_0 = 4036915674u;
					continue;
				}
				case 3u:
				{
					IDescriptor descriptor = base.File.DescriptorPool.LookupSymbol(this.Proto.TypeName, this);
					arg_333_0 = (num * 1137267228u ^ 1800642603u);
					continue;
				}
				case 4u:
					arg_333_0 = (((this.Proto.Type != (FieldDescriptorProto.Types.Type)0) ? 3944142871u : 3881033019u) ^ num * 2947199265u);
					continue;
				case 5u:
					arg_333_0 = (num * 3768717094u ^ 4265278771u);
					continue;
				case 6u:
					goto IL_3D9;
				case 7u:
					this.fieldType = FieldType.Message;
					arg_333_0 = (num * 2040762779u ^ 2945237881u);
					continue;
				case 8u:
					arg_333_0 = (((this.fieldType != FieldType.Enum) ? 4206089270u : 4050017104u) ^ num * 2028914515u);
					continue;
				case 9u:
				{
					IDescriptor descriptor;
					arg_333_0 = (((!(descriptor is EnumDescriptor)) ? 2973306776u : 2993182602u) ^ num * 1211533732u);
					continue;
				}
				case 10u:
					this.fieldType = FieldType.Enum;
					arg_333_0 = (num * 335191304u ^ 978261121u);
					continue;
				case 11u:
					goto IL_3EA;
				case 12u:
				{
					IDescriptor descriptor;
					arg_333_0 = (((descriptor is MessageDescriptor) ? 1340053915u : 1990891018u) ^ num * 3272437084u);
					continue;
				}
				case 13u:
					goto IL_3FB;
				case 14u:
					goto IL_425;
				case 15u:
					goto IL_436;
				case 16u:
					goto IL_191;
				case 17u:
				{
					IDescriptor descriptor;
					this.enumType = (EnumDescriptor)descriptor;
					arg_333_0 = 4053406812u;
					continue;
				}
				case 18u:
					this.accessor = this.CreateAccessor(this.propertyName);
					arg_333_0 = 3795529724u;
					continue;
				case 19u:
					goto IL_447;
				case 20u:
					arg_333_0 = ((this.fieldType != FieldType.Message) ? 2460784210u : 3995577395u);
					continue;
				case 22u:
					arg_333_0 = (((this.containingType.Proto.Options == null) ? 419873589u : 668635125u) ^ num * 1090866907u);
					continue;
				case 23u:
					arg_333_0 = (((this.containingType != null) ? 572724748u : 1874315500u) ^ num * 1436619519u);
					continue;
				case 24u:
				{
					IDescriptor descriptor;
					arg_333_0 = (((!(descriptor is MessageDescriptor)) ? 471649775u : 1414817504u) ^ num * 4283271988u);
					continue;
				}
				case 25u:
					arg_333_0 = ((this.fieldType != FieldType.Enum) ? 2708078287u : 4205631964u);
					continue;
				case 26u:
					goto IL_3CA;
				case 27u:
					goto IL_471;
				case 28u:
					arg_333_0 = ((this.containingType.Proto.Options.MessageSetWireFormat ? 288763958u : 1623010749u) ^ num * 3306098553u);
					continue;
				case 29u:
					base.File.DescriptorPool.AddFieldByNumber(this);
					arg_333_0 = 2913542014u;
					continue;
				}
				break;
			}
			return;
			IL_3D9:
			throw new DescriptorValidationException(this, Module.smethod_33<string>(1009936473u));
			IL_3EA:
			throw new DescriptorValidationException(this, Module.smethod_37<string>(3005745843u));
			IL_3FB:
			throw new DescriptorValidationException(this, FieldDescriptor.smethod_0(Module.smethod_33<string>(3783798939u), new object[]
			{
				this.Proto.TypeName
			}));
			IL_425:
			throw new DescriptorValidationException(this, Module.smethod_33<string>(306987899u));
			IL_436:
			throw new DescriptorValidationException(this, Module.smethod_37<string>(785259833u));
			IL_447:
			throw new DescriptorValidationException(this, FieldDescriptor.smethod_0(Module.smethod_33<string>(2096439923u), new object[]
			{
				this.Proto.TypeName
			}));
			IL_471:
			throw new DescriptorValidationException(this, FieldDescriptor.smethod_0(Module.smethod_37<string>(1924739148u), new object[]
			{
				this.Proto.TypeName
			}));
			IL_191:
			arg_333_0 = 2419306412u;
			goto IL_32E;
			IL_3CA:
			arg_333_0 = ((this.fieldType == FieldType.Message) ? 4199521082u : 2785444915u);
			goto IL_32E;
		}

		private IFieldAccessor CreateAccessor(string propertyName)
		{
			if (propertyName == null)
			{
				goto IL_06;
			}
			goto IL_E4;
			uint arg_A7_0;
			PropertyInfo property;
			IFieldAccessor result;
			while (true)
			{
				IL_A2:
				uint num;
				switch ((num = (arg_A7_0 ^ 2720568274u)) % 12u)
				{
				case 0u:
					arg_A7_0 = ((!this.IsMap) ? 2387454740u : 3727411354u);
					continue;
				case 1u:
					goto IL_FD;
				case 2u:
					result = new RepeatedFieldAccessor(property, this);
					arg_A7_0 = 3190240481u;
					continue;
				case 3u:
					return result;
				case 4u:
					goto IL_101;
				case 5u:
					result = new SingleFieldAccessor(property, this);
					arg_A7_0 = (num * 2866179060u ^ 1427270409u);
					continue;
				case 6u:
					arg_A7_0 = ((this.IsRepeated ? 2767871872u : 3251485679u) ^ num * 2633443800u);
					continue;
				case 7u:
					goto IL_E4;
				case 9u:
					arg_A7_0 = (((property != null) ? 3418836970u : 3324558718u) ^ num * 1433534820u);
					continue;
				case 10u:
					goto IL_06;
				case 11u:
					return result;
				}
				break;
			}
			goto IL_12F;
			IL_FD:
			return null;
			IL_101:
			throw new DescriptorValidationException(this, FieldDescriptor.smethod_0(Module.smethod_37<string>(814437201u), new object[]
			{
				propertyName,
				this.containingType.ClrType
			}));
			IL_12F:
			result = new MapFieldAccessor(property, this);
			return result;
			IL_06:
			arg_A7_0 = 2372915079u;
			goto IL_A2;
			IL_E4:
			property = this.containingType.ClrType.GetProperty(propertyName);
			arg_A7_0 = 4205391919u;
			goto IL_A2;
		}

		static string smethod_0(string string_0, object[] object_0)
		{
			return string.Format(string_0, object_0);
		}

		static ArgumentException smethod_1(string string_0)
		{
			return new ArgumentException(string_0);
		}

		static InvalidOperationException smethod_2(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static bool smethod_3(string string_0, string string_1)
		{
			return string_0 != string_1;
		}
	}
}
