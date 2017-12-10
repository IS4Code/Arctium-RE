using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class VerifyWebCredentialsRequest : IMessage<VerifyWebCredentialsRequest>, IEquatable<VerifyWebCredentialsRequest>, IDeepCloneable<VerifyWebCredentialsRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly VerifyWebCredentialsRequest.__c __9 = new VerifyWebCredentialsRequest.__c();

			internal VerifyWebCredentialsRequest cctor>b__24_0()
			{
				return new VerifyWebCredentialsRequest();
			}
		}

		private static readonly MessageParser<VerifyWebCredentialsRequest> _parser = new MessageParser<VerifyWebCredentialsRequest>(new Func<VerifyWebCredentialsRequest>(VerifyWebCredentialsRequest.__c.__9.<.cctor>b__24_0));

		public const int WebCredentialsFieldNumber = 1;

		private ByteString webCredentials_ = ByteString.Empty;

		public static MessageParser<VerifyWebCredentialsRequest> Parser
		{
			get
			{
				return VerifyWebCredentialsRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[19];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VerifyWebCredentialsRequest.Descriptor;
			}
		}

		public ByteString WebCredentials
		{
			get
			{
				return this.webCredentials_;
			}
			set
			{
				this.webCredentials_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_37<string>(2719011704u));
			}
		}

		public VerifyWebCredentialsRequest()
		{
		}

		public VerifyWebCredentialsRequest(VerifyWebCredentialsRequest other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 2121198536u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 1735868047u)) % 3u)
					{
					case 0u:
						goto IL_3E;
					case 1u:
						this.webCredentials_ = other.webCredentials_;
						arg_26_0 = (num * 3879575880u ^ 2103906623u);
						continue;
					}
					return;
				}
			}
		}

		public VerifyWebCredentialsRequest Clone()
		{
			return new VerifyWebCredentialsRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as VerifyWebCredentialsRequest);
		}

		public bool Equals(VerifyWebCredentialsRequest other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -433815543) % 7)
				{
				case 0:
					arg_48_0 = ((!(this.WebCredentials != other.WebCredentials)) ? -726851445 : -1934092721);
					continue;
				case 1:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_12;
				case 5:
					goto IL_7A;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -612538491;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -1134171515 : -690736530);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6E:
				uint arg_52_0 = 4199803091u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_52_0 ^ 4193567702u)) % 4u)
					{
					case 0u:
						num ^= VerifyWebCredentialsRequest.smethod_0(this.WebCredentials);
						arg_52_0 = (num2 * 2423204365u ^ 414480476u);
						continue;
					case 1u:
						arg_52_0 = (((this.WebCredentials.Length == 0) ? 1281775629u : 1617626359u) ^ num2 * 1876382681u);
						continue;
					case 3u:
						goto IL_6E;
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
			if (this.WebCredentials.Length != 0)
			{
				while (true)
				{
					IL_4D:
					uint arg_35_0 = 2518966983u;
					while (true)
					{
						uint num;
						switch ((num = (arg_35_0 ^ 2688069330u)) % 3u)
						{
						case 0u:
							goto IL_4D;
						case 1u:
							output.WriteRawTag(10);
							output.WriteBytes(this.WebCredentials);
							arg_35_0 = (num * 1534716797u ^ 401061091u);
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
			while (true)
			{
				IL_70:
				uint arg_54_0 = 3483324365u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_54_0 ^ 2336970210u)) % 4u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.WebCredentials);
						arg_54_0 = (num2 * 3772662937u ^ 3550292515u);
						continue;
					case 2u:
						goto IL_70;
					case 3u:
						arg_54_0 = (((this.WebCredentials.Length != 0) ? 288833944u : 480495577u) ^ num2 * 2344236374u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(VerifyWebCredentialsRequest other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 264672591u)) % 5u)
				{
				case 0u:
					this.WebCredentials = other.WebCredentials;
					arg_37_0 = (num * 3442778457u ^ 2981769345u);
					continue;
				case 1u:
					return;
				case 3u:
					goto IL_12;
				case 4u:
					goto IL_63;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 28392868u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.WebCredentials.Length == 0) ? 1616404971u : 638623797u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) == 0u) ? 338383156u : 40637341u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 517683580u)) % 7u)
					{
					case 0u:
						goto IL_A9;
					case 1u:
						arg_72_0 = (num2 * 3991535634u ^ 3705156617u);
						continue;
					case 2u:
						this.WebCredentials = input.ReadBytes();
						arg_72_0 = 1785121257u;
						continue;
					case 3u:
						arg_72_0 = ((num == 10u) ? 138579522u : 1899295322u);
						continue;
					case 4u:
						input.SkipLastField();
						arg_72_0 = (num2 * 302699530u ^ 2869050736u);
						continue;
					case 6u:
						arg_72_0 = 40637341u;
						continue;
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
