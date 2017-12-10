using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountOnlineNotification : IMessage<GameAccountOnlineNotification>, IEquatable<GameAccountOnlineNotification>, IDeepCloneable<GameAccountOnlineNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountOnlineNotification.__c __9 = new GameAccountOnlineNotification.__c();

			internal GameAccountOnlineNotification cctor>b__34_0()
			{
				return new GameAccountOnlineNotification();
			}
		}

		private static readonly MessageParser<GameAccountOnlineNotification> _parser = new MessageParser<GameAccountOnlineNotification>(new Func<GameAccountOnlineNotification>(GameAccountOnlineNotification.__c.__9.<.cctor>b__34_0));

		public const int GameAccountIdFieldNumber = 1;

		private EntityId gameAccountId_;

		public const int HostFieldNumber = 2;

		private ProcessId host_;

		public const int SessionIdFieldNumber = 3;

		private string sessionId_ = "";

		public static MessageParser<GameAccountOnlineNotification> Parser
		{
			get
			{
				return GameAccountOnlineNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountOnlineNotification.Descriptor;
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

		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		public string SessionId
		{
			get
			{
				return this.sessionId_;
			}
			set
			{
				this.sessionId_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public GameAccountOnlineNotification()
		{
		}

		public GameAccountOnlineNotification(GameAccountOnlineNotification other) : this()
		{
			while (true)
			{
				IL_8F:
				uint arg_6F_0 = 2181103460u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6F_0 ^ 3606721597u)) % 5u)
					{
					case 0u:
						this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
						arg_6F_0 = 2254060220u;
						continue;
					case 1u:
						this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
						arg_6F_0 = 2423723677u;
						continue;
					case 2u:
						goto IL_8F;
					case 3u:
						this.sessionId_ = other.sessionId_;
						arg_6F_0 = (num * 245163163u ^ 4167981865u);
						continue;
					}
					return;
				}
			}
		}

		public GameAccountOnlineNotification Clone()
		{
			return new GameAccountOnlineNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountOnlineNotification);
		}

		public bool Equals(GameAccountOnlineNotification other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ -1140795187) % 11)
				{
				case 0:
					return false;
				case 1:
					arg_A6_0 = (GameAccountOnlineNotification.smethod_1(this.SessionId, other.SessionId) ? -685077654 : -244479080);
					continue;
				case 2:
					return true;
				case 3:
					arg_A6_0 = (GameAccountOnlineNotification.smethod_0(this.Host, other.Host) ? -438966594 : -1341386545);
					continue;
				case 4:
					goto IL_44;
				case 5:
					arg_A6_0 = (GameAccountOnlineNotification.smethod_0(this.GameAccountId, other.GameAccountId) ? -1216753654 : -2108516640);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_EC;
				case 9:
					return false;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_44:
			arg_A6_0 = -1769735828;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other == this) ? -1761864851 : -89511260);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_DB:
				uint arg_B3_0 = 3117190176u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 4200534063u)) % 7u)
					{
					case 0u:
						goto IL_DB;
					case 1u:
						num ^= GameAccountOnlineNotification.smethod_2(this.SessionId);
						arg_B3_0 = (num2 * 1240375468u ^ 2425239031u);
						continue;
					case 3u:
						arg_B3_0 = ((GameAccountOnlineNotification.smethod_3(this.SessionId) != 0) ? 2715551514u : 2320794219u);
						continue;
					case 4u:
						arg_B3_0 = (((this.host_ == null) ? 842179562u : 287845678u) ^ num2 * 3415564301u);
						continue;
					case 5u:
						num ^= GameAccountOnlineNotification.smethod_2(this.Host);
						arg_B3_0 = (num2 * 1034710224u ^ 2402633738u);
						continue;
					case 6u:
						num ^= GameAccountOnlineNotification.smethod_2(this.GameAccountId);
						arg_B3_0 = (num2 * 3527756395u ^ 2432986266u);
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
			output.WriteRawTag(10);
			while (true)
			{
				IL_115:
				uint arg_E4_0 = 2878169159u;
				while (true)
				{
					uint num;
					switch ((num = (arg_E4_0 ^ 3548354004u)) % 9u)
					{
					case 0u:
						goto IL_115;
					case 2u:
						output.WriteMessage(this.Host);
						arg_E4_0 = (num * 2491960399u ^ 2632451216u);
						continue;
					case 3u:
						output.WriteRawTag(26);
						arg_E4_0 = (num * 1098232804u ^ 853567348u);
						continue;
					case 4u:
						output.WriteString(this.SessionId);
						arg_E4_0 = (num * 1849759184u ^ 4027462358u);
						continue;
					case 5u:
						output.WriteRawTag(18);
						arg_E4_0 = (num * 799481874u ^ 1190786467u);
						continue;
					case 6u:
						arg_E4_0 = ((GameAccountOnlineNotification.smethod_3(this.SessionId) != 0) ? 2252593516u : 2805462742u);
						continue;
					case 7u:
						output.WriteMessage(this.GameAccountId);
						arg_E4_0 = (num * 1877231962u ^ 4272325538u);
						continue;
					case 8u:
						arg_E4_0 = (((this.host_ == null) ? 4152997791u : 3367779547u) ^ num * 3029455947u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId));
			if (this.host_ != null)
			{
				goto IL_6A;
			}
			goto IL_A0;
			uint arg_74_0;
			while (true)
			{
				IL_6F:
				uint num2;
				switch ((num2 = (arg_74_0 ^ 250995980u)) % 5u)
				{
				case 0u:
					goto IL_6A;
				case 1u:
					goto IL_A0;
				case 2u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
					arg_74_0 = (num2 * 1350301649u ^ 4067618507u);
					continue;
				case 4u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
					arg_74_0 = (num2 * 4033124571u ^ 1788275794u);
					continue;
				}
				break;
			}
			return num;
			IL_6A:
			arg_74_0 = 2073133012u;
			goto IL_6F;
			IL_A0:
			arg_74_0 = ((GameAccountOnlineNotification.smethod_3(this.SessionId) == 0) ? 1321023427u : 1422353935u);
			goto IL_6F;
		}

		public void MergeFrom(GameAccountOnlineNotification other)
		{
			if (other == null)
			{
				goto IL_C5;
			}
			goto IL_19C;
			uint arg_14C_0;
			while (true)
			{
				IL_147:
				uint num;
				switch ((num = (arg_14C_0 ^ 2848462060u)) % 13u)
				{
				case 0u:
					arg_14C_0 = ((other.host_ != null) ? 3244325283u : 3076700315u);
					continue;
				case 1u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_14C_0 = 3630378138u;
					continue;
				case 2u:
					goto IL_19C;
				case 4u:
					arg_14C_0 = (((this.host_ != null) ? 453417992u : 1523577806u) ^ num * 3897295760u);
					continue;
				case 5u:
					this.SessionId = other.SessionId;
					arg_14C_0 = (num * 3352858386u ^ 2317194647u);
					continue;
				case 6u:
					goto IL_C5;
				case 7u:
					arg_14C_0 = (((this.gameAccountId_ != null) ? 1171229978u : 1974949541u) ^ num * 2557998396u);
					continue;
				case 8u:
					this.Host.MergeFrom(other.Host);
					arg_14C_0 = 3076700315u;
					continue;
				case 9u:
					this.gameAccountId_ = new EntityId();
					arg_14C_0 = (num * 4120630976u ^ 3783410278u);
					continue;
				case 10u:
					arg_14C_0 = ((GameAccountOnlineNotification.smethod_3(other.SessionId) == 0) ? 2470448547u : 3620937254u);
					continue;
				case 11u:
					return;
				case 12u:
					this.host_ = new ProcessId();
					arg_14C_0 = (num * 2927117784u ^ 2179717704u);
					continue;
				}
				break;
			}
			return;
			IL_C5:
			arg_14C_0 = 2610779247u;
			goto IL_147;
			IL_19C:
			arg_14C_0 = ((other.gameAccountId_ != null) ? 2834114637u : 3630378138u);
			goto IL_147;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1B7:
				uint num;
				uint arg_163_0 = ((num = input.ReadTag()) == 0u) ? 1880803266u : 550715047u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_163_0 ^ 886319838u)) % 14u)
					{
					case 1u:
						arg_163_0 = (((num != 18u) ? 1773405986u : 1053133351u) ^ num2 * 600285158u);
						continue;
					case 2u:
						input.ReadMessage(this.gameAccountId_);
						arg_163_0 = 1220839439u;
						continue;
					case 3u:
						this.SessionId = input.ReadString();
						arg_163_0 = 1220839439u;
						continue;
					case 4u:
						arg_163_0 = ((this.gameAccountId_ == null) ? 1845000534u : 209399680u);
						continue;
					case 5u:
						goto IL_1B7;
					case 6u:
						input.SkipLastField();
						arg_163_0 = (num2 * 3830312012u ^ 469195311u);
						continue;
					case 7u:
						input.ReadMessage(this.host_);
						arg_163_0 = 1220839439u;
						continue;
					case 8u:
						this.gameAccountId_ = new EntityId();
						arg_163_0 = (num2 * 1115962574u ^ 1260665072u);
						continue;
					case 9u:
						arg_163_0 = ((this.host_ == null) ? 877981660u : 451850571u);
						continue;
					case 10u:
						this.host_ = new ProcessId();
						arg_163_0 = (num2 * 135494179u ^ 72176141u);
						continue;
					case 11u:
						arg_163_0 = ((num == 10u) ? 2087376606u : 192338603u);
						continue;
					case 12u:
						arg_163_0 = (((num != 26u) ? 1186058564u : 1392834495u) ^ num2 * 2009280241u);
						continue;
					case 13u:
						arg_163_0 = 550715047u;
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
