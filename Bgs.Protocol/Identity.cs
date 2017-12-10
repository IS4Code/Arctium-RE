using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class Identity : IMessage<Identity>, IEquatable<Identity>, IDeepCloneable<Identity>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Identity.__c __9 = new Identity.__c();

			internal Identity cctor>b__29_0()
			{
				return new Identity();
			}
		}

		private static readonly MessageParser<Identity> _parser = new MessageParser<Identity>(new Func<Identity>(Identity.__c.__9.<.cctor>b__29_0));

		public const int AccountIdFieldNumber = 1;

		private EntityId accountId_;

		public const int GameAccountIdFieldNumber = 2;

		private EntityId gameAccountId_;

		public static MessageParser<Identity> Parser
		{
			get
			{
				return Identity._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Identity.Descriptor;
			}
		}

		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
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

		public Identity()
		{
		}

		public Identity(Identity other) : this()
		{
			this.AccountId = ((other.accountId_ != null) ? other.AccountId.Clone() : null);
			this.GameAccountId = ((other.gameAccountId_ != null) ? other.GameAccountId.Clone() : null);
		}

		public Identity Clone()
		{
			return new Identity(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Identity);
		}

		public bool Equals(Identity other)
		{
			if (other == null)
			{
				goto IL_6D;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 269520785) % 9)
				{
				case 0:
					goto IL_6D;
				case 2:
					arg_77_0 = (Identity.smethod_0(this.AccountId, other.AccountId) ? 389037525 : 60594397);
					continue;
				case 3:
					arg_77_0 = (Identity.smethod_0(this.GameAccountId, other.GameAccountId) ? 10560356 : 207537660);
					continue;
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					goto IL_B5;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = 696708447;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? 1154428515 : 1890138783);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.accountId_ != null)
			{
				goto IL_19;
			}
			goto IL_89;
			uint arg_5D_0;
			while (true)
			{
				IL_58:
				uint num2;
				switch ((num2 = (arg_5D_0 ^ 3218238170u)) % 5u)
				{
				case 1u:
					goto IL_89;
				case 2u:
					num ^= Identity.smethod_1(this.GameAccountId);
					arg_5D_0 = (num2 * 1379649596u ^ 701942609u);
					continue;
				case 3u:
					num ^= Identity.smethod_1(this.AccountId);
					arg_5D_0 = (num2 * 202057850u ^ 2074045418u);
					continue;
				case 4u:
					goto IL_19;
				}
				break;
			}
			return num;
			IL_19:
			arg_5D_0 = 3235348546u;
			goto IL_58;
			IL_89:
			arg_5D_0 = ((this.gameAccountId_ == null) ? 3806221625u : 2753329692u);
			goto IL_58;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.accountId_ != null)
			{
				goto IL_1A;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 1591955892u)) % 6u)
				{
				case 1u:
					goto IL_AC;
				case 2u:
					output.WriteRawTag(10);
					arg_79_0 = (num * 1847538841u ^ 1932940881u);
					continue;
				case 3u:
					output.WriteMessage(this.AccountId);
					arg_79_0 = (num * 3719853203u ^ 2389162404u);
					continue;
				case 4u:
					output.WriteRawTag(18);
					output.WriteMessage(this.GameAccountId);
					arg_79_0 = (num * 100035962u ^ 3200487422u);
					continue;
				case 5u:
					goto IL_1A;
				}
				break;
			}
			return;
			IL_1A:
			arg_79_0 = 1036533156u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.gameAccountId_ == null) ? 1292746558u : 1845493332u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_B6:
				uint arg_92_0 = 3879531046u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_92_0 ^ 3430296331u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
						arg_92_0 = (num2 * 151639631u ^ 2602516489u);
						continue;
					case 1u:
						arg_92_0 = (((this.accountId_ != null) ? 293858020u : 245428262u) ^ num2 * 2976675243u);
						continue;
					case 2u:
						arg_92_0 = ((this.gameAccountId_ != null) ? 2378278337u : 2604615320u);
						continue;
					case 3u:
						goto IL_B6;
					case 4u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
						arg_92_0 = (num2 * 2248501601u ^ 758166034u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Identity other)
		{
			if (other == null)
			{
				goto IL_B1;
			}
			goto IL_14D;
			uint arg_105_0;
			while (true)
			{
				IL_100:
				uint num;
				switch ((num = (arg_105_0 ^ 2380003157u)) % 11u)
				{
				case 0u:
					goto IL_14D;
				case 1u:
					arg_105_0 = (((this.gameAccountId_ != null) ? 4033714828u : 2894125394u) ^ num * 202000690u);
					continue;
				case 2u:
					arg_105_0 = ((other.gameAccountId_ != null) ? 3062634498u : 3640859176u);
					continue;
				case 3u:
					goto IL_B1;
				case 4u:
					return;
				case 5u:
					arg_105_0 = (((this.accountId_ == null) ? 2145333947u : 1357529679u) ^ num * 3778806502u);
					continue;
				case 6u:
					this.AccountId.MergeFrom(other.AccountId);
					arg_105_0 = 3351687909u;
					continue;
				case 7u:
					this.GameAccountId.MergeFrom(other.GameAccountId);
					arg_105_0 = 3640859176u;
					continue;
				case 8u:
					this.gameAccountId_ = new EntityId();
					arg_105_0 = (num * 378919060u ^ 2556884102u);
					continue;
				case 9u:
					this.accountId_ = new EntityId();
					arg_105_0 = (num * 2363246884u ^ 60416877u);
					continue;
				}
				break;
			}
			return;
			IL_B1:
			arg_105_0 = 2699530943u;
			goto IL_100;
			IL_14D:
			arg_105_0 = ((other.accountId_ == null) ? 3351687909u : 2899784742u);
			goto IL_100;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_183:
				uint num;
				uint arg_133_0 = ((num = input.ReadTag()) == 0u) ? 3155774031u : 2610837290u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_133_0 ^ 3476315206u)) % 13u)
					{
					case 0u:
						input.SkipLastField();
						arg_133_0 = (num2 * 4254272820u ^ 3219857411u);
						continue;
					case 1u:
						arg_133_0 = ((num != 10u) ? 2300061426u : 3343742959u);
						continue;
					case 3u:
						goto IL_183;
					case 4u:
						arg_133_0 = ((this.accountId_ == null) ? 3672397951u : 3725837506u);
						continue;
					case 5u:
						this.gameAccountId_ = new EntityId();
						arg_133_0 = (num2 * 4160297823u ^ 1636658631u);
						continue;
					case 6u:
						arg_133_0 = 2610837290u;
						continue;
					case 7u:
						input.ReadMessage(this.gameAccountId_);
						arg_133_0 = 3010809783u;
						continue;
					case 8u:
						arg_133_0 = (num2 * 3451624158u ^ 2831387511u);
						continue;
					case 9u:
						input.ReadMessage(this.accountId_);
						arg_133_0 = 4283699174u;
						continue;
					case 10u:
						this.accountId_ = new EntityId();
						arg_133_0 = (num2 * 1781709933u ^ 2816371847u);
						continue;
					case 11u:
						arg_133_0 = (((num != 18u) ? 1224171915u : 1056366657u) ^ num2 * 1403562759u);
						continue;
					case 12u:
						arg_133_0 = ((this.gameAccountId_ == null) ? 3058522864u : 2569650765u);
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
