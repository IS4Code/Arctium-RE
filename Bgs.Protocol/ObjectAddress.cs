using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class ObjectAddress : IMessage<ObjectAddress>, IEquatable<ObjectAddress>, IDeepCloneable<ObjectAddress>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ObjectAddress.__c __9 = new ObjectAddress.__c();

			internal ObjectAddress cctor>b__29_0()
			{
				return new ObjectAddress();
			}
		}

		private static readonly MessageParser<ObjectAddress> _parser = new MessageParser<ObjectAddress>(new Func<ObjectAddress>(ObjectAddress.__c.__9.<.cctor>b__29_0));

		public const int HostFieldNumber = 1;

		private ProcessId host_;

		public const int ObjectIdFieldNumber = 2;

		private ulong objectId_;

		public static MessageParser<ObjectAddress> Parser
		{
			get
			{
				return ObjectAddress._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ObjectAddress.Descriptor;
			}
		}

		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		public ulong ObjectId
		{
			get
			{
				return this.objectId_;
			}
			set
			{
				this.objectId_ = value;
			}
		}

		public ObjectAddress()
		{
		}

		public ObjectAddress(ObjectAddress other) : this()
		{
			this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
			this.objectId_ = other.objectId_;
		}

		public ObjectAddress Clone()
		{
			return new ObjectAddress(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ObjectAddress);
		}

		public bool Equals(ObjectAddress other)
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
				switch ((arg_72_0 ^ 2126518567) % 9)
				{
				case 0:
					arg_72_0 = ((!ObjectAddress.smethod_0(this.Host, other.Host)) ? 506165601 : 347133427);
					continue;
				case 1:
					arg_72_0 = ((this.ObjectId != other.ObjectId) ? 506788898 : 744276925);
					continue;
				case 2:
					goto IL_B0;
				case 3:
					goto IL_15;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_72_0 = 1254453680;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other == this) ? 2017105065 : 2109675614);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ ObjectAddress.smethod_1(this.Host);
			while (true)
			{
				IL_7A:
				uint arg_5E_0 = 1388377778u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5E_0 ^ 436569008u)) % 4u)
					{
					case 0u:
						goto IL_7A;
					case 1u:
						num ^= this.ObjectId.GetHashCode();
						arg_5E_0 = (num2 * 3114563367u ^ 1372315460u);
						continue;
					case 2u:
						arg_5E_0 = (((this.ObjectId == 0uL) ? 1009854875u : 1804757577u) ^ num2 * 1450141308u);
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
			output.WriteMessage(this.Host);
			while (true)
			{
				IL_81:
				uint arg_65_0 = 880761159u;
				while (true)
				{
					uint num;
					switch ((num = (arg_65_0 ^ 1563109521u)) % 4u)
					{
					case 0u:
						goto IL_81;
					case 1u:
						output.WriteRawTag(16);
						output.WriteUInt64(this.ObjectId);
						arg_65_0 = (num * 2958067841u ^ 2876228831u);
						continue;
					case 2u:
						arg_65_0 = (((this.ObjectId == 0uL) ? 906845704u : 787001542u) ^ num * 145965687u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeMessageSize(this.Host));
			while (true)
			{
				IL_7B:
				uint arg_5F_0 = 3532080024u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5F_0 ^ 2184967746u)) % 4u)
					{
					case 0u:
						goto IL_7B;
					case 1u:
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
						arg_5F_0 = (num2 * 3449153423u ^ 743595002u);
						continue;
					case 2u:
						arg_5F_0 = (((this.ObjectId != 0uL) ? 1634319625u : 1127513695u) ^ num2 * 330731901u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ObjectAddress other)
		{
			if (other == null)
			{
				goto IL_7C;
			}
			goto IL_F9;
			uint arg_B9_0;
			while (true)
			{
				IL_B4:
				uint num;
				switch ((num = (arg_B9_0 ^ 460412436u)) % 9u)
				{
				case 0u:
					this.ObjectId = other.ObjectId;
					arg_B9_0 = (num * 3739280031u ^ 114632850u);
					continue;
				case 2u:
					this.Host.MergeFrom(other.Host);
					arg_B9_0 = 1632779411u;
					continue;
				case 3u:
					goto IL_7C;
				case 4u:
					this.host_ = new ProcessId();
					arg_B9_0 = (num * 2976309156u ^ 2775404304u);
					continue;
				case 5u:
					goto IL_F9;
				case 6u:
					return;
				case 7u:
					arg_B9_0 = (((this.host_ != null) ? 485046196u : 640651363u) ^ num * 3808556174u);
					continue;
				case 8u:
					arg_B9_0 = ((other.ObjectId != 0uL) ? 214090938u : 2056298112u);
					continue;
				}
				break;
			}
			return;
			IL_7C:
			arg_B9_0 = 1712836748u;
			goto IL_B4;
			IL_F9:
			arg_B9_0 = ((other.host_ == null) ? 1632779411u : 1332552592u);
			goto IL_B4;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13D:
				uint num;
				uint arg_F5_0 = ((num = input.ReadTag()) == 0u) ? 3235118161u : 2517609179u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F5_0 ^ 2636316335u)) % 11u)
					{
					case 0u:
						arg_F5_0 = (num2 * 1645222074u ^ 2313580737u);
						continue;
					case 2u:
						goto IL_13D;
					case 3u:
						arg_F5_0 = ((num != 10u) ? 2496460079u : 3952867392u);
						continue;
					case 4u:
						arg_F5_0 = ((this.host_ != null) ? 4231451463u : 4037584338u);
						continue;
					case 5u:
						arg_F5_0 = (((num != 16u) ? 1370834955u : 732611108u) ^ num2 * 874238007u);
						continue;
					case 6u:
						this.ObjectId = input.ReadUInt64();
						arg_F5_0 = 2842609969u;
						continue;
					case 7u:
						this.host_ = new ProcessId();
						arg_F5_0 = (num2 * 3024403130u ^ 2986711445u);
						continue;
					case 8u:
						arg_F5_0 = 2517609179u;
						continue;
					case 9u:
						input.ReadMessage(this.host_);
						arg_F5_0 = 2842609969u;
						continue;
					case 10u:
						input.SkipLastField();
						arg_F5_0 = (num2 * 444464401u ^ 22182803u);
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
