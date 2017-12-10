using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class GeneratedCodeInfo
	{
		private static readonly string[] EmptyNames = new string[0];

		private static readonly GeneratedCodeInfo[] EmptyCodeInfo;

		public Type ClrType
		{
			get;
			private set;
		}

		public MessageParser Parser
		{
			[CompilerGenerated]
			get
			{
				return this.<Parser>k__BackingField;
			}
		}

		public string[] PropertyNames
		{
			[CompilerGenerated]
			get
			{
				return this.<PropertyNames>k__BackingField;
			}
		}

		public string[] OneofNames
		{
			[CompilerGenerated]
			get
			{
				return this.<OneofNames>k__BackingField;
			}
		}

		public GeneratedCodeInfo[] NestedTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<NestedTypes>k__BackingField;
			}
		}

		public Type[] NestedEnums
		{
			[CompilerGenerated]
			get
			{
				return this.<NestedEnums>k__BackingField;
			}
		}

		public GeneratedCodeInfo(Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, Type[] nestedEnums, GeneratedCodeInfo[] nestedTypes)
		{
			this.<NestedTypes>k__BackingField = (nestedTypes ?? GeneratedCodeInfo.EmptyCodeInfo);
			this.<NestedEnums>k__BackingField = (nestedEnums ?? ReflectionUtil.EmptyTypes);
			this.ClrType = clrType;
			this.<Parser>k__BackingField = parser;
			this.<PropertyNames>k__BackingField = (propertyNames ?? GeneratedCodeInfo.EmptyNames);
			this.<OneofNames>k__BackingField = (oneofNames ?? GeneratedCodeInfo.EmptyNames);
		}

		public GeneratedCodeInfo(Type[] nestedEnums, GeneratedCodeInfo[] nestedTypes) : this(null, null, null, null, nestedEnums, nestedTypes)
		{
		}

		static GeneratedCodeInfo()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_42:
				uint arg_2A_0 = 2571341516u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2A_0 ^ 2460218854u)) % 3u)
					{
					case 0u:
						goto IL_42;
					case 1u:
						GeneratedCodeInfo.EmptyCodeInfo = new GeneratedCodeInfo[0];
						arg_2A_0 = (num * 3084454570u ^ 3938460172u);
						continue;
					}
					return;
				}
			}
		}
	}
}
