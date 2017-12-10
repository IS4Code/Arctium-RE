using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class ModuleMessageRequest : IMessage<ModuleMessageRequest>, IEquatable<ModuleMessageRequest>, IDeepCloneable<ModuleMessageRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ModuleMessageRequest.__c __9 = new ModuleMessageRequest.__c();

			internal ModuleMessageRequest cctor>b__29_0()
			{
				return new ModuleMessageRequest();
			}
		}

		private static readonly MessageParser<ModuleMessageRequest> _parser = new MessageParser<ModuleMessageRequest>(new Func<ModuleMessageRequest>(ModuleMessageRequest.__c.__9.<.cctor>b__29_0));

		public const int ModuleIdFieldNumber = 1;

		private int moduleId_;

		public const int MessageFieldNumber = 2;

		private ByteString message_ = ByteString.Empty;

		public static MessageParser<ModuleMessageRequest> Parser
		{
			get
			{
				return ModuleMessageRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModuleMessageRequest.Descriptor;
			}
		}

		public int ModuleId
		{
			get
			{
				return this.moduleId_;
			}
			set
			{
				this.moduleId_ = value;
			}
		}

		public ByteString Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public ModuleMessageRequest()
		{
		}

		public ModuleMessageRequest(ModuleMessageRequest other) : this()
		{
			this.moduleId_ = other.moduleId_;
			this.message_ = other.message_;
		}

		public ModuleMessageRequest Clone()
		{
			return new ModuleMessageRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ModuleMessageRequest);
		}

		public bool Equals(ModuleMessageRequest other)
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
				switch ((arg_72_0 ^ 1542479470) % 9)
				{
				case 0:
					arg_72_0 = ((this.ModuleId == other.ModuleId) ? 1639838774 : 2042867377);
					continue;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					goto IL_41;
				case 4:
					goto IL_B0;
				case 6:
					arg_72_0 = ((this.Message != other.Message) ? 628911309 : 793882916);
					continue;
				case 7:
					return true;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_41:
			arg_72_0 = 1549714871;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 993188932 : 307329844);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_7F:
				uint arg_63_0 = 531676141u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_63_0 ^ 1999646688u)) % 4u)
					{
					case 0u:
						goto IL_7F;
					case 1u:
						num ^= this.ModuleId.GetHashCode();
						arg_63_0 = (((this.Message.Length == 0) ? 3898083131u : 3079401746u) ^ num2 * 2043049836u);
						continue;
					case 2u:
						num ^= this.Message.GetHashCode();
						arg_63_0 = (num2 * 3606793103u ^ 2081156117u);
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
			output.WriteRawTag(8);
			while (true)
			{
				IL_9B:
				uint arg_7B_0 = 4155028264u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7B_0 ^ 2926507677u)) % 5u)
					{
					case 0u:
						goto IL_9B;
					case 1u:
						output.WriteRawTag(18);
						arg_7B_0 = (num * 1927068880u ^ 2924592135u);
						continue;
					case 2u:
						output.WriteInt32(this.ModuleId);
						arg_7B_0 = (((this.Message.Length == 0) ? 3323606335u : 3365270438u) ^ num * 1188699298u);
						continue;
					case 3u:
						output.WriteBytes(this.Message);
						arg_7B_0 = (num * 3537584055u ^ 3214314579u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_80:
				uint arg_64_0 = 144551469u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_64_0 ^ 240356304u)) % 4u)
					{
					case 0u:
						goto IL_80;
					case 1u:
						num += 1 + CodedOutputStream.ComputeInt32Size(this.ModuleId);
						arg_64_0 = (((this.Message.Length == 0) ? 253002282u : 167928735u) ^ num2 * 3207193553u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.Message);
						arg_64_0 = (num2 * 2982261712u ^ 1631927047u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ModuleMessageRequest other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_B2;
			uint arg_7B_0;
			while (true)
			{
				IL_76:
				uint num;
				switch ((num = (arg_7B_0 ^ 4029559410u)) % 7u)
				{
				case 0u:
					goto IL_71;
				case 2u:
					this.ModuleId = other.ModuleId;
					arg_7B_0 = (num * 2249628694u ^ 1651750243u);
					continue;
				case 3u:
					goto IL_B2;
				case 4u:
					this.Message = other.Message;
					arg_7B_0 = (num * 1033054816u ^ 1739415604u);
					continue;
				case 5u:
					return;
				case 6u:
					arg_7B_0 = ((other.Message.Length != 0) ? 4044488294u : 2236526516u);
					continue;
				}
				break;
			}
			return;
			IL_71:
			arg_7B_0 = 2282081470u;
			goto IL_76;
			IL_B2:
			arg_7B_0 = ((other.ModuleId == 0) ? 2636534361u : 3372574597u);
			goto IL_76;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_ED:
				uint num;
				uint arg_AD_0 = ((num = input.ReadTag()) != 0u) ? 1058508433u : 1766903877u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AD_0 ^ 485959174u)) % 9u)
					{
					case 0u:
						this.ModuleId = input.ReadInt32();
						arg_AD_0 = 1489327786u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_AD_0 = (num2 * 1018673584u ^ 1412776485u);
						continue;
					case 2u:
						arg_AD_0 = 1058508433u;
						continue;
					case 3u:
						arg_AD_0 = (num2 * 4230974440u ^ 195026389u);
						continue;
					case 4u:
						this.Message = input.ReadBytes();
						arg_AD_0 = 1005101621u;
						continue;
					case 5u:
						arg_AD_0 = ((num == 8u) ? 396980799u : 1628599047u);
						continue;
					case 7u:
						goto IL_ED;
					case 8u:
						arg_AD_0 = (((num == 18u) ? 1070496585u : 1967516742u) ^ num2 * 2287146963u);
						continue;
					}
					return;
				}
			}
		}
	}
}
