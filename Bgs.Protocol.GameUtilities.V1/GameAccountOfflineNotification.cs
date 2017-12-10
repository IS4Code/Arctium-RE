using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountOfflineNotification : IMessage<GameAccountOfflineNotification>, IEquatable<GameAccountOfflineNotification>, IDeepCloneable<GameAccountOfflineNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountOfflineNotification.__c __9 = new GameAccountOfflineNotification.__c();

			internal GameAccountOfflineNotification cctor>b__34_0()
			{
				return new GameAccountOfflineNotification();
			}
		}

		private static readonly MessageParser<GameAccountOfflineNotification> _parser = new MessageParser<GameAccountOfflineNotification>(new Func<GameAccountOfflineNotification>(GameAccountOfflineNotification.__c.__9.<.cctor>b__34_0));

		public const int GameAccountIdFieldNumber = 1;

		private EntityId gameAccountId_;

		public const int HostFieldNumber = 2;

		private ProcessId host_;

		public const int SessionIdFieldNumber = 3;

		private string sessionId_ = "";

		public static MessageParser<GameAccountOfflineNotification> Parser
		{
			get
			{
				return GameAccountOfflineNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountOfflineNotification.Descriptor;
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
				this.sessionId_ = Preconditions.CheckNotNull<string>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public GameAccountOfflineNotification()
		{
		}

		public GameAccountOfflineNotification(GameAccountOfflineNotification other) : this()
		{
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
			this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
			this.sessionId_ = other.sessionId_;
		}

		public GameAccountOfflineNotification Clone()
		{
			return new GameAccountOfflineNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountOfflineNotification);
		}

		public bool Equals(GameAccountOfflineNotification other)
		{
			if (other == null)
			{
				goto IL_70;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ 584034928) % 11)
				{
				case 1:
					goto IL_EC;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_A6_0 = ((!GameAccountOfflineNotification.smethod_0(this.GameAccountId, other.GameAccountId)) ? 1372416767 : 800454457);
					continue;
				case 5:
					goto IL_70;
				case 6:
					return false;
				case 7:
					arg_A6_0 = ((!GameAccountOfflineNotification.smethod_1(this.SessionId, other.SessionId)) ? 1749857959 : 432414334);
					continue;
				case 8:
					arg_A6_0 = ((!GameAccountOfflineNotification.smethod_0(this.Host, other.Host)) ? 602600850 : 1150801411);
					continue;
				case 9:
					return false;
				case 10:
					return true;
				}
				break;
			}
			return true;
			IL_70:
			arg_A6_0 = 1761637141;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other == this) ? 1114251026 : 1217857912);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_DB:
				uint arg_B3_0 = 1965819252u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 1209535492u)) % 7u)
					{
					case 0u:
						goto IL_DB;
					case 1u:
						arg_B3_0 = ((GameAccountOfflineNotification.smethod_3(this.SessionId) != 0) ? 154941781u : 2055554638u);
						continue;
					case 2u:
						num ^= GameAccountOfflineNotification.smethod_2(this.Host);
						arg_B3_0 = (num2 * 1174474721u ^ 2436990007u);
						continue;
					case 3u:
						num ^= GameAccountOfflineNotification.smethod_2(this.SessionId);
						arg_B3_0 = (num2 * 2737101001u ^ 3192615639u);
						continue;
					case 4u:
						arg_B3_0 = (((this.host_ != null) ? 3687531722u : 3200642745u) ^ num2 * 2312274062u);
						continue;
					case 5u:
						num ^= GameAccountOfflineNotification.smethod_2(this.GameAccountId);
						arg_B3_0 = (num2 * 2554128522u ^ 2755040196u);
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
				IL_FE:
				uint arg_D2_0 = 3123947244u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D2_0 ^ 2787816551u)) % 8u)
					{
					case 0u:
						goto IL_FE;
					case 1u:
						arg_D2_0 = (((this.host_ != null) ? 2429227841u : 3465575408u) ^ num * 3974444849u);
						continue;
					case 3u:
						output.WriteMessage(this.GameAccountId);
						arg_D2_0 = (num * 782822121u ^ 2144926149u);
						continue;
					case 4u:
						output.WriteString(this.SessionId);
						arg_D2_0 = (num * 1106271198u ^ 4230200453u);
						continue;
					case 5u:
						output.WriteRawTag(26);
						arg_D2_0 = (num * 2474351876u ^ 987879367u);
						continue;
					case 6u:
						arg_D2_0 = ((GameAccountOfflineNotification.smethod_3(this.SessionId) == 0) ? 3783372893u : 4158137818u);
						continue;
					case 7u:
						output.WriteRawTag(18);
						output.WriteMessage(this.Host);
						arg_D2_0 = (num * 909674359u ^ 3993887472u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId));
			while (true)
			{
				IL_CB:
				uint arg_A7_0 = 637495294u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A7_0 ^ 1933150455u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
						arg_A7_0 = (num2 * 1460470515u ^ 3233632035u);
						continue;
					case 1u:
						arg_A7_0 = (((this.host_ != null) ? 424377294u : 120343922u) ^ num2 * 1107066388u);
						continue;
					case 2u:
						goto IL_CB;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
						arg_A7_0 = (num2 * 645278798u ^ 775566128u);
						continue;
					case 5u:
						arg_A7_0 = ((GameAccountOfflineNotification.smethod_3(this.SessionId) != 0) ? 1649851525u : 310174485u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameAccountOfflineNotification other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_199;
			uint arg_149_0;
			while (true)
			{
				IL_144:
				uint num;
				switch ((num = (arg_149_0 ^ 1672682679u)) % 13u)
				{
				case 0u:
					this.SessionId = other.SessionId;
					arg_149_0 = (num * 3295747611u ^ 4038594862u);
					continue;
				case 1u:
					arg_149_0 = (((this.gameAccountId_ != null) ? 1421690194u : 186125960u) ^ num * 3807097226u);
					continue;
				case 2u:
					arg_149_0 = ((other.host_ == null) ? 1922309912u : 1439326218u);
					continue;
				case 3u:
					return;
				case 4u:
					this.gameAccountId_ = new EntityId();
					arg_149_0 = (num * 2265645718u ^ 3154196990u);
					continue;
				case 5u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_149_0 = 1450647575u;
					continue;
				case 6u:
					arg_149_0 = (((this.host_ != null) ? 485618266u : 1321838593u) ^ num * 4241729169u);
					continue;
				case 7u:
					this.host_ = new ProcessId();
					arg_149_0 = (num * 3125634392u ^ 2804586527u);
					continue;
				case 8u:
					this.Host.MergeFrom(other.Host);
					arg_149_0 = 1922309912u;
					continue;
				case 9u:
					goto IL_199;
				case 11u:
					arg_149_0 = ((GameAccountOfflineNotification.smethod_3(other.SessionId) != 0) ? 1944085667u : 554439474u);
					continue;
				case 12u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_149_0 = 1661714755u;
			goto IL_144;
			IL_199:
			arg_149_0 = ((other.gameAccountId_ == null) ? 1450647575u : 166607474u);
			goto IL_144;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1E0:
				uint num;
				uint arg_184_0 = ((num = input.ReadTag()) == 0u) ? 3229080614u : 3676262558u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_184_0 ^ 3799257852u)) % 16u)
					{
					case 0u:
						input.SkipLastField();
						arg_184_0 = (num2 * 1737847088u ^ 1789875978u);
						continue;
					case 1u:
						arg_184_0 = (num2 * 3498690857u ^ 45365923u);
						continue;
					case 2u:
						arg_184_0 = ((num != 10u) ? 2969238530u : 2982887845u);
						continue;
					case 3u:
						arg_184_0 = 3676262558u;
						continue;
					case 4u:
						arg_184_0 = (((num != 26u) ? 747549492u : 1230651356u) ^ num2 * 3996502918u);
						continue;
					case 5u:
						input.ReadMessage(this.host_);
						arg_184_0 = 4294933079u;
						continue;
					case 6u:
						goto IL_1E0;
					case 7u:
						input.ReadMessage(this.gameAccountId_);
						arg_184_0 = 3987113853u;
						continue;
					case 8u:
						this.SessionId = input.ReadString();
						arg_184_0 = 2962292746u;
						continue;
					case 9u:
						arg_184_0 = ((this.gameAccountId_ == null) ? 3743884499u : 3606298139u);
						continue;
					case 11u:
						arg_184_0 = (num2 * 3713371880u ^ 3401430258u);
						continue;
					case 12u:
						arg_184_0 = ((this.host_ == null) ? 3699004897u : 2625338889u);
						continue;
					case 13u:
						this.host_ = new ProcessId();
						arg_184_0 = (num2 * 429415747u ^ 3887160222u);
						continue;
					case 14u:
						arg_184_0 = (((num == 18u) ? 543182618u : 1997454850u) ^ num2 * 604174019u);
						continue;
					case 15u:
						this.gameAccountId_ = new EntityId();
						arg_184_0 = (num2 * 945263263u ^ 3950889770u);
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
