using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class Member : IMessage<Member>, IEquatable<Member>, IDeepCloneable<Member>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Member.__c __9 = new Member.__c();

			internal Member cctor>b__29_0()
			{
				return new Member();
			}
		}

		private static readonly MessageParser<Member> _parser = new MessageParser<Member>(new Func<Member>(Member.__c.__9.<.cctor>b__29_0));

		public const int IdentityFieldNumber = 1;

		private Identity identity_;

		public const int StateFieldNumber = 2;

		private MemberState state_;

		public static MessageParser<Member> Parser
		{
			get
			{
				return Member._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Member.Descriptor;
			}
		}

		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		public MemberState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		public Member()
		{
		}

		public Member(Member other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = -1292787121;
				while (true)
				{
					switch ((arg_2E_0 ^ -1867672256) % 3)
					{
					case 0:
						goto IL_44;
					case 1:
						this.Identity = ((other.identity_ != null) ? other.Identity.Clone() : null);
						arg_2E_0 = -751749821;
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.State = ((other.state_ != null) ? other.State.Clone() : null);
		}

		public Member Clone()
		{
			return new Member(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Member);
		}

		public bool Equals(Member other)
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
				switch ((arg_77_0 ^ -1672701637) % 9)
				{
				case 0:
					return true;
				case 1:
					arg_77_0 = (Member.smethod_0(this.State, other.State) ? -1597148277 : -794491784);
					continue;
				case 2:
					arg_77_0 = ((!Member.smethod_0(this.Identity, other.Identity)) ? -1801549910 : -295825536);
					continue;
				case 3:
					goto IL_15;
				case 4:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_B5;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = -1797148378;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -1415763303 : -296898439);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			return 1 ^ Member.smethod_1(this.Identity) ^ Member.smethod_1(this.State);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteMessage(this.Identity);
			while (true)
			{
				IL_54:
				uint arg_3C_0 = 2591616176u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3C_0 ^ 2375239286u)) % 3u)
					{
					case 0u:
						goto IL_54;
					case 2u:
						output.WriteRawTag(18);
						output.WriteMessage(this.State);
						arg_3C_0 = (num * 2890775567u ^ 9154466u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.Identity)) + (1 + CodedOutputStream.ComputeMessageSize(this.State));
		}

		public void MergeFrom(Member other)
		{
			if (other == null)
			{
				goto IL_68;
			}
			goto IL_14A;
			uint arg_102_0;
			while (true)
			{
				IL_FD:
				uint num;
				switch ((num = (arg_102_0 ^ 4233549494u)) % 11u)
				{
				case 0u:
					arg_102_0 = (((this.identity_ == null) ? 1209241364u : 1036108649u) ^ num * 1770578249u);
					continue;
				case 1u:
					this.state_ = new MemberState();
					arg_102_0 = (num * 3855138120u ^ 2461169924u);
					continue;
				case 2u:
					this.identity_ = new Identity();
					arg_102_0 = (num * 656541080u ^ 3012071469u);
					continue;
				case 3u:
					this.State.MergeFrom(other.State);
					arg_102_0 = 3283414722u;
					continue;
				case 5u:
					this.Identity.MergeFrom(other.Identity);
					arg_102_0 = 2722307032u;
					continue;
				case 6u:
					goto IL_68;
				case 7u:
					return;
				case 8u:
					goto IL_14A;
				case 9u:
					arg_102_0 = ((other.state_ != null) ? 3899534026u : 3283414722u);
					continue;
				case 10u:
					arg_102_0 = (((this.state_ != null) ? 4218211292u : 3395999845u) ^ num * 1091732704u);
					continue;
				}
				break;
			}
			return;
			IL_68:
			arg_102_0 = 2605819962u;
			goto IL_FD;
			IL_14A:
			arg_102_0 = ((other.identity_ == null) ? 2722307032u : 3157584386u);
			goto IL_FD;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_183:
				uint num;
				uint arg_133_0 = ((num = input.ReadTag()) != 0u) ? 3232522935u : 3974503944u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_133_0 ^ 3821917404u)) % 13u)
					{
					case 0u:
						input.ReadMessage(this.state_);
						arg_133_0 = 4251405533u;
						continue;
					case 1u:
						this.state_ = new MemberState();
						arg_133_0 = (num2 * 981090857u ^ 2366905266u);
						continue;
					case 2u:
						arg_133_0 = 3232522935u;
						continue;
					case 4u:
						arg_133_0 = ((num == 10u) ? 3188101311u : 3113326198u);
						continue;
					case 5u:
						arg_133_0 = ((this.state_ == null) ? 2222359176u : 2556321990u);
						continue;
					case 6u:
						this.identity_ = new Identity();
						arg_133_0 = (num2 * 399741641u ^ 152210466u);
						continue;
					case 7u:
						arg_133_0 = (num2 * 443517618u ^ 2118424699u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_133_0 = (num2 * 1533029528u ^ 3339867597u);
						continue;
					case 9u:
						arg_133_0 = ((this.identity_ == null) ? 3847584048u : 3347556974u);
						continue;
					case 10u:
						input.ReadMessage(this.identity_);
						arg_133_0 = 2264248151u;
						continue;
					case 11u:
						goto IL_183;
					case 12u:
						arg_133_0 = (((num == 18u) ? 2040702423u : 778131960u) ^ num2 * 411084533u);
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
