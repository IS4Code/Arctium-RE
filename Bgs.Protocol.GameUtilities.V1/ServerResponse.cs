using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class ServerResponse : IMessage<ServerResponse>, IEquatable<ServerResponse>, IDeepCloneable<ServerResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ServerResponse.__c __9 = new ServerResponse.__c();

			internal ServerResponse cctor>b__24_0()
			{
				return new ServerResponse();
			}
		}

		private static readonly MessageParser<ServerResponse> _parser = new MessageParser<ServerResponse>(new Func<ServerResponse>(ServerResponse.__c.__9.<.cctor>b__24_0));

		public const int AttributeFieldNumber = 1;

		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_attribute_codec;

		private readonly RepeatedField<Bgs.Protocol.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.Attribute>();

		public static MessageParser<ServerResponse> Parser
		{
			get
			{
				return ServerResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerResponse.Descriptor;
			}
		}

		public RepeatedField<Bgs.Protocol.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		public ServerResponse()
		{
		}

		public ServerResponse(ServerResponse other) : this()
		{
			this.attribute_ = other.attribute_.Clone();
		}

		public ServerResponse Clone()
		{
			return new ServerResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ServerResponse);
		}

		public bool Equals(ServerResponse other)
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
				switch ((arg_48_0 ^ -136253788) % 7)
				{
				case 0:
					goto IL_7A;
				case 1:
					return false;
				case 3:
					return true;
				case 4:
					arg_48_0 = ((!this.attribute_.Equals(other.attribute_)) ? -1337136749 : -1814785561);
					continue;
				case 5:
					return false;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = -900986934;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? -2066298524 : -354686245);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ ServerResponse.smethod_0(this.attribute_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.attribute_.WriteTo(output, ServerResponse._repeated_attribute_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.attribute_.CalculateSize(ServerResponse._repeated_attribute_codec);
		}

		public void MergeFrom(ServerResponse other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = 1519033767;
			IL_08:
			switch ((arg_0D_0 ^ 732749010) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				return;
			case 2:
				IL_27:
				this.attribute_.Add(other.attribute_);
				arg_0D_0 = 164220689;
				goto IL_08;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 1237913662u : 716902232u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 1596697169u)) % 7u)
					{
					case 0u:
						arg_77_0 = 1237913662u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_77_0 = (num2 * 1275023330u ^ 2714899253u);
						continue;
					case 2u:
						goto IL_AE;
					case 4u:
						arg_77_0 = (num2 * 1086105345u ^ 2668523276u);
						continue;
					case 5u:
						this.attribute_.AddEntriesFrom(input, ServerResponse._repeated_attribute_codec);
						arg_77_0 = 283710852u;
						continue;
					case 6u:
						arg_77_0 = ((num != 10u) ? 93399303u : 1194845891u);
						continue;
					}
					return;
				}
			}
		}

		static ServerResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 2611793139u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 3522437237u)) % 3u)
					{
					case 0u:
						goto IL_57;
					case 1u:
						ServerResponse._repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(10u, Bgs.Protocol.Attribute.Parser);
						arg_3F_0 = (num * 2704498165u ^ 928992842u);
						continue;
					}
					return;
				}
			}
		}

		static int smethod_0(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
