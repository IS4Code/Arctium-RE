using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountStateTagged : IMessage<GameAccountStateTagged>, IEquatable<GameAccountStateTagged>, IDeepCloneable<GameAccountStateTagged>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountStateTagged.__c __9 = new GameAccountStateTagged.__c();

			internal GameAccountStateTagged cctor>b__29_0()
			{
				return new GameAccountStateTagged();
			}
		}

		private static readonly MessageParser<GameAccountStateTagged> _parser = new MessageParser<GameAccountStateTagged>(new Func<GameAccountStateTagged>(GameAccountStateTagged.__c.__9.<.cctor>b__29_0));

		public const int GameAccountStateFieldNumber = 1;

		private GameAccountState gameAccountState_;

		public const int GameAccountTagsFieldNumber = 2;

		private GameAccountFieldTags gameAccountTags_;

		public static MessageParser<GameAccountStateTagged> Parser
		{
			get
			{
				return GameAccountStateTagged._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[34];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountStateTagged.Descriptor;
			}
		}

		public GameAccountState GameAccountState
		{
			get
			{
				return this.gameAccountState_;
			}
			set
			{
				this.gameAccountState_ = value;
			}
		}

		public GameAccountFieldTags GameAccountTags
		{
			get
			{
				return this.gameAccountTags_;
			}
			set
			{
				this.gameAccountTags_ = value;
			}
		}

		public GameAccountStateTagged()
		{
		}

		public GameAccountStateTagged(GameAccountStateTagged other) : this()
		{
			this.GameAccountState = ((other.gameAccountState_ != null) ? other.GameAccountState.Clone() : null);
			this.GameAccountTags = ((other.gameAccountTags_ != null) ? other.GameAccountTags.Clone() : null);
		}

		public GameAccountStateTagged Clone()
		{
			return new GameAccountStateTagged(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountStateTagged);
		}

		public bool Equals(GameAccountStateTagged other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 1304958851) % 9)
				{
				case 0:
					arg_77_0 = ((!GameAccountStateTagged.smethod_0(this.GameAccountState, other.GameAccountState)) ? 2071239984 : 70196962);
					continue;
				case 1:
					goto IL_B5;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					arg_77_0 = ((!GameAccountStateTagged.smethod_0(this.GameAccountTags, other.GameAccountTags)) ? 307454719 : 1670116908);
					continue;
				case 7:
					goto IL_15;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = 2013397497;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other == this) ? 333826408 : 1442790170);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B2:
				uint arg_8E_0 = 3905125738u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_8E_0 ^ 4255204237u)) % 6u)
					{
					case 1u:
						arg_8E_0 = (((this.gameAccountState_ != null) ? 3252352532u : 2170787275u) ^ num2 * 3502197694u);
						continue;
					case 2u:
						arg_8E_0 = ((this.gameAccountTags_ == null) ? 4052291921u : 2891865547u);
						continue;
					case 3u:
						goto IL_B2;
					case 4u:
						num ^= GameAccountStateTagged.smethod_1(this.GameAccountTags);
						arg_8E_0 = (num2 * 2375675286u ^ 298949205u);
						continue;
					case 5u:
						num ^= GameAccountStateTagged.smethod_1(this.GameAccountState);
						arg_8E_0 = (num2 * 698168115u ^ 217555816u);
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
			if (this.gameAccountState_ != null)
			{
				goto IL_35;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 1645111295u)) % 6u)
				{
				case 1u:
					output.WriteRawTag(18);
					arg_79_0 = (num * 971210851u ^ 1799494081u);
					continue;
				case 2u:
					output.WriteRawTag(10);
					output.WriteMessage(this.GameAccountState);
					arg_79_0 = (num * 647616801u ^ 4098913464u);
					continue;
				case 3u:
					goto IL_AC;
				case 4u:
					goto IL_35;
				case 5u:
					output.WriteMessage(this.GameAccountTags);
					arg_79_0 = (num * 3625714254u ^ 364910795u);
					continue;
				}
				break;
			}
			return;
			IL_35:
			arg_79_0 = 136466437u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.gameAccountTags_ == null) ? 1007601569u : 1560466400u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 2536558851u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 4173770992u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountState);
						arg_92_0 = (num2 * 283573391u ^ 3644502114u);
						continue;
					case 1u:
						arg_92_0 = (((this.gameAccountState_ == null) ? 3291895973u : 2457454663u) ^ num2 * 1963813333u);
						continue;
					case 3u:
						goto IL_B6;
					case 4u:
						arg_92_0 = ((this.gameAccountTags_ != null) ? 3491395009u : 2969894962u);
						continue;
					case 5u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountTags);
						arg_92_0 = (num2 * 3391467071u ^ 4151694653u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameAccountStateTagged other)
		{
			if (other == null)
			{
				goto IL_7C;
			}
			goto IL_14A;
			uint arg_102_0;
			while (true)
			{
				IL_FD:
				uint num;
				switch ((num = (arg_102_0 ^ 3922801888u)) % 11u)
				{
				case 0u:
					this.GameAccountState.MergeFrom(other.GameAccountState);
					arg_102_0 = 2862366396u;
					continue;
				case 1u:
					arg_102_0 = (((this.gameAccountState_ == null) ? 741765232u : 1391641675u) ^ num * 3155956642u);
					continue;
				case 3u:
					return;
				case 4u:
					this.gameAccountTags_ = new GameAccountFieldTags();
					arg_102_0 = (num * 355118143u ^ 2902166665u);
					continue;
				case 5u:
					goto IL_14A;
				case 6u:
					arg_102_0 = ((other.gameAccountTags_ != null) ? 3129292557u : 3537774981u);
					continue;
				case 7u:
					goto IL_7C;
				case 8u:
					this.gameAccountState_ = new GameAccountState();
					arg_102_0 = (num * 835121093u ^ 2006572891u);
					continue;
				case 9u:
					arg_102_0 = (((this.gameAccountTags_ == null) ? 3218850039u : 2675433760u) ^ num * 1402894534u);
					continue;
				case 10u:
					this.GameAccountTags.MergeFrom(other.GameAccountTags);
					arg_102_0 = 3537774981u;
					continue;
				}
				break;
			}
			return;
			IL_7C:
			arg_102_0 = 3933840632u;
			goto IL_FD;
			IL_14A:
			arg_102_0 = ((other.gameAccountState_ == null) ? 2862366396u : 2356165016u);
			goto IL_FD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) != 0u) ? 198660265u : 292714018u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 1998510890u)) % 14u)
					{
					case 0u:
						arg_145_0 = (num2 * 110825685u ^ 757041961u);
						continue;
					case 1u:
						arg_145_0 = ((this.gameAccountTags_ != null) ? 2101867833u : 463130378u);
						continue;
					case 2u:
						input.ReadMessage(this.gameAccountState_);
						arg_145_0 = 1718763534u;
						continue;
					case 3u:
						this.gameAccountState_ = new GameAccountState();
						arg_145_0 = (num2 * 2143880122u ^ 3978760088u);
						continue;
					case 4u:
						arg_145_0 = 198660265u;
						continue;
					case 5u:
						arg_145_0 = ((this.gameAccountState_ != null) ? 1435517074u : 1055735523u);
						continue;
					case 6u:
						arg_145_0 = (((num != 18u) ? 1145260143u : 2018497365u) ^ num2 * 1056065553u);
						continue;
					case 7u:
						goto IL_199;
					case 8u:
						this.gameAccountTags_ = new GameAccountFieldTags();
						arg_145_0 = (num2 * 3295020965u ^ 1865035161u);
						continue;
					case 9u:
						arg_145_0 = ((num == 10u) ? 850439345u : 1004637050u);
						continue;
					case 11u:
						input.SkipLastField();
						arg_145_0 = (num2 * 1233676987u ^ 4005103191u);
						continue;
					case 12u:
						arg_145_0 = (num2 * 2482412949u ^ 3651284911u);
						continue;
					case 13u:
						input.ReadMessage(this.gameAccountTags_);
						arg_145_0 = 583327709u;
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
