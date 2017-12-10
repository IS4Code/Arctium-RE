using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Presence.V1
{
	[DebuggerNonUserCode]
	public sealed class QueryRequest : IMessage<QueryRequest>, IEquatable<QueryRequest>, IDeepCloneable<QueryRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly QueryRequest.__c __9 = new QueryRequest.__c();

			internal QueryRequest cctor>b__34_0()
			{
				return new QueryRequest();
			}
		}

		private static readonly MessageParser<QueryRequest> _parser = new MessageParser<QueryRequest>(new Func<QueryRequest>(QueryRequest.__c.__9.<.cctor>b__34_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public const int KeyFieldNumber = 2;

		private static readonly FieldCodec<FieldKey> _repeated_key_codec = FieldCodec.ForMessage<FieldKey>(18u, FieldKey.Parser);

		private readonly RepeatedField<FieldKey> key_ = new RepeatedField<FieldKey>();

		public const int AgentIdFieldNumber = 3;

		private EntityId agentId_;

		public static MessageParser<QueryRequest> Parser
		{
			get
			{
				return QueryRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryRequest.Descriptor;
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

		public RepeatedField<FieldKey> Key
		{
			get
			{
				return this.key_;
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

		public QueryRequest()
		{
		}

		public QueryRequest(QueryRequest other) : this()
		{
			while (true)
			{
				IL_55:
				int arg_3F_0 = 926773904;
				while (true)
				{
					switch ((arg_3F_0 ^ 413003863) % 3)
					{
					case 0:
						goto IL_55;
					case 2:
						this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
						this.key_ = other.key_.Clone();
						arg_3F_0 = 142106793;
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.AgentId = ((other.agentId_ != null) ? other.AgentId.Clone() : null);
		}

		public QueryRequest Clone()
		{
			return new QueryRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as QueryRequest);
		}

		public bool Equals(QueryRequest other)
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
				switch ((arg_A6_0 ^ -667700461) % 11)
				{
				case 1:
					return true;
				case 2:
					goto IL_EC;
				case 3:
					arg_A6_0 = (this.key_.Equals(other.key_) ? -1515566658 : -2142241530);
					continue;
				case 4:
					arg_A6_0 = (QueryRequest.smethod_0(this.EntityId, other.EntityId) ? -540162475 : -1365038569);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					return false;
				case 9:
					goto IL_44;
				case 10:
					arg_A6_0 = ((!QueryRequest.smethod_0(this.AgentId, other.AgentId)) ? -1739426010 : -1043527728);
					continue;
				}
				break;
			}
			return true;
			IL_44:
			arg_A6_0 = -1238690822;
			goto IL_A1;
			IL_EC:
			arg_A6_0 = ((other != this) ? -246531064 : -1466261895);
			goto IL_A1;
		}

		public override int GetHashCode()
		{
			int num = 1 ^ QueryRequest.smethod_1(this.EntityId);
			num ^= QueryRequest.smethod_1(this.key_);
			if (this.agentId_ != null)
			{
				while (true)
				{
					IL_60:
					uint arg_48_0 = 2535793420u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_48_0 ^ 2623518650u)) % 3u)
						{
						case 1u:
							num ^= QueryRequest.smethod_1(this.AgentId);
							arg_48_0 = (num2 * 1950425143u ^ 3658049383u);
							continue;
						case 2u:
							goto IL_60;
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
			output.WriteRawTag(10);
			while (true)
			{
				IL_BB:
				uint arg_97_0 = 1746305688u;
				while (true)
				{
					uint num;
					switch ((num = (arg_97_0 ^ 985165624u)) % 6u)
					{
					case 1u:
						output.WriteRawTag(26);
						arg_97_0 = (num * 2314329460u ^ 3914495627u);
						continue;
					case 2u:
						output.WriteMessage(this.EntityId);
						this.key_.WriteTo(output, QueryRequest._repeated_key_codec);
						arg_97_0 = (num * 3801791104u ^ 3092223524u);
						continue;
					case 3u:
						output.WriteMessage(this.AgentId);
						arg_97_0 = (num * 1586987993u ^ 279251139u);
						continue;
					case 4u:
						arg_97_0 = (((this.agentId_ != null) ? 205850139u : 1541994660u) ^ num * 1526292084u);
						continue;
					case 5u:
						goto IL_BB;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + (1 + CodedOutputStream.ComputeMessageSize(this.EntityId));
			num += this.key_.CalculateSize(QueryRequest._repeated_key_codec);
			while (true)
			{
				IL_8E:
				uint arg_72_0 = 3238002587u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_72_0 ^ 4018910518u)) % 4u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
						arg_72_0 = (num2 * 3139827774u ^ 636509164u);
						continue;
					case 1u:
						arg_72_0 = (((this.agentId_ != null) ? 3261090519u : 2805836861u) ^ num2 * 2974957717u);
						continue;
					case 3u:
						goto IL_8E;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(QueryRequest other)
		{
			if (other == null)
			{
				goto IL_C0;
			}
			goto IL_171;
			uint arg_125_0;
			while (true)
			{
				IL_120:
				uint num;
				switch ((num = (arg_125_0 ^ 3203301847u)) % 12u)
				{
				case 0u:
					goto IL_171;
				case 1u:
					arg_125_0 = (((this.entityId_ == null) ? 733043829u : 1179250735u) ^ num * 1857080742u);
					continue;
				case 2u:
					this.key_.Add(other.key_);
					arg_125_0 = 3716649840u;
					continue;
				case 4u:
					this.entityId_ = new EntityId();
					arg_125_0 = (num * 831432120u ^ 2934225273u);
					continue;
				case 5u:
					goto IL_C0;
				case 6u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_125_0 = 2857550985u;
					continue;
				case 7u:
					return;
				case 8u:
					this.AgentId.MergeFrom(other.AgentId);
					arg_125_0 = 2425374856u;
					continue;
				case 9u:
					arg_125_0 = (((this.agentId_ == null) ? 150536318u : 784118968u) ^ num * 3873053395u);
					continue;
				case 10u:
					this.agentId_ = new EntityId();
					arg_125_0 = (num * 3670180736u ^ 3291234283u);
					continue;
				case 11u:
					arg_125_0 = (((other.agentId_ != null) ? 354615305u : 1316158935u) ^ num * 2048112265u);
					continue;
				}
				break;
			}
			return;
			IL_C0:
			arg_125_0 = 2827912808u;
			goto IL_120;
			IL_171:
			arg_125_0 = ((other.entityId_ != null) ? 3186707150u : 2857550985u);
			goto IL_120;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1CF:
				uint num;
				uint arg_177_0 = ((num = input.ReadTag()) == 0u) ? 4250250072u : 3152056973u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_177_0 ^ 4137094450u)) % 15u)
					{
					case 0u:
						arg_177_0 = (((num != 18u) ? 2486854431u : 3946449310u) ^ num2 * 2718764205u);
						continue;
					case 1u:
						goto IL_1CF;
					case 2u:
						arg_177_0 = (num2 * 1894434957u ^ 2410940356u);
						continue;
					case 3u:
						input.SkipLastField();
						arg_177_0 = (num2 * 703533940u ^ 86569248u);
						continue;
					case 4u:
						arg_177_0 = 3152056973u;
						continue;
					case 5u:
						this.agentId_ = new EntityId();
						arg_177_0 = (num2 * 1627376009u ^ 2087393944u);
						continue;
					case 6u:
						arg_177_0 = ((num == 10u) ? 3242714739u : 2888387052u);
						continue;
					case 7u:
						this.key_.AddEntriesFrom(input, QueryRequest._repeated_key_codec);
						arg_177_0 = 3717511764u;
						continue;
					case 8u:
						arg_177_0 = ((this.entityId_ == null) ? 3788598182u : 4211174114u);
						continue;
					case 9u:
						input.ReadMessage(this.entityId_);
						arg_177_0 = 2261957346u;
						continue;
					case 10u:
						arg_177_0 = (((num == 26u) ? 477253500u : 2034836626u) ^ num2 * 2218590563u);
						continue;
					case 11u:
						arg_177_0 = ((this.agentId_ != null) ? 3944633473u : 3173351715u);
						continue;
					case 13u:
						this.entityId_ = new EntityId();
						arg_177_0 = (num2 * 4142578163u ^ 138229918u);
						continue;
					case 14u:
						input.ReadMessage(this.agentId_);
						arg_177_0 = 3717511764u;
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
