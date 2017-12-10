using Google.Protobuf.Compatibility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Google.Protobuf.Collections
{
	[ComVisible(true)]
	public sealed class RepeatedField<T> : IEnumerable, IList, ICollection, IList<T>, ICollection<T>, IEnumerable<T>, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>
	{
		private static readonly T[] EmptyArray = new T[0];

		private const int MinArraySize = 8;

		private T[] array = RepeatedField<T>.EmptyArray;

		private int count;

		public int Count
		{
			get
			{
				return this.count;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public T this[int index]
		{
			get
			{
				if (index >= 0)
				{
					while (true)
					{
						IL_4F:
						uint arg_33_0 = 495512970u;
						while (true)
						{
							uint num;
							switch ((num = (arg_33_0 ^ 1887603351u)) % 4u)
							{
							case 0u:
								goto IL_56;
							case 1u:
								arg_33_0 = (((index < this.count) ? 65021127u : 149641209u) ^ num * 2244673006u);
								continue;
							case 3u:
								goto IL_4F;
							}
							goto Block_3;
						}
					}
					Block_3:
					return this.array[index];
				}
				IL_56:
				throw RepeatedField<T>.smethod_7(Module.smethod_36<string>(1137418279u));
			}
			set
			{
				if (index >= 0)
				{
					while (true)
					{
						IL_96:
						uint arg_6E_0 = 3630079173u;
						while (true)
						{
							uint num;
							switch ((num = (arg_6E_0 ^ 4134116640u)) % 7u)
							{
							case 0u:
								goto IL_96;
							case 2u:
								arg_6E_0 = ((value == null) ? 2954725098u : 4079346881u);
								continue;
							case 3u:
								goto IL_9D;
							case 4u:
								arg_6E_0 = (((index >= this.count) ? 3198776132u : 3883271993u) ^ num * 2698028948u);
								continue;
							case 5u:
								this.array[index] = value;
								arg_6E_0 = 3540219867u;
								continue;
							case 6u:
								goto IL_AD;
							}
							goto Block_4;
						}
					}
					Block_4:
					return;
					IL_9D:
					throw RepeatedField<T>.smethod_4(Module.smethod_37<string>(2719011704u));
				}
				IL_AD:
				throw RepeatedField<T>.smethod_7(Module.smethod_36<string>(1137418279u));
			}
		}

		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (T)((object)value);
			}
		}

		public RepeatedField<T> Clone()
		{
			RepeatedField<T> repeatedField = new RepeatedField<T>();
			if (this.array != RepeatedField<T>.EmptyArray)
			{
				goto IL_BE;
			}
			goto IL_129;
			uint arg_F4_0;
			while (true)
			{
				IL_EF:
				uint num;
				switch ((num = (arg_F4_0 ^ 3868469865u)) % 10u)
				{
				case 0u:
				{
					IDeepCloneable<T>[] array = repeatedField.array as IDeepCloneable<T>[];
					arg_F4_0 = (num * 328887486u ^ 2569178578u);
					continue;
				}
				case 1u:
					goto IL_129;
				case 2u:
				{
					int num2 = 0;
					arg_F4_0 = (num * 3112580505u ^ 1383133642u);
					continue;
				}
				case 3u:
					goto IL_BE;
				case 5u:
				{
					IDeepCloneable<T>[] array;
					arg_F4_0 = (((array != null) ? 1247038031u : 341634826u) ^ num * 2959909362u);
					continue;
				}
				case 6u:
				{
					int num2;
					arg_F4_0 = ((num2 >= this.count) ? 2519804532u : 3026334069u);
					continue;
				}
				case 7u:
					repeatedField.array = (T[])RepeatedField<T>.smethod_0(this.array);
					arg_F4_0 = (num * 3418464118u ^ 2881654057u);
					continue;
				case 8u:
				{
					IDeepCloneable<T>[] array;
					int num2;
					repeatedField.array[num2] = array[num2].Clone();
					num2++;
					arg_F4_0 = 2395505135u;
					continue;
				}
				case 9u:
					arg_F4_0 = (num * 1552521539u ^ 2698824094u);
					continue;
				}
				break;
			}
			return repeatedField;
			IL_BE:
			arg_F4_0 = 2167043006u;
			goto IL_EF;
			IL_129:
			repeatedField.count = this.count;
			arg_F4_0 = 3085565801u;
			goto IL_EF;
		}

		public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec)
		{
			uint lastTag = input.LastTag;
			Func<CodedInputStream, T> valueReader = codec.ValueReader;
			if (RepeatedField<T>.smethod_1(typeof(T).TypeHandle).IsValueType())
			{
				goto IL_79;
			}
			goto IL_189;
			uint arg_147_0;
			while (true)
			{
				IL_142:
				uint num;
				switch ((num = (arg_147_0 ^ 349581016u)) % 13u)
				{
				case 0u:
					arg_147_0 = ((input.MaybeConsumeTag(lastTag) ? 2792542167u : 2493560502u) ^ num * 4283985340u);
					continue;
				case 1u:
					arg_147_0 = (((WireFormat.GetTagWireType(lastTag) == WireFormat.WireType.LengthDelimited) ? 4182580420u : 2445968179u) ^ num * 3573087188u);
					continue;
				case 2u:
					arg_147_0 = (num * 2407926176u ^ 627495612u);
					continue;
				case 3u:
				{
					int num2;
					arg_147_0 = (((num2 > 0) ? 704969730u : 1347903514u) ^ num * 2106852334u);
					continue;
				}
				case 4u:
				{
					int oldLimit;
					input.PopLimit(oldLimit);
					arg_147_0 = (num * 2913868755u ^ 1655185686u);
					continue;
				}
				case 6u:
				{
					int num2;
					int oldLimit = input.PushLimit(num2);
					arg_147_0 = (num * 3972840873u ^ 320789690u);
					continue;
				}
				case 7u:
					goto IL_79;
				case 8u:
					this.Add(valueReader(input));
					arg_147_0 = 1293084732u;
					continue;
				case 9u:
					arg_147_0 = ((!input.ReachedLimit) ? 862879642u : 1176527045u);
					continue;
				case 10u:
					return;
				case 11u:
					goto IL_189;
				case 12u:
				{
					int num2 = input.ReadLength();
					arg_147_0 = (num * 1888486294u ^ 430467554u);
					continue;
				}
				}
				break;
			}
			return;
			IL_79:
			arg_147_0 = 431838837u;
			goto IL_142;
			IL_189:
			this.Add(valueReader(input));
			arg_147_0 = 320588544u;
			goto IL_142;
		}

		public int CalculateSize(FieldCodec<T> codec)
		{
			if (this.count == 0)
			{
				goto IL_7F;
			}
			goto IL_14C;
			uint arg_10E_0;
			int num2;
			uint tag;
			int num3;
			while (true)
			{
				IL_109:
				uint num;
				switch ((num = (arg_10E_0 ^ 4001631253u)) % 12u)
				{
				case 0u:
					goto IL_15A;
				case 1u:
					num2 = this.CalculatePackedDataSize(codec);
					arg_10E_0 = (num * 3891558231u ^ 1575501722u);
					continue;
				case 2u:
					goto IL_14C;
				case 3u:
				{
					Func<T, int> valueSizeCalculator = codec.ValueSizeCalculator;
					num3 = this.count * CodedOutputStream.ComputeRawVarint32Size(tag);
					arg_10E_0 = 3044489711u;
					continue;
				}
				case 4u:
				{
					Func<T, int> valueSizeCalculator;
					int num4;
					num3 += valueSizeCalculator(this.array[num4]);
					num4++;
					arg_10E_0 = 2737623098u;
					continue;
				}
				case 5u:
					return 0;
				case 6u:
					arg_10E_0 = (((WireFormat.GetTagWireType(tag) == WireFormat.WireType.LengthDelimited) ? 1110063554u : 216719364u) ^ num * 1888421937u);
					continue;
				case 7u:
					goto IL_7F;
				case 8u:
					arg_10E_0 = ((RepeatedField<T>.smethod_1(typeof(T).TypeHandle).IsValueType() ? 405727823u : 968969150u) ^ num * 1456731362u);
					continue;
				case 10u:
				{
					int num4 = 0;
					arg_10E_0 = (num * 2246578605u ^ 3048063944u);
					continue;
				}
				case 11u:
				{
					int num4;
					arg_10E_0 = ((num4 < this.count) ? 3082958981u : 4069993376u);
					continue;
				}
				}
				break;
			}
			return num3;
			IL_15A:
			return CodedOutputStream.ComputeRawVarint32Size(tag) + CodedOutputStream.ComputeLengthSize(num2) + num2;
			IL_7F:
			arg_10E_0 = 2713212068u;
			goto IL_109;
			IL_14C:
			tag = codec.Tag;
			arg_10E_0 = 2759193717u;
			goto IL_109;
		}

		private int CalculatePackedDataSize(FieldCodec<T> codec)
		{
			int fixedSize = codec.FixedSize;
			if (fixedSize == 0)
			{
				while (true)
				{
					IL_D4:
					uint arg_A2_0 = 2833686227u;
					while (true)
					{
						uint num;
						switch ((num = (arg_A2_0 ^ 2175998545u)) % 9u)
						{
						case 0u:
							goto IL_D4;
						case 1u:
						{
							int num2;
							return num2;
						}
						case 2u:
						{
							int num2 = 0;
							int num3 = 0;
							arg_A2_0 = (num * 2189381860u ^ 2913051558u);
							continue;
						}
						case 3u:
						{
							int num3;
							arg_A2_0 = ((num3 < this.count) ? 2988845271u : 2662832558u);
							continue;
						}
						case 4u:
						{
							int num3;
							num3++;
							arg_A2_0 = (num * 3732949925u ^ 1868024201u);
							continue;
						}
						case 5u:
							arg_A2_0 = (num * 1679443217u ^ 2977036967u);
							continue;
						case 6u:
						{
							int num2;
							int num3;
							Func<T, int> valueSizeCalculator;
							num2 += valueSizeCalculator(this.array[num3]);
							arg_A2_0 = 2488117428u;
							continue;
						}
						case 7u:
						{
							Func<T, int> valueSizeCalculator = codec.ValueSizeCalculator;
							arg_A2_0 = (num * 4280227348u ^ 3021418933u);
							continue;
						}
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			return fixedSize * this.Count;
		}

		public void WriteTo(CodedOutputStream output, FieldCodec<T> codec)
		{
			if (this.count == 0)
			{
				goto IL_0B;
			}
			goto IL_1E1;
			uint arg_18F_0;
			Action<CodedOutputStream, T> valueWriter;
			while (true)
			{
				IL_18A:
				uint num;
				switch ((num = (arg_18F_0 ^ 1953686162u)) % 17u)
				{
				case 0u:
					arg_18F_0 = (num * 3203489594u ^ 1031590236u);
					continue;
				case 1u:
				{
					uint tag;
					output.WriteTag(tag);
					uint value;
					output.WriteRawVarint32(value);
					int num2 = 0;
					arg_18F_0 = (num * 515923323u ^ 23271688u);
					continue;
				}
				case 2u:
				{
					uint tag = codec.Tag;
					arg_18F_0 = ((RepeatedField<T>.smethod_1(typeof(T).TypeHandle).IsValueType() ? 1056524744u : 1802064101u) ^ num * 3884348354u);
					continue;
				}
				case 3u:
					arg_18F_0 = (num * 2769258316u ^ 2862122040u);
					continue;
				case 4u:
				{
					uint value = (uint)this.CalculatePackedDataSize(codec);
					arg_18F_0 = (num * 4231138135u ^ 3155140988u);
					continue;
				}
				case 5u:
				{
					uint tag;
					output.WriteTag(tag);
					int num3;
					valueWriter(output, this.array[num3]);
					num3++;
					arg_18F_0 = 603286320u;
					continue;
				}
				case 6u:
				{
					int num2;
					arg_18F_0 = ((num2 < this.count) ? 1868080555u : 798875600u);
					continue;
				}
				case 8u:
				{
					uint tag;
					arg_18F_0 = (((WireFormat.GetTagWireType(tag) != WireFormat.WireType.LengthDelimited) ? 457279799u : 500871248u) ^ num * 3734816805u);
					continue;
				}
				case 9u:
				{
					int num3 = 0;
					arg_18F_0 = 1317493604u;
					continue;
				}
				case 10u:
				{
					int num2;
					valueWriter(output, this.array[num2]);
					arg_18F_0 = 1207070914u;
					continue;
				}
				case 11u:
				{
					int num3;
					arg_18F_0 = ((num3 >= this.count) ? 1230221189u : 414117966u);
					continue;
				}
				case 12u:
					goto IL_1E1;
				case 13u:
					return;
				case 14u:
				{
					int num2;
					num2++;
					arg_18F_0 = (num * 2746311965u ^ 3912762196u);
					continue;
				}
				case 15u:
					return;
				case 16u:
					goto IL_0B;
				}
				break;
			}
			return;
			IL_0B:
			arg_18F_0 = 793007137u;
			goto IL_18A;
			IL_1E1:
			valueWriter = codec.ValueWriter;
			arg_18F_0 = 158090120u;
			goto IL_18A;
		}

		private void EnsureSize(int size)
		{
			if (this.array.Length < size)
			{
				while (true)
				{
					IL_89:
					uint arg_6D_0 = 4002637106u;
					while (true)
					{
						uint num;
						switch ((num = (arg_6D_0 ^ 3981761093u)) % 4u)
						{
						case 0u:
							goto IL_89;
						case 1u:
						{
							T[] array_;
							RepeatedField<T>.smethod_3(this.array, 0, array_, 0, this.array.Length);
							this.array = array_;
							arg_6D_0 = (num * 452830843u ^ 22932296u);
							continue;
						}
						case 3u:
						{
							size = RepeatedField<T>.smethod_2(size, 8);
							T[] array_ = new T[RepeatedField<T>.smethod_2(this.array.Length * 2, size)];
							arg_6D_0 = (num * 3730143719u ^ 1732339117u);
							continue;
						}
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public void Add(T item)
		{
			if (item != null)
			{
				goto IL_2C;
			}
			IL_08:
			int arg_12_0 = 345573595;
			IL_0D:
			switch ((arg_12_0 ^ 1228463330) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				throw RepeatedField<T>.smethod_4(Module.smethod_33<string>(250796250u));
			case 2:
			{
				IL_2C:
				this.EnsureSize(this.count + 1);
				T[] arg_52_0 = this.array;
				int num = this.count;
				this.count = num + 1;
				arg_52_0[num] = item;
				arg_12_0 = 733793885;
				goto IL_0D;
			}
			}
		}

		public void Clear()
		{
			this.array = RepeatedField<T>.EmptyArray;
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 2584893099u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 3959011504u)) % 3u)
					{
					case 1u:
						this.count = 0;
						arg_26_0 = (num * 1317551434u ^ 1405766284u);
						continue;
					case 2u:
						goto IL_3E;
					}
					return;
				}
			}
		}

		public bool Contains(T item)
		{
			return this.IndexOf(item) != -1;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			RepeatedField<T>.smethod_3(this.array, 0, array, arrayIndex, this.count);
		}

		public bool Remove(T item)
		{
			int num = this.IndexOf(item);
			while (true)
			{
				IL_86:
				uint arg_66_0 = 601507694u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_66_0 ^ 153965440u)) % 5u)
					{
					case 0u:
						RepeatedField<T>.smethod_3(this.array, num + 1, this.array, num, this.count - num - 1);
						this.count--;
						arg_66_0 = 967664632u;
						continue;
					case 1u:
						return false;
					case 2u:
						arg_66_0 = (((num != -1) ? 386754548u : 1938479000u) ^ num2 * 1521070497u);
						continue;
					case 3u:
						goto IL_86;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.array[this.count] = default(T);
			return true;
		}

		public void Add(RepeatedField<T> values)
		{
			if (values == null)
			{
				throw RepeatedField<T>.smethod_4(Module.smethod_33<string>(659671905u));
			}
			this.EnsureSize(this.count + values.count);
			RepeatedField<T>.smethod_3(values.array, 0, this.array, this.count, values.count);
			this.count += values.count;
		}

		public void Add(IEnumerable<T> values)
		{
			if (values == null)
			{
				throw RepeatedField<T>.smethod_4(Module.smethod_36<string>(633765944u));
			}
			IEnumerator<T> enumerator = values.GetEnumerator();
			try
			{
				while (true)
				{
					IL_77:
					int arg_4F_0 = RepeatedField<T>.smethod_5(enumerator) ? 1105574788 : 1140450487;
					while (true)
					{
						switch ((arg_4F_0 ^ 667299957) % 4)
						{
						case 0:
							arg_4F_0 = 1105574788;
							continue;
						case 1:
						{
							T current = enumerator.Current;
							this.Add(current);
							arg_4F_0 = 591472010;
							continue;
						}
						case 3:
							goto IL_77;
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
						IL_B8:
						uint arg_A0_0 = 1260874760u;
						while (true)
						{
							uint num;
							switch ((num = (arg_A0_0 ^ 667299957u)) % 3u)
							{
							case 1u:
								RepeatedField<T>.smethod_6(enumerator);
								arg_A0_0 = (num * 2483277025u ^ 3773351686u);
								continue;
							case 2u:
								goto IL_B8;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
			}
		}

		[IteratorStateMachine(typeof(RepeatedField__.<GetEnumerator>d__21))]
		public IEnumerator<T> GetEnumerator()
		{
			RepeatedField<T>.<GetEnumerator>d__21 expr_06 = new RepeatedField<T>.<GetEnumerator>d__21(0);
			expr_06.__4__this = this;
			return expr_06;
		}

		public override bool Equals(object obj)
		{
			return this.Equals(obj as RepeatedField<T>);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		public override int GetHashCode()
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				IL_9A:
				uint arg_76_0 = 2586240208u;
				while (true)
				{
					uint num3;
					switch ((num3 = (arg_76_0 ^ 2901867794u)) % 6u)
					{
					case 0u:
						num = num * 31 + this.array[num2].GetHashCode();
						arg_76_0 = 2672207594u;
						continue;
					case 1u:
						arg_76_0 = ((num2 < this.count) ? 2208136224u : 2588468087u);
						continue;
					case 2u:
						num2++;
						arg_76_0 = (num3 * 513945887u ^ 2184949933u);
						continue;
					case 4u:
						arg_76_0 = (num3 * 3365125655u ^ 2129160139u);
						continue;
					case 5u:
						goto IL_9A;
					}
					return num;
				}
			}
			return num;
		}

		public bool Equals(RepeatedField<T> other)
		{
			if (other == null)
			{
				goto IL_DE;
			}
			goto IL_13C;
			uint arg_E8_0;
			while (true)
			{
				IL_E3:
				uint num;
				switch ((num = (arg_E8_0 ^ 2026901279u)) % 14u)
				{
				case 0u:
					goto IL_13C;
				case 1u:
					return false;
				case 2u:
					goto IL_DE;
				case 3u:
				{
					EqualityComparer<T> @default;
					int num2;
					arg_E8_0 = (@default.Equals(this.array[num2], other.array[num2]) ? 622073604u : 1212297050u);
					continue;
				}
				case 4u:
					return false;
				case 5u:
					return false;
				case 6u:
				{
					int num2;
					arg_E8_0 = ((num2 < this.count) ? 1691336322u : 1067068481u);
					continue;
				}
				case 7u:
					return true;
				case 8u:
					arg_E8_0 = (num * 3859565619u ^ 2417882767u);
					continue;
				case 9u:
				{
					int num2 = 0;
					arg_E8_0 = (num * 256934839u ^ 1605893188u);
					continue;
				}
				case 10u:
				{
					EqualityComparer<T> @default = EqualityComparer<T>.Default;
					arg_E8_0 = 866845094u;
					continue;
				}
				case 11u:
					arg_E8_0 = ((other.Count == this.Count) ? 147303997u : 455643969u);
					continue;
				case 13u:
				{
					int num2;
					num2++;
					arg_E8_0 = 949788515u;
					continue;
				}
				}
				break;
			}
			return true;
			IL_DE:
			arg_E8_0 = 854787260u;
			goto IL_E3;
			IL_13C:
			arg_E8_0 = ((other == this) ? 1701731294u : 1404128284u);
			goto IL_E3;
		}

		public int IndexOf(T item)
		{
			if (item == null)
			{
				goto IL_88;
			}
			goto IL_C7;
			uint arg_92_0;
			EqualityComparer<T> @default;
			while (true)
			{
				IL_8D:
				uint num;
				switch ((num = (arg_92_0 ^ 942271747u)) % 10u)
				{
				case 0u:
					goto IL_88;
				case 1u:
					goto IL_D4;
				case 2u:
				{
					int num2;
					arg_92_0 = ((num2 >= this.count) ? 296236707u : 374127910u);
					continue;
				}
				case 3u:
					goto IL_C7;
				case 5u:
				{
					int num2 = 0;
					arg_92_0 = (num * 2482567144u ^ 4041701487u);
					continue;
				}
				case 6u:
				{
					int num2;
					num2++;
					arg_92_0 = 1999304121u;
					continue;
				}
				case 7u:
				{
					int num2;
					return num2;
				}
				case 8u:
					arg_92_0 = (num * 1124084143u ^ 3754158453u);
					continue;
				case 9u:
				{
					int num2;
					arg_92_0 = ((!@default.Equals(this.array[num2], item)) ? 223232867u : 1637101498u);
					continue;
				}
				}
				break;
			}
			return -1;
			IL_D4:
			throw RepeatedField<T>.smethod_4(Module.smethod_34<string>(1998303130u));
			IL_88:
			arg_92_0 = 1054411828u;
			goto IL_8D;
			IL_C7:
			@default = EqualityComparer<T>.Default;
			arg_92_0 = 643417132u;
			goto IL_8D;
		}

		public void Insert(int index, T item)
		{
			if (item == null)
			{
				goto IL_1D;
			}
			goto IL_FF;
			uint arg_BF_0;
			while (true)
			{
				IL_BA:
				uint num;
				switch ((num = (arg_BF_0 ^ 2516027339u)) % 9u)
				{
				case 0u:
					goto IL_108;
				case 1u:
					goto IL_FF;
				case 3u:
					arg_BF_0 = (((index <= this.count) ? 837796657u : 866095185u) ^ num * 3157720697u);
					continue;
				case 4u:
					this.count++;
					arg_BF_0 = (num * 942514077u ^ 70766067u);
					continue;
				case 5u:
					this.EnsureSize(this.count + 1);
					RepeatedField<T>.smethod_3(this.array, index, this.array, index + 1, this.count - index);
					arg_BF_0 = 4267804870u;
					continue;
				case 6u:
					this.array[index] = item;
					arg_BF_0 = (num * 3413272626u ^ 749495697u);
					continue;
				case 7u:
					goto IL_1D;
				case 8u:
					goto IL_118;
				}
				break;
			}
			return;
			IL_108:
			throw RepeatedField<T>.smethod_7(Module.smethod_34<string>(3349025576u));
			IL_118:
			throw RepeatedField<T>.smethod_4(Module.smethod_35<string>(2613611489u));
			IL_1D:
			arg_BF_0 = 3595699030u;
			goto IL_BA;
			IL_FF:
			arg_BF_0 = ((index >= 0) ? 3393884718u : 2516131692u);
			goto IL_BA;
		}

		public void RemoveAt(int index)
		{
			if (index >= 0)
			{
				while (true)
				{
					IL_A0:
					uint arg_7C_0 = 1856822727u;
					while (true)
					{
						uint num;
						switch ((num = (arg_7C_0 ^ 177069126u)) % 6u)
						{
						case 0u:
							goto IL_A7;
						case 2u:
							this.count--;
							arg_7C_0 = (num * 3372450543u ^ 1896179937u);
							continue;
						case 3u:
							goto IL_A0;
						case 4u:
							RepeatedField<T>.smethod_3(this.array, index + 1, this.array, index, this.count - index - 1);
							arg_7C_0 = 1791480996u;
							continue;
						case 5u:
							arg_7C_0 = (((index >= this.count) ? 674979184u : 445073436u) ^ num * 4139897492u);
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:
				this.array[this.count] = default(T);
				return;
			}
			IL_A7:
			throw RepeatedField<T>.smethod_7(Module.smethod_37<string>(1515578163u));
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = RepeatedField<T>.smethod_8();
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 3762034287u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 3041272673u)) % 3u)
					{
					case 0u:
						goto IL_3E;
					case 1u:
						JsonFormatter.Default.WriteList(stringBuilder, this);
						arg_26_0 = (num * 3822163022u ^ 2426271970u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return RepeatedField<T>.smethod_9(stringBuilder);
		}

		void ICollection.CopyTo(Array array, int index)
		{
			RepeatedField<T>.smethod_3(this.array, 0, array, index, this.count);
		}

		int IList.Add(object value)
		{
			this.Add((T)((object)value));
			return this.count - 1;
		}

		bool IList.Contains(object value)
		{
			return value is T && this.Contains((T)((object)value));
		}

		int IList.IndexOf(object value)
		{
			if (!(value is T))
			{
				return -1;
			}
			return this.IndexOf((T)((object)value));
		}

		void IList.Insert(int index, object value)
		{
			this.Insert(index, (T)((object)value));
		}

		void IList.Remove(object value)
		{
			if (value is T)
			{
				goto IL_2C;
			}
			IL_08:
			int arg_12_0 = -1772889532;
			IL_0D:
			switch ((arg_12_0 ^ -1743869255) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 2:
				IL_2C:
				this.Remove((T)((object)value));
				arg_12_0 = -1674331314;
				goto IL_0D;
			}
		}

		static object smethod_0(Array array_0)
		{
			return array_0.Clone();
		}

		static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static int smethod_2(int int_0, int int_1)
		{
			return Math.Max(int_0, int_1);
		}

		static void smethod_3(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Array.Copy(array_0, int_0, array_1, int_1, int_2);
		}

		static ArgumentNullException smethod_4(string string_0)
		{
			return new ArgumentNullException(string_0);
		}

		static bool smethod_5(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_6(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static ArgumentOutOfRangeException smethod_7(string string_0)
		{
			return new ArgumentOutOfRangeException(string_0);
		}

		static StringBuilder smethod_8()
		{
			return new StringBuilder();
		}

		static string smethod_9(object object_0)
		{
			return object_0.ToString();
		}
	}
}
