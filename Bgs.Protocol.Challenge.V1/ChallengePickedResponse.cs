using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Challenge.V1
{
	[DebuggerNonUserCode]
	public sealed class ChallengePickedResponse : IMessage<ChallengePickedResponse>, IEquatable<ChallengePickedResponse>, IDeepCloneable<ChallengePickedResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ChallengePickedResponse.__c __9 = new ChallengePickedResponse.__c();

			internal ChallengePickedResponse cctor>b__24_0()
			{
				return new ChallengePickedResponse();
			}
		}

		private static readonly MessageParser<ChallengePickedResponse> _parser = new MessageParser<ChallengePickedResponse>(new Func<ChallengePickedResponse>(ChallengePickedResponse.__c.__9.<.cctor>b__24_0));

		public const int DataFieldNumber = 1;

		private ByteString data_ = ByteString.Empty;

		public static MessageParser<ChallengePickedResponse> Parser
		{
			get
			{
				return ChallengePickedResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengePickedResponse.Descriptor;
			}
		}

		public ByteString Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = Preconditions.CheckNotNull<ByteString>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public ChallengePickedResponse()
		{
		}

		public ChallengePickedResponse(ChallengePickedResponse other) : this()
		{
			while (true)
			{
				IL_3E:
				uint arg_26_0 = 2805006404u;
				while (true)
				{
					uint num;
					switch ((num = (arg_26_0 ^ 3179147556u)) % 3u)
					{
					case 0u:
						goto IL_3E;
					case 1u:
						this.data_ = other.data_;
						arg_26_0 = (num * 1947258650u ^ 2659167506u);
						continue;
					}
					return;
				}
			}
		}

		public ChallengePickedResponse Clone()
		{
			return new ChallengePickedResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengePickedResponse);
		}

		public bool Equals(ChallengePickedResponse other)
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
				switch ((arg_48_0 ^ -87630199) % 7)
				{
				case 0:
					goto IL_7A;
				case 1:
					arg_48_0 = ((this.Data != other.Data) ? -896903363 : -1889824472);
					continue;
				case 2:
					goto IL_12;
				case 3:
					return true;
				case 4:
					return false;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -1849173859;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -2138460242 : -549314834);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_6E:
				uint arg_52_0 = 1760463255u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_52_0 ^ 649614973u)) % 4u)
					{
					case 1u:
						num ^= ChallengePickedResponse.smethod_0(this.Data);
						arg_52_0 = (num2 * 2309627541u ^ 3187575080u);
						continue;
					case 2u:
						arg_52_0 = (((this.Data.Length == 0) ? 2805514967u : 3638764182u) ^ num2 * 3101521713u);
						continue;
					case 3u:
						goto IL_6E;
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
			if (this.Data.Length != 0)
			{
				while (true)
				{
					IL_60:
					uint arg_44_0 = 2743080734u;
					while (true)
					{
						uint num;
						switch ((num = (arg_44_0 ^ 2908246661u)) % 4u)
						{
						case 0u:
							goto IL_60;
						case 1u:
							output.WriteBytes(this.Data);
							arg_44_0 = (num * 1625214539u ^ 2049915632u);
							continue;
						case 3u:
							output.WriteRawTag(10);
							arg_44_0 = (num * 4209332291u ^ 3369884993u);
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
			if (this.Data.Length != 0)
			{
				while (true)
				{
					IL_4B:
					uint arg_33_0 = 3010724146u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_33_0 ^ 3690942653u)) % 3u)
						{
						case 0u:
							goto IL_4B;
						case 2u:
							num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
							arg_33_0 = (num2 * 2667910640u ^ 992826152u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(ChallengePickedResponse other)
		{
			if (other == null)
			{
				goto IL_2D;
			}
			goto IL_63;
			uint arg_37_0;
			while (true)
			{
				IL_32:
				uint num;
				switch ((num = (arg_37_0 ^ 1439505469u)) % 5u)
				{
				case 0u:
					goto IL_2D;
				case 1u:
					goto IL_63;
				case 3u:
					this.Data = other.Data;
					arg_37_0 = (num * 3013708504u ^ 4268836230u);
					continue;
				case 4u:
					return;
				}
				break;
			}
			return;
			IL_2D:
			arg_37_0 = 1907645714u;
			goto IL_32;
			IL_63:
			arg_37_0 = ((other.Data.Length != 0) ? 369386015u : 387155254u);
			goto IL_32;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_96:
				uint num;
				uint arg_63_0 = ((num = input.ReadTag()) != 0u) ? 753317514u : 1279041146u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_63_0 ^ 1972414482u)) % 6u)
					{
					case 1u:
						goto IL_96;
					case 2u:
						arg_63_0 = ((num != 10u) ? 2018434581u : 878510082u);
						continue;
					case 3u:
						input.SkipLastField();
						arg_63_0 = (num2 * 2757638124u ^ 768878309u);
						continue;
					case 4u:
						this.Data = input.ReadBytes();
						arg_63_0 = 1255565713u;
						continue;
					case 5u:
						arg_63_0 = 753317514u;
						continue;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
