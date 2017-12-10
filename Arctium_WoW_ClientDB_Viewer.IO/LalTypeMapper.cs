using System;
using System.Collections.Generic;

namespace Arctium_WoW_ClientDB_Viewer.IO
{
	internal class LalTypeMapper
	{
		public static Dictionary<string, Type> ReadValue = new Dictionary<string, Type>
		{
			{
				Module.smethod_33<string>(3603521510u),
				LalTypeMapper.smethod_0(typeof(bool).TypeHandle)
			},
			{
				Module.smethod_35<string>(1524474144u),
				LalTypeMapper.smethod_0(typeof(sbyte).TypeHandle)
			},
			{
				Module.smethod_35<string>(3217276998u),
				LalTypeMapper.smethod_0(typeof(byte).TypeHandle)
			},
			{
				Module.smethod_34<string>(1514091022u),
				LalTypeMapper.smethod_0(typeof(short).TypeHandle)
			},
			{
				Module.smethod_35<string>(4000718264u),
				LalTypeMapper.smethod_0(typeof(ushort).TypeHandle)
			},
			{
				Module.smethod_36<string>(2323869031u),
				LalTypeMapper.smethod_0(typeof(int).TypeHandle)
			},
			{
				Module.smethod_36<string>(5629522u),
				LalTypeMapper.smethod_0(typeof(uint).TypeHandle)
			},
			{
				Module.smethod_35<string>(3706998619u),
				LalTypeMapper.smethod_0(typeof(float).TypeHandle)
			},
			{
				Module.smethod_35<string>(2923557353u),
				LalTypeMapper.smethod_0(typeof(long).TypeHandle)
			},
			{
				Module.smethod_37<string>(2917594848u),
				LalTypeMapper.smethod_0(typeof(ulong).TypeHandle)
			},
			{
				Module.smethod_36<string>(3617573374u),
				LalTypeMapper.smethod_0(typeof(double).TypeHandle)
			},
			{
				Module.smethod_37<string>(2128715485u),
				LalTypeMapper.smethod_0(typeof(string).TypeHandle)
			},
			{
				Module.smethod_33<string>(3471772470u),
				LalTypeMapper.smethod_0(typeof(LalTypes.LalGroup).TypeHandle)
			},
			{
				Module.smethod_33<string>(1814069486u),
				LalTypeMapper.smethod_0(typeof(LalTypes.LalList).TypeHandle)
			},
			{
				Module.smethod_36<string>(2291928492u),
				LalTypeMapper.smethod_0(typeof(LalTypes.Bit).TypeHandle)
			}
		};

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}
}
