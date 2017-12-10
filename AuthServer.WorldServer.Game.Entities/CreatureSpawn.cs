using AuthServer.WorldServer.Managers;
using Framework.ObjectDefines;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AuthServer.WorldServer.Game.Entities
{
	[Serializable]
	public class CreatureSpawn : WorldObject
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly CreatureSpawn.__c __9 = new CreatureSpawn.__c();

			public static Func<ulong, ulong> __9__5_0;

			internal ulong <GetLastGuid>b__5_0(ulong k)
			{
				return k;
			}
		}

		public int Id;

		public Creature Creature;

		public int Emote;

		public ConcurrentBag<Waypoint> Waypoints;

		public CreatureSpawn(int updateLength = 212) : base(updateLength)
		{
			this.Waypoints = new ConcurrentBag<Waypoint>();
		}

		public static ulong GetLastGuid()
		{
			IEnumerable<ulong> arg_2E_0 = Manager.SpawnMgr.CreatureSpawns.Keys;
			Func<ulong, ulong> arg_2E_1;
			if ((arg_2E_1 = CreatureSpawn.__c.__9__5_0) == null)
			{
				arg_2E_1 = (CreatureSpawn.__c.__9__5_0 = new Func<ulong, ulong>(CreatureSpawn.__c.__9.<GetLastGuid>b__5_0));
			}
			return arg_2E_0.OrderByDescending(arg_2E_1).FirstOrDefault<ulong>();
		}

		public void CreateFullGuid()
		{
			this.SGuid = new SmartGuid(this.Guid, this.Id, GuidType.Creature, (ulong)this.Map);
			this.Guid = this.SGuid.Guid;
		}

		public void CreateData(Creature creature)
		{
			this.Creature = creature;
		}

		public bool AddToDB()
		{
			Manager.SpawnMgr.AddSpawn(new CreatureSpawn(212)
			{
				Id = this.Id,
				Creature = this.Creature,
				Guid = CreatureSpawn.GetLastGuid() + 1uL,
				Map = this.Map,
				Position = new Vector4
				{
					X = this.Position.X,
					Y = this.Position.Y,
					Z = this.Position.Z,
					O = this.Position.O
				}
			});
			return true;
		}

		public void AddToWorld()
		{
			this.CreateFullGuid();
			this.CreateData(this.Creature);
			Manager.SpawnMgr.AddSpawn(this);
		}

		public override void SetUpdateFields()
		{
			base.SetUpdateField<ulong>(0, this.Guid, 0);
			while (true)
			{
				IL_836:
				uint arg_750_0 = 237886523u;
				while (true)
				{
					uint num;
					switch ((num = (arg_750_0 ^ 1528320836u)) % 54u)
					{
					case 0u:
						base.SetUpdateField<int>(64, 1, 0);
						arg_750_0 = (num * 3610745583u ^ 1838084446u);
						continue;
					case 1u:
					{
						int num2;
						base.SetUpdateField<int>(153 + num2, 0, 0);
						arg_750_0 = (num * 1619586627u ^ 3244614014u);
						continue;
					}
					case 2u:
						base.SetUpdateField<ulong>(124, 0uL, 0);
						arg_750_0 = (num * 1812117381u ^ 2456935444u);
						continue;
					case 3u:
						base.SetUpdateField<float>(117, 1f, 0);
						arg_750_0 = (num * 3565188234u ^ 1477123020u);
						continue;
					case 4u:
						goto IL_836;
					case 5u:
					{
						int num2;
						arg_750_0 = ((num2 >= 7) ? 269169050u : 586025614u);
						continue;
					}
					case 6u:
					{
						int num3;
						arg_750_0 = ((num3 >= 6) ? 571949700u : 737065791u);
						continue;
					}
					case 7u:
						base.SetUpdateField<int>(162, 1, 0);
						arg_750_0 = (num * 3907973660u ^ 3394182677u);
						continue;
					case 8u:
						base.SetUpdateField<int>(96, 0, 0);
						base.SetUpdateField<int>(97, 0, 0);
						arg_750_0 = (num * 2028371504u ^ 707893916u);
						continue;
					case 9u:
					{
						int num4;
						arg_750_0 = ((num4 < 6) ? 909025174u : 762720453u);
						continue;
					}
					case 10u:
					{
						int num4;
						base.SetUpdateField<int>(66 + num4, 0, 0);
						arg_750_0 = 1935149233u;
						continue;
					}
					case 11u:
					{
						int num5;
						base.SetUpdateField<int>(127 + num5, 1, 0);
						arg_750_0 = 757635734u;
						continue;
					}
					case 12u:
					{
						int num2;
						base.SetUpdateField<int>(146 + num2, 0, 0);
						arg_750_0 = (num * 2435287739u ^ 3658749741u);
						continue;
					}
					case 13u:
						base.SetUpdateField<float>(109, 0f, 0);
						arg_750_0 = (num * 4016325890u ^ 1225666739u);
						continue;
					case 14u:
						base.SetUpdateField<int>(89, 7, 0);
						arg_750_0 = (num * 2262316087u ^ 180881922u);
						continue;
					case 15u:
					{
						int num3;
						num3++;
						arg_750_0 = (num * 1322641156u ^ 2613785378u);
						continue;
					}
					case 16u:
						base.SetUpdateField<int>(164, 0, 0);
						base.SetUpdateField<int>(168, 0, 0);
						arg_750_0 = (num * 1093106460u ^ 3967094936u);
						continue;
					case 17u:
						base.SetUpdateField<float>(110, 0f, 0);
						base.SetUpdateField<float>(111, 0f, 0);
						arg_750_0 = (num * 631746108u ^ 281948068u);
						continue;
					case 18u:
						base.SetUpdateField<int>(165, 0, 0);
						base.SetUpdateField<int>(169, 0, 0);
						base.SetUpdateField<float>(173, 0f, 0);
						base.SetUpdateField<float>(174, 0f, 0);
						base.SetUpdateField<float>(167, 0f, 0);
						arg_750_0 = (num * 1283258722u ^ 511658920u);
						continue;
					case 19u:
						base.SetUpdateField<int>(107, 0, 0);
						arg_750_0 = (num * 3419386998u ^ 3627557574u);
						continue;
					case 20u:
					{
						int num2 = 0;
						arg_750_0 = (num * 1883164299u ^ 2313590937u);
						continue;
					}
					case 21u:
					{
						SmartGuid smartGuid = new SmartGuid(this.Guid, this.Id, GuidType.Creature, (ulong)this.Map);
						base.SetUpdateField<ulong>(2, smartGuid.HighGuid, 0);
						base.SetUpdateField<ulong>(4, 0uL, 0);
						base.SetUpdateField<int>(9, this.Id, 0);
						arg_750_0 = (num * 2255509972u ^ 1618986453u);
						continue;
					}
					case 22u:
						base.SetUpdateField<int>(54, 0, 0);
						base.SetUpdateField<int>(105, this.Creature.DisplayInfoId[0], 0);
						arg_750_0 = (num * 1813632837u ^ 2273520395u);
						continue;
					case 24u:
					{
						int num5;
						arg_750_0 = ((num5 >= 5) ? 1782073348u : 1144773961u);
						continue;
					}
					case 25u:
						arg_750_0 = (num * 4148259167u ^ 2514504695u);
						continue;
					case 26u:
						base.SetUpdateField<float>(11, 1f, 0);
						arg_750_0 = (num * 1625486723u ^ 3338259225u);
						continue;
					case 27u:
					{
						int num5;
						base.SetUpdateField<int>(135 + num5, 0, 0);
						arg_750_0 = (num * 3130670064u ^ 629823659u);
						continue;
					}
					case 28u:
						base.SetUpdateField<float>(189, 1f, 0);
						arg_750_0 = (((this.Id == 114791) ? 735727167u : 1522774325u) ^ num * 3193800621u);
						continue;
					case 29u:
						base.SetUpdateField<float>(190, 6f, 0);
						base.SetUpdateField<int>(54, 1, 0);
						arg_750_0 = (num * 162856968u ^ 183126627u);
						continue;
					case 30u:
						base.SetUpdateField<short>(102, 0, 0);
						arg_750_0 = (num * 2555578126u ^ 3095029771u);
						continue;
					case 31u:
						base.SetUpdateField<int>(106, this.Creature.DisplayInfoId[0], 0);
						arg_750_0 = (num * 4103549470u ^ 1174276495u);
						continue;
					case 32u:
						base.SetUpdateField<float>(103, 0.389f, 0);
						arg_750_0 = (num * 2633248044u ^ 2667827738u);
						continue;
					case 33u:
					{
						int num5;
						num5++;
						arg_750_0 = (num * 3145927869u ^ 370126679u);
						continue;
					}
					case 34u:
						base.SetUpdateField<int>(96, 33088, 0);
						arg_750_0 = (num * 640744838u ^ 3801238860u);
						continue;
					case 35u:
					{
						int num4;
						num4++;
						arg_750_0 = (num * 2594117446u ^ 2099580485u);
						continue;
					}
					case 36u:
					{
						int num4 = 0;
						arg_750_0 = (num * 1354476460u ^ 2712581059u);
						continue;
					}
					case 37u:
						base.SetUpdateField<int>(56, 1, 0);
						arg_750_0 = (num * 2544577213u ^ 435928766u);
						continue;
					case 38u:
						base.SetUpdateField<float>(171, 0f, 0);
						arg_750_0 = (num * 4142851119u ^ 4208899568u);
						continue;
					case 39u:
					{
						int num2;
						num2++;
						arg_750_0 = (num * 627873502u ^ 1245213075u);
						continue;
					}
					case 40u:
						base.SetUpdateField<ulong>(204, 100uL, 0);
						arg_750_0 = (num * 589149039u ^ 1827455864u);
						continue;
					case 41u:
					{
						int num3;
						base.SetUpdateField<int>(58 + num3, 0, 0);
						arg_750_0 = 1908405377u;
						continue;
					}
					case 42u:
						base.SetUpdateField<ulong>(112, 50331648uL, 0);
						base.SetUpdateField<ulong>(163, 1uL, 0);
						arg_750_0 = (num * 740895270u ^ 2494309065u);
						continue;
					case 43u:
						base.SetUpdateField<int>(161, 0, 0);
						base.SetUpdateField<int>(84, 110, 0);
						arg_750_0 = (num * 716606811u ^ 683298147u);
						continue;
					case 44u:
					{
						int num5 = 0;
						arg_750_0 = (num * 645724212u ^ 2219005145u);
						continue;
					}
					case 45u:
						base.SetUpdateField<int>(72, 0, 0);
						base.SetUpdateField<int>(78, 0, 0);
						arg_750_0 = (num * 2369184928u ^ 402976831u);
						continue;
					case 46u:
					{
						int num5;
						base.SetUpdateField<int>(131 + num5, 0, 0);
						arg_750_0 = (num * 3755003001u ^ 2166038637u);
						continue;
					}
					case 47u:
						base.SetUpdateField<short>(102, 0, 1);
						arg_750_0 = (num * 1276678106u ^ 3835185211u);
						continue;
					case 48u:
						base.SetUpdateField<int>(97, 4196352, 0);
						arg_750_0 = (num * 2619014669u ^ 2577791090u);
						continue;
					case 49u:
					{
						int num3 = 0;
						arg_750_0 = (num * 1247933337u ^ 506390079u);
						continue;
					}
					case 50u:
						base.SetUpdateField<float>(104, 1.5f, 0);
						base.SetUpdateField<float>(108, 0f, 0);
						arg_750_0 = (num * 263025040u ^ 294895891u);
						continue;
					case 51u:
						base.SetUpdateField<int>(8, 9, 0);
						arg_750_0 = (num * 2994754189u ^ 1955941347u);
						continue;
					case 52u:
					{
						int num2;
						base.SetUpdateField<int>(139 + num2, 0, 0);
						arg_750_0 = 383154904u;
						continue;
					}
					case 53u:
						base.SetUpdateField<int>(53, 16777472, 0);
						base.SetUpdateField<int>(84, 110, 0);
						arg_750_0 = (num * 3484837175u ^ 3470856369u);
						continue;
					}
					goto Block_6;
				}
			}
			Block_6:
			base.SetUpdateField<int>(126, this.Emote, 0);
		}
	}
}
