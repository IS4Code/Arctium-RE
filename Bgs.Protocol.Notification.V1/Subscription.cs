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
	public sealed class Subscription : IMessage<Subscription>, IEquatable<Subscription>, IDeepCloneable<Subscription>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly Subscription.__c __9 = new Subscription.__c();

			internal Subscription cctor>b__34_0()
			{
				return new Subscription();
			}
		}

		private static readonly MessageParser<Subscription> _parser = new MessageParser<Subscription>(new Func<Subscription>(Subscription.__c.__9.<.cctor>b__34_0));

		public const int TargetFieldNumber = 1;

		private static readonly FieldCodec<Target> _repeated_target_codec = FieldCodec.ForMessage<Target>(10u, Bgs.Protocol.Notification.V1.Target.Parser);

		private readonly RepeatedField<Target> target_ = new RepeatedField<Target>();

		public const int SubscriberFieldNumber = 2;

		private Bgs.Protocol.Account.V1.Identity subscriber_;

		public const int DeliveryRequiredFieldNumber = 3;

		private bool deliveryRequired_;

		public static MessageParser<Subscription> Parser
		{
			get
			{
				return Subscription._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Subscription.Descriptor;
			}
		}

		public RepeatedField<Target> Target
		{
			get
			{
				return this.target_;
			}
		}

		public Bgs.Protocol.Account.V1.Identity Subscriber
		{
			get
			{
				return this.subscriber_;
			}
			set
			{
				this.subscriber_ = value;
			}
		}

		public bool DeliveryRequired
		{
			get
			{
				return this.deliveryRequired_;
			}
			set
			{
				this.deliveryRequired_ = value;
			}
		}

		public Subscription()
		{
		}

		public Subscription(Subscription other) : this()
		{
			this.target_ = other.target_.Clone();
			this.Subscriber = ((other.subscriber_ != null) ? other.Subscriber.Clone() : null);
			this.deliveryRequired_ = other.deliveryRequired_;
		}

		public Subscription Clone()
		{
			return new Subscription(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as Subscription);
		}

		public bool Equals(Subscription other)
		{
			if (other == null)
			{
				goto IL_9A;
			}
			goto IL_EA;
			int arg_A4_0;
			while (true)
			{
				IL_9F:
				switch ((arg_A4_0 ^ 7964622) % 11)
				{
				case 0:
					goto IL_9A;
				case 1:
					return false;
				case 2:
					arg_A4_0 = (this.target_.Equals(other.target_) ? 1363278412 : 1886253932);
					continue;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					arg_A4_0 = ((this.DeliveryRequired == other.DeliveryRequired) ? 1856649697 : 1541726576);
					continue;
				case 6:
					arg_A4_0 = (Subscription.smethod_0(this.Subscriber, other.Subscriber) ? 806515713 : 1935744554);
					continue;
				case 7:
					return false;
				case 9:
					goto IL_EA;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_9A:
			arg_A4_0 = 2066859763;
			goto IL_9F;
			IL_EA:
			arg_A4_0 = ((other == this) ? 409975692 : 663058465);
			goto IL_9F;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_D9:
				uint arg_B1_0 = 471177095u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B1_0 ^ 448265304u)) % 7u)
					{
					case 0u:
						num ^= this.DeliveryRequired.GetHashCode();
						arg_B1_0 = (num2 * 1833223068u ^ 2894518662u);
						continue;
					case 1u:
						num ^= Subscription.smethod_1(this.target_);
						arg_B1_0 = (num2 * 1878798975u ^ 2930189770u);
						continue;
					case 2u:
						arg_B1_0 = (((this.subscriber_ != null) ? 2015836977u : 1081124052u) ^ num2 * 197443270u);
						continue;
					case 3u:
						num ^= Subscription.smethod_1(this.Subscriber);
						arg_B1_0 = (num2 * 1910783425u ^ 4025052413u);
						continue;
					case 4u:
						goto IL_D9;
					case 5u:
						arg_B1_0 = ((!this.DeliveryRequired) ? 393721114u : 1035667353u);
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
			this.target_.WriteTo(output, Subscription._repeated_target_codec);
			while (true)
			{
				IL_E0:
				uint arg_B8_0 = 2548894793u;
				while (true)
				{
					uint num;
					switch ((num = (arg_B8_0 ^ 2490947613u)) % 7u)
					{
					case 0u:
						output.WriteBool(this.DeliveryRequired);
						arg_B8_0 = (num * 1031393544u ^ 3836759039u);
						continue;
					case 1u:
						arg_B8_0 = (((this.subscriber_ != null) ? 4150777326u : 2282326086u) ^ num * 1076301495u);
						continue;
					case 2u:
						output.WriteRawTag(24);
						arg_B8_0 = (num * 3334719059u ^ 1731835778u);
						continue;
					case 3u:
						goto IL_E0;
					case 4u:
						output.WriteRawTag(18);
						output.WriteMessage(this.Subscriber);
						arg_B8_0 = (num * 301732386u ^ 3456917908u);
						continue;
					case 6u:
						arg_B8_0 = (this.DeliveryRequired ? 3187940163u : 4082587607u);
						continue;
					}
					return;
				}
			}
		}

		public int CalculateSize()
		{
			int num = 0 + this.target_.CalculateSize(Subscription._repeated_target_codec);
			while (true)
			{
				IL_BD:
				uint arg_99_0 = 2970534090u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_99_0 ^ 2998110316u)) % 6u)
					{
					case 0u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
						arg_99_0 = (num2 * 2610837631u ^ 3092066339u);
						continue;
					case 2u:
						goto IL_BD;
					case 3u:
						num += 2;
						arg_99_0 = (num2 * 2875878761u ^ 3171378656u);
						continue;
					case 4u:
						arg_99_0 = (((this.subscriber_ != null) ? 457784412u : 1513998063u) ^ num2 * 166657767u);
						continue;
					case 5u:
						arg_99_0 = ((!this.DeliveryRequired) ? 2914900815u : 3563231291u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(Subscription other)
		{
			if (other == null)
			{
				goto IL_96;
			}
			goto IL_110;
			uint arg_DB_0;
			while (true)
			{
				IL_D6:
				uint num;
				switch ((num = (arg_DB_0 ^ 1759671886u)) % 10u)
				{
				case 0u:
					arg_DB_0 = ((!other.DeliveryRequired) ? 1251438218u : 1940621507u);
					continue;
				case 1u:
					return;
				case 2u:
					this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
					arg_DB_0 = (num * 677360541u ^ 558253952u);
					continue;
				case 3u:
					goto IL_96;
				case 4u:
					arg_DB_0 = (((this.subscriber_ == null) ? 1201748648u : 2017813374u) ^ num * 663022425u);
					continue;
				case 5u:
					this.DeliveryRequired = other.DeliveryRequired;
					arg_DB_0 = (num * 2331707757u ^ 2216966531u);
					continue;
				case 7u:
					goto IL_110;
				case 8u:
					this.Subscriber.MergeFrom(other.Subscriber);
					arg_DB_0 = 1586841262u;
					continue;
				case 9u:
					arg_DB_0 = (((other.subscriber_ == null) ? 3811662548u : 3833615036u) ^ num * 467610122u);
					continue;
				}
				break;
			}
			return;
			IL_96:
			arg_DB_0 = 972119607u;
			goto IL_D6;
			IL_110:
			this.target_.Add(other.target_);
			arg_DB_0 = 2138320791u;
			goto IL_D6;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1AF:
				uint num;
				uint arg_157_0 = ((num = input.ReadTag()) != 0u) ? 1249814007u : 2145295015u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_157_0 ^ 999655017u)) % 15u)
					{
					case 0u:
						goto IL_1AF;
					case 1u:
						arg_157_0 = ((num != 10u) ? 157867089u : 1304758693u);
						continue;
					case 3u:
						arg_157_0 = (num2 * 1226072962u ^ 1553621811u);
						continue;
					case 4u:
						this.subscriber_ = new Bgs.Protocol.Account.V1.Identity();
						arg_157_0 = (num2 * 2564590638u ^ 1511124511u);
						continue;
					case 5u:
						this.target_.AddEntriesFrom(input, Subscription._repeated_target_codec);
						arg_157_0 = 128768147u;
						continue;
					case 6u:
						input.SkipLastField();
						arg_157_0 = (num2 * 643586391u ^ 1296060603u);
						continue;
					case 7u:
						arg_157_0 = 1249814007u;
						continue;
					case 8u:
						input.ReadMessage(this.subscriber_);
						arg_157_0 = 593690679u;
						continue;
					case 9u:
						arg_157_0 = ((this.subscriber_ == null) ? 170264808u : 1965017393u);
						continue;
					case 10u:
						this.DeliveryRequired = input.ReadBool();
						arg_157_0 = 216331919u;
						continue;
					case 11u:
						arg_157_0 = (num2 * 1606619566u ^ 3495940451u);
						continue;
					case 12u:
						arg_157_0 = (((num == 24u) ? 1962035627u : 1425551195u) ^ num2 * 3787884850u);
						continue;
					case 13u:
						arg_157_0 = (num2 * 1218652786u ^ 3810732707u);
						continue;
					case 14u:
						arg_157_0 = (((num == 18u) ? 3846170097u : 2832951822u) ^ num2 * 3664064350u);
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
