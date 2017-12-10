using AuthServer.Game.Entities;
using Framework.Network.Packets;
using Framework.ObjectDefines;
using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Serialization;

namespace AuthServer.WorldServer.Game.Entities
{
	[DataContract]
	[Serializable]
	public class WorldObject
	{
		public SmartGuid SGuid;

		[DataMember]
		public ulong Guid;

		[DataMember]
		public Vector4 Position;

		[DataMember]
		public uint Map;

		public ulong TargetGuid;

		public int MaskSize;

		[DataMember]
		public int DataLength;

		public BitArray Mask;

		public Hashtable UpdateData = WorldObject.smethod_0();

		public WorldObject()
		{
		}

		public WorldObject(int dataLength)
		{
			this.DataLength = dataLength;
			this.MaskSize = dataLength / 32;
			this.Mask = WorldObject.smethod_1(dataLength, false);
		}

		public bool CheckDistance(WorldObject obj, float dist = 100000f)
		{
			if (this.Map == obj.Map)
			{
				float arg_89_0 = (float)WorldObject.smethod_2((double)(this.Position.X - obj.Position.X), 2.0);
				float num = (float)WorldObject.smethod_2((double)(this.Position.Y - obj.Position.Y), 2.0);
				float num2 = (float)WorldObject.smethod_2((double)(this.Position.Z - obj.Position.Z), 2.0);
				return arg_89_0 + num + num2 <= dist;
			}
			return false;
		}

		public virtual void SetUpdateFields()
		{
		}

		public void SetItemUpdateFields(SmartGuid guid, int itemId = 0, int modId = 0)
		{
			this.SetUpdateField<ulong>(0, guid.Guid, 0);
			while (true)
			{
				IL_1C1:
				uint arg_184_0 = 1063411794u;
				while (true)
				{
					uint num;
					switch ((num = (arg_184_0 ^ 72283757u)) % 12u)
					{
					case 0u:
					{
						SmartGuid smartGuid;
						this.SetUpdateField<ulong>(14, smartGuid.HighGuid, 0);
						this.SetUpdateField<ulong>(16, smartGuid.Guid, 0);
						arg_184_0 = (num * 3453894861u ^ 1482513746u);
						continue;
					}
					case 1u:
						this.SetUpdateField<uint>(28, 1u, 0);
						this.SetUpdateField<uint>(35, 196609u, 0);
						arg_184_0 = (num * 3852825095u ^ 3796627504u);
						continue;
					case 2u:
						goto IL_1C1;
					case 4u:
					{
						SmartGuid smartGuid = new SmartGuid
						{
							Type = GuidType.Player,
							CreationBits = this.Guid,
							RealmId = 1
						};
						this.SetUpdateField<ulong>(12, smartGuid.Guid, 0);
						arg_184_0 = (num * 1312344684u ^ 2002962573u);
						continue;
					}
					case 5u:
						this.SetUpdateField<float>(11, 1f, 0);
						arg_184_0 = (num * 1291593438u ^ 3694125931u);
						continue;
					case 6u:
						this.SetUpdateField<int>(84, modId, 0);
						arg_184_0 = (num * 3334826283u ^ 625357320u);
						continue;
					case 7u:
						this.SetUpdateField<ulong>(2, guid.HighGuid, 0);
						arg_184_0 = (num * 109549280u ^ 4216859312u);
						continue;
					case 8u:
						this.SetUpdateField<uint>(78, 85u, 0);
						arg_184_0 = (num * 2647184815u ^ 1924686639u);
						continue;
					case 9u:
						this.SetUpdateField<int>(8, 3, 0);
						this.SetUpdateField<int>(9, itemId, 0);
						arg_184_0 = (num * 743845792u ^ 4144677760u);
						continue;
					case 10u:
						this.SetUpdateField<uint>(77, 85u, 0);
						arg_184_0 = (num * 2126794692u ^ 1334550125u);
						continue;
					case 11u:
					{
						SmartGuid smartGuid;
						this.SetUpdateField<ulong>(18, smartGuid.HighGuid, 0);
						arg_184_0 = (num * 701019929u ^ 3960210607u);
						continue;
					}
					}
					goto Block_1;
				}
			}
			Block_1:
			this.SetUpdateField<long>(82, 14075510000L, 0);
		}

		public void SetUpdateField<T>(int index, T value, byte offset = 0)
		{
			if (this.UpdateData == null)
			{
				goto IL_3E1;
			}
			goto IL_4C1;
			uint arg_438_0;
			string string_;
			ulong num3;
			while (true)
			{
				IL_433:
				uint num;
				switch ((num = (arg_438_0 ^ 1078523441u)) % 31u)
				{
				case 0u:
					arg_438_0 = ((WorldObject.smethod_4(string_, Module.smethod_35<string>(471189065u)) ? 2769783969u : 3556855128u) ^ num * 2244124706u);
					continue;
				case 1u:
					this.UpdateData = WorldObject.smethod_0();
					arg_438_0 = (num * 1235961168u ^ 1201306209u);
					continue;
				case 2u:
					goto IL_3E1;
				case 3u:
					return;
				case 4u:
					arg_438_0 = ((WorldObject.smethod_6(this.UpdateData, index) ? 2508933868u : 3083554084u) ^ num * 919501449u);
					continue;
				case 5u:
					return;
				case 6u:
					WorldObject.smethod_5(this.Mask, index + 1, true);
					arg_438_0 = (num * 3174523526u ^ 779944474u);
					continue;
				case 7u:
					WorldObject.smethod_10(this.UpdateData, index, (int)WorldObject.smethod_7(this.UpdateData, index) | (int)WorldObject.smethod_9(value, WorldObject.smethod_8(typeof(int).TypeHandle)) << (int)(offset * (WorldObject.smethod_4(string_, Module.smethod_37<string>(2367085557u)) ? 8 : 16)));
					arg_438_0 = 1814176547u;
					continue;
				case 8u:
					arg_438_0 = (num * 2027589988u ^ 1662781883u);
					continue;
				case 9u:
				{
					long num2 = (long)WorldObject.smethod_9(value, WorldObject.smethod_8(typeof(long).TypeHandle));
					WorldObject.smethod_10(this.UpdateData, index, (uint)(num2 & 2147483647L));
					arg_438_0 = (num * 441206569u ^ 3288547449u);
					continue;
				}
				case 10u:
					arg_438_0 = (((!WorldObject.smethod_4(string_, Module.smethod_36<string>(4148125342u))) ? 3051065104u : 2722040491u) ^ num * 1311538312u);
					continue;
				case 11u:
					WorldObject.smethod_5(this.Mask, index, true);
					WorldObject.smethod_5(this.Mask, index + 1, true);
					arg_438_0 = 2066190807u;
					continue;
				case 12u:
					return;
				case 13u:
					arg_438_0 = (((!WorldObject.smethod_4(string_, Module.smethod_33<string>(442578807u))) ? 4226308765u : 2424126876u) ^ num * 3266367109u);
					continue;
				case 14u:
					WorldObject.smethod_5(this.Mask, index, true);
					arg_438_0 = 390023262u;
					continue;
				case 15u:
					WorldObject.smethod_10(this.UpdateData, index, value);
					arg_438_0 = (num * 942141689u ^ 47258091u);
					continue;
				case 16u:
					goto IL_4E1;
				case 17u:
				{
					long num2;
					WorldObject.smethod_10(this.UpdateData, index + 1, (uint)(num2 >> 32 & 2147483647L));
					arg_438_0 = (num * 2181430052u ^ 2907402656u);
					continue;
				}
				case 18u:
					WorldObject.smethod_5(this.Mask, index, true);
					arg_438_0 = 595910673u;
					continue;
				case 19u:
					num3 = (ulong)WorldObject.smethod_9(value, WorldObject.smethod_8(typeof(ulong).TypeHandle));
					arg_438_0 = (num * 2843172724u ^ 682357435u);
					continue;
				case 21u:
					goto IL_530;
				case 22u:
					arg_438_0 = (((!WorldObject.smethod_4(string_, Module.smethod_37<string>(3097521771u))) ? 3467220426u : 2229331461u) ^ num * 1271791227u);
					continue;
				case 23u:
					goto IL_4C1;
				case 24u:
					WorldObject.smethod_5(this.Mask, index, true);
					arg_438_0 = 1254435409u;
					continue;
				case 25u:
					WorldObject.smethod_5(this.Mask, index, true);
					arg_438_0 = 920397743u;
					continue;
				case 26u:
					arg_438_0 = ((WorldObject.smethod_4(string_, Module.smethod_35<string>(3073353507u)) ? 1419483600u : 317806583u) ^ num * 3771367217u);
					continue;
				case 27u:
					goto IL_595;
				case 28u:
					WorldObject.smethod_10(this.UpdateData, index, (uint)WorldObject.smethod_9(value, WorldObject.smethod_8(typeof(uint).TypeHandle)) << (int)(offset * (WorldObject.smethod_4(string_, Module.smethod_35<string>(3073353507u)) ? 8 : 16)));
					arg_438_0 = 1549646685u;
					continue;
				case 29u:
					arg_438_0 = (((!WorldObject.smethod_4(string_, Module.smethod_34<string>(1485958124u))) ? 3130158510u : 3316577943u) ^ num * 3739135092u);
					continue;
				case 30u:
					arg_438_0 = ((WorldObject.smethod_6(this.UpdateData, index) ? 60155166u : 46010574u) ^ num * 1953978871u);
					continue;
				}
				break;
			}
			return;
			IL_4E1:
			WorldObject.smethod_10(this.UpdateData, index, (int)WorldObject.smethod_9(value, WorldObject.smethod_8(typeof(int).TypeHandle)) << (int)(offset * (WorldObject.smethod_4(string_, Module.smethod_36<string>(3195932721u)) ? 8 : 16)));
			return;
			IL_530:
			WorldObject.smethod_10(this.UpdateData, index, (uint)WorldObject.smethod_7(this.UpdateData, index) | (uint)WorldObject.smethod_9(value, WorldObject.smethod_8(typeof(uint).TypeHandle)) << (int)(offset * (WorldObject.smethod_4(string_, Module.smethod_37<string>(1636649343u)) ? 8 : 16)));
			return;
			IL_595:
			WorldObject.smethod_10(this.UpdateData, index, (uint)(num3 & 4294967295uL));
			WorldObject.smethod_10(this.UpdateData, index + 1, (uint)(num3 >> 32 & 4294967295uL));
			return;
			IL_3E1:
			arg_438_0 = 1035292382u;
			goto IL_433;
			IL_4C1:
			string_ = WorldObject.smethod_3(value.GetType());
			arg_438_0 = 44427092u;
			goto IL_433;
		}

		public void WriteUpdateFields(ref PacketWriter packet)
		{
			packet.WriteUInt8((byte)this.MaskSize);
			while (true)
			{
				IL_0E:
				uint arg_18_0 = 3366670953u;
				while (true)
				{
					uint num;
					int num2;
					int arg_8E_0;
					switch ((num = (arg_18_0 ^ 4235975302u)) % 6u)
					{
					case 0u:
						goto IL_0E;
					case 1u:
						goto IL_CE;
					case 2u:
						IL_76:
						if (num2 >= WorldObject.smethod_13(this.Mask))
						{
							arg_8E_0 = -1464656900;
							goto IL_89;
						}
						break;
					case 3u:
						num2 = 0;
						arg_18_0 = (num * 2481430274u ^ 527075398u);
						continue;
					case 4u:
						break;
					case 5u:
						packet.WriteBitArray(this.Mask, this.MaskSize * 4);
						arg_18_0 = (num * 1921983537u ^ 3048034970u);
						continue;
					default:
						goto IL_CE;
					}
					if (WorldObject.smethod_11(this.Mask, num2))
					{
						arg_18_0 = 3713779421u;
						continue;
					}
					goto IL_226;
					IL_89:
					switch ((arg_8E_0 ^ -58991994) % 3)
					{
					case 0:
						IL_A9:
						arg_8E_0 = -385541468;
						goto IL_89;
					case 1:
						goto IL_76;
					}
					goto Block_4;
					IL_226:
					num2++;
					goto IL_A9;
					IL_CE:
					if (WorldObject.smethod_6(this.UpdateData, num2))
					{
						try
						{
							string string_ = WorldObject.smethod_3(WorldObject.smethod_12(WorldObject.smethod_7(this.UpdateData, num2)));
							if (!WorldObject.smethod_4(string_, Module.smethod_36<string>(4292810432u)))
							{
								goto IL_180;
							}
							goto IL_1FD;
							uint arg_1CC_0;
							while (true)
							{
								IL_1C7:
								switch ((num = (arg_1CC_0 ^ 4235975302u)) % 9u)
								{
								case 0u:
									arg_1CC_0 = (num * 1956267406u ^ 2145021447u);
									continue;
								case 1u:
									arg_1CC_0 = (((!WorldObject.smethod_4(string_, Module.smethod_35<string>(1254913650u))) ? 3224060110u : 3558025122u) ^ num * 1827654248u);
									continue;
								case 2u:
									goto IL_180;
								case 3u:
									arg_1CC_0 = (num * 3871578959u ^ 3344296025u);
									continue;
								case 4u:
									arg_1CC_0 = (num * 1694166464u ^ 3454029761u);
									continue;
								case 5u:
									packet.WriteInt32((int)WorldObject.smethod_7(this.UpdateData, num2));
									arg_1CC_0 = 3967916097u;
									continue;
								case 7u:
									goto IL_1FD;
								case 8u:
									packet.WriteFloat((float)WorldObject.smethod_7(this.UpdateData, num2));
									arg_1CC_0 = 3192550676u;
									continue;
								}
								break;
							}
							goto IL_226;
							IL_180:
							arg_1CC_0 = 3652733696u;
							goto IL_1C7;
							IL_1FD:
							packet.WriteUInt32((uint)WorldObject.smethod_7(this.UpdateData, num2));
							arg_1CC_0 = 3667907139u;
							goto IL_1C7;
						}
						catch
						{
						}
						goto IL_226;
					}
					goto IL_226;
				}
			}
			Block_4:
			WorldObject.smethod_14(this.Mask, false);
		}

		public void WriteDynamicUpdateFields(ref PacketWriter packet)
		{
			packet.WriteUInt8(0);
		}

		public void RemoveFromWorld()
		{
		}

		public Character ToCharacter()
		{
			return this as Character;
		}

		static Hashtable smethod_0()
		{
			return new Hashtable();
		}

		static BitArray smethod_1(int int_0, bool bool_0)
		{
			return new BitArray(int_0, bool_0);
		}

		static double smethod_2(double double_0, double double_1)
		{
			return Math.Pow(double_0, double_1);
		}

		static string smethod_3(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		static bool smethod_4(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static void smethod_5(BitArray bitArray_0, int int_0, bool bool_0)
		{
			bitArray_0.Set(int_0, bool_0);
		}

		static bool smethod_6(Hashtable hashtable_0, object object_0)
		{
			return hashtable_0.ContainsKey(object_0);
		}

		static object smethod_7(Hashtable hashtable_0, object object_0)
		{
			return hashtable_0[object_0];
		}

		static Type smethod_8(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static object smethod_9(object object_0, Type type_0)
		{
			return Convert.ChangeType(object_0, type_0);
		}

		static void smethod_10(Hashtable hashtable_0, object object_0, object object_1)
		{
			hashtable_0[object_0] = object_1;
		}

		static bool smethod_11(BitArray bitArray_0, int int_0)
		{
			return bitArray_0.Get(int_0);
		}

		static Type smethod_12(object object_0)
		{
			return object_0.GetType();
		}

		static int smethod_13(BitArray bitArray_0)
		{
			return bitArray_0.Count;
		}

		static void smethod_14(BitArray bitArray_0, bool bool_0)
		{
			bitArray_0.SetAll(bool_0);
		}
	}
}
