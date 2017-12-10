using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountFieldOptions : IMessage<GameAccountFieldOptions>, IEquatable<GameAccountFieldOptions>, IDeepCloneable<GameAccountFieldOptions>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountFieldOptions.__c __9 = new GameAccountFieldOptions.__c();

			internal GameAccountFieldOptions cctor>b__44_0()
			{
				return new GameAccountFieldOptions();
			}
		}

		private static readonly MessageParser<GameAccountFieldOptions> _parser = new MessageParser<GameAccountFieldOptions>(new Func<GameAccountFieldOptions>(GameAccountFieldOptions.__c.__9.<.cctor>b__44_0));

		public const int AllFieldsFieldNumber = 1;

		private bool allFields_;

		public const int FieldGameLevelInfoFieldNumber = 2;

		private bool fieldGameLevelInfo_;

		public const int FieldGameTimeInfoFieldNumber = 3;

		private bool fieldGameTimeInfo_;

		public const int FieldGameStatusFieldNumber = 4;

		private bool fieldGameStatus_;

		public const int FieldRafInfoFieldNumber = 5;

		private bool fieldRafInfo_;

		public static MessageParser<GameAccountFieldOptions> Parser
		{
			get
			{
				return GameAccountFieldOptions._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[16];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountFieldOptions.Descriptor;
			}
		}

		public bool AllFields
		{
			get
			{
				return this.allFields_;
			}
			set
			{
				this.allFields_ = value;
			}
		}

		public bool FieldGameLevelInfo
		{
			get
			{
				return this.fieldGameLevelInfo_;
			}
			set
			{
				this.fieldGameLevelInfo_ = value;
			}
		}

		public bool FieldGameTimeInfo
		{
			get
			{
				return this.fieldGameTimeInfo_;
			}
			set
			{
				this.fieldGameTimeInfo_ = value;
			}
		}

		public bool FieldGameStatus
		{
			get
			{
				return this.fieldGameStatus_;
			}
			set
			{
				this.fieldGameStatus_ = value;
			}
		}

		public bool FieldRafInfo
		{
			get
			{
				return this.fieldRafInfo_;
			}
			set
			{
				this.fieldRafInfo_ = value;
			}
		}

		public GameAccountFieldOptions()
		{
		}

		public GameAccountFieldOptions(GameAccountFieldOptions other) : this()
		{
			while (true)
			{
				IL_75:
				uint arg_59_0 = 3904285803u;
				while (true)
				{
					uint num;
					switch ((num = (arg_59_0 ^ 4190169394u)) % 4u)
					{
					case 0u:
						this.fieldGameLevelInfo_ = other.fieldGameLevelInfo_;
						this.fieldGameTimeInfo_ = other.fieldGameTimeInfo_;
						this.fieldGameStatus_ = other.fieldGameStatus_;
						arg_59_0 = (num * 3637457542u ^ 936607977u);
						continue;
					case 1u:
						this.allFields_ = other.allFields_;
						arg_59_0 = (num * 3164237577u ^ 1337552515u);
						continue;
					case 2u:
						goto IL_75;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.fieldRafInfo_ = other.fieldRafInfo_;
		}

		public GameAccountFieldOptions Clone()
		{
			return new GameAccountFieldOptions(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountFieldOptions);
		}

		public bool Equals(GameAccountFieldOptions other)
		{
			if (other == null)
			{
				goto IL_93;
			}
			goto IL_141;
			int arg_EB_0;
			while (true)
			{
				IL_E6:
				switch ((arg_EB_0 ^ -1912299886) % 15)
				{
				case 0:
					return false;
				case 1:
					arg_EB_0 = ((this.FieldGameStatus != other.FieldGameStatus) ? -61864194 : -2028051094);
					continue;
				case 2:
					arg_EB_0 = ((this.FieldGameLevelInfo == other.FieldGameLevelInfo) ? -995940015 : -1161243802);
					continue;
				case 3:
					goto IL_93;
				case 4:
					arg_EB_0 = ((this.FieldGameTimeInfo != other.FieldGameTimeInfo) ? -1911197514 : -1017819570);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					arg_EB_0 = ((this.FieldRafInfo != other.FieldRafInfo) ? -1041299901 : -1664507645);
					continue;
				case 10:
					return false;
				case 12:
					arg_EB_0 = ((this.AllFields == other.AllFields) ? -947360478 : -2158724);
					continue;
				case 13:
					goto IL_141;
				case 14:
					return true;
				}
				break;
			}
			return true;
			IL_93:
			arg_EB_0 = -1225373837;
			goto IL_E6;
			IL_141:
			arg_EB_0 = ((other != this) ? -1991681891 : -621879240);
			goto IL_E6;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_1A6:
				uint arg_169_0 = 2929957589u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_169_0 ^ 2716006456u)) % 12u)
					{
					case 0u:
						num ^= this.FieldRafInfo.GetHashCode();
						arg_169_0 = (num2 * 1807058915u ^ 3522538615u);
						continue;
					case 1u:
						arg_169_0 = (((!this.AllFields) ? 2023232668u : 1544234242u) ^ num2 * 2757837018u);
						continue;
					case 2u:
						num ^= this.FieldGameLevelInfo.GetHashCode();
						arg_169_0 = (num2 * 3526971120u ^ 2244546223u);
						continue;
					case 3u:
						arg_169_0 = ((!this.FieldGameStatus) ? 2292821561u : 3020221724u);
						continue;
					case 4u:
						num ^= this.AllFields.GetHashCode();
						arg_169_0 = (num2 * 3186402066u ^ 2846056734u);
						continue;
					case 5u:
						arg_169_0 = (this.FieldRafInfo ? 3116161360u : 2221464399u);
						continue;
					case 6u:
						goto IL_1A6;
					case 7u:
						arg_169_0 = ((!this.FieldGameTimeInfo) ? 3186265595u : 3505474525u);
						continue;
					case 8u:
						num ^= this.FieldGameStatus.GetHashCode();
						arg_169_0 = (num2 * 739556763u ^ 2115227381u);
						continue;
					case 9u:
						num ^= this.FieldGameTimeInfo.GetHashCode();
						arg_169_0 = (num2 * 1986520250u ^ 507585945u);
						continue;
					case 10u:
						arg_169_0 = (this.FieldGameLevelInfo ? 2814631738u : 2845844303u);
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
			if (this.AllFields)
			{
				goto IL_161;
			}
			goto IL_1BB;
			uint arg_16B_0;
			while (true)
			{
				IL_166:
				uint num;
				switch ((num = (arg_16B_0 ^ 768326284u)) % 13u)
				{
				case 0u:
					goto IL_161;
				case 1u:
					arg_16B_0 = (this.FieldGameTimeInfo ? 1431796129u : 1804791325u);
					continue;
				case 2u:
					arg_16B_0 = (this.FieldRafInfo ? 432802945u : 1972059978u);
					continue;
				case 3u:
					arg_16B_0 = ((!this.FieldGameStatus) ? 492918527u : 726769156u);
					continue;
				case 4u:
					output.WriteBool(this.FieldGameLevelInfo);
					arg_16B_0 = (num * 319336391u ^ 3104763588u);
					continue;
				case 5u:
					output.WriteRawTag(32);
					output.WriteBool(this.FieldGameStatus);
					arg_16B_0 = (num * 4127560875u ^ 4057747495u);
					continue;
				case 6u:
					output.WriteRawTag(8);
					output.WriteBool(this.AllFields);
					arg_16B_0 = (num * 2197544760u ^ 1151921920u);
					continue;
				case 7u:
					output.WriteRawTag(16);
					arg_16B_0 = (num * 2581565360u ^ 2470230612u);
					continue;
				case 8u:
					output.WriteRawTag(40);
					output.WriteBool(this.FieldRafInfo);
					arg_16B_0 = (num * 2700471457u ^ 1519732071u);
					continue;
				case 9u:
					output.WriteRawTag(24);
					arg_16B_0 = (num * 733387183u ^ 1015806409u);
					continue;
				case 10u:
					output.WriteBool(this.FieldGameTimeInfo);
					arg_16B_0 = (num * 3274871479u ^ 2226491095u);
					continue;
				case 12u:
					goto IL_1BB;
				}
				break;
			}
			return;
			IL_161:
			arg_16B_0 = 1362941348u;
			goto IL_166;
			IL_1BB:
			arg_16B_0 = (this.FieldGameLevelInfo ? 919024471u : 24609340u);
			goto IL_166;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.AllFields)
			{
				goto IL_1F;
			}
			goto IL_13C;
			uint arg_F4_0;
			while (true)
			{
				IL_EF:
				uint num2;
				switch ((num2 = (arg_F4_0 ^ 4205897665u)) % 11u)
				{
				case 0u:
					arg_F4_0 = ((!this.FieldGameStatus) ? 2979264677u : 3043936040u);
					continue;
				case 1u:
					goto IL_13C;
				case 2u:
					num += 2;
					arg_F4_0 = (num2 * 2105455401u ^ 3297090261u);
					continue;
				case 3u:
					arg_F4_0 = ((!this.FieldRafInfo) ? 3810452673u : 3694964841u);
					continue;
				case 4u:
					num += 2;
					arg_F4_0 = (num2 * 3930603953u ^ 1134374377u);
					continue;
				case 5u:
					num += 2;
					arg_F4_0 = (num2 * 3443409601u ^ 3119716620u);
					continue;
				case 7u:
					arg_F4_0 = (this.FieldGameTimeInfo ? 3198161031u : 2206550573u);
					continue;
				case 8u:
					num += 2;
					arg_F4_0 = (num2 * 999954021u ^ 2978535603u);
					continue;
				case 9u:
					num += 2;
					arg_F4_0 = (num2 * 1106558024u ^ 4175881089u);
					continue;
				case 10u:
					goto IL_1F;
				}
				break;
			}
			return num;
			IL_1F:
			arg_F4_0 = 4100285184u;
			goto IL_EF;
			IL_13C:
			arg_F4_0 = ((!this.FieldGameLevelInfo) ? 3640711947u : 3481988163u);
			goto IL_EF;
		}

		public void MergeFrom(GameAccountFieldOptions other)
		{
			if (other == null)
			{
				goto IL_E1;
			}
			goto IL_18C;
			uint arg_13C_0;
			while (true)
			{
				IL_137:
				uint num;
				switch ((num = (arg_13C_0 ^ 1341785072u)) % 13u)
				{
				case 0u:
					this.FieldRafInfo = other.FieldRafInfo;
					arg_13C_0 = (num * 1667212998u ^ 2844134137u);
					continue;
				case 1u:
					this.AllFields = other.AllFields;
					arg_13C_0 = (num * 3776997741u ^ 578204068u);
					continue;
				case 2u:
					this.FieldGameTimeInfo = other.FieldGameTimeInfo;
					arg_13C_0 = (num * 3252739106u ^ 428792486u);
					continue;
				case 3u:
					return;
				case 4u:
					goto IL_E1;
				case 6u:
					this.FieldGameLevelInfo = other.FieldGameLevelInfo;
					arg_13C_0 = (num * 2666669854u ^ 3196271171u);
					continue;
				case 7u:
					arg_13C_0 = (other.FieldGameStatus ? 1182244206u : 1774513244u);
					continue;
				case 8u:
					goto IL_18C;
				case 9u:
					arg_13C_0 = ((!other.FieldGameLevelInfo) ? 571147813u : 1637821165u);
					continue;
				case 10u:
					this.FieldGameStatus = other.FieldGameStatus;
					arg_13C_0 = (num * 4010449675u ^ 3046086294u);
					continue;
				case 11u:
					arg_13C_0 = (other.FieldGameTimeInfo ? 662051285u : 402497100u);
					continue;
				case 12u:
					arg_13C_0 = (other.FieldRafInfo ? 435569072u : 2142680953u);
					continue;
				}
				break;
			}
			return;
			IL_E1:
			arg_13C_0 = 282458111u;
			goto IL_137;
			IL_18C:
			arg_13C_0 = (other.AllFields ? 1840234999u : 277793375u);
			goto IL_137;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_227:
				uint num;
				uint arg_1BF_0 = ((num = input.ReadTag()) == 0u) ? 2688741484u : 3179296000u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1BF_0 ^ 4208370289u)) % 19u)
					{
					case 0u:
						arg_1BF_0 = (((num == 32u) ? 4027907946u : 2851179153u) ^ num2 * 3231878226u);
						continue;
					case 1u:
						arg_1BF_0 = ((num == 24u) ? 3512089590u : 2421918883u);
						continue;
					case 2u:
						this.FieldGameTimeInfo = input.ReadBool();
						arg_1BF_0 = 3228861468u;
						continue;
					case 3u:
						arg_1BF_0 = (((num != 16u) ? 214184092u : 1459194655u) ^ num2 * 2083810325u);
						continue;
					case 4u:
						this.FieldGameStatus = input.ReadBool();
						arg_1BF_0 = 4272189361u;
						continue;
					case 5u:
						arg_1BF_0 = ((num <= 16u) ? 2962275318u : 4068959392u);
						continue;
					case 6u:
						arg_1BF_0 = (num2 * 3580467876u ^ 3168447646u);
						continue;
					case 7u:
						this.AllFields = input.ReadBool();
						arg_1BF_0 = 3228861468u;
						continue;
					case 8u:
						arg_1BF_0 = 3179296000u;
						continue;
					case 10u:
						this.FieldRafInfo = input.ReadBool();
						arg_1BF_0 = 3228861468u;
						continue;
					case 11u:
						arg_1BF_0 = (((num == 40u) ? 602466759u : 1559370102u) ^ num2 * 2895268378u);
						continue;
					case 12u:
						arg_1BF_0 = (((num == 8u) ? 1568275512u : 2145505232u) ^ num2 * 1513703192u);
						continue;
					case 13u:
						arg_1BF_0 = (num2 * 3347123473u ^ 3450269148u);
						continue;
					case 14u:
						goto IL_227;
					case 15u:
						arg_1BF_0 = (num2 * 2934932377u ^ 2402165224u);
						continue;
					case 16u:
						input.SkipLastField();
						arg_1BF_0 = 2370469008u;
						continue;
					case 17u:
						arg_1BF_0 = (num2 * 2091408256u ^ 287698844u);
						continue;
					case 18u:
						this.FieldGameLevelInfo = input.ReadBool();
						arg_1BF_0 = 3029642341u;
						continue;
					}
					return;
				}
			}
		}
	}
}
