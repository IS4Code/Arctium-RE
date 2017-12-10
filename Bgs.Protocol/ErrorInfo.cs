using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class ErrorInfo : IMessage<ErrorInfo>, IEquatable<ErrorInfo>, IDeepCloneable<ErrorInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ErrorInfo.__c __9 = new ErrorInfo.__c();

			internal ErrorInfo cctor>b__39_0()
			{
				return new ErrorInfo();
			}
		}

		private static readonly MessageParser<ErrorInfo> _parser = new MessageParser<ErrorInfo>(new Func<ErrorInfo>(ErrorInfo.__c.__9.<.cctor>b__39_0));

		public const int ObjectAddressFieldNumber = 1;

		private ObjectAddress objectAddress_;

		public const int StatusFieldNumber = 2;

		private uint status_;

		public const int ServiceHashFieldNumber = 3;

		private uint serviceHash_;

		public const int MethodIdFieldNumber = 4;

		private uint methodId_;

		public static MessageParser<ErrorInfo> Parser
		{
			get
			{
				return ErrorInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ErrorInfo.Descriptor;
			}
		}

		public ObjectAddress ObjectAddress
		{
			get
			{
				return this.objectAddress_;
			}
			set
			{
				this.objectAddress_ = value;
			}
		}

		public uint Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		public uint ServiceHash
		{
			get
			{
				return this.serviceHash_;
			}
			set
			{
				this.serviceHash_ = value;
			}
		}

		public uint MethodId
		{
			get
			{
				return this.methodId_;
			}
			set
			{
				this.methodId_ = value;
			}
		}

		public ErrorInfo()
		{
		}

		public ErrorInfo(ErrorInfo other) : this()
		{
			while (true)
			{
				IL_65:
				uint arg_49_0 = 1522379187u;
				while (true)
				{
					uint num;
					switch ((num = (arg_49_0 ^ 1009853074u)) % 4u)
					{
					case 1u:
						this.ObjectAddress = ((other.objectAddress_ != null) ? other.ObjectAddress.Clone() : null);
						arg_49_0 = 858718053u;
						continue;
					case 2u:
						goto IL_65;
					case 3u:
						this.status_ = other.status_;
						arg_49_0 = (num * 3020765513u ^ 1101458657u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.serviceHash_ = other.serviceHash_;
			this.methodId_ = other.methodId_;
		}

		public ErrorInfo Clone()
		{
			return new ErrorInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ErrorInfo);
		}

		public bool Equals(ErrorInfo other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_114;
			int arg_C6_0;
			while (true)
			{
				IL_C1:
				switch ((arg_C6_0 ^ 383492524) % 13)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					arg_C6_0 = ((!ErrorInfo.smethod_0(this.ObjectAddress, other.ObjectAddress)) ? 63476309 : 874072386);
					continue;
				case 3:
					return true;
				case 4:
					arg_C6_0 = ((this.Status == other.Status) ? 465112748 : 1464721473);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					arg_C6_0 = ((this.MethodId != other.MethodId) ? 1774036157 : 53093456);
					continue;
				case 8:
					goto IL_114;
				case 10:
					arg_C6_0 = ((this.ServiceHash != other.ServiceHash) ? 1754311642 : 658411737);
					continue;
				case 11:
					return false;
				case 12:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_C6_0 = 1009580947;
			goto IL_C1;
			IL_114:
			arg_C6_0 = ((other != this) ? 836130000 : 1034370472);
			goto IL_C1;
		}

		public override int GetHashCode()
		{
			return 1 ^ ErrorInfo.smethod_1(this.ObjectAddress) ^ this.Status.GetHashCode() ^ this.ServiceHash.GetHashCode() ^ this.MethodId.GetHashCode();
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			while (true)
			{
				IL_AC:
				uint arg_88_0 = 1006919464u;
				while (true)
				{
					uint num;
					switch ((num = (arg_88_0 ^ 506496947u)) % 6u)
					{
					case 0u:
						output.WriteRawTag(24);
						output.WriteUInt32(this.ServiceHash);
						arg_88_0 = (num * 2306844826u ^ 813464956u);
						continue;
					case 1u:
						output.WriteMessage(this.ObjectAddress);
						arg_88_0 = (num * 1638743948u ^ 3821856625u);
						continue;
					case 2u:
						output.WriteRawTag(16);
						output.WriteUInt32(this.Status);
						arg_88_0 = (num * 586625811u ^ 2271986285u);
						continue;
					case 3u:
						output.WriteRawTag(32);
						arg_88_0 = (num * 2975972501u ^ 4125294461u);
						continue;
					case 4u:
						goto IL_AC;
					}
					goto Block_1;
				}
			}
			Block_1:
			output.WriteUInt32(this.MethodId);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.ObjectAddress)) + (1 + CodedOutputStream.ComputeUInt32Size(this.Status)) + (1 + CodedOutputStream.ComputeUInt32Size(this.ServiceHash)) + (1 + CodedOutputStream.ComputeUInt32Size(this.MethodId));
		}

		public void MergeFrom(ErrorInfo other)
		{
			if (other == null)
			{
				goto IL_136;
			}
			goto IL_190;
			uint arg_140_0;
			while (true)
			{
				IL_13B:
				uint num;
				switch ((num = (arg_140_0 ^ 367135147u)) % 13u)
				{
				case 0u:
					goto IL_136;
				case 1u:
					arg_140_0 = ((other.ServiceHash != 0u) ? 2083956000u : 1053991539u);
					continue;
				case 2u:
					this.MethodId = other.MethodId;
					arg_140_0 = (num * 13486757u ^ 4059313196u);
					continue;
				case 3u:
					this.ObjectAddress.MergeFrom(other.ObjectAddress);
					arg_140_0 = 1280220567u;
					continue;
				case 4u:
					return;
				case 5u:
					arg_140_0 = ((other.MethodId == 0u) ? 1128003028u : 693418291u);
					continue;
				case 6u:
					goto IL_190;
				case 7u:
					arg_140_0 = (((this.objectAddress_ != null) ? 1232839252u : 2041428242u) ^ num * 2081660195u);
					continue;
				case 8u:
					arg_140_0 = ((other.Status != 0u) ? 825811282u : 176395360u);
					continue;
				case 9u:
					this.objectAddress_ = new ObjectAddress();
					arg_140_0 = (num * 2527266627u ^ 2607735865u);
					continue;
				case 10u:
					this.ServiceHash = other.ServiceHash;
					arg_140_0 = (num * 2336965507u ^ 3899067986u);
					continue;
				case 11u:
					this.Status = other.Status;
					arg_140_0 = (num * 2184209208u ^ 3525891352u);
					continue;
				}
				break;
			}
			return;
			IL_136:
			arg_140_0 = 1371118061u;
			goto IL_13B;
			IL_190:
			arg_140_0 = ((other.objectAddress_ == null) ? 1280220567u : 1185098686u);
			goto IL_13B;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_211:
				uint num;
				uint arg_1AD_0 = ((num = input.ReadTag()) == 0u) ? 670662643u : 756699698u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_1AD_0 ^ 1425462976u)) % 18u)
					{
					case 0u:
						arg_1AD_0 = (num2 * 1012991751u ^ 826552799u);
						continue;
					case 1u:
						arg_1AD_0 = ((num != 24u) ? 662328647u : 888310942u);
						continue;
					case 2u:
						this.ServiceHash = input.ReadUInt32();
						arg_1AD_0 = 1062436109u;
						continue;
					case 3u:
						arg_1AD_0 = (((num == 16u) ? 495577116u : 1337798943u) ^ num2 * 664089892u);
						continue;
					case 4u:
						this.Status = input.ReadUInt32();
						arg_1AD_0 = 1865639012u;
						continue;
					case 5u:
						arg_1AD_0 = (num2 * 1582653280u ^ 4202804386u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_1AD_0 = 1062436109u;
						continue;
					case 7u:
						arg_1AD_0 = 756699698u;
						continue;
					case 8u:
						this.MethodId = input.ReadUInt32();
						arg_1AD_0 = 1062436109u;
						continue;
					case 9u:
						goto IL_211;
					case 10u:
						arg_1AD_0 = (num2 * 3460277702u ^ 2855576533u);
						continue;
					case 12u:
						this.objectAddress_ = new ObjectAddress();
						arg_1AD_0 = (num2 * 3900995777u ^ 895701103u);
						continue;
					case 13u:
						input.ReadMessage(this.objectAddress_);
						arg_1AD_0 = 2054021342u;
						continue;
					case 14u:
						arg_1AD_0 = ((num > 16u) ? 121899633u : 2052301734u);
						continue;
					case 15u:
						arg_1AD_0 = ((this.objectAddress_ != null) ? 739671355u : 433445012u);
						continue;
					case 16u:
						arg_1AD_0 = (((num != 10u) ? 2320793211u : 2610709821u) ^ num2 * 3170679056u);
						continue;
					case 17u:
						arg_1AD_0 = (((num != 32u) ? 667369157u : 1539531977u) ^ num2 * 763854657u);
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
