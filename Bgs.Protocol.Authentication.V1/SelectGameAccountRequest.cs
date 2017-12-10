using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class SelectGameAccountRequest : IMessage<SelectGameAccountRequest>, IEquatable<SelectGameAccountRequest>, IDeepCloneable<SelectGameAccountRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SelectGameAccountRequest.__c __9 = new SelectGameAccountRequest.__c();

			internal SelectGameAccountRequest cctor>b__24_0()
			{
				return new SelectGameAccountRequest();
			}
		}

		private static readonly MessageParser<SelectGameAccountRequest> _parser = new MessageParser<SelectGameAccountRequest>(new Func<SelectGameAccountRequest>(SelectGameAccountRequest.__c.__9.<.cctor>b__24_0));

		public const int GameAccountIdFieldNumber = 1;

		private EntityId gameAccountId_;

		public static MessageParser<SelectGameAccountRequest> Parser
		{
			get
			{
				return SelectGameAccountRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[15];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectGameAccountRequest.Descriptor;
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

		public SelectGameAccountRequest()
		{
		}

		public SelectGameAccountRequest(SelectGameAccountRequest other) : this()
		{
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
		}

		public SelectGameAccountRequest Clone()
		{
			return new SelectGameAccountRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SelectGameAccountRequest);
		}

		public bool Equals(SelectGameAccountRequest other)
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
				switch ((arg_48_0 ^ 1973231055) % 7)
				{
				case 0:
					arg_48_0 = (SelectGameAccountRequest.smethod_0(this.GameAccountId, other.GameAccountId) ? 1782922729 : 1937597232);
					continue;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					goto IL_7A;
				case 4:
					goto IL_12;
				case 5:
					return true;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 1163497633;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 1556145813 : 1849648676);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ SelectGameAccountRequest.smethod_1(this.GameAccountId);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteMessage(this.GameAccountId);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId));
		}

		public void MergeFrom(SelectGameAccountRequest other)
		{
			if (other == null)
			{
				goto IL_70;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 4080886162u)) % 7u)
				{
				case 0u:
					goto IL_70;
				case 1u:
					return;
				case 2u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_7A_0 = 3547320528u;
					continue;
				case 3u:
					this.gameAccountId_ = new EntityId();
					arg_7A_0 = (num * 2641439357u ^ 3813158137u);
					continue;
				case 5u:
					arg_7A_0 = (((this.gameAccountId_ == null) ? 3735095641u : 2416720946u) ^ num * 2345360609u);
					continue;
				case 6u:
					goto IL_B1;
				}
				break;
			}
			return;
			IL_70:
			arg_7A_0 = 2274930308u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.gameAccountId_ == null) ? 3547320528u : 2357907641u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_DC:
				uint num;
				uint arg_A1_0 = ((num = input.ReadTag()) != 0u) ? 3126533616u : 2431159198u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A1_0 ^ 4138909025u)) % 8u)
					{
					case 0u:
						goto IL_DC;
					case 1u:
						arg_A1_0 = ((num != 10u) ? 3704836300u : 2861837839u);
						continue;
					case 2u:
						arg_A1_0 = 3126533616u;
						continue;
					case 3u:
						this.gameAccountId_ = new EntityId();
						arg_A1_0 = (num2 * 1209953835u ^ 4076204100u);
						continue;
					case 4u:
						input.ReadMessage(this.gameAccountId_);
						arg_A1_0 = 3467924385u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_A1_0 = (num2 * 1781727078u ^ 2990167631u);
						continue;
					case 6u:
						arg_A1_0 = ((this.gameAccountId_ == null) ? 3220013114u : 4210268173u);
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
