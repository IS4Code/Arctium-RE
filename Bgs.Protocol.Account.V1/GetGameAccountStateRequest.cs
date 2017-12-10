using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetGameAccountStateRequest : IMessage<GetGameAccountStateRequest>, IEquatable<GetGameAccountStateRequest>, IDeepCloneable<GetGameAccountStateRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetGameAccountStateRequest.__c __9 = new GetGameAccountStateRequest.__c();

			internal GetGameAccountStateRequest cctor>b__39_0()
			{
				return new GetGameAccountStateRequest();
			}
		}

		private static readonly MessageParser<GetGameAccountStateRequest> _parser = new MessageParser<GetGameAccountStateRequest>(new Func<GetGameAccountStateRequest>(GetGameAccountStateRequest.__c.__9.<.cctor>b__39_0));

		public const int AccountIdFieldNumber = 1;

		private EntityId accountId_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public const int OptionsFieldNumber = 10;

		private GameAccountFieldOptions options_;

		public const int TagsFieldNumber = 11;

		private GameAccountFieldTags tags_;

		public static MessageParser<GetGameAccountStateRequest> Parser
		{
			get
			{
				return GetGameAccountStateRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[15];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameAccountStateRequest.Descriptor;
			}
		}

		[Obsolete]
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

		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		public GameAccountFieldOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		public GameAccountFieldTags Tags
		{
			get
			{
				return this.tags_;
			}
			set
			{
				this.tags_ = value;
			}
		}

		public GetGameAccountStateRequest()
		{
		}

		public GetGameAccountStateRequest(GetGameAccountStateRequest other) : this()
		{
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
			this.Options = ((other.options_ != null) ? other.Options.Clone() : null);
			this.Tags = ((other.tags_ != null) ? other.Tags.Clone() : null);
		}

		public GetGameAccountStateRequest Clone()
		{
			return new GetGameAccountStateRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameAccountStateRequest);
		}

		public bool Equals(GetGameAccountStateRequest other)
		{
			if (other == null)
			{
				goto IL_47;
			}
			goto IL_126;
			int arg_D8_0;
			while (true)
			{
				IL_D3:
				switch ((arg_D8_0 ^ -1289276732) % 13)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_D8_0 = (GetGameAccountStateRequest.smethod_0(this.AccountId, other.AccountId) ? -241238532 : -1014381965);
					continue;
				case 5:
					arg_D8_0 = (GetGameAccountStateRequest.smethod_0(this.GameAccountId, other.GameAccountId) ? -535136579 : -1149992538);
					continue;
				case 6:
					goto IL_126;
				case 7:
					return false;
				case 9:
					arg_D8_0 = ((!GetGameAccountStateRequest.smethod_0(this.Tags, other.Tags)) ? -1926673718 : -438886013);
					continue;
				case 10:
					goto IL_47;
				case 11:
					arg_D8_0 = (GetGameAccountStateRequest.smethod_0(this.Options, other.Options) ? -1233971579 : -1569884154);
					continue;
				case 12:
					return true;
				}
				break;
			}
			return true;
			IL_47:
			arg_D8_0 = -414878951;
			goto IL_D3;
			IL_126:
			arg_D8_0 = ((other != this) ? -518599723 : -1091596591);
			goto IL_D3;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.accountId_ != null)
			{
				goto IL_80;
			}
			goto IL_125;
			uint arg_E5_0;
			while (true)
			{
				IL_E0:
				uint num2;
				switch ((num2 = (arg_E5_0 ^ 3728158985u)) % 9u)
				{
				case 0u:
					arg_E5_0 = ((this.tags_ == null) ? 2929549678u : 2353031925u);
					continue;
				case 1u:
					num ^= GetGameAccountStateRequest.smethod_1(this.Tags);
					arg_E5_0 = (num2 * 682172404u ^ 2313048414u);
					continue;
				case 2u:
					num ^= GetGameAccountStateRequest.smethod_1(this.AccountId);
					arg_E5_0 = (num2 * 3119847847u ^ 3585186747u);
					continue;
				case 3u:
					goto IL_80;
				case 4u:
					arg_E5_0 = ((this.options_ != null) ? 2901276672u : 2665116110u);
					continue;
				case 5u:
					num ^= GetGameAccountStateRequest.smethod_1(this.Options);
					arg_E5_0 = (num2 * 3194888653u ^ 2720093435u);
					continue;
				case 7u:
					goto IL_125;
				case 8u:
					num ^= GetGameAccountStateRequest.smethod_1(this.GameAccountId);
					arg_E5_0 = (num2 * 1240348646u ^ 975448655u);
					continue;
				}
				break;
			}
			return num;
			IL_80:
			arg_E5_0 = 4275373698u;
			goto IL_E0;
			IL_125:
			arg_E5_0 = ((this.gameAccountId_ == null) ? 3134458293u : 2744219462u);
			goto IL_E0;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.accountId_ != null)
			{
				goto IL_3B;
			}
			goto IL_17D;
			uint arg_131_0;
			while (true)
			{
				IL_12C:
				uint num;
				switch ((num = (arg_131_0 ^ 3202430304u)) % 12u)
				{
				case 0u:
					arg_131_0 = ((this.options_ == null) ? 3556321899u : 3704327723u);
					continue;
				case 1u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AccountId);
					arg_131_0 = (num * 3997486349u ^ 37361455u);
					continue;
				case 2u:
					output.WriteMessage(this.Tags);
					arg_131_0 = (num * 3261207184u ^ 2710174901u);
					continue;
				case 3u:
					output.WriteRawTag(82);
					arg_131_0 = (num * 1503488437u ^ 540496743u);
					continue;
				case 4u:
					output.WriteRawTag(90);
					arg_131_0 = (num * 3429523533u ^ 2628376174u);
					continue;
				case 6u:
					goto IL_17D;
				case 7u:
					arg_131_0 = ((this.tags_ != null) ? 2441796428u : 3951713429u);
					continue;
				case 8u:
					output.WriteMessage(this.Options);
					arg_131_0 = (num * 4120306731u ^ 3939658091u);
					continue;
				case 9u:
					output.WriteRawTag(18);
					arg_131_0 = (num * 4292384758u ^ 4025415669u);
					continue;
				case 10u:
					goto IL_3B;
				case 11u:
					output.WriteMessage(this.GameAccountId);
					arg_131_0 = (num * 3835907917u ^ 2411186419u);
					continue;
				}
				break;
			}
			return;
			IL_3B:
			arg_131_0 = 3635473445u;
			goto IL_12C;
			IL_17D:
			arg_131_0 = ((this.gameAccountId_ == null) ? 2228430572u : 3688479941u);
			goto IL_12C;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_153:
				uint arg_11E_0 = 825073631u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_11E_0 ^ 1588651238u)) % 10u)
					{
					case 0u:
						goto IL_153;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_11E_0 = (num2 * 37271729u ^ 1421773230u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Tags);
						arg_11E_0 = (num2 * 2868178784u ^ 3173061262u);
						continue;
					case 3u:
						arg_11E_0 = (((this.accountId_ != null) ? 2226052894u : 3923807784u) ^ num2 * 299831548u);
						continue;
					case 4u:
						arg_11E_0 = ((this.gameAccountId_ != null) ? 1498939297u : 1129475513u);
						continue;
					case 5u:
						arg_11E_0 = ((this.tags_ == null) ? 466109966u : 2133583946u);
						continue;
					case 6u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_11E_0 = (num2 * 2912788476u ^ 1963307588u);
						continue;
					case 7u:
						arg_11E_0 = ((this.options_ == null) ? 1868762923u : 1076884673u);
						continue;
					case 9u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
						arg_11E_0 = (num2 * 537371522u ^ 1245906917u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetGameAccountStateRequest other)
		{
			if (other == null)
			{
				goto IL_A5;
			}
			goto IL_280;
			uint arg_218_0;
			while (true)
			{
				IL_213:
				uint num;
				switch ((num = (arg_218_0 ^ 3847594146u)) % 19u)
				{
				case 0u:
					arg_218_0 = (((this.tags_ != null) ? 4097310359u : 4257944052u) ^ num * 825030935u);
					continue;
				case 1u:
					arg_218_0 = (((this.accountId_ == null) ? 1563741268u : 1960999662u) ^ num * 3385394609u);
					continue;
				case 2u:
					this.Options.MergeFrom(other.Options);
					arg_218_0 = 3365649516u;
					continue;
				case 3u:
					arg_218_0 = ((other.options_ == null) ? 3365649516u : 2606077412u);
					continue;
				case 4u:
					arg_218_0 = (((this.options_ != null) ? 58819000u : 1505117387u) ^ num * 1594447087u);
					continue;
				case 5u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_218_0 = 2546782468u;
					continue;
				case 6u:
					return;
				case 7u:
					this.Tags.MergeFrom(other.Tags);
					arg_218_0 = 3460574568u;
					continue;
				case 8u:
					this.options_ = new GameAccountFieldOptions();
					arg_218_0 = (num * 3009604816u ^ 1898256530u);
					continue;
				case 9u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_218_0 = 4197057254u;
					continue;
				case 10u:
					arg_218_0 = ((other.gameAccountId_ == null) ? 4197057254u : 3966350129u);
					continue;
				case 11u:
					this.tags_ = new GameAccountFieldTags();
					arg_218_0 = (num * 1497475096u ^ 3340469232u);
					continue;
				case 12u:
					goto IL_A5;
				case 13u:
					this.gameAccountId_ = new EntityId();
					arg_218_0 = (num * 684928181u ^ 3385125078u);
					continue;
				case 15u:
					goto IL_280;
				case 16u:
					arg_218_0 = (((this.gameAccountId_ != null) ? 1802675875u : 633221731u) ^ num * 72820354u);
					continue;
				case 17u:
					arg_218_0 = ((other.tags_ != null) ? 2655315515u : 3460574568u);
					continue;
				case 18u:
					this.accountId_ = new EntityId();
					arg_218_0 = (num * 3779599780u ^ 985769119u);
					continue;
				}
				break;
			}
			return;
			IL_A5:
			arg_218_0 = 2319734412u;
			goto IL_213;
			IL_280:
			arg_218_0 = ((other.accountId_ != null) ? 3059137583u : 2546782468u);
			goto IL_213;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2D9:
				uint num;
				uint arg_261_0 = ((num = input.ReadTag()) == 0u) ? 647179442u : 196458912u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_261_0 ^ 1807758080u)) % 23u)
					{
					case 0u:
						arg_261_0 = (((num == 18u) ? 468199480u : 454290373u) ^ num2 * 737196258u);
						continue;
					case 1u:
						this.accountId_ = new EntityId();
						arg_261_0 = (num2 * 1352429530u ^ 1563910493u);
						continue;
					case 2u:
						arg_261_0 = ((this.gameAccountId_ == null) ? 1638589137u : 1218815643u);
						continue;
					case 3u:
						arg_261_0 = ((num != 82u) ? 814762745u : 759181509u);
						continue;
					case 4u:
						input.ReadMessage(this.tags_);
						arg_261_0 = 1103155923u;
						continue;
					case 5u:
						arg_261_0 = ((this.options_ == null) ? 789917887u : 362452930u);
						continue;
					case 6u:
						arg_261_0 = (num2 * 1430089411u ^ 2031060155u);
						continue;
					case 7u:
						arg_261_0 = (num2 * 42985276u ^ 3056441139u);
						continue;
					case 8u:
						this.tags_ = new GameAccountFieldTags();
						arg_261_0 = (num2 * 1205886460u ^ 230189037u);
						continue;
					case 9u:
						arg_261_0 = ((this.accountId_ != null) ? 816944953u : 1495084730u);
						continue;
					case 10u:
						arg_261_0 = ((num <= 18u) ? 2055098443u : 247931711u);
						continue;
					case 11u:
						arg_261_0 = (((num != 10u) ? 2750333011u : 2421432407u) ^ num2 * 3663109332u);
						continue;
					case 12u:
						arg_261_0 = 196458912u;
						continue;
					case 13u:
						this.gameAccountId_ = new EntityId();
						arg_261_0 = (num2 * 479169344u ^ 3808053723u);
						continue;
					case 14u:
						arg_261_0 = ((this.tags_ != null) ? 625485229u : 1708819568u);
						continue;
					case 16u:
						input.SkipLastField();
						arg_261_0 = 1103155923u;
						continue;
					case 17u:
						arg_261_0 = (((num == 90u) ? 2264125027u : 4156618492u) ^ num2 * 4199992243u);
						continue;
					case 18u:
						input.ReadMessage(this.gameAccountId_);
						arg_261_0 = 1432226424u;
						continue;
					case 19u:
						goto IL_2D9;
					case 20u:
						this.options_ = new GameAccountFieldOptions();
						arg_261_0 = (num2 * 4120379090u ^ 3297182572u);
						continue;
					case 21u:
						input.ReadMessage(this.accountId_);
						arg_261_0 = 1103155923u;
						continue;
					case 22u:
						input.ReadMessage(this.options_);
						arg_261_0 = 1103155923u;
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
