using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class VersionInfoNotification : IMessage<VersionInfoNotification>, IEquatable<VersionInfoNotification>, IDeepCloneable<VersionInfoNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly VersionInfoNotification.__c __9 = new VersionInfoNotification.__c();

			internal VersionInfoNotification cctor>b__24_0()
			{
				return new VersionInfoNotification();
			}
		}

		private static readonly MessageParser<VersionInfoNotification> _parser = new MessageParser<VersionInfoNotification>(new Func<VersionInfoNotification>(VersionInfoNotification.__c.__9.<.cctor>b__24_0));

		public const int VersionInfoFieldNumber = 1;

		private VersionInfo versionInfo_;

		public static MessageParser<VersionInfoNotification> Parser
		{
			get
			{
				return VersionInfoNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VersionInfoNotification.Descriptor;
			}
		}

		public VersionInfo VersionInfo
		{
			get
			{
				return this.versionInfo_;
			}
			set
			{
				this.versionInfo_ = value;
			}
		}

		public VersionInfoNotification()
		{
		}

		public VersionInfoNotification(VersionInfoNotification other) : this()
		{
			this.VersionInfo = ((other.versionInfo_ != null) ? other.VersionInfo.Clone() : null);
		}

		public VersionInfoNotification Clone()
		{
			return new VersionInfoNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as VersionInfoNotification);
		}

		public bool Equals(VersionInfoNotification other)
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
				switch ((arg_48_0 ^ 1167469064) % 7)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					goto IL_3E;
				case 3:
					return true;
				case 5:
					arg_48_0 = ((!VersionInfoNotification.smethod_0(this.VersionInfo, other.VersionInfo)) ? 862210667 : 1845831180);
					continue;
				case 6:
					goto IL_7A;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 1230994752;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? 1494400148 : 1613179843);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.versionInfo_ != null)
			{
				while (true)
				{
					IL_44:
					uint arg_2C_0 = 2426948142u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2C_0 ^ 3076081472u)) % 3u)
						{
						case 0u:
							goto IL_44;
						case 1u:
							num ^= VersionInfoNotification.smethod_1(this.VersionInfo);
							arg_2C_0 = (num2 * 3158987785u ^ 2581517291u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.versionInfo_ != null)
			{
				while (true)
				{
					IL_48:
					uint arg_30_0 = 847013015u;
					while (true)
					{
						uint num;
						switch ((num = (arg_30_0 ^ 174985753u)) % 3u)
						{
						case 1u:
							output.WriteRawTag(10);
							output.WriteMessage(this.VersionInfo);
							arg_30_0 = (num * 1080055673u ^ 2803612956u);
							continue;
						case 2u:
							goto IL_48;
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
			if (this.versionInfo_ != null)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 495642289u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 523487673u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 2u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.VersionInfo);
							arg_2E_0 = (num2 * 3922857005u ^ 738927983u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(VersionInfoNotification other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 78880585u)) % 7u)
				{
				case 0u:
					this.versionInfo_ = new VersionInfo();
					arg_7A_0 = (num * 857377u ^ 2710529709u);
					continue;
				case 1u:
					goto IL_B1;
				case 2u:
					return;
				case 4u:
					arg_7A_0 = (((this.versionInfo_ != null) ? 3405876083u : 2530409623u) ^ num * 4098217210u);
					continue;
				case 5u:
					goto IL_2D;
				case 6u:
					this.VersionInfo.MergeFrom(other.VersionInfo);
					arg_7A_0 = 1106239674u;
					continue;
				}
				break;
			}
			return;
			IL_2D:
			arg_7A_0 = 108275686u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.versionInfo_ != null) ? 694335642u : 1106239674u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F0:
				uint num;
				uint arg_B0_0 = ((num = input.ReadTag()) != 0u) ? 554392149u : 1389365956u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B0_0 ^ 1440684131u)) % 9u)
					{
					case 1u:
						arg_B0_0 = ((num != 10u) ? 1362983959u : 2136585592u);
						continue;
					case 2u:
						arg_B0_0 = (num2 * 2224310108u ^ 235328371u);
						continue;
					case 3u:
						input.ReadMessage(this.versionInfo_);
						arg_B0_0 = 468882695u;
						continue;
					case 4u:
						goto IL_F0;
					case 5u:
						input.SkipLastField();
						arg_B0_0 = (num2 * 1747288976u ^ 1600976008u);
						continue;
					case 6u:
						arg_B0_0 = 554392149u;
						continue;
					case 7u:
						arg_B0_0 = ((this.versionInfo_ != null) ? 2083508682u : 1184143780u);
						continue;
					case 8u:
						this.versionInfo_ = new VersionInfo();
						arg_B0_0 = (num2 * 1905675317u ^ 921510905u);
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
