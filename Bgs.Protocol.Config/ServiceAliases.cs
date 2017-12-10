using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Config
{
	[DebuggerNonUserCode]
	public sealed class ServiceAliases : IMessage<ServiceAliases>, IEquatable<ServiceAliases>, IDeepCloneable<ServiceAliases>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ServiceAliases.__c __9 = new ServiceAliases.__c();

			internal ServiceAliases cctor>b__24_0()
			{
				return new ServiceAliases();
			}
		}

		private static readonly MessageParser<ServiceAliases> _parser = new MessageParser<ServiceAliases>(new Func<ServiceAliases>(ServiceAliases.__c.__9.<.cctor>b__24_0));

		public const int ProtocolAliasFieldNumber = 1;

		private static readonly FieldCodec<ProtocolAlias> _repeated_protocolAlias_codec;

		private readonly RepeatedField<ProtocolAlias> protocolAlias_ = new RepeatedField<ProtocolAlias>();

		public static MessageParser<ServiceAliases> Parser
		{
			get
			{
				return ServiceAliases._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.Descriptor.MessageTypes[3];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServiceAliases.Descriptor;
			}
		}

		public RepeatedField<ProtocolAlias> ProtocolAlias
		{
			get
			{
				return this.protocolAlias_;
			}
		}

		public ServiceAliases()
		{
		}

		public ServiceAliases(ServiceAliases other) : this()
		{
			this.protocolAlias_ = other.protocolAlias_.Clone();
		}

		public ServiceAliases Clone()
		{
			return new ServiceAliases(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ServiceAliases);
		}

		public bool Equals(ServiceAliases other)
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
				switch ((arg_48_0 ^ 1702468532) % 7)
				{
				case 0:
					return false;
				case 1:
					goto IL_7A;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					arg_48_0 = ((!this.protocolAlias_.Equals(other.protocolAlias_)) ? 4507462 : 737729059);
					continue;
				case 6:
					goto IL_12;
				}
				break;
			}
			return true;
			IL_12:
			arg_48_0 = 1107723482;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? 2096453890 : 1970810046);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ ServiceAliases.smethod_0(this.protocolAlias_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.protocolAlias_.WriteTo(output, ServiceAliases._repeated_protocolAlias_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.protocolAlias_.CalculateSize(ServiceAliases._repeated_protocolAlias_codec);
		}

		public void MergeFrom(ServiceAliases other)
		{
			if (other != null)
			{
				goto IL_27;
			}
			IL_03:
			int arg_0D_0 = -654176352;
			IL_08:
			switch ((arg_0D_0 ^ -1874911169) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				IL_27:
				this.protocolAlias_.Add(other.protocolAlias_);
				arg_0D_0 = -1663324043;
				goto IL_08;
			case 3:
				return;
			}
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_AE:
				uint num;
				uint arg_77_0 = ((num = input.ReadTag()) != 0u) ? 2502439279u : 4180235726u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_77_0 ^ 2872219501u)) % 7u)
					{
					case 0u:
						arg_77_0 = 2502439279u;
						continue;
					case 1u:
						input.SkipLastField();
						arg_77_0 = (num2 * 402693679u ^ 2120460632u);
						continue;
					case 2u:
						goto IL_AE;
					case 3u:
						arg_77_0 = ((num == 10u) ? 2877924794u : 4019724560u);
						continue;
					case 5u:
						this.protocolAlias_.AddEntriesFrom(input, ServiceAliases._repeated_protocolAlias_codec);
						arg_77_0 = 2850981270u;
						continue;
					case 6u:
						arg_77_0 = (num2 * 3820891117u ^ 2842768600u);
						continue;
					}
					return;
				}
			}
		}

		static ServiceAliases()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_57:
				uint arg_3F_0 = 3269351539u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3F_0 ^ 2930130785u)) % 3u)
					{
					case 1u:
						ServiceAliases._repeated_protocolAlias_codec = FieldCodec.ForMessage<ProtocolAlias>(10u, Bgs.Protocol.Config.ProtocolAlias.Parser);
						arg_3F_0 = (num * 719774220u ^ 1128839081u);
						continue;
					case 2u:
						goto IL_57;
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
