using Google.Protobuf.Compatibility;
using Google.Protobuf.Reflection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Google.Protobuf.Collections
{
	[ComVisible(true)]
	public sealed class MapField<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEquatable<MapField<TKey, TValue>>
	{
		private class DictionaryEnumerator : IEnumerator, IDictionaryEnumerator
		{
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;

			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			public DictionaryEntry Entry
			{
				get
				{
					return new DictionaryEntry(this.Key, this.Value);
				}
			}

			public object Key
			{
				get
				{
					KeyValuePair<TKey, TValue> current = this.enumerator.Current;
					return current.Key;
				}
			}

			public object Value
			{
				get
				{
					KeyValuePair<TKey, TValue> current = this.enumerator.Current;
					return current.Value;
				}
			}

			internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator)
			{
				this.enumerator = enumerator;
			}

			public bool MoveNext()
			{
				return MapField<TKey, TValue>.DictionaryEnumerator.smethod_0(this.enumerator);
			}

			public void Reset()
			{
				MapField<TKey, TValue>.DictionaryEnumerator.smethod_1(this.enumerator);
			}

			static bool smethod_0(IEnumerator ienumerator_0)
			{
				return ienumerator_0.MoveNext();
			}

			static void smethod_1(IEnumerator ienumerator_0)
			{
				ienumerator_0.Reset();
			}
		}

		public sealed class Codec
		{
			internal class MessageAdapter : IMessage
			{
				private readonly MapField<TKey, TValue>.Codec codec;

				internal TKey Key
				{
					get;
					set;
				}

				internal TValue Value
				{
					get;
					set;
				}

				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				internal MessageAdapter(MapField<TKey, TValue>.Codec codec)
				{
					while (true)
					{
						IL_39:
						uint arg_21_0 = 1370978205u;
						while (true)
						{
							uint num;
							switch ((num = (arg_21_0 ^ 960216553u)) % 3u)
							{
							case 0u:
								goto IL_39;
							case 1u:
								this.codec = codec;
								arg_21_0 = (num * 470956029u ^ 1170415337u);
								continue;
							}
							return;
						}
					}
				}

				internal void Reset()
				{
					this.Key = this.codec.keyCodec.DefaultValue;
					while (true)
					{
						IL_58:
						uint arg_40_0 = 1698209103u;
						while (true)
						{
							uint num;
							switch ((num = (arg_40_0 ^ 466210016u)) % 3u)
							{
							case 0u:
								goto IL_58;
							case 2u:
								this.Value = this.codec.valueCodec.DefaultValue;
								arg_40_0 = (num * 572990784u ^ 580878625u);
								continue;
							}
							return;
						}
					}
				}

				public void MergeFrom(CodedInputStream input)
				{
					while (true)
					{
						IL_112:
						uint num;
						uint arg_D7_0 = ((num = input.ReadTag()) != 0u) ? 3303032382u : 3356458653u;
						while (true)
						{
							uint num2;
							switch ((num2 = (arg_D7_0 ^ 3451716539u)) % 8u)
							{
							case 0u:
								goto IL_112;
							case 1u:
								input.SkipLastField();
								arg_D7_0 = 3676125403u;
								continue;
							case 2u:
								this.Key = this.codec.keyCodec.Read(input);
								arg_D7_0 = (num2 * 2290070049u ^ 4039667025u);
								continue;
							case 3u:
								this.Value = this.codec.valueCodec.Read(input);
								arg_D7_0 = (num2 * 3351502033u ^ 717773552u);
								continue;
							case 4u:
								arg_D7_0 = ((num == this.codec.valueCodec.Tag) ? 2864455040u : 3788498690u);
								continue;
							case 5u:
								arg_D7_0 = ((num != this.codec.keyCodec.Tag) ? 3819227879u : 3911048177u);
								continue;
							case 7u:
								arg_D7_0 = 3303032382u;
								continue;
							}
							return;
						}
					}
				}

				public void WriteTo(CodedOutputStream output)
				{
					this.codec.keyCodec.WriteTagAndValue(output, this.Key);
					this.codec.valueCodec.WriteTagAndValue(output, this.Value);
				}

				public int CalculateSize()
				{
					return this.codec.keyCodec.CalculateSizeWithTag(this.Key) + this.codec.valueCodec.CalculateSizeWithTag(this.Value);
				}
			}

			private readonly FieldCodec<TKey> keyCodec;

			private readonly FieldCodec<TValue> valueCodec;

			private readonly uint mapTag;

			internal uint MapTag
			{
				get
				{
					return this.mapTag;
				}
			}

			public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag)
			{
				this.keyCodec = keyCodec;
				this.valueCodec = valueCodec;
				this.mapTag = mapTag;
			}
		}

		private class MapView<T> : IEnumerable, ICollection, ICollection<T>, IEnumerable<T>
		{
			private readonly MapField<TKey, TValue> parent;

			private readonly Func<KeyValuePair<TKey, TValue>, T> projection;

			private readonly Func<T, bool> containsCheck;

			public int Count
			{
				get
				{
					return this.parent.Count;
				}
			}

			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			public bool IsSynchronized
			{
				get
				{
					return false;
				}
			}

			public object SyncRoot
			{
				get
				{
					return this.parent;
				}
			}

			internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck)
			{
				this.parent = parent;
				this.projection = projection;
				this.containsCheck = containsCheck;
			}

			public void Add(T item)
			{
				throw MapField<TKey, TValue>.MapView<T>.smethod_0();
			}

			public void Clear()
			{
				throw MapField<TKey, TValue>.MapView<T>.smethod_0();
			}

			public bool Contains(T item)
			{
				return this.containsCheck(item);
			}

			public void CopyTo(T[] array, int arrayIndex)
			{
				if (arrayIndex >= 0)
				{
					goto IL_49;
				}
				IL_13:
				int arg_1D_0 = -1120938110;
				IL_18:
				switch ((arg_1D_0 ^ -1829387815) % 5)
				{
				case 0:
					IL_49:
					arg_1D_0 = ((arrayIndex + this.Count < array.Length) ? -276659330 : -1024886501);
					goto IL_18;
				case 1:
					throw MapField<TKey, TValue>.MapView<T>.smethod_2(Module.smethod_35<string>(2082010867u), Module.smethod_33<string>(1880551425u));
				case 3:
					goto IL_132;
				case 4:
					goto IL_13;
				}
				IEnumerator<T> enumerator = this.GetEnumerator();
				try
				{
					while (true)
					{
						IL_E9:
						uint arg_BD_0 = (!MapField<TKey, TValue>.MapView<T>.smethod_3(enumerator)) ? 4009544974u : 2346551384u;
						while (true)
						{
							uint num;
							switch ((num = (arg_BD_0 ^ 2465579481u)) % 5u)
							{
							case 1u:
							{
								T current;
								array[arrayIndex++] = current;
								arg_BD_0 = (num * 1095831635u ^ 1260299999u);
								continue;
							}
							case 2u:
							{
								T current = enumerator.Current;
								arg_BD_0 = 3638568108u;
								continue;
							}
							case 3u:
								arg_BD_0 = 2346551384u;
								continue;
							case 4u:
								goto IL_E9;
							}
							goto Block_6;
						}
					}
					Block_6:
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							IL_12A:
							uint arg_112_0 = 2963618268u;
							while (true)
							{
								uint num;
								switch ((num = (arg_112_0 ^ 2465579481u)) % 3u)
								{
								case 1u:
									MapField<TKey, TValue>.MapView<T>.smethod_4(enumerator);
									arg_112_0 = (num * 647037918u ^ 1062834806u);
									continue;
								case 2u:
									goto IL_12A;
								}
								goto Block_10;
							}
						}
						Block_10:;
					}
				}
				IL_132:
				throw MapField<TKey, TValue>.MapView<T>.smethod_1(Module.smethod_34<string>(178897624u));
			}

			public IEnumerator<T> GetEnumerator()
			{
				return this.parent.list.Select(this.projection).GetEnumerator();
			}

			public bool Remove(T item)
			{
				throw MapField<TKey, TValue>.MapView<T>.smethod_0();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			public void CopyTo(Array array, int index)
			{
				if (index >= 0)
				{
					goto IL_49;
				}
				IL_13:
				int arg_1D_0 = -63406274;
				IL_18:
				switch ((arg_1D_0 ^ -289179319) % 5)
				{
				case 0:
					throw MapField<TKey, TValue>.MapView<T>.smethod_2(Module.smethod_35<string>(2082010867u), Module.smethod_37<string>(1194126108u));
				case 1:
					IL_49:
					arg_1D_0 = ((index + this.Count < MapField<TKey, TValue>.MapView<T>.smethod_5(array)) ? -182547107 : -411928083);
					goto IL_18;
				case 3:
					goto IL_13;
				case 4:
					goto IL_130;
				}
				IEnumerator<T> enumerator = this.GetEnumerator();
				try
				{
					while (true)
					{
						IL_E7:
						int arg_BF_0 = MapField<TKey, TValue>.MapView<T>.smethod_3(enumerator) ? -980863989 : -1838440544;
						while (true)
						{
							switch ((arg_BF_0 ^ -289179319) % 4)
							{
							case 0:
								arg_BF_0 = -980863989;
								continue;
							case 2:
							{
								T current = enumerator.Current;
								MapField<TKey, TValue>.MapView<T>.smethod_6(array, current, new int[]
								{
									index++
								});
								arg_BF_0 = -1938334234;
								continue;
							}
							case 3:
								goto IL_E7;
							}
							goto Block_6;
						}
					}
					Block_6:
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							IL_128:
							uint arg_110_0 = 2893450592u;
							while (true)
							{
								uint num;
								switch ((num = (arg_110_0 ^ 4005787977u)) % 3u)
								{
								case 0u:
									goto IL_128;
								case 1u:
									MapField<TKey, TValue>.MapView<T>.smethod_4(enumerator);
									arg_110_0 = (num * 3810399149u ^ 453040383u);
									continue;
								}
								goto Block_10;
							}
						}
						Block_10:;
					}
				}
				IL_130:
				throw MapField<TKey, TValue>.MapView<T>.smethod_1(Module.smethod_33<string>(1439392708u));
			}

			static NotSupportedException smethod_0()
			{
				return new NotSupportedException();
			}

			static ArgumentOutOfRangeException smethod_1(string string_0)
			{
				return new ArgumentOutOfRangeException(string_0);
			}

			static ArgumentException smethod_2(string string_0, string string_1)
			{
				return new ArgumentException(string_0, string_1);
			}

			static bool smethod_3(IEnumerator ienumerator_0)
			{
				return ienumerator_0.MoveNext();
			}

			static void smethod_4(IDisposable idisposable_0)
			{
				idisposable_0.Dispose();
			}

			static int smethod_5(Array array_0)
			{
				return array_0.Length;
			}

			static void smethod_6(Array array_0, object object_0, int[] int_0)
			{
				array_0.SetValue(object_0, int_0);
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MapField<TKey, TValue>.__c __9 = new MapField<TKey, TValue>.__c();

			public static Func<KeyValuePair<TKey, TValue>, TKey> __9__15_0;

			public static Func<KeyValuePair<TKey, TValue>, TValue> __9__17_0;

			public static Func<KeyValuePair<TKey, TValue>, DictionaryEntry> __9__43_0;

			internal TKey <get_Keys>b__15_0(KeyValuePair<TKey, TValue> pair)
			{
				return pair.Key;
			}

			internal TValue <get_Values>b__17_0(KeyValuePair<TKey, TValue> pair)
			{
				return pair.Value;
			}

			internal DictionaryEntry CopyTo>b__43_0(KeyValuePair<TKey, TValue> pair)
			{
				return new DictionaryEntry(pair.Key, pair.Value);
			}
		}

		private readonly bool allowNullValues;

		private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map = new Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>>();

		private readonly LinkedList<KeyValuePair<TKey, TValue>> list = new LinkedList<KeyValuePair<TKey, TValue>>();

		public TValue this[TKey key]
		{
			get
			{
				Preconditions.CheckNotNullUnconstrained<TKey>(key, Module.smethod_37<string>(2567348548u));
				TValue result;
				if (!this.TryGetValue(key, out result))
				{
					throw MapField<TKey, TValue>.smethod_3();
				}
				return result;
			}
			set
			{
				Preconditions.CheckNotNullUnconstrained<TKey>(key, Module.smethod_33<string>(3567910441u));
				LinkedListNode<KeyValuePair<TKey, TValue>> linkedListNode;
				while (true)
				{
					IL_134:
					uint arg_FF_0 = 3415560039u;
					while (true)
					{
						uint num;
						switch ((num = (arg_FF_0 ^ 3265137633u)) % 10u)
						{
						case 0u:
							goto IL_134;
						case 1u:
							arg_FF_0 = (((!this.map.TryGetValue(key, out linkedListNode)) ? 4013628177u : 2657022034u) ^ num * 3043306133u);
							continue;
						case 2u:
							arg_FF_0 = (((value == null) ? 198502020u : 1307246504u) ^ num * 2705987851u);
							continue;
						case 3u:
						{
							KeyValuePair<TKey, TValue> value2;
							linkedListNode = this.list.AddLast(value2);
							arg_FF_0 = 3962844499u;
							continue;
						}
						case 4u:
							Preconditions.CheckNotNullUnconstrained<TValue>(value, Module.smethod_34<string>(2130392831u));
							arg_FF_0 = (num * 2453653874u ^ 1806060698u);
							continue;
						case 5u:
							return;
						case 7u:
							arg_FF_0 = (((!this.allowNullValues) ? 713015442u : 611864865u) ^ num * 653702333u);
							continue;
						case 8u:
						{
							KeyValuePair<TKey, TValue> value2;
							linkedListNode.Value = value2;
							arg_FF_0 = (num * 2159750764u ^ 1373043468u);
							continue;
						}
						case 9u:
						{
							KeyValuePair<TKey, TValue> value2 = new KeyValuePair<TKey, TValue>(key, value);
							arg_FF_0 = 3433467366u;
							continue;
						}
						}
						goto Block_4;
					}
				}
				Block_4:
				this.map[key] = linkedListNode;
			}
		}

		public ICollection<TKey> Keys
		{
			get
			{
				Func<KeyValuePair<TKey, TValue>, TKey> arg_2D_1;
				if ((arg_2D_1 = MapField<TKey, TValue>.__c.__9__15_0) == null)
				{
					arg_2D_1 = (MapField<TKey, TValue>.__c.__9__15_0 = new Func<KeyValuePair<TKey, TValue>, TKey>(MapField<TKey, TValue>.__c.__9.<get_Keys>b__15_0));
				}
				return new MapField<TKey, TValue>.MapView<TKey>(this, arg_2D_1, new Func<TKey, bool>(this.ContainsKey));
			}
		}

		public ICollection<TValue> Values
		{
			get
			{
				Func<KeyValuePair<TKey, TValue>, TValue> arg_2C_1;
				if ((arg_2C_1 = MapField<TKey, TValue>.__c.__9__17_0) == null)
				{
					arg_2C_1 = (MapField<TKey, TValue>.__c.__9__17_0 = new Func<KeyValuePair<TKey, TValue>, TValue>(MapField<TKey, TValue>.__c.__9.<get_Values>b__17_0));
				}
				return new MapField<TKey, TValue>.MapView<TValue>(this, arg_2C_1, new Func<TValue, bool>(this.ContainsValue));
			}
		}

		public bool AllowsNullValues
		{
			get
			{
				return this.allowNullValues;
			}
		}

		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		ICollection IDictionary.Keys
		{
			get
			{
				return (ICollection)this.Keys;
			}
		}

		ICollection IDictionary.Values
		{
			get
			{
				return (ICollection)this.Values;
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

		object IDictionary.this[object key]
		{
			get
			{
				Preconditions.CheckNotNull<object>(key, Module.smethod_36<string>(2587547248u));
				TValue tValue;
				while (true)
				{
					IL_75:
					uint arg_55_0 = 3774691653u;
					while (true)
					{
						uint num;
						switch ((num = (arg_55_0 ^ 2379130955u)) % 5u)
						{
						case 0u:
							this.TryGetValue((TKey)((object)key), out tValue);
							arg_55_0 = 3929692879u;
							continue;
						case 2u:
							goto IL_83;
						case 3u:
							goto IL_75;
						case 4u:
							arg_55_0 = (((!(key is TKey)) ? 1194638497u : 1528963333u) ^ num * 1877142148u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:
				return tValue;
				IL_83:
				return null;
			}
			set
			{
				this[(TKey)((object)key)] = (TValue)((object)value);
			}
		}

		public MapField() : this(MapField<TKey, TValue>.smethod_0(typeof(IMessage).TypeHandle).IsAssignableFrom(MapField<TKey, TValue>.smethod_0(typeof(TValue).TypeHandle)) || MapField<TKey, TValue>.smethod_1(MapField<TKey, TValue>.smethod_0(typeof(TValue).TypeHandle)) != null)
		{
		}

		public MapField(bool allowNullValues)
		{
			while (true)
			{
				IL_E2:
				uint arg_BA_0 = 3904158003u;
				while (true)
				{
					uint num;
					switch ((num = (arg_BA_0 ^ 3345331615u)) % 7u)
					{
					case 0u:
						arg_BA_0 = (((MapField<TKey, TValue>.smethod_1(MapField<TKey, TValue>.smethod_0(typeof(TValue).TypeHandle)) != null) ? 1562219801u : 1691107887u) ^ num * 3872711468u);
						continue;
					case 2u:
						goto IL_E9;
					case 3u:
						this.allowNullValues = allowNullValues;
						arg_BA_0 = 3112878605u;
						continue;
					case 4u:
						goto IL_E2;
					case 5u:
						arg_BA_0 = ((MapField<TKey, TValue>.smethod_0(typeof(TValue).TypeHandle).IsValueType() ? 1307305448u : 695315327u) ^ num * 3095455947u);
						continue;
					case 6u:
						arg_BA_0 = ((allowNullValues ? 79455233u : 295020405u) ^ num * 3160987932u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			return;
			IL_E9:
			throw MapField<TKey, TValue>.smethod_2(Module.smethod_34<string>(2841932638u), Module.smethod_36<string>(4005735678u));
		}

		public MapField<TKey, TValue> Clone()
		{
			MapField<TKey, TValue> mapField = new MapField<TKey, TValue>(this.allowNullValues);
			while (true)
			{
				IL_56:
				uint arg_3E_0 = 1167686490u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3E_0 ^ 1021116184u)) % 3u)
					{
					case 1u:
						if (MapField<TKey, TValue>.smethod_0(typeof(IDeepCloneable<TValue>).TypeHandle).IsAssignableFrom(MapField<TKey, TValue>.smethod_0(typeof(TValue).TypeHandle)))
						{
							arg_3E_0 = (num * 2024535756u ^ 3090371646u);
							continue;
						}
						goto IL_115;
					case 2u:
						goto IL_56;
					}
					goto Block_2;
				}
			}
			Block_2:
			using (LinkedList<KeyValuePair<TKey, TValue>>.Enumerator enumerator = this.list.GetEnumerator())
			{
				while (true)
				{
					IL_F7:
					int arg_CF_0 = (!enumerator.MoveNext()) ? 1304906255 : 671437898;
					while (true)
					{
						switch ((arg_CF_0 ^ 1021116184) % 4)
						{
						case 0:
							arg_CF_0 = 671437898;
							continue;
						case 1:
							goto IL_F7;
						case 2:
						{
							KeyValuePair<TKey, TValue> current = enumerator.Current;
							mapField.Add(current.Key, (current.Value == null) ? current.Value : ((IDeepCloneable<TValue>)((object)current.Value)).Clone());
							arg_CF_0 = 423902397;
							continue;
						}
						}
						goto Block_6;
					}
				}
				Block_6:
				return mapField;
			}
			IL_115:
			mapField.Add(this);
			return mapField;
		}

		public void Add(TKey key, TValue value)
		{
			if (!this.ContainsKey(key))
			{
				goto IL_2D;
			}
			IL_09:
			int arg_13_0 = -757706476;
			IL_0E:
			switch ((arg_13_0 ^ -1805234047) % 4)
			{
			case 1:
				throw MapField<TKey, TValue>.smethod_2(Module.smethod_37<string>(4291170940u), Module.smethod_36<string>(2587547248u));
			case 2:
				goto IL_09;
			case 3:
				IL_2D:
				this[key] = value;
				arg_13_0 = -1647647475;
				goto IL_0E;
			}
		}

		public bool ContainsKey(TKey key)
		{
			Preconditions.CheckNotNullUnconstrained<TKey>(key, Module.smethod_33<string>(3567910441u));
			return this.map.ContainsKey(key);
		}

		private bool ContainsValue(TValue value)
		{
			EqualityComparer<TValue> comparer;
			TValue value;
			while (true)
			{
				IL_44:
				uint arg_2C_0 = 3055675477u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2C_0 ^ 2190345178u)) % 3u)
					{
					case 0u:
						goto IL_44;
					case 2u:
						value = value2;
						comparer = EqualityComparer<TValue>.Default;
						arg_2C_0 = (num * 92960453u ^ 3129934038u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return this.list.Any((KeyValuePair<TKey, TValue> pair) => comparer.Equals(pair.Value, value));
		}

		public bool Remove(TKey key)
		{
			Preconditions.CheckNotNullUnconstrained<TKey>(key, Module.smethod_37<string>(2567348548u));
			while (true)
			{
				IL_8F:
				uint arg_6F_0 = 544457277u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6F_0 ^ 96975899u)) % 5u)
					{
					case 0u:
					{
						this.map.Remove(key);
						LinkedListNode<KeyValuePair<TKey, TValue>> linkedListNode;
						linkedListNode.List.Remove(linkedListNode);
						arg_6F_0 = (num * 2794647973u ^ 2809640284u);
						continue;
					}
					case 1u:
					{
						LinkedListNode<KeyValuePair<TKey, TValue>> linkedListNode;
						arg_6F_0 = ((this.map.TryGetValue(key, out linkedListNode) ? 1991666715u : 1512426622u) ^ num * 4135140928u);
						continue;
					}
					case 3u:
						return true;
					case 4u:
						goto IL_8F;
					}
					return false;
				}
			}
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			LinkedListNode<KeyValuePair<TKey, TValue>> linkedListNode;
			if (!this.map.TryGetValue(key, out linkedListNode))
			{
				goto IL_34;
			}
			IL_10:
			int arg_1A_0 = -461974596;
			IL_15:
			switch ((arg_1A_0 ^ -1272543825) % 4)
			{
			case 0:
				IL_34:
				value = default(TValue);
				arg_1A_0 = -644787390;
				goto IL_15;
			case 2:
				goto IL_10;
			case 3:
				value = linkedListNode.Value.Value;
				return true;
			}
			return false;
		}

		public void Add(IDictionary<TKey, TValue> entries)
		{
			Preconditions.CheckNotNull<IDictionary<TKey, TValue>>(entries, Module.smethod_33<string>(3785211131u));
			IEnumerator<KeyValuePair<TKey, TValue>> enumerator = entries.GetEnumerator();
			try
			{
				while (true)
				{
					IL_8F:
					uint arg_63_0 = (!MapField<TKey, TValue>.smethod_4(enumerator)) ? 102600442u : 570581804u;
					while (true)
					{
						uint num;
						switch ((num = (arg_63_0 ^ 1421198152u)) % 5u)
						{
						case 1u:
						{
							KeyValuePair<TKey, TValue> current = enumerator.Current;
							arg_63_0 = 553006614u;
							continue;
						}
						case 2u:
						{
							KeyValuePair<TKey, TValue> current;
							this.Add(current.Key, current.Value);
							arg_63_0 = (num * 2408826796u ^ 1151598044u);
							continue;
						}
						case 3u:
							goto IL_8F;
						case 4u:
							arg_63_0 = 570581804u;
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
						IL_D0:
						uint arg_B8_0 = 1818409970u;
						while (true)
						{
							uint num;
							switch ((num = (arg_B8_0 ^ 1421198152u)) % 3u)
							{
							case 1u:
								MapField<TKey, TValue>.smethod_5(enumerator);
								arg_B8_0 = (num * 4118747341u ^ 3137542146u);
								continue;
							case 2u:
								goto IL_D0;
							}
							goto Block_7;
						}
					}
					Block_7:;
				}
			}
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
			this.Add(item.Key, item.Value);
		}

		public void Clear()
		{
			this.list.Clear();
			while (true)
			{
				IL_42:
				uint arg_2A_0 = 3452911788u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2A_0 ^ 3797466243u)) % 3u)
					{
					case 0u:
						goto IL_42;
					case 2u:
						this.map.Clear();
						arg_2A_0 = (num * 2415783751u ^ 92902320u);
						continue;
					}
					return;
				}
			}
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			TValue y;
			return this.TryGetValue(item.Key, out y) && EqualityComparer<TValue>.Default.Equals(item.Value, y);
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			this.list.CopyTo(array, arrayIndex);
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			if (item.Key == null)
			{
				goto IL_A5;
			}
			goto IL_EA;
			uint arg_AF_0;
			LinkedListNode<KeyValuePair<TKey, TValue>> linkedListNode;
			while (true)
			{
				IL_AA:
				uint num;
				switch ((num = (arg_AF_0 ^ 1816634761u)) % 8u)
				{
				case 0u:
					goto IL_A5;
				case 1u:
					goto IL_105;
				case 2u:
					this.map.Remove(item.Key);
					arg_AF_0 = (num * 124005834u ^ 1014048690u);
					continue;
				case 4u:
					goto IL_EA;
				case 5u:
					return true;
				case 6u:
					arg_AF_0 = (((!EqualityComparer<TValue>.Default.Equals(item.Value, linkedListNode.Value.Value)) ? 3133751758u : 4017588495u) ^ num * 1239991746u);
					continue;
				case 7u:
					linkedListNode.List.Remove(linkedListNode);
					arg_AF_0 = (num * 1688063827u ^ 3535056073u);
					continue;
				}
				break;
			}
			return false;
			IL_105:
			throw MapField<TKey, TValue>.smethod_2(Module.smethod_33<string>(685397630u), Module.smethod_37<string>(2888741661u));
			IL_A5:
			arg_AF_0 = 327567640u;
			goto IL_AA;
			IL_EA:
			arg_AF_0 = (this.map.TryGetValue(item.Key, out linkedListNode) ? 1422474855u : 2097746322u);
			goto IL_AA;
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MapField<TKey, TValue>);
		}

		public override int GetHashCode()
		{
			EqualityComparer<TValue> @default = EqualityComparer<TValue>.Default;
			int num = 0;
			using (LinkedList<KeyValuePair<TKey, TValue>>.Enumerator enumerator = this.list.GetEnumerator())
			{
				while (true)
				{
					IL_AA:
					uint arg_7A_0 = enumerator.MoveNext() ? 1713585246u : 1482543118u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_7A_0 ^ 1202140775u)) % 5u)
						{
						case 0u:
							arg_7A_0 = 1713585246u;
							continue;
						case 2u:
						{
							KeyValuePair<TKey, TValue> current = enumerator.Current;
							arg_7A_0 = 2141861222u;
							continue;
						}
						case 3u:
						{
							int arg_4F_0 = num;
							KeyValuePair<TKey, TValue> current;
							TKey key = current.Key;
							num = (arg_4F_0 ^ key.GetHashCode() * 31 + @default.GetHashCode(current.Value));
							arg_7A_0 = (num2 * 75704509u ^ 3881396042u);
							continue;
						}
						case 4u:
							goto IL_AA;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			return num;
		}

		public bool Equals(MapField<TKey, TValue> other)
		{
			if (other == null)
			{
				goto IL_39;
			}
			goto IL_78;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ 559718338) % 7)
				{
				case 0:
					goto IL_39;
				case 2:
					goto IL_78;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					arg_43_0 = ((other.Count != this.Count) ? 506021359 : 1637480932);
					continue;
				case 6:
					return false;
				}
				break;
			}
			EqualityComparer<TValue> @default = EqualityComparer<TValue>.Default;
			IEnumerator<KeyValuePair<TKey, TValue>> enumerator = this.GetEnumerator();
			try
			{
				bool result;
				while (true)
				{
					IL_169:
					uint arg_128_0 = (!MapField<TKey, TValue>.smethod_4(enumerator)) ? 1843242525u : 456522231u;
					while (true)
					{
						uint num;
						switch ((num = (arg_128_0 ^ 559718338u)) % 9u)
						{
						case 0u:
							arg_128_0 = 456522231u;
							continue;
						case 1u:
							goto IL_169;
						case 2u:
							goto IL_176;
						case 3u:
						{
							KeyValuePair<TKey, TValue> current = enumerator.Current;
							arg_128_0 = 970870785u;
							continue;
						}
						case 4u:
						{
							KeyValuePair<TKey, TValue> current;
							TValue x;
							arg_128_0 = (((!other.TryGetValue(current.Key, out x)) ? 783368694u : 1583793443u) ^ num * 4150100105u);
							continue;
						}
						case 5u:
						{
							KeyValuePair<TKey, TValue> current;
							TValue x;
							arg_128_0 = (@default.Equals(x, current.Value) ? 1170131668u : 1900238166u);
							continue;
						}
						case 6u:
							result = false;
							arg_128_0 = (num * 1044707454u ^ 1785143649u);
							continue;
						case 7u:
							goto IL_17B;
						}
						goto Block_9;
					}
				}
				Block_9:
				goto IL_17D;
				IL_176:
				result = false;
				IL_17B:
				return result;
				IL_17D:;
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_1B6:
						uint arg_19D_0 = 1947491883u;
						while (true)
						{
							uint num;
							switch ((num = (arg_19D_0 ^ 559718338u)) % 3u)
							{
							case 0u:
								goto IL_1B6;
							case 1u:
								MapField<TKey, TValue>.smethod_5(enumerator);
								arg_19D_0 = (num * 4229434066u ^ 1546059497u);
								continue;
							}
							goto Block_13;
						}
					}
					Block_13:;
				}
			}
			return true;
			IL_39:
			arg_43_0 = 673969793;
			goto IL_3E;
			IL_78:
			arg_43_0 = ((other == this) ? 1909058213 : 1358360491);
			goto IL_3E;
		}

		public void AddEntriesFrom(CodedInputStream input, MapField<TKey, TValue>.Codec codec)
		{
			MapField<TKey, TValue>.Codec.MessageAdapter messageAdapter = new MapField<TKey, TValue>.Codec.MessageAdapter(codec);
			while (true)
			{
				IL_93:
				uint arg_73_0 = 628691396u;
				while (true)
				{
					uint num;
					switch ((num = (arg_73_0 ^ 371428270u)) % 5u)
					{
					case 0u:
						goto IL_93;
					case 1u:
						messageAdapter.Reset();
						arg_73_0 = 698242948u;
						continue;
					case 3u:
						this[messageAdapter.Key] = messageAdapter.Value;
						arg_73_0 = ((input.MaybeConsumeTag(codec.MapTag) ? 2330632738u : 2210537095u) ^ num * 1602454558u);
						continue;
					case 4u:
						input.ReadMessage(messageAdapter);
						arg_73_0 = (num * 1112167940u ^ 2093906651u);
						continue;
					}
					return;
				}
			}
		}

		public void WriteTo(CodedOutputStream output, MapField<TKey, TValue>.Codec codec)
		{
			MapField<TKey, TValue>.Codec.MessageAdapter messageAdapter = new MapField<TKey, TValue>.Codec.MessageAdapter(codec);
			using (LinkedList<KeyValuePair<TKey, TValue>>.Enumerator enumerator = this.list.GetEnumerator())
			{
				while (true)
				{
					IL_BD:
					uint arg_8A_0 = (!enumerator.MoveNext()) ? 1636633820u : 470078609u;
					while (true)
					{
						uint num;
						switch ((num = (arg_8A_0 ^ 527457419u)) % 6u)
						{
						case 0u:
							goto IL_BD;
						case 1u:
						{
							KeyValuePair<TKey, TValue> current;
							messageAdapter.Value = current.Value;
							output.WriteTag(codec.MapTag);
							arg_8A_0 = (num * 175971974u ^ 1001509484u);
							continue;
						}
						case 2u:
						{
							KeyValuePair<TKey, TValue> current = enumerator.Current;
							messageAdapter.Key = current.Key;
							arg_8A_0 = 1275309530u;
							continue;
						}
						case 4u:
							arg_8A_0 = 470078609u;
							continue;
						case 5u:
							output.WriteMessage(messageAdapter);
							arg_8A_0 = (num * 2751932437u ^ 2518150680u);
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
		}

		public int CalculateSize(MapField<TKey, TValue>.Codec codec)
		{
			if (this.Count != 0)
			{
				goto IL_2F;
			}
			IL_08:
			int arg_12_0 = 121135447;
			IL_0D:
			MapField<TKey, TValue>.Codec.MessageAdapter messageAdapter;
			int num;
			switch ((arg_12_0 ^ 708469546) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return 0;
			case 2:
				IL_2F:
				messageAdapter = new MapField<TKey, TValue>.Codec.MessageAdapter(codec);
				num = 0;
				arg_12_0 = 1229441325;
				goto IL_0D;
			}
			using (LinkedList<KeyValuePair<TKey, TValue>>.Enumerator enumerator = this.list.GetEnumerator())
			{
				while (true)
				{
					IL_FE:
					uint arg_CA_0 = enumerator.MoveNext() ? 371096569u : 2082850424u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_CA_0 ^ 708469546u)) % 6u)
						{
						case 0u:
						{
							KeyValuePair<TKey, TValue> current;
							messageAdapter.Key = current.Key;
							messageAdapter.Value = current.Value;
							num += CodedOutputStream.ComputeRawVarint32Size(codec.MapTag);
							arg_CA_0 = (num2 * 2680746663u ^ 3971763513u);
							continue;
						}
						case 1u:
						{
							KeyValuePair<TKey, TValue> current = enumerator.Current;
							arg_CA_0 = 1610495656u;
							continue;
						}
						case 2u:
							arg_CA_0 = 371096569u;
							continue;
						case 3u:
							num += CodedOutputStream.ComputeMessageSize(messageAdapter);
							arg_CA_0 = (num2 * 3258543750u ^ 4285265397u);
							continue;
						case 5u:
							goto IL_FE;
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
			return num;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = MapField<TKey, TValue>.smethod_6();
			JsonFormatter.Default.WriteDictionary(stringBuilder, this);
			return MapField<TKey, TValue>.smethod_7(stringBuilder);
		}

		void IDictionary.Add(object key, object value)
		{
			this.Add((TKey)((object)key), (TValue)((object)value));
		}

		bool IDictionary.Contains(object key)
		{
			return key is TKey && this.ContainsKey((TKey)((object)key));
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new MapField<TKey, TValue>.DictionaryEnumerator(this.GetEnumerator());
		}

		void IDictionary.Remove(object key)
		{
			Preconditions.CheckNotNull<object>(key, Module.smethod_34<string>(2908005883u));
			while (true)
			{
				IL_73:
				uint arg_53_0 = 3880966263u;
				while (true)
				{
					uint num;
					switch ((num = (arg_53_0 ^ 3305223996u)) % 5u)
					{
					case 0u:
						goto IL_73;
					case 1u:
						this.Remove((TKey)((object)key));
						arg_53_0 = 2755177987u;
						continue;
					case 3u:
						arg_53_0 = (((key is TKey) ? 3477137443u : 3012356763u) ^ num * 3160732414u);
						continue;
					case 4u:
						return;
					}
					return;
				}
			}
		}

		void ICollection.CopyTo(Array array, int index)
		{
			Func<KeyValuePair<TKey, TValue>, DictionaryEntry> arg_20_1;
			if ((arg_20_1 = MapField<TKey, TValue>.__c.__9__43_0) == null)
			{
				arg_20_1 = (MapField<TKey, TValue>.__c.__9__43_0 = new Func<KeyValuePair<TKey, TValue>, DictionaryEntry>(MapField<TKey, TValue>.__c.__9.<System.Collections.ICollection.CopyTo>b__43_0));
			}
			MapField<TKey, TValue>.smethod_8(this.Select(arg_20_1).ToList<DictionaryEntry>(), array, index);
		}

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static Type smethod_1(Type type_0)
		{
			return Nullable.GetUnderlyingType(type_0);
		}

		static ArgumentException smethod_2(string string_0, string string_1)
		{
			return new ArgumentException(string_0, string_1);
		}

		static KeyNotFoundException smethod_3()
		{
			return new KeyNotFoundException();
		}

		static bool smethod_4(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		static void smethod_5(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		static StringBuilder smethod_6()
		{
			return new StringBuilder();
		}

		static string smethod_7(object object_0)
		{
			return object_0.ToString();
		}

		static void smethod_8(ICollection icollection_0, Array array_0, int int_0)
		{
			icollection_0.CopyTo(array_0, int_0);
		}
	}
}
