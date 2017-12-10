using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class ClientInfo : IMessage<ClientInfo>, IEquatable<ClientInfo>, IDeepCloneable<ClientInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ClientInfo.__c __9 = new ClientInfo.__c();

			internal ClientInfo cctor>b__29_0()
			{
				return new ClientInfo();
			}
		}

		private static readonly MessageParser<ClientInfo> _parser = new MessageParser<ClientInfo>(new Func<ClientInfo>(ClientInfo.__c.__9.<.cctor>b__29_0));

		public const int ClientAddressFieldNumber = 1;

		private string clientAddress_ = "";

		public const int PrivilegedNetworkFieldNumber = 2;

		private bool privilegedNetwork_;

		public static MessageParser<ClientInfo> Parser
		{
			get
			{
				return ClientInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientInfo.Descriptor;
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

		public bool PrivilegedNetwork
		{
			get
			{
				return this.privilegedNetwork_;
			}
			set
			{
				this.privilegedNetwork_ = value;
			}
		}

		public ClientInfo()
		{
		}

		public ClientInfo(ClientInfo other) : this()
		{
			this.clientAddress_ = other.clientAddress_;
			this.privilegedNetwork_ = other.privilegedNetwork_;
		}

		public ClientInfo Clone()
		{
			return new ClientInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ClientInfo);
		}

		public bool Equals(ClientInfo other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 1514667057) % 9)
				{
				case 0:
					arg_72_0 = (ClientInfo.smethod_0(this.ClientAddress, other.ClientAddress) ? 1289140314 : 992735732);
					continue;
				case 1:
					goto IL_B0;
				case 3:
					return false;
				case 4:
					arg_72_0 = ((this.PrivilegedNetwork != other.PrivilegedNetwork) ? 1592151054 : 1631885719);
					continue;
				case 5:
					return true;
				case 6:
					goto IL_15;
				case 7:
					return false;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 1657040522;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? 1143072667 : 755870066);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_BA:
				uint arg_96_0 = 1823374571u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_96_0 ^ 1321231823u)) % 6u)
					{
					case 0u:
						arg_96_0 = ((!this.PrivilegedNetwork) ? 207524005u : 1086297652u);
						continue;
					case 1u:
						num ^= ClientInfo.smethod_2(this.ClientAddress);
						arg_96_0 = (num2 * 2043642343u ^ 807606238u);
						continue;
					case 3u:
						goto IL_BA;
					case 4u:
						arg_96_0 = (((ClientInfo.smethod_1(this.ClientAddress) == 0) ? 2177702765u : 2515048394u) ^ num2 * 1321300658u);
						continue;
					case 5u:
						num ^= this.PrivilegedNetwork.GetHashCode();
						arg_96_0 = (num2 * 1899890417u ^ 2343043566u);
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
			if (ClientInfo.smethod_1(this.ClientAddress) != 0)
			{
				goto IL_1F;
			}
			goto IL_B1;
			uint arg_7E_0;
			while (true)
			{
				IL_79:
				uint num;
				switch ((num = (arg_7E_0 ^ 1938423419u)) % 6u)
				{
				case 0u:
					goto IL_B1;
				case 1u:
					output.WriteRawTag(16);
					output.WriteBool(this.PrivilegedNetwork);
					arg_7E_0 = (num * 2766376552u ^ 893404676u);
					continue;
				case 2u:
					output.WriteString(this.ClientAddress);
					arg_7E_0 = (num * 3495520935u ^ 4176448973u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					arg_7E_0 = (num * 2816689618u ^ 1823954087u);
					continue;
				case 5u:
					goto IL_1F;
				}
				break;
			}
			return;
			IL_1F:
			arg_7E_0 = 1112956587u;
			goto IL_79;
			IL_B1:
			arg_7E_0 = (this.PrivilegedNetwork ? 1272861666u : 1305748012u);
			goto IL_79;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_AF:
				uint arg_8B_0 = 1342505967u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_8B_0 ^ 24834948u)) % 6u)
					{
					case 0u:
						num += 2;
						arg_8B_0 = (num2 * 2419191727u ^ 99368886u);
						continue;
					case 1u:
						arg_8B_0 = (this.PrivilegedNetwork ? 1890929270u : 1996961240u);
						continue;
					case 3u:
						arg_8B_0 = (((ClientInfo.smethod_1(this.ClientAddress) == 0) ? 3309154074u : 3061107233u) ^ num2 * 2924625883u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.ClientAddress);
						arg_8B_0 = (num2 * 3038495357u ^ 840101359u);
						continue;
					case 5u:
						goto IL_AF;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ClientInfo other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 3568210730u)) % 7u)
				{
				case 0u:
					goto IL_6C;
				case 1u:
					this.PrivilegedNetwork = other.PrivilegedNetwork;
					arg_76_0 = (num * 1042289466u ^ 3457584430u);
					continue;
				case 2u:
					return;
				case 4u:
					this.ClientAddress = other.ClientAddress;
					arg_76_0 = (num * 3636611980u ^ 2163706387u);
					continue;
				case 5u:
					arg_76_0 = (other.PrivilegedNetwork ? 3978792791u : 3319477884u);
					continue;
				case 6u:
					goto IL_AD;
				}
				break;
			}
			return;
			IL_6C:
			arg_76_0 = 2344942335u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((ClientInfo.smethod_1(other.ClientAddress) == 0) ? 3080997827u : 2412380374u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_101:
				uint num;
				uint arg_BD_0 = ((num = input.ReadTag()) != 0u) ? 3626875460u : 2974083244u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_BD_0 ^ 3105662621u)) % 10u)
					{
					case 0u:
						goto IL_101;
					case 1u:
						arg_BD_0 = ((num != 10u) ? 4097903230u : 3981918152u);
						continue;
					case 2u:
						arg_BD_0 = (num2 * 2884474460u ^ 392941161u);
						continue;
					case 4u:
						arg_BD_0 = (num2 * 2812153409u ^ 445760985u);
						continue;
					case 5u:
						arg_BD_0 = 3626875460u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_BD_0 = (num2 * 290076299u ^ 1242981091u);
						continue;
					case 7u:
						this.ClientAddress = input.ReadString();
						arg_BD_0 = 3421214075u;
						continue;
					case 8u:
						this.PrivilegedNetwork = input.ReadBool();
						arg_BD_0 = 3225855169u;
						continue;
					case 9u:
						arg_BD_0 = (((num == 16u) ? 2084529400u : 437404722u) ^ num2 * 519018431u);
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
