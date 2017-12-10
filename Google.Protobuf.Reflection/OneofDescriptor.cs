using Google.Protobuf.Compatibility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class OneofDescriptor : DescriptorBase
	{
		private readonly OneofDescriptorProto proto;

		private MessageDescriptor containingType;

		private IList<FieldDescriptor> fields;

		private readonly OneofAccessor accessor;

		public override string Name
		{
			get
			{
				return this.proto.Name;
			}
		}

		public MessageDescriptor ContainingType
		{
			get
			{
				return this.containingType;
			}
		}

		public IList<FieldDescriptor> Fields
		{
			get
			{
				return this.fields;
			}
		}

		public OneofAccessor Accessor
		{
			get
			{
				return this.accessor;
			}
		}

		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName) : base(file, file.ComputeFullName(parent, proto.Name), index)
		{
			while (true)
			{
				IL_63:
				uint arg_47_0 = 2329051274u;
				while (true)
				{
					uint num;
					switch ((num = (arg_47_0 ^ 3026981471u)) % 4u)
					{
					case 0u:
						goto IL_63;
					case 1u:
						this.proto = proto;
						arg_47_0 = (num * 378117375u ^ 1534672859u);
						continue;
					case 3u:
						this.containingType = parent;
						arg_47_0 = (num * 4267417022u ^ 3727843631u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			file.DescriptorPool.AddSymbol(this);
			this.accessor = this.CreateAccessor(clrName);
		}

		internal void CrossLink()
		{
			List<FieldDescriptor> list = new List<FieldDescriptor>();
			IEnumerator<FieldDescriptor> enumerator = this.ContainingType.Fields.InDeclarationOrder().GetEnumerator();
			try
			{
				while (true)
				{
					IL_A4:
					uint arg_78_0 = OneofDescriptor.smethod_0(enumerator) ? 645945303u : 1779362706u;
					while (true)
					{
						uint num;
						switch ((num = (arg_78_0 ^ 1929289758u)) % 5u)
						{
						case 0u:
						{
							FieldDescriptor current;
							list.Add(current);
							arg_78_0 = (num * 2160487366u ^ 3013554972u);
							continue;
						}
						case 1u:
							goto IL_A4;
						case 2u:
							arg_78_0 = 645945303u;
							continue;
						case 3u:
						{
							FieldDescriptor current = enumerator.Current;
							arg_78_0 = ((current.ContainingOneof != this) ? 607704728u : 324701640u);
							continue;
						}
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_E8:
						uint arg_D0_0 = 327623526u;
						while (true)
						{
							uint num;
							switch ((num = (arg_D0_0 ^ 1929289758u)) % 3u)
							{
							case 1u:
								OneofDescriptor.smethod_1(enumerator);
								arg_D0_0 = (num * 1913406752u ^ 3932505543u);
								continue;
							case 2u:
								goto IL_E8;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
			this.fields = new ReadOnlyCollection<FieldDescriptor>(list);
		}

		private OneofAccessor CreateAccessor(string clrName)
		{
			PropertyInfo property = this.containingType.ClrType.GetProperty(OneofDescriptor.smethod_2(clrName, Module.smethod_33<string>(199749746u)));
			if (property == null)
			{
				goto IL_4A;
			}
			goto IL_7B;
			uint arg_54_0;
			MethodInfo method;
			while (true)
			{
				IL_4F:
				uint num;
				switch ((num = (arg_54_0 ^ 270247863u)) % 6u)
				{
				case 0u:
					goto IL_4A;
				case 1u:
					goto IL_7B;
				case 3u:
					goto IL_A3;
				case 4u:
					arg_54_0 = (((method == null) ? 2794963222u : 2408756909u) ^ num * 4080221847u);
					continue;
				case 5u:
					goto IL_D1;
				}
				break;
			}
			goto IL_FF;
			IL_A3:
			throw new DescriptorValidationException(this, OneofDescriptor.smethod_3(Module.smethod_35<string>(403167680u), new object[]
			{
				clrName,
				this.containingType.ClrType
			}));
			IL_D1:
			throw new DescriptorValidationException(this, OneofDescriptor.smethod_3(Module.smethod_36<string>(3684424959u), new object[]
			{
				clrName,
				this.containingType.ClrType
			}));
			IL_FF:
			return new OneofAccessor(property, method, this);
			IL_4A:
			arg_54_0 = 334375866u;
			goto IL_4F;
			IL_7B:
			method = this.containingType.ClrType.GetMethod(OneofDescriptor.smethod_2(Module.smethod_33<string>(2372756646u), clrName));
			arg_54_0 = 2031678099u;
			goto IL_4F;
		}

		static bool smethod_0(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_1(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static string smethod_2(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static string smethod_3(string string_0, object[] object_0)
		{
			return string.Format(string_0, object_0);
		}
	}
}
