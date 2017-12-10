using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class RegionTag : IMessage<RegionTag>, IEquatable<RegionTag>, IDeepCloneable<RegionTag>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RegionTag.__c __9 = new RegionTag.__c();

			internal RegionTag cctor>b__29_0()
			{
				return new RegionTag();
			}
		}

		private static readonly MessageParser<RegionTag> _parser = new MessageParser<RegionTag>(new Func<RegionTag>(RegionTag.__c.__9.<.cctor>b__29_0));

		public const int RegionFieldNumber = 1;

		private uint region_;

		public const int TagFieldNumber = 2;

		private uint tag_;

		public static MessageParser<RegionTag> Parser
		{
			get
			{
				return RegionTag._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[12];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegionTag.Descriptor;
			}
		}

		public uint Region
		{
			get
			{
				return this.region_;
			}
			set
			{
				this.region_ = value;
			}
		}

		public uint Tag
		{
			get
			{
				return this.tag_;
			}
			set
			{
				this.tag_ = value;
			}
		}

		public RegionTag()
		{
		}

		public RegionTag(RegionTag other) : this()
		{
			while (true)
			{
				IL_4A:
				uint arg_32_0 = 3696840306u;
				while (true)
				{
					uint num;
					switch ((num = (arg_32_0 ^ 3146092368u)) % 3u)
					{
					case 0u:
						goto IL_4A;
					case 1u:
						this.region_ = other.region_;
						this.tag_ = other.tag_;
						arg_32_0 = (num * 4040161747u ^ 2228374286u);
						continue;
					}
					return;
				}
			}
		}

		public RegionTag Clone()
		{
			return new RegionTag(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RegionTag);
		}

		public bool Equals(RegionTag other)
		{
			if (other == null)
			{
				goto IL_3C;
			}
			goto IL_AB;
			int arg_6D_0;
			while (true)
			{
				IL_68:
				switch ((arg_6D_0 ^ 2043307661) % 9)
				{
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					arg_6D_0 = ((this.Region != other.Region) ? 893721832 : 1896318819);
					continue;
				case 4:
					goto IL_3C;
				case 5:
					return false;
				case 6:
					goto IL_AB;
				case 7:
					arg_6D_0 = ((this.Tag == other.Tag) ? 1128657239 : 715571709);
					continue;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_3C:
			arg_6D_0 = 2055337744;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other != this) ? 171213264 : 770937400);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Region != 0u)
			{
				goto IL_3C;
			}
			goto IL_92;
			uint arg_66_0;
			while (true)
			{
				IL_61:
				uint num2;
				switch ((num2 = (arg_66_0 ^ 2420517357u)) % 5u)
				{
				case 1u:
					num ^= this.Tag.GetHashCode();
					arg_66_0 = (num2 * 2728849644u ^ 3505070855u);
					continue;
				case 2u:
					goto IL_3C;
				case 3u:
					num ^= this.Region.GetHashCode();
					arg_66_0 = (num2 * 2894504445u ^ 2831360142u);
					continue;
				case 4u:
					goto IL_92;
				}
				break;
			}
			return num;
			IL_3C:
			arg_66_0 = 2194312281u;
			goto IL_61;
			IL_92:
			arg_66_0 = ((this.Tag != 0u) ? 2953663868u : 3264210603u);
			goto IL_61;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.Region != 0u)
			{
				goto IL_6F;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 1001591562u)) % 6u)
				{
				case 0u:
					goto IL_6F;
				case 1u:
					output.WriteRawTag(21);
					arg_79_0 = (num * 3769724643u ^ 1811810191u);
					continue;
				case 3u:
					goto IL_AC;
				case 4u:
					output.WriteFixed32(this.Tag);
					arg_79_0 = (num * 1243360513u ^ 1355817802u);
					continue;
				case 5u:
					output.WriteRawTag(13);
					output.WriteFixed32(this.Region);
					arg_79_0 = (num * 1634156165u ^ 608345030u);
					continue;
				}
				break;
			}
			return;
			IL_6F:
			arg_79_0 = 1771703303u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.Tag != 0u) ? 886134321u : 876269214u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.Region != 0u)
			{
				goto IL_3F;
			}
			goto IL_75;
			uint arg_49_0;
			while (true)
			{
				IL_44:
				uint num2;
				switch ((num2 = (arg_49_0 ^ 1013190539u)) % 5u)
				{
				case 0u:
					goto IL_3F;
				case 1u:
					num += 5;
					arg_49_0 = (num2 * 3370250133u ^ 3525720103u);
					continue;
				case 2u:
					goto IL_75;
				case 3u:
					num += 5;
					arg_49_0 = (num2 * 3681935504u ^ 641222474u);
					continue;
				}
				break;
			}
			return num;
			IL_3F:
			arg_49_0 = 853550776u;
			goto IL_44;
			IL_75:
			arg_49_0 = ((this.Tag == 0u) ? 1203886012u : 704993764u);
			goto IL_44;
		}

		public void MergeFrom(RegionTag other)
		{
			if (other == null)
			{
				goto IL_30;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 2406882994u)) % 7u)
				{
				case 0u:
					arg_76_0 = ((other.Tag == 0u) ? 3481701740u : 4189816713u);
					continue;
				case 1u:
					goto IL_AD;
				case 2u:
					this.Tag = other.Tag;
					arg_76_0 = (num * 17163898u ^ 1095468402u);
					continue;
				case 4u:
					goto IL_30;
				case 5u:
					return;
				case 6u:
					this.Region = other.Region;
					arg_76_0 = (num * 3739087552u ^ 439980076u);
					continue;
				}
				break;
			}
			return;
			IL_30:
			arg_76_0 = 3282156175u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.Region == 0u) ? 3764588524u : 2701158191u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_EE:
				uint num;
				uint arg_AE_0 = ((num = input.ReadTag()) == 0u) ? 1714563902u : 1671751132u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AE_0 ^ 353205341u)) % 9u)
					{
					case 0u:
						arg_AE_0 = (num2 * 1151550331u ^ 1068208598u);
						continue;
					case 1u:
						this.Region = input.ReadFixed32();
						arg_AE_0 = 1569786575u;
						continue;
					case 2u:
						arg_AE_0 = 1671751132u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_AE_0 = (num2 * 3273717224u ^ 1824099528u);
						continue;
					case 5u:
						this.Tag = input.ReadFixed32();
						arg_AE_0 = 578863088u;
						continue;
					case 6u:
						goto IL_EE;
					case 7u:
						arg_AE_0 = (((num == 21u) ? 203988571u : 1187894249u) ^ num2 * 1392072753u);
						continue;
					case 8u:
						arg_AE_0 = ((num == 13u) ? 774502907u : 244410282u);
						continue;
					}
					return;
				}
			}
		}
	}
}
