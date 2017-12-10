using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Google.Protobuf.Reflection
{
	internal static class DescriptorUtil
	{
		internal delegate TOutput IndexedConverter<TInput, TOutput>(TInput element, int index);

		internal static IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(IList<TInput> input, DescriptorUtil.IndexedConverter<TInput, TOutput> converter)
		{
			TOutput[] array = new TOutput[input.Count];
			while (true)
			{
				IL_97:
				uint arg_73_0 = 3331546075u;
				while (true)
				{
					uint num;
					switch ((num = (arg_73_0 ^ 2467315675u)) % 6u)
					{
					case 0u:
						goto IL_97;
					case 2u:
					{
						int num2;
						arg_73_0 = ((num2 < array.Length) ? 3643342010u : 2445283146u);
						continue;
					}
					case 3u:
						arg_73_0 = (num * 2761093046u ^ 1075757647u);
						continue;
					case 4u:
					{
						int num2 = 0;
						arg_73_0 = (num * 2613492090u ^ 3110948942u);
						continue;
					}
					case 5u:
					{
						int num2;
						array[num2] = converter(input[num2], num2);
						num2++;
						arg_73_0 = 3403496609u;
						continue;
					}
					}
					goto Block_2;
				}
			}
			Block_2:
			return new ReadOnlyCollection<TOutput>(array);
		}
	}
}
