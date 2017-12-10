using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameSessionInfo : IMessage<GameSessionInfo>, IEquatable<GameSessionInfo>, IDeepCloneable<GameSessionInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameSessionInfo.__c __9 = new GameSessionInfo.__c();

			internal GameSessionInfo cctor>b__49_0()
			{
				return new GameSessionInfo();
			}
		}

		private static readonly MessageParser<GameSessionInfo> _parser = new MessageParser<GameSessionInfo>(new Func<GameSessionInfo>(GameSessionInfo.__c.__9.<.cctor>b__49_0));

		public const int StartTimeFieldNumber = 3;

		private uint startTime_;

		public const int LocationFieldNumber = 4;

		private GameSessionLocation location_;

		public const int HasBenefactorFieldNumber = 5;

		private bool hasBenefactor_;

		public const int IsUsingIgrFieldNumber = 6;

		private bool isUsingIgr_;

		public const int ParentalControlsActiveFieldNumber = 7;

		private bool parentalControlsActive_;

		public const int StartTimeSecFieldNumber = 8;

		private ulong startTimeSec_;

		public static MessageParser<GameSessionInfo> Parser
		{
			get
			{
				return GameSessionInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[26];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSessionInfo.Descriptor;
			}
		}

		[Obsolete]
		public uint StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		public GameSessionLocation Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		public bool HasBenefactor
		{
			get
			{
				return this.hasBenefactor_;
			}
			set
			{
				this.hasBenefactor_ = value;
			}
		}

		public bool IsUsingIgr
		{
			get
			{
				return this.isUsingIgr_;
			}
			set
			{
				this.isUsingIgr_ = value;
			}
		}

		public bool ParentalControlsActive
		{
			get
			{
				return this.parentalControlsActive_;
			}
			set
			{
				this.parentalControlsActive_ = value;
			}
		}

		public ulong StartTimeSec
		{
			get
			{
				return this.startTimeSec_;
			}
			set
			{
				this.startTimeSec_ = value;
			}
		}

		public GameSessionInfo()
		{
		}

		public GameSessionInfo(GameSessionInfo other) : this()
		{
			while (true)
			{
				IL_D1:
				uint arg_A9_0 = 2466125595u;
				while (true)
				{
					uint num;
					switch ((num = (arg_A9_0 ^ 2256340435u)) % 7u)
					{
					case 0u:
						this.Location = ((other.location_ != null) ? other.Location.Clone() : null);
						arg_A9_0 = 3207309205u;
						continue;
					case 1u:
						this.startTime_ = other.startTime_;
						arg_A9_0 = (num * 751576854u ^ 2949448514u);
						continue;
					case 2u:
						this.hasBenefactor_ = other.hasBenefactor_;
						arg_A9_0 = (num * 2254480915u ^ 659429534u);
						continue;
					case 3u:
						goto IL_D1;
					case 4u:
						this.parentalControlsActive_ = other.parentalControlsActive_;
						this.startTimeSec_ = other.startTimeSec_;
						arg_A9_0 = (num * 2969300772u ^ 83680636u);
						continue;
					case 6u:
						this.isUsingIgr_ = other.isUsingIgr_;
						arg_A9_0 = (num * 862522026u ^ 3976954002u);
						continue;
					}
					return;
				}
			}
		}

		public GameSessionInfo Clone()
		{
			return new GameSessionInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameSessionInfo);
		}

		public bool Equals(GameSessionInfo other)
		{
			if (other == null)
			{
				goto IL_C2;
			}
			goto IL_178;
			int arg_11A_0;
			while (true)
			{
				IL_115:
				switch ((arg_11A_0 ^ -881759902) % 17)
				{
				case 0:
					return false;
				case 1:
					arg_11A_0 = ((this.StartTimeSec != other.StartTimeSec) ? -1924195991 : -1411981080);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_11A_0 = ((this.ParentalControlsActive == other.ParentalControlsActive) ? -1831971842 : -648776736);
					continue;
				case 5:
					goto IL_C2;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					arg_11A_0 = ((this.IsUsingIgr == other.IsUsingIgr) ? -847152965 : -2119108665);
					continue;
				case 9:
					goto IL_178;
				case 10:
					return false;
				case 12:
					return false;
				case 13:
					return true;
				case 14:
					arg_11A_0 = ((this.StartTime == other.StartTime) ? -1424480500 : -666611259);
					continue;
				case 15:
					arg_11A_0 = (GameSessionInfo.smethod_0(this.Location, other.Location) ? -1105559243 : -1493566709);
					continue;
				case 16:
					arg_11A_0 = ((this.HasBenefactor != other.HasBenefactor) ? -1498592535 : -233535686);
					continue;
				}
				break;
			}
			return true;
			IL_C2:
			arg_11A_0 = -65926048;
			goto IL_115;
			IL_178:
			arg_11A_0 = ((other != this) ? -472125137 : -1912136655);
			goto IL_115;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.StartTime != 0u)
			{
				goto IL_15A;
			}
			goto IL_1D6;
			uint arg_185_0;
			while (true)
			{
				IL_180:
				uint num2;
				switch ((num2 = (arg_185_0 ^ 2077524348u)) % 13u)
				{
				case 0u:
					arg_185_0 = (this.ParentalControlsActive ? 526798160u : 478303397u);
					continue;
				case 1u:
					goto IL_1D6;
				case 3u:
					goto IL_15A;
				case 4u:
					arg_185_0 = (this.IsUsingIgr ? 901651707u : 2089751454u);
					continue;
				case 5u:
					num ^= this.ParentalControlsActive.GetHashCode();
					arg_185_0 = (num2 * 75185912u ^ 3209569797u);
					continue;
				case 6u:
					num ^= this.StartTimeSec.GetHashCode();
					arg_185_0 = (num2 * 3316906704u ^ 1529123188u);
					continue;
				case 7u:
					num ^= this.IsUsingIgr.GetHashCode();
					arg_185_0 = (num2 * 2171780115u ^ 909756059u);
					continue;
				case 8u:
					num ^= this.Location.GetHashCode();
					arg_185_0 = (num2 * 3662210957u ^ 3050357849u);
					continue;
				case 9u:
					num ^= this.StartTime.GetHashCode();
					arg_185_0 = (num2 * 2773441531u ^ 1159740793u);
					continue;
				case 10u:
					arg_185_0 = (this.HasBenefactor ? 348721731u : 306583131u);
					continue;
				case 11u:
					num ^= this.HasBenefactor.GetHashCode();
					arg_185_0 = (num2 * 3490595513u ^ 998355164u);
					continue;
				case 12u:
					arg_185_0 = ((this.StartTimeSec == 0uL) ? 2092041700u : 167187185u);
					continue;
				}
				break;
			}
			return num;
			IL_15A:
			arg_185_0 = 224462535u;
			goto IL_180;
			IL_1D6:
			arg_185_0 = ((this.location_ != null) ? 2057830158u : 303384211u);
			goto IL_180;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.StartTime != 0u)
			{
				goto IL_195;
			}
			goto IL_237;
			uint arg_1D7_0;
			while (true)
			{
				IL_1D2:
				uint num;
				switch ((num = (arg_1D7_0 ^ 2545468575u)) % 17u)
				{
				case 1u:
					output.WriteRawTag(48);
					arg_1D7_0 = (num * 1711086609u ^ 904847255u);
					continue;
				case 2u:
					arg_1D7_0 = ((!this.IsUsingIgr) ? 2158444164u : 3160019014u);
					continue;
				case 3u:
					goto IL_195;
				case 4u:
					output.WriteRawTag(56);
					output.WriteBool(this.ParentalControlsActive);
					arg_1D7_0 = (num * 833830620u ^ 3845757580u);
					continue;
				case 5u:
					output.WriteBool(this.HasBenefactor);
					arg_1D7_0 = (num * 3727423305u ^ 3409686278u);
					continue;
				case 6u:
					arg_1D7_0 = ((this.StartTimeSec == 0uL) ? 4054988565u : 3673362188u);
					continue;
				case 7u:
					output.WriteBool(this.IsUsingIgr);
					arg_1D7_0 = (num * 327577756u ^ 282560920u);
					continue;
				case 8u:
					arg_1D7_0 = ((!this.ParentalControlsActive) ? 2326364716u : 2453741447u);
					continue;
				case 9u:
					output.WriteRawTag(64);
					arg_1D7_0 = (num * 364958602u ^ 2054366896u);
					continue;
				case 10u:
					output.WriteRawTag(24);
					output.WriteUInt32(this.StartTime);
					arg_1D7_0 = (num * 435244820u ^ 2904108204u);
					continue;
				case 11u:
					arg_1D7_0 = (this.HasBenefactor ? 3996731400u : 3188045803u);
					continue;
				case 12u:
					output.WriteUInt64(this.StartTimeSec);
					arg_1D7_0 = (num * 4186789296u ^ 3974842277u);
					continue;
				case 13u:
					goto IL_237;
				case 14u:
					output.WriteRawTag(40);
					arg_1D7_0 = (num * 1430210595u ^ 1304483007u);
					continue;
				case 15u:
					output.WriteRawTag(34);
					arg_1D7_0 = (num * 426153255u ^ 3019981962u);
					continue;
				case 16u:
					output.WriteMessage(this.Location);
					arg_1D7_0 = (num * 3038145145u ^ 2759452002u);
					continue;
				}
				break;
			}
			return;
			IL_195:
			arg_1D7_0 = 3908530560u;
			goto IL_1D2;
			IL_237:
			arg_1D7_0 = ((this.location_ == null) ? 4095389818u : 3364794228u);
			goto IL_1D2;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.StartTime != 0u)
			{
				goto IL_89;
			}
			goto IL_1A2;
			uint arg_152_0;
			while (true)
			{
				IL_14D:
				uint num2;
				switch ((num2 = (arg_152_0 ^ 4074447919u)) % 13u)
				{
				case 0u:
					num += 2;
					arg_152_0 = (num2 * 4288360532u ^ 2554675765u);
					continue;
				case 1u:
					goto IL_1A2;
				case 2u:
					arg_152_0 = ((!this.ParentalControlsActive) ? 3668875617u : 3877456878u);
					continue;
				case 4u:
					num += 2;
					arg_152_0 = (num2 * 3929447783u ^ 3820533381u);
					continue;
				case 5u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
					arg_152_0 = (num2 * 1672690303u ^ 772324653u);
					continue;
				case 6u:
					num += 2;
					arg_152_0 = (num2 * 2836787885u ^ 3867388207u);
					continue;
				case 7u:
					arg_152_0 = ((!this.HasBenefactor) ? 2766230351u : 2180754383u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartTimeSec);
					arg_152_0 = (num2 * 1312749062u ^ 2305594532u);
					continue;
				case 9u:
					goto IL_89;
				case 10u:
					arg_152_0 = (this.IsUsingIgr ? 2382441205u : 3211468083u);
					continue;
				case 11u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.StartTime);
					arg_152_0 = (num2 * 405046287u ^ 2707719797u);
					continue;
				case 12u:
					arg_152_0 = ((this.StartTimeSec == 0uL) ? 3313935936u : 3608393993u);
					continue;
				}
				break;
			}
			return num;
			IL_89:
			arg_152_0 = 2673973251u;
			goto IL_14D;
			IL_1A2:
			arg_152_0 = ((this.location_ != null) ? 4238284972u : 2887782352u);
			goto IL_14D;
		}

		public void MergeFrom(GameSessionInfo other)
		{
			if (other == null)
			{
				goto IL_C8;
			}
			goto IL_227;
			uint arg_1C7_0;
			while (true)
			{
				IL_1C2:
				uint num;
				switch ((num = (arg_1C7_0 ^ 2478443145u)) % 17u)
				{
				case 0u:
					arg_1C7_0 = (other.HasBenefactor ? 3129099187u : 2454844683u);
					continue;
				case 1u:
					goto IL_227;
				case 2u:
					this.StartTimeSec = other.StartTimeSec;
					arg_1C7_0 = (num * 3248737853u ^ 432147070u);
					continue;
				case 3u:
					arg_1C7_0 = ((other.StartTimeSec == 0uL) ? 3377658018u : 3189170821u);
					continue;
				case 4u:
					this.location_ = new GameSessionLocation();
					arg_1C7_0 = (num * 3202527743u ^ 3361131669u);
					continue;
				case 5u:
					return;
				case 6u:
					this.ParentalControlsActive = other.ParentalControlsActive;
					arg_1C7_0 = (num * 1377661240u ^ 599237339u);
					continue;
				case 7u:
					this.HasBenefactor = other.HasBenefactor;
					arg_1C7_0 = (num * 2584353663u ^ 2964882637u);
					continue;
				case 8u:
					this.StartTime = other.StartTime;
					arg_1C7_0 = (num * 2876987004u ^ 2312841249u);
					continue;
				case 9u:
					arg_1C7_0 = ((!other.IsUsingIgr) ? 3096597887u : 2524885574u);
					continue;
				case 10u:
					goto IL_C8;
				case 11u:
					this.Location.MergeFrom(other.Location);
					arg_1C7_0 = 2408391789u;
					continue;
				case 13u:
					arg_1C7_0 = ((other.location_ != null) ? 3197541954u : 2408391789u);
					continue;
				case 14u:
					this.IsUsingIgr = other.IsUsingIgr;
					arg_1C7_0 = (num * 2430292147u ^ 3018898882u);
					continue;
				case 15u:
					arg_1C7_0 = (((this.location_ != null) ? 814264011u : 1217490735u) ^ num * 2481307998u);
					continue;
				case 16u:
					arg_1C7_0 = ((!other.ParentalControlsActive) ? 2829763379u : 2443329138u);
					continue;
				}
				break;
			}
			return;
			IL_C8:
			arg_1C7_0 = 4214642525u;
			goto IL_1C2;
			IL_227:
			arg_1C7_0 = ((other.StartTime != 0u) ? 3225533561u : 4218033249u);
			goto IL_1C2;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_2C8:
				uint num;
				uint arg_24C_0 = ((num = input.ReadTag()) != 0u) ? 2348574651u : 2508065388u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_24C_0 ^ 3446334145u)) % 24u)
					{
					case 0u:
						arg_24C_0 = 2348574651u;
						continue;
					case 1u:
						arg_24C_0 = (num2 * 1307209329u ^ 1787694676u);
						continue;
					case 2u:
						input.ReadMessage(this.location_);
						arg_24C_0 = 3563601434u;
						continue;
					case 3u:
						arg_24C_0 = ((num == 48u) ? 2913512536u : 4112710726u);
						continue;
					case 4u:
						arg_24C_0 = ((this.location_ != null) ? 2793791091u : 2162992121u);
						continue;
					case 5u:
						arg_24C_0 = (num2 * 1673357506u ^ 1414583619u);
						continue;
					case 6u:
						arg_24C_0 = (num2 * 1698109597u ^ 148167027u);
						continue;
					case 7u:
						arg_24C_0 = (((num != 40u) ? 2571002761u : 2355584816u) ^ num2 * 3417564307u);
						continue;
					case 8u:
						this.location_ = new GameSessionLocation();
						arg_24C_0 = (num2 * 1489011032u ^ 3515252019u);
						continue;
					case 9u:
						arg_24C_0 = (((num != 24u) ? 295738606u : 984138907u) ^ num2 * 822642700u);
						continue;
					case 10u:
						arg_24C_0 = ((num <= 40u) ? 2230334016u : 2924408690u);
						continue;
					case 11u:
						arg_24C_0 = (((num == 34u) ? 4177981163u : 2361545672u) ^ num2 * 1703345770u);
						continue;
					case 12u:
						this.HasBenefactor = input.ReadBool();
						arg_24C_0 = 3977733200u;
						continue;
					case 13u:
						arg_24C_0 = (num2 * 917512504u ^ 3278835149u);
						continue;
					case 14u:
						this.StartTime = input.ReadUInt32();
						arg_24C_0 = 2387262037u;
						continue;
					case 15u:
						this.StartTimeSec = input.ReadUInt64();
						arg_24C_0 = 2387262037u;
						continue;
					case 16u:
						input.SkipLastField();
						arg_24C_0 = 2934790292u;
						continue;
					case 17u:
						this.IsUsingIgr = input.ReadBool();
						arg_24C_0 = 3784516895u;
						continue;
					case 18u:
						arg_24C_0 = (((num == 64u) ? 1531667984u : 884133415u) ^ num2 * 2993297395u);
						continue;
					case 19u:
						arg_24C_0 = (num2 * 28707751u ^ 3242705288u);
						continue;
					case 20u:
						goto IL_2C8;
					case 22u:
						this.ParentalControlsActive = input.ReadBool();
						arg_24C_0 = 2387262037u;
						continue;
					case 23u:
						arg_24C_0 = (((num == 56u) ? 272402413u : 101972041u) ^ num2 * 1192989838u);
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
	}
}
