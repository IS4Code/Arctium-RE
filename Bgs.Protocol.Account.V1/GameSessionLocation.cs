using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameSessionLocation : IMessage<GameSessionLocation>, IEquatable<GameSessionLocation>, IDeepCloneable<GameSessionLocation>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameSessionLocation.__c __9 = new GameSessionLocation.__c();

			internal GameSessionLocation cctor>b__34_0()
			{
				return new GameSessionLocation();
			}
		}

		private static readonly MessageParser<GameSessionLocation> _parser = new MessageParser<GameSessionLocation>(new Func<GameSessionLocation>(GameSessionLocation.__c.__9.<.cctor>b__34_0));

		public const int IpAddressFieldNumber = 1;

		private string ipAddress_ = "";

		public const int CountryFieldNumber = 2;

		private uint country_;

		public const int CityFieldNumber = 3;

		private string city_ = "";

		public static MessageParser<GameSessionLocation> Parser
		{
			get
			{
				return GameSessionLocation._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[28];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSessionLocation.Descriptor;
			}
		}

		public string IpAddress
		{
			get
			{
				return this.ipAddress_;
			}
			set
			{
				this.ipAddress_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public uint Country
		{
			get
			{
				return this.country_;
			}
			set
			{
				this.country_ = value;
			}
		}

		public string City
		{
			get
			{
				return this.city_;
			}
			set
			{
				this.city_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public GameSessionLocation()
		{
		}

		public GameSessionLocation(GameSessionLocation other) : this()
		{
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 2627719441u;
				while (true)
				{
					uint num;
					switch ((num = (arg_4D_0 ^ 2256945194u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 1u:
						this.country_ = other.country_;
						this.city_ = other.city_;
						arg_4D_0 = (num * 2080819039u ^ 2159448063u);
						continue;
					case 3u:
						this.ipAddress_ = other.ipAddress_;
						arg_4D_0 = (num * 3985547152u ^ 166188003u);
						continue;
					}
					return;
				}
			}
		}

		public GameSessionLocation Clone()
		{
			return new GameSessionLocation(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameSessionLocation);
		}

		public bool Equals(GameSessionLocation other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_EA;
			int arg_A4_0;
			while (true)
			{
				IL_9F:
				switch ((arg_A4_0 ^ -883987193) % 11)
				{
				case 1:
					goto IL_EA;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					goto IL_9A;
				case 5:
					arg_A4_0 = ((this.Country == other.Country) ? -1998424733 : -1660916150);
					continue;
				case 6:
					return false;
				case 7:
					arg_A4_0 = ((!GameSessionLocation.smethod_0(this.City, other.City)) ? -1812832927 : -345119887);
					continue;
				case 8:
					arg_A4_0 = (GameSessionLocation.smethod_0(this.IpAddress, other.IpAddress) ? -2094011245 : -106225924);
					continue;
				case 9:
					return false;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = -996386253;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other != this) ? -99235764 : -1945505920);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (GameSessionLocation.smethod_1(this.IpAddress) != 0)
			{
				goto IL_A7;
			}
			goto IL_E8;
			uint arg_B1_0;
			while (true)
			{
				IL_AC:
				uint num2;
				switch ((num2 = (arg_B1_0 ^ 4175474980u)) % 7u)
				{
				case 0u:
					goto IL_A7;
				case 1u:
					num ^= this.City.GetHashCode();
					arg_B1_0 = (num2 * 2863239649u ^ 3330612938u);
					continue;
				case 3u:
					num ^= this.Country.GetHashCode();
					arg_B1_0 = (num2 * 3283148973u ^ 1306564960u);
					continue;
				case 4u:
					num ^= GameSessionLocation.smethod_2(this.IpAddress);
					arg_B1_0 = (num2 * 380530127u ^ 4124282294u);
					continue;
				case 5u:
					arg_B1_0 = ((this.City.Length == 0) ? 2518525146u : 3112938804u);
					continue;
				case 6u:
					goto IL_E8;
				}
				break;
			}
			return num;
			IL_A7:
			arg_B1_0 = 3470728969u;
			goto IL_AC;
			IL_E8:
			arg_B1_0 = ((this.Country == 0u) ? 4213944501u : 3251944429u);
			goto IL_AC;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (GameSessionLocation.smethod_1(this.IpAddress) != 0)
			{
				goto IL_8C;
			}
			goto IL_132;
			uint arg_EE_0;
			while (true)
			{
				IL_E9:
				uint num;
				switch ((num = (arg_EE_0 ^ 2923732050u)) % 10u)
				{
				case 0u:
					output.WriteUInt32(this.Country);
					arg_EE_0 = (num * 923975355u ^ 1671771180u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					arg_EE_0 = (num * 110509949u ^ 3568711749u);
					continue;
				case 2u:
					arg_EE_0 = ((GameSessionLocation.smethod_1(this.City) == 0) ? 3038997875u : 3702285902u);
					continue;
				case 3u:
					goto IL_8C;
				case 4u:
					output.WriteRawTag(26);
					arg_EE_0 = (num * 4006602485u ^ 1603037323u);
					continue;
				case 5u:
					output.WriteRawTag(16);
					arg_EE_0 = (num * 1691021510u ^ 3986071942u);
					continue;
				case 6u:
					goto IL_132;
				case 7u:
					output.WriteString(this.City);
					arg_EE_0 = (num * 1205483989u ^ 3934814986u);
					continue;
				case 8u:
					output.WriteString(this.IpAddress);
					arg_EE_0 = (num * 2352814711u ^ 1700843776u);
					continue;
				}
				break;
			}
			return;
			IL_8C:
			arg_EE_0 = 3103841649u;
			goto IL_E9;
			IL_132:
			arg_EE_0 = ((this.Country == 0u) ? 2779841314u : 4072127863u);
			goto IL_E9;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (GameSessionLocation.smethod_1(this.IpAddress) != 0)
			{
				goto IL_88;
			}
			goto IL_E8;
			uint arg_B1_0;
			while (true)
			{
				IL_AC:
				uint num2;
				switch ((num2 = (arg_B1_0 ^ 3585185841u)) % 7u)
				{
				case 0u:
					goto IL_E8;
				case 1u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Country);
					arg_B1_0 = (num2 * 3933200779u ^ 2694466086u);
					continue;
				case 2u:
					goto IL_88;
				case 3u:
					arg_B1_0 = ((GameSessionLocation.smethod_1(this.City) != 0) ? 2501511253u : 2671645565u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.City);
					arg_B1_0 = (num2 * 1579838592u ^ 2149871997u);
					continue;
				case 6u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.IpAddress);
					arg_B1_0 = (num2 * 3348727260u ^ 1741041041u);
					continue;
				}
				break;
			}
			return num;
			IL_88:
			arg_B1_0 = 2200853773u;
			goto IL_AC;
			IL_E8:
			arg_B1_0 = ((this.Country != 0u) ? 4074987525u : 3424924186u);
			goto IL_AC;
		}

		public void MergeFrom(GameSessionLocation other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_FD;
			uint arg_BD_0;
			while (true)
			{
				IL_B8:
				uint num;
				switch ((num = (arg_BD_0 ^ 153081207u)) % 9u)
				{
				case 0u:
					arg_BD_0 = ((GameSessionLocation.smethod_1(other.City) == 0) ? 1239628279u : 588397723u);
					continue;
				case 1u:
					return;
				case 3u:
					this.IpAddress = other.IpAddress;
					arg_BD_0 = (num * 748737534u ^ 842614929u);
					continue;
				case 4u:
					this.Country = other.Country;
					arg_BD_0 = (num * 2695251650u ^ 1585880760u);
					continue;
				case 5u:
					this.City = other.City;
					arg_BD_0 = (num * 1985214118u ^ 179392255u);
					continue;
				case 6u:
					goto IL_FD;
				case 7u:
					arg_BD_0 = ((other.Country != 0u) ? 1940172943u : 3377992u);
					continue;
				case 8u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_BD_0 = 1076397211u;
			goto IL_B8;
			IL_FD:
			arg_BD_0 = ((GameSessionLocation.smethod_1(other.IpAddress) == 0) ? 714893487u : 782978198u);
			goto IL_B8;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_138:
				uint num;
				uint arg_F0_0 = ((num = input.ReadTag()) != 0u) ? 1288392418u : 583349700u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F0_0 ^ 210039683u)) % 11u)
					{
					case 0u:
						this.Country = input.ReadUInt32();
						arg_F0_0 = 1724612509u;
						continue;
					case 1u:
						arg_F0_0 = ((num == 10u) ? 291755936u : 1738198365u);
						continue;
					case 2u:
						this.IpAddress = input.ReadString();
						arg_F0_0 = 309534634u;
						continue;
					case 3u:
						arg_F0_0 = (((num == 16u) ? 4216091980u : 2330661770u) ^ num2 * 2918490343u);
						continue;
					case 4u:
						this.City = input.ReadString();
						arg_F0_0 = 1724612509u;
						continue;
					case 5u:
						arg_F0_0 = (((num == 26u) ? 2539723943u : 3990048715u) ^ num2 * 3952958267u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_F0_0 = (num2 * 1094751975u ^ 1305258282u);
						continue;
					case 8u:
						goto IL_138;
					case 9u:
						arg_F0_0 = (num2 * 769386005u ^ 3797764800u);
						continue;
					case 10u:
						arg_F0_0 = 1288392418u;
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
