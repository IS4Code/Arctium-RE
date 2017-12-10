using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GetCAISInfoResponse : IMessage<GetCAISInfoResponse>, IEquatable<GetCAISInfoResponse>, IDeepCloneable<GetCAISInfoResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetCAISInfoResponse.__c __9 = new GetCAISInfoResponse.__c();

			internal GetCAISInfoResponse cctor>b__24_0()
			{
				return new GetCAISInfoResponse();
			}
		}

		private static readonly MessageParser<GetCAISInfoResponse> _parser = new MessageParser<GetCAISInfoResponse>(new Func<GetCAISInfoResponse>(GetCAISInfoResponse.__c.__9.<.cctor>b__24_0));

		public const int CaisInfoFieldNumber = 1;

		private CAIS caisInfo_;

		public static MessageParser<GetCAISInfoResponse> Parser
		{
			get
			{
				return GetCAISInfoResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[24];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCAISInfoResponse.Descriptor;
			}
		}

		public CAIS CaisInfo
		{
			get
			{
				return this.caisInfo_;
			}
			set
			{
				this.caisInfo_ = value;
			}
		}

		public GetCAISInfoResponse()
		{
		}

		public GetCAISInfoResponse(GetCAISInfoResponse other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = -1645473740;
				while (true)
				{
					switch ((arg_2E_0 ^ -1864088540) % 3)
					{
					case 0:
						goto IL_44;
					case 1:
						this.CaisInfo = ((other.caisInfo_ != null) ? other.CaisInfo.Clone() : null);
						arg_2E_0 = -1534720244;
						continue;
					}
					return;
				}
			}
		}

		public GetCAISInfoResponse Clone()
		{
			return new GetCAISInfoResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetCAISInfoResponse);
		}

		public bool Equals(GetCAISInfoResponse other)
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
				switch ((arg_48_0 ^ -20523666) % 7)
				{
				case 1:
					return true;
				case 2:
					goto IL_7A;
				case 3:
					return false;
				case 4:
					goto IL_3E;
				case 5:
					return false;
				case 6:
					arg_48_0 = (GetCAISInfoResponse.smethod_0(this.CaisInfo, other.CaisInfo) ? -177025624 : -1685401468);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1963159558;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -1547083614 : -1974903665);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 1437996059u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 14740586u)) % 4u)
					{
					case 1u:
						arg_4D_0 = (((this.caisInfo_ == null) ? 3875683289u : 2981558163u) ^ num2 * 2841513959u);
						continue;
					case 2u:
						num ^= GetCAISInfoResponse.smethod_1(this.CaisInfo);
						arg_4D_0 = (num2 * 4004892824u ^ 2015750014u);
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
			if (this.caisInfo_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 1787592141u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 1888031004u)) % 4u)
						{
						case 0u:
							output.WriteMessage(this.CaisInfo);
							arg_3F_0 = (num * 1939130696u ^ 1485397390u);
							continue;
						case 1u:
							output.WriteRawTag(10);
							arg_3F_0 = (num * 3841198728u ^ 4262831080u);
							continue;
						case 3u:
							goto IL_5B;
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
			if (this.caisInfo_ != null)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 1945233105u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 1444387294u)) % 3u)
						{
						case 1u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.CaisInfo);
							arg_2E_0 = (num2 * 1148751622u ^ 440114855u);
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

		public void MergeFrom(GetCAISInfoResponse other)
		{
			if (other == null)
			{
				goto IL_2F;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 2021516271u)) % 7u)
				{
				case 1u:
					this.CaisInfo.MergeFrom(other.CaisInfo);
					arg_7A_0 = 156656824u;
					continue;
				case 2u:
					goto IL_B1;
				case 3u:
					arg_7A_0 = (((this.caisInfo_ != null) ? 2235050151u : 2834346456u) ^ num * 292529578u);
					continue;
				case 4u:
					goto IL_2F;
				case 5u:
					return;
				case 6u:
					this.caisInfo_ = new CAIS();
					arg_7A_0 = (num * 131055207u ^ 3126584566u);
					continue;
				}
				break;
			}
			return;
			IL_2F:
			arg_7A_0 = 2062552310u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.caisInfo_ == null) ? 156656824u : 1552759712u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_DC:
				uint num;
				uint arg_A1_0 = ((num = input.ReadTag()) == 0u) ? 1820014638u : 1232393844u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A1_0 ^ 1724917681u)) % 8u)
					{
					case 0u:
						goto IL_DC;
					case 1u:
						input.SkipLastField();
						arg_A1_0 = (num2 * 3635837598u ^ 901074639u);
						continue;
					case 2u:
						input.ReadMessage(this.caisInfo_);
						arg_A1_0 = 367298625u;
						continue;
					case 3u:
						arg_A1_0 = ((this.caisInfo_ == null) ? 538335535u : 1600834323u);
						continue;
					case 4u:
						arg_A1_0 = 1232393844u;
						continue;
					case 5u:
						arg_A1_0 = ((num != 10u) ? 273451832u : 1005983786u);
						continue;
					case 6u:
						this.caisInfo_ = new CAIS();
						arg_A1_0 = (num2 * 2545523083u ^ 2664163033u);
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
