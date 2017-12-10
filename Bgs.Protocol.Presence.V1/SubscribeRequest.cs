using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SubscribeRequest.__c __9 = new SubscribeRequest.__c();

			internal SubscribeRequest cctor>b__44_0()
			{
				return new SubscribeRequest();
			}
		}

		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(new Func<SubscribeRequest>(SubscribeRequest.__c.__9.<.cctor>b__44_0));

		public const int AgentIdFieldNumber = 1;

		private EntityId agentId_;

		public const int EntityIdFieldNumber = 2;

		private EntityId entityId_;

		public const int ObjectIdFieldNumber = 3;

		private ulong objectId_;

		public const int ProgramFieldNumber = 4;

		private static readonly FieldCodec<uint> _repeated_program_codec = FieldCodec.ForFixed32(34u);

		private readonly RepeatedField<uint> program_ = new RepeatedField<uint>();

		public const int FlagPublicFieldNumber = 5;

		private bool flagPublic_;

		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		public EntityId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
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

		public RepeatedField<uint> Program
		{
			get
			{
				return this.program_;
			}
		}

		public bool FlagPublic
		{
			get
			{
				return this.flagPublic_;
			}
			set
			{
				this.flagPublic_ = value;
			}
		}

		public SubscribeRequest()
		{
		}

		public SubscribeRequest(SubscribeRequest other) : this()
		{
			while (true)
			{
				IL_D2:
				uint arg_AA_0 = 4147933475u;
				while (true)
				{
					uint num;
					switch ((num = (arg_AA_0 ^ 2161640928u)) % 7u)
					{
					case 0u:
						goto IL_D2;
					case 1u:
						this.program_ = other.program_.Clone();
						arg_AA_0 = (num * 2449852625u ^ 1261156542u);
						continue;
					case 2u:
						this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
						arg_AA_0 = 2508569309u;
						continue;
					case 3u:
						this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
						arg_AA_0 = 3630356268u;
						continue;
					case 5u:
						this.flagPublic_ = other.flagPublic_;
						arg_AA_0 = (num * 3425382422u ^ 623876445u);
						continue;
					case 6u:
						this.objectId_ = other.objectId_;
						arg_AA_0 = (num * 1995052304u ^ 994650161u);
						continue;
					}
					return;
				}
			}
		}

		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		public bool Equals(SubscribeRequest other)
		{
			if (other == null)
			{
				goto IL_71;
			}
			goto IL_150;
			int arg_FA_0;
			while (true)
			{
				IL_F5:
				switch ((arg_FA_0 ^ -1059517055) % 15)
				{
				case 0:
					goto IL_150;
				case 1:
					arg_FA_0 = (this.program_.Equals(other.program_) ? -168163366 : -1793894336);
					continue;
				case 2:
					arg_FA_0 = (SubscribeRequest.smethod_0(this.AgentId, other.AgentId) ? -1293838794 : -1843716421);
					continue;
				case 4:
					arg_FA_0 = ((this.ObjectId == other.ObjectId) ? -816524782 : -1679194175);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_71;
				case 8:
					return false;
				case 9:
					arg_FA_0 = ((this.FlagPublic != other.FlagPublic) ? -805387789 : -728448309);
					continue;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
					return false;
				case 13:
					arg_FA_0 = (SubscribeRequest.smethod_0(this.EntityId, other.EntityId) ? -399548154 : -2041285777);
					continue;
				case 14:
					return true;
				}
				break;
			}
			return true;
			IL_71:
			arg_FA_0 = -67151912;
			goto IL_F5;
			IL_150:
			arg_FA_0 = ((other == this) ? -1159316683 : -1007009855);
			goto IL_F5;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentId_ != null)
			{
				goto IL_78;
			}
			goto IL_FD;
			uint arg_D1_0;
			while (true)
			{
				IL_CC:
				uint num2;
				switch ((num2 = (arg_D1_0 ^ 2585830225u)) % 8u)
				{
				case 0u:
					num ^= this.program_.GetHashCode();
					arg_D1_0 = ((!this.FlagPublic) ? 3577033180u : 3445708656u);
					continue;
				case 1u:
					num ^= this.FlagPublic.GetHashCode();
					arg_D1_0 = (num2 * 2625452326u ^ 645375034u);
					continue;
				case 2u:
					goto IL_78;
				case 3u:
					arg_D1_0 = (((this.ObjectId == 0uL) ? 2540157907u : 3240818796u) ^ num2 * 2870375062u);
					continue;
				case 4u:
					goto IL_FD;
				case 6u:
					num ^= SubscribeRequest.smethod_1(this.AgentId);
					arg_D1_0 = (num2 * 549261466u ^ 445140049u);
					continue;
				case 7u:
					num ^= this.ObjectId.GetHashCode();
					arg_D1_0 = (num2 * 1737124730u ^ 2165347047u);
					continue;
				}
				break;
			}
			return num;
			IL_78:
			arg_D1_0 = 2995339615u;
			goto IL_CC;
			IL_FD:
			num ^= SubscribeRequest.smethod_1(this.EntityId);
			arg_D1_0 = 3971246154u;
			goto IL_CC;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentId_ != null)
			{
				goto IL_2B;
			}
			goto IL_124;
			uint arg_F3_0;
			while (true)
			{
				IL_EE:
				uint num;
				switch ((num = (arg_F3_0 ^ 4066333483u)) % 9u)
				{
				case 0u:
					output.WriteRawTag(24);
					output.WriteUInt64(this.ObjectId);
					arg_F3_0 = (num * 3465962251u ^ 2029114433u);
					continue;
				case 1u:
					this.program_.WriteTo(output, SubscribeRequest._repeated_program_codec);
					arg_F3_0 = (this.FlagPublic ? 3532529957u : 3510009777u);
					continue;
				case 3u:
					output.WriteRawTag(40);
					output.WriteBool(this.FlagPublic);
					arg_F3_0 = (num * 1507474584u ^ 1077247969u);
					continue;
				case 4u:
					output.WriteRawTag(10);
					arg_F3_0 = (num * 1747618687u ^ 1310679324u);
					continue;
				case 5u:
					goto IL_124;
				case 6u:
					arg_F3_0 = (((this.ObjectId != 0uL) ? 1834017854u : 1464960798u) ^ num * 1678166577u);
					continue;
				case 7u:
					goto IL_2B;
				case 8u:
					output.WriteMessage(this.AgentId);
					arg_F3_0 = (num * 3070204482u ^ 3519976904u);
					continue;
				}
				break;
			}
			return;
			IL_2B:
			arg_F3_0 = 3711122022u;
			goto IL_EE;
			IL_124:
			output.WriteRawTag(18);
			output.WriteMessage(this.EntityId);
			arg_F3_0 = 3576548959u;
			goto IL_EE;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentId_ != null)
			{
				goto IL_0D;
			}
			goto IL_10B;
			uint arg_DA_0;
			while (true)
			{
				IL_D5:
				uint num2;
				switch ((num2 = (arg_DA_0 ^ 2885048772u)) % 9u)
				{
				case 0u:
					num += 2;
					arg_DA_0 = (num2 * 898855238u ^ 2834593568u);
					continue;
				case 1u:
					num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
					arg_DA_0 = (num2 * 3304442342u ^ 484738084u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
					arg_DA_0 = (num2 * 4125124610u ^ 2958909194u);
					continue;
				case 4u:
					arg_DA_0 = (((this.ObjectId == 0uL) ? 2280955048u : 4019406046u) ^ num2 * 3345826934u);
					continue;
				case 5u:
					arg_DA_0 = ((this.FlagPublic ? 566468863u : 639899090u) ^ num2 * 3862836592u);
					continue;
				case 6u:
					num += this.program_.CalculateSize(SubscribeRequest._repeated_program_codec);
					arg_DA_0 = 3990816709u;
					continue;
				case 7u:
					goto IL_0D;
				case 8u:
					goto IL_10B;
				}
				break;
			}
			return num;
			IL_0D:
			arg_DA_0 = 3446539741u;
			goto IL_D5;
			IL_10B:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			arg_DA_0 = 3243503244u;
			goto IL_D5;
		}

		public void MergeFrom(SubscribeRequest other)
		{
			if (other == null)
			{
				goto IL_9D;
			}
			goto IL_1F5;
			uint arg_19D_0;
			while (true)
			{
				IL_198:
				uint num;
				switch ((num = (arg_19D_0 ^ 596970489u)) % 15u)
				{
				case 0u:
					this.program_.Add(other.program_);
					arg_19D_0 = (other.FlagPublic ? 244616871u : 1772022305u);
					continue;
				case 2u:
					arg_19D_0 = ((other.entityId_ != null) ? 1285651062u : 1339385792u);
					continue;
				case 3u:
					this.FlagPublic = other.FlagPublic;
					arg_19D_0 = (num * 2144609355u ^ 328573099u);
					continue;
				case 4u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_19D_0 = 1339385792u;
					continue;
				case 5u:
					this.agentId_ = new EntityId();
					arg_19D_0 = (num * 4088194530u ^ 1777062448u);
					continue;
				case 6u:
					goto IL_1F5;
				case 7u:
					arg_19D_0 = ((other.ObjectId != 0uL) ? 2032832472u : 368178849u);
					continue;
				case 8u:
					arg_19D_0 = (((this.agentId_ == null) ? 2068994494u : 1047071064u) ^ num * 220100641u);
					continue;
				case 9u:
					goto IL_9D;
				case 10u:
					this.entityId_ = new EntityId();
					arg_19D_0 = (num * 2432052123u ^ 3561017010u);
					continue;
				case 11u:
					this.ObjectId = other.ObjectId;
					arg_19D_0 = (num * 59873253u ^ 1207983652u);
					continue;
				case 12u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_19D_0 = 2129066712u;
					continue;
				case 13u:
					return;
				case 14u:
					arg_19D_0 = (((this.entityId_ != null) ? 1452155908u : 15482613u) ^ num * 3176192891u);
					continue;
				}
				break;
			}
			return;
			IL_9D:
			arg_19D_0 = 1265292998u;
			goto IL_198;
			IL_1F5:
			arg_19D_0 = ((other.agentId_ == null) ? 2129066712u : 62599355u);
			goto IL_198;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_315:
				uint num;
				uint arg_291_0 = ((num = input.ReadTag()) != 0u) ? 119781018u : 2035633210u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_291_0 ^ 273965724u)) % 26u)
					{
					case 0u:
						arg_291_0 = (num2 * 3664723926u ^ 549080885u);
						continue;
					case 1u:
						arg_291_0 = (((num != 10u) ? 826238375u : 254615165u) ^ num2 * 1855052012u);
						continue;
					case 2u:
						arg_291_0 = (num2 * 3356249962u ^ 1412598367u);
						continue;
					case 3u:
						this.ObjectId = input.ReadUInt64();
						arg_291_0 = 675860167u;
						continue;
					case 4u:
						input.ReadMessage(this.agentId_);
						arg_291_0 = 24068532u;
						continue;
					case 5u:
						this.program_.AddEntriesFrom(input, SubscribeRequest._repeated_program_codec);
						arg_291_0 = 1326647160u;
						continue;
					case 6u:
						arg_291_0 = ((num <= 24u) ? 1856700279u : 2118962255u);
						continue;
					case 7u:
						arg_291_0 = ((this.agentId_ != null) ? 352554822u : 385957478u);
						continue;
					case 8u:
						arg_291_0 = 119781018u;
						continue;
					case 9u:
						arg_291_0 = ((num == 34u) ? 1944330493u : 2027551040u);
						continue;
					case 10u:
						arg_291_0 = (((num != 37u) ? 4134795712u : 2941735649u) ^ num2 * 3649897201u);
						continue;
					case 11u:
						arg_291_0 = (num2 * 770755779u ^ 503106406u);
						continue;
					case 13u:
						input.ReadMessage(this.entityId_);
						arg_291_0 = 2074102386u;
						continue;
					case 14u:
						this.agentId_ = new EntityId();
						arg_291_0 = (num2 * 1342340260u ^ 4038010734u);
						continue;
					case 15u:
						this.FlagPublic = input.ReadBool();
						arg_291_0 = 914556471u;
						continue;
					case 16u:
						arg_291_0 = (num2 * 697989208u ^ 73257975u);
						continue;
					case 17u:
						input.SkipLastField();
						arg_291_0 = 465508435u;
						continue;
					case 18u:
						this.entityId_ = new EntityId();
						arg_291_0 = (num2 * 7110975u ^ 94061553u);
						continue;
					case 19u:
						arg_291_0 = (num2 * 1278055345u ^ 1228193832u);
						continue;
					case 20u:
						arg_291_0 = (num2 * 1444559645u ^ 2864741057u);
						continue;
					case 21u:
						arg_291_0 = ((this.entityId_ != null) ? 1708823635u : 1462116162u);
						continue;
					case 22u:
						arg_291_0 = (((num != 24u) ? 838952324u : 2089128315u) ^ num2 * 1905480191u);
						continue;
					case 23u:
						arg_291_0 = (((num == 18u) ? 2260332112u : 4105695741u) ^ num2 * 44416239u);
						continue;
					case 24u:
						arg_291_0 = (((num != 40u) ? 898965317u : 263266885u) ^ num2 * 1460261246u);
						continue;
					case 25u:
						goto IL_315;
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
