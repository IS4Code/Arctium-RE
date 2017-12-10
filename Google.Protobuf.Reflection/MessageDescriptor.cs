using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class MessageDescriptor : DescriptorBase
	{
		public sealed class FieldCollection
		{
			private readonly MessageDescriptor messageDescriptor;

			public FieldDescriptor this[int number]
			{
				get
				{
					FieldDescriptor expr_0C = this.messageDescriptor.FindFieldByNumber(number);
					if (expr_0C == null)
					{
						throw MessageDescriptor.FieldCollection.smethod_0(Module.smethod_35<string>(3970532378u));
					}
					return expr_0C;
				}
			}

			public FieldDescriptor this[string name]
			{
				get
				{
					FieldDescriptor expr_0C = this.messageDescriptor.FindFieldByName(name);
					if (expr_0C == null)
					{
						throw MessageDescriptor.FieldCollection.smethod_0(Module.smethod_34<string>(2081293231u));
					}
					return expr_0C;
				}
			}

			internal FieldCollection(MessageDescriptor messageDescriptor)
			{
				while (true)
				{
					IL_39:
					uint arg_21_0 = 2890426633u;
					while (true)
					{
						uint num;
						switch ((num = (arg_21_0 ^ 2290670412u)) % 3u)
						{
						case 0u:
							goto IL_39;
						case 1u:
							this.messageDescriptor = messageDescriptor;
							arg_21_0 = (num * 4117989716u ^ 4051887557u);
							continue;
						}
						return;
					}
				}
			}

			public IList<FieldDescriptor> InDeclarationOrder()
			{
				return this.messageDescriptor.fieldsInDeclarationOrder;
			}

			public IList<FieldDescriptor> InFieldNumberOrder()
			{
				return this.messageDescriptor.fieldsInNumberOrder;
			}

			internal IDictionary<string, FieldDescriptor> ByJsonName()
			{
				return this.messageDescriptor.jsonFieldMap;
			}

			static KeyNotFoundException smethod_0(string string_0)
			{
				return new KeyNotFoundException(string_0);
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MessageDescriptor.__c __9 = new MessageDescriptor.__c();

			public static Func<FieldDescriptor, int> __9__4_4;

			public static Func<FieldDescriptor, string> __9__4_5;

			internal int ctor>b__4_4(FieldDescriptor field)
			{
				return field.FieldNumber;
			}

			internal string ctor>b__4_5(FieldDescriptor field)
			{
				return JsonFormatter.ToCamelCase(field.Name);
			}
		}

		private static readonly HashSet<string> WellKnownTypeNames = new HashSet<string>
		{
			Module.smethod_33<string>(1785015754u),
			Module.smethod_34<string>(2015219986u),
			Module.smethod_37<string>(989619293u),
			Module.smethod_34<string>(1292990457u),
			Module.smethod_33<string>(807162649u),
			Module.smethod_34<string>(1480463681u),
			Module.smethod_34<string>(3740888880u),
			Module.smethod_35<string>(2123889868u),
			Module.smethod_36<string>(1377924986u),
			Module.smethod_36<string>(1181098354u)
		};

		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder;

		private readonly IList<FieldDescriptor> fieldsInNumberOrder;

		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap;

		public override string Name
		{
			get
			{
				return this.Proto.Name;
			}
		}

		internal DescriptorProto Proto
		{
			[CompilerGenerated]
			get
			{
				return this.<Proto>k__BackingField;
			}
		}

		public Type ClrType
		{
			[CompilerGenerated]
			get
			{
				return this.<ClrType>k__BackingField;
			}
		}

		public MessageParser Parser
		{
			[CompilerGenerated]
			get
			{
				return this.<Parser>k__BackingField;
			}
		}

		internal bool IsWellKnownType
		{
			get
			{
				return MessageDescriptor.smethod_0(base.File.Package, Module.smethod_36<string>(3105684599u)) && MessageDescriptor.WellKnownTypeNames.Contains(base.File.Name);
			}
		}

		internal bool IsWrapperType
		{
			get
			{
				return MessageDescriptor.smethod_0(base.File.Package, Module.smethod_37<string>(2070655459u)) && MessageDescriptor.smethod_0(base.File.Name, Module.smethod_34<string>(4237235307u));
			}
		}

		public MessageDescriptor ContainingType
		{
			[CompilerGenerated]
			get
			{
				return this.<ContainingType>k__BackingField;
			}
		}

		public MessageDescriptor.FieldCollection Fields
		{
			[CompilerGenerated]
			get
			{
				return this.Fieldsk__BackingField;
			}
		}

		public IList<MessageDescriptor> NestedTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<NestedTypes>k__BackingField;
			}
		}

		public IList<EnumDescriptor> EnumTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<EnumTypes>k__BackingField;
			}
		}

		public IList<OneofDescriptor> Oneofs
		{
			[CompilerGenerated]
			get
			{
				return this.<Oneofs>k__BackingField;
			}
		}

		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedCodeInfo generatedCodeInfo) : base(file, file.ComputeFullName(parent, proto.Name), typeIndex)
		{
			MessageDescriptor __4__this;
			while (true)
			{
				IL_247:
				uint arg_20A_0 = 4043199534u;
				while (true)
				{
					uint num;
					switch ((num = (arg_20A_0 ^ 3788346645u)) % 12u)
					{
					case 0u:
						this.<ContainingType>k__BackingField = parent;
						arg_20A_0 = (num * 1002898729u ^ 1601684763u);
						continue;
					case 1u:
					{
						GeneratedCodeInfo expr_1D9 = generatedCodeInfo;
						this.<Parser>k__BackingField = ((expr_1D9 != null) ? expr_1D9.Parser : null);
						arg_20A_0 = 2694476678u;
						continue;
					}
					case 2u:
						file.DescriptorPool.AddSymbol(this);
						this.Fieldsk__BackingField = new MessageDescriptor.FieldCollection(this);
						arg_20A_0 = (num * 174268781u ^ 339015310u);
						continue;
					case 3u:
						goto IL_247;
					case 4u:
						this.<NestedTypes>k__BackingField = DescriptorUtil.ConvertAndMakeReadOnly<DescriptorProto, MessageDescriptor>(proto.NestedType, (DescriptorProto type, int index) => new MessageDescriptor(type, file, __4__this, index, generatedCodeInfo.NestedTypes[index]));
						arg_20A_0 = (num * 1204710165u ^ 359963217u);
						continue;
					case 5u:
					{
						IEnumerable<FieldDescriptor> arg_161_0 = this.fieldsInNumberOrder;
						Func<FieldDescriptor, string> arg_161_1;
						if ((arg_161_1 = MessageDescriptor.__c.__9__4_5) == null)
						{
							arg_161_1 = (MessageDescriptor.__c.__9__4_5 = new Func<FieldDescriptor, string>(MessageDescriptor.__c.__9.<.ctor>b__4_5));
						}
						this.jsonFieldMap = new ReadOnlyDictionary<string, FieldDescriptor>(arg_161_0.ToDictionary(arg_161_1));
						arg_20A_0 = 3491112463u;
						continue;
					}
					case 6u:
					{
						this.fieldsInDeclarationOrder = DescriptorUtil.ConvertAndMakeReadOnly<FieldDescriptorProto, FieldDescriptor>(proto.Field, delegate(FieldDescriptorProto field, int index)
						{
							FileDescriptor arg_26_1 = file;
							MessageDescriptor arg_26_2 = __4__this;
							GeneratedCodeInfo expr_14 = generatedCodeInfo;
							return new FieldDescriptor(field, arg_26_1, arg_26_2, index, (expr_14 != null) ? expr_14.PropertyNames[index] : null);
						});
						IEnumerable<FieldDescriptor> arg_11D_0 = this.fieldsInDeclarationOrder;
						Func<FieldDescriptor, int> arg_11D_1;
						if ((arg_11D_1 = MessageDescriptor.__c.__9__4_4) == null)
						{
							arg_11D_1 = (MessageDescriptor.__c.__9__4_4 = new Func<FieldDescriptor, int>(MessageDescriptor.__c.__9.<.ctor>b__4_4));
						}
						this.fieldsInNumberOrder = new ReadOnlyCollection<FieldDescriptor>(arg_11D_0.OrderBy(arg_11D_1).ToArray<FieldDescriptor>());
						arg_20A_0 = 2414391428u;
						continue;
					}
					case 7u:
					{
						GeneratedCodeInfo expr_BF = generatedCodeInfo;
						this.<ClrType>k__BackingField = ((expr_BF != null) ? expr_BF.ClrType : null);
						arg_20A_0 = 3870743541u;
						continue;
					}
					case 8u:
						this.<EnumTypes>k__BackingField = DescriptorUtil.ConvertAndMakeReadOnly<EnumDescriptorProto, EnumDescriptor>(proto.EnumType, (EnumDescriptorProto type, int index) => new EnumDescriptor(type, file, __4__this, index, generatedCodeInfo.NestedEnums[index]));
						arg_20A_0 = (num * 3914277205u ^ 2964567391u);
						continue;
					case 10u:
						this.<Oneofs>k__BackingField = DescriptorUtil.ConvertAndMakeReadOnly<OneofDescriptorProto, OneofDescriptor>(proto.OneofDecl, (OneofDescriptorProto oneof, int index) => new OneofDescriptor(oneof, file, __4__this, index, generatedCodeInfo.OneofNames[index]));
						arg_20A_0 = (num * 3879854900u ^ 3765292269u);
						continue;
					case 11u:
						__4__this = this;
						this.<Proto>k__BackingField = proto;
						arg_20A_0 = (num * 1105444768u ^ 1991989292u);
						continue;
					}
					return;
				}
			}
		}

		public FieldDescriptor FindFieldByName(string name)
		{
			return base.File.DescriptorPool.FindSymbol<FieldDescriptor>(MessageDescriptor.smethod_1(base.FullName, Module.smethod_34<string>(3349943853u), name));
		}

		public FieldDescriptor FindFieldByNumber(int number)
		{
			return base.File.DescriptorPool.FindFieldByNumber(this, number);
		}

		public T FindDescriptor<T>(string name) where T : class, IDescriptor
		{
			return base.File.DescriptorPool.FindSymbol<T>(MessageDescriptor.smethod_1(base.FullName, Module.smethod_37<string>(3886401134u), name));
		}

		internal void CrossLink()
		{
			IEnumerator<MessageDescriptor> enumerator = this.NestedTypes.GetEnumerator();
			try
			{
				while (true)
				{
					IL_60:
					int arg_38_0 = MessageDescriptor.smethod_2(enumerator) ? 1134616046 : 1843708573;
					while (true)
					{
						switch ((arg_38_0 ^ 29679423) % 4)
						{
						case 0:
							goto IL_60;
						case 1:
							enumerator.Current.CrossLink();
							arg_38_0 = 375820175;
							continue;
						case 3:
							arg_38_0 = 1134616046;
							continue;
						}
						goto Block_5;
					}
				}
				Block_5:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_A1:
						uint arg_89_0 = 868083471u;
						while (true)
						{
							uint num;
							switch ((num = (arg_89_0 ^ 29679423u)) % 3u)
							{
							case 0u:
								goto IL_A1;
							case 2u:
								MessageDescriptor.smethod_3(enumerator);
								arg_89_0 = (num * 1785932764u ^ 2171121617u);
								continue;
							}
							goto Block_9;
						}
					}
					Block_9:;
				}
			}
			IEnumerator<FieldDescriptor> enumerator2 = this.fieldsInDeclarationOrder.GetEnumerator();
			try
			{
				while (true)
				{
					IL_109:
					int arg_E1_0 = (!MessageDescriptor.smethod_2(enumerator2)) ? 2106707788 : 1471015578;
					while (true)
					{
						switch ((arg_E1_0 ^ 29679423) % 4)
						{
						case 0:
							arg_E1_0 = 1471015578;
							continue;
						case 1:
							enumerator2.Current.CrossLink();
							arg_E1_0 = 2049388989;
							continue;
						case 2:
							goto IL_109;
						}
						goto Block_11;
					}
				}
				Block_11:;
			}
			finally
			{
				if (enumerator2 != null)
				{
					while (true)
					{
						IL_14A:
						uint arg_132_0 = 1386396480u;
						while (true)
						{
							uint num;
							switch ((num = (arg_132_0 ^ 29679423u)) % 3u)
							{
							case 0u:
								goto IL_14A;
							case 1u:
								MessageDescriptor.smethod_3(enumerator2);
								arg_132_0 = (num * 3884617075u ^ 2615629246u);
								continue;
							}
							goto Block_15;
						}
					}
					Block_15:;
				}
			}
			IEnumerator<OneofDescriptor> enumerator3 = this.Oneofs.GetEnumerator();
			try
			{
				while (true)
				{
					IL_1B2:
					int arg_18A_0 = MessageDescriptor.smethod_2(enumerator3) ? 454722637 : 1116807928;
					while (true)
					{
						switch ((arg_18A_0 ^ 29679423) % 4)
						{
						case 0:
							arg_18A_0 = 454722637;
							continue;
						case 1:
							goto IL_1B2;
						case 2:
							enumerator3.Current.CrossLink();
							arg_18A_0 = 1470632970;
							continue;
						}
						goto Block_17;
					}
				}
				Block_17:;
			}
			finally
			{
				if (enumerator3 != null)
				{
					while (true)
					{
						IL_1F3:
						uint arg_1DB_0 = 2079469540u;
						while (true)
						{
							uint num;
							switch ((num = (arg_1DB_0 ^ 29679423u)) % 3u)
							{
							case 0u:
								goto IL_1F3;
							case 2u:
								MessageDescriptor.smethod_3(enumerator3);
								arg_1DB_0 = (num * 2939956246u ^ 1130673756u);
								continue;
							}
							goto Block_21;
						}
					}
					Block_21:;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static string smethod_1(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}

		static bool smethod_2(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_3(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}
	}
}
