using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class SendInvitationResponse : IMessage<SendInvitationResponse>, IEquatable<SendInvitationResponse>, IDeepCloneable<SendInvitationResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SendInvitationResponse.__c __9 = new SendInvitationResponse.__c();

			internal SendInvitationResponse cctor>b__24_0()
			{
				return new SendInvitationResponse();
			}
		}

		private static readonly MessageParser<SendInvitationResponse> _parser = new MessageParser<SendInvitationResponse>(new Func<SendInvitationResponse>(SendInvitationResponse.__c.__9.<.cctor>b__24_0));

		public const int InvitationFieldNumber = 2;

		private Invitation invitation_;

		public static MessageParser<SendInvitationResponse> Parser
		{
			get
			{
				return SendInvitationResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendInvitationResponse.Descriptor;
			}
		}

		public Invitation Invitation
		{
			get
			{
				return this.invitation_;
			}
			set
			{
				this.invitation_ = value;
			}
		}

		public SendInvitationResponse()
		{
		}

		public SendInvitationResponse(SendInvitationResponse other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = 1657710906;
				while (true)
				{
					switch ((arg_2E_0 ^ 884992976) % 3)
					{
					case 1:
						this.Invitation = ((other.invitation_ != null) ? other.Invitation.Clone() : null);
						arg_2E_0 = 2008036035;
						continue;
					case 2:
						goto IL_44;
					}
					return;
				}
			}
		}

		public SendInvitationResponse Clone()
		{
			return new SendInvitationResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SendInvitationResponse);
		}

		public bool Equals(SendInvitationResponse other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ -799886851) % 7)
				{
				case 1:
					return false;
				case 2:
					goto IL_3E;
				case 3:
					return false;
				case 4:
					arg_48_0 = ((!SendInvitationResponse.smethod_0(this.Invitation, other.Invitation)) ? -311008703 : -1166603550);
					continue;
				case 5:
					goto IL_7A;
				case 6:
					return true;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1936641338;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -1078047457 : -1155175197);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 2488253992u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 2669238039u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 1u:
						num ^= SendInvitationResponse.smethod_1(this.Invitation);
						arg_4D_0 = (num2 * 1503231475u ^ 695963030u);
						continue;
					case 3u:
						arg_4D_0 = (((this.invitation_ == null) ? 1053878005u : 1861284014u) ^ num2 * 3803070460u);
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
			if (this.invitation_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 812594939u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 2060839406u)) % 4u)
						{
						case 0u:
							goto IL_5B;
						case 1u:
							output.WriteRawTag(18);
							arg_3F_0 = (num * 768386530u ^ 3487028131u);
							continue;
						case 3u:
							output.WriteMessage(this.Invitation);
							arg_3F_0 = (num * 3878601901u ^ 2977732207u);
							continue;
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
			if (this.invitation_ != null)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 978929698u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 1549666783u)) % 3u)
						{
						case 1u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
							arg_2E_0 = (num2 * 2207499234u ^ 3366098488u);
							continue;
						case 2u:
							goto IL_46;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(SendInvitationResponse other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 1117200954u)) % 7u)
				{
				case 0u:
					goto IL_B1;
				case 1u:
					this.invitation_ = new Invitation();
					arg_7A_0 = (num * 2612508560u ^ 3564039130u);
					continue;
				case 2u:
					arg_7A_0 = (((this.invitation_ == null) ? 708039692u : 1288204934u) ^ num * 3166136370u);
					continue;
				case 3u:
					goto IL_2D;
				case 4u:
					this.Invitation.MergeFrom(other.Invitation);
					arg_7A_0 = 1183684380u;
					continue;
				case 5u:
					return;
				}
				break;
			}
			return;
			IL_2D:
			arg_7A_0 = 707008351u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.invitation_ == null) ? 1183684380u : 958193940u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F3:
				uint num;
				uint arg_B3_0 = ((num = input.ReadTag()) != 0u) ? 381900891u : 1163231807u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 1760262813u)) % 9u)
					{
					case 1u:
						input.ReadMessage(this.invitation_);
						arg_B3_0 = 1066913849u;
						continue;
					case 2u:
						arg_B3_0 = ((num == 18u) ? 1038888405u : 1941290367u);
						continue;
					case 3u:
						this.invitation_ = new Invitation();
						arg_B3_0 = (num2 * 3449643963u ^ 188940281u);
						continue;
					case 4u:
						arg_B3_0 = 381900891u;
						continue;
					case 5u:
						arg_B3_0 = ((this.invitation_ == null) ? 782457185u : 292176621u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_B3_0 = (num2 * 2397627654u ^ 2994147970u);
						continue;
					case 7u:
						arg_B3_0 = (num2 * 2295918249u ^ 2266950130u);
						continue;
					case 8u:
						goto IL_F3;
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
