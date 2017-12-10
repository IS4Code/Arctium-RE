using AuthServer.Game.WorldEntities;
using AuthServer.WorldServer.Game.Entities;
using AuthServer.WorldServer.Managers;
using Framework.ObjectDefines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AuthServer.Game.Entities
{
	[DataContract]
	[Serializable]
	public class Character : WorldObject
	{
		[DataMember]
		public uint AccountId;

		[DataMember]
		public string Name;

		[DataMember]
		public byte Race;

		[DataMember]
		public byte Class;

		[DataMember]
		public byte Gender;

		[DataMember]
		public byte Skin;

		[DataMember]
		public byte Face;

		[DataMember]
		public byte HairStyle;

		[DataMember]
		public byte HairColor;

		[DataMember]
		public byte FacialHair;

		[DataMember]
		public byte HornStyle;

		[DataMember]
		public byte BlindFolds;

		[DataMember]
		public byte Tattoos;

		[DataMember]
		public byte Level;

		[DataMember]
		public uint Zone;

		[DataMember]
		public ulong GuildGuid;

		[DataMember]
		public uint PetDisplayInfo;

		[DataMember]
		public uint PetLevel;

		[DataMember]
		public uint PetFamily;

		[DataMember]
		public uint CharacterFlags;

		[DataMember]
		public uint CustomizeFlags;

		[DataMember]
		public bool LoginCinematic;

		[DataMember]
		public byte SpecGroupCount;

		[DataMember]
		public byte ActiveSpecGroup;

		[DataMember]
		public uint PrimarySpec;

		[DataMember]
		public uint SecondarySpec;

		[DataMember]
		public List<Skill> Skills = new List<Skill>();

		[DataMember]
		public List<PlayerSpell> SpellList = new List<PlayerSpell>();

		[DataMember]
		public Dictionary<byte, Item> Equipment = new Dictionary<byte, Item>();

		[DataMember]
		public Dictionary<byte, Item> Bag = new Dictionary<byte, Item>();

		[DataMember]
		public List<ActionButton> ActionButtons = new List<ActionButton>();

		public Dictionary<ulong, WorldObject> InRangeObjects = new Dictionary<ulong, WorldObject>();

		public uint Faction;

		public Character()
		{
		}

		public Character(ulong guid, int updateLength = 4592) : base(updateLength)
		{
			foreach (Character current in Manager.WorldMgr.CharaterList)
			{
				if (current.Guid == guid)
				{
					this.Guid = current.Guid;
					this.AccountId = 1u;
					this.Name = current.Name;
					this.Race = current.Race;
					this.Class = current.Class;
					this.Gender = current.Gender;
					this.Skin = current.Skin;
					this.Face = current.Face;
					this.HairStyle = current.HairStyle;
					this.HairColor = current.HairColor;
					this.FacialHair = current.FacialHair;
					this.HornStyle = current.HornStyle;
					this.BlindFolds = current.BlindFolds;
					this.Tattoos = current.Tattoos;
					this.Level = current.Level;
					this.Zone = current.Zone;
					this.GuildGuid = current.GuildGuid;
					this.PetDisplayInfo = current.PetDisplayInfo;
					this.PetLevel = current.PetLevel;
					this.PetFamily = current.PetFamily;
					this.CharacterFlags = current.CharacterFlags;
					this.CustomizeFlags = current.CustomizeFlags;
					this.LoginCinematic = current.LoginCinematic;
					this.SpecGroupCount = current.SpecGroupCount;
					this.ActiveSpecGroup = current.ActiveSpecGroup;
					this.PrimarySpec = current.PrimarySpec;
					this.SecondarySpec = current.SecondarySpec;
					this.Position = current.Position;
					this.Map = current.Map;
					break;
				}
			}
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 130092u,
				State = PlayerSpellState.New
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 668u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 69046u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 79738u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 669u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 79743u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 9078u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 197130u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 131347u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 176890u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 61451u,
				State = PlayerSpellState.Unchanged
			});
			if (this.Race != 26 && this.Race != 25)
			{
				if (this.Race != 24)
				{
					this.Skills.Add(new Skill
					{
						Id = 197u,
						SkillLevel = 300u
					});
					this.Skills.Add(new Skill
					{
						Id = 98u,
						SkillLevel = 300u
					});
					this.Skills.Add(new Skill
					{
						Id = 109u,
						SkillLevel = 300u
					});
					this.Skills.Add(new Skill
					{
						Id = 790u,
						SkillLevel = 0u
					});
					goto IL_47D;
				}
			}
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 905u,
				State = PlayerSpellState.Unchanged
			});
			this.Skills.Add(new Skill
			{
				Id = 905u,
				SkillLevel = 300u
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 131701u,
				State = PlayerSpellState.Unchanged
			});
			IL_47D:
			this.Skills.Add(new Skill
			{
				Id = 44u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 45u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 415u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 226u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 173u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 473u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 414u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 54u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 413u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 293u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 229u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 433u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 136u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 43u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 172u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 160u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 55u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 228u,
				SkillLevel = 300u
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 202782u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 202783u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 195304u,
				State = PlayerSpellState.Unchanged
			});
			this.SpellList.Add(new PlayerSpell
			{
				SpellId = 196055u,
				State = PlayerSpellState.Unchanged
			});
			this.Skills.Add(new Skill
			{
				Id = 1848u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 118u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 2152u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 777u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 769u,
				SkillLevel = 300u
			});
			this.Skills.Add(new Skill
			{
				Id = 762u,
				SkillLevel = 300u
			});
		}

		private bool IsHorde()
		{
			if (this.Race != 10)
			{
				while (true)
				{
					IL_118:
					uint arg_EC_0 = 2175166716u;
					while (true)
					{
						uint num;
						switch ((num = (arg_EC_0 ^ 3460805711u)) % 8u)
						{
						case 0u:
							goto IL_11F;
						case 1u:
							arg_EC_0 = (((this.Race == 26) ? 191491009u : 1217158808u) ^ num * 851128904u);
							continue;
						case 2u:
							arg_EC_0 = (((this.Race != 2) ? 142178198u : 22481873u) ^ num * 1606771516u);
							continue;
						case 3u:
							arg_EC_0 = (((this.Race == 9) ? 919304526u : 945348610u) ^ num * 531538333u);
							continue;
						case 4u:
							arg_EC_0 = (((this.Race != 8) ? 4081393335u : 2637987929u) ^ num * 4021092292u);
							continue;
						case 5u:
							goto IL_118;
						case 7u:
							arg_EC_0 = (((this.Race == 6) ? 3970469791u : 2840723181u) ^ num * 2527741994u);
							continue;
						}
						goto Block_7;
					}
				}
				Block_7:
				return true;
				IL_11F:
				return this.Race == 5;
			}
			return true;
		}

		public override void SetUpdateFields()
		{
			SmartGuid smartGuid = new SmartGuid
			{
				Type = GuidType.Player,
				CreationBits = this.Guid,
				RealmId = 1
			};
			while (true)
			{
				IL_BA6:
				uint arg_A8C_0 = 3362022498u;
				while (true)
				{
					uint num;
					uint value;
					uint arg_2AE_0;
					switch ((num = (arg_A8C_0 ^ 4145227827u)) % 67u)
					{
					case 0u:
						base.SetUpdateField<byte>(229, this.HairStyle, 2);
						arg_A8C_0 = (num * 4191529225u ^ 1166677571u);
						continue;
					case 1u:
					{
						int num2;
						base.SetUpdateField<uint>(1857 + num2 + 128, 300u, 0);
						base.SetUpdateField<uint>(1857 + num2 + 192, 1u, 0);
						arg_A8C_0 = (num * 341253735u ^ 3119224610u);
						continue;
					}
					case 2u:
						base.SetUpdateField<float>(109, 1337f, 0);
						arg_A8C_0 = (num * 2663813069u ^ 2946050710u);
						continue;
					case 3u:
					{
						int num2;
						base.SetUpdateField<uint>(1857 + num2 + 256, 490u, 0);
						base.SetUpdateField<uint>(1857 + num2 + 320, 1u, 0);
						base.SetUpdateField<uint>(1857 + num2 + 384, 1u, 0);
						arg_A8C_0 = (num * 2943954661u ^ 83118421u);
						continue;
					}
					case 4u:
						base.SetUpdateField<byte>(231, 0, 3);
						arg_A8C_0 = (num * 663694352u ^ 1969678795u);
						continue;
					case 5u:
						base.SetUpdateField<byte>(229, this.Skin, 0);
						arg_A8C_0 = (num * 4001737194u ^ 2492630477u);
						continue;
					case 6u:
						base.SetUpdateField<float>(2324, 0f, 0);
						arg_A8C_0 = (num * 985080521u ^ 2557173096u);
						continue;
					case 7u:
						base.SetUpdateField<int>(1083, 50, 0);
						arg_A8C_0 = (num * 3353072118u ^ 1574167544u);
						continue;
					case 8u:
						base.SetUpdateField<float>(204, 100f, 0);
						arg_A8C_0 = (num * 3907129026u ^ 79563245u);
						continue;
					case 9u:
						base.SetUpdateField<uint>(89, this.Faction, 0);
						arg_A8C_0 = (num * 2345251588u ^ 2123893132u);
						continue;
					case 10u:
						base.SetUpdateField<float>(117, 1f, 0);
						arg_A8C_0 = (num * 3198300392u ^ 322716183u);
						continue;
					case 11u:
						base.SetUpdateField<float>(189, 1f, 0);
						arg_A8C_0 = (num * 3523774928u ^ 1439404063u);
						continue;
					case 12u:
						base.SetUpdateField<uint>(1076, Manager.WorldMgr.DefaultChrSpec[(uint)this.Class], 0);
						base.SetUpdateField<float>(1078, 1f, 0);
						arg_A8C_0 = (num * 2240443312u ^ 235484044u);
						continue;
					case 13u:
						base.SetUpdateField<int>(1856, 400, 0);
						base.SetUpdateField<uint>(107, 0u, 0);
						arg_A8C_0 = (num * 2674944503u ^ 3928916786u);
						continue;
					case 14u:
						base.SetUpdateField<float>(104, 1.5f, 0);
						arg_A8C_0 = (num * 634593754u ^ 654435267u);
						continue;
					case 15u:
						base.SetUpdateField<int>(56, 1, 0);
						arg_A8C_0 = (num * 346485926u ^ 1433689022u);
						continue;
					case 16u:
					{
						int num2;
						base.SetUpdateField<uint>(1857 + num2 + 64, 1u, 0);
						arg_A8C_0 = (num * 2175926644u ^ 2161399249u);
						continue;
					}
					case 18u:
						base.SetUpdateField<uint>(105, value, 0);
						base.SetUpdateField<uint>(106, value, 0);
						arg_A8C_0 = (num * 2650772320u ^ 2264293372u);
						continue;
					case 19u:
					{
						int num2;
						base.SetUpdateField<uint>(1857 + num2, this.Skills[num2].Id, 0);
						arg_A8C_0 = (num * 1075763337u ^ 4126727761u);
						continue;
					}
					case 20u:
						base.SetUpdateField<int>(8, 65561, 0);
						base.SetUpdateField<float>(11, 1f, 0);
						arg_A8C_0 = (num * 1176461958u ^ 2696221759u);
						continue;
					case 21u:
						base.SetUpdateField<float>(1079, 1f, 0);
						arg_A8C_0 = (num * 1948465944u ^ 2947274196u);
						continue;
					case 22u:
					{
						Races races = Manager.WorldMgr.ChrRaces.Single((Races r) => r.Id == (uint)this.Race);
						if (this.Gender != 0)
						{
							arg_A8C_0 = (num * 3206551392u ^ 2285065839u);
							continue;
						}
						arg_2AE_0 = races.MaleDisplayId;
						goto IL_2AE;
					}
					case 23u:
						base.SetUpdateField<int>(129, 1, 0);
						arg_A8C_0 = (num * 3174050420u ^ 2021044933u);
						continue;
					case 24u:
						base.SetUpdateField<float>(103, 0.389f, 0);
						arg_A8C_0 = (num * 3433571387u ^ 3881573744u);
						continue;
					case 25u:
						base.SetUpdateField<float>(110, 42f, 0);
						base.SetUpdateField<float>(111, 42f, 0);
						arg_A8C_0 = (num * 4210040317u ^ 4279241858u);
						continue;
					case 26u:
						base.SetUpdateField<int>(2305, 0, 0);
						arg_A8C_0 = (num * 523204179u ^ 1758224075u);
						continue;
					case 27u:
						base.SetUpdateField<int>(133, 0, 0);
						arg_A8C_0 = (num * 3609259888u ^ 1437850688u);
						continue;
					case 28u:
						arg_A8C_0 = (num * 1646104443u ^ 106033085u);
						continue;
					case 29u:
						base.SetUpdateField<int>(84, (int)this.Level, 0);
						base.SetUpdateField<int>(2799, 110, 0);
						arg_A8C_0 = (num * 3785765493u ^ 1513835986u);
						continue;
					case 30u:
						base.SetUpdateField<int>(58, 5000, 0);
						base.SetUpdateField<int>(66, 5000, 0);
						arg_A8C_0 = (num * 4254594651u ^ 4171747618u);
						continue;
					case 31u:
						base.SetUpdateField<uint>(1075, 1u, 0);
						base.SetUpdateField<int>(2671, 2, 0);
						base.SetUpdateField<int>(100, 2000, 0);
						base.SetUpdateField<int>(102, 2000, 0);
						arg_A8C_0 = (num * 3804769601u ^ 520110499u);
						continue;
					case 32u:
						base.SetUpdateField<float>(1080, 1f, 0);
						arg_A8C_0 = (num * 4078682135u ^ 2875606574u);
						continue;
					case 33u:
						base.SetUpdateField<byte>(229, this.Face, 1);
						arg_A8C_0 = (num * 2559775110u ^ 2078298877u);
						continue;
					case 34u:
						base.SetUpdateField<int>(117, 42, 0);
						arg_A8C_0 = (num * 1260314422u ^ 1565665195u);
						continue;
					case 35u:
						base.SetUpdateField<ulong>(0, smartGuid.Guid, 0);
						base.SetUpdateField<ulong>(2, smartGuid.HighGuid, 0);
						arg_A8C_0 = (num * 2433167489u ^ 2816061565u);
						continue;
					case 36u:
						base.SetUpdateField<int>(2306, 21, 0);
						base.SetUpdateField<int>(99, 4194304, 0);
						arg_A8C_0 = (num * 100814028u ^ 3072653526u);
						continue;
					case 37u:
						base.SetUpdateField<uint>(112, 65536u, 0);
						arg_A8C_0 = (num * 62540501u ^ 646882076u);
						continue;
					case 38u:
						base.SetUpdateField<byte>(53, this.Class, 1);
						base.SetUpdateField<byte>(53, 0, 2);
						base.SetUpdateField<byte>(53, this.Gender, 3);
						base.SetUpdateField<uint>(54, Manager.WorldMgr.DefaultPowerTypes[(uint)this.Class], 0);
						arg_A8C_0 = (num * 964918507u ^ 3151098252u);
						continue;
					case 39u:
						base.SetUpdateField<int>(2653, 2, 0);
						base.SetUpdateField<int>(232, 0, 0);
						arg_A8C_0 = (num * 2130652486u ^ 2037663857u);
						continue;
					case 40u:
						base.SetUpdateField<int>(128, 1, 0);
						arg_A8C_0 = (num * 1328463574u ^ 1183088005u);
						continue;
					case 41u:
						base.SetUpdateField<float>(2325, 7f, 0);
						arg_A8C_0 = (num * 1986332979u ^ 3633177268u);
						continue;
					case 42u:
						base.SetUpdateField<int>(64, 1, 0);
						this.Faction = Manager.WorldMgr.ChrRaces.Single((Races r) => r.Id == (uint)this.Race).Faction;
						arg_A8C_0 = (num * 506256744u ^ 1017043020u);
						continue;
					case 43u:
						base.SetUpdateField<int>(1084, 50, 0);
						arg_A8C_0 = (num * 2196478767u ^ 4068802405u);
						continue;
					case 44u:
						base.SetUpdateField<int>(207, -1, 0);
						base.SetUpdateField<int>(230, (int)this.FacialHair << 24 | (int)this.Tattoos << 16 | (int)this.BlindFolds << 8 | (int)this.HornStyle, 0);
						base.SetUpdateField<uint>(1073, 315u, 0);
						arg_A8C_0 = (num * 401854400u ^ 421126737u);
						continue;
					case 45u:
						base.SetUpdateField<int>(2531, 2147483647, 0);
						arg_A8C_0 = (num * 3035220601u ^ 2964939857u);
						continue;
					case 46u:
						base.SetUpdateField<int>(4591, 350, 0);
						arg_A8C_0 = (num * 4154855600u ^ 571652020u);
						continue;
					case 47u:
					{
						Races races;
						arg_2AE_0 = races.FemaleDisplayId;
						goto IL_2AE;
					}
					case 48u:
						base.SetUpdateField<uint>(96, 8u, 0);
						arg_A8C_0 = (num * 565745881u ^ 1871953938u);
						continue;
					case 49u:
					{
						int num2;
						arg_A8C_0 = ((num2 >= this.Skills.Count) ? 2606039594u : 3681206070u);
						continue;
					}
					case 50u:
						base.SetUpdateField<byte>(229, this.HairColor, 3);
						arg_A8C_0 = (num * 3816078619u ^ 932202503u);
						continue;
					case 51u:
					{
						int num2;
						arg_A8C_0 = ((num2 >= 64) ? 4266884691u : 2608069202u);
						continue;
					}
					case 52u:
						base.SetUpdateField<byte>(53, this.Race, 0);
						arg_A8C_0 = (num * 2478557743u ^ 1006291970u);
						continue;
					case 53u:
						goto IL_BA6;
					case 54u:
						base.SetUpdateField<float>(108, 1337f, 0);
						arg_A8C_0 = (num * 1672153762u ^ 3359117251u);
						continue;
					case 55u:
						base.SetUpdateField<int>(1855, 0, 0);
						base.SetUpdateField<int>(2694, 8, 0);
						arg_A8C_0 = (num * 2837554239u ^ 2404694369u);
						continue;
					case 56u:
						base.SetUpdateField<uint>(190, 1u, 0);
						arg_A8C_0 = (num * 4197942694u ^ 3210995054u);
						continue;
					case 57u:
						base.SetUpdateField<int>(127, 1, 0);
						arg_A8C_0 = (num * 1736485825u ^ 1356110532u);
						continue;
					case 58u:
					{
						int num2;
						num2++;
						arg_A8C_0 = 3263568798u;
						continue;
					}
					case 59u:
						base.SetUpdateField<int>(130, 1, 0);
						base.SetUpdateField<int>(132, 0, 0);
						arg_A8C_0 = (num * 3127260296u ^ 4244907525u);
						continue;
					case 60u:
						base.SetUpdateField<int>(139, 1, 0);
						base.SetUpdateField<int>(164, 1, 0);
						arg_A8C_0 = (num * 1408997502u ^ 3556141945u);
						continue;
					case 61u:
						base.SetUpdateField<byte>(231, this.Gender, 2);
						arg_A8C_0 = (num * 2417106500u ^ 3665189629u);
						continue;
					case 62u:
						base.SetUpdateField<int>(2724, -1, 0);
						arg_A8C_0 = (num * 4016402819u ^ 819527604u);
						continue;
					case 63u:
					{
						base.SetUpdateField<int>(59, 100, 0);
						base.SetUpdateField<int>(60, 1000, 0);
						int num2 = 0;
						arg_A8C_0 = (num * 101977690u ^ 476485388u);
						continue;
					}
					case 64u:
						base.SetUpdateField<byte>(231, 0, 0);
						base.SetUpdateField<byte>(231, 0, 1);
						arg_A8C_0 = (num * 3736737872u ^ 1786945540u);
						continue;
					case 65u:
						base.SetUpdateField<uint>(97, 2048u, 0);
						arg_A8C_0 = (num * 255146829u ^ 2316109280u);
						continue;
					case 66u:
						base.SetUpdateField<int>(2310, 7, 0);
						arg_A8C_0 = (num * 3510051898u ^ 2912203465u);
						continue;
					}
					goto Block_4;
					IL_2AE:
					value = arg_2AE_0;
					arg_A8C_0 = 2935423918u;
				}
			}
			Block_4:
			base.SetUpdateField<float>(1081, 1f, 0);
			base.SetUpdateField<uint>(2695, 3840u, 0);
		}

		public static string NormalizeName(string name)
		{
			return Character.smethod_15(name, 0).ToString().ToUpper() + name.Remove(0, 1).ToLower();
		}

		static char smethod_15(string string_0, int int_0)
		{
			return string_0[int_0];
		}
	}
}
