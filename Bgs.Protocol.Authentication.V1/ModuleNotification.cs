using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Authentication.V1
{
	[DebuggerNonUserCode]
	public sealed class ModuleNotification : IMessage<ModuleNotification>, IEquatable<ModuleNotification>, IDeepCloneable<ModuleNotification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ModuleNotification.__c __9 = new ModuleNotification.__c();

			internal ModuleNotification cctor>b__29_0()
			{
				return new ModuleNotification();
			}
		}

		private static readonly MessageParser<ModuleNotification> _parser = new MessageParser<ModuleNotification>(new Func<ModuleNotification>(ModuleNotification.__c.__9.<.cctor>b__29_0));

		public const int ModuleIdFieldNumber = 2;

		private int moduleId_;

		public const int ResultFieldNumber = 3;

		private uint result_;

		public static MessageParser<ModuleNotification> Parser
		{
			get
			{
				return ModuleNotification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModuleNotification.Descriptor;
			}
		}

		public int ModuleId
		{
			get
			{
				return this.moduleId_;
			}
			set
			{
				this.moduleId_ = value;
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

		public ModuleNotification()
		{
		}

		public ModuleNotification(ModuleNotification other) : this()
		{
			while (true)
			{
				IL_5D:
				uint arg_41_0 = 4189166581u;
				while (true)
				{
					uint num;
					switch ((num = (arg_41_0 ^ 4145326552u)) % 4u)
					{
					case 0u:
						this.result_ = other.result_;
						arg_41_0 = (num * 2561572836u ^ 2670963330u);
						continue;
					case 1u:
						this.moduleId_ = other.moduleId_;
						arg_41_0 = (num * 907510420u ^ 3467429620u);
						continue;
					case 3u:
						goto IL_5D;
					}
					return;
				}
			}
		}

		public ModuleNotification Clone()
		{
			return new ModuleNotification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ModuleNotification);
		}

		public bool Equals(ModuleNotification other)
		{
			if (other == null)
			{
				goto IL_3C;
			}
			goto IL_AB;
			int arg_6D_0;
			while (true)
			{
				IL_68:
				switch ((arg_6D_0 ^ -1352497754) % 9)
				{
				case 0:
					goto IL_AB;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_6D_0 = ((this.ModuleId != other.ModuleId) ? -1050991588 : -1676104451);
					continue;
				case 5:
					goto IL_3C;
				case 7:
					return false;
				case 8:
					arg_6D_0 = ((this.Result != other.Result) ? -175071668 : -404152886);
					continue;
				}
				break;
			}
			return true;
			IL_3C:
			arg_6D_0 = -1046382439;
			goto IL_68;
			IL_AB:
			arg_6D_0 = ((other != this) ? -414371001 : -324352216);
			goto IL_68;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_B8:
				uint arg_94_0 = 552921155u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_94_0 ^ 1144266199u)) % 6u)
					{
					case 0u:
						goto IL_B8;
					case 1u:
						num ^= this.ModuleId.GetHashCode();
						arg_94_0 = (num2 * 4099576059u ^ 3213662886u);
						continue;
					case 2u:
						arg_94_0 = ((this.Result == 0u) ? 788468746u : 1881397478u);
						continue;
					case 3u:
						num ^= this.Result.GetHashCode();
						arg_94_0 = (num2 * 4013278701u ^ 941250391u);
						continue;
					case 4u:
						arg_94_0 = (((this.ModuleId == 0) ? 2333314307u : 4065046640u) ^ num2 * 2377758375u);
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
			if (this.ModuleId != 0)
			{
				goto IL_6F;
			}
			goto IL_AC;
			uint arg_79_0;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 332935414u)) % 6u)
				{
				case 0u:
					goto IL_6F;
				case 2u:
					output.WriteRawTag(16);
					output.WriteInt32(this.ModuleId);
					arg_79_0 = (num * 3352984933u ^ 2403226001u);
					continue;
				case 3u:
					goto IL_AC;
				case 4u:
					output.WriteUInt32(this.Result);
					arg_79_0 = (num * 1855000106u ^ 946453783u);
					continue;
				case 5u:
					output.WriteRawTag(24);
					arg_79_0 = (num * 3352413052u ^ 1520278546u);
					continue;
				}
				break;
			}
			return;
			IL_6F:
			arg_79_0 = 2092038898u;
			goto IL_74;
			IL_AC:
			arg_79_0 = ((this.Result == 0u) ? 2040753159u : 1367819467u);
			goto IL_74;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.ModuleId != 0)
			{
				goto IL_1C;
			}
			goto IL_90;
			uint arg_64_0;
			while (true)
			{
				IL_5F:
				uint num2;
				switch ((num2 = (arg_64_0 ^ 1194425933u)) % 5u)
				{
				case 0u:
					goto IL_90;
				case 1u:
					num += 1 + CodedOutputStream.ComputeInt32Size(this.ModuleId);
					arg_64_0 = (num2 * 3621976890u ^ 1307139577u);
					continue;
				case 2u:
					num += 1 + CodedOutputStream.ComputeUInt32Size(this.Result);
					arg_64_0 = (num2 * 1351609714u ^ 2919296893u);
					continue;
				case 4u:
					goto IL_1C;
				}
				break;
			}
			return num;
			IL_1C:
			arg_64_0 = 9059036u;
			goto IL_5F;
			IL_90:
			arg_64_0 = ((this.Result == 0u) ? 581503037u : 1038204653u);
			goto IL_5F;
		}

		public void MergeFrom(ModuleNotification other)
		{
			if (other == null)
			{
				goto IL_30;
			}
			goto IL_AD;
			uint arg_76_0;
			while (true)
			{
				IL_71:
				uint num;
				switch ((num = (arg_76_0 ^ 3581138662u)) % 7u)
				{
				case 0u:
					this.ModuleId = other.ModuleId;
					arg_76_0 = (num * 2201659995u ^ 2115779222u);
					continue;
				case 1u:
					arg_76_0 = ((other.Result != 0u) ? 3277813657u : 3715206142u);
					continue;
				case 3u:
					goto IL_30;
				case 4u:
					return;
				case 5u:
					goto IL_AD;
				case 6u:
					this.Result = other.Result;
					arg_76_0 = (num * 4051600391u ^ 1955491207u);
					continue;
				}
				break;
			}
			return;
			IL_30:
			arg_76_0 = 2157519755u;
			goto IL_71;
			IL_AD:
			arg_76_0 = ((other.ModuleId != 0) ? 3290689588u : 3703929392u);
			goto IL_71;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_DA:
				uint num;
				uint arg_9F_0 = ((num = input.ReadTag()) != 0u) ? 1655556361u : 449925223u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_9F_0 ^ 615774840u)) % 8u)
					{
					case 0u:
						this.Result = input.ReadUInt32();
						arg_9F_0 = 1377870778u;
						continue;
					case 1u:
						arg_9F_0 = ((num != 16u) ? 704687436u : 1820684453u);
						continue;
					case 2u:
						goto IL_DA;
					case 3u:
						arg_9F_0 = 1655556361u;
						continue;
					case 4u:
						arg_9F_0 = (((num == 24u) ? 3051783420u : 2253334970u) ^ num2 * 2347012145u);
						continue;
					case 5u:
						this.ModuleId = input.ReadInt32();
						arg_9F_0 = 1377870778u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_9F_0 = (num2 * 4083517686u ^ 2181834334u);
						continue;
					}
					return;
				}
			}
		}
	}
}
