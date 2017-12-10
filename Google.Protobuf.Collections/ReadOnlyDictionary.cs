using System;
using System.Collections;
using System.Collections.Generic;

namespace Google.Protobuf.Collections
{
	internal sealed class ReadOnlyDictionary<TKey, TValue> : IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
	{
		private readonly IDictionary<TKey, TValue> wrapped;

		public ICollection<TKey> Keys
		{
			get
			{
				return this.wrapped.Keys;
			}
		}

		public ICollection<TValue> Values
		{
			get
			{
				return this.wrapped.Values;
			}
		}

		public TValue this[TKey key]
		{
			get
			{
				return this.wrapped[key];
			}
			set
			{
				throw ReadOnlyDictionary<TKey, TValue>.smethod_0();
			}
		}

		public int Count
		{
			get
			{
				return this.wrapped.Count;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		public ReadOnlyDictionary(IDictionary<TKey, TValue> wrapped)
		{
			this.wrapped = wrapped;
		}

		public void Add(TKey key, TValue value)
		{
			throw ReadOnlyDictionary<TKey, TValue>.smethod_0();
		}

		public bool ContainsKey(TKey key)
		{
			return this.wrapped.ContainsKey(key);
		}

		public bool Remove(TKey key)
		{
			throw ReadOnlyDictionary<TKey, TValue>.smethod_0();
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.wrapped.TryGetValue(key, out value);
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
			throw ReadOnlyDictionary<TKey, TValue>.smethod_0();
		}

		public void Clear()
		{
			throw ReadOnlyDictionary<TKey, TValue>.smethod_0();
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return this.wrapped.Contains(item);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			this.wrapped.CopyTo(array, arrayIndex);
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw ReadOnlyDictionary<TKey, TValue>.smethod_0();
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return this.wrapped.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ReadOnlyDictionary<TKey, TValue>.smethod_1(this.wrapped);
		}

		public override bool Equals(object obj)
		{
			return ReadOnlyDictionary<TKey, TValue>.smethod_2(this.wrapped, obj);
		}

		public override int GetHashCode()
		{
			return ReadOnlyDictionary<TKey, TValue>.smethod_3(this.wrapped);
		}

		public override string ToString()
		{
			return ReadOnlyDictionary<TKey, TValue>.smethod_4(this.wrapped);
		}

		static InvalidOperationException smethod_0()
		{
			return new InvalidOperationException();
		}

		static IEnumerator smethod_1(IEnumerable ienumerable_0)
		{
			return ienumerable_0.GetEnumerator();
		}

		static bool smethod_2(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		static int smethod_3(object object_0)
		{
			return object_0.GetHashCode();
		}

		static string smethod_4(object object_0)
		{
			return object_0.ToString();
		}
	}
}
