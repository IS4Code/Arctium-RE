using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol
{
	[DebuggerNonUserCode]
	public sealed class EntityId : IMessage<EntityId>, IEquatable<EntityId>, IDeepCloneable<EntityId>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly EntityId.__c __9 = new EntityId.__c();

			internal EntityId cctor>b__29_0()
			{
				return new EntityId();
			}
		}

		private static readonly MessageParser<EntityId> _parser = new MessageParser<EntityId>(new Func<EntityId>(EntityId.__c.__9.<.cctor>b__29_0));

		public const int HighFieldNumber = 1;

		private ulong high_;

		public const int LowFieldNumber = 2;

		private ulong low_;

		public static MessageParser<EntityId> Parser
		{
			get
			{
				return EntityId._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityId.Descriptor;
			}
		}

		public ulong High
		{
			get
			{
				return this.high_;
			}
			set
			{
				this.high_ = value;
			}
		}

		public ulong Low
		{
			get
			{
				return this.low_;
			}
			set
			{
				this.low_ = value;
			}
		}

		public EntityId()
		{
		}

		public EntityId(EntityId other) : this()
		{
			this.high_ = other.high_;
			this.low_ = other.low_;
		}

		public EntityId Clone()
		{
			return new EntityId(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as EntityId);
		}

		public bool Equals(EntityId other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_AB;
			int arg_6D_0;
			while (true)
			{
				IL_68:
				switch ((arg_6D_0 ^ 239387858) % 9)
				{
				case 0:
					goto IL_AB;
				case 1:
					return false;
				case 2:
					arg_6D_0 = ((this.Low != other.Low) ? 1586809258 : 334036230);
					continue;
				case 3:
					return true;
				case 4:
					arg_6D_0 = ((this.High != other.High) ? 1349451010 : 1956876109);
					continue;
				case 5:
					return false;
				case 6:
					goto IL_15;
				case 7:
					return false;
				}
				break;
			}
			return true;
			IL_15:
			arg_6D_0 = 2007473208;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other == this) ? 1856708497 : 50257523);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B8:
				uint arg_94_0 = 4011092708u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_94_0 ^ 3318548026u)) % 6u)
					{
					case 0u:
						goto IL_B8;
					case 1u:
						num ^= this.Low.GetHashCode();
						arg_94_0 = (num2 * 636770190u ^ 3867556209u);
						continue;
					case 2u:
						num ^= this.High.GetHashCode();
						arg_94_0 = (num2 * 3401924882u ^ 1837497009u);
						continue;
					case 3u:
						arg_94_0 = ((this.Low == 0uL) ? 3987815871u : 2992812635u);
						continue;
					case 4u:
						arg_94_0 = (((this.High == 0uL) ? 191901727u : 1288224076u) ^ num2 * 2057110545u);
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
			if (this.High != 0uL)
			{
				goto IL_7E;
			}
			goto IL_BF;
			uint arg_88_0;
			while (true)
			{
				IL_83:
				uint num;
				switch ((num = (arg_88_0 ^ 3383780884u)) % 7u)
				{
				case 0u:
					goto IL_7E;
				case 2u:
					output.WriteFixed64(this.Low);
					arg_88_0 = (num * 3479259615u ^ 2220931131u);
					continue;
				case 3u:
					goto IL_BF;
				case 4u:
					output.WriteRawTag(9);
					arg_88_0 = (num * 1458404235u ^ 2058829048u);
					continue;
				case 5u:
					output.WriteRawTag(17);
					arg_88_0 = (num * 2773289365u ^ 490782989u);
					continue;
				case 6u:
					output.WriteFixed64(this.High);
					arg_88_0 = (num * 735607873u ^ 3723559260u);
					continue;
				}
				break;
			}
			return;
			IL_7E:
			arg_88_0 = 3480764451u;
			goto IL_83;
			IL_BF:
			arg_88_0 = ((this.Low != 0uL) ? 2660531343u : 3919595049u);
			goto IL_83;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.High != 0uL)
			{
				goto IL_41;
			}
			goto IL_77;
			uint arg_4B_0;
			while (true)
			{
				IL_46:
				uint num2;
				switch ((num2 = (arg_4B_0 ^ 549960690u)) % 5u)
				{
				case 0u:
					goto IL_41;
				case 1u:
					num += 9;
					arg_4B_0 = (num2 * 4144724228u ^ 417625094u);
					continue;
				case 2u:
					goto IL_77;
				case 3u:
					num += 9;
					arg_4B_0 = (num2 * 2494548650u ^ 1876636027u);
					continue;
				}
				break;
			}
			return num;
			IL_41:
			arg_4B_0 = 2096385273u;
			goto IL_46;
			IL_77:
			arg_4B_0 = ((this.Low != 0uL) ? 680969211u : 2133655169u);
			goto IL_46;
		}

		public void MergeFrom(EntityId other)
		{
			if (other == null)
			{
				goto IL_6C;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 175745408u)) % 7u)
				{
				case 0u:
					goto IL_6C;
				case 1u:
					return;
				case 2u:
					this.High = other.High;
					arg_76_0 = (num * 3296995850u ^ 803065134u);
					continue;
				case 3u:
					this.Low = other.Low;
					arg_76_0 = (num * 1465478082u ^ 404435026u);
					continue;
				case 4u:
					arg_76_0 = ((other.Low != 0uL) ? 1639294413u : 1938927880u);
					continue;
				case 6u:
					goto IL_AD;
				}
				break;
			}
			return;
			IL_6C:
			arg_76_0 = 1523588078u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.High != 0uL) ? 1261806134u : 1197579314u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_EE:
				uint num;
				uint arg_AE_0 = ((num = input.ReadTag()) == 0u) ? 2596405310u : 3746403002u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_AE_0 ^ 3687839862u)) % 9u)
					{
					case 0u:
						arg_AE_0 = 3746403002u;
						continue;
					case 1u:
						this.High = input.ReadFixed64();
						arg_AE_0 = 2260494908u;
						continue;
					case 2u:
						arg_AE_0 = (num2 * 3694170469u ^ 727805065u);
						continue;
					case 3u:
						arg_AE_0 = ((num != 9u) ? 3858688494u : 2836792519u);
						continue;
					case 4u:
						arg_AE_0 = (((num == 17u) ? 3638900163u : 4035197468u) ^ num2 * 12135852u);
						continue;
					case 6u:
						this.Low = input.ReadFixed64();
						arg_AE_0 = 2260494908u;
						continue;
					case 7u:
						input.SkipLastField();
						arg_AE_0 = (num2 * 2390404845u ^ 3296572389u);
						continue;
					case 8u:
						goto IL_EE;
					}
					return;
				}
			}
		}
	}
}
