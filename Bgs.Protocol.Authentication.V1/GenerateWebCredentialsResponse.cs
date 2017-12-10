using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class GenerateWebCredentialsResponse : IMessage<GenerateWebCredentialsResponse>, IEquatable<GenerateWebCredentialsResponse>, IDeepCloneable<GenerateWebCredentialsResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GenerateWebCredentialsResponse.__c __9 = new GenerateWebCredentialsResponse.__c();

			internal GenerateWebCredentialsResponse cctor>b__24_0()
			{
				return new GenerateWebCredentialsResponse();
			}
		}

		private static readonly MessageParser<GenerateWebCredentialsResponse> _parser = new MessageParser<GenerateWebCredentialsResponse>(new Func<GenerateWebCredentialsResponse>(GenerateWebCredentialsResponse.__c.__9.<.cctor>b__24_0));

		public const int WebCredentialsFieldNumber = 1;

		private ByteString webCredentials_ = ByteString.Empty;

		public static MessageParser<GenerateWebCredentialsResponse> Parser
		{
			get
			{
				return GenerateWebCredentialsResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[18];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateWebCredentialsResponse.Descriptor;
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
				this.webCredentials_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public GenerateWebCredentialsResponse()
		{
		}

		public GenerateWebCredentialsResponse(GenerateWebCredentialsResponse other) : this()
		{
			this.webCredentials_ = other.webCredentials_;
		}

		public GenerateWebCredentialsResponse Clone()
		{
			return new GenerateWebCredentialsResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateWebCredentialsResponse);
		}

		public bool Equals(GenerateWebCredentialsResponse other)
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
				switch ((arg_48_0 ^ 390038090) % 7)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					goto IL_3E;
				case 4:
					goto IL_7A;
				case 5:
					return true;
				case 6:
					arg_48_0 = ((this.WebCredentials != other.WebCredentials) ? 1871395720 : 1946837890);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 951587411;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? 769288373 : 1564236285);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.WebCredentials.Length != 0)
			{
				while (true)
				{
					IL_49:
					uint arg_31_0 = 4184708911u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_31_0 ^ 3278268101u)) % 3u)
						{
						case 1u:
							num ^= GenerateWebCredentialsResponse.smethod_0(this.WebCredentials);
							arg_31_0 = (num2 * 552303463u ^ 2592292392u);
							continue;
						case 2u:
							goto IL_49;
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
			if (this.WebCredentials.Length != 0)
			{
				while (true)
				{
					IL_60:
					uint arg_44_0 = 1934204955u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 1166289056u)) % 4u)
						{
						case 0u:
							goto IL_60;
						case 2u:
							output.WriteBytes(this.WebCredentials);
							arg_44_0 = (num * 2856215288u ^ 1297170657u);
							continue;
						case 3u:
							output.WriteRawTag(10);
							arg_44_0 = (num * 2110255802u ^ 4164109012u);
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
				uint arg_54_0 = 2460405954u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_54_0 ^ 3479425860u)) % 4u)
					{
					case 1u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.WebCredentials);
						arg_54_0 = (num2 * 890090339u ^ 2293980595u);
						continue;
					case 2u:
						arg_54_0 = (((this.WebCredentials.Length != 0) ? 1836870445u : 884845336u) ^ num2 * 225803012u);
						continue;
					case 3u:
						goto IL_70;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GenerateWebCredentialsResponse other)
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
				switch ((num = (arg_37_0 ^ 1236201053u)) % 5u)
				{
				case 1u:
					this.WebCredentials = other.WebCredentials;
					arg_37_0 = (num * 1400486173u ^ 2516299209u);
					continue;
				case 2u:
					return;
				case 3u:
					goto IL_63;
				case 4u:
					goto IL_12;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 1314660307u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.WebCredentials.Length == 0) ? 33053142u : 430716726u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_96:
				uint num;
				uint arg_63_0 = ((num = input.ReadTag()) == 0u) ? 2722622081u : 2152692116u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_63_0 ^ 4156911478u)) % 6u)
					{
					case 0u:
						input.SkipLastField();
						arg_63_0 = (num2 * 3451447486u ^ 2645441947u);
						continue;
					case 2u:
						arg_63_0 = 2152692116u;
						continue;
					case 3u:
						this.WebCredentials = input.ReadBytes();
						arg_63_0 = 2169360419u;
						continue;
					case 4u:
						arg_63_0 = ((num != 10u) ? 3520444882u : 2863973763u);
						continue;
					case 5u:
						goto IL_96;
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
