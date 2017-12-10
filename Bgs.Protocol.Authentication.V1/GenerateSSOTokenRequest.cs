using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class GenerateSSOTokenRequest : IMessage<GenerateSSOTokenRequest>, IEquatable<GenerateSSOTokenRequest>, IDeepCloneable<GenerateSSOTokenRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GenerateSSOTokenRequest.__c __9 = new GenerateSSOTokenRequest.__c();

			internal GenerateSSOTokenRequest cctor>b__24_0()
			{
				return new GenerateSSOTokenRequest();
			}
		}

		private static readonly MessageParser<GenerateSSOTokenRequest> _parser = new MessageParser<GenerateSSOTokenRequest>(new Func<GenerateSSOTokenRequest>(GenerateSSOTokenRequest.__c.__9.<.cctor>b__24_0));

		public const int ProgramFieldNumber = 1;

		private uint program_;

		public static MessageParser<GenerateSSOTokenRequest> Parser
		{
			get
			{
				return GenerateSSOTokenRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateSSOTokenRequest.Descriptor;
			}
		}

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public GenerateSSOTokenRequest()
		{
		}

		public GenerateSSOTokenRequest(GenerateSSOTokenRequest other) : this()
		{
			this.program_ = other.program_;
		}

		public GenerateSSOTokenRequest Clone()
		{
			return new GenerateSSOTokenRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateSSOTokenRequest);
		}

		public bool Equals(GenerateSSOTokenRequest other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_75;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ -1275165716) % 7)
				{
				case 0:
					return true;
				case 1:
					arg_43_0 = ((this.Program != other.Program) ? -1987812633 : -200213621);
					continue;
				case 2:
					return false;
				case 4:
					return false;
				case 5:
					goto IL_12;
				case 6:
					goto IL_75;
				}
				break;
			}
			return true;
			IL_12:
			arg_43_0 = -1040701084;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other != this) ? -1521840506 : -136605471);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.Program != 0u)
			{
				while (true)
				{
					IL_47:
					uint arg_2F_0 = 1860917957u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2F_0 ^ 538091679u)) % 3u)
						{
						case 1u:
							num ^= this.Program.GetHashCode();
							arg_2F_0 = (num2 * 3786351374u ^ 2741696901u);
							continue;
						case 2u:
							goto IL_47;
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
			if (this.Program != 0u)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 2213573352u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 4294128651u)) % 4u)
						{
						case 0u:
							goto IL_5B;
						case 2u:
							output.WriteFixed32(this.Program);
							arg_3F_0 = (num * 56726962u ^ 2051532810u);
							continue;
						case 3u:
							output.WriteRawTag(13);
							arg_3F_0 = (num * 2053929231u ^ 346099904u);
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
				IL_5F:
				uint arg_43_0 = 798303787u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_43_0 ^ 1612425020u)) % 4u)
					{
					case 0u:
						goto IL_5F;
					case 1u:
						num += 5;
						arg_43_0 = (num2 * 1145366114u ^ 412865576u);
						continue;
					case 3u:
						arg_43_0 = (((this.Program != 0u) ? 117372836u : 417435263u) ^ num2 * 3060199691u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GenerateSSOTokenRequest other)
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
				switch ((num = (arg_37_0 ^ 1827500747u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					this.Program = other.Program;
					arg_37_0 = (num * 4283363807u ^ 3093159457u);
					continue;
				case 2u:
					goto IL_63;
				case 3u:
					return;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 170877745u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Program != 0u) ? 1766887932u : 2135715272u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_96:
				uint num;
				uint arg_63_0 = ((num = input.ReadTag()) == 0u) ? 1141907951u : 292980050u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_63_0 ^ 2040627655u)) % 6u)
					{
					case 1u:
						arg_63_0 = ((num == 13u) ? 1768904221u : 1869738644u);
						continue;
					case 2u:
						arg_63_0 = 292980050u;
						continue;
					case 3u:
						goto IL_96;
					case 4u:
						this.Program = input.ReadFixed32();
						arg_63_0 = 1320017830u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_63_0 = (num2 * 3010013274u ^ 2750766216u);
						continue;
					}
					return;
				}
			}
		}
	}
}
