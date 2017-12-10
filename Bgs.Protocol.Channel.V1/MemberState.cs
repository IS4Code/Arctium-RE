using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class MemberState : IMessage<MemberState>, IEquatable<MemberState>, IDeepCloneable<MemberState>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MemberState.__c __9 = new MemberState.__c();

			internal MemberState cctor>b__44_0()
			{
				return new MemberState();
			}
		}

		private static readonly MessageParser<MemberState> _parser = new MessageParser<MemberState>(new Func<MemberState>(MemberState.__c.__9.<.cctor>b__44_0));

		public const int AttributeFieldNumber = 1;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(10u, Bgs.Protocol.Attribute.Parser);

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int RoleFieldNumber = 2;

		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(18u);

		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		public const int PrivilegesFieldNumber = 3;

		private ulong privileges_;

		public const int InfoFieldNumber = 4;

		private AccountInfo info_;

		public const int DEPRECATEDHiddenFieldNumber = 5;

		private bool dEPRECATEDHidden_;

		public static MessageParser<MemberState> Parser
		{
			get
			{
				return MemberState._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberState.Descriptor;
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

		public AccountInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		public bool DEPRECATEDHidden
		{
			get
			{
				return this.dEPRECATEDHidden_;
			}
			set
			{
				this.dEPRECATEDHidden_ = value;
			}
		}

		public MemberState()
		{
		}

		public MemberState(MemberState other) : this()
		{
			while (true)
			{
				IL_9D:
				uint arg_7D_0 = 721556297u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7D_0 ^ 1363805824u)) % 5u)
					{
					case 0u:
						this.role_ = other.role_.Clone();
						arg_7D_0 = (num * 3858104767u ^ 2844106940u);
						continue;
					case 1u:
						this.attribute_ = other.attribute_.Clone();
						arg_7D_0 = (num * 2889401468u ^ 679540175u);
						continue;
					case 2u:
						this.privileges_ = other.privileges_;
						this.Info = ((other.info_ != null) ? other.Info.Clone() : null);
						arg_7D_0 = 2017433432u;
						continue;
					case 3u:
						goto IL_9D;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.dEPRECATEDHidden_ = other.dEPRECATEDHidden_;
		}

		public MemberState Clone()
		{
			return new MemberState(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MemberState);
		}

		public bool Equals(MemberState other)
		{
			if (other == null)
			{
				goto IL_42;
			}
			goto IL_150;
			int arg_FA_0;
			while (true)
			{
				IL_F5:
				switch ((arg_FA_0 ^ -1858847969) % 15)
				{
				case 0:
					return false;
				case 1:
					arg_FA_0 = ((this.Privileges == other.Privileges) ? -84682189 : -2137937122);
					continue;
				case 2:
					return false;
				case 3:
					arg_FA_0 = (this.attribute_.Equals(other.attribute_) ? -204513718 : -2048964916);
					continue;
				case 4:
					return false;
				case 5:
					arg_FA_0 = ((!MemberState.smethod_0(this.Info, other.Info)) ? -818685483 : -1110293389);
					continue;
				case 6:
					return false;
				case 7:
					return true;
				case 8:
					goto IL_150;
				case 10:
					arg_FA_0 = (this.role_.Equals(other.role_) ? -265732000 : -2042606299);
					continue;
				case 11:
					goto IL_42;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					arg_FA_0 = ((this.DEPRECATEDHidden == other.DEPRECATEDHidden) ? -1703177146 : -2013638314);
					continue;
				}
				break;
			}
			return true;
			IL_42:
			arg_FA_0 = -22956260;
			goto IL_F5;
			IL_150:
			arg_FA_0 = ((other != this) ? -292120238 : -767756230);
			goto IL_F5;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ MemberState.smethod_1(this.attribute_);
			while (true)
			{
				IL_11D:
				uint arg_F1_0 = 1902943516u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F1_0 ^ 653977585u)) % 8u)
					{
					case 0u:
						arg_F1_0 = ((this.info_ != null) ? 711376971u : 1993413637u);
						continue;
					case 2u:
						num ^= this.Info.GetHashCode();
						arg_F1_0 = (num2 * 1416454424u ^ 1026697077u);
						continue;
					case 3u:
						num ^= this.DEPRECATEDHidden.GetHashCode();
						arg_F1_0 = (num2 * 4178116074u ^ 1621441190u);
						continue;
					case 4u:
						arg_F1_0 = ((!this.DEPRECATEDHidden) ? 246386792u : 1382348442u);
						continue;
					case 5u:
						num ^= MemberState.smethod_1(this.role_);
						arg_F1_0 = (((this.Privileges == 0uL) ? 2728981340u : 3729454491u) ^ num2 * 3623796657u);
						continue;
					case 6u:
						goto IL_11D;
					case 7u:
						num ^= this.Privileges.GetHashCode();
						arg_F1_0 = (num2 * 1446323759u ^ 648661528u);
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
			this.attribute_.WriteTo(output, MemberState._repeated_attribute_codec);
			this.role_.WriteTo(output, MemberState._repeated_role_codec);
			while (true)
			{
				IL_170:
				uint arg_137_0 = 1884313537u;
				while (true)
				{
					uint num;
					switch ((num = (arg_137_0 ^ 902067631u)) % 11u)
					{
					case 0u:
						output.WriteMessage(this.Info);
						arg_137_0 = (num * 1327175836u ^ 3096049689u);
						continue;
					case 1u:
						output.WriteRawTag(40);
						arg_137_0 = (num * 2856329942u ^ 2708513521u);
						continue;
					case 2u:
						arg_137_0 = ((this.info_ == null) ? 1167416737u : 365036957u);
						continue;
					case 4u:
						arg_137_0 = ((!this.DEPRECATEDHidden) ? 1930386799u : 726812864u);
						continue;
					case 5u:
						output.WriteRawTag(24);
						arg_137_0 = (num * 416795661u ^ 1857733431u);
						continue;
					case 6u:
						output.WriteRawTag(34);
						arg_137_0 = (num * 3201061230u ^ 1636941617u);
						continue;
					case 7u:
						output.WriteUInt64(this.Privileges);
						arg_137_0 = (num * 3474962530u ^ 1909128225u);
						continue;
					case 8u:
						arg_137_0 = (((this.Privileges != 0uL) ? 1248055545u : 1239822585u) ^ num * 2153484202u);
						continue;
					case 9u:
						output.WriteBool(this.DEPRECATEDHidden);
						arg_137_0 = (num * 1121168799u ^ 2650844547u);
						continue;
					case 10u:
						goto IL_170;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_135:
				uint arg_104_0 = 4054054329u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_104_0 ^ 4161636974u)) % 9u)
					{
					case 0u:
						goto IL_135;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
						arg_104_0 = (num2 * 1831532562u ^ 321379960u);
						continue;
					case 2u:
						arg_104_0 = (((this.Privileges != 0uL) ? 2582065712u : 2430194462u) ^ num2 * 222837101u);
						continue;
					case 3u:
						arg_104_0 = ((!this.DEPRECATEDHidden) ? 2538728038u : 3737668088u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.Privileges);
						arg_104_0 = (num2 * 1949783375u ^ 4251518108u);
						continue;
					case 6u:
						num += this.attribute_.CalculateSize(MemberState._repeated_attribute_codec);
						num += this.role_.CalculateSize(MemberState._repeated_role_codec);
						arg_104_0 = (num2 * 554937248u ^ 1797354938u);
						continue;
					case 7u:
						num += 2;
						arg_104_0 = (num2 * 2454858535u ^ 3310819260u);
						continue;
					case 8u:
						arg_104_0 = ((this.info_ == null) ? 2769840164u : 2550006608u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(MemberState other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_157;
			uint arg_11A_0;
			while (true)
			{
				IL_115:
				uint num;
				switch ((num = (arg_11A_0 ^ 1135144546u)) % 12u)
				{
				case 0u:
					this.info_ = new AccountInfo();
					arg_11A_0 = (num * 3713590745u ^ 4174200629u);
					continue;
				case 1u:
					return;
				case 2u:
					arg_11A_0 = ((!other.DEPRECATEDHidden) ? 1656915793u : 285998200u);
					continue;
				case 3u:
					this.Info.MergeFrom(other.Info);
					arg_11A_0 = 1262946996u;
					continue;
				case 4u:
					goto IL_157;
				case 5u:
					arg_11A_0 = (((other.Privileges == 0uL) ? 1057389418u : 498458735u) ^ num * 2269014494u);
					continue;
				case 6u:
					arg_11A_0 = ((other.info_ == null) ? 1262946996u : 1831171274u);
					continue;
				case 8u:
					arg_11A_0 = (((this.info_ != null) ? 2787483793u : 2866442278u) ^ num * 2349235473u);
					continue;
				case 9u:
					goto IL_44;
				case 10u:
					this.DEPRECATEDHidden = other.DEPRECATEDHidden;
					arg_11A_0 = (num * 2648308074u ^ 2095599509u);
					continue;
				case 11u:
					this.Privileges = other.Privileges;
					arg_11A_0 = (num * 3749417044u ^ 566501992u);
					continue;
				}
				break;
			}
			return;
			IL_44:
			arg_11A_0 = 778702515u;
			goto IL_115;
			IL_157:
			this.attribute_.Add(other.attribute_);
			this.role_.Add(other.role_);
			arg_11A_0 = 2018291315u;
			goto IL_115;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2BE:
				uint num;
				uint arg_246_0 = ((num = input.ReadTag()) != 0u) ? 2737835890u : 3048208745u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_246_0 ^ 2246414525u)) % 23u)
					{
					case 0u:
						goto IL_2BE;
					case 1u:
						arg_246_0 = (((num != 40u) ? 3236060553u : 3938239125u) ^ num2 * 1413439998u);
						continue;
					case 2u:
						arg_246_0 = (num2 * 3248911609u ^ 2172688267u);
						continue;
					case 3u:
						arg_246_0 = (((num != 34u) ? 3880279389u : 3164557566u) ^ num2 * 3534801821u);
						continue;
					case 4u:
						input.ReadMessage(this.info_);
						arg_246_0 = 2810466451u;
						continue;
					case 6u:
						arg_246_0 = (((num != 16u) ? 3948674076u : 2869721572u) ^ num2 * 3973123142u);
						continue;
					case 7u:
						arg_246_0 = ((num != 24u) ? 3538106183u : 2185289230u);
						continue;
					case 8u:
						this.role_.AddEntriesFrom(input, MemberState._repeated_role_codec);
						arg_246_0 = 3227112410u;
						continue;
					case 9u:
						arg_246_0 = ((this.info_ == null) ? 3665285871u : 2166767670u);
						continue;
					case 10u:
						arg_246_0 = (num2 * 2621446487u ^ 2333199786u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_246_0 = 3136612711u;
						continue;
					case 12u:
						this.DEPRECATEDHidden = input.ReadBool();
						arg_246_0 = 3018986856u;
						continue;
					case 13u:
						arg_246_0 = (((num != 10u) ? 677713617u : 1620343950u) ^ num2 * 3525774661u);
						continue;
					case 14u:
						arg_246_0 = 2737835890u;
						continue;
					case 15u:
						arg_246_0 = (((num == 18u) ? 3103107255u : 3720668524u) ^ num2 * 3120522683u);
						continue;
					case 16u:
						arg_246_0 = ((num <= 18u) ? 2452045483u : 4274272447u);
						continue;
					case 17u:
						this.Privileges = input.ReadUInt64();
						arg_246_0 = 3018986856u;
						continue;
					case 18u:
						arg_246_0 = (num2 * 3448593532u ^ 3117857932u);
						continue;
					case 19u:
						this.info_ = new AccountInfo();
						arg_246_0 = (num2 * 3369335760u ^ 1179912342u);
						continue;
					case 20u:
						arg_246_0 = (num2 * 1102161004u ^ 3571128976u);
						continue;
					case 21u:
						arg_246_0 = (num2 * 2861331600u ^ 4106937480u);
						continue;
					case 22u:
						this.attribute_.AddEntriesFrom(input, MemberState._repeated_attribute_codec);
						arg_246_0 = 2704075443u;
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

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
