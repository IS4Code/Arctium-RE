using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class ContentHandle : IMessage<ContentHandle>, IEquatable<ContentHandle>, IDeepCloneable<ContentHandle>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ContentHandle.__c __9 = new ContentHandle.__c();

			internal ContentHandle cctor>b__39_0()
			{
				return new ContentHandle();
			}
		}

		private static readonly MessageParser<ContentHandle> _parser = new MessageParser<ContentHandle>(new Func<ContentHandle>(ContentHandle.__c.__9.<.cctor>b__39_0));

		public const int RegionFieldNumber = 1;

		private uint region_;

		public const int UsageFieldNumber = 2;

		private uint usage_;

		public const int HashFieldNumber = 3;

		private ByteString hash_ = ByteString.Empty;

		public const int ProtoUrlFieldNumber = 4;

		private string protoUrl_ = "";

		public static MessageParser<ContentHandle> Parser
		{
			get
			{
				return ContentHandle._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentHandleTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentHandle.Descriptor;
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

		public uint Usage
		{
			get
			{
				return this.usage_;
			}
			set
			{
				this.usage_ = value;
			}
		}

		public ByteString Hash
		{
			get
			{
				return this.hash_;
			}
			set
			{
				this.hash_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_36<string>(1095253436u));
			}
		}

		public string ProtoUrl
		{
			get
			{
				return this.protoUrl_;
			}
			set
			{
				this.protoUrl_ = Preconditions.CheckNotNull<string>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public ContentHandle()
		{
		}

		public ContentHandle(ContentHandle other) : this()
		{
			this.region_ = other.region_;
			this.usage_ = other.usage_;
			this.hash_ = other.hash_;
			this.protoUrl_ = other.protoUrl_;
		}

		public ContentHandle Clone()
		{
			return new ContentHandle(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ContentHandle);
		}

		public bool Equals(ContentHandle other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_116;
			int arg_C8_0;
			while (true)
			{
				IL_C3:
				switch ((arg_C8_0 ^ -1671093463) % 13)
				{
				case 0:
					arg_C8_0 = ((this.Usage != other.Usage) ? -1265670296 : -1620689695);
					continue;
				case 1:
					arg_C8_0 = ((this.Region != other.Region) ? -194907944 : -500464743);
					continue;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					return false;
				case 6:
					arg_C8_0 = (ContentHandle.smethod_0(this.ProtoUrl, other.ProtoUrl) ? -1279912574 : -100222763);
					continue;
				case 7:
					return false;
				case 8:
					goto IL_44;
				case 9:
					return true;
				case 10:
					arg_C8_0 = ((this.Hash != other.Hash) ? -1977153278 : -204270641);
					continue;
				case 11:
					return false;
				case 12:
					goto IL_116;
				}
				break;
			}
			return true;
			IL_44:
			arg_C8_0 = -420366030;
			goto IL_C3;
			IL_116:
			arg_C8_0 = ((other != this) ? -1213475696 : -64876340);
			goto IL_C3;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ this.Region.GetHashCode();
			while (true)
			{
				IL_C7:
				uint arg_A3_0 = 1646517667u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A3_0 ^ 317921148u)) % 6u)
					{
					case 0u:
						num ^= this.ProtoUrl.GetHashCode();
						arg_A3_0 = (num2 * 3227089615u ^ 3203910007u);
						continue;
					case 1u:
						num ^= this.Usage.GetHashCode();
						arg_A3_0 = (num2 * 1377244530u ^ 1617096702u);
						continue;
					case 2u:
						num ^= this.Hash.GetHashCode();
						arg_A3_0 = (num2 * 3250719977u ^ 3329739869u);
						continue;
					case 3u:
						arg_A3_0 = (((this.ProtoUrl.Length != 0) ? 3609755830u : 2322032005u) ^ num2 * 294078350u);
						continue;
					case 4u:
						goto IL_C7;
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
			output.WriteRawTag(13);
			while (true)
			{
				IL_103:
				uint arg_D7_0 = 1324987083u;
				while (true)
				{
					uint num;
					switch ((num = (arg_D7_0 ^ 158427908u)) % 8u)
					{
					case 0u:
						output.WriteBytes(this.Hash);
						arg_D7_0 = (((ContentHandle.smethod_1(this.ProtoUrl) != 0) ? 2165241805u : 2910461791u) ^ num * 3006757172u);
						continue;
					case 1u:
						output.WriteRawTag(34);
						arg_D7_0 = (num * 27807896u ^ 2316960824u);
						continue;
					case 2u:
						goto IL_103;
					case 4u:
						output.WriteString(this.ProtoUrl);
						arg_D7_0 = (num * 1614975717u ^ 1595522571u);
						continue;
					case 5u:
						output.WriteRawTag(26);
						arg_D7_0 = (num * 2628973845u ^ 200440045u);
						continue;
					case 6u:
						output.WriteFixed32(this.Usage);
						arg_D7_0 = (num * 1900679743u ^ 1163813803u);
						continue;
					case 7u:
						output.WriteFixed32(this.Region);
						output.WriteRawTag(21);
						arg_D7_0 = (num * 2328750940u ^ 52848782u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 10 + (1 + CodedOutputStream.ComputeBytesSize(this.Hash));
			if (ContentHandle.smethod_1(this.ProtoUrl) != 0)
			{
				while (true)
				{
					IL_61:
					uint arg_49_0 = 82695887u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_49_0 ^ 2090860883u)) % 3u)
						{
						case 0u:
							goto IL_61;
						case 1u:
							num += 1 + CodedOutputStream.ComputeStringSize(this.ProtoUrl);
							arg_49_0 = (num2 * 3787526208u ^ 2883850405u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(ContentHandle other)
		{
			if (other == null)
			{
				goto IL_65;
			}
			goto IL_14C;
			uint arg_104_0;
			while (true)
			{
				IL_FF:
				uint num;
				switch ((num = (arg_104_0 ^ 2811611724u)) % 11u)
				{
				case 0u:
					this.Region = other.Region;
					arg_104_0 = (num * 2919997010u ^ 839007443u);
					continue;
				case 1u:
					this.Usage = other.Usage;
					arg_104_0 = (num * 4112545442u ^ 887999064u);
					continue;
				case 2u:
					goto IL_14C;
				case 4u:
					this.Hash = other.Hash;
					arg_104_0 = (num * 1409846633u ^ 1569898026u);
					continue;
				case 5u:
					this.ProtoUrl = other.ProtoUrl;
					arg_104_0 = (num * 1883110423u ^ 1414102517u);
					continue;
				case 6u:
					arg_104_0 = ((ContentHandle.smethod_1(other.ProtoUrl) != 0) ? 4033790444u : 2555836053u);
					continue;
				case 7u:
					return;
				case 8u:
					goto IL_65;
				case 9u:
					arg_104_0 = ((other.Usage == 0u) ? 3905424246u : 4193376555u);
					continue;
				case 10u:
					arg_104_0 = ((other.Hash.Length == 0) ? 4230674379u : 3942972405u);
					continue;
				}
				break;
			}
			return;
			IL_65:
			arg_104_0 = 4029834591u;
			goto IL_FF;
			IL_14C:
			arg_104_0 = ((other.Region != 0u) ? 4140907085u : 2688696961u);
			goto IL_FF;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1DB:
				uint num;
				uint arg_17B_0 = ((num = input.ReadTag()) == 0u) ? 2494375871u : 3586499333u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_17B_0 ^ 2664115468u)) % 17u)
					{
					case 0u:
						arg_17B_0 = (num2 * 3314211520u ^ 2186776925u);
						continue;
					case 1u:
						input.SkipLastField();
						arg_17B_0 = 2299855128u;
						continue;
					case 2u:
						arg_17B_0 = ((num <= 21u) ? 2872680410u : 4243253880u);
						continue;
					case 3u:
						goto IL_1DB;
					case 4u:
						arg_17B_0 = ((num == 26u) ? 4112320615u : 2595459321u);
						continue;
					case 5u:
						this.ProtoUrl = input.ReadString();
						arg_17B_0 = 2299855128u;
						continue;
					case 6u:
						this.Hash = input.ReadBytes();
						arg_17B_0 = 3034558808u;
						continue;
					case 7u:
						arg_17B_0 = (((num != 13u) ? 3894968277u : 4163347591u) ^ num2 * 275449569u);
						continue;
					case 8u:
						arg_17B_0 = (((num != 21u) ? 2607366308u : 2472069547u) ^ num2 * 2578476141u);
						continue;
					case 9u:
						arg_17B_0 = 3586499333u;
						continue;
					case 10u:
						this.Region = input.ReadFixed32();
						arg_17B_0 = 3219908427u;
						continue;
					case 11u:
						arg_17B_0 = (num2 * 1795491597u ^ 2785393331u);
						continue;
					case 13u:
						arg_17B_0 = (num2 * 3955093413u ^ 1781149500u);
						continue;
					case 14u:
						arg_17B_0 = (((num != 34u) ? 3529620521u : 3477737914u) ^ num2 * 4035144164u);
						continue;
					case 15u:
						arg_17B_0 = (num2 * 2328630830u ^ 2999940058u);
						continue;
					case 16u:
						this.Usage = input.ReadFixed32();
						arg_17B_0 = 3467653787u;
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}
	}
}
