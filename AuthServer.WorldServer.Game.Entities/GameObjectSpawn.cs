using AuthServer.WorldServer.Managers;
using Framework.ObjectDefines;
using System;

namespace AuthServer.WorldServer.Game.Entities
{
	[Serializable]
	public class GameObjectSpawn : WorldObject
	{
		public int Id;

		public uint FactionTemplate;

		public byte AnimProgress;

		public byte State;

		public GameObject GameObject;

		public GameObjectSpawn(int updateLength = 33) : base(updateLength)
		{
		}

		public static ulong GetLastGuid()
		{
			return (ulong)((long)Manager.SpawnMgr.GameObjectSpawns.Count + 1L);
		}

		public void CreateFullGuid()
		{
			this.SGuid = new SmartGuid(this.Guid, this.Id, GuidType.GameObject, (ulong)this.Map);
			this.Guid = this.SGuid.Guid;
		}

		public void CreateData(GameObject gameobject)
		{
			this.GameObject = gameobject;
		}

		public bool AddToDB()
		{
			return false;
		}

		public void AddToWorld()
		{
			this.CreateFullGuid();
			while (true)
			{
				IL_5C:
				uint arg_40_0 = 1977405627u;
				while (true)
				{
					uint num;
					switch ((num = (arg_40_0 ^ 658709834u)) % 4u)
					{
					case 0u:
						goto IL_5C;
					case 1u:
						this.CreateData(this.GameObject);
						arg_40_0 = (num * 3818611022u ^ 171797355u);
						continue;
					case 3u:
						Manager.SpawnMgr.AddSpawn(this);
						arg_40_0 = (num * 2673656784u ^ 3244605608u);
						continue;
					}
					return;
				}
			}
		}

		public override void SetUpdateFields()
		{
			base.SetUpdateField<ulong>(0, this.Guid, 0);
			while (true)
			{
				IL_2EF:
				uint arg_29E_0 = 999333535u;
				while (true)
				{
					uint num;
					switch ((num = (arg_29E_0 ^ 504559828u)) % 17u)
					{
					case 0u:
						base.SetUpdateField<float>(21, this.GameObject.Rot.O, 0);
						arg_29E_0 = (num * 748905259u ^ 2031209607u);
						continue;
					case 2u:
						base.SetUpdateField<byte>(24, 255, 3);
						arg_29E_0 = (num * 2507631249u ^ 571473568u);
						continue;
					case 3u:
						base.SetUpdateField<float>(18, this.GameObject.Rot.X, 0);
						arg_29E_0 = (num * 3516617196u ^ 2887152302u);
						continue;
					case 4u:
					{
						SmartGuid smartGuid = new SmartGuid(this.Guid, this.Id, GuidType.GameObject, (ulong)this.Map);
						base.SetUpdateField<ulong>(2, smartGuid.HighGuid, 0);
						base.SetUpdateField<ulong>(4, 0uL, 0);
						base.SetUpdateField<int>(8, 33, 0);
						base.SetUpdateField<int>(9, this.Id, 0);
						arg_29E_0 = (num * 2137176038u ^ 600593551u);
						continue;
					}
					case 5u:
						base.SetUpdateField<uint>(22, this.FactionTemplate, 0);
						base.SetUpdateField<int>(23, 0, 0);
						arg_29E_0 = (num * 533401104u ^ 3946632066u);
						continue;
					case 6u:
						base.SetUpdateField<byte>(24, (byte)this.GameObject.Type, 1);
						base.SetUpdateField<byte>(24, 0, 2);
						arg_29E_0 = (num * 644085778u ^ 388308084u);
						continue;
					case 7u:
						goto IL_2EF;
					case 8u:
						base.SetUpdateField<float>(19, this.GameObject.Rot.Y, 0);
						base.SetUpdateField<float>(20, this.GameObject.Rot.Z, 0);
						arg_29E_0 = (num * 624909204u ^ 3760992830u);
						continue;
					case 9u:
						base.SetUpdateField<int>(16, this.GameObject.DisplayInfoId, 0);
						arg_29E_0 = (num * 1489428309u ^ 666582131u);
						continue;
					case 10u:
						base.SetUpdateField<byte>(26, 255, 3);
						arg_29E_0 = (num * 3501202112u ^ 388806276u);
						continue;
					case 11u:
						base.SetUpdateField<byte>(24, this.State, 0);
						arg_29E_0 = (num * 2994032068u ^ 4098580944u);
						continue;
					case 12u:
						base.SetUpdateField<byte>(26, this.AnimProgress, 0);
						arg_29E_0 = (num * 3740736952u ^ 1920541854u);
						continue;
					case 13u:
						base.SetUpdateField<int>(17, 49, 0);
						arg_29E_0 = (num * 596278471u ^ 1729958822u);
						continue;
					case 14u:
						base.SetUpdateField<byte>(26, 0, 1);
						arg_29E_0 = (num * 2713790489u ^ 3859455500u);
						continue;
					case 15u:
						base.SetUpdateField<byte>(26, 255, 2);
						arg_29E_0 = (num * 2506023519u ^ 1216899585u);
						continue;
					case 16u:
						base.SetUpdateField<float>(11, this.GameObject.Size, 0);
						base.SetUpdateField<ulong>(12, 0uL, 0);
						arg_29E_0 = (num * 3058171710u ^ 441443711u);
						continue;
					}
					return;
				}
			}
		}
	}
}
