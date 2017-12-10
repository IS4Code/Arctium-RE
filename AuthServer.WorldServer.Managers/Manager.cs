using AuthServer.Game.Managers;
using Framework.Misc;
using System;

namespace AuthServer.WorldServer.Managers
{
	public class Manager
	{
		public static ActionManager ActionMgr;

		public static ObjectManager ObjectMgr;

		public static SkillManager SkillMgr;

		public static SpellManager SpellMgr;

		public static SpawnManager SpawnMgr;

		public static WorldManager WorldMgr;

		public static EquipmentManager Equipments;

		public static void Initialize()
		{
			Manager.ActionMgr = Singleton<ActionManager>.GetInstance();
			Manager.Equipments = Singleton<EquipmentManager>.GetInstance();
			while (true)
			{
				IL_67:
				uint arg_4B_0 = 636662863u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4B_0 ^ 2064959537u)) % 4u)
					{
					case 1u:
						Manager.SpellMgr = Singleton<SpellManager>.GetInstance();
						arg_4B_0 = (num * 436624283u ^ 3934160218u);
						continue;
					case 2u:
						Manager.SkillMgr = Singleton<SkillManager>.GetInstance();
						arg_4B_0 = (num * 3638131236u ^ 1896839496u);
						continue;
					case 3u:
						goto IL_67;
					}
					goto Block_1;
				}
			}
			Block_1:
			Manager.ObjectMgr = Singleton<ObjectManager>.GetInstance();
			Manager.WorldMgr = Singleton<WorldManager>.GetInstance();
			Manager.SpawnMgr = Singleton<SpawnManager>.GetInstance();
		}
	}
}
