using Framework.Misc;
using System;

namespace AuthServer.Managers
{
	internal class Manager
	{
		public static ComponentManager Components;

		public static ModuleManager Modules;

		public static RealmManager Realms;

		public static void Initialize()
		{
			Manager.Components = Singleton<ComponentManager>.GetInstance();
			while (true)
			{
				IL_40:
				uint arg_28_0 = 911271730u;
				while (true)
				{
					uint num;
					switch ((num = (arg_28_0 ^ 678096377u)) % 3u)
					{
					case 0u:
						goto IL_40;
					case 1u:
						Manager.Modules = Singleton<ModuleManager>.GetInstance();
						arg_28_0 = (num * 943526612u ^ 1299894418u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			Manager.Realms = Singleton<RealmManager>.GetInstance();
		}
	}
}
