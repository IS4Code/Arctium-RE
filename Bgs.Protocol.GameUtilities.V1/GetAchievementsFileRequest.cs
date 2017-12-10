using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAchievementsFileRequest : IMessage<GetAchievementsFileRequest>, IEquatable<GetAchievementsFileRequest>, IDeepCloneable<GetAchievementsFileRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAchievementsFileRequest.__c __9 = new GetAchievementsFileRequest.__c();

			internal GetAchievementsFileRequest cctor>b__24_0()
			{
				return new GetAchievementsFileRequest();
			}
		}

		private static readonly MessageParser<GetAchievementsFileRequest> _parser = new MessageParser<GetAchievementsFileRequest>(new Func<GetAchievementsFileRequest>(GetAchievementsFileRequest.__c.__9.<.cctor>b__24_0));

		public const int HostFieldNumber = 1;

		private ProcessId host_;

		public static MessageParser<GetAchievementsFileRequest> Parser
		{
			get
			{
				return GetAchievementsFileRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAchievementsFileRequest.Descriptor;
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

		public GetAchievementsFileRequest()
		{
		}

		public GetAchievementsFileRequest(GetAchievementsFileRequest other) : this()
		{
			this.Host = ((other.host_ != null) ? other.Host.Clone() : null);
		}

		public GetAchievementsFileRequest Clone()
		{
			return new GetAchievementsFileRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAchievementsFileRequest);
		}

		public bool Equals(GetAchievementsFileRequest other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 960803077) % 7)
				{
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					arg_48_0 = ((!GetAchievementsFileRequest.smethod_0(this.Host, other.Host)) ? 219268756 : 1237394871);
					continue;
				case 5:
					goto IL_7A;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 564539200;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? 168076699 : 2013752118);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 4081816336u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 3884091701u)) % 4u)
					{
					case 1u:
						arg_4D_0 = (((this.host_ == null) ? 2722238817u : 3439394423u) ^ num2 * 2474616832u);
						continue;
					case 2u:
						num ^= GetAchievementsFileRequest.smethod_1(this.Host);
						arg_4D_0 = (num2 * 2350571084u ^ 3274660601u);
						continue;
					case 3u:
						goto IL_69;
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
			if (this.host_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 1906646536u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 1699423859u)) % 4u)
						{
						case 0u:
							goto IL_5B;
						case 1u:
							output.WriteMessage(this.Host);
							arg_3F_0 = (num * 3578540824u ^ 1718187197u);
							continue;
						case 3u:
							output.WriteRawTag(10);
							arg_3F_0 = (num * 2377326965u ^ 2994747261u);
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
			while (true)
			{
				IL_6B:
				uint arg_4F_0 = 3477843463u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4F_0 ^ 3834349897u)) % 4u)
					{
					case 0u:
						goto IL_6B;
					case 2u:
						arg_4F_0 = (((this.host_ == null) ? 994279886u : 1934560824u) ^ num2 * 854923703u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
						arg_4F_0 = (num2 * 3069497530u ^ 1038269186u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetAchievementsFileRequest other)
		{
			if (other == null)
			{
				goto IL_58;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 2294053253u)) % 7u)
				{
				case 0u:
					this.Host.MergeFrom(other.Host);
					arg_7A_0 = 3013838508u;
					continue;
				case 1u:
					goto IL_B1;
				case 2u:
					return;
				case 3u:
					goto IL_58;
				case 4u:
					this.host_ = new ProcessId();
					arg_7A_0 = (num * 3243608735u ^ 2450391225u);
					continue;
				case 5u:
					arg_7A_0 = (((this.host_ == null) ? 2834770261u : 2958050217u) ^ num * 3148935056u);
					continue;
				}
				break;
			}
			return;
			IL_58:
			arg_7A_0 = 2212885438u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.host_ != null) ? 2298601422u : 3013838508u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F0:
				uint num;
				uint arg_B0_0 = ((num = input.ReadTag()) != 0u) ? 1958159267u : 1274177388u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B0_0 ^ 455931694u)) % 9u)
					{
					case 0u:
						input.SkipLastField();
						arg_B0_0 = (num2 * 3362808843u ^ 1790925770u);
						continue;
					case 1u:
						input.ReadMessage(this.host_);
						arg_B0_0 = 781959145u;
						continue;
					case 2u:
						this.host_ = new ProcessId();
						arg_B0_0 = (num2 * 2391214092u ^ 3636397728u);
						continue;
					case 3u:
						goto IL_F0;
					case 4u:
						arg_B0_0 = 1958159267u;
						continue;
					case 5u:
						arg_B0_0 = ((this.host_ != null) ? 357026404u : 1542315669u);
						continue;
					case 6u:
						arg_B0_0 = (num2 * 3526348299u ^ 1942813606u);
						continue;
					case 7u:
						arg_B0_0 = ((num == 10u) ? 987677339u : 1280738997u);
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
