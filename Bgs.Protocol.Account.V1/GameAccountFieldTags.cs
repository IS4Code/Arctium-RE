using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountFieldTags : IMessage<GameAccountFieldTags>, IEquatable<GameAccountFieldTags>, IDeepCloneable<GameAccountFieldTags>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountFieldTags.__c __9 = new GameAccountFieldTags.__c();

			internal GameAccountFieldTags cctor>b__39_0()
			{
				return new GameAccountFieldTags();
			}
		}

		private static readonly MessageParser<GameAccountFieldTags> _parser = new MessageParser<GameAccountFieldTags>(new Func<GameAccountFieldTags>(GameAccountFieldTags.__c.__9.<.cctor>b__39_0));

		public const int GameLevelInfoTagFieldNumber = 2;

		private uint gameLevelInfoTag_;

		public const int GameTimeInfoTagFieldNumber = 3;

		private uint gameTimeInfoTag_;

		public const int GameStatusTagFieldNumber = 4;

		private uint gameStatusTag_;

		public const int RafInfoTagFieldNumber = 5;

		private uint rafInfoTag_;

		public static MessageParser<GameAccountFieldTags> Parser
		{
			get
			{
				return GameAccountFieldTags._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[14];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountFieldTags.Descriptor;
			}
		}

		public uint GameLevelInfoTag
		{
			get
			{
				return this.gameLevelInfoTag_;
			}
			set
			{
				this.gameLevelInfoTag_ = value;
			}
		}

		public uint GameTimeInfoTag
		{
			get
			{
				return this.gameTimeInfoTag_;
			}
			set
			{
				this.gameTimeInfoTag_ = value;
			}
		}

		public uint GameStatusTag
		{
			get
			{
				return this.gameStatusTag_;
			}
			set
			{
				this.gameStatusTag_ = value;
			}
		}

		public uint RafInfoTag
		{
			get
			{
				return this.rafInfoTag_;
			}
			set
			{
				this.rafInfoTag_ = value;
			}
		}

		public GameAccountFieldTags()
		{
		}

		public GameAccountFieldTags(GameAccountFieldTags other) : this()
		{
			this.gameLevelInfoTag_ = other.gameLevelInfoTag_;
			this.gameTimeInfoTag_ = other.gameTimeInfoTag_;
			this.gameStatusTag_ = other.gameStatusTag_;
			this.rafInfoTag_ = other.rafInfoTag_;
		}

		public GameAccountFieldTags Clone()
		{
			return new GameAccountFieldTags(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountFieldTags);
		}

		public bool Equals(GameAccountFieldTags other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_10F;
			int arg_C1_0;
			while (true)
			{
				IL_BC:
				switch ((arg_C1_0 ^ -1659054172) % 13)
				{
				case 0:
					arg_C1_0 = ((this.GameStatusTag != other.GameStatusTag) ? -1592459687 : -173664115);
					continue;
				case 1:
					return false;
				case 2:
					arg_C1_0 = ((this.GameTimeInfoTag == other.GameTimeInfoTag) ? -894563933 : -1114876485);
					continue;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					arg_C1_0 = ((this.RafInfoTag == other.RafInfoTag) ? -2141771685 : -1866164229);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					arg_C1_0 = ((this.GameLevelInfoTag == other.GameLevelInfoTag) ? -293355725 : -656973293);
					continue;
				case 10:
					goto IL_10F;
				case 11:
					return false;
				case 12:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_C1_0 = -1785546666;
			goto IL_BC;
			IL_10F:
			arg_C1_0 = ((other == this) ? -981901790 : -1441160984);
			goto IL_BC;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameLevelInfoTag != 0u)
			{
				goto IL_1F;
			}
			goto IL_131;
			uint arg_F1_0;
			while (true)
			{
				IL_EC:
				uint num2;
				switch ((num2 = (arg_F1_0 ^ 1549596246u)) % 9u)
				{
				case 0u:
					num ^= this.RafInfoTag.GetHashCode();
					arg_F1_0 = (num2 * 2715160316u ^ 2759916189u);
					continue;
				case 1u:
					arg_F1_0 = ((this.GameStatusTag != 0u) ? 222083683u : 1106968757u);
					continue;
				case 2u:
					num ^= this.GameTimeInfoTag.GetHashCode();
					arg_F1_0 = (num2 * 3631690882u ^ 1580262269u);
					continue;
				case 3u:
					num ^= this.GameStatusTag.GetHashCode();
					arg_F1_0 = (num2 * 4160774494u ^ 4157018307u);
					continue;
				case 4u:
					num ^= this.GameLevelInfoTag.GetHashCode();
					arg_F1_0 = (num2 * 3520863791u ^ 3807129854u);
					continue;
				case 5u:
					goto IL_131;
				case 6u:
					arg_F1_0 = ((this.RafInfoTag == 0u) ? 1467472625u : 67327219u);
					continue;
				case 8u:
					goto IL_1F;
				}
				break;
			}
			return num;
			IL_1F:
			arg_F1_0 = 26984673u;
			goto IL_EC;
			IL_131:
			arg_F1_0 = ((this.GameTimeInfoTag == 0u) ? 452533631u : 1029456535u);
			goto IL_EC;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.GameLevelInfoTag != 0u)
			{
				goto IL_EF;
			}
			goto IL_17D;
			uint arg_131_0;
			while (true)
			{
				IL_12C:
				uint num;
				switch ((num = (arg_131_0 ^ 1437303021u)) % 12u)
				{
				case 0u:
					arg_131_0 = ((this.RafInfoTag == 0u) ? 1145893483u : 993783850u);
					continue;
				case 1u:
					output.WriteRawTag(21);
					arg_131_0 = (num * 3389182696u ^ 3656603964u);
					continue;
				case 2u:
					goto IL_EF;
				case 3u:
					goto IL_17D;
				case 4u:
					arg_131_0 = ((this.GameStatusTag == 0u) ? 1364078557u : 512524215u);
					continue;
				case 5u:
					output.WriteFixed32(this.GameLevelInfoTag);
					arg_131_0 = (num * 2238264770u ^ 1930794296u);
					continue;
				case 6u:
					output.WriteRawTag(37);
					arg_131_0 = (num * 1524273500u ^ 2796356861u);
					continue;
				case 7u:
					output.WriteRawTag(45);
					arg_131_0 = (num * 2735203437u ^ 2600272385u);
					continue;
				case 8u:
					output.WriteFixed32(this.GameStatusTag);
					arg_131_0 = (num * 2687327285u ^ 3375030069u);
					continue;
				case 9u:
					output.WriteRawTag(29);
					output.WriteFixed32(this.GameTimeInfoTag);
					arg_131_0 = (num * 3539769895u ^ 2628375638u);
					continue;
				case 11u:
					output.WriteFixed32(this.RafInfoTag);
					arg_131_0 = (num * 394586398u ^ 1386678105u);
					continue;
				}
				break;
			}
			return;
			IL_EF:
			arg_131_0 = 1914284188u;
			goto IL_12C;
			IL_17D:
			arg_131_0 = ((this.GameTimeInfoTag == 0u) ? 87144937u : 1014744644u);
			goto IL_12C;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_120:
				uint arg_EB_0 = 2536707653u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_EB_0 ^ 2468535138u)) % 10u)
					{
					case 0u:
						num += 5;
						arg_EB_0 = (num2 * 2330762149u ^ 2058716963u);
						continue;
					case 1u:
						num += 5;
						arg_EB_0 = (num2 * 1307852173u ^ 2382413501u);
						continue;
					case 2u:
						goto IL_120;
					case 3u:
						arg_EB_0 = ((this.GameTimeInfoTag == 0u) ? 2420593347u : 2221916930u);
						continue;
					case 4u:
						num += 5;
						arg_EB_0 = (num2 * 4030935689u ^ 2147014335u);
						continue;
					case 5u:
						arg_EB_0 = (((this.GameLevelInfoTag == 0u) ? 4015835300u : 2735590137u) ^ num2 * 999640285u);
						continue;
					case 7u:
						arg_EB_0 = ((this.GameStatusTag == 0u) ? 2794467185u : 2830314930u);
						continue;
					case 8u:
						num += 5;
						arg_EB_0 = (num2 * 1929550752u ^ 1608129905u);
						continue;
					case 9u:
						arg_EB_0 = ((this.RafInfoTag != 0u) ? 2597396945u : 3921216810u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameAccountFieldTags other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_142;
			uint arg_FA_0;
			while (true)
			{
				IL_F5:
				uint num;
				switch ((num = (arg_FA_0 ^ 1144426519u)) % 11u)
				{
				case 0u:
					this.GameLevelInfoTag = other.GameLevelInfoTag;
					arg_FA_0 = (num * 3322491770u ^ 3979229563u);
					continue;
				case 2u:
					this.GameStatusTag = other.GameStatusTag;
					arg_FA_0 = (num * 3946244778u ^ 497389495u);
					continue;
				case 3u:
					arg_FA_0 = ((other.GameTimeInfoTag != 0u) ? 1306216370u : 233398377u);
					continue;
				case 4u:
					arg_FA_0 = ((other.RafInfoTag == 0u) ? 1053846647u : 1169959178u);
					continue;
				case 5u:
					this.RafInfoTag = other.RafInfoTag;
					arg_FA_0 = (num * 888933477u ^ 103024646u);
					continue;
				case 6u:
					arg_FA_0 = ((other.GameStatusTag != 0u) ? 1236528718u : 1145884333u);
					continue;
				case 7u:
					this.GameTimeInfoTag = other.GameTimeInfoTag;
					arg_FA_0 = (num * 1666097724u ^ 1418958021u);
					continue;
				case 8u:
					goto IL_142;
				case 9u:
					goto IL_18;
				case 10u:
					return;
				}
				break;
			}
			return;
			IL_18:
			arg_FA_0 = 1584673541u;
			goto IL_F5;
			IL_142:
			arg_FA_0 = ((other.GameLevelInfoTag == 0u) ? 894554195u : 237805107u);
			goto IL_F5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1E4:
				uint num;
				uint arg_184_0 = ((num = input.ReadTag()) == 0u) ? 782695326u : 1959731240u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_184_0 ^ 755129099u)) % 17u)
					{
					case 1u:
						arg_184_0 = (((num != 21u) ? 3231069507u : 2486216272u) ^ num2 * 198694902u);
						continue;
					case 2u:
						arg_184_0 = (((num != 45u) ? 1145013317u : 65798710u) ^ num2 * 2282226116u);
						continue;
					case 3u:
						arg_184_0 = (((num == 29u) ? 1410460428u : 1982067224u) ^ num2 * 379231827u);
						continue;
					case 4u:
						this.GameLevelInfoTag = input.ReadFixed32();
						arg_184_0 = 1774779530u;
						continue;
					case 5u:
						arg_184_0 = (num2 * 676600224u ^ 2441231428u);
						continue;
					case 6u:
						this.GameStatusTag = input.ReadFixed32();
						arg_184_0 = 526486477u;
						continue;
					case 7u:
						this.RafInfoTag = input.ReadFixed32();
						arg_184_0 = 1994028516u;
						continue;
					case 8u:
						arg_184_0 = 1959731240u;
						continue;
					case 9u:
						arg_184_0 = ((num != 37u) ? 2055789070u : 2065653822u);
						continue;
					case 10u:
						arg_184_0 = ((num <= 29u) ? 1646463459u : 1071667534u);
						continue;
					case 11u:
						arg_184_0 = (num2 * 3430777339u ^ 442830278u);
						continue;
					case 12u:
						arg_184_0 = (num2 * 2973161939u ^ 182446000u);
						continue;
					case 13u:
						this.GameTimeInfoTag = input.ReadFixed32();
						arg_184_0 = 1994028516u;
						continue;
					case 14u:
						goto IL_1E4;
					case 15u:
						arg_184_0 = (num2 * 2465912353u ^ 504808074u);
						continue;
					case 16u:
						input.SkipLastField();
						arg_184_0 = 226350757u;
						continue;
					}
					return;
				}
			}
		}
	}
}
