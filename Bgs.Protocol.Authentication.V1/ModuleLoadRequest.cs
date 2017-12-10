using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class ModuleLoadRequest : IMessage<ModuleLoadRequest>, IEquatable<ModuleLoadRequest>, IDeepCloneable<ModuleLoadRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ModuleLoadRequest.__c __9 = new ModuleLoadRequest.__c();

			internal ModuleLoadRequest cctor>b__29_0()
			{
				return new ModuleLoadRequest();
			}
		}

		private static readonly MessageParser<ModuleLoadRequest> _parser = new MessageParser<ModuleLoadRequest>(new Func<ModuleLoadRequest>(ModuleLoadRequest.__c.__9.<.cctor>b__29_0));

		public const int ModuleHandleFieldNumber = 1;

		private ContentHandle moduleHandle_;

		public const int MessageFieldNumber = 2;

		private ByteString message_ = ByteString.Empty;

		public static MessageParser<ModuleLoadRequest> Parser
		{
			get
			{
				return ModuleLoadRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModuleLoadRequest.Descriptor;
			}
		}

		public ContentHandle ModuleHandle
		{
			get
			{
				return this.moduleHandle_;
			}
			set
			{
				this.moduleHandle_ = value;
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
				this.message_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public ModuleLoadRequest()
		{
		}

		public ModuleLoadRequest(ModuleLoadRequest other) : this()
		{
			while (true)
			{
				IL_50:
				int arg_3A_0 = 227403691;
				while (true)
				{
					switch ((arg_3A_0 ^ 907570580) % 3)
					{
					case 1:
						this.ModuleHandle = ((other.moduleHandle_ != null) ? other.ModuleHandle.Clone() : null);
						this.message_ = other.message_;
						arg_3A_0 = 718809343;
						continue;
					case 2:
						goto IL_50;
					}
					return;
				}
			}
		}

		public ModuleLoadRequest Clone()
		{
			return new ModuleLoadRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ModuleLoadRequest);
		}

		public bool Equals(ModuleLoadRequest other)
		{
			if (other == null)
			{
				goto IL_6D;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 122354242) % 9)
				{
				case 0:
					goto IL_6D;
				case 1:
					return true;
				case 2:
					goto IL_B5;
				case 3:
					arg_77_0 = ((!(this.Message != other.Message)) ? 1606535281 : 711143776);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
					arg_77_0 = ((!ModuleLoadRequest.smethod_0(this.ModuleHandle, other.ModuleHandle)) ? 1150256612 : 1089966512);
					continue;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = 2039536103;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? 1931391754 : 1916817085);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ ModuleLoadRequest.smethod_1(this.ModuleHandle);
			while (true)
			{
				IL_7C:
				uint arg_60_0 = 146414588u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_60_0 ^ 299600817u)) % 4u)
					{
					case 1u:
						arg_60_0 = (((this.Message.Length != 0) ? 2638775749u : 2376584702u) ^ num2 * 3452490515u);
						continue;
					case 2u:
						goto IL_7C;
					case 3u:
						num ^= ModuleLoadRequest.smethod_1(this.Message);
						arg_60_0 = (num2 * 258671607u ^ 3722850924u);
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
			output.WriteRawTag(10);
			output.WriteMessage(this.ModuleHandle);
			while (true)
			{
				IL_86:
				uint arg_6A_0 = 2050773038u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6A_0 ^ 365091409u)) % 4u)
					{
					case 0u:
						goto IL_86;
					case 2u:
						output.WriteRawTag(18);
						output.WriteBytes(this.Message);
						arg_6A_0 = (num * 2719542989u ^ 2087845406u);
						continue;
					case 3u:
						arg_6A_0 = (((this.Message.Length != 0) ? 2074067179u : 1757741484u) ^ num * 2729404816u);
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
				IL_96:
				uint arg_76_0 = 4036261903u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_76_0 ^ 3059735664u)) % 5u)
					{
					case 0u:
						goto IL_96;
					case 1u:
						arg_76_0 = (((this.Message.Length != 0) ? 4033344523u : 2628193201u) ^ num2 * 610919169u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeBytesSize(this.Message);
						arg_76_0 = (num2 * 2327052240u ^ 3020676233u);
						continue;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ModuleHandle);
						arg_76_0 = (num2 * 3311032481u ^ 3960045287u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ModuleLoadRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_101;
			uint arg_C1_0;
			while (true)
			{
				IL_BC:
				uint num;
				switch ((num = (arg_C1_0 ^ 3517434530u)) % 9u)
				{
				case 0u:
					goto IL_101;
				case 1u:
					return;
				case 3u:
					this.ModuleHandle.MergeFrom(other.ModuleHandle);
					arg_C1_0 = 4009164021u;
					continue;
				case 4u:
					this.moduleHandle_ = new ContentHandle();
					arg_C1_0 = (num * 2478017156u ^ 2317219278u);
					continue;
				case 5u:
					this.Message = other.Message;
					arg_C1_0 = (num * 2925704472u ^ 3035999500u);
					continue;
				case 6u:
					arg_C1_0 = ((other.Message.Length == 0) ? 3854963524u : 3151335425u);
					continue;
				case 7u:
					arg_C1_0 = (((this.moduleHandle_ == null) ? 2739492028u : 3580182373u) ^ num * 554656167u);
					continue;
				case 8u:
					goto IL_18;
				}
				break;
			}
			return;
			IL_18:
			arg_C1_0 = 4024937404u;
			goto IL_BC;
			IL_101:
			arg_C1_0 = ((other.moduleHandle_ != null) ? 3292008923u : 4009164021u);
			goto IL_BC;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_150:
				uint num;
				uint arg_104_0 = ((num = input.ReadTag()) == 0u) ? 3240851680u : 3911203106u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_104_0 ^ 3874519837u)) % 12u)
					{
					case 0u:
						goto IL_150;
					case 2u:
						input.ReadMessage(this.moduleHandle_);
						arg_104_0 = 2345928663u;
						continue;
					case 3u:
						this.moduleHandle_ = new ContentHandle();
						arg_104_0 = (num2 * 1852460054u ^ 1869735793u);
						continue;
					case 4u:
						arg_104_0 = 3911203106u;
						continue;
					case 5u:
						arg_104_0 = (((num == 18u) ? 2278601351u : 3960444390u) ^ num2 * 2526387095u);
						continue;
					case 6u:
						arg_104_0 = (num2 * 942189939u ^ 2834218227u);
						continue;
					case 7u:
						arg_104_0 = ((num != 10u) ? 3643248240u : 3386124454u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_104_0 = (num2 * 2982677482u ^ 1373722523u);
						continue;
					case 9u:
						this.Message = input.ReadBytes();
						arg_104_0 = 4154862669u;
						continue;
					case 10u:
						arg_104_0 = (num2 * 3716635894u ^ 2688044617u);
						continue;
					case 11u:
						arg_104_0 = ((this.moduleHandle_ == null) ? 2521825334u : 2740502211u);
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
