using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class FileDescriptor : IDescriptor
	{
		internal FileDescriptorProto Proto
		{
			[CompilerGenerated]
			get
			{
				return this.<Proto>k__BackingField;
			}
		}

		public string Name
		{
			get
			{
				return this.Proto.Name;
			}
		}

		public string Package
		{
			get
			{
				return this.Proto.Package;
			}
		}

		public IList<MessageDescriptor> MessageTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<MessageTypes>k__BackingField;
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

		public IList<ServiceDescriptor> Services
		{
			[CompilerGenerated]
			get
			{
				return this.<Services>k__BackingField;
			}
		}

		public IList<FileDescriptor> Dependencies
		{
			[CompilerGenerated]
			get
			{
				return this.<Dependencies>k__BackingField;
			}
		}

		public IList<FileDescriptor> PublicDependencies
		{
			[CompilerGenerated]
			get
			{
				return this.<PublicDependencies>k__BackingField;
			}
		}

		public ByteString SerializedData
		{
			[CompilerGenerated]
			get
			{
				return this.<SerializedData>k__BackingField;
			}
		}

		string IDescriptor.FullName
		{
			get
			{
				return this.Name;
			}
		}

		FileDescriptor IDescriptor.File
		{
			get
			{
				return this;
			}
		}

		internal DescriptorPool DescriptorPool
		{
			[CompilerGenerated]
			get
			{
				return this.<DescriptorPool>k__BackingField;
			}
		}

		public static FileDescriptor DescriptorProtoFileDescriptor
		{
			get
			{
				return DescriptorReflection.Descriptor;
			}
		}

		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedCodeInfo generatedCodeInfo)
		{
			FileDescriptor __4__this;
			while (true)
			{
				IL_113:
				uint arg_E7_0 = 3109136426u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E7_0 ^ 2557234891u)) % 8u)
					{
					case 0u:
						pool.AddPackage(this.Package, this);
						arg_E7_0 = (num * 1105332455u ^ 1354664894u);
						continue;
					case 1u:
						__4__this = this;
						arg_E7_0 = (num * 4125576103u ^ 2241118048u);
						continue;
					case 2u:
						this.<Dependencies>k__BackingField = new ReadOnlyCollection<FileDescriptor>((FileDescriptor[])FileDescriptor.smethod_0(dependencies));
						this.<PublicDependencies>k__BackingField = FileDescriptor.DeterminePublicDependencies(this, proto, dependencies, allowUnknownDependencies);
						arg_E7_0 = (num * 2070285500u ^ 1583842795u);
						continue;
					case 3u:
						goto IL_113;
					case 4u:
						this.<SerializedData>k__BackingField = descriptorData;
						arg_E7_0 = (num * 559784837u ^ 3768172688u);
						continue;
					case 5u:
						this.<MessageTypes>k__BackingField = DescriptorUtil.ConvertAndMakeReadOnly<DescriptorProto, MessageDescriptor>(proto.MessageType, (DescriptorProto message, int index) => new MessageDescriptor(message, __4__this, null, index, generatedCodeInfo.NestedTypes[index]));
						arg_E7_0 = (num * 3261531694u ^ 3702070131u);
						continue;
					case 7u:
						this.<DescriptorPool>k__BackingField = pool;
						this.<Proto>k__BackingField = proto;
						arg_E7_0 = (num * 2550378934u ^ 3723757811u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.<EnumTypes>k__BackingField = DescriptorUtil.ConvertAndMakeReadOnly<EnumDescriptorProto, EnumDescriptor>(proto.EnumType, (EnumDescriptorProto enumType, int index) => new EnumDescriptor(enumType, __4__this, null, index, generatedCodeInfo.NestedEnums[index]));
			this.<Services>k__BackingField = DescriptorUtil.ConvertAndMakeReadOnly<ServiceDescriptorProto, ServiceDescriptor>(proto.Service, (ServiceDescriptorProto service, int index) => new ServiceDescriptor(service, this, index));
		}

		internal string ComputeFullName(MessageDescriptor parent, string name)
		{
			if (parent == null)
			{
				goto IL_46;
			}
			IL_12:
			int arg_1C_0 = -1406984416;
			IL_17:
			switch ((arg_1C_0 ^ -1811609614) % 5)
			{
			case 0:
				IL_46:
				arg_1C_0 = ((FileDescriptor.smethod_2(this.Package) <= 0) ? -1756364047 : -1888255348);
				goto IL_17;
			case 2:
				goto IL_12;
			case 3:
				return FileDescriptor.smethod_1(parent.FullName, Module.smethod_36<string>(1323488018u), name);
			case 4:
				return FileDescriptor.smethod_1(this.Package, Module.smethod_37<string>(3886401134u), name);
			}
			return name;
		}

		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies)
		{
			Dictionary<string, FileDescriptor> dictionary = new Dictionary<string, FileDescriptor>();
			List<FileDescriptor> list;
			string text;
			while (true)
			{
				IL_25F:
				uint arg_1FD_0 = 1480753851u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1FD_0 ^ 354656998u)) % 21u)
					{
					case 0u:
					{
						int num2;
						arg_1FD_0 = ((num2 < dependencies.Length) ? 755598000u : 1625878074u);
						continue;
					}
					case 1u:
					{
						FileDescriptor fileDescriptor;
						arg_1FD_0 = (((fileDescriptor != null) ? 3503588187u : 2689291383u) ^ num * 269180022u);
						continue;
					}
					case 2u:
						arg_1FD_0 = (num * 1428810503u ^ 597188103u);
						continue;
					case 3u:
					{
						int num2;
						num2++;
						arg_1FD_0 = (num * 4026010881u ^ 1873699178u);
						continue;
					}
					case 4u:
					{
						list = new List<FileDescriptor>();
						int num3 = 0;
						arg_1FD_0 = (num * 172851441u ^ 2057392629u);
						continue;
					}
					case 5u:
					{
						int num4;
						text = proto.Dependency[num4];
						arg_1FD_0 = 1182864162u;
						continue;
					}
					case 6u:
					{
						int num4;
						arg_1FD_0 = (((num4 < proto.Dependency.Count) ? 199583157u : 1553389033u) ^ num * 904630291u);
						continue;
					}
					case 7u:
					{
						int num2 = 0;
						arg_1FD_0 = (num * 2059016605u ^ 2886768975u);
						continue;
					}
					case 8u:
					{
						FileDescriptor fileDescriptor2;
						dictionary[fileDescriptor2.Name] = fileDescriptor2;
						arg_1FD_0 = (num * 2415469140u ^ 158078469u);
						continue;
					}
					case 9u:
					{
						FileDescriptor fileDescriptor = dictionary[text];
						arg_1FD_0 = (num * 1703034579u ^ 4134718755u);
						continue;
					}
					case 10u:
					{
						int num3;
						num3++;
						arg_1FD_0 = 1400639947u;
						continue;
					}
					case 11u:
						goto IL_266;
					case 13u:
						goto IL_277;
					case 14u:
					{
						int num3;
						int num4 = proto.PublicDependency[num3];
						arg_1FD_0 = ((num4 < 0) ? 43381538u : 749549455u);
						continue;
					}
					case 15u:
						arg_1FD_0 = (num * 1315834947u ^ 1640480294u);
						continue;
					case 16u:
						arg_1FD_0 = (((!allowUnknownDependencies) ? 1742178966u : 1225729944u) ^ num * 865084290u);
						continue;
					case 17u:
					{
						FileDescriptor fileDescriptor;
						list.Add(fileDescriptor);
						arg_1FD_0 = 83744118u;
						continue;
					}
					case 18u:
					{
						int num2;
						FileDescriptor fileDescriptor2 = dependencies[num2];
						arg_1FD_0 = 266579083u;
						continue;
					}
					case 19u:
						goto IL_25F;
					case 20u:
					{
						int num3;
						arg_1FD_0 = ((num3 < proto.PublicDependency.Count) ? 1502489908u : 1152782524u);
						continue;
					}
					}
					goto Block_7;
				}
			}
			Block_7:
			goto IL_28F;
			IL_266:
			throw new DescriptorValidationException(@this, Module.smethod_34<string>(2614455357u));
			IL_277:
			throw new DescriptorValidationException(@this, FileDescriptor.smethod_3(Module.smethod_35<string>(82095339u), text));
			IL_28F:
			return new ReadOnlyCollection<FileDescriptor>(list);
		}

		public T FindTypeByName<T>(string name) where T : class, IDescriptor
		{
			if (FileDescriptor.smethod_4(name, '.') != -1)
			{
				goto IL_49;
			}
			goto IL_FD;
			uint arg_BD_0;
			while (true)
			{
				IL_B8:
				uint num;
				switch ((num = (arg_BD_0 ^ 464370408u)) % 9u)
				{
				case 0u:
				{
					T t;
					arg_BD_0 = (((t.File == this) ? 192187766u : 338264466u) ^ num * 343090665u);
					continue;
				}
				case 2u:
					name = FileDescriptor.smethod_1(this.Package, Module.smethod_36<string>(1323488018u), name);
					arg_BD_0 = (num * 3152909545u ^ 3774283465u);
					continue;
				case 3u:
				{
					T t = this.DescriptorPool.FindSymbol<T>(name);
					arg_BD_0 = 1469809664u;
					continue;
				}
				case 4u:
					goto IL_FD;
				case 5u:
					goto IL_49;
				case 6u:
				{
					T t;
					return t;
				}
				case 7u:
				{
					T t;
					arg_BD_0 = (((t != null) ? 484983571u : 1629139297u) ^ num * 2175120638u);
					continue;
				}
				case 8u:
					goto IL_11C;
				}
				break;
			}
			return default(T);
			IL_11C:
			return default(T);
			IL_49:
			arg_BD_0 = 1699441690u;
			goto IL_B8;
			IL_FD:
			arg_BD_0 = ((FileDescriptor.smethod_2(this.Package) <= 0) ? 1039614224u : 1192626073u);
			goto IL_B8;
		}

		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedCodeInfo generatedCodeInfo)
		{
			if (dependencies == null)
			{
				goto IL_18;
			}
			goto IL_122;
			uint arg_D3_0;
			FileDescriptor fileDescriptor;
			int num2;
			while (true)
			{
				IL_CE:
				uint num;
				switch ((num = (arg_D3_0 ^ 4161713641u)) % 12u)
				{
				case 0u:
					fileDescriptor.CrossLink();
					arg_D3_0 = (num * 1953233347u ^ 2707760628u);
					continue;
				case 1u:
					num2 = 0;
					arg_D3_0 = 2574715432u;
					continue;
				case 2u:
					num2++;
					arg_D3_0 = 4243801185u;
					continue;
				case 3u:
					dependencies = new FileDescriptor[0];
					arg_D3_0 = (num * 3942966366u ^ 4286440245u);
					continue;
				case 4u:
					arg_D3_0 = ((num2 < proto.Dependency.Count) ? 2982469083u : 3757505837u);
					continue;
				case 5u:
					arg_D3_0 = (num * 314203903u ^ 1276877662u);
					continue;
				case 6u:
					arg_D3_0 = ((!FileDescriptor.smethod_5(dependencies[num2].Name, proto.Dependency[num2])) ? 3773742995u : 2893382989u);
					continue;
				case 7u:
					goto IL_18;
				case 8u:
					goto IL_14B;
				case 10u:
					goto IL_122;
				case 11u:
					goto IL_183;
				}
				break;
			}
			return fileDescriptor;
			IL_14B:
			throw new DescriptorValidationException(fileDescriptor, FileDescriptor.smethod_6(Module.smethod_37<string>(2509052754u), proto.Dependency[num2], Module.smethod_35<string>(3048061080u), dependencies[num2].Name));
			IL_183:
			throw new DescriptorValidationException(fileDescriptor, Module.smethod_33<string>(2639691648u));
			IL_18:
			arg_D3_0 = 3320637418u;
			goto IL_CE;
			IL_122:
			DescriptorPool pool = new DescriptorPool(dependencies);
			fileDescriptor = new FileDescriptor(descriptorData, proto, dependencies, pool, allowUnknownDependencies, generatedCodeInfo);
			arg_D3_0 = ((dependencies.Length != proto.Dependency.Count) ? 2984046962u : 2591580144u);
			goto IL_CE;
		}

		private void CrossLink()
		{
			IEnumerator<MessageDescriptor> enumerator = this.MessageTypes.GetEnumerator();
			try
			{
				while (true)
				{
					IL_60:
					int arg_38_0 = (!FileDescriptor.smethod_7(enumerator)) ? -152615990 : -2058392403;
					while (true)
					{
						switch ((arg_38_0 ^ -323940801) % 4)
						{
						case 0:
							arg_38_0 = -2058392403;
							continue;
						case 2:
							enumerator.Current.CrossLink();
							arg_38_0 = -393624028;
							continue;
						case 3:
							goto IL_60;
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
						IL_A1:
						uint arg_89_0 = 3921181848u;
						while (true)
						{
							uint num;
							switch ((num = (arg_89_0 ^ 3971026495u)) % 3u)
							{
							case 1u:
								FileDescriptor.smethod_8(enumerator);
								arg_89_0 = (num * 3830264196u ^ 519961653u);
								continue;
							case 2u:
								goto IL_A1;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
			IEnumerator<ServiceDescriptor> enumerator2 = this.Services.GetEnumerator();
			try
			{
				while (true)
				{
					IL_109:
					int arg_E1_0 = (!FileDescriptor.smethod_7(enumerator2)) ? -1638352192 : -1864184730;
					while (true)
					{
						switch ((arg_E1_0 ^ -323940801) % 4)
						{
						case 0:
							arg_E1_0 = -1864184730;
							continue;
						case 1:
							enumerator2.Current.CrossLink();
							arg_E1_0 = -584973483;
							continue;
						case 2:
							goto IL_109;
						}
						goto Block_10;
					}
				}
				Block_10:;
			}
			finally
			{
				if (enumerator2 != null)
				{
					while (true)
					{
						IL_14A:
						uint arg_132_0 = 3979203725u;
						while (true)
						{
							uint num;
							switch ((num = (arg_132_0 ^ 3971026495u)) % 3u)
							{
							case 0u:
								goto IL_14A;
							case 1u:
								FileDescriptor.smethod_8(enumerator2);
								arg_132_0 = (num * 2140043047u ^ 1525068915u);
								continue;
							}
							goto Block_14;
						}
					}
					Block_14:;
				}
			}
		}

		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedCodeInfo generatedCodeInfo)
		{
			FileDescriptorProto fileDescriptorProto;
			try
			{
				fileDescriptorProto = FileDescriptorProto.Parser.ParseFrom(descriptorData);
			}
			catch (InvalidProtocolBufferException exception_)
			{
				throw FileDescriptor.smethod_9(Module.smethod_36<string>(4196006172u), exception_);
			}
			FileDescriptor result;
			try
			{
				result = FileDescriptor.BuildFrom(ByteString.CopyFrom(descriptorData), fileDescriptorProto, dependencies, true, generatedCodeInfo);
			}
			catch (DescriptorValidationException exception_2)
			{
				throw FileDescriptor.smethod_9(FileDescriptor.smethod_10(Module.smethod_33<string>(3393686726u), new object[]
				{
					fileDescriptorProto.Name
				}), exception_2);
			}
			return result;
		}

		public override string ToString()
		{
			return FileDescriptor.smethod_10(Module.smethod_37<string>(4174461468u), new object[]
			{
				this.Name
			});
		}

		static object smethod_0(Array array_0)
		{
			return array_0.Clone();
		}

		static string smethod_1(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}

		static int smethod_2(string string_0)
		{
			return string_0.Length;
		}

		static string smethod_3(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static int smethod_4(string string_0, char char_0)
		{
			return string_0.IndexOf(char_0);
		}

		static bool smethod_5(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static string smethod_6(string string_0, string string_1, string string_2, string string_3)
		{
			return string_0 + string_1 + string_2 + string_3;
		}

		static bool smethod_7(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_8(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static ArgumentException smethod_9(string string_0, Exception exception_0)
		{
			return new ArgumentException(string_0, exception_0);
		}

		static string smethod_10(string string_0, object[] object_0)
		{
			return string.Format(string_0, object_0);
		}
	}
}
