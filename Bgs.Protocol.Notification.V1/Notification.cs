using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Notification.V1
{
	[DebuggerNonUserCode]
	public sealed class Notification : IMessage<Notification>, IEquatable<Notification>, IDeepCloneable<Notification>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Notification.__c __9 = new Notification.__c();

			internal Notification cctor>b__69_0()
			{
				return new Notification();
			}
		}

		private static readonly MessageParser<Notification> _parser = new MessageParser<Notification>(new Func<Notification>(Notification.__c.__9.<.cctor>b__69_0));

		public const int SenderIdFieldNumber = 1;

		private EntityId senderId_;

		public const int TargetIdFieldNumber = 2;

		private EntityId targetId_;

		public const int TypeFieldNumber = 3;

		private string type_ = "";

		public const int AttributeFieldNumber = 4;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec;

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public const int SenderAccountIdFieldNumber = 5;

		private EntityId senderAccountId_;

		public const int TargetAccountIdFieldNumber = 6;

		private EntityId targetAccountId_;

		public const int SenderBattleTagFieldNumber = 7;

		private string senderBattleTag_ = "";

		public const int TargetBattleTagFieldNumber = 8;

		private string targetBattleTag_ = "";

		public const int PeerFieldNumber = 9;

		private ProcessId peer_;

		public const int ForwardingIdentityFieldNumber = 10;

		private Bgs.Protocol.Account.V1.Identity forwardingIdentity_;

		public static MessageParser<Notification> Parser
		{
			get
			{
				return Notification._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Notification.Descriptor;
			}
		}

		public EntityId SenderId
		{
			get
			{
				return this.senderId_;
			}
			set
			{
				this.senderId_ = value;
			}
		}

		public EntityId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		public string Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = Preconditions.CheckNotNull<string>(value, Module.smethod_35<string>(4287036u));
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public EntityId SenderAccountId
		{
			get
			{
				return this.senderAccountId_;
			}
			set
			{
				this.senderAccountId_ = value;
			}
		}

		public EntityId TargetAccountId
		{
			get
			{
				return this.targetAccountId_;
			}
			set
			{
				this.targetAccountId_ = value;
			}
		}

		public string SenderBattleTag
		{
			get
			{
				return this.senderBattleTag_;
			}
			set
			{
				this.senderBattleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public string TargetBattleTag
		{
			get
			{
				return this.targetBattleTag_;
			}
			set
			{
				this.targetBattleTag_ = Preconditions.CheckNotNull<string>(value, Module.smethod_33<string>(58016685u));
			}
		}

		public ProcessId Peer
		{
			get
			{
				return this.peer_;
			}
			set
			{
				this.peer_ = value;
			}
		}

		public Bgs.Protocol.Account.V1.Identity ForwardingIdentity
		{
			get
			{
				return this.forwardingIdentity_;
			}
			set
			{
				this.forwardingIdentity_ = value;
			}
		}

		public Notification()
		{
		}

		public Notification(Notification other) : this()
		{
			this.SenderId = ((other.senderId_ != null) ? other.SenderId.Clone() : null);
			this.TargetId = ((other.targetId_ != null) ? other.TargetId.Clone() : null);
			this.type_ = other.type_;
			this.attribute_ = other.attribute_.Clone();
			this.SenderAccountId = ((other.senderAccountId_ != null) ? other.SenderAccountId.Clone() : null);
			this.TargetAccountId = ((other.targetAccountId_ != null) ? other.TargetAccountId.Clone() : null);
			this.senderBattleTag_ = other.senderBattleTag_;
			this.targetBattleTag_ = other.targetBattleTag_;
			this.Peer = ((other.peer_ != null) ? other.Peer.Clone() : null);
			this.ForwardingIdentity = ((other.forwardingIdentity_ != null) ? other.ForwardingIdentity.Clone() : null);
		}

		public Notification Clone()
		{
			return new Notification(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Notification);
		}

		public bool Equals(Notification other)
		{
			if (other == null)
			{
				goto IL_76;
			}
			goto IL_270;
			int arg_1F2_0;
			while (true)
			{
				IL_1ED:
				switch ((arg_1F2_0 ^ 1784756256) % 25)
				{
				case 0:
					return false;
				case 1:
					arg_1F2_0 = ((!Notification.smethod_0(this.Peer, other.Peer)) ? 1162436705 : 2105881454);
					continue;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					goto IL_270;
				case 5:
					arg_1F2_0 = (Notification.smethod_0(this.SenderAccountId, other.SenderAccountId) ? 6838232 : 444942307);
					continue;
				case 6:
					arg_1F2_0 = ((!Notification.smethod_1(this.TargetBattleTag, other.TargetBattleTag)) ? 144384746 : 1623271628);
					continue;
				case 7:
					return false;
				case 8:
					arg_1F2_0 = ((!Notification.smethod_1(this.SenderBattleTag, other.SenderBattleTag)) ? 2029363921 : 1183655394);
					continue;
				case 9:
					arg_1F2_0 = (Notification.smethod_0(this.TargetAccountId, other.TargetAccountId) ? 2120415628 : 897505657);
					continue;
				case 10:
					return false;
				case 11:
					arg_1F2_0 = (Notification.smethod_0(this.TargetId, other.TargetId) ? 1291748462 : 592906611);
					continue;
				case 13:
					arg_1F2_0 = ((!Notification.smethod_1(this.Type, other.Type)) ? 1536733528 : 2062747450);
					continue;
				case 14:
					return false;
				case 15:
					arg_1F2_0 = (this.attribute_.Equals(other.attribute_) ? 405781042 : 2094246945);
					continue;
				case 16:
					return false;
				case 17:
					goto IL_76;
				case 18:
					return false;
				case 19:
					return false;
				case 20:
					arg_1F2_0 = (Notification.smethod_0(this.ForwardingIdentity, other.ForwardingIdentity) ? 1990746830 : 696356777);
					continue;
				case 21:
					return false;
				case 22:
					arg_1F2_0 = ((!Notification.smethod_0(this.SenderId, other.SenderId)) ? 1582382451 : 36324087);
					continue;
				case 23:
					return false;
				case 24:
					return false;
				}
				break;
			}
			return true;
			IL_76:
			arg_1F2_0 = 80579414;
			goto IL_1ED;
			IL_270:
			arg_1F2_0 = ((other != this) ? 1453765658 : 1510958310);
			goto IL_1ED;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_279:
				uint arg_228_0 = 2474478883u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_228_0 ^ 4237186125u)) % 17u)
					{
					case 0u:
						num ^= Notification.smethod_2(this.ForwardingIdentity);
						arg_228_0 = (num2 * 4238605090u ^ 3642883923u);
						continue;
					case 1u:
						arg_228_0 = (((this.senderId_ == null) ? 1947330851u : 1112335667u) ^ num2 * 481048234u);
						continue;
					case 2u:
						arg_228_0 = ((Notification.smethod_3(this.TargetBattleTag) == 0) ? 3510811131u : 3879987496u);
						continue;
					case 3u:
						arg_228_0 = ((this.targetAccountId_ == null) ? 3878072499u : 3929804948u);
						continue;
					case 4u:
						num ^= Notification.smethod_2(this.TargetId);
						num ^= Notification.smethod_2(this.Type);
						arg_228_0 = 3018897587u;
						continue;
					case 5u:
						arg_228_0 = ((this.peer_ != null) ? 2505210408u : 2976713922u);
						continue;
					case 6u:
						num ^= Notification.smethod_2(this.SenderBattleTag);
						arg_228_0 = (num2 * 880919594u ^ 113969889u);
						continue;
					case 7u:
						num ^= Notification.smethod_2(this.SenderAccountId);
						arg_228_0 = (num2 * 1012456652u ^ 4183753348u);
						continue;
					case 8u:
						arg_228_0 = ((this.forwardingIdentity_ == null) ? 2441491007u : 2538564635u);
						continue;
					case 9u:
						num ^= Notification.smethod_2(this.TargetAccountId);
						arg_228_0 = (num2 * 1258929026u ^ 1515506049u);
						continue;
					case 11u:
						goto IL_279;
					case 12u:
						num ^= Notification.smethod_2(this.TargetBattleTag);
						arg_228_0 = (num2 * 1757585910u ^ 2065186293u);
						continue;
					case 13u:
						num ^= Notification.smethod_2(this.Peer);
						arg_228_0 = (num2 * 375988144u ^ 2533764274u);
						continue;
					case 14u:
						arg_228_0 = ((Notification.smethod_3(this.SenderBattleTag) != 0) ? 4031945313u : 4176775641u);
						continue;
					case 15u:
						num ^= Notification.smethod_2(this.attribute_);
						arg_228_0 = (((this.senderAccountId_ != null) ? 3094568807u : 2825799808u) ^ num2 * 1801289562u);
						continue;
					case 16u:
						num ^= Notification.smethod_2(this.SenderId);
						arg_228_0 = (num2 * 611300509u ^ 3346580933u);
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
			if (this.senderId_ != null)
			{
				goto IL_50;
			}
			goto IL_359;
			uint arg_2E4_0;
			while (true)
			{
				IL_2DF:
				uint num;
				switch ((num = (arg_2E4_0 ^ 1827452364u)) % 26u)
				{
				case 0u:
					arg_2E4_0 = ((Notification.smethod_3(this.TargetBattleTag) == 0) ? 2138178603u : 1488769948u);
					continue;
				case 1u:
					output.WriteString(this.SenderBattleTag);
					arg_2E4_0 = (num * 3584681413u ^ 1364716643u);
					continue;
				case 2u:
					output.WriteMessage(this.SenderAccountId);
					arg_2E4_0 = (num * 2204637468u ^ 3374164301u);
					continue;
				case 3u:
					arg_2E4_0 = ((this.peer_ != null) ? 1434517123u : 248763010u);
					continue;
				case 4u:
					output.WriteMessage(this.Peer);
					arg_2E4_0 = (num * 4125104741u ^ 3120007788u);
					continue;
				case 5u:
					output.WriteString(this.Type);
					arg_2E4_0 = (num * 265699719u ^ 628414721u);
					continue;
				case 6u:
					this.attribute_.WriteTo(output, Notification._repeated_attribute_codec);
					arg_2E4_0 = (num * 1069903818u ^ 109675552u);
					continue;
				case 7u:
					output.WriteRawTag(10);
					arg_2E4_0 = (num * 2384193503u ^ 4129646051u);
					continue;
				case 8u:
					arg_2E4_0 = (((this.senderAccountId_ == null) ? 2645203525u : 3787684641u) ^ num * 2252940091u);
					continue;
				case 9u:
					goto IL_359;
				case 10u:
					output.WriteRawTag(50);
					arg_2E4_0 = (num * 244906138u ^ 1553454170u);
					continue;
				case 11u:
					arg_2E4_0 = ((this.targetAccountId_ != null) ? 89515074u : 10635980u);
					continue;
				case 12u:
					output.WriteMessage(this.SenderId);
					arg_2E4_0 = (num * 88912048u ^ 3754187873u);
					continue;
				case 13u:
					output.WriteRawTag(26);
					arg_2E4_0 = (num * 2636014449u ^ 789292018u);
					continue;
				case 14u:
					output.WriteMessage(this.TargetId);
					arg_2E4_0 = (num * 1282551520u ^ 1053925435u);
					continue;
				case 16u:
					output.WriteRawTag(66);
					output.WriteString(this.TargetBattleTag);
					arg_2E4_0 = (num * 4210575103u ^ 721276315u);
					continue;
				case 17u:
					output.WriteRawTag(74);
					arg_2E4_0 = (num * 4220029203u ^ 2557622087u);
					continue;
				case 18u:
					arg_2E4_0 = ((this.forwardingIdentity_ == null) ? 134795043u : 2145721849u);
					continue;
				case 19u:
					output.WriteRawTag(42);
					arg_2E4_0 = (num * 4193984379u ^ 4026520275u);
					continue;
				case 20u:
					output.WriteMessage(this.ForwardingIdentity);
					arg_2E4_0 = (num * 3018416530u ^ 3346292915u);
					continue;
				case 21u:
					output.WriteRawTag(58);
					arg_2E4_0 = (num * 1043676839u ^ 3476052752u);
					continue;
				case 22u:
					output.WriteMessage(this.TargetAccountId);
					arg_2E4_0 = (num * 3142785136u ^ 3654727596u);
					continue;
				case 23u:
					goto IL_50;
				case 24u:
					arg_2E4_0 = ((Notification.smethod_3(this.SenderBattleTag) == 0) ? 1873246340u : 928847245u);
					continue;
				case 25u:
					output.WriteRawTag(82);
					arg_2E4_0 = (num * 3741304267u ^ 1335892803u);
					continue;
				}
				break;
			}
			return;
			IL_50:
			arg_2E4_0 = 323880495u;
			goto IL_2DF;
			IL_359:
			output.WriteRawTag(18);
			arg_2E4_0 = 2129611676u;
			goto IL_2DF;
		}

		public int CalculateSize()
		{
			int num = 0;
			if (this.senderId_ != null)
			{
				goto IL_13D;
			}
			goto IL_227;
			uint arg_1CF_0;
			while (true)
			{
				IL_1CA:
				uint num2;
				switch ((num2 = (arg_1CF_0 ^ 1208134331u)) % 15u)
				{
				case 0u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetAccountId);
					arg_1CF_0 = (num2 * 2609389752u ^ 687237204u);
					continue;
				case 1u:
					arg_1CF_0 = ((Notification.smethod_3(this.TargetBattleTag) == 0) ? 782318735u : 1106714070u);
					continue;
				case 2u:
					arg_1CF_0 = ((this.peer_ == null) ? 1673632610u : 1053107761u);
					continue;
				case 3u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.SenderAccountId);
					arg_1CF_0 = (num2 * 2136895600u ^ 2550059886u);
					continue;
				case 4u:
					goto IL_227;
				case 5u:
					goto IL_13D;
				case 6u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.TargetBattleTag);
					arg_1CF_0 = (num2 * 3254306180u ^ 969951675u);
					continue;
				case 7u:
					arg_1CF_0 = ((Notification.smethod_3(this.SenderBattleTag) == 0) ? 1156627913u : 1101519369u);
					continue;
				case 8u:
					arg_1CF_0 = ((this.targetAccountId_ == null) ? 235118468u : 1991920045u);
					continue;
				case 9u:
					arg_1CF_0 = ((this.forwardingIdentity_ == null) ? 1013069280u : 2106790336u);
					continue;
				case 10u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.Peer);
					arg_1CF_0 = (num2 * 989441958u ^ 124840990u);
					continue;
				case 11u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.SenderId);
					arg_1CF_0 = (num2 * 594739840u ^ 1902343983u);
					continue;
				case 13u:
					num += 1 + CodedOutputStream.ComputeMessageSize(this.ForwardingIdentity);
					arg_1CF_0 = (num2 * 2698009293u ^ 1777232543u);
					continue;
				case 14u:
					num += 1 + CodedOutputStream.ComputeStringSize(this.SenderBattleTag);
					arg_1CF_0 = (num2 * 1259172490u ^ 4204314173u);
					continue;
				}
				break;
			}
			return num;
			IL_13D:
			arg_1CF_0 = 224557535u;
			goto IL_1CA;
			IL_227:
			num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			num += this.attribute_.CalculateSize(Notification._repeated_attribute_codec);
			arg_1CF_0 = ((this.senderAccountId_ == null) ? 1335656382u : 397761584u);
			goto IL_1CA;
		}

		public void MergeFrom(Notification other)
		{
			if (other == null)
			{
				goto IL_1AC;
			}
			goto IL_4C1;
			uint arg_41D_0;
			while (true)
			{
				IL_418:
				uint num;
				switch ((num = (arg_41D_0 ^ 2040750665u)) % 34u)
				{
				case 0u:
					this.TargetId.MergeFrom(other.TargetId);
					arg_41D_0 = 1227822175u;
					continue;
				case 1u:
					this.targetId_ = new EntityId();
					arg_41D_0 = (num * 3154874368u ^ 422476315u);
					continue;
				case 2u:
					arg_41D_0 = ((other.forwardingIdentity_ == null) ? 514931477u : 364200913u);
					continue;
				case 3u:
					arg_41D_0 = (((this.senderAccountId_ != null) ? 3686995115u : 2486093062u) ^ num * 2951098733u);
					continue;
				case 4u:
					this.senderAccountId_ = new EntityId();
					arg_41D_0 = (num * 2430664006u ^ 1272945922u);
					continue;
				case 5u:
					arg_41D_0 = (((other.senderAccountId_ != null) ? 3584414342u : 2849410179u) ^ num * 2231283506u);
					continue;
				case 6u:
					this.SenderId.MergeFrom(other.SenderId);
					arg_41D_0 = 288455740u;
					continue;
				case 7u:
					this.forwardingIdentity_ = new Bgs.Protocol.Account.V1.Identity();
					arg_41D_0 = (num * 3094316710u ^ 192069144u);
					continue;
				case 8u:
					arg_41D_0 = ((other.targetAccountId_ != null) ? 521300049u : 1536384514u);
					continue;
				case 9u:
					this.Peer.MergeFrom(other.Peer);
					arg_41D_0 = 341260439u;
					continue;
				case 10u:
					this.peer_ = new ProcessId();
					arg_41D_0 = (num * 3980720896u ^ 3543710460u);
					continue;
				case 11u:
					this.SenderAccountId.MergeFrom(other.SenderAccountId);
					arg_41D_0 = 596809829u;
					continue;
				case 12u:
					this.TargetAccountId.MergeFrom(other.TargetAccountId);
					arg_41D_0 = 1536384514u;
					continue;
				case 13u:
					arg_41D_0 = ((Notification.smethod_3(other.SenderBattleTag) == 0) ? 2023554429u : 1924184414u);
					continue;
				case 14u:
					arg_41D_0 = (((this.peer_ != null) ? 455536252u : 324531205u) ^ num * 289977596u);
					continue;
				case 15u:
					this.Type = other.Type;
					arg_41D_0 = (num * 1567605306u ^ 409098147u);
					continue;
				case 16u:
					arg_41D_0 = (((this.senderId_ == null) ? 3235123162u : 2277178267u) ^ num * 3075029448u);
					continue;
				case 17u:
					this.SenderBattleTag = other.SenderBattleTag;
					arg_41D_0 = (num * 1892797630u ^ 2172981871u);
					continue;
				case 18u:
					this.attribute_.Add(other.attribute_);
					arg_41D_0 = 1144073122u;
					continue;
				case 19u:
					goto IL_1AC;
				case 20u:
					arg_41D_0 = ((Notification.smethod_3(other.TargetBattleTag) == 0) ? 992183075u : 1715381646u);
					continue;
				case 21u:
					this.ForwardingIdentity.MergeFrom(other.ForwardingIdentity);
					arg_41D_0 = 514931477u;
					continue;
				case 22u:
					arg_41D_0 = ((Notification.smethod_3(other.Type) == 0) ? 1076083629u : 269691962u);
					continue;
				case 23u:
					arg_41D_0 = ((other.targetId_ == null) ? 1227822175u : 1020281863u);
					continue;
				case 24u:
					arg_41D_0 = (((this.targetAccountId_ != null) ? 4157039151u : 2801001740u) ^ num * 3074786874u);
					continue;
				case 25u:
					this.TargetBattleTag = other.TargetBattleTag;
					arg_41D_0 = (num * 1064472734u ^ 142393329u);
					continue;
				case 26u:
					arg_41D_0 = (((this.forwardingIdentity_ != null) ? 511382010u : 1732986762u) ^ num * 4268072490u);
					continue;
				case 27u:
					this.senderId_ = new EntityId();
					arg_41D_0 = (num * 1117440827u ^ 2856856506u);
					continue;
				case 28u:
					arg_41D_0 = (((this.targetId_ == null) ? 2407424796u : 3517505913u) ^ num * 548673383u);
					continue;
				case 29u:
					goto IL_4C1;
				case 31u:
					this.targetAccountId_ = new EntityId();
					arg_41D_0 = (num * 1973109438u ^ 2207591945u);
					continue;
				case 32u:
					arg_41D_0 = ((other.peer_ == null) ? 341260439u : 677192105u);
					continue;
				case 33u:
					return;
				}
				break;
			}
			return;
			IL_1AC:
			arg_41D_0 = 985250282u;
			goto IL_418;
			IL_4C1:
			arg_41D_0 = ((other.senderId_ != null) ? 1190038379u : 288455740u);
			goto IL_418;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_627:
				uint num;
				uint arg_543_0 = ((num = input.ReadTag()) == 0u) ? 1657673554u : 890823503u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_543_0 ^ 708652070u)) % 50u)
					{
					case 0u:
						input.ReadMessage(this.targetId_);
						arg_543_0 = 1571908714u;
						continue;
					case 1u:
						this.senderId_ = new EntityId();
						arg_543_0 = (num2 * 505513389u ^ 787996545u);
						continue;
					case 2u:
						this.attribute_.AddEntriesFrom(input, Notification._repeated_attribute_codec);
						arg_543_0 = 67415794u;
						continue;
					case 3u:
						this.targetAccountId_ = new EntityId();
						arg_543_0 = (num2 * 4090512337u ^ 3145074826u);
						continue;
					case 4u:
						arg_543_0 = (num2 * 2482549992u ^ 2567388259u);
						continue;
					case 5u:
						arg_543_0 = (((num == 18u) ? 2026873707u : 818030097u) ^ num2 * 118385212u);
						continue;
					case 6u:
						arg_543_0 = (((num <= 18u) ? 4257519347u : 2295573696u) ^ num2 * 1757491449u);
						continue;
					case 7u:
						this.Type = input.ReadString();
						arg_543_0 = 1158981173u;
						continue;
					case 8u:
						this.forwardingIdentity_ = new Bgs.Protocol.Account.V1.Identity();
						arg_543_0 = (num2 * 3198677771u ^ 1523342755u);
						continue;
					case 9u:
						arg_543_0 = ((num != 66u) ? 824177286u : 764183948u);
						continue;
					case 10u:
						arg_543_0 = (num2 * 3506126399u ^ 774822548u);
						continue;
					case 11u:
						arg_543_0 = (num2 * 4093483556u ^ 2628987503u);
						continue;
					case 12u:
						arg_543_0 = 890823503u;
						continue;
					case 13u:
						arg_543_0 = (((num != 82u) ? 1096216590u : 1431766510u) ^ num2 * 3050280184u);
						continue;
					case 14u:
						this.peer_ = new ProcessId();
						arg_543_0 = (num2 * 3823112666u ^ 72120282u);
						continue;
					case 15u:
						arg_543_0 = ((this.senderId_ != null) ? 1711985906u : 2026411449u);
						continue;
					case 16u:
						arg_543_0 = (((num != 34u) ? 4014946445u : 4270213608u) ^ num2 * 2713464043u);
						continue;
					case 17u:
						arg_543_0 = (((num == 58u) ? 2060198571u : 1172278861u) ^ num2 * 905819593u);
						continue;
					case 18u:
						this.TargetBattleTag = input.ReadString();
						arg_543_0 = 1967323920u;
						continue;
					case 19u:
						arg_543_0 = ((num <= 58u) ? 109818935u : 435537827u);
						continue;
					case 21u:
						this.senderAccountId_ = new EntityId();
						arg_543_0 = (num2 * 3425277307u ^ 1705012460u);
						continue;
					case 22u:
						this.SenderBattleTag = input.ReadString();
						arg_543_0 = 363784197u;
						continue;
					case 23u:
						arg_543_0 = (((num != 42u) ? 4231571017u : 2857847369u) ^ num2 * 3807211501u);
						continue;
					case 24u:
						arg_543_0 = ((num != 26u) ? 1696853042u : 644650367u);
						continue;
					case 25u:
						arg_543_0 = ((num <= 42u) ? 1686492340u : 1839309553u);
						continue;
					case 26u:
						input.ReadMessage(this.peer_);
						arg_543_0 = 2028505219u;
						continue;
					case 27u:
						arg_543_0 = ((this.targetAccountId_ != null) ? 898888169u : 614029013u);
						continue;
					case 28u:
						input.SkipLastField();
						arg_543_0 = 1549119987u;
						continue;
					case 29u:
						goto IL_627;
					case 30u:
						arg_543_0 = (num2 * 3583334448u ^ 2177756995u);
						continue;
					case 31u:
						input.ReadMessage(this.senderAccountId_);
						arg_543_0 = 1353913154u;
						continue;
					case 32u:
						arg_543_0 = ((this.forwardingIdentity_ == null) ? 1768405974u : 2053180147u);
						continue;
					case 33u:
						input.ReadMessage(this.forwardingIdentity_);
						arg_543_0 = 2028505219u;
						continue;
					case 34u:
						this.targetId_ = new EntityId();
						arg_543_0 = (num2 * 17965613u ^ 3506704060u);
						continue;
					case 35u:
						arg_543_0 = (((num == 50u) ? 181682437u : 868373573u) ^ num2 * 267150958u);
						continue;
					case 36u:
						arg_543_0 = (num2 * 2978477609u ^ 2401882917u);
						continue;
					case 37u:
						arg_543_0 = (num2 * 1457593840u ^ 1522700339u);
						continue;
					case 38u:
						arg_543_0 = ((this.peer_ != null) ? 174626566u : 853870144u);
						continue;
					case 39u:
						arg_543_0 = (((num == 10u) ? 690787719u : 1625513647u) ^ num2 * 1667969688u);
						continue;
					case 40u:
						arg_543_0 = (num2 * 3487615548u ^ 3294427942u);
						continue;
					case 41u:
						arg_543_0 = (num2 * 1863787374u ^ 3459343468u);
						continue;
					case 42u:
						arg_543_0 = (num2 * 302070319u ^ 2033632223u);
						continue;
					case 43u:
						input.ReadMessage(this.targetAccountId_);
						arg_543_0 = 1579146391u;
						continue;
					case 44u:
						arg_543_0 = ((this.senderAccountId_ != null) ? 1015917229u : 350342229u);
						continue;
					case 45u:
						arg_543_0 = ((this.targetId_ != null) ? 1694896164u : 1131463646u);
						continue;
					case 46u:
						input.ReadMessage(this.senderId_);
						arg_543_0 = 2028505219u;
						continue;
					case 47u:
						arg_543_0 = (num2 * 2131700520u ^ 2511003179u);
						continue;
					case 48u:
						arg_543_0 = (((num != 74u) ? 844590403u : 1271565308u) ^ num2 * 4224782225u);
						continue;
					case 49u:
						arg_543_0 = (num2 * 3289255930u ^ 1851357965u);
						continue;
					}
					return;
				}
			}
		}

		static Notification()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 331329482u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 1656328958u)) % 3u)
					{
					case 1u:
						Notification._repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(34u, Bgs.Protocol.Attribute.Parser);
						arg_3F_0 = (num * 1732953260u ^ 1382051337u);
						continue;
					case 2u:
						goto IL_57;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}

		static int smethod_3(string string_0)
		{
			return string_0.Length;
		}
	}
}
