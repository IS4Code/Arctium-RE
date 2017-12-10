using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class Friend : IMessage<Friend>, IEquatable<Friend>, IDeepCloneable<Friend>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Friend.__c __9 = new Friend.__c();

			internal Friend cctor>b__54_0()
			{
				return new Friend();
			}
		}

		private static readonly MessageParser<Friend> _parser = new MessageParser<Friend>(new Func<Friend>(Friend.__c.__9.<.cctor>b__54_0));

		public const int AccountIdFieldNumber = 1;

		private EntityId accountId_;

		public const int AttributeFieldNumber = 2;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec;

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int RoleFieldNumber = 3;

		private static readonly FieldCodec<uint> _repeated_role_codec;

		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		public const int PrivilegesFieldNumber = 4;

		private ulong privileges_;

		public const int AttributesEpochFieldNumber = 5;

		private ulong attributesEpoch_;

		public const int FullNameFieldNumber = 6;

		private string fullName_ = "";

		public const int BattleTagFieldNumber = 7;

		private string battleTag_ = "";

		public static MessageParser<Friend> Parser
		{
			get
			{
				return Friend._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Friend.Descriptor;
			}
		}

		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		public ulong Privileges
		{
			get
			{
				return this.privileges_;
			}
			set
			{
				this.privileges_ = value;
			}
		}

		public ulong AttributesEpoch
		{
			get
			{
				return this.attributesEpoch_;
			}
			set
			{
				this.attributesEpoch_ = value;
			}
		}

		public string FullName
		{
			get
			{
				return this.fullName_;
			}
			set
			{
				this.fullName_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public string BattleTag
		{
			get
			{
				return this.battleTag_;
			}
			set
			{
				this.battleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public Friend()
		{
		}

		public Friend(Friend other) : this()
		{
			while (true)
			{
				IL_C8:
				uint arg_A4_0 = 2432262734u;
				while (true)
				{
					uint num;
					switch ((num = (arg_A4_0 ^ 2235398958u)) % 6u)
					{
					case 0u:
						goto IL_C8;
					case 2u:
						this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
						this.attribute_ = other.attribute_.Clone();
						arg_A4_0 = 3309738956u;
						continue;
					case 3u:
						this.attributesEpoch_ = other.attributesEpoch_;
						arg_A4_0 = (num * 4154278684u ^ 3447661709u);
						continue;
					case 4u:
						this.role_ = other.role_.Clone();
						this.privileges_ = other.privileges_;
						arg_A4_0 = (num * 1427615383u ^ 3775941955u);
						continue;
					case 5u:
						this.fullName_ = other.fullName_;
						arg_A4_0 = (num * 380829200u ^ 3477693313u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.battleTag_ = other.battleTag_;
		}

		public Friend Clone()
		{
			return new Friend(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Friend);
		}

		public bool Equals(Friend other)
		{
			if (other == null)
			{
				goto IL_151;
			}
			goto IL_1C1;
			int arg_15B_0;
			while (true)
			{
				IL_156:
				switch ((arg_15B_0 ^ 1549770097) % 19)
				{
				case 0:
					goto IL_151;
				case 1:
					arg_15B_0 = ((!Friend.smethod_0(this.AccountId, other.AccountId)) ? 725939771 : 220292978);
					continue;
				case 2:
					arg_15B_0 = ((!Friend.smethod_1(this.BattleTag, other.BattleTag)) ? 1378127231 : 1780819106);
					continue;
				case 3:
					arg_15B_0 = ((this.AttributesEpoch == other.AttributesEpoch) ? 539301933 : 324136302);
					continue;
				case 4:
					return true;
				case 5:
					return false;
				case 6:
					arg_15B_0 = ((this.Privileges != other.Privileges) ? 448880595 : 2026573051);
					continue;
				case 7:
					goto IL_1C1;
				case 8:
					return false;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					arg_15B_0 = (this.attribute_.Equals(other.attribute_) ? 59107559 : 1930528043);
					continue;
				case 12:
					arg_15B_0 = ((!Friend.smethod_1(this.FullName, other.FullName)) ? 1372783714 : 1622320884);
					continue;
				case 13:
					arg_15B_0 = (this.role_.Equals(other.role_) ? 1502449765 : 753099803);
					continue;
				case 14:
					return false;
				case 15:
					return false;
				case 17:
					return false;
				case 18:
					return false;
				}
				break;
			}
			return true;
			IL_151:
			arg_15B_0 = 274764584;
			goto IL_156;
			IL_1C1:
			arg_15B_0 = ((other == this) ? 601252364 : 1862048144);
			goto IL_156;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_1D6:
				uint arg_195_0 = 2210699668u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_195_0 ^ 3728171441u)) % 13u)
					{
					case 0u:
						num ^= Friend.smethod_2(this.AccountId);
						arg_195_0 = (num2 * 2214133160u ^ 3869003380u);
						continue;
					case 1u:
						num ^= this.BattleTag.GetHashCode();
						arg_195_0 = (num2 * 1740375450u ^ 1642533829u);
						continue;
					case 2u:
						goto IL_1D6;
					case 3u:
						arg_195_0 = ((this.FullName.Length == 0) ? 4081570299u : 3438191549u);
						continue;
					case 4u:
						num ^= Friend.smethod_2(this.attribute_);
						arg_195_0 = 3215736576u;
						continue;
					case 5u:
						num ^= this.Privileges.GetHashCode();
						arg_195_0 = (num2 * 829384397u ^ 256114110u);
						continue;
					case 7u:
						num ^= this.AttributesEpoch.GetHashCode();
						arg_195_0 = (num2 * 447210149u ^ 605136229u);
						continue;
					case 8u:
						arg_195_0 = ((this.AttributesEpoch == 0uL) ? 3142695914u : 2187107218u);
						continue;
					case 9u:
						num ^= this.FullName.GetHashCode();
						arg_195_0 = (num2 * 1644790112u ^ 3315270011u);
						continue;
					case 10u:
						arg_195_0 = (((this.accountId_ != null) ? 3334017200u : 4049205731u) ^ num2 * 167888283u);
						continue;
					case 11u:
						arg_195_0 = ((this.BattleTag.Length == 0) ? 4174337565u : 2924955437u);
						continue;
					case 12u:
						num ^= Friend.smethod_2(this.role_);
						arg_195_0 = (((this.Privileges != 0uL) ? 294360960u : 1028300959u) ^ num2 * 1598529525u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.accountId_ != null)
			{
				goto IL_45;
			}
			goto IL_1C1;
			uint arg_180_0;
			while (true)
			{
				IL_17B:
				uint num;
				switch ((num = (arg_180_0 ^ 3138894497u)) % 13u)
				{
				case 0u:
					arg_180_0 = ((this.AttributesEpoch == 0uL) ? 2368424702u : 2196702652u);
					continue;
				case 1u:
					output.WriteRawTag(40);
					output.WriteUInt64(this.AttributesEpoch);
					arg_180_0 = (num * 324375418u ^ 2630021164u);
					continue;
				case 2u:
					output.WriteRawTag(58);
					output.WriteString(this.BattleTag);
					arg_180_0 = (num * 833634132u ^ 1223623800u);
					continue;
				case 3u:
					arg_180_0 = ((Friend.smethod_3(this.BattleTag) == 0) ? 4017108660u : 2271939782u);
					continue;
				case 4u:
					output.WriteRawTag(50);
					output.WriteString(this.FullName);
					arg_180_0 = (num * 4111655209u ^ 4099741047u);
					continue;
				case 5u:
					arg_180_0 = (((this.Privileges == 0uL) ? 3260057427u : 4060699509u) ^ num * 3721177741u);
					continue;
				case 6u:
					arg_180_0 = ((Friend.smethod_3(this.FullName) == 0) ? 2520775567u : 2205435033u);
					continue;
				case 7u:
					goto IL_1C1;
				case 8u:
					output.WriteRawTag(32);
					output.WriteUInt64(this.Privileges);
					arg_180_0 = (num * 2704745202u ^ 2701962581u);
					continue;
				case 9u:
					goto IL_45;
				case 11u:
					output.WriteRawTag(10);
					arg_180_0 = (num * 3659479586u ^ 313327519u);
					continue;
				case 12u:
					output.WriteMessage(this.AccountId);
					arg_180_0 = (num * 2494476165u ^ 451315935u);
					continue;
				}
				break;
			}
			return;
			IL_45:
			arg_180_0 = 3864575671u;
			goto IL_17B;
			IL_1C1:
			this.attribute_.WriteTo(output, Friend._repeated_attribute_codec);
			this.role_.WriteTo(output, Friend._repeated_role_codec);
			arg_180_0 = 4116808259u;
			goto IL_17B;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.accountId_ != null)
			{
				goto IL_A3;
			}
			goto IL_1AF;
			uint arg_172_0;
			while (true)
			{
				IL_16D:
				uint num2;
				switch ((num2 = (arg_172_0 ^ 57745913u)) % 12u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.AttributesEpoch);
					arg_172_0 = (num2 * 1411810589u ^ 2076976575u);
					continue;
				case 1u:
					num += this.role_.CalculateSize(Friend._repeated_role_codec);
					arg_172_0 = (((this.Privileges == 0uL) ? 3007110649u : 2606868834u) ^ num2 * 3991515977u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.Privileges);
					arg_172_0 = (num2 * 3403702149u ^ 4258985194u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.FullName);
					arg_172_0 = (num2 * 1426253885u ^ 1815357931u);
					continue;
				case 5u:
					arg_172_0 = ((Friend.smethod_3(this.BattleTag) == 0) ? 1321343393u : 160083657u);
					continue;
				case 6u:
					goto IL_A3;
				case 7u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
					arg_172_0 = (num2 * 2458239196u ^ 904290378u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
					arg_172_0 = (num2 * 1472970601u ^ 1120965393u);
					continue;
				case 9u:
					arg_172_0 = ((this.AttributesEpoch == 0uL) ? 825230655u : 930356089u);
					continue;
				case 10u:
					arg_172_0 = ((Friend.smethod_3(this.FullName) == 0) ? 1414455108u : 1075362978u);
					continue;
				case 11u:
					goto IL_1AF;
				}
				break;
			}
			return num;
			IL_A3:
			arg_172_0 = 1239185470u;
			goto IL_16D;
			IL_1AF:
			num += this.attribute_.CalculateSize(Friend._repeated_attribute_codec);
			arg_172_0 = 1704934052u;
			goto IL_16D;
		}

		public void MergeFrom(Friend other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_21F;
			uint arg_1C3_0;
			while (true)
			{
				IL_1BE:
				uint num;
				switch ((num = (arg_1C3_0 ^ 3763732900u)) % 16u)
				{
				case 0u:
					this.role_.Add(other.role_);
					arg_1C3_0 = (((other.Privileges == 0uL) ? 172192495u : 728676158u) ^ num * 1904068569u);
					continue;
				case 1u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_1C3_0 = 4144190001u;
					continue;
				case 2u:
					arg_1C3_0 = ((Friend.smethod_3(other.FullName) == 0) ? 3103044649u : 4121392610u);
					continue;
				case 3u:
					this.accountId_ = new EntityId();
					arg_1C3_0 = (num * 454764248u ^ 2517073613u);
					continue;
				case 4u:
					this.AttributesEpoch = other.AttributesEpoch;
					arg_1C3_0 = (num * 4223374412u ^ 2950116182u);
					continue;
				case 5u:
					this.attribute_.Add(other.attribute_);
					arg_1C3_0 = 2250884228u;
					continue;
				case 6u:
					this.FullName = other.FullName;
					arg_1C3_0 = (num * 2466159304u ^ 385631897u);
					continue;
				case 7u:
					goto IL_21F;
				case 8u:
					this.BattleTag = other.BattleTag;
					arg_1C3_0 = (num * 1386754993u ^ 1341995360u);
					continue;
				case 9u:
					arg_1C3_0 = (((this.accountId_ != null) ? 652236322u : 329186608u) ^ num * 3218983727u);
					continue;
				case 10u:
					this.Privileges = other.Privileges;
					arg_1C3_0 = (num * 2635814404u ^ 926891047u);
					continue;
				case 11u:
					arg_1C3_0 = ((other.AttributesEpoch != 0uL) ? 4057481008u : 3948089510u);
					continue;
				case 13u:
					arg_1C3_0 = ((Friend.smethod_3(other.BattleTag) != 0) ? 3002938300u : 2632274936u);
					continue;
				case 14u:
					goto IL_18;
				case 15u:
					return;
				}
				break;
			}
			return;
			IL_18:
			arg_1C3_0 = 3783446267u;
			goto IL_1BE;
			IL_21F:
			arg_1C3_0 = ((other.accountId_ == null) ? 4144190001u : 4089320813u);
			goto IL_1BE;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_3EB:
				uint num;
				uint arg_34B_0 = ((num = input.ReadTag()) == 0u) ? 1845246190u : 682939485u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_34B_0 ^ 208401894u)) % 33u)
					{
					case 0u:
						arg_34B_0 = ((this.accountId_ != null) ? 1132576893u : 801463679u);
						continue;
					case 1u:
						this.role_.AddEntriesFrom(input, Friend._repeated_role_codec);
						arg_34B_0 = 227447178u;
						continue;
					case 2u:
						this.BattleTag = input.ReadString();
						arg_34B_0 = 1751879905u;
						continue;
					case 3u:
						arg_34B_0 = (num2 * 1455380807u ^ 761789557u);
						continue;
					case 4u:
						arg_34B_0 = (((num == 18u) ? 1604747343u : 682555123u) ^ num2 * 3779944117u);
						continue;
					case 5u:
						arg_34B_0 = (((num <= 18u) ? 3563978001u : 2927426049u) ^ num2 * 424251529u);
						continue;
					case 6u:
						arg_34B_0 = (num2 * 1159334148u ^ 2840773360u);
						continue;
					case 7u:
						goto IL_3EB;
					case 8u:
						arg_34B_0 = ((num != 50u) ? 17081445u : 1295604132u);
						continue;
					case 9u:
						arg_34B_0 = 682939485u;
						continue;
					case 10u:
						this.AttributesEpoch = input.ReadUInt64();
						arg_34B_0 = 1608748330u;
						continue;
					case 11u:
						this.accountId_ = new EntityId();
						arg_34B_0 = (num2 * 821861122u ^ 3985388623u);
						continue;
					case 12u:
						arg_34B_0 = (num2 * 47159646u ^ 1880675663u);
						continue;
					case 13u:
						arg_34B_0 = (num2 * 4251598270u ^ 1589574159u);
						continue;
					case 15u:
						arg_34B_0 = (((num == 26u) ? 137193694u : 81672562u) ^ num2 * 2543774026u);
						continue;
					case 16u:
						arg_34B_0 = (num2 * 1389254603u ^ 243524046u);
						continue;
					case 17u:
						arg_34B_0 = (num2 * 1595350214u ^ 3119257658u);
						continue;
					case 18u:
						arg_34B_0 = ((num != 24u) ? 982741321u : 968280392u);
						continue;
					case 19u:
						arg_34B_0 = (((num != 40u) ? 3347985305u : 3713837398u) ^ num2 * 2226417492u);
						continue;
					case 20u:
						arg_34B_0 = ((num <= 26u) ? 936555487u : 826476304u);
						continue;
					case 21u:
						arg_34B_0 = (num2 * 315728963u ^ 1877076133u);
						continue;
					case 22u:
						this.Privileges = input.ReadUInt64();
						arg_34B_0 = 601325724u;
						continue;
					case 23u:
						arg_34B_0 = (num2 * 51103805u ^ 360926443u);
						continue;
					case 24u:
						arg_34B_0 = (num2 * 3454118937u ^ 1390731275u);
						continue;
					case 25u:
						arg_34B_0 = (((num != 32u) ? 4153661665u : 3511396056u) ^ num2 * 4060141446u);
						continue;
					case 26u:
						input.SkipLastField();
						arg_34B_0 = 148722623u;
						continue;
					case 27u:
						arg_34B_0 = (((num == 10u) ? 454047650u : 798804493u) ^ num2 * 1621405964u);
						continue;
					case 28u:
						this.FullName = input.ReadString();
						arg_34B_0 = 1751879905u;
						continue;
					case 29u:
						this.attribute_.AddEntriesFrom(input, Friend._repeated_attribute_codec);
						arg_34B_0 = 725057935u;
						continue;
					case 30u:
						arg_34B_0 = (((num == 58u) ? 3651830611u : 3086656321u) ^ num2 * 1878799667u);
						continue;
					case 31u:
						arg_34B_0 = ((num > 40u) ? 1587532822u : 1656800813u);
						continue;
					case 32u:
						input.ReadMessage(this.accountId_);
						arg_34B_0 = 1279481652u;
						continue;
					}
					return;
				}
			}
		}

		static Friend()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_76:
				uint arg_5A_0 = 3763193023u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5A_0 ^ 2882862508u)) % 4u)
					{
					case 0u:
						goto IL_76;
					case 2u:
						Friend._repeated_role_codec = FieldCodec.ForUInt32(26u);
						arg_5A_0 = (num * 3603598278u ^ 3726229073u);
						continue;
					case 3u:
						Friend._repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(18u, Bgs.Protocol.Attribute.Parser);
						arg_5A_0 = (num * 906386255u ^ 2717449295u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_3(string string_0)
		{
			return string_0.Length;
		}
	}
}
