using System;
using System.Reflection;
using System.Threading;

namespace Framework.Misc
{
	public abstract class Singleton<T> where T : class
	{
		private static object sync = Singleton<T>.smethod_4();

		private static T instance;

		public static T GetInstance()
		{
			object object_ = Singleton<T>.sync;
			bool flag = false;
			try
			{
				Singleton<T>.smethod_0(object_, ref flag);
				T result;
				while (true)
				{
					IL_77:
					uint arg_57_0 = 766018763u;
					while (true)
					{
						uint num;
						switch ((num = (arg_57_0 ^ 359265617u)) % 5u)
						{
						case 0u:
							goto IL_7E;
						case 1u:
							arg_57_0 = (((Singleton<T>.instance != null) ? 1848335579u : 1108333807u) ^ num * 124799509u);
							continue;
						case 2u:
							result = Singleton<T>.instance;
							arg_57_0 = (num * 764848325u ^ 39872962u);
							continue;
						case 3u:
							goto IL_77;
						}
						goto Block_4;
					}
				}
				Block_4:
				goto IL_80;
				IL_7E:
				return result;
				IL_80:;
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						IL_B7:
						uint arg_9F_0 = 1107217742u;
						while (true)
						{
							uint num;
							switch ((num = (arg_9F_0 ^ 359265617u)) % 3u)
							{
							case 1u:
								Singleton<T>.smethod_1(object_);
								arg_9F_0 = (num * 980933481u ^ 355050012u);
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
			return Singleton<T>.instance = (Singleton<T>.smethod_3(Singleton<T>.smethod_2(typeof(T).TypeHandle).method_0(BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null), new object[0]) as T);
		}

		static void smethod_0(object object_0, ref bool bool_0)
		{
			Monitor.Enter(object_0, ref bool_0);
		}

		static void smethod_1(object object_0)
		{
			Monitor.Exit(object_0);
		}

		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		ConstructorInfo method_0(BindingFlags bindingFlags_0, Binder binder_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
		{
			return base.GetConstructor(bindingFlags_0, binder_0, type_0, parameterModifier_0);
		}

		static object smethod_3(ConstructorInfo constructorInfo_0, object[] object_0)
		{
			return constructorInfo_0.Invoke(object_0);
		}

		static object smethod_4()
		{
			return new object();
		}
	}
}
