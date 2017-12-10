using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Connection.V1
{
	[DebuggerNonUserCode]
	public sealed class BindRequest : IMessage<BindRequest>, IEquatable<BindRequest>, IDeepCloneable<BindRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly BindRequest.__c __9 = new BindRequest.__c();

			internal BindRequest cctor>b__39_0()
			{
				return new BindRequest();
			}
		}

		private static readonly MessageParser<BindRequest> _parser = new MessageParser<BindRequest>(new Func<BindRequest>(BindRequest.__c.__9.<.cctor>b__39_0));

		public const int DeprecatedImportedServiceHashFieldNumber = 1;

		private static readonly FieldCodec<uint> _repeated_deprecatedImportedServiceHash_codec = FieldCodec.ForFixed32(10u);

		private readonly RepeatedField<uint> deprecatedImportedServiceHash_ = new RepeatedField<uint>();

		public const int DeprecatedExportedServiceFieldNumber = 2;

		private static readonly FieldCodec<BoundService> _repeated_deprecatedExportedService_codec;

		private readonly RepeatedField<BoundService> deprecatedExportedService_ = new RepeatedField<BoundService>();

		public const int ExportedServiceFieldNumber = 3;

		private static readonly FieldCodec<BoundService> _repeated_exportedService_codec;

		private readonly RepeatedField<BoundService> exportedService_ = new RepeatedField<BoundService>();

		public const int ImportedServiceFieldNumber = 4;

		private static readonly FieldCodec<BoundService> _repeated_importedService_codec;

		private readonly RepeatedField<BoundService> importedService_ = new RepeatedField<BoundService>();

		public static MessageParser<BindRequest> Parser
		{
			get
			{
				return BindRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BindRequest.Descriptor;
			}
		}

		[Obsolete]
		public RepeatedField<uint> DeprecatedImportedServiceHash
		{
			get
			{
				return this.deprecatedImportedServiceHash_;
			}
		}

		[Obsolete]
		public RepeatedField<BoundService> DeprecatedExportedService
		{
			get
			{
				return this.deprecatedExportedService_;
			}
		}

		public RepeatedField<BoundService> ExportedService
		{
			get
			{
				return this.exportedService_;
			}
		}

		public RepeatedField<BoundService> ImportedService
		{
			get
			{
				return this.importedService_;
			}
		}

		public BindRequest()
		{
		}

		public BindRequest(BindRequest other) : this()
		{
			this.deprecatedImportedServiceHash_ = other.deprecatedImportedServiceHash_.Clone();
			this.deprecatedExportedService_ = other.deprecatedExportedService_.Clone();
			this.exportedService_ = other.exportedService_.Clone();
			this.importedService_ = other.importedService_.Clone();
		}

		public BindRequest Clone()
		{
			return new BindRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as BindRequest);
		}

		public bool Equals(BindRequest other)
		{
			if (other == null)
			{
				goto IL_18;
			}
			goto IL_126;
			int arg_D8_0;
			while (true)
			{
				IL_D3:
				switch ((arg_D8_0 ^ 267045019) % 13)
				{
				case 0:
					arg_D8_0 = ((!this.importedService_.Equals(other.importedService_)) ? 817030216 : 1079493738);
					continue;
				case 1:
					arg_D8_0 = ((!this.exportedService_.Equals(other.exportedService_)) ? 641441435 : 1302630778);
					continue;
				case 2:
					return false;
				case 3:
					arg_D8_0 = ((!this.deprecatedImportedServiceHash_.Equals(other.deprecatedImportedServiceHash_)) ? 1884608061 : 595126786);
					continue;
				case 4:
					return false;
				case 5:
					arg_D8_0 = (this.deprecatedExportedService_.Equals(other.deprecatedExportedService_) ? 1869459183 : 1829085159);
					continue;
				case 6:
					return false;
				case 8:
					return true;
				case 9:
					goto IL_126;
				case 10:
					goto IL_18;
				case 11:
					return false;
				case 12:
					return false;
				}
				break;
			}
			return true;
			IL_18:
			arg_D8_0 = 172860479;
			goto IL_D3;
			IL_126:
			arg_D8_0 = ((other != this) ? 1262809085 : 1437870563);
			goto IL_D3;
		}

		public override int GetHashCode()
		{
			return 1 ^ BindRequest.smethod_0(this.deprecatedImportedServiceHash_) ^ BindRequest.smethod_0(this.deprecatedExportedService_) ^ BindRequest.smethod_0(this.exportedService_) ^ BindRequest.smethod_0(this.importedService_);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			this.deprecatedImportedServiceHash_.WriteTo(output, BindRequest._repeated_deprecatedImportedServiceHash_codec);
			while (true)
			{
				IL_4E:
				uint arg_36_0 = 3679344897u;
				while (true)
				{
					uint num;
					switch ((num = (arg_36_0 ^ 2449860434u)) % 3u)
					{
					case 0u:
						goto IL_4E;
					case 1u:
						this.deprecatedExportedService_.WriteTo(output, BindRequest._repeated_deprecatedExportedService_codec);
						arg_36_0 = (num * 3634225007u ^ 1394965225u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.exportedService_.WriteTo(output, BindRequest._repeated_exportedService_codec);
			this.importedService_.WriteTo(output, BindRequest._repeated_importedService_codec);
		}

		public int CalculateSize()
		{
			return 0 + this.deprecatedImportedServiceHash_.CalculateSize(BindRequest._repeated_deprecatedImportedServiceHash_codec) + this.deprecatedExportedService_.CalculateSize(BindRequest._repeated_deprecatedExportedService_codec) + this.exportedService_.CalculateSize(BindRequest._repeated_exportedService_codec) + this.importedService_.CalculateSize(BindRequest._repeated_importedService_codec);
		}

		public void MergeFrom(BindRequest other)
		{
			if (other == null)
			{
				goto IL_25;
			}
			goto IL_4F;
			uint arg_2F_0;
			while (true)
			{
				IL_2A:
				uint num;
				switch ((num = (arg_2F_0 ^ 1593013776u)) % 5u)
				{
				case 0u:
					goto IL_25;
				case 1u:
					this.exportedService_.Add(other.exportedService_);
					arg_2F_0 = (num * 2224279942u ^ 3796273912u);
					continue;
				case 3u:
					return;
				case 4u:
					goto IL_4F;
				}
				break;
			}
			this.importedService_.Add(other.importedService_);
			return;
			IL_25:
			arg_2F_0 = 247950512u;
			goto IL_2A;
			IL_4F:
			this.deprecatedImportedServiceHash_.Add(other.deprecatedImportedServiceHash_);
			this.deprecatedExportedService_.Add(other.deprecatedExportedService_);
			arg_2F_0 = 742424168u;
			goto IL_2A;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_1F0:
				uint num;
				uint arg_194_0 = ((num = input.ReadTag()) != 0u) ? 2763667383u : 2848052272u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_194_0 ^ 3700393637u)) % 16u)
					{
					case 0u:
						arg_194_0 = 2763667383u;
						continue;
					case 1u:
						arg_194_0 = (num2 * 1081411796u ^ 1847202805u);
						continue;
					case 2u:
						arg_194_0 = ((num > 13u) ? 3734901133u : 4222415939u);
						continue;
					case 3u:
						this.deprecatedExportedService_.AddEntriesFrom(input, BindRequest._repeated_deprecatedExportedService_codec);
						arg_194_0 = 2664551912u;
						continue;
					case 4u:
						input.SkipLastField();
						arg_194_0 = 3093484809u;
						continue;
					case 6u:
						arg_194_0 = (((num == 10u) ? 4254587559u : 2680916638u) ^ num2 * 2506131538u);
						continue;
					case 7u:
						arg_194_0 = (((num != 13u) ? 689202702u : 855388465u) ^ num2 * 2516856534u);
						continue;
					case 8u:
						arg_194_0 = ((num != 18u) ? 4013010862u : 4131554662u);
						continue;
					case 9u:
						arg_194_0 = (((num != 34u) ? 1978409344u : 208161406u) ^ num2 * 752059977u);
						continue;
					case 10u:
						this.importedService_.AddEntriesFrom(input, BindRequest._repeated_importedService_codec);
						arg_194_0 = 3093484809u;
						continue;
					case 11u:
						arg_194_0 = (((num != 26u) ? 1166719018u : 370169084u) ^ num2 * 1165925186u);
						continue;
					case 12u:
						goto IL_1F0;
					case 13u:
						arg_194_0 = (num2 * 1554438292u ^ 484308365u);
						continue;
					case 14u:
						this.deprecatedImportedServiceHash_.AddEntriesFrom(input, BindRequest._repeated_deprecatedImportedServiceHash_codec);
						arg_194_0 = 3093484809u;
						continue;
					case 15u:
						this.exportedService_.AddEntriesFrom(input, BindRequest._repeated_exportedService_codec);
						arg_194_0 = 3093484809u;
						continue;
					}
					return;
				}
			}
		}

		static BindRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_AE:
				uint arg_8E_0 = 1210991938u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8E_0 ^ 451917867u)) % 5u)
					{
					case 0u:
						goto IL_AE;
					case 2u:
						BindRequest._repeated_exportedService_codec = FieldCodec.ForMessage<BoundService>(26u, BoundService.Parser);
						arg_8E_0 = (num * 720775964u ^ 1392065070u);
						continue;
					case 3u:
						BindRequest._repeated_deprecatedExportedService_codec = FieldCodec.ForMessage<BoundService>(18u, BoundService.Parser);
						arg_8E_0 = (num * 1135561611u ^ 1425679247u);
						continue;
					case 4u:
						BindRequest._repeated_importedService_codec = FieldCodec.ForMessage<BoundService>(34u, BoundService.Parser);
						arg_8E_0 = (num * 1895954380u ^ 3028148241u);
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
