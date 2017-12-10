using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class PlayerVariables : IMessage<PlayerVariables>, IEquatable<PlayerVariables>, IDeepCloneable<PlayerVariables>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly PlayerVariables.__c __9 = new PlayerVariables.__c();

			internal PlayerVariables cctor>b__34_0()
			{
				return new PlayerVariables();
			}
		}

		private static readonly MessageParser<PlayerVariables> _parser = new MessageParser<PlayerVariables>(new Func<PlayerVariables>(PlayerVariables.__c.__9.<.cctor>b__34_0));

		public const int IdentityFieldNumber = 1;

		private Identity identity_;

		public const int RatingFieldNumber = 2;

		private double rating_;

		public const int AttributeFieldNumber = 3;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(26u, Bgs.Protocol.Attribute.Parser);

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public static MessageParser<PlayerVariables> Parser
		{
			get
			{
				return PlayerVariables._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVariables.Descriptor;
			}
		}

		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		public double Rating
		{
			get
			{
				return this.rating_;
			}
			set
			{
				this.rating_ = value;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public PlayerVariables()
		{
		}

		public PlayerVariables(PlayerVariables other) : this()
		{
			while (true)
			{
				IL_8C:
				uint arg_6C_0 = 2383557536u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6C_0 ^ 3616924459u)) % 5u)
					{
					case 0u:
						goto IL_8C;
					case 1u:
						this.Identity = ((other.identity_ != null) ? other.Identity.Clone() : null);
						arg_6C_0 = 3798668037u;
						continue;
					case 2u:
						this.attribute_ = other.attribute_.Clone();
						arg_6C_0 = (num * 1969194812u ^ 472524545u);
						continue;
					case 3u:
						this.rating_ = other.rating_;
						arg_6C_0 = (num * 4245354942u ^ 1274849377u);
						continue;
					}
					return;
				}
			}
		}

		public PlayerVariables Clone()
		{
			return new PlayerVariables(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVariables);
		}

		public bool Equals(PlayerVariables other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_E7;
			int arg_A1_0;
			while (true)
			{
				IL_9C:
				switch ((arg_A1_0 ^ 1765315137) % 11)
				{
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					arg_A1_0 = ((!this.attribute_.Equals(other.attribute_)) ? 947067185 : 1202162883);
					continue;
				case 5:
					arg_A1_0 = ((this.Rating == other.Rating) ? 1622429503 : 1605838316);
					continue;
				case 6:
					goto IL_E7;
				case 7:
					arg_A1_0 = (PlayerVariables.smethod_0(this.Identity, other.Identity) ? 1361574536 : 214109466);
					continue;
				case 8:
					goto IL_18;
				case 9:
					return true;
				case 10:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_A1_0 = 2057527762;
			goto IL_9C;
			IL_E7:
			arg_A1_0 = ((other != this) ? 1345838806 : 217204812);
			goto IL_9C;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_9F:
				uint arg_7F_0 = 2965734066u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_7F_0 ^ 3407694500u)) % 5u)
					{
					case 0u:
						goto IL_9F;
					case 1u:
						num ^= PlayerVariables.smethod_1(this.Identity);
						arg_7F_0 = (((this.Rating != 0.0) ? 2622733283u : 4227625490u) ^ num2 * 798244398u);
						continue;
					case 2u:
						num ^= this.attribute_.GetHashCode();
						arg_7F_0 = 2808057542u;
						continue;
					case 4u:
						num ^= this.Rating.GetHashCode();
						arg_7F_0 = (num2 * 407181340u ^ 743110258u);
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
			output.WriteRawTag(10);
			output.WriteMessage(this.Identity);
			while (true)
			{
				IL_A9:
				uint arg_89_0 = 2196407766u;
				while (true)
				{
					uint num;
					switch ((num = (arg_89_0 ^ 2478727347u)) % 5u)
					{
					case 0u:
						output.WriteRawTag(17);
						output.WriteDouble(this.Rating);
						arg_89_0 = (num * 2175325036u ^ 3466846445u);
						continue;
					case 1u:
						arg_89_0 = (((this.Rating != 0.0) ? 403211167u : 1007623444u) ^ num * 755390161u);
						continue;
					case 3u:
						this.attribute_.WriteTo(output, PlayerVariables._repeated_attribute_codec);
						arg_89_0 = 3466860008u;
						continue;
					case 4u:
						goto IL_A9;
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
				IL_79:
				uint arg_5D_0 = 2376747840u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_5D_0 ^ 2317507702u)) % 4u)
					{
					case 1u:
						num += 9;
						arg_5D_0 = (num2 * 3209455621u ^ 3268170103u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
						arg_5D_0 = (((this.Rating == 0.0) ? 791270254u : 1527267875u) ^ num2 * 2835051204u);
						continue;
					case 3u:
						goto IL_79;
					}
					goto Block_2;
				}
			}
			Block_2:
			return num + this.attribute_.CalculateSize(PlayerVariables._repeated_attribute_codec);
		}

		public void MergeFrom(PlayerVariables other)
		{
			if (other == null)
			{
				goto IL_D9;
			}
			goto IL_127;
			uint arg_E3_0;
			while (true)
			{
				IL_DE:
				uint num;
				switch ((num = (arg_E3_0 ^ 3788398140u)) % 10u)
				{
				case 0u:
					goto IL_D9;
				case 2u:
					return;
				case 3u:
					arg_E3_0 = (((this.identity_ == null) ? 2733008484u : 3909706057u) ^ num * 2442557110u);
					continue;
				case 4u:
					this.Rating = other.Rating;
					arg_E3_0 = (num * 40007797u ^ 1772240286u);
					continue;
				case 5u:
					goto IL_127;
				case 6u:
					this.identity_ = new Identity();
					arg_E3_0 = (num * 2821318932u ^ 168671323u);
					continue;
				case 7u:
					arg_E3_0 = ((other.Rating != 0.0) ? 3681889280u : 2173528306u);
					continue;
				case 8u:
					this.attribute_.Add(other.attribute_);
					arg_E3_0 = 4158894415u;
					continue;
				case 9u:
					this.Identity.MergeFrom(other.Identity);
					arg_E3_0 = 2689790399u;
					continue;
				}
				break;
			}
			return;
			IL_D9:
			arg_E3_0 = 2238235374u;
			goto IL_DE;
			IL_127:
			arg_E3_0 = ((other.identity_ != null) ? 2937306523u : 2689790399u);
			goto IL_DE;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_199:
				uint num;
				uint arg_145_0 = ((num = input.ReadTag()) != 0u) ? 1685106083u : 2039359105u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_145_0 ^ 1937081726u)) % 14u)
					{
					case 0u:
						goto IL_199;
					case 1u:
						arg_145_0 = ((num != 10u) ? 1824176012u : 443367891u);
						continue;
					case 2u:
						arg_145_0 = (num2 * 2449798022u ^ 807637158u);
						continue;
					case 3u:
						input.ReadMessage(this.identity_);
						arg_145_0 = 1447388458u;
						continue;
					case 4u:
						arg_145_0 = (((num != 26u) ? 3730370298u : 4166605457u) ^ num2 * 3393588191u);
						continue;
					case 6u:
						arg_145_0 = 1685106083u;
						continue;
					case 7u:
						this.Rating = input.ReadDouble();
						arg_145_0 = 1766095772u;
						continue;
					case 8u:
						arg_145_0 = (num2 * 2269217752u ^ 3267088794u);
						continue;
					case 9u:
						this.attribute_.AddEntriesFrom(input, PlayerVariables._repeated_attribute_codec);
						arg_145_0 = 1447388458u;
						continue;
					case 10u:
						input.SkipLastField();
						arg_145_0 = (num2 * 2578504984u ^ 3507678908u);
						continue;
					case 11u:
						arg_145_0 = ((this.identity_ != null) ? 1163804235u : 1857595203u);
						continue;
					case 12u:
						arg_145_0 = (((num == 17u) ? 3954779237u : 3965153058u) ^ num2 * 4005391376u);
						continue;
					case 13u:
						this.identity_ = new Identity();
						arg_145_0 = (num2 * 1233416380u ^ 3947752071u);
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
