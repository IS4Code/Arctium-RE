using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class GenerateWebCredentialsRequest : IMessage<GenerateWebCredentialsRequest>, IEquatable<GenerateWebCredentialsRequest>, IDeepCloneable<GenerateWebCredentialsRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GenerateWebCredentialsRequest.__c __9 = new GenerateWebCredentialsRequest.__c();

			internal GenerateWebCredentialsRequest cctor>b__24_0()
			{
				return new GenerateWebCredentialsRequest();
			}
		}

		private static readonly MessageParser<GenerateWebCredentialsRequest> _parser = new MessageParser<GenerateWebCredentialsRequest>(new Func<GenerateWebCredentialsRequest>(GenerateWebCredentialsRequest.__c.__9.<.cctor>b__24_0));

		public const int ProgramFieldNumber = 1;

		private uint program_;

		public static MessageParser<GenerateWebCredentialsRequest> Parser
		{
			get
			{
				return GenerateWebCredentialsRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[17];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateWebCredentialsRequest.Descriptor;
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

		public GenerateWebCredentialsRequest()
		{
		}

		public GenerateWebCredentialsRequest(GenerateWebCredentialsRequest other) : this()
		{
			this.program_ = other.program_;
		}

		public GenerateWebCredentialsRequest Clone()
		{
			return new GenerateWebCredentialsRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateWebCredentialsRequest);
		}

		public bool Equals(GenerateWebCredentialsRequest other)
		{
			if (other == null)
			{
				goto IL_39;
			}
			goto IL_75;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ -1615798032) % 7)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 3:
					goto IL_39;
				case 4:
					return false;
				case 5:
					arg_43_0 = ((this.Program != other.Program) ? -1438166326 : -416725948);
					continue;
				case 6:
					goto IL_75;
				}
				break;
			}
			return true;
			IL_39:
			arg_43_0 = -828128790;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other == this) ? -2109463340 : -2087183230);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 3788980110u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_50_0 ^ 3245953433u)) % 4u)
					{
					case 0u:
						goto IL_6C;
					case 2u:
						num ^= this.Program.GetHashCode();
						arg_50_0 = (num2 * 3085561070u ^ 1538596476u);
						continue;
					case 3u:
						arg_50_0 = (((this.Program != 0u) ? 995119013u : 1834763358u) ^ num2 * 1034564402u);
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
			if (this.Program != 0u)
			{
				while (true)
				{
					IL_48:
					uint arg_30_0 = 283605157u;
					while (true)
					{
						uint num;
						switch ((num = (arg_30_0 ^ 724870426u)) % 3u)
						{
						case 1u:
							output.WriteRawTag(13);
							output.WriteFixed32(this.Program);
							arg_30_0 = (num * 2372022560u ^ 655928265u);
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
			while (true)
			{
				IL_5F:
				uint arg_43_0 = 2821990665u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_43_0 ^ 2338014012u)) % 4u)
					{
					case 1u:
						arg_43_0 = (((this.Program == 0u) ? 1072200521u : 555987026u) ^ num2 * 1027715937u);
						continue;
					case 2u:
						goto IL_5F;
					case 3u:
						num += 5;
						arg_43_0 = (num2 * 3467335099u ^ 4198026373u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GenerateWebCredentialsRequest other)
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
				switch ((num = (arg_37_0 ^ 3673134615u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 2u:
					return;
				case 3u:
					this.Program = other.Program;
					arg_37_0 = (num * 2689686178u ^ 4094840836u);
					continue;
				case 4u:
					goto IL_63;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 4035903930u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Program != 0u) ? 2914782773u : 3174459776u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_A9:
				uint num;
				uint arg_72_0 = ((num = input.ReadTag()) != 0u) ? 3223745461u : 3690594088u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 3647028001u)) % 7u)
					{
					case 1u:
						arg_72_0 = ((num == 13u) ? 3925968244u : 3586684755u);
						continue;
					case 2u:
						arg_72_0 = 3223745461u;
						continue;
					case 3u:
						this.Program = input.ReadFixed32();
						arg_72_0 = 3302930560u;
						continue;
					case 4u:
						goto IL_A9;
					case 5u:
						input.SkipLastField();
						arg_72_0 = (num2 * 2414251679u ^ 2393943078u);
						continue;
					case 6u:
						arg_72_0 = (num2 * 3515206833u ^ 2546351993u);
						continue;
					}
					return;
				}
			}
		}
	}
}
