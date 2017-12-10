using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class MemModuleLoadRequest : IMessage<MemModuleLoadRequest>, IEquatable<MemModuleLoadRequest>, IDeepCloneable<MemModuleLoadRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly MemModuleLoadRequest.__c __9 = new MemModuleLoadRequest.__c();

			internal MemModuleLoadRequest cctor>b__34_0()
			{
				return new MemModuleLoadRequest();
			}
		}

		private static readonly MessageParser<MemModuleLoadRequest> _parser = new MessageParser<MemModuleLoadRequest>(new Func<MemModuleLoadRequest>(MemModuleLoadRequest.__c.__9.<.cctor>b__34_0));

		public const int HandleFieldNumber = 1;

		private ContentHandle handle_;

		public const int KeyFieldNumber = 2;

		private ByteString key_ = ByteString.Empty;

		public const int InputFieldNumber = 3;

		private ByteString input_ = ByteString.Empty;

		public static MessageParser<MemModuleLoadRequest> Parser
		{
			get
			{
				return MemModuleLoadRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemModuleLoadRequest.Descriptor;
			}
		}

		public ContentHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		public ByteString Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public ByteString Input
		{
			get
			{
				return this.input_;
			}
			set
			{
				this.input_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public MemModuleLoadRequest()
		{
		}

		public MemModuleLoadRequest(MemModuleLoadRequest other) : this()
		{
			while (true)
			{
				IL_84:
				uint arg_64_0 = 3660146628u;
				while (true)
				{
					uint num;
					switch ((num = (arg_64_0 ^ 2562444466u)) % 5u)
					{
					case 0u:
						this.key_ = other.key_;
						arg_64_0 = (num * 1996960927u ^ 2498852074u);
						continue;
					case 1u:
						this.Handle = ((other.handle_ != null) ? other.Handle.Clone() : null);
						arg_64_0 = 2475913443u;
						continue;
					case 3u:
						this.input_ = other.input_;
						arg_64_0 = (num * 2189016823u ^ 2334561991u);
						continue;
					case 4u:
						goto IL_84;
					}
					return;
				}
			}
		}

		public MemModuleLoadRequest Clone()
		{
			return new MemModuleLoadRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as MemModuleLoadRequest);
		}

		public bool Equals(MemModuleLoadRequest other)
		{
			if (other == null)
			{
				goto IL_44;
			}
			goto IL_EC;
			int arg_A6_0;
			while (true)
			{
				IL_A1:
				switch ((arg_A6_0 ^ -545960206) % 11)
				{
				case 1:
					return true;
				case 2:
					arg_A6_0 = ((!MemModuleLoadRequest.smethod_0(this.Handle, other.Handle)) ? -31116484 : -1119954870);
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_A6_0 = ((this.Key != other.Key) ? -637790031 : -938712221);
					continue;
				case 7:
					goto IL_EC;
				case 8:
					goto IL_44;
				case 9:
					return false;
				case 10:
					arg_A6_0 = ((this.Input != other.Input) ? -1007138837 : -1176368319);
					continue;
				}
				break;
			}
			return true;
			IL_44:
			arg_A6_0 = -814188914;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other != this) ? -1486914974 : -813743348);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			return 1 ^ MemModuleLoadRequest.smethod_1(this.Handle) ^ MemModuleLoadRequest.smethod_1(this.Key) ^ MemModuleLoadRequest.smethod_1(this.Input);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteMessage(this.Handle);
			while (true)
			{
				IL_8E:
				uint arg_6E_0 = 2656127753u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6E_0 ^ 3527024739u)) % 5u)
					{
					case 0u:
						output.WriteRawTag(26);
						output.WriteBytes(this.Input);
						arg_6E_0 = (num * 1017322877u ^ 1149341449u);
						continue;
					case 1u:
						output.WriteRawTag(18);
						arg_6E_0 = (num * 2858448699u ^ 2592475497u);
						continue;
					case 2u:
						output.WriteBytes(this.Key);
						arg_6E_0 = (num * 166497264u ^ 203705007u);
						continue;
					case 3u:
						goto IL_8E;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.Handle)) + (1 + CodedOutputStream.ComputeBytesSize(this.Key)) + (1 + CodedOutputStream.ComputeBytesSize(this.Input));
		}

		public void MergeFrom(MemModuleLoadRequest other)
		{
			if (other == null)
			{
				goto IL_DB;
			}
			goto IL_153;
			uint arg_10B_0;
			while (true)
			{
				IL_106:
				uint num;
				switch ((num = (arg_10B_0 ^ 1733169685u)) % 11u)
				{
				case 1u:
					arg_10B_0 = ((other.Key.Length == 0) ? 1035309351u : 323293873u);
					continue;
				case 2u:
					goto IL_DB;
				case 3u:
					goto IL_153;
				case 4u:
					arg_10B_0 = (((this.handle_ != null) ? 3113664507u : 2293154297u) ^ num * 964338006u);
					continue;
				case 5u:
					return;
				case 6u:
					arg_10B_0 = ((other.Input.Length == 0) ? 701020044u : 205263302u);
					continue;
				case 7u:
					this.Key = other.Key;
					arg_10B_0 = (num * 3864261624u ^ 1422252999u);
					continue;
				case 8u:
					this.Handle.MergeFrom(other.Handle);
					arg_10B_0 = 526040831u;
					continue;
				case 9u:
					this.handle_ = new ContentHandle();
					arg_10B_0 = (num * 1500587489u ^ 1210784855u);
					continue;
				case 10u:
					this.Input = other.Input;
					arg_10B_0 = (num * 1848408413u ^ 397846827u);
					continue;
				}
				break;
			}
			return;
			IL_DB:
			arg_10B_0 = 212394142u;
			goto IL_106;
			IL_153:
			arg_10B_0 = ((other.handle_ == null) ? 526040831u : 1522601854u);
			goto IL_106;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_197:
				uint num;
				uint arg_143_0 = ((num = input.ReadTag()) == 0u) ? 4152991702u : 2911821788u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_143_0 ^ 2417721053u)) % 14u)
					{
					case 0u:
						this.handle_ = new ContentHandle();
						arg_143_0 = (num2 * 3382806737u ^ 1703479610u);
						continue;
					case 1u:
						goto IL_197;
					case 2u:
						arg_143_0 = (num2 * 1852283086u ^ 1884059718u);
						continue;
					case 3u:
						arg_143_0 = ((num != 10u) ? 3032329293u : 3675297542u);
						continue;
					case 4u:
						this.Input = input.ReadBytes();
						arg_143_0 = 3710304194u;
						continue;
					case 5u:
						arg_143_0 = (((num != 26u) ? 925116337u : 125034904u) ^ num2 * 279269693u);
						continue;
					case 6u:
						arg_143_0 = (num2 * 2961365507u ^ 1970846926u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_143_0 = (num2 * 2791188777u ^ 2842763631u);
						continue;
					case 8u:
						arg_143_0 = (((num != 18u) ? 1230739264u : 268835931u) ^ num2 * 3896893626u);
						continue;
					case 9u:
						arg_143_0 = ((this.handle_ != null) ? 2519520100u : 3863893283u);
						continue;
					case 10u:
						arg_143_0 = 2911821788u;
						continue;
					case 12u:
						this.Key = input.ReadBytes();
						arg_143_0 = 3566663641u;
						continue;
					case 13u:
						input.ReadMessage(this.handle_);
						arg_143_0 = 4067768883u;
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
