using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class PrivacyInfo : IMessage<PrivacyInfo>, IEquatable<PrivacyInfo>, IDeepCloneable<PrivacyInfo>, IMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum GameInfoPrivacy
			{
				PRIVACY_ME,
				PRIVACY_FRIENDS,
				PRIVACY_EVERYONE
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly PrivacyInfo.__c __9 = new PrivacyInfo.__c();

			internal PrivacyInfo cctor>b__40_0()
			{
				return new PrivacyInfo();
			}
		}

		private static readonly MessageParser<PrivacyInfo> _parser = new MessageParser<PrivacyInfo>(new Func<PrivacyInfo>(PrivacyInfo.__c.__9.<.cctor>b__40_0));

		public const int IsUsingRidFieldNumber = 3;

		private bool isUsingRid_;

		public const int IsRealIdVisibleForViewFriendsFieldNumber = 4;

		private bool isRealIdVisibleForViewFriends_;

		public const int IsHiddenFromFriendFinderFieldNumber = 5;

		private bool isHiddenFromFriendFinder_;

		public const int GameInfoPrivacyFieldNumber = 6;

		private PrivacyInfo.Types.GameInfoPrivacy gameInfoPrivacy_;

		public static MessageParser<PrivacyInfo> Parser
		{
			get
			{
				return PrivacyInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[19];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivacyInfo.Descriptor;
			}
		}

		public bool IsUsingRid
		{
			get
			{
				return this.isUsingRid_;
			}
			set
			{
				this.isUsingRid_ = value;
			}
		}

		public bool IsRealIdVisibleForViewFriends
		{
			get
			{
				return this.isRealIdVisibleForViewFriends_;
			}
			set
			{
				this.isRealIdVisibleForViewFriends_ = value;
			}
		}

		public bool IsHiddenFromFriendFinder
		{
			get
			{
				return this.isHiddenFromFriendFinder_;
			}
			set
			{
				this.isHiddenFromFriendFinder_ = value;
			}
		}

		public PrivacyInfo.Types.GameInfoPrivacy GameInfoPrivacy
		{
			get
			{
				return this.gameInfoPrivacy_;
			}
			set
			{
				this.gameInfoPrivacy_ = value;
			}
		}

		public PrivacyInfo()
		{
		}

		public PrivacyInfo(PrivacyInfo other) : this()
		{
			this.isUsingRid_ = other.isUsingRid_;
			this.isRealIdVisibleForViewFriends_ = other.isRealIdVisibleForViewFriends_;
			this.isHiddenFromFriendFinder_ = other.isHiddenFromFriendFinder_;
			this.gameInfoPrivacy_ = other.gameInfoPrivacy_;
		}

		public PrivacyInfo Clone()
		{
			return new PrivacyInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as PrivacyInfo);
		}

		public bool Equals(PrivacyInfo other)
		{
			if (other == null)
			{
				goto IL_66;
			}
			goto IL_10C;
			int arg_BE_0;
			while (true)
			{
				IL_B9:
				switch ((arg_BE_0 ^ -1269463170) % 13)
				{
				case 0:
					arg_BE_0 = ((this.IsUsingRid != other.IsUsingRid) ? -997117834 : -374165687);
					continue;
				case 1:
					arg_BE_0 = ((this.IsHiddenFromFriendFinder == other.IsHiddenFromFriendFinder) ? -414200359 : -824542822);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_66;
				case 5:
					arg_BE_0 = ((this.IsRealIdVisibleForViewFriends != other.IsRealIdVisibleForViewFriends) ? -1245146739 : -2103264070);
					continue;
				case 6:
					arg_BE_0 = ((this.GameInfoPrivacy == other.GameInfoPrivacy) ? -769389055 : -59112665);
					continue;
				case 8:
					return false;
				case 9:
					return true;
				case 10:
					return false;
				case 11:
					goto IL_10C;
				case 12:
					return false;
				}
				break;
			}
			return true;
			IL_66:
			arg_BE_0 = -1705286140;
			goto IL_B9;
			IL_10C:
			arg_BE_0 = ((other == this) ? -642725252 : -1273684878);
			goto IL_B9;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsUsingRid)
			{
				goto IL_8B;
			}
			goto IL_137;
			uint arg_F7_0;
			while (true)
			{
				IL_F2:
				uint num2;
				switch ((num2 = (arg_F7_0 ^ 1090258972u)) % 9u)
				{
				case 0u:
					num ^= this.IsHiddenFromFriendFinder.GetHashCode();
					arg_F7_0 = (num2 * 3497955619u ^ 3593607670u);
					continue;
				case 1u:
					goto IL_137;
				case 2u:
					arg_F7_0 = ((this.GameInfoPrivacy == PrivacyInfo.Types.GameInfoPrivacy.PRIVACY_ME) ? 2043557185u : 2067625241u);
					continue;
				case 3u:
					arg_F7_0 = (this.IsHiddenFromFriendFinder ? 608862474u : 1465658868u);
					continue;
				case 4u:
					goto IL_8B;
				case 5u:
					num ^= this.IsRealIdVisibleForViewFriends.GetHashCode();
					arg_F7_0 = (num2 * 57698870u ^ 2869384634u);
					continue;
				case 7u:
					num ^= this.GameInfoPrivacy.GetHashCode();
					arg_F7_0 = (num2 * 3818576960u ^ 2719987713u);
					continue;
				case 8u:
					num ^= this.IsUsingRid.GetHashCode();
					arg_F7_0 = (num2 * 4235545383u ^ 4122073871u);
					continue;
				}
				break;
			}
			return num;
			IL_8B:
			arg_F7_0 = 1152156567u;
			goto IL_F2;
			IL_137:
			arg_F7_0 = ((!this.IsRealIdVisibleForViewFriends) ? 1255387964u : 934882533u);
			goto IL_F2;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.IsUsingRid)
			{
				goto IL_DD;
			}
			goto IL_167;
			uint arg_11F_0;
			while (true)
			{
				IL_11A:
				uint num;
				switch ((num = (arg_11F_0 ^ 2973996928u)) % 11u)
				{
				case 1u:
					arg_11F_0 = ((!this.IsHiddenFromFriendFinder) ? 3128570003u : 3959208121u);
					continue;
				case 2u:
					output.WriteRawTag(40);
					arg_11F_0 = (num * 3049827751u ^ 1619161886u);
					continue;
				case 3u:
					goto IL_DD;
				case 4u:
					output.WriteRawTag(32);
					arg_11F_0 = (num * 3690335304u ^ 163877848u);
					continue;
				case 5u:
					output.WriteRawTag(48);
					output.WriteEnum((int)this.GameInfoPrivacy);
					arg_11F_0 = (num * 2267063656u ^ 186262202u);
					continue;
				case 6u:
					goto IL_167;
				case 7u:
					output.WriteBool(this.IsHiddenFromFriendFinder);
					arg_11F_0 = (num * 2580774359u ^ 3850142260u);
					continue;
				case 8u:
					output.WriteBool(this.IsRealIdVisibleForViewFriends);
					arg_11F_0 = (num * 1482339491u ^ 3212624460u);
					continue;
				case 9u:
					output.WriteRawTag(24);
					output.WriteBool(this.IsUsingRid);
					arg_11F_0 = (num * 2815178783u ^ 1129286719u);
					continue;
				case 10u:
					arg_11F_0 = ((this.GameInfoPrivacy != PrivacyInfo.Types.GameInfoPrivacy.PRIVACY_ME) ? 2182873702u : 2317877706u);
					continue;
				}
				break;
			}
			return;
			IL_DD:
			arg_11F_0 = 2317035680u;
			goto IL_11A;
			IL_167:
			arg_11F_0 = ((!this.IsRealIdVisibleForViewFriends) ? 3817771452u : 4150608921u);
			goto IL_11A;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_12F:
				uint arg_FA_0 = 2991017885u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_FA_0 ^ 2498181733u)) % 10u)
					{
					case 0u:
						goto IL_12F;
					case 2u:
						arg_FA_0 = (this.IsRealIdVisibleForViewFriends ? 2592568164u : 3728214941u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GameInfoPrivacy);
						arg_FA_0 = (num2 * 1113762422u ^ 2074371920u);
						continue;
					case 4u:
						arg_FA_0 = (this.IsHiddenFromFriendFinder ? 2197609821u : 2977478162u);
						continue;
					case 5u:
						arg_FA_0 = ((this.GameInfoPrivacy == PrivacyInfo.Types.GameInfoPrivacy.PRIVACY_ME) ? 2781731458u : 3786862670u);
						continue;
					case 6u:
						num += 2;
						arg_FA_0 = (num2 * 1641209817u ^ 1098412138u);
						continue;
					case 7u:
						num += 2;
						arg_FA_0 = (num2 * 605269322u ^ 1324099959u);
						continue;
					case 8u:
						arg_FA_0 = (((!this.IsUsingRid) ? 3707967641u : 2402667698u) ^ num2 * 4028438193u);
						continue;
					case 9u:
						num += 2;
						arg_FA_0 = (num2 * 1617533324u ^ 1737133585u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(PrivacyInfo other)
		{
			if (other == null)
			{
				goto IL_B4;
			}
			goto IL_142;
			uint arg_FA_0;
			while (true)
			{
				IL_F5:
				uint num;
				switch ((num = (arg_FA_0 ^ 2297862859u)) % 11u)
				{
				case 0u:
					arg_FA_0 = ((!other.IsHiddenFromFriendFinder) ? 4042959675u : 3618057225u);
					continue;
				case 1u:
					return;
				case 2u:
					this.GameInfoPrivacy = other.GameInfoPrivacy;
					arg_FA_0 = (num * 1220726845u ^ 1617795141u);
					continue;
				case 3u:
					goto IL_B4;
				case 4u:
					this.IsUsingRid = other.IsUsingRid;
					arg_FA_0 = (num * 2803599959u ^ 3261893399u);
					continue;
				case 6u:
					arg_FA_0 = ((other.GameInfoPrivacy == PrivacyInfo.Types.GameInfoPrivacy.PRIVACY_ME) ? 3903858856u : 3300107450u);
					continue;
				case 7u:
					goto IL_142;
				case 8u:
					this.IsHiddenFromFriendFinder = other.IsHiddenFromFriendFinder;
					arg_FA_0 = (num * 3590593721u ^ 703127817u);
					continue;
				case 9u:
					arg_FA_0 = (other.IsRealIdVisibleForViewFriends ? 2611081147u : 2150097445u);
					continue;
				case 10u:
					this.IsRealIdVisibleForViewFriends = other.IsRealIdVisibleForViewFriends;
					arg_FA_0 = (num * 670229420u ^ 534959461u);
					continue;
				}
				break;
			}
			return;
			IL_B4:
			arg_FA_0 = 3993229036u;
			goto IL_F5;
			IL_142:
			arg_FA_0 = (other.IsUsingRid ? 3192284188u : 3814656518u);
			goto IL_F5;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1AF:
				uint num;
				uint arg_157_0 = ((num = input.ReadTag()) == 0u) ? 837942778u : 33121334u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_157_0 ^ 1949101265u)) % 15u)
					{
					case 0u:
						arg_157_0 = 33121334u;
						continue;
					case 1u:
						this.IsRealIdVisibleForViewFriends = input.ReadBool();
						arg_157_0 = 1215514799u;
						continue;
					case 2u:
						arg_157_0 = (num2 * 4040789942u ^ 1945481537u);
						continue;
					case 3u:
						arg_157_0 = ((num == 40u) ? 634192043u : 928980586u);
						continue;
					case 4u:
						this.IsHiddenFromFriendFinder = input.ReadBool();
						arg_157_0 = 403278461u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_157_0 = 403278461u;
						continue;
					case 7u:
						arg_157_0 = ((num <= 32u) ? 1444789018u : 1098016105u);
						continue;
					case 8u:
						arg_157_0 = (((num == 32u) ? 2777771114u : 2613850185u) ^ num2 * 3835202766u);
						continue;
					case 9u:
						this.IsUsingRid = input.ReadBool();
						arg_157_0 = 403278461u;
						continue;
					case 10u:
						arg_157_0 = (num2 * 1983429181u ^ 4157879419u);
						continue;
					case 11u:
						arg_157_0 = (((num != 48u) ? 2553138446u : 3619491984u) ^ num2 * 2220045517u);
						continue;
					case 12u:
						this.gameInfoPrivacy_ = (PrivacyInfo.Types.GameInfoPrivacy)input.ReadEnum();
						arg_157_0 = 403278461u;
						continue;
					case 13u:
						arg_157_0 = (((num != 24u) ? 2421133213u : 2539890418u) ^ num2 * 3667378828u);
						continue;
					case 14u:
						goto IL_1AF;
					}
					return;
				}
			}
		}
	}
}
