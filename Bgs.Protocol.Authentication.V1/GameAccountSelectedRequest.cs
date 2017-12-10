using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class GameAccountSelectedRequest : IMessage<GameAccountSelectedRequest>, IEquatable<GameAccountSelectedRequest>, IDeepCloneable<GameAccountSelectedRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameAccountSelectedRequest.__c __9 = new GameAccountSelectedRequest.__c();

			internal GameAccountSelectedRequest cctor>b__29_0()
			{
				return new GameAccountSelectedRequest();
			}
		}

		private static readonly MessageParser<GameAccountSelectedRequest> _parser = new MessageParser<GameAccountSelectedRequest>(new Func<GameAccountSelectedRequest>(GameAccountSelectedRequest.__c.__9.<.cctor>b__29_0));

		public const int ResultFieldNumber = 1;

		private uint result_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public static MessageParser<GameAccountSelectedRequest> Parser
		{
			get
			{
				return GameAccountSelectedRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[16];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountSelectedRequest.Descriptor;
			}
		}

		public uint Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		public GameAccountSelectedRequest()
		{
		}

		public GameAccountSelectedRequest(GameAccountSelectedRequest other) : this()
		{
			this.result_ = other.result_;
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
		}

		public GameAccountSelectedRequest Clone()
		{
			return new GameAccountSelectedRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountSelectedRequest);
		}

		public bool Equals(GameAccountSelectedRequest other)
		{
			if (other == null)
			{
				goto IL_41;
			}
			goto IL_B0;
			int arg_72_0;
			while (true)
			{
				IL_6D:
				switch ((arg_72_0 ^ 1231102829) % 9)
				{
				case 0:
					goto IL_B0;
				case 1:
					arg_72_0 = ((this.Result != other.Result) ? 1613309053 : 688743851);
					continue;
				case 2:
					goto IL_41;
				case 3:
					return false;
				case 4:
					return false;
				case 6:
					return false;
				case 7:
					arg_72_0 = ((!GameAccountSelectedRequest.smethod_0(this.GameAccountId, other.GameAccountId)) ? 614453928 : 1016538616);
					continue;
				case 8:
					return true;
				}
				break;
			}
			return true;
			IL_41:
			arg_72_0 = 2013261718;
			goto IL_6D;
			IL_B0:
			arg_72_0 = ((other != this) ? 1666204037 : 54047534);
			goto IL_6D;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_7A:
				uint arg_5E_0 = 1925848129u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5E_0 ^ 2046370864u)) % 4u)
					{
					case 1u:
						num ^= this.Result.GetHashCode();
						arg_5E_0 = (((this.gameAccountId_ != null) ? 2476017180u : 3639015982u) ^ num2 * 3062255914u);
						continue;
					case 2u:
						num ^= this.GameAccountId.GetHashCode();
						arg_5E_0 = (num2 * 3682886118u ^ 2172377216u);
						continue;
					case 3u:
						goto IL_7A;
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
			output.WriteRawTag(8);
			while (true)
			{
				IL_96:
				uint arg_76_0 = 2945661096u;
				while (true)
				{
					uint num;
					switch ((num = (arg_76_0 ^ 3639963850u)) % 5u)
					{
					case 1u:
						output.WriteUInt32(this.Result);
						arg_76_0 = (num * 1325381911u ^ 2051547615u);
						continue;
					case 2u:
						goto IL_96;
					case 3u:
						arg_76_0 = (((this.gameAccountId_ != null) ? 654720575u : 1181479780u) ^ num * 2821488695u);
						continue;
					case 4u:
						output.WriteRawTag(18);
						output.WriteMessage(this.GameAccountId);
						arg_76_0 = (num * 117333958u ^ 3967108281u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_7B:
				uint arg_5F_0 = 3871845381u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5F_0 ^ 4027619206u)) % 4u)
					{
					case 0u:
						goto IL_7B;
					case 1u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_5F_0 = (num2 * 2837001384u ^ 1612172860u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Result);
						arg_5F_0 = (((this.gameAccountId_ == null) ? 3696635493u : 3015637334u) ^ num2 * 3656224379u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameAccountSelectedRequest other)
		{
			if (other == null)
			{
				goto IL_54;
			}
			goto IL_FC;
			uint arg_BC_0;
			while (true)
			{
				IL_B7:
				uint num;
				switch ((num = (arg_BC_0 ^ 3083016765u)) % 9u)
				{
				case 0u:
					this.Result = other.Result;
					arg_BC_0 = (num * 2359437629u ^ 942660998u);
					continue;
				case 1u:
					this.gameAccountId_ = new EntityId();
					arg_BC_0 = (num * 2052484588u ^ 229593190u);
					continue;
				case 2u:
					arg_BC_0 = (((this.gameAccountId_ != null) ? 81773963u : 274863240u) ^ num * 1785518467u);
					continue;
				case 3u:
					goto IL_FC;
				case 4u:
					goto IL_54;
				case 5u:
					arg_BC_0 = ((other.gameAccountId_ != null) ? 2922043090u : 3804220162u);
					continue;
				case 6u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_BC_0 = 3804220162u;
					continue;
				case 8u:
					return;
				}
				break;
			}
			return;
			IL_54:
			arg_BC_0 = 3075276873u;
			goto IL_B7;
			IL_FC:
			arg_BC_0 = ((other.Result == 0u) ? 2714855696u : 2368466547u);
			goto IL_B7;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_14F:
				uint num;
				uint arg_103_0 = ((num = input.ReadTag()) != 0u) ? 1548516507u : 1020247418u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_103_0 ^ 1019864074u)) % 12u)
					{
					case 1u:
						arg_103_0 = ((num != 8u) ? 1746257208u : 1907664673u);
						continue;
					case 2u:
						this.gameAccountId_ = new EntityId();
						arg_103_0 = (num2 * 3221857946u ^ 4055922806u);
						continue;
					case 3u:
						this.Result = input.ReadUInt32();
						arg_103_0 = 560929765u;
						continue;
					case 4u:
						input.ReadMessage(this.gameAccountId_);
						arg_103_0 = 144012006u;
						continue;
					case 5u:
						arg_103_0 = 1548516507u;
						continue;
					case 6u:
						arg_103_0 = (((num != 18u) ? 2865069496u : 2360699291u) ^ num2 * 3024415828u);
						continue;
					case 7u:
						arg_103_0 = (num2 * 3644815762u ^ 3700064560u);
						continue;
					case 8u:
						goto IL_14F;
					case 9u:
						arg_103_0 = ((this.gameAccountId_ != null) ? 1828344722u : 275264688u);
						continue;
					case 10u:
						input.SkipLastField();
						arg_103_0 = (num2 * 2566610462u ^ 314941589u);
						continue;
					case 11u:
						arg_103_0 = (num2 * 764129279u ^ 2760319735u);
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
	}
}
