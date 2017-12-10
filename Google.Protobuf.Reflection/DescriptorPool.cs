using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google.Protobuf.Reflection
{
	internal sealed class DescriptorPool
	{
		private struct DescriptorIntPair : IEquatable<DescriptorPool.DescriptorIntPair>
		{
			private readonly int number;

			private readonly IDescriptor descriptor;

			internal DescriptorIntPair(IDescriptor descriptor, int number)
			{
				this.number = number;
				this.descriptor = descriptor;
			}

			public bool Equals(DescriptorPool.DescriptorIntPair other)
			{
				return this.descriptor == other.descriptor && this.number == other.number;
			}

			public override bool Equals(object obj)
			{
				return obj is DescriptorPool.DescriptorIntPair && this.Equals((DescriptorPool.DescriptorIntPair)obj);
			}

			public override int GetHashCode()
			{
				return DescriptorPool.DescriptorIntPair.smethod_0(this.descriptor) * 65535 + this.number;
			}

			static int smethod_0(object object_0)
			{
				return object_0.GetHashCode();
			}
		}

		private readonly IDictionary<string, IDescriptor> descriptorsByName = new Dictionary<string, IDescriptor>();

		private readonly IDictionary<DescriptorPool.DescriptorIntPair, FieldDescriptor> fieldsByNumber = new Dictionary<DescriptorPool.DescriptorIntPair, FieldDescriptor>();

		private readonly IDictionary<DescriptorPool.DescriptorIntPair, EnumValueDescriptor> enumValuesByNumber = new Dictionary<DescriptorPool.DescriptorIntPair, EnumValueDescriptor>();

		private readonly HashSet<FileDescriptor> dependencies;

		private static readonly Regex ValidationRegex = DescriptorPool.smethod_17(Module.smethod_37<string>(1311100819u), FrameworkPortability.CompiledRegexWhereAvailable);

		internal DescriptorPool(FileDescriptor[] dependencyFiles)
		{
			while (true)
			{
				IL_15F:
				uint arg_125_0 = 2867741474u;
				while (true)
				{
					uint num;
					switch ((num = (arg_125_0 ^ 3587480274u)) % 11u)
					{
					case 0u:
					{
						int num2;
						arg_125_0 = ((num2 < dependencyFiles.Length) ? 4207413293u : 3795583198u);
						continue;
					}
					case 1u:
					{
						int num3;
						arg_125_0 = ((num3 < dependencyFiles.Length) ? 3513816270u : 2166799543u);
						continue;
					}
					case 2u:
					{
						this.dependencies = new HashSet<FileDescriptor>();
						int num3 = 0;
						arg_125_0 = (num * 2631113323u ^ 2574616807u);
						continue;
					}
					case 3u:
					{
						int num2;
						FileDescriptor fileDescriptor = dependencyFiles[num2];
						this.AddPackage(fileDescriptor.Package, fileDescriptor);
						num2++;
						arg_125_0 = 3276048337u;
						continue;
					}
					case 4u:
					{
						int num3;
						this.dependencies.Add(dependencyFiles[num3]);
						arg_125_0 = 3179756802u;
						continue;
					}
					case 5u:
						arg_125_0 = (num * 3693977428u ^ 1260750322u);
						continue;
					case 6u:
					{
						int num2 = 0;
						arg_125_0 = (num * 1946987356u ^ 281619545u);
						continue;
					}
					case 7u:
					{
						int num3;
						this.ImportPublicDependencies(dependencyFiles[num3]);
						num3++;
						arg_125_0 = (num * 4050069737u ^ 2871900550u);
						continue;
					}
					case 8u:
						arg_125_0 = (num * 2664253148u ^ 3891939312u);
						continue;
					case 9u:
						goto IL_15F;
					}
					return;
				}
			}
		}

		private void ImportPublicDependencies(FileDescriptor file)
		{
			IEnumerator<FileDescriptor> enumerator = file.PublicDependencies.GetEnumerator();
			try
			{
				while (true)
				{
					IL_AF:
					uint arg_7C_0 = DescriptorPool.smethod_0(enumerator) ? 483463677u : 1013596277u;
					while (true)
					{
						uint num;
						switch ((num = (arg_7C_0 ^ 1510700764u)) % 6u)
						{
						case 0u:
							goto IL_AF;
						case 1u:
						{
							FileDescriptor current = enumerator.Current;
							arg_7C_0 = 2088187487u;
							continue;
						}
						case 2u:
							arg_7C_0 = 483463677u;
							continue;
						case 3u:
						{
							FileDescriptor current;
							arg_7C_0 = ((this.dependencies.Add(current) ? 3551628460u : 3841956582u) ^ num * 990315274u);
							continue;
						}
						case 4u:
						{
							FileDescriptor current;
							this.ImportPublicDependencies(current);
							arg_7C_0 = (num * 2977631201u ^ 244456022u);
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
						IL_F3:
						uint arg_DB_0 = 273087490u;
						while (true)
						{
							uint num;
							switch ((num = (arg_DB_0 ^ 1510700764u)) % 3u)
							{
							case 0u:
								goto IL_F3;
							case 1u:
								DescriptorPool.smethod_1(enumerator);
								arg_DB_0 = (num * 2366569890u ^ 4210252562u);
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
		}

		internal T FindSymbol<T>(string fullName) where T : class
		{
			IDescriptor descriptor;
			this.descriptorsByName.TryGetValue(fullName, out descriptor);
			T t = descriptor as T;
			if (t != null)
			{
				return t;
			}
			using (HashSet<FileDescriptor>.Enumerator enumerator = this.dependencies.GetEnumerator())
			{
				T result;
				while (true)
				{
					IL_F6:
					uint arg_BE_0 = (!enumerator.MoveNext()) ? 4019694310u : 2447028926u;
					while (true)
					{
						uint num;
						switch ((num = (arg_BE_0 ^ 3083068236u)) % 7u)
						{
						case 0u:
							arg_BE_0 = 2447028926u;
							continue;
						case 1u:
							goto IL_F6;
						case 2u:
							t = (descriptor as T);
							arg_BE_0 = (((t != null) ? 3533821376u : 3234978632u) ^ num * 1291394793u);
							continue;
						case 3u:
							enumerator.Current.DescriptorPool.descriptorsByName.TryGetValue(fullName, out descriptor);
							arg_BE_0 = 3405879150u;
							continue;
						case 5u:
							result = t;
							arg_BE_0 = (num * 3163499059u ^ 4131604281u);
							continue;
						case 6u:
							goto IL_106;
						}
						goto Block_5;
					}
				}
				Block_5:
				goto IL_116;
				IL_106:
				return result;
			}
			IL_116:
			return default(T);
		}

		internal void AddPackage(string fullName, FileDescriptor file)
		{
			int num = DescriptorPool.smethod_2(fullName, '.');
			if (num != -1)
			{
				goto IL_2D;
			}
			goto IL_DD;
			uint arg_B1_0;
			IDescriptor descriptor;
			string text;
			while (true)
			{
				IL_AC:
				uint num2;
				switch ((num2 = (arg_B1_0 ^ 3316964695u)) % 8u)
				{
				case 0u:
					arg_B1_0 = (this.descriptorsByName.TryGetValue(fullName, out descriptor) ? 2404316941u : 3896060576u);
					continue;
				case 1u:
					this.AddPackage(DescriptorPool.smethod_3(fullName, 0, num), file);
					text = DescriptorPool.smethod_4(fullName, num + 1);
					arg_B1_0 = (num2 * 1743673299u ^ 1753241596u);
					continue;
				case 2u:
					arg_B1_0 = (((descriptor is PackageDescriptor) ? 932590856u : 1724073788u) ^ num2 * 1699437476u);
					continue;
				case 3u:
					goto IL_E6;
				case 5u:
					goto IL_DD;
				case 6u:
					goto IL_2D;
				case 7u:
					this.descriptorsByName[fullName] = new PackageDescriptor(text, fullName, file);
					arg_B1_0 = 2781272387u;
					continue;
				}
				break;
			}
			return;
			IL_E6:
			throw new DescriptorValidationException(file, DescriptorPool.smethod_5(new string[]
			{
				Module.smethod_33<string>(3031927268u),
				text,
				Module.smethod_35<string>(2921857439u),
				descriptor.File.Name,
				Module.smethod_35<string>(2292255829u)
			}));
			IL_2D:
			arg_B1_0 = 4212142822u;
			goto IL_AC;
			IL_DD:
			text = fullName;
			arg_B1_0 = 3564429855u;
			goto IL_AC;
		}

		internal void AddSymbol(IDescriptor descriptor)
		{
			DescriptorPool.ValidateSymbolName(descriptor);
			string description;
			while (true)
			{
				IL_220:
				uint arg_1DA_0 = 1985145293u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1DA_0 ^ 2053731764u)) % 14u)
					{
					case 0u:
					{
						string fullName;
						int num2;
						description = DescriptorPool.smethod_5(new string[]
						{
							Module.smethod_36<string>(1708679815u),
							DescriptorPool.smethod_4(fullName, num2 + 1),
							Module.smethod_37<string>(2801180086u),
							DescriptorPool.smethod_3(fullName, 0, num2),
							Module.smethod_35<string>(2292255829u)
						});
						arg_1DA_0 = 1833202264u;
						continue;
					}
					case 1u:
					{
						IDescriptor descriptor2;
						arg_1DA_0 = (((descriptor.File != descriptor2.File) ? 461553329u : 98503376u) ^ num * 1094856435u);
						continue;
					}
					case 2u:
					{
						string fullName;
						IDescriptor descriptor2;
						description = DescriptorPool.smethod_5(new string[]
						{
							Module.smethod_36<string>(1708679815u),
							fullName,
							Module.smethod_35<string>(2935817106u),
							descriptor2.File.Name,
							Module.smethod_34<string>(4290967862u)
						});
						arg_1DA_0 = 399949226u;
						continue;
					}
					case 4u:
						arg_1DA_0 = (num * 512943130u ^ 3276706322u);
						continue;
					case 5u:
					{
						string fullName;
						IDescriptor descriptor2;
						arg_1DA_0 = ((this.descriptorsByName.TryGetValue(fullName, out descriptor2) ? 724224651u : 816491605u) ^ num * 3835365548u);
						continue;
					}
					case 6u:
						arg_1DA_0 = (num * 587877992u ^ 2721817162u);
						continue;
					case 7u:
					{
						string fullName = descriptor.FullName;
						arg_1DA_0 = (num * 3042641918u ^ 2879375567u);
						continue;
					}
					case 8u:
					{
						string fullName;
						description = DescriptorPool.smethod_6(Module.smethod_33<string>(3031927268u), fullName, Module.smethod_36<string>(4135403163u));
						arg_1DA_0 = (num * 294609173u ^ 513628476u);
						continue;
					}
					case 9u:
					{
						string fullName;
						this.descriptorsByName[fullName] = descriptor;
						arg_1DA_0 = 560751961u;
						continue;
					}
					case 10u:
						goto IL_220;
					case 11u:
					{
						int num2;
						arg_1DA_0 = (((num2 != -1) ? 3906432723u : 2856908785u) ^ num * 923807959u);
						continue;
					}
					case 12u:
						goto IL_227;
					case 13u:
					{
						string fullName;
						int num2 = DescriptorPool.smethod_2(fullName, '.');
						arg_1DA_0 = (num * 2071959698u ^ 1993918755u);
						continue;
					}
					}
					goto Block_4;
				}
			}
			Block_4:
			return;
			IL_227:
			throw new DescriptorValidationException(descriptor, description);
		}

		private static void ValidateSymbolName(IDescriptor descriptor)
		{
			if (!DescriptorPool.smethod_7(descriptor.Name, ""))
			{
				goto IL_55;
			}
			IL_21:
			int arg_2B_0 = 164232957;
			IL_26:
			switch ((arg_2B_0 ^ 1498968607) % 5)
			{
			case 1:
				throw new DescriptorValidationException(descriptor, Module.smethod_35<string>(3327537739u));
			case 2:
				IL_55:
				arg_2B_0 = (DescriptorPool.smethod_8(DescriptorPool.ValidationRegex, descriptor.Name) ? 956386433 : 1225429300);
				goto IL_26;
			case 3:
				throw new DescriptorValidationException(descriptor, DescriptorPool.smethod_6(Module.smethod_33<string>(3031927268u), descriptor.Name, Module.smethod_37<string>(1895443896u)));
			case 4:
				goto IL_21;
			}
		}

		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number)
		{
			FieldDescriptor result;
			this.fieldsByNumber.TryGetValue(new DescriptorPool.DescriptorIntPair(messageDescriptor, number), out result);
			return result;
		}

		internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number)
		{
			EnumValueDescriptor result;
			this.enumValuesByNumber.TryGetValue(new DescriptorPool.DescriptorIntPair(enumDescriptor, number), out result);
			return result;
		}

		internal void AddFieldByNumber(FieldDescriptor field)
		{
			DescriptorPool.DescriptorIntPair key = new DescriptorPool.DescriptorIntPair(field.ContainingType, field.FieldNumber);
			FieldDescriptor fieldDescriptor;
			if (this.fieldsByNumber.TryGetValue(key, out fieldDescriptor))
			{
				throw new DescriptorValidationException(field, DescriptorPool.smethod_9(new object[]
				{
					Module.smethod_36<string>(896911572u),
					field.FieldNumber,
					Module.smethod_35<string>(1732735873u),
					field.ContainingType.FullName,
					Module.smethod_34<string>(3822284802u),
					fieldDescriptor.Name,
					Module.smethod_37<string>(3940659401u)
				}));
			}
			this.fieldsByNumber[key] = field;
		}

		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue)
		{
			DescriptorPool.DescriptorIntPair key = new DescriptorPool.DescriptorIntPair(enumValue.EnumDescriptor, enumValue.Number);
			while (true)
			{
				IL_7F:
				uint arg_63_0 = 2334012792u;
				while (true)
				{
					uint num;
					switch ((num = (arg_63_0 ^ 3355675090u)) % 4u)
					{
					case 0u:
						goto IL_7F;
					case 2u:
						arg_63_0 = (((!this.enumValuesByNumber.ContainsKey(key)) ? 3139572129u : 3625274707u) ^ num * 2510821840u);
						continue;
					case 3u:
						this.enumValuesByNumber[key] = enumValue;
						arg_63_0 = (num * 4075470653u ^ 3296798132u);
						continue;
					}
					return;
				}
			}
		}

		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo)
		{
			if (DescriptorPool.smethod_10(name, Module.smethod_37<string>(3886401134u)))
			{
				goto IL_1E0;
			}
			goto IL_25F;
			uint arg_1EA_0;
			IDescriptor descriptor;
			int num2;
			string string_;
			while (true)
			{
				IL_1E5:
				uint num;
				switch ((num = (arg_1EA_0 ^ 1120319073u)) % 20u)
				{
				case 0u:
					goto IL_1E0;
				case 1u:
					arg_1EA_0 = ((descriptor == null) ? 870869395u : 499394510u);
					continue;
				case 2u:
					goto IL_248;
				case 3u:
					arg_1EA_0 = (num * 3182389240u ^ 2661154485u);
					continue;
				case 4u:
					arg_1EA_0 = (((num2 != -1) ? 1585465210u : 655580376u) ^ num * 49592841u);
					continue;
				case 5u:
					descriptor = this.FindSymbol<IDescriptor>(DescriptorPool.smethod_4(name, 1));
					arg_1EA_0 = (num * 3672446899u ^ 3969592099u);
					continue;
				case 6u:
				{
					StringBuilder stringBuilder;
					descriptor = this.FindSymbol<IDescriptor>(DescriptorPool.smethod_13(stringBuilder));
					arg_1EA_0 = (((descriptor != null) ? 64710281u : 267317740u) ^ num * 1678552982u);
					continue;
				}
				case 8u:
				{
					StringBuilder stringBuilder;
					int num3 = DescriptorPool.smethod_14(DescriptorPool.smethod_13(stringBuilder), Module.smethod_37<string>(3886401134u));
					arg_1EA_0 = 2002560569u;
					continue;
				}
				case 9u:
				{
					StringBuilder stringBuilder = DescriptorPool.smethod_12(relativeTo.FullName);
					arg_1EA_0 = (num * 3531444233u ^ 3381061816u);
					continue;
				}
				case 10u:
				{
					StringBuilder stringBuilder;
					DescriptorPool.smethod_16(stringBuilder, name);
					arg_1EA_0 = (num * 817521685u ^ 2631391113u);
					continue;
				}
				case 11u:
					arg_1EA_0 = (num * 552099699u ^ 2537391261u);
					continue;
				case 12u:
				{
					StringBuilder stringBuilder;
					int num3;
					DescriptorPool.smethod_15(stringBuilder, num3 + 1);
					DescriptorPool.smethod_16(stringBuilder, string_);
					arg_1EA_0 = 1012720395u;
					continue;
				}
				case 13u:
					descriptor = this.FindSymbol<IDescriptor>(name);
					arg_1EA_0 = (num * 2889115466u ^ 2648762352u);
					continue;
				case 14u:
					goto IL_271;
				case 15u:
					goto IL_25F;
				case 16u:
				{
					int num3;
					arg_1EA_0 = (((num3 == -1) ? 4120049240u : 3230677641u) ^ num * 813323212u);
					continue;
				}
				case 17u:
				{
					StringBuilder stringBuilder;
					int num3;
					DescriptorPool.smethod_15(stringBuilder, num3);
					arg_1EA_0 = 782561782u;
					continue;
				}
				case 18u:
				{
					StringBuilder stringBuilder;
					descriptor = this.FindSymbol<IDescriptor>(DescriptorPool.smethod_13(stringBuilder));
					arg_1EA_0 = (num * 2911074500u ^ 582846468u);
					continue;
				}
				case 19u:
				{
					StringBuilder stringBuilder;
					int num3;
					DescriptorPool.smethod_15(stringBuilder, num3 + 1);
					arg_1EA_0 = (num * 3586444226u ^ 2060538829u);
					continue;
				}
				}
				break;
			}
			return descriptor;
			IL_248:
			string arg_250_0 = DescriptorPool.smethod_3(name, 0, num2);
			goto IL_250;
			IL_271:
			throw new DescriptorValidationException(relativeTo, DescriptorPool.smethod_6(Module.smethod_36<string>(1708679815u), name, Module.smethod_35<string>(165853341u)));
			IL_1E0:
			arg_1EA_0 = 1226689332u;
			goto IL_1E5;
			IL_250:
			string_ = arg_250_0;
			arg_1EA_0 = 1911610428u;
			goto IL_1E5;
			IL_25F:
			num2 = DescriptorPool.smethod_11(name, '.');
			if (num2 != -1)
			{
				arg_1EA_0 = 604030619u;
				goto IL_1E5;
			}
			arg_250_0 = name;
			goto IL_250;
		}

		static bool smethod_0(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_1(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static int smethod_2(string string_0, char char_0)
		{
			return string_0.LastIndexOf(char_0);
		}

		static string smethod_3(string string_0, int int_0, int int_1)
		{
			return string_0.Substring(int_0, int_1);
		}

		static string smethod_4(string string_0, int int_0)
		{
			return string_0.Substring(int_0);
		}

		static string smethod_5(string[] string_0)
		{
			return string.Concat(string_0);
		}

		static string smethod_6(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}

		static bool smethod_7(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static bool smethod_8(Regex regex_0, string string_0)
		{
			return regex_0.IsMatch(string_0);
		}

		static string smethod_9(object[] object_0)
		{
			return string.Concat(object_0);
		}

		static bool smethod_10(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1);
		}

		static int smethod_11(string string_0, char char_0)
		{
			return string_0.IndexOf(char_0);
		}

		static StringBuilder smethod_12(string string_0)
		{
			return new StringBuilder(string_0);
		}

		static string smethod_13(object object_0)
		{
			return object_0.ToString();
		}

		static int smethod_14(string string_0, string string_1)
		{
			return string_0.LastIndexOf(string_1);
		}

		static void smethod_15(StringBuilder stringBuilder_0, int int_0)
		{
			stringBuilder_0.Length = int_0;
		}

		static StringBuilder smethod_16(StringBuilder stringBuilder_0, string string_0)
		{
			return stringBuilder_0.Append(string_0);
		}

		static Regex smethod_17(string string_0, RegexOptions regexOptions_0)
		{
			return new Regex(string_0, regexOptions_0);
		}
	}
}
