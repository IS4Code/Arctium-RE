using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class ServiceDescriptor : DescriptorBase
	{
		private readonly ServiceDescriptorProto proto;

		private readonly IList<MethodDescriptor> methods;

		public override string Name
		{
			get
			{
				return this.proto.Name;
			}
		}

		internal ServiceDescriptorProto Proto
		{
			get
			{
				return this.proto;
			}
		}

		public IList<MethodDescriptor> Methods
		{
			get
			{
				return this.methods;
			}
		}

		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index) : base(file, file.ComputeFullName(null, proto.Name), index)
		{
			ServiceDescriptor __4__this = this;
			this.proto = proto;
			this.methods = DescriptorUtil.ConvertAndMakeReadOnly<MethodDescriptorProto, MethodDescriptor>(proto.Method, (MethodDescriptorProto method, int i) => new MethodDescriptor(method, file, __4__this, i));
			file.DescriptorPool.AddSymbol(this);
		}

		public MethodDescriptor FindMethodByName(string name)
		{
			return base.File.DescriptorPool.FindSymbol<MethodDescriptor>(ServiceDescriptor.smethod_0(base.FullName, Module.smethod_37<string>(3886401134u), name));
		}

		internal void CrossLink()
		{
			IEnumerator<MethodDescriptor> enumerator = this.methods.GetEnumerator();
			try
			{
				while (true)
				{
					IL_60:
					int arg_38_0 = ServiceDescriptor.smethod_1(enumerator) ? -766175278 : -1943296255;
					while (true)
					{
						switch ((arg_38_0 ^ -691578849) % 4)
						{
						case 0:
							goto IL_60;
						case 1:
							enumerator.Current.CrossLink();
							arg_38_0 = -172422773;
							continue;
						case 3:
							arg_38_0 = -766175278;
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_A1:
						uint arg_89_0 = 2295009578u;
						while (true)
						{
							uint num;
							switch ((num = (arg_89_0 ^ 3603388447u)) % 3u)
							{
							case 0u:
								goto IL_A1;
							case 1u:
								ServiceDescriptor.smethod_2(enumerator);
								arg_89_0 = (num * 898590588u ^ 3854439035u);
								continue;
							}
							goto Block_7;
						}
					}
					Block_7:;
				}
			}
		}

		static string smethod_0(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}

		static bool smethod_1(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_2(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}
	}
}
