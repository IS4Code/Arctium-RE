using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAuthorizedDataRequest : IMessage<GetAuthorizedDataRequest>, IEquatable<GetAuthorizedDataRequest>, IDeepCloneable<GetAuthorizedDataRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAuthorizedDataRequest.__c __9 = new GetAuthorizedDataRequest.__c();

			internal GetAuthorizedDataRequest cctor>b__34_0()
			{
				return new GetAuthorizedDataRequest();
			}
		}

		private static readonly MessageParser<GetAuthorizedDataRequest> _parser = new MessageParser<GetAuthorizedDataRequest>(new Func<GetAuthorizedDataRequest>(GetAuthorizedDataRequest.__c.__9.<.cctor>b__34_0));

		public const int EntityIdFieldNumber = 1;

		private EntityId entityId_;

		public const int TagFieldNumber = 2;

		private static readonly FieldCodec<string> _repeated_tag_codec = FieldCodec.ForString(18u);

		private readonly RepeatedField<string> tag_ = new RepeatedField<string>();

		public const int PrivilegedNetworkFieldNumber = 3;

		private bool privilegedNetwork_;

		public static MessageParser<GetAuthorizedDataRequest> Parser
		{
			get
			{
				return GetAuthorizedDataRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[26];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAuthorizedDataRequest.Descriptor;
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

		public RepeatedField<string> Tag
		{
			get
			{
				return this.tag_;
			}
		}

		public bool PrivilegedNetwork
		{
			get
			{
				return this.privilegedNetwork_;
			}
			set
			{
				this.privilegedNetwork_ = value;
			}
		}

		public GetAuthorizedDataRequest()
		{
		}

		public GetAuthorizedDataRequest(GetAuthorizedDataRequest other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = 411880156;
				while (true)
				{
					switch ((arg_2E_0 ^ 253295107) % 3)
					{
					case 0:
						goto IL_44;
					case 1:
						this.EntityId = ((other.entityId_ != null) ? other.EntityId.Clone() : null);
						arg_2E_0 = 64999162;
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.tag_ = other.tag_.Clone();
			this.privilegedNetwork_ = other.privilegedNetwork_;
		}

		public GetAuthorizedDataRequest Clone()
		{
			return new GetAuthorizedDataRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAuthorizedDataRequest);
		}

		public bool Equals(GetAuthorizedDataRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ 1049770579) % 11)
				{
				case 0:
					arg_A1_0 = ((!this.tag_.Equals(other.tag_)) ? 1866995938 : 1359098599);
					continue;
				case 1:
					return false;
				case 3:
					return false;
				case 4:
					arg_A1_0 = (GetAuthorizedDataRequest.smethod_0(this.EntityId, other.EntityId) ? 1904281011 : 2050886190);
					continue;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_E7;
				case 8:
					return true;
				case 9:
					arg_A1_0 = ((this.PrivilegedNetwork != other.PrivilegedNetwork) ? 2015332713 : 683295574);
					continue;
				case 10:
					goto IL_18;
				}
				break;
			}
			return true;
			IL_18:
			arg_A1_0 = 97895365;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other == this) ? 59884591 : 304797678);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D6:
				uint arg_AE_0 = 1676625961u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AE_0 ^ 813048434u)) % 7u)
					{
					case 1u:
						arg_AE_0 = (((this.entityId_ == null) ? 4069462313u : 3002962258u) ^ num2 * 2827610088u);
						continue;
					case 2u:
						goto IL_D6;
					case 3u:
						num ^= GetAuthorizedDataRequest.smethod_1(this.EntityId);
						arg_AE_0 = (num2 * 3926748413u ^ 3673390249u);
						continue;
					case 4u:
						num ^= this.PrivilegedNetwork.GetHashCode();
						arg_AE_0 = (num2 * 2542054564u ^ 1361671118u);
						continue;
					case 5u:
						num ^= GetAuthorizedDataRequest.smethod_1(this.tag_);
						arg_AE_0 = 418574998u;
						continue;
					case 6u:
						arg_AE_0 = ((this.PrivilegedNetwork ? 1760644900u : 688735890u) ^ num2 * 844869613u);
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
			if (this.entityId_ != null)
			{
				goto IL_0B;
			}
			goto IL_D1;
			uint arg_A5_0;
			while (true)
			{
				IL_A0:
				uint num;
				switch ((num = (arg_A5_0 ^ 2183881433u)) % 8u)
				{
				case 0u:
					arg_A5_0 = (((!this.PrivilegedNetwork) ? 238862922u : 1288727080u) ^ num * 3447973964u);
					continue;
				case 1u:
					output.WriteRawTag(24);
					arg_A5_0 = (num * 2681821802u ^ 1195759663u);
					continue;
				case 2u:
					output.WriteMessage(this.EntityId);
					arg_A5_0 = (num * 2079688325u ^ 1180763132u);
					continue;
				case 4u:
					output.WriteBool(this.PrivilegedNetwork);
					arg_A5_0 = (num * 2647748961u ^ 548420886u);
					continue;
				case 5u:
					output.WriteRawTag(10);
					arg_A5_0 = (num * 1672041261u ^ 163994066u);
					continue;
				case 6u:
					goto IL_0B;
				case 7u:
					goto IL_D1;
				}
				break;
			}
			return;
			IL_0B:
			arg_A5_0 = 4042311692u;
			goto IL_A0;
			IL_D1:
			this.tag_.WriteTo(output, GetAuthorizedDataRequest._repeated_tag_codec);
			arg_A5_0 = 3305042913u;
			goto IL_A0;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.entityId_ != null)
			{
				goto IL_0D;
			}
			goto IL_96;
			uint arg_72_0;
			while (true)
			{
				IL_6D:
				uint num2;
				switch ((num2 = (arg_72_0 ^ 1429821198u)) % 6u)
				{
				case 1u:
					num += 2;
					arg_72_0 = (num2 * 3899569780u ^ 765317886u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
					arg_72_0 = (num2 * 1808153319u ^ 3566691338u);
					continue;
				case 3u:
					arg_72_0 = ((this.PrivilegedNetwork ? 167672933u : 1376372942u) ^ num2 * 4123531628u);
					continue;
				case 4u:
					goto IL_96;
				case 5u:
					goto IL_0D;
				}
				break;
			}
			return num;
			IL_0D:
			arg_72_0 = 346699230u;
			goto IL_6D;
			IL_96:
			num += this.tag_.CalculateSize(GetAuthorizedDataRequest._repeated_tag_codec);
			arg_72_0 = 1572702427u;
			goto IL_6D;
		}

		public void MergeFrom(GetAuthorizedDataRequest other)
		{
			if (other == null)
			{
				goto IL_5C;
			}
			goto IL_120;
			uint arg_DC_0;
			while (true)
			{
				IL_D7:
				uint num;
				switch ((num = (arg_DC_0 ^ 2101225724u)) % 10u)
				{
				case 0u:
					this.EntityId.MergeFrom(other.EntityId);
					arg_DC_0 = 1675355494u;
					continue;
				case 1u:
					arg_DC_0 = (((this.entityId_ != null) ? 1233190537u : 770094727u) ^ num * 948408821u);
					continue;
				case 2u:
					this.entityId_ = new EntityId();
					arg_DC_0 = (num * 4226767462u ^ 2781405726u);
					continue;
				case 3u:
					return;
				case 4u:
					this.PrivilegedNetwork = other.PrivilegedNetwork;
					arg_DC_0 = (num * 8702870u ^ 1316778094u);
					continue;
				case 5u:
					goto IL_120;
				case 7u:
					goto IL_5C;
				case 8u:
					this.tag_.Add(other.tag_);
					arg_DC_0 = 204656187u;
					continue;
				case 9u:
					arg_DC_0 = (((!other.PrivilegedNetwork) ? 1924101121u : 65655571u) ^ num * 594608665u);
					continue;
				}
				break;
			}
			return;
			IL_5C:
			arg_DC_0 = 1899230793u;
			goto IL_D7;
			IL_120:
			arg_DC_0 = ((other.entityId_ != null) ? 4675503u : 1675355494u);
			goto IL_D7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) == 0u) ? 2149067814u : 3881170608u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 3041056606u)) % 14u)
					{
					case 0u:
						arg_145_0 = 3881170608u;
						continue;
					case 1u:
						this.PrivilegedNetwork = input.ReadBool();
						arg_145_0 = 3652740355u;
						continue;
					case 2u:
						arg_145_0 = (num2 * 1567258661u ^ 2425374199u);
						continue;
					case 3u:
						input.ReadMessage(this.entityId_);
						arg_145_0 = 3282532292u;
						continue;
					case 4u:
						arg_145_0 = (((num != 24u) ? 935152125u : 414101071u) ^ num2 * 1958717415u);
						continue;
					case 5u:
						this.entityId_ = new EntityId();
						arg_145_0 = (num2 * 1121040908u ^ 2755985661u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_145_0 = (num2 * 924377564u ^ 2262142006u);
						continue;
					case 8u:
						arg_145_0 = ((num != 10u) ? 3138347249u : 3086822283u);
						continue;
					case 9u:
						arg_145_0 = ((this.entityId_ != null) ? 2226119377u : 3848157191u);
						continue;
					case 10u:
						this.tag_.AddEntriesFrom(input, GetAuthorizedDataRequest._repeated_tag_codec);
						arg_145_0 = 3652740355u;
						continue;
					case 11u:
						arg_145_0 = (((num != 18u) ? 1524515635u : 881449773u) ^ num2 * 474276569u);
						continue;
					case 12u:
						arg_145_0 = (num2 * 1722097871u ^ 1857714565u);
						continue;
					case 13u:
						goto IL_199;
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
