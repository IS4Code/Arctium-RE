using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Channel.V1
{
	[DebuggerNonUserCode]
	public sealed class ChannelInfo : IMessage<ChannelInfo>, IEquatable<ChannelInfo>, IDeepCloneable<ChannelInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChannelInfo.__c __9 = new ChannelInfo.__c();

			internal ChannelInfo cctor>b__29_0()
			{
				return new ChannelInfo();
			}
		}

		private static readonly MessageParser<ChannelInfo> _parser = new MessageParser<ChannelInfo>(new Func<ChannelInfo>(ChannelInfo.__c.__9.<.cctor>b__29_0));

		public const int DescriptionFieldNumber = 1;

		private ChannelDescription description_;

		public const int MemberFieldNumber = 2;

		private static readonly FieldCodec<Member> _repeated_member_codec = FieldCodec.ForMessage<Member>(18u, Bgs.Protocol.Channel.V1.Member.Parser);

		private readonly RepeatedField<Member> member_ = new RepeatedField<Member>();

		public static MessageParser<ChannelInfo> Parser
		{
			get
			{
				return ChannelInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelInfo.Descriptor;
			}
		}

		public ChannelDescription Description
		{
			get
			{
				return this.description_;
			}
			set
			{
				this.description_ = value;
			}
		}

		public RepeatedField<Member> Member
		{
			get
			{
				return this.member_;
			}
		}

		public ChannelInfo()
		{
		}

		public ChannelInfo(ChannelInfo other) : this()
		{
			while (true)
			{
				IL_55:
				int arg_3F_0 = 145698129;
				while (true)
				{
					switch ((arg_3F_0 ^ 1279609202) % 3)
					{
					case 0:
						goto IL_55;
					case 2:
						this.Description = ((other.description_ != null) ? other.Description.Clone() : null);
						this.member_ = other.member_.Clone();
						arg_3F_0 = 1173525740;
						continue;
					}
					return;
				}
			}
		}

		public ChannelInfo Clone()
		{
			return new ChannelInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelInfo);
		}

		public bool Equals(ChannelInfo other)
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
				switch ((arg_77_0 ^ -1181358713) % 9)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					goto IL_B5;
				case 5:
					arg_77_0 = ((!ChannelInfo.smethod_0(this.Description, other.Description)) ? -1256247803 : -1387286740);
					continue;
				case 6:
					arg_77_0 = ((!this.member_.Equals(other.member_)) ? -439694023 : -1143257880);
					continue;
				case 8:
					goto IL_15;
				}
				break;
			}
			return true;
			IL_15:
			arg_77_0 = -1315941912;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? -135786796 : -1698872224);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			return 1 ^ ChannelInfo.smethod_1(this.Description) ^ ChannelInfo.smethod_1(this.member_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteMessage(this.Description);
			this.member_.WriteTo(output, ChannelInfo._repeated_member_codec);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.Description)) + this.member_.CalculateSize(ChannelInfo._repeated_member_codec);
		}

		public void MergeFrom(ChannelInfo other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_CD;
			uint arg_92_0;
			while (true)
			{
				IL_8D:
				uint num;
				switch ((num = (arg_92_0 ^ 1226571012u)) % 8u)
				{
				case 0u:
					arg_92_0 = (((this.description_ != null) ? 2917911395u : 4028149543u) ^ num * 3629027422u);
					continue;
				case 2u:
					this.member_.Add(other.member_);
					arg_92_0 = 184893909u;
					continue;
				case 3u:
					this.description_ = new ChannelDescription();
					arg_92_0 = (num * 2192252830u ^ 2463513177u);
					continue;
				case 4u:
					goto IL_CD;
				case 5u:
					return;
				case 6u:
					goto IL_2D;
				case 7u:
					this.Description.MergeFrom(other.Description);
					arg_92_0 = 248041326u;
					continue;
				}
				break;
			}
			return;
			IL_2D:
			arg_92_0 = 530107553u;
			goto IL_8D;
			IL_CD:
			arg_92_0 = ((other.description_ == null) ? 248041326u : 900905812u);
			goto IL_8D;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_158:
				uint num;
				uint arg_10C_0 = ((num = input.ReadTag()) == 0u) ? 3021152974u : 3479129743u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_10C_0 ^ 3307076525u)) % 12u)
					{
					case 0u:
						goto IL_158;
					case 1u:
						this.description_ = new ChannelDescription();
						arg_10C_0 = (num2 * 2017116177u ^ 3047478442u);
						continue;
					case 2u:
						arg_10C_0 = ((this.description_ == null) ? 2646354020u : 3233481971u);
						continue;
					case 3u:
						arg_10C_0 = (((num != 18u) ? 2191868591u : 2462664979u) ^ num2 * 920186085u);
						continue;
					case 4u:
						arg_10C_0 = (num2 * 2435924433u ^ 1939982789u);
						continue;
					case 5u:
						input.SkipLastField();
						arg_10C_0 = (num2 * 4137158995u ^ 58176598u);
						continue;
					case 6u:
						arg_10C_0 = ((num == 10u) ? 2546747911u : 4260304198u);
						continue;
					case 7u:
						arg_10C_0 = (num2 * 1312867481u ^ 2005853054u);
						continue;
					case 8u:
						arg_10C_0 = 3479129743u;
						continue;
					case 9u:
						this.member_.AddEntriesFrom(input, ChannelInfo._repeated_member_codec);
						arg_10C_0 = 2384874193u;
						continue;
					case 10u:
						input.ReadMessage(this.description_);
						arg_10C_0 = 3123183146u;
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
