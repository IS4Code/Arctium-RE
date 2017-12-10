using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class GameSessionUpdateInfo : IMessage<GameSessionUpdateInfo>, IEquatable<GameSessionUpdateInfo>, IDeepCloneable<GameSessionUpdateInfo>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GameSessionUpdateInfo.__c __9 = new GameSessionUpdateInfo.__c();

			internal GameSessionUpdateInfo cctor>b__24_0()
			{
				return new GameSessionUpdateInfo();
			}
		}

		private static readonly MessageParser<GameSessionUpdateInfo> _parser = new MessageParser<GameSessionUpdateInfo>(new Func<GameSessionUpdateInfo>(GameSessionUpdateInfo.__c.__9.<.cctor>b__24_0));

		public const int CaisFieldNumber = 8;

		private CAIS cais_;

		public static MessageParser<GameSessionUpdateInfo> Parser
		{
			get
			{
				return GameSessionUpdateInfo._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[27];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSessionUpdateInfo.Descriptor;
			}
		}

		public CAIS Cais
		{
			get
			{
				return this.cais_;
			}
			set
			{
				this.cais_ = value;
			}
		}

		public GameSessionUpdateInfo()
		{
		}

		public GameSessionUpdateInfo(GameSessionUpdateInfo other) : this()
		{
			while (true)
			{
				IL_44:
				int arg_2E_0 = -1630806590;
				while (true)
				{
					switch ((arg_2E_0 ^ -1219859766) % 3)
					{
					case 1:
						this.Cais = ((other.cais_ != null) ? other.Cais.Clone() : null);
						arg_2E_0 = -158380136;
						continue;
					case 2:
						goto IL_44;
					}
					return;
				}
			}
		}

		public GameSessionUpdateInfo Clone()
		{
			return new GameSessionUpdateInfo(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GameSessionUpdateInfo);
		}

		public bool Equals(GameSessionUpdateInfo other)
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
				switch ((arg_48_0 ^ 2019512763) % 7)
				{
				case 0:
					return true;
				case 2:
					arg_48_0 = ((!GameSessionUpdateInfo.smethod_0(this.Cais, other.Cais)) ? 2075581725 : 1165444136);
					continue;
				case 3:
					goto IL_12;
				case 4:
					goto IL_7A;
				case 5:
					return false;
				case 6:
					return false;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 911101106;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 372717275 : 304076382);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 4176058140u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 3405929275u)) % 4u)
					{
					case 0u:
						num ^= GameSessionUpdateInfo.smethod_1(this.Cais);
						arg_4D_0 = (num2 * 3310688824u ^ 2899639426u);
						continue;
					case 2u:
						goto IL_69;
					case 3u:
						arg_4D_0 = (((this.cais_ == null) ? 341321557u : 1540403528u) ^ num2 * 2345859185u);
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
			if (this.cais_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 1471643796u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 767586307u)) % 4u)
						{
						case 0u:
							output.WriteMessage(this.Cais);
							arg_3F_0 = (num * 3812830688u ^ 389632090u);
							continue;
						case 2u:
							goto IL_5B;
						case 3u:
							output.WriteRawTag(66);
							arg_3F_0 = (num * 4094122921u ^ 2940605852u);
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
				uint arg_4F_0 = 4177243250u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4F_0 ^ 4003092795u)) % 4u)
					{
					case 1u:
						arg_4F_0 = (((this.cais_ == null) ? 520059175u : 153851721u) ^ num2 * 247686424u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Cais);
						arg_4F_0 = (num2 * 2679892068u ^ 3690656919u);
						continue;
					case 3u:
						goto IL_6B;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GameSessionUpdateInfo other)
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
				switch ((num = (arg_7A_0 ^ 48893701u)) % 7u)
				{
				case 0u:
					goto IL_70;
				case 2u:
					arg_7A_0 = (((this.cais_ != null) ? 1214211580u : 1338897355u) ^ num * 3291827525u);
					continue;
				case 3u:
					this.cais_ = new CAIS();
					arg_7A_0 = (num * 1459301925u ^ 3878896846u);
					continue;
				case 4u:
					return;
				case 5u:
					this.Cais.MergeFrom(other.Cais);
					arg_7A_0 = 1570403875u;
					continue;
				case 6u:
					goto IL_B1;
				}
				break;
			}
			return;
			IL_70:
			arg_7A_0 = 1998875878u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.cais_ != null) ? 1305816404u : 1570403875u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_DC:
				uint num;
				uint arg_A1_0 = ((num = input.ReadTag()) != 0u) ? 1676731135u : 677801988u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A1_0 ^ 1415980294u)) % 8u)
					{
					case 0u:
						arg_A1_0 = 1676731135u;
						continue;
					case 1u:
						arg_A1_0 = ((num == 66u) ? 1843831505u : 25418451u);
						continue;
					case 3u:
						this.cais_ = new CAIS();
						arg_A1_0 = (num2 * 3279870948u ^ 1239428046u);
						continue;
					case 4u:
						input.ReadMessage(this.cais_);
						arg_A1_0 = 588664160u;
						continue;
					case 5u:
						input.SkipLastField();
						arg_A1_0 = (num2 * 3902404665u ^ 4249813773u);
						continue;
					case 6u:
						goto IL_DC;
					case 7u:
						arg_A1_0 = ((this.cais_ == null) ? 1677105925u : 1410326626u);
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
