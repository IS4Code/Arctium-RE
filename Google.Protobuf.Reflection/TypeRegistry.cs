using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class TypeRegistry
	{
		private class Builder
		{
			private readonly Dictionary<string, MessageDescriptor> types;

			private readonly HashSet<string> fileDescriptorNames;

			internal Builder()
			{
				this.types = new Dictionary<string, MessageDescriptor>();
				this.fileDescriptorNames = new HashSet<string>();
			}

			internal void AddFile(FileDescriptor fileDescriptor)
			{
				if (!this.fileDescriptorNames.Add(fileDescriptor.Name))
				{
					return;
				}
				IEnumerator<FileDescriptor> enumerator = fileDescriptor.Dependencies.GetEnumerator();
				try
				{
					while (true)
					{
						IL_7F:
						int arg_56_0 = (!TypeRegistry.Builder.smethod_0(enumerator)) ? -1090525266 : -792330836;
						while (true)
						{
							switch ((arg_56_0 ^ -136632362) % 4)
							{
							case 1:
								goto IL_7F;
							case 2:
							{
								FileDescriptor current = enumerator.Current;
								this.AddFile(current);
								arg_56_0 = -67223049;
								continue;
							}
							case 3:
								arg_56_0 = -792330836;
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
							IL_C2:
							uint arg_A9_0 = 2376606614u;
							while (true)
							{
								uint num;
								switch ((num = (arg_A9_0 ^ 4158334934u)) % 3u)
								{
								case 0u:
									goto IL_C2;
								case 2u:
									TypeRegistry.Builder.smethod_1(enumerator);
									arg_A9_0 = (num * 353277277u ^ 1794307014u);
									continue;
								}
								goto Block_9;
							}
						}
						Block_9:;
					}
				}
				IEnumerator<MessageDescriptor> enumerator2 = fileDescriptor.MessageTypes.GetEnumerator();
				try
				{
					while (true)
					{
						IL_12E:
						int arg_105_0 = (!TypeRegistry.Builder.smethod_0(enumerator2)) ? -2052165515 : -913572613;
						while (true)
						{
							switch ((arg_105_0 ^ -136632362) % 4)
							{
							case 0:
								arg_105_0 = -913572613;
								continue;
							case 1:
							{
								MessageDescriptor current2 = enumerator2.Current;
								this.AddMessage(current2);
								arg_105_0 = -1785936184;
								continue;
							}
							case 2:
								goto IL_12E;
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
							IL_171:
							uint arg_158_0 = 2295237479u;
							while (true)
							{
								uint num;
								switch ((num = (arg_158_0 ^ 4158334934u)) % 3u)
								{
								case 0u:
									goto IL_171;
								case 2u:
									TypeRegistry.Builder.smethod_1(enumerator2);
									arg_158_0 = (num * 2014248563u ^ 3207272856u);
									continue;
								}
								goto Block_15;
							}
						}
						Block_15:;
					}
				}
			}

			private void AddMessage(MessageDescriptor messageDescriptor)
			{
				IEnumerator<MessageDescriptor> enumerator = messageDescriptor.NestedTypes.GetEnumerator();
				try
				{
					while (true)
					{
						IL_76:
						uint arg_4A_0 = TypeRegistry.Builder.smethod_0(enumerator) ? 4034483203u : 2900455577u;
						while (true)
						{
							uint num;
							switch ((num = (arg_4A_0 ^ 3766789498u)) % 5u)
							{
							case 0u:
								arg_4A_0 = 4034483203u;
								continue;
							case 1u:
							{
								MessageDescriptor current = enumerator.Current;
								arg_4A_0 = 3563130679u;
								continue;
							}
							case 3u:
							{
								MessageDescriptor current;
								this.AddMessage(current);
								arg_4A_0 = (num * 861940351u ^ 2915693501u);
								continue;
							}
							case 4u:
								goto IL_76;
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
							IL_B7:
							uint arg_9F_0 = 3485012909u;
							while (true)
							{
								uint num;
								switch ((num = (arg_9F_0 ^ 3766789498u)) % 3u)
								{
								case 1u:
									TypeRegistry.Builder.smethod_1(enumerator);
									arg_9F_0 = (num * 3747808284u ^ 3746933214u);
									continue;
								case 2u:
									goto IL_B7;
								}
								goto Block_7;
							}
						}
						Block_7:;
					}
				}
				this.types[messageDescriptor.FullName] = messageDescriptor;
			}

			internal TypeRegistry Build()
			{
				return new TypeRegistry(this.types);
			}

			static bool smethod_0(IEnumerator ienumerator_0)
			{
				return ienumerator_0.MoveNext();
			}

			static void smethod_1(IDisposable idisposable_0)
			{
				idisposable_0.Dispose();
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly TypeRegistry.__c __9 = new TypeRegistry.__c();

			public static Func<MessageDescriptor, FileDescriptor> __9__9_0;

			internal FileDescriptor <FromMessages>b__9_0(MessageDescriptor md)
			{
				return md.File;
			}
		}

		private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap;

		public static TypeRegistry Empty
		{
			[CompilerGenerated]
			get
			{
				return TypeRegistry.<Empty>k__BackingField;
			}
		}

		private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap)
		{
			this.fullNameToMessageMap = fullNameToMessageMap;
		}

		public MessageDescriptor Find(string fullName)
		{
			MessageDescriptor result;
			this.fullNameToMessageMap.TryGetValue(fullName, out result);
			return result;
		}

		public static TypeRegistry FromFiles(params FileDescriptor[] fileDescriptors)
		{
			return TypeRegistry.FromFiles(fileDescriptors);
		}

		public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors)
		{
			Preconditions.CheckNotNull<IEnumerable<FileDescriptor>>(fileDescriptors, Module.smethod_37<string>(3823684690u));
			TypeRegistry.Builder builder;
			while (true)
			{
				IL_43:
				uint arg_2B_0 = 572427948u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2B_0 ^ 570727210u)) % 3u)
					{
					case 0u:
						goto IL_43;
					case 1u:
						builder = new TypeRegistry.Builder();
						arg_2B_0 = (num * 1860881079u ^ 2819786057u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			IEnumerator<FileDescriptor> enumerator = fileDescriptors.GetEnumerator();
			try
			{
				while (true)
				{
					IL_BB:
					uint arg_8F_0 = TypeRegistry.smethod_0(enumerator) ? 1131359393u : 689609985u;
					while (true)
					{
						uint num;
						switch ((num = (arg_8F_0 ^ 570727210u)) % 5u)
						{
						case 1u:
						{
							FileDescriptor current = enumerator.Current;
							arg_8F_0 = 1834372445u;
							continue;
						}
						case 2u:
							arg_8F_0 = 1131359393u;
							continue;
						case 3u:
							goto IL_BB;
						case 4u:
						{
							FileDescriptor current;
							builder.AddFile(current);
							arg_8F_0 = (num * 4146575965u ^ 593622994u);
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
						IL_FC:
						uint arg_E4_0 = 2091946684u;
						while (true)
						{
							uint num;
							switch ((num = (arg_E4_0 ^ 570727210u)) % 3u)
							{
							case 0u:
								goto IL_FC;
							case 1u:
								TypeRegistry.smethod_1(enumerator);
								arg_E4_0 = (num * 3508695067u ^ 703506824u);
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
			return builder.Build();
		}

		public static TypeRegistry FromMessages(params MessageDescriptor[] messageDescriptors)
		{
			return TypeRegistry.FromMessages(messageDescriptors);
		}

		public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors)
		{
			Preconditions.CheckNotNull<IEnumerable<MessageDescriptor>>(messageDescriptors, Module.smethod_36<string>(3395054779u));
			Func<MessageDescriptor, FileDescriptor> arg_31_1;
			if ((arg_31_1 = TypeRegistry.__c.__9__9_0) == null)
			{
				arg_31_1 = (TypeRegistry.__c.__9__9_0 = new Func<MessageDescriptor, FileDescriptor>(TypeRegistry.__c.__9.<FromMessages>b__9_0));
			}
			return TypeRegistry.FromFiles(messageDescriptors.Select(arg_31_1));
		}

		static TypeRegistry()
		{
			// Note: this type is marked as 'beforefieldinit'.
			TypeRegistry.<Empty>k__BackingField = new TypeRegistry(new Dictionary<string, MessageDescriptor>());
		}

		static bool smethod_0(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_1(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}
	}
}
