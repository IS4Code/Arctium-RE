using Framework.Constants.Misc;
using Framework.Database.Auth.Entities;
using Framework.Logging;
using Framework.Misc;
using System;
using System.Collections.Generic;

namespace AuthServer.Managers
{
	internal class ModuleManager : Singleton<ModuleManager>
	{
		public readonly ListModule ModuleList;

		public readonly ListModule Module64List;

		public readonly ListModule ModuleMacList;

		private ModuleManager()
		{
			while (true)
			{
				IL_66:
				uint arg_4A_0 = 1511803485u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4A_0 ^ 770676634u)) % 4u)
					{
					case 0u:
						goto IL_66;
					case 1u:
						this.ModuleMacList = new ListModule();
						arg_4A_0 = (num * 4094155014u ^ 2835633086u);
						continue;
					case 3u:
						this.ModuleList = new ListModule();
						this.Module64List = new ListModule();
						arg_4A_0 = (num * 29915891u ^ 1375251382u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.UpdateModules();
		}

		public void UpdateModules()
		{
			Log.Message(LogType.Debug, Module.smethod_36<string>(1493557509u), Array.Empty<object>());
			while (true)
			{
				IL_3E5:
				uint arg_3A3_0 = 3898085660u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3A3_0 ^ 3322766058u)) % 13u)
					{
					case 0u:
					{
						Module item;
						this.ModuleMacList.Add(item);
						arg_3A3_0 = (num * 584349903u ^ 1706511698u);
						continue;
					}
					case 1u:
						Log.Message(LogType.Debug, Module.smethod_35<string>(2248033240u), new object[]
						{
							this.ModuleList.Count
						});
						arg_3A3_0 = (num * 2365859414u ^ 101854083u);
						continue;
					case 2u:
					{
						Module item2;
						this.ModuleList.Add(item2);
						Module item3 = new Module
						{
							Hash = Module.smethod_36<string>(4294715761u),
							Type = Module.smethod_36<string>(115771085u),
							Size = 0,
							Data = ""
						};
						this.ModuleList.Add(item3);
						arg_3A3_0 = (num * 1254024579u ^ 2984690686u);
						continue;
					}
					case 3u:
					{
						Module item4 = new Module
						{
							Hash = Module.smethod_35<string>(3549965418u),
							Type = Module.smethod_35<string>(3018081477u),
							Size = 321,
							Data = ""
						};
						this.ModuleMacList.Add(item4);
						Module item5 = new Module
						{
							Hash = Module.smethod_36<string>(3722531539u),
							Type = Module.smethod_34<string>(1753439462u),
							Size = 0,
							Data = ""
						};
						arg_3A3_0 = (num * 4123436389u ^ 3489384571u);
						continue;
					}
					case 4u:
					{
						Module item5;
						this.ModuleMacList.Add(item5);
						arg_3A3_0 = (num * 1500929652u ^ 1039204789u);
						continue;
					}
					case 5u:
						goto IL_3E5;
					case 6u:
					{
						Module item6 = new Module
						{
							Hash = Module.smethod_33<string>(363890763u),
							Type = Module.smethod_33<string>(2121968294u),
							Size = 512,
							Data = Module.smethod_36<string>(1140306251u)
						};
						this.Module64List.Add(item6);
						arg_3A3_0 = (num * 2646558481u ^ 2055126984u);
						continue;
					}
					case 7u:
					{
						Module item7 = new Module
						{
							Hash = Module.smethod_34<string>(556356528u),
							Type = Module.smethod_34<string>(1753439462u),
							Size = 321,
							Data = ""
						};
						this.Module64List.Add(item7);
						arg_3A3_0 = (num * 1010931423u ^ 936505321u);
						continue;
					}
					case 9u:
					{
						Module item8 = new Module
						{
							Hash = Module.smethod_37<string>(1344610424u),
							Type = Module.smethod_35<string>(3018081477u),
							Size = 512,
							Data = Module.smethod_33<string>(1470066224u)
						};
						this.ModuleList.Add(item8);
						Module item2 = new Module
						{
							Hash = Module.smethod_34<string>(1052702955u),
							Type = Module.smethod_33<string>(2121968294u),
							Size = 321,
							Data = ""
						};
						arg_3A3_0 = (num * 512836407u ^ 1160546673u);
						continue;
					}
					case 10u:
					{
						Module item = new Module
						{
							Hash = Module.smethod_37<string>(1958248753u),
							Type = Module.smethod_37<string>(1841303513u),
							Size = 512,
							Data = Module.smethod_33<string>(1470066224u)
						};
						arg_3A3_0 = (num * 2115783901u ^ 226394251u);
						continue;
					}
					case 11u:
					{
						Module item9;
						this.Module64List.Add(item9);
						arg_3A3_0 = (num * 3434466226u ^ 2447004371u);
						continue;
					}
					case 12u:
					{
						Module item9 = new Module
						{
							Hash = Module.smethod_36<string>(4129829668u),
							Type = Module.smethod_33<string>(2121968294u),
							Size = 0,
							Data = ""
						};
						arg_3A3_0 = (num * 3224331562u ^ 3809534528u);
						continue;
					}
					}
					return;
				}
			}
		}
	}
}
