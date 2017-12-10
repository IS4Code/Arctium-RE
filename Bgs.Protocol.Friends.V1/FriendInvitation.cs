using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class FriendInvitation : IMessage<FriendInvitation>, IEquatable<FriendInvitation>, IDeepCloneable<FriendInvitation>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FriendInvitation.__c __9 = new FriendInvitation.__c();

			internal FriendInvitation cctor>b__34_0()
			{
				return new FriendInvitation();
			}
		}

		private static readonly MessageParser<FriendInvitation> _parser = new MessageParser<FriendInvitation>(new Func<FriendInvitation>(FriendInvitation.__c.__9.<.cctor>b__34_0));

		public const int FirstReceivedFieldNumber = 1;

		private bool firstReceived_;

		public const int RoleFieldNumber = 2;

		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(18u);

		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		public const int FriendInvitation_FieldNumber = 103;

		private FriendInvitation friendInvitation_;

		public static MessageParser<FriendInvitation> Parser
		{
			get
			{
				return FriendInvitation._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendInvitation.Descriptor;
			}
		}

		public bool FirstReceived
		{
			get
			{
				return this.firstReceived_;
			}
			set
			{
				this.firstReceived_ = value;
			}
		}

		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		public FriendInvitation FriendInvitation_
		{
			get
			{
				return this.friendInvitation_;
			}
			set
			{
				this.friendInvitation_ = value;
			}
		}

		public FriendInvitation()
		{
		}

		public FriendInvitation(FriendInvitation other) : this()
		{
			while (true)
			{
				IL_61:
				int arg_4B_0 = 1669000918;
				while (true)
				{
					switch ((arg_4B_0 ^ 1170294040) % 3)
					{
					case 0:
						goto IL_61;
					case 2:
						this.firstReceived_ = other.firstReceived_;
						this.role_ = other.role_.Clone();
						this.FriendInvitation_ = ((other.friendInvitation_ != null) ? other.FriendInvitation_.Clone() : null);
						arg_4B_0 = 1771125270;
						continue;
					}
					return;
				}
			}
		}

		public FriendInvitation Clone()
		{
			return new FriendInvitation(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as FriendInvitation);
		}

		public bool Equals(FriendInvitation other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_EA;
			int arg_A4_0;
			while (true)
			{
				IL_9F:
				switch ((arg_A4_0 ^ 239496334) % 11)
				{
				case 0:
					goto IL_9A;
				case 1:
					arg_A4_0 = ((this.FirstReceived == other.FirstReceived) ? 1131789002 : 621970087);
					continue;
				case 3:
					arg_A4_0 = (this.role_.Equals(other.role_) ? 948130717 : 1368288528);
					continue;
				case 4:
					goto IL_EA;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_A4_0 = ((!FriendInvitation.smethod_0(this.FriendInvitation_, other.FriendInvitation_)) ? 1954859973 : 1604954946);
					continue;
				case 8:
					return true;
				case 9:
					return false;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = 753390908;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other != this) ? 1786984153 : 445048434);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_C3:
				uint arg_9F_0 = 2095757028u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9F_0 ^ 1575433419u)) % 6u)
					{
					case 1u:
						arg_9F_0 = ((this.FirstReceived ? 707697101u : 468163296u) ^ num2 * 2092360649u);
						continue;
					case 2u:
						num ^= this.role_.GetHashCode();
						arg_9F_0 = ((this.friendInvitation_ != null) ? 808314425u : 1515959211u);
						continue;
					case 3u:
						num ^= this.FirstReceived.GetHashCode();
						arg_9F_0 = (num2 * 1178450339u ^ 1421192004u);
						continue;
					case 4u:
						num ^= this.FriendInvitation_.GetHashCode();
						arg_9F_0 = (num2 * 722093846u ^ 3375926631u);
						continue;
					case 5u:
						goto IL_C3;
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
			if (this.FirstReceived)
			{
				goto IL_63;
			}
			goto IL_9C;
			uint arg_6D_0;
			while (true)
			{
				IL_68:
				uint num;
				switch ((num = (arg_6D_0 ^ 4201556848u)) % 5u)
				{
				case 0u:
					goto IL_63;
				case 1u:
					output.WriteRawTag(8);
					output.WriteBool(this.FirstReceived);
					arg_6D_0 = (num * 1870936425u ^ 1485359356u);
					continue;
				case 2u:
					output.WriteRawTag(186, 6);
					output.WriteMessage(this.FriendInvitation_);
					arg_6D_0 = (num * 964747635u ^ 1461788831u);
					continue;
				case 4u:
					goto IL_9C;
				}
				break;
			}
			return;
			IL_63:
			arg_6D_0 = 4130405580u;
			goto IL_68;
			IL_9C:
			this.role_.WriteTo(output, FriendInvitation._repeated_role_codec);
			arg_6D_0 = ((this.friendInvitation_ == null) ? 3784549820u : 2407500513u);
			goto IL_68;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_D0:
				uint arg_A8_0 = 3293345480u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A8_0 ^ 2917676657u)) % 7u)
					{
					case 0u:
						num += 2;
						arg_A8_0 = (num2 * 3578033293u ^ 1996193491u);
						continue;
					case 1u:
						num += 2 + CodedOutputStream.ComputeMessageSize(this.FriendInvitation_);
						arg_A8_0 = (num2 * 3200268936u ^ 3683254000u);
						continue;
					case 2u:
						goto IL_D0;
					case 4u:
						arg_A8_0 = (((this.friendInvitation_ != null) ? 3997704028u : 4238073474u) ^ num2 * 108284730u);
						continue;
					case 5u:
						num += this.role_.CalculateSize(FriendInvitation._repeated_role_codec);
						arg_A8_0 = 3210161432u;
						continue;
					case 6u:
						arg_A8_0 = ((this.FirstReceived ? 2520084096u : 2964496766u) ^ num2 * 3573503334u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(FriendInvitation other)
		{
			if (other == null)
			{
				goto IL_33;
			}
			goto IL_126;
			uint arg_E2_0;
			while (true)
			{
				IL_DD:
				uint num;
				switch ((num = (arg_E2_0 ^ 4199841859u)) % 10u)
				{
				case 0u:
					arg_E2_0 = (((this.friendInvitation_ == null) ? 3480631615u : 3287593266u) ^ num * 2615713541u);
					continue;
				case 1u:
					this.role_.Add(other.role_);
					arg_E2_0 = 2326293901u;
					continue;
				case 2u:
					arg_E2_0 = (((other.friendInvitation_ == null) ? 940321829u : 1244411821u) ^ num * 4100903140u);
					continue;
				case 3u:
					this.FirstReceived = other.FirstReceived;
					arg_E2_0 = (num * 3670462211u ^ 3386672925u);
					continue;
				case 4u:
					return;
				case 5u:
					goto IL_126;
				case 6u:
					this.friendInvitation_ = new FriendInvitation();
					arg_E2_0 = (num * 84338464u ^ 1193638300u);
					continue;
				case 7u:
					goto IL_33;
				case 9u:
					this.FriendInvitation_.MergeFrom(other.FriendInvitation_);
					arg_E2_0 = 2431846237u;
					continue;
				}
				break;
			}
			return;
			IL_33:
			arg_E2_0 = 3125889203u;
			goto IL_DD;
			IL_126:
			arg_E2_0 = (other.FirstReceived ? 3750038842u : 2444490870u);
			goto IL_DD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1FB:
				uint num;
				uint arg_19B_0 = ((num = input.ReadTag()) == 0u) ? 1481557437u : 42918632u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_19B_0 ^ 1928913103u)) % 17u)
					{
					case 0u:
						input.SkipLastField();
						arg_19B_0 = 1084420749u;
						continue;
					case 2u:
						input.ReadMessage(this.friendInvitation_);
						arg_19B_0 = 1146898745u;
						continue;
					case 3u:
						arg_19B_0 = (num2 * 191714023u ^ 2707805367u);
						continue;
					case 4u:
						goto IL_1FB;
					case 5u:
						arg_19B_0 = (((num != 16u) ? 465674371u : 165991240u) ^ num2 * 1848516133u);
						continue;
					case 6u:
						this.friendInvitation_ = new FriendInvitation();
						arg_19B_0 = (num2 * 4134036817u ^ 3437459504u);
						continue;
					case 7u:
						arg_19B_0 = (num2 * 240959498u ^ 1267401087u);
						continue;
					case 8u:
						arg_19B_0 = 42918632u;
						continue;
					case 9u:
						arg_19B_0 = ((this.friendInvitation_ != null) ? 1218101416u : 880445911u);
						continue;
					case 10u:
						arg_19B_0 = (((num == 826u) ? 1622134197u : 1967024079u) ^ num2 * 2426276401u);
						continue;
					case 11u:
						this.FirstReceived = input.ReadBool();
						arg_19B_0 = 2056705224u;
						continue;
					case 12u:
						arg_19B_0 = (num2 * 3027514116u ^ 295646737u);
						continue;
					case 13u:
						arg_19B_0 = (((num != 8u) ? 4067874630u : 3616660314u) ^ num2 * 4072922565u);
						continue;
					case 14u:
						arg_19B_0 = ((num != 18u) ? 804590421u : 2040414637u);
						continue;
					case 15u:
						this.role_.AddEntriesFrom(input, FriendInvitation._repeated_role_codec);
						arg_19B_0 = 1146898745u;
						continue;
					case 16u:
						arg_19B_0 = ((num > 16u) ? 10077620u : 10655079u);
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
