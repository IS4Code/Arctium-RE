using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class UpdateInvitationRequest : IMessage<UpdateInvitationRequest>, IEquatable<UpdateInvitationRequest>, IDeepCloneable<UpdateInvitationRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly UpdateInvitationRequest.__c __9 = new UpdateInvitationRequest.__c();

			internal UpdateInvitationRequest cctor>b__34_0()
			{
				return new UpdateInvitationRequest();
			}
		}

		private static readonly MessageParser<UpdateInvitationRequest> _parser = new MessageParser<UpdateInvitationRequest>(new Func<UpdateInvitationRequest>(UpdateInvitationRequest.__c.__9.<.cctor>b__34_0));

		public const int AgentIdentityFieldNumber = 1;

		private Identity agentIdentity_;

		public const int InvitationIdFieldNumber = 2;

		private ulong invitationId_;

		public const int ParamsFieldNumber = 3;

		private InvitationParams params_;

		public static MessageParser<UpdateInvitationRequest> Parser
		{
			get
			{
				return UpdateInvitationRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateInvitationRequest.Descriptor;
			}
		}

		public Identity AgentIdentity
		{
			get
			{
				return this.agentIdentity_;
			}
			set
			{
				this.agentIdentity_ = value;
			}
		}

		public ulong InvitationId
		{
			get
			{
				return this.invitationId_;
			}
			set
			{
				this.invitationId_ = value;
			}
		}

		public InvitationParams Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = value;
			}
		}

		public UpdateInvitationRequest()
		{
		}

		public UpdateInvitationRequest(UpdateInvitationRequest other) : this()
		{
			this.AgentIdentity = ((other.agentIdentity_ != null) ? other.AgentIdentity.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this.Params = ((other.params_ != null) ? other.Params.Clone() : null);
		}

		public UpdateInvitationRequest Clone()
		{
			return new UpdateInvitationRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateInvitationRequest);
		}

		public bool Equals(UpdateInvitationRequest other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_EA;
			int arg_A4_0;
			while (true)
			{
				IL_9F:
				switch ((arg_A4_0 ^ -1191757984) % 11)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					goto IL_9A;
				case 3:
					return false;
				case 4:
					arg_A4_0 = (UpdateInvitationRequest.smethod_0(this.Params, other.Params) ? -1995235699 : -1752788712);
					continue;
				case 5:
					arg_A4_0 = ((this.InvitationId == other.InvitationId) ? -1005537946 : -1627100552);
					continue;
				case 7:
					arg_A4_0 = ((!UpdateInvitationRequest.smethod_0(this.AgentIdentity, other.AgentIdentity)) ? -425025588 : -1913331405);
					continue;
				case 8:
					return false;
				case 9:
					return true;
				case 10:
					goto IL_EA;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = -941516265;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other == this) ? -636219642 : -1613667757);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.agentIdentity_ != null)
			{
				goto IL_1C;
			}
			goto IL_8F;
			uint arg_63_0;
			while (true)
			{
				IL_5E:
				uint num2;
				switch ((num2 = (arg_63_0 ^ 3571811806u)) % 5u)
				{
				case 1u:
					goto IL_8F;
				case 2u:
					num ^= UpdateInvitationRequest.smethod_1(this.AgentIdentity);
					arg_63_0 = (num2 * 1932585292u ^ 1125625719u);
					continue;
				case 3u:
					num ^= this.InvitationId.GetHashCode();
					arg_63_0 = (num2 * 3687887507u ^ 2415816799u);
					continue;
				case 4u:
					goto IL_1C;
				}
				break;
			}
			return num ^ this.Params.GetHashCode();
			IL_1C:
			arg_63_0 = 3215074705u;
			goto IL_5E;
			IL_8F:
			arg_63_0 = ((this.InvitationId == 0uL) ? 2561355809u : 3166081940u);
			goto IL_5E;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.agentIdentity_ != null)
			{
				goto IL_1A;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 2852101716u)) % 6u)
				{
				case 1u:
					output.WriteRawTag(26);
					arg_79_0 = 4255135418u;
					continue;
				case 2u:
					output.WriteRawTag(10);
					output.WriteMessage(this.AgentIdentity);
					arg_79_0 = (num * 2992231922u ^ 2433363271u);
					continue;
				case 3u:
					goto IL_AC;
				case 4u:
					output.WriteRawTag(17);
					output.WriteFixed64(this.InvitationId);
					arg_79_0 = (num * 3156020748u ^ 2452939947u);
					continue;
				case 5u:
					goto IL_1A;
				}
				break;
			}
			output.WriteMessage(this.Params);
			return;
			IL_1A:
			arg_79_0 = 3282393852u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.InvitationId != 0uL) ? 4108054614u : 3687293107u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.agentIdentity_ != null)
			{
				goto IL_1C;
			}
			goto IL_A3;
			uint arg_70_0;
			while (true)
			{
				IL_6B:
				uint num2;
				switch ((num2 = (arg_70_0 ^ 2631024271u)) % 6u)
				{
				case 0u:
					goto IL_A3;
				case 1u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentIdentity);
					arg_70_0 = (num2 * 675778288u ^ 3426741437u);
					continue;
				case 2u:
					num += 9;
					arg_70_0 = (num2 * 3994606705u ^ 83634614u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Params);
					arg_70_0 = 3738218999u;
					continue;
				case 5u:
					goto IL_1C;
				}
				break;
			}
			return num;
			IL_1C:
			arg_70_0 = 2774955586u;
			goto IL_6B;
			IL_A3:
			arg_70_0 = ((this.InvitationId == 0uL) ? 4046459706u : 2469259203u);
			goto IL_6B;
		}

		public void MergeFrom(UpdateInvitationRequest other)
		{
			if (other == null)
			{
				goto IL_9D;
			}
			goto IL_197;
			uint arg_147_0;
			while (true)
			{
				IL_142:
				uint num;
				switch ((num = (arg_147_0 ^ 3419895316u)) % 13u)
				{
				case 0u:
					arg_147_0 = ((other.InvitationId != 0uL) ? 2572791920u : 3915150824u);
					continue;
				case 1u:
					this.params_ = new InvitationParams();
					arg_147_0 = (num * 4160504387u ^ 580811139u);
					continue;
				case 2u:
					arg_147_0 = ((other.params_ == null) ? 3281686707u : 2950319505u);
					continue;
				case 3u:
					this.Params.MergeFrom(other.Params);
					arg_147_0 = 3281686707u;
					continue;
				case 4u:
					arg_147_0 = (((this.agentIdentity_ != null) ? 3432823966u : 2588968177u) ^ num * 2930672746u);
					continue;
				case 5u:
					return;
				case 7u:
					goto IL_197;
				case 8u:
					goto IL_9D;
				case 9u:
					this.AgentIdentity.MergeFrom(other.AgentIdentity);
					arg_147_0 = 3772748690u;
					continue;
				case 10u:
					arg_147_0 = (((this.params_ != null) ? 3468432509u : 4002311560u) ^ num * 3832455785u);
					continue;
				case 11u:
					this.InvitationId = other.InvitationId;
					arg_147_0 = (num * 2396792908u ^ 772730968u);
					continue;
				case 12u:
					this.agentIdentity_ = new Identity();
					arg_147_0 = (num * 2100483122u ^ 3363296762u);
					continue;
				}
				break;
			}
			return;
			IL_9D:
			arg_147_0 = 4011299193u;
			goto IL_142;
			IL_197:
			arg_147_0 = ((other.agentIdentity_ == null) ? 3772748690u : 3752331941u);
			goto IL_142;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1E0:
				uint num;
				uint arg_184_0 = ((num = input.ReadTag()) == 0u) ? 1945179017u : 1731948863u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_184_0 ^ 1979769374u)) % 16u)
					{
					case 0u:
						input.ReadMessage(this.agentIdentity_);
						arg_184_0 = 424671874u;
						continue;
					case 1u:
						arg_184_0 = ((num != 10u) ? 2120989571u : 1653001179u);
						continue;
					case 2u:
						arg_184_0 = (num2 * 1165877852u ^ 1936218991u);
						continue;
					case 3u:
						input.ReadMessage(this.params_);
						arg_184_0 = 366593111u;
						continue;
					case 4u:
						arg_184_0 = (((num != 26u) ? 3674701580u : 3690475240u) ^ num2 * 3198846002u);
						continue;
					case 5u:
						arg_184_0 = ((this.agentIdentity_ == null) ? 249290216u : 310993998u);
						continue;
					case 6u:
						this.agentIdentity_ = new Identity();
						arg_184_0 = (num2 * 1128817607u ^ 164871796u);
						continue;
					case 8u:
						this.InvitationId = input.ReadFixed64();
						arg_184_0 = 366593111u;
						continue;
					case 9u:
						goto IL_1E0;
					case 10u:
						input.SkipLastField();
						arg_184_0 = (num2 * 2661260473u ^ 1280677974u);
						continue;
					case 11u:
						arg_184_0 = 1731948863u;
						continue;
					case 12u:
						arg_184_0 = (num2 * 1615877193u ^ 4156092459u);
						continue;
					case 13u:
						arg_184_0 = (((num != 17u) ? 915696769u : 1838321597u) ^ num2 * 4144204039u);
						continue;
					case 14u:
						arg_184_0 = ((this.params_ != null) ? 1736599405u : 1192825713u);
						continue;
					case 15u:
						this.params_ = new InvitationParams();
						arg_184_0 = (num2 * 2095530672u ^ 1992293693u);
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
