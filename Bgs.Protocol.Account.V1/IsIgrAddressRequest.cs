using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class IsIgrAddressRequest : IMessage<IsIgrAddressRequest>, IEquatable<IsIgrAddressRequest>, IDeepCloneable<IsIgrAddressRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly IsIgrAddressRequest.__c __9 = new IsIgrAddressRequest.__c();

			internal IsIgrAddressRequest cctor>b__29_0()
			{
				return new IsIgrAddressRequest();
			}
		}

		private static readonly MessageParser<IsIgrAddressRequest> _parser = new MessageParser<IsIgrAddressRequest>(new Func<IsIgrAddressRequest>(IsIgrAddressRequest.__c.__9.<.cctor>b__29_0));

		public const int ClientAddressFieldNumber = 1;

		private string clientAddress_ = "";

		public const int RegionFieldNumber = 2;

		private uint region_;

		public static MessageParser<IsIgrAddressRequest> Parser
		{
			get
			{
				return IsIgrAddressRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IsIgrAddressRequest.Descriptor;
			}
		}

		public string ClientAddress
		{
			get
			{
				return this.clientAddress_;
			}
			set
			{
				this.clientAddress_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
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

		public IsIgrAddressRequest()
		{
		}

		public IsIgrAddressRequest(IsIgrAddressRequest other) : this()
		{
			this.clientAddress_ = other.clientAddress_;
			this.region_ = other.region_;
		}

		public IsIgrAddressRequest Clone()
		{
			return new IsIgrAddressRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as IsIgrAddressRequest);
		}

		public bool Equals(IsIgrAddressRequest other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 816326458) % 9)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_72_0 = ((this.Region == other.Region) ? 1049984152 : 1004632356);
					continue;
				case 3:
					goto IL_41;
				case 5:
					return true;
				case 6:
					goto IL_B0;
				case 7:
					return false;
				case 8:
					arg_72_0 = ((!IsIgrAddressRequest.smethod_0(this.ClientAddress, other.ClientAddress)) ? 421543149 : 1722143118);
					continue;
				}
				break;
			}
			return true;
			IL_41:
			arg_72_0 = 1367242488;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? 908261161 : 486270685);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_BA:
				uint arg_96_0 = 614106848u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_96_0 ^ 70404347u)) % 6u)
					{
					case 0u:
						num ^= this.Region.GetHashCode();
						arg_96_0 = (num2 * 3676315284u ^ 1549058859u);
						continue;
					case 1u:
						arg_96_0 = (((IsIgrAddressRequest.smethod_1(this.ClientAddress) == 0) ? 578998288u : 1303510630u) ^ num2 * 3801880702u);
						continue;
					case 2u:
						goto IL_BA;
					case 3u:
						num ^= IsIgrAddressRequest.smethod_2(this.ClientAddress);
						arg_96_0 = (num2 * 2971036550u ^ 3209400016u);
						continue;
					case 5u:
						arg_96_0 = ((this.Region == 0u) ? 194225411u : 491832761u);
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
			if (IsIgrAddressRequest.smethod_1(this.ClientAddress) != 0)
			{
				goto IL_1F;
			}
			goto IL_C4;
			uint arg_8D_0;
			while (true)
			{
				IL_88:
				uint num;
				switch ((num = (arg_8D_0 ^ 2171559202u)) % 7u)
				{
				case 0u:
					output.WriteString(this.ClientAddress);
					arg_8D_0 = (num * 3368510034u ^ 1672123184u);
					continue;
				case 2u:
					output.WriteUInt32(this.Region);
					arg_8D_0 = (num * 3650834977u ^ 76326339u);
					continue;
				case 3u:
					output.WriteRawTag(10);
					arg_8D_0 = (num * 707914348u ^ 1750200029u);
					continue;
				case 4u:
					output.WriteRawTag(16);
					arg_8D_0 = (num * 3960858283u ^ 409347412u);
					continue;
				case 5u:
					goto IL_1F;
				case 6u:
					goto IL_C4;
				}
				break;
			}
			return;
			IL_1F:
			arg_8D_0 = 3373646032u;
			goto IL_88;
			IL_C4:
			arg_8D_0 = ((this.Region == 0u) ? 3198256497u : 2812014382u);
			goto IL_88;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (IsIgrAddressRequest.smethod_1(this.ClientAddress) != 0)
			{
				goto IL_21;
			}
			goto IL_95;
			uint arg_69_0;
			while (true)
			{
				IL_64:
				uint num2;
				switch ((num2 = (arg_69_0 ^ 553539060u)) % 5u)
				{
				case 1u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.ClientAddress);
					arg_69_0 = (num2 * 8881765u ^ 3201558081u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
					arg_69_0 = (num2 * 3234794535u ^ 618206016u);
					continue;
				case 3u:
					goto IL_21;
				case 4u:
					goto IL_95;
				}
				break;
			}
			return num;
			IL_21:
			arg_69_0 = 1688216468u;
			goto IL_64;
			IL_95:
			arg_69_0 = ((this.Region != 0u) ? 951508745u : 419240907u);
			goto IL_64;
		}

		public void MergeFrom(IsIgrAddressRequest other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 1613970865u)) % 7u)
				{
				case 0u:
					arg_76_0 = ((other.Region != 0u) ? 736813057u : 1104544137u);
					continue;
				case 1u:
					this.Region = other.Region;
					arg_76_0 = (num * 2846843874u ^ 3015099625u);
					continue;
				case 2u:
					this.ClientAddress = other.ClientAddress;
					arg_76_0 = (num * 88933861u ^ 2391957712u);
					continue;
				case 4u:
					goto IL_AD;
				case 5u:
					return;
				case 6u:
					goto IL_15;
				}
				break;
			}
			return;
			IL_15:
			arg_76_0 = 2056009587u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((IsIgrAddressRequest.smethod_1(other.ClientAddress) != 0) ? 607036875u : 1337436146u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F1:
				uint num;
				uint arg_B1_0 = ((num = input.ReadTag()) != 0u) ? 4107077161u : 2828485679u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B1_0 ^ 3886977065u)) % 9u)
					{
					case 1u:
						this.ClientAddress = input.ReadString();
						arg_B1_0 = 2749357191u;
						continue;
					case 2u:
						arg_B1_0 = (((num == 16u) ? 1726669423u : 795115297u) ^ num2 * 273259550u);
						continue;
					case 3u:
						this.Region = input.ReadUInt32();
						arg_B1_0 = 2749357191u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_B1_0 = (num2 * 1292808870u ^ 1863896776u);
						continue;
					case 5u:
						goto IL_F1;
					case 6u:
						arg_B1_0 = (num2 * 1706036928u ^ 2082963527u);
						continue;
					case 7u:
						arg_B1_0 = ((num != 10u) ? 3095941431u : 4057931859u);
						continue;
					case 8u:
						arg_B1_0 = 4107077161u;
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

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
