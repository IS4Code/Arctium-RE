using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class SendChallengeToUserResponse : IMessage<SendChallengeToUserResponse>, IEquatable<SendChallengeToUserResponse>, IDeepCloneable<SendChallengeToUserResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SendChallengeToUserResponse.__c __9 = new SendChallengeToUserResponse.__c();

			internal SendChallengeToUserResponse cctor>b__24_0()
			{
				return new SendChallengeToUserResponse();
			}
		}

		private static readonly MessageParser<SendChallengeToUserResponse> _parser = new MessageParser<SendChallengeToUserResponse>(new Func<SendChallengeToUserResponse>(SendChallengeToUserResponse.__c.__9.<.cctor>b__24_0));

		public const int IdFieldNumber = 1;

		private uint id_;

		public static MessageParser<SendChallengeToUserResponse> Parser
		{
			get
			{
				return SendChallengeToUserResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendChallengeToUserResponse.Descriptor;
			}
		}

		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		public SendChallengeToUserResponse()
		{
		}

		public SendChallengeToUserResponse(SendChallengeToUserResponse other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 567720194u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 683765103u)) % 3u)
					{
					case 0u:
						goto IL_3E;
					case 2u:
						this.id_ = other.id_;
						arg_26_0 = (num * 3875838278u ^ 1413634056u);
						continue;
					}
					return;
				}
			}
		}

		public SendChallengeToUserResponse Clone()
		{
			return new SendChallengeToUserResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SendChallengeToUserResponse);
		}

		public bool Equals(SendChallengeToUserResponse other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_75;
			int arg_43_0;
			while (true)
			{
				IL_3E:
				switch ((arg_43_0 ^ -1585371029) % 7)
				{
				case 1:
					return false;
				case 2:
					arg_43_0 = ((this.Id == other.Id) ? -1220501530 : -2089021917);
					continue;
				case 3:
					return true;
				case 4:
					goto IL_12;
				case 5:
					return false;
				case 6:
					goto IL_75;
				}
				break;
			}
			return true;
			IL_12:
			arg_43_0 = -1079337530;
			goto IL_3E;
			IL_75:
			arg_43_0 = ((other != this) ? -698115180 : -1586180064);
			goto IL_3E;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6C:
				uint arg_50_0 = 3505358641u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_50_0 ^ 3724596583u)) % 4u)
					{
					case 1u:
						num ^= this.Id.GetHashCode();
						arg_50_0 = (num2 * 4137887214u ^ 2571471181u);
						continue;
					case 2u:
						arg_50_0 = (((this.Id == 0u) ? 2940849575u : 2865091442u) ^ num2 * 1482096342u);
						continue;
					case 3u:
						goto IL_6C;
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
			if (this.Id != 0u)
			{
				while (true)
				{
					IL_5A:
					uint arg_3E_0 = 3113054620u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3E_0 ^ 2801760683u)) % 4u)
						{
						case 0u:
							goto IL_5A;
						case 2u:
							output.WriteUInt32(this.Id);
							arg_3E_0 = (num * 1056603098u ^ 4120282494u);
							continue;
						case 3u:
							output.WriteRawTag(8);
							arg_3E_0 = (num * 137703656u ^ 2642869953u);
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
			if (this.Id != 0u)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 1926666305u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 367983422u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 1u:
							num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
							arg_2E_0 = (num2 * 844415134u ^ 243911233u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(SendChallengeToUserResponse other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 4132920506u)) % 5u)
				{
				case 0u:
					goto IL_63;
				case 1u:
					this.Id = other.Id;
					arg_37_0 = (num * 2892930602u ^ 4202310922u);
					continue;
				case 2u:
					goto IL_12;
				case 3u:
					return;
				}
				break;
			}
			return;
			IL_12:
			arg_37_0 = 2686637141u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Id == 0u) ? 3111154168u : 3757049455u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_95:
				uint num;
				uint arg_62_0 = ((num = input.ReadTag()) != 0u) ? 2436697995u : 2988155914u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_62_0 ^ 3614959017u)) % 6u)
					{
					case 0u:
						this.Id = input.ReadUInt32();
						arg_62_0 = 4214667437u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_62_0 = (num2 * 3760131431u ^ 1148809580u);
						continue;
					case 2u:
						goto IL_95;
					case 3u:
						arg_62_0 = 2436697995u;
						continue;
					case 4u:
						arg_62_0 = ((num != 8u) ? 3240962878u : 3307727707u);
						continue;
					}
					return;
				}
			}
		}
	}
}
