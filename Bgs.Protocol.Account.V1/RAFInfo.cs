using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class RAFInfo : IMessage<RAFInfo>, IEquatable<RAFInfo>, IDeepCloneable<RAFInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly RAFInfo.__c __9 = new RAFInfo.__c();

			internal RAFInfo cctor>b__24_0()
			{
				return new RAFInfo();
			}
		}

		private static readonly MessageParser<RAFInfo> _parser = new MessageParser<RAFInfo>(new Func<RAFInfo>(RAFInfo.__c.__9.<.cctor>b__24_0));

		public const int RafInfoFieldNumber = 1;

		private ByteString rafInfo_ = ByteString.Empty;

		public static MessageParser<RAFInfo> Parser
		{
			get
			{
				return RAFInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[25];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RAFInfo.Descriptor;
			}
		}

		public ByteString RafInfo
		{
			get
			{
				return this.rafInfo_;
			}
			set
			{
				this.rafInfo_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public RAFInfo()
		{
		}

		public RAFInfo(RAFInfo other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 1677394260u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 862971313u)) % 3u)
					{
					case 1u:
						this.rafInfo_ = other.rafInfo_;
						arg_26_0 = (num * 1529210122u ^ 3878197999u);
						continue;
					case 2u:
						goto IL_3E;
					}
					return;
				}
			}
		}

		public RAFInfo Clone()
		{
			return new RAFInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as RAFInfo);
		}

		public bool Equals(RAFInfo other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -573111891) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					goto IL_7A;
				case 4:
					arg_48_0 = ((this.RafInfo != other.RafInfo) ? -1823597647 : -441223242);
					continue;
				case 5:
					return false;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -439630878;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -765409213 : -1857775928);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6E:
				uint arg_52_0 = 1049827981u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_52_0 ^ 1312806648u)) % 4u)
					{
					case 0u:
						goto IL_6E;
					case 1u:
						arg_52_0 = (((this.RafInfo.Length != 0) ? 2163283420u : 3387448601u) ^ num2 * 2581042367u);
						continue;
					case 3u:
						num ^= RAFInfo.smethod_0(this.RafInfo);
						arg_52_0 = (num2 * 3753509674u ^ 880764260u);
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
			if (this.RafInfo.Length != 0)
			{
				while (true)
				{
					IL_60:
					uint arg_44_0 = 124295519u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 60625605u)) % 4u)
						{
						case 0u:
							goto IL_60;
						case 1u:
							output.WriteBytes(this.RafInfo);
							arg_44_0 = (num * 3538354654u ^ 1530580632u);
							continue;
						case 2u:
							output.WriteRawTag(10);
							arg_44_0 = (num * 1923166352u ^ 185832140u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.RafInfo.Length != 0)
			{
				while (true)
				{
					IL_4B:
					uint arg_33_0 = 4031944765u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_33_0 ^ 2646041817u)) % 3u)
						{
						case 0u:
							goto IL_4B;
						case 2u:
							num += 1 + CodedOutputStream.ComputeBytesSize(this.RafInfo);
							arg_33_0 = (num2 * 1755022136u ^ 4179259230u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(RAFInfo other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 411047518u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 2u:
					return;
				case 3u:
					this.RafInfo = other.RafInfo;
					arg_37_0 = (num * 1158816308u ^ 3279051318u);
					continue;
				case 4u:
					goto IL_63;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 1698975626u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.RafInfo.Length != 0) ? 949926875u : 1725084466u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) != 0u) ? 1797436250u : 15420157u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 641252932u)) % 7u)
					{
					case 0u:
						arg_72_0 = (num2 * 779833701u ^ 3226662939u);
						continue;
					case 1u:
						arg_72_0 = ((num == 10u) ? 1986592893u : 620662148u);
						continue;
					case 2u:
						this.RafInfo = input.ReadBytes();
						arg_72_0 = 1827696307u;
						continue;
					case 3u:
						input.SkipLastField();
						arg_72_0 = (num2 * 1616031503u ^ 1834292108u);
						continue;
					case 5u:
						arg_72_0 = 1797436250u;
						continue;
					case 6u:
						goto IL_A9;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
