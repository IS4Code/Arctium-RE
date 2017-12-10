using Framework.Constants.Misc;
using Framework.Database.Auth.Entities;
using Framework.Logging;
using Framework.Misc;
using System;
using System.Collections.Concurrent;

namespace AuthServer.Managers
{
	internal class RealmManager : Singleton<RealmManager>
	{
		public readonly ConcurrentDictionary<int, Realm> RealmList;

		public bool IsInitialized
		{
			get;
			private set;
		}

		private RealmManager()
		{
			while (true)
			{
				IL_111:
				uint arg_F1_0 = 2027188306u;
				while (true)
				{
					uint num;
					switch ((num = (arg_F1_0 ^ 1042556165u)) % 5u)
					{
					case 0u:
					{
						Realm realm;
						Log.Message(LogType.Debug, Module.smethod_34<string>(1738116785u), new object[]
						{
							realm.Id,
							realm.Name
						});
						arg_F1_0 = (num * 1330193156u ^ 1395142242u);
						continue;
					}
					case 2u:
						this.IsInitialized = false;
						arg_F1_0 = (num * 350750606u ^ 838730833u);
						continue;
					case 3u:
						goto IL_111;
					case 4u:
					{
						this.RealmList = new ConcurrentDictionary<int, Realm>();
						Realm realm = new Realm
						{
							Id = 970,
							Name = Module.smethod_36<string>(3939559174u),
							IP = Module.smethod_34<string>(1831853397u),
							Port = 8100,
							Type = 0,
							Status = 1,
							Flags = 0
						};
						arg_F1_0 = ((this.RealmList.TryAdd(realm.Id, realm) ? 2709194853u : 2858204314u) ^ num * 92996644u);
						continue;
					}
					}
					return;
				}
			}
		}
	}
}
