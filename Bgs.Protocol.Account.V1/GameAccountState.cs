using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountState : IMessage<GameAccountState>, IEquatable<GameAccountState>, IDeepCloneable<GameAccountState>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountState.__c __9 = new GameAccountState.__c();

			internal GameAccountState cctor>b__39_0()
			{
				return new GameAccountState();
			}
		}

		private static readonly MessageParser<GameAccountState> _parser = new MessageParser<GameAccountState>(new Func<GameAccountState>(GameAccountState.__c.__9.<.cctor>b__39_0));

		public const int GameLevelInfoFieldNumber = 1;

		private GameLevelInfo gameLevelInfo_;

		public const int GameTimeInfoFieldNumber = 2;

		private GameTimeInfo gameTimeInfo_;

		public const int GameStatusFieldNumber = 3;

		private GameStatus gameStatus_;

		public const int RafInfoFieldNumber = 4;

		private RAFInfo rafInfo_;

		public static MessageParser<GameAccountState> Parser
		{
			get
			{
				return GameAccountState._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[33];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountState.Descriptor;
			}
		}

		public GameLevelInfo GameLevelInfo
		{
			get
			{
				return this.gameLevelInfo_;
			}
			set
			{
				this.gameLevelInfo_ = value;
			}
		}

		public GameTimeInfo GameTimeInfo
		{
			get
			{
				return this.gameTimeInfo_;
			}
			set
			{
				this.gameTimeInfo_ = value;
			}
		}

		public GameStatus GameStatus
		{
			get
			{
				return this.gameStatus_;
			}
			set
			{
				this.gameStatus_ = value;
			}
		}

		public RAFInfo RafInfo
		{
			get
			{
				return this.rafInfo_;
			}
			set
			{
				this.rafInfo_ = value;
			}
		}

		public GameAccountState()
		{
		}

		public GameAccountState(GameAccountState other) : this()
		{
			this.GameLevelInfo = ((other.gameLevelInfo_ != null) ? other.GameLevelInfo.Clone() : null);
			this.GameTimeInfo = ((other.gameTimeInfo_ != null) ? other.GameTimeInfo.Clone() : null);
			this.GameStatus = ((other.gameStatus_ != null) ? other.GameStatus.Clone() : null);
			this.RafInfo = ((other.rafInfo_ != null) ? other.RafInfo.Clone() : null);
		}

		public GameAccountState Clone()
		{
			return new GameAccountState(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountState);
		}

		public bool Equals(GameAccountState other)
		{
			if (other == null)
			{
				goto IL_A2;
			}
			goto IL_126;
			int arg_D8_0;
			while (true)
			{
				IL_D3:
				switch ((arg_D8_0 ^ -1572710099) % 13)
				{
				case 0:
					return false;
				case 1:
					arg_D8_0 = (GameAccountState.smethod_0(this.GameLevelInfo, other.GameLevelInfo) ? -1519123125 : -683220339);
					continue;
				case 2:
					goto IL_A2;
				case 4:
					return false;
				case 5:
					goto IL_126;
				case 6:
					return true;
				case 7:
					arg_D8_0 = ((!GameAccountState.smethod_0(this.GameTimeInfo, other.GameTimeInfo)) ? -2144244611 : -609570970);
					continue;
				case 8:
					arg_D8_0 = (GameAccountState.smethod_0(this.RafInfo, other.RafInfo) ? -1932932102 : -1151931931);
					continue;
				case 9:
					return false;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					arg_D8_0 = (GameAccountState.smethod_0(this.GameStatus, other.GameStatus) ? -1272933169 : -1718792234);
					continue;
				}
				break;
			}
			return true;
			IL_A2:
			arg_D8_0 = -747280812;
			goto IL_D3;
			IL_126:
			arg_D8_0 = ((other == this) ? -1283042865 : -914504868);
			goto IL_D3;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_148:
				uint arg_113_0 = 3841263962u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_113_0 ^ 3105275610u)) % 10u)
					{
					case 0u:
						goto IL_148;
					case 1u:
						num ^= GameAccountState.smethod_1(this.GameStatus);
						arg_113_0 = (num2 * 4041437204u ^ 2181290110u);
						continue;
					case 2u:
						num ^= GameAccountState.smethod_1(this.GameTimeInfo);
						arg_113_0 = (num2 * 3717433519u ^ 3693984748u);
						continue;
					case 3u:
						num ^= GameAccountState.smethod_1(this.GameLevelInfo);
						arg_113_0 = (num2 * 3754971442u ^ 1718227095u);
						continue;
					case 4u:
						arg_113_0 = ((this.rafInfo_ != null) ? 4015163497u : 3511020153u);
						continue;
					case 5u:
						arg_113_0 = ((this.gameTimeInfo_ == null) ? 3272164300u : 2642734906u);
						continue;
					case 6u:
						arg_113_0 = (((this.gameLevelInfo_ != null) ? 4101182195u : 2173295893u) ^ num2 * 3115759549u);
						continue;
					case 7u:
						num ^= GameAccountState.smethod_1(this.RafInfo);
						arg_113_0 = (num2 * 4198133322u ^ 2692961223u);
						continue;
					case 8u:
						arg_113_0 = ((this.gameStatus_ == null) ? 2695562730u : 2258277691u);
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
			if (this.gameLevelInfo_ != null)
			{
				goto IL_83;
			}
			goto IL_151;
			uint arg_10D_0;
			while (true)
			{
				IL_108:
				uint num;
				switch ((num = (arg_10D_0 ^ 1337407862u)) % 10u)
				{
				case 1u:
					output.WriteRawTag(34);
					arg_10D_0 = (num * 1036537657u ^ 1920939593u);
					continue;
				case 2u:
					output.WriteRawTag(26);
					output.WriteMessage(this.GameStatus);
					arg_10D_0 = (num * 1535388388u ^ 3142120888u);
					continue;
				case 3u:
					output.WriteRawTag(10);
					output.WriteMessage(this.GameLevelInfo);
					arg_10D_0 = (num * 1366617722u ^ 244646531u);
					continue;
				case 4u:
					output.WriteRawTag(18);
					output.WriteMessage(this.GameTimeInfo);
					arg_10D_0 = (num * 3324831639u ^ 2292164009u);
					continue;
				case 5u:
					goto IL_83;
				case 6u:
					output.WriteMessage(this.RafInfo);
					arg_10D_0 = (num * 1238778651u ^ 1629696968u);
					continue;
				case 7u:
					arg_10D_0 = ((this.gameStatus_ != null) ? 767215498u : 359957960u);
					continue;
				case 8u:
					arg_10D_0 = ((this.rafInfo_ == null) ? 195253500u : 1827077773u);
					continue;
				case 9u:
					goto IL_151;
				}
				break;
			}
			return;
			IL_83:
			arg_10D_0 = 278033923u;
			goto IL_108;
			IL_151:
			arg_10D_0 = ((this.gameTimeInfo_ == null) ? 810549049u : 1952805510u);
			goto IL_108;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.gameLevelInfo_ != null)
			{
				goto IL_84;
			}
			goto IL_12D;
			uint arg_ED_0;
			while (true)
			{
				IL_E8:
				uint num2;
				switch ((num2 = (arg_ED_0 ^ 1470342961u)) % 9u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameTimeInfo);
					arg_ED_0 = (num2 * 1615698883u ^ 3763096981u);
					continue;
				case 1u:
					arg_ED_0 = ((this.gameStatus_ == null) ? 2047099440u : 1392139316u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.RafInfo);
					arg_ED_0 = (num2 * 4121633079u ^ 3928964509u);
					continue;
				case 3u:
					goto IL_84;
				case 5u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameLevelInfo);
					arg_ED_0 = (num2 * 212920181u ^ 761746893u);
					continue;
				case 6u:
					goto IL_12D;
				case 7u:
					arg_ED_0 = ((this.rafInfo_ != null) ? 1887399561u : 913781525u);
					continue;
				case 8u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameStatus);
					arg_ED_0 = (num2 * 2813915396u ^ 55304996u);
					continue;
				}
				break;
			}
			return num;
			IL_84:
			arg_ED_0 = 1687557280u;
			goto IL_E8;
			IL_12D:
			arg_ED_0 = ((this.gameTimeInfo_ == null) ? 355880001u : 1208859309u);
			goto IL_E8;
		}

		public void MergeFrom(GameAccountState other)
		{
			if (other == null)
			{
				goto IL_3C;
			}
			goto IL_27D;
			uint arg_215_0;
			while (true)
			{
				IL_210:
				uint num;
				switch ((num = (arg_215_0 ^ 1410441633u)) % 19u)
				{
				case 0u:
					this.GameTimeInfo.MergeFrom(other.GameTimeInfo);
					arg_215_0 = 1719932446u;
					continue;
				case 2u:
					this.rafInfo_ = new RAFInfo();
					arg_215_0 = (num * 3082895277u ^ 4001234750u);
					continue;
				case 3u:
					arg_215_0 = (((this.gameTimeInfo_ != null) ? 1283980800u : 349369814u) ^ num * 2379025011u);
					continue;
				case 4u:
					goto IL_27D;
				case 5u:
					arg_215_0 = (((this.gameLevelInfo_ == null) ? 858568771u : 390153290u) ^ num * 3380535023u);
					continue;
				case 6u:
					this.GameStatus.MergeFrom(other.GameStatus);
					arg_215_0 = 759953097u;
					continue;
				case 7u:
					arg_215_0 = ((other.gameStatus_ != null) ? 1014352919u : 759953097u);
					continue;
				case 8u:
					arg_215_0 = ((other.gameTimeInfo_ == null) ? 1719932446u : 310969027u);
					continue;
				case 9u:
					this.gameTimeInfo_ = new GameTimeInfo();
					arg_215_0 = (num * 1229843329u ^ 3870435319u);
					continue;
				case 10u:
					return;
				case 11u:
					this.gameStatus_ = new GameStatus();
					arg_215_0 = (num * 225392269u ^ 3115035081u);
					continue;
				case 12u:
					this.gameLevelInfo_ = new GameLevelInfo();
					arg_215_0 = (num * 3437848998u ^ 1034672316u);
					continue;
				case 13u:
					this.RafInfo.MergeFrom(other.RafInfo);
					arg_215_0 = 883033520u;
					continue;
				case 14u:
					arg_215_0 = (((this.rafInfo_ == null) ? 914815286u : 1882333473u) ^ num * 1921154549u);
					continue;
				case 15u:
					this.GameLevelInfo.MergeFrom(other.GameLevelInfo);
					arg_215_0 = 1440048730u;
					continue;
				case 16u:
					arg_215_0 = (((this.gameStatus_ != null) ? 498710658u : 1730314470u) ^ num * 561039881u);
					continue;
				case 17u:
					goto IL_3C;
				case 18u:
					arg_215_0 = ((other.rafInfo_ != null) ? 528892012u : 883033520u);
					continue;
				}
				break;
			}
			return;
			IL_3C:
			arg_215_0 = 1263541986u;
			goto IL_210;
			IL_27D:
			arg_215_0 = ((other.gameLevelInfo_ == null) ? 1440048730u : 149231331u);
			goto IL_210;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_302:
				uint num;
				uint arg_282_0 = ((num = input.ReadTag()) != 0u) ? 162024442u : 1831846966u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_282_0 ^ 115187127u)) % 25u)
					{
					case 0u:
						arg_282_0 = ((this.rafInfo_ == null) ? 1746331160u : 1308600964u);
						continue;
					case 1u:
						goto IL_302;
					case 2u:
						input.ReadMessage(this.gameTimeInfo_);
						arg_282_0 = 1015753924u;
						continue;
					case 3u:
						input.ReadMessage(this.gameLevelInfo_);
						arg_282_0 = 735716337u;
						continue;
					case 4u:
						arg_282_0 = (((num == 18u) ? 1986941156u : 647854795u) ^ num2 * 3132988003u);
						continue;
					case 5u:
						input.ReadMessage(this.rafInfo_);
						arg_282_0 = 1015753924u;
						continue;
					case 6u:
						this.rafInfo_ = new RAFInfo();
						arg_282_0 = (num2 * 2370719136u ^ 3360512740u);
						continue;
					case 7u:
						arg_282_0 = (num2 * 782825252u ^ 51865372u);
						continue;
					case 8u:
						arg_282_0 = (num2 * 495414139u ^ 1231038969u);
						continue;
					case 9u:
						this.gameLevelInfo_ = new GameLevelInfo();
						arg_282_0 = (num2 * 3262397901u ^ 1466798597u);
						continue;
					case 10u:
						arg_282_0 = ((this.gameStatus_ != null) ? 1168144911u : 966354682u);
						continue;
					case 11u:
						arg_282_0 = ((this.gameLevelInfo_ != null) ? 1042134050u : 655606388u);
						continue;
					case 13u:
						arg_282_0 = ((num > 18u) ? 142262224u : 248912880u);
						continue;
					case 14u:
						this.gameStatus_ = new GameStatus();
						arg_282_0 = (num2 * 2655550263u ^ 3046606468u);
						continue;
					case 15u:
						arg_282_0 = (num2 * 3165359609u ^ 400503111u);
						continue;
					case 16u:
						arg_282_0 = (((num != 34u) ? 2020940649u : 997273575u) ^ num2 * 1276395109u);
						continue;
					case 17u:
						input.ReadMessage(this.gameStatus_);
						arg_282_0 = 960406800u;
						continue;
					case 18u:
						arg_282_0 = ((num == 26u) ? 616674803u : 834650863u);
						continue;
					case 19u:
						input.SkipLastField();
						arg_282_0 = 1698876396u;
						continue;
					case 20u:
						arg_282_0 = 162024442u;
						continue;
					case 21u:
						this.gameTimeInfo_ = new GameTimeInfo();
						arg_282_0 = (num2 * 2225402936u ^ 2560901117u);
						continue;
					case 22u:
						arg_282_0 = ((this.gameTimeInfo_ == null) ? 953636837u : 656299533u);
						continue;
					case 23u:
						arg_282_0 = (num2 * 483989980u ^ 473458389u);
						continue;
					case 24u:
						arg_282_0 = (((num == 10u) ? 1695455580u : 1934704507u) ^ num2 * 1596750035u);
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
