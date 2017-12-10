using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountSessionNotification : IMessage<GameAccountSessionNotification>, IEquatable<GameAccountSessionNotification>, IDeepCloneable<GameAccountSessionNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountSessionNotification.__c __9 = new GameAccountSessionNotification.__c();

			internal GameAccountSessionNotification cctor>b__29_0()
			{
				return new GameAccountSessionNotification();
			}
		}

		private static readonly MessageParser<GameAccountSessionNotification> _parser = new MessageParser<GameAccountSessionNotification>(new Func<GameAccountSessionNotification>(GameAccountSessionNotification.__c.__9.<.cctor>b__29_0));

		public const int GameAccountFieldNumber = 1;

		private GameAccountHandle gameAccount_;

		public const int SessionInfoFieldNumber = 2;

		private GameSessionUpdateInfo sessionInfo_;

		public static MessageParser<GameAccountSessionNotification> Parser
		{
			get
			{
				return GameAccountSessionNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[31];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountSessionNotification.Descriptor;
			}
		}

		public GameAccountHandle GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
			set
			{
				this.gameAccount_ = value;
			}
		}

		public GameSessionUpdateInfo SessionInfo
		{
			get
			{
				return this.sessionInfo_;
			}
			set
			{
				this.sessionInfo_ = value;
			}
		}

		public GameAccountSessionNotification()
		{
		}

		public GameAccountSessionNotification(GameAccountSessionNotification other) : this()
		{
			while (true)
			{
				IL_60:
				int arg_4A_0 = 620424843;
				while (true)
				{
					switch ((arg_4A_0 ^ 1087377796) % 3)
					{
					case 1:
						this.GameAccount = ((other.gameAccount_ != null) ? other.GameAccount.Clone() : null);
						this.SessionInfo = ((other.sessionInfo_ != null) ? other.SessionInfo.Clone() : null);
						arg_4A_0 = 279416032;
						continue;
					case 2:
						goto IL_60;
					}
					return;
				}
			}
		}

		public GameAccountSessionNotification Clone()
		{
			return new GameAccountSessionNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountSessionNotification);
		}

		public bool Equals(GameAccountSessionNotification other)
		{
			if (other == null)
			{
				goto IL_6D;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 1561408686) % 9)
				{
				case 0:
					goto IL_6D;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return true;
				case 5:
					goto IL_B5;
				case 7:
					arg_77_0 = ((!GameAccountSessionNotification.smethod_0(this.SessionInfo, other.SessionInfo)) ? 1098362412 : 468746630);
					continue;
				case 8:
					arg_77_0 = ((!GameAccountSessionNotification.smethod_0(this.GameAccount, other.GameAccount)) ? 1540688979 : 829835220);
					continue;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = 1340440498;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? 168773056 : 1297884187);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.gameAccount_ != null)
			{
				goto IL_36;
			}
			goto IL_89;
			uint arg_5D_0;
			while (true)
			{
				IL_58:
				uint num2;
				switch ((num2 = (arg_5D_0 ^ 4269037885u)) % 5u)
				{
				case 1u:
					num ^= GameAccountSessionNotification.smethod_1(this.SessionInfo);
					arg_5D_0 = (num2 * 3144237901u ^ 3082735212u);
					continue;
				case 2u:
					goto IL_36;
				case 3u:
					num ^= GameAccountSessionNotification.smethod_1(this.GameAccount);
					arg_5D_0 = (num2 * 3603458143u ^ 1915968483u);
					continue;
				case 4u:
					goto IL_89;
				}
				break;
			}
			return num;
			IL_36:
			arg_5D_0 = 2444664810u;
			goto IL_58;
			IL_89:
			arg_5D_0 = ((this.sessionInfo_ != null) ? 2403383514u : 4286097687u);
			goto IL_58;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.gameAccount_ != null)
			{
				goto IL_60;
			}
			goto IL_96;
			uint arg_6A_0;
			while (true)
			{
				IL_65:
				uint num;
				switch ((num = (arg_6A_0 ^ 1796036701u)) % 5u)
				{
				case 0u:
					goto IL_60;
				case 1u:
					goto IL_96;
				case 3u:
					output.WriteRawTag(10);
					output.WriteMessage(this.GameAccount);
					arg_6A_0 = (num * 3002749556u ^ 2919084897u);
					continue;
				case 4u:
					output.WriteRawTag(18);
					output.WriteMessage(this.SessionInfo);
					arg_6A_0 = (num * 3252380848u ^ 3993032764u);
					continue;
				}
				break;
			}
			return;
			IL_60:
			arg_6A_0 = 2127140168u;
			goto IL_65;
			IL_96:
			arg_6A_0 = ((this.sessionInfo_ != null) ? 1776467666u : 676562540u);
			goto IL_65;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.gameAccount_ != null)
			{
				goto IL_3B;
			}
			goto IL_90;
			uint arg_64_0;
			while (true)
			{
				IL_5F:
				uint num2;
				switch ((num2 = (arg_64_0 ^ 1316726899u)) % 5u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionInfo);
					arg_64_0 = (num2 * 720325476u ^ 1831873192u);
					continue;
				case 2u:
					goto IL_3B;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
					arg_64_0 = (num2 * 3278385078u ^ 448032295u);
					continue;
				case 4u:
					goto IL_90;
				}
				break;
			}
			return num;
			IL_3B:
			arg_64_0 = 1912620540u;
			goto IL_5F;
			IL_90:
			arg_64_0 = ((this.sessionInfo_ != null) ? 290647076u : 997000276u);
			goto IL_5F;
		}

		public void MergeFrom(GameAccountSessionNotification other)
		{
			if (other == null)
			{
				goto IL_E3;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 391428166u)) % 11u)
				{
				case 0u:
					this.GameAccount.MergeFrom(other.GameAccount);
					arg_105_0 = 5465253u;
					continue;
				case 1u:
					return;
				case 2u:
					goto IL_E3;
				case 3u:
					goto IL_14D;
				case 4u:
					arg_105_0 = (((this.sessionInfo_ != null) ? 729509147u : 680641853u) ^ num * 979568515u);
					continue;
				case 6u:
					arg_105_0 = (((this.gameAccount_ != null) ? 3114116859u : 2216677420u) ^ num * 1168125988u);
					continue;
				case 7u:
					this.SessionInfo.MergeFrom(other.SessionInfo);
					arg_105_0 = 676181792u;
					continue;
				case 8u:
					this.gameAccount_ = new GameAccountHandle();
					arg_105_0 = (num * 4226349050u ^ 3333713223u);
					continue;
				case 9u:
					arg_105_0 = ((other.sessionInfo_ == null) ? 676181792u : 1991817574u);
					continue;
				case 10u:
					this.sessionInfo_ = new GameSessionUpdateInfo();
					arg_105_0 = (num * 1353236465u ^ 2062774800u);
					continue;
				}
				break;
			}
			return;
			IL_E3:
			arg_105_0 = 535752065u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.gameAccount_ != null) ? 1154155188u : 5465253u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_180:
				uint num;
				uint arg_130_0 = ((num = input.ReadTag()) == 0u) ? 160061623u : 1773571977u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_130_0 ^ 526212172u)) % 13u)
					{
					case 0u:
						arg_130_0 = 1773571977u;
						continue;
					case 1u:
						this.sessionInfo_ = new GameSessionUpdateInfo();
						arg_130_0 = (num2 * 1907170149u ^ 1430850974u);
						continue;
					case 2u:
						input.SkipLastField();
						arg_130_0 = (num2 * 2648699100u ^ 2710162912u);
						continue;
					case 3u:
						arg_130_0 = (num2 * 1876571138u ^ 2498605988u);
						continue;
					case 4u:
						input.ReadMessage(this.sessionInfo_);
						arg_130_0 = 1519602736u;
						continue;
					case 6u:
						goto IL_180;
					case 7u:
						arg_130_0 = ((num == 10u) ? 1725126622u : 1044036104u);
						continue;
					case 8u:
						input.ReadMessage(this.gameAccount_);
						arg_130_0 = 385329030u;
						continue;
					case 9u:
						this.gameAccount_ = new GameAccountHandle();
						arg_130_0 = (num2 * 1783360941u ^ 1600370238u);
						continue;
					case 10u:
						arg_130_0 = (((num != 18u) ? 2819555680u : 2371564103u) ^ num2 * 3468401408u);
						continue;
					case 11u:
						arg_130_0 = ((this.sessionInfo_ != null) ? 1382408375u : 1759646777u);
						continue;
					case 12u:
						arg_130_0 = ((this.gameAccount_ != null) ? 1860249975u : 138489793u);
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
