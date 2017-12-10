using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Resources.V1
{
	[DebuggerNonUserCode]
	public sealed class ContentHandleRequest : IMessage<ContentHandleRequest>, IEquatable<ContentHandleRequest>, IDeepCloneable<ContentHandleRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly ContentHandleRequest.__c __9 = new ContentHandleRequest.__c();

			internal ContentHandleRequest cctor>b__34_0()
			{
				return new ContentHandleRequest();
			}
		}

		private static readonly MessageParser<ContentHandleRequest> _parser = new MessageParser<ContentHandleRequest>(new Func<ContentHandleRequest>(ContentHandleRequest.__c.__9.<.cctor>b__34_0));

		public const int ProgramFieldNumber = 1;

		private uint program_;

		public const int StreamFieldNumber = 2;

		private uint stream_;

		public const int VersionFieldNumber = 3;

		private uint version_;

		public static MessageParser<ContentHandleRequest> Parser
		{
			get
			{
				return ContentHandleRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ResourceServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentHandleRequest.Descriptor;
			}
		}

		public uint Program
		{
			get
			{
				return this.program_;
			}
			set
			{
				this.program_ = value;
			}
		}

		public uint Stream
		{
			get
			{
				return this.stream_;
			}
			set
			{
				this.stream_ = value;
			}
		}

		public uint Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		public ContentHandleRequest()
		{
		}

		public ContentHandleRequest(ContentHandleRequest other) : this()
		{
			this.program_ = other.program_;
			this.stream_ = other.stream_;
			this.version_ = other.version_;
		}

		public ContentHandleRequest Clone()
		{
			return new ContentHandleRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as ContentHandleRequest);
		}

		public bool Equals(ContentHandleRequest other)
		{
			if (other == null)
			{
				goto IL_8D;
			}
			goto IL_DD;
			int arg_97_0;
			while (true)
			{
				IL_92:
				switch ((arg_97_0 ^ 939620478) % 11)
				{
				case 0:
					return true;
				case 1:
					return false;
				case 2:
					goto IL_8D;
				case 3:
					goto IL_DD;
				case 4:
					return false;
				case 5:
					arg_97_0 = ((this.Version != other.Version) ? 1606711556 : 149153421);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					arg_97_0 = ((this.Program != other.Program) ? 1578846239 : 1603122601);
					continue;
				case 9:
					arg_97_0 = ((this.Stream != other.Stream) ? 2111800084 : 180410102);
					continue;
				}
				break;
			}
			return true;
			IL_8D:
			arg_97_0 = 1764465170;
			goto IL_92;
			IL_DD:
			arg_97_0 = ((other == this) ? 339175193 : 2033301593);
			goto IL_92;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_A4:
				uint arg_84_0 = 110021148u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_84_0 ^ 995499366u)) % 5u)
					{
					case 0u:
						goto IL_A4;
					case 2u:
						arg_84_0 = (((this.Version == 0u) ? 3745304004u : 3405634988u) ^ num2 * 1496738207u);
						continue;
					case 3u:
						num ^= this.Version.GetHashCode();
						arg_84_0 = (num2 * 2947445366u ^ 195338156u);
						continue;
					case 4u:
						num ^= this.Program.GetHashCode();
						num ^= this.Stream.GetHashCode();
						arg_84_0 = (num2 * 3032279369u ^ 132581432u);
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
			output.WriteRawTag(13);
			output.WriteFixed32(this.Program);
			output.WriteRawTag(21);
			while (true)
			{
				IL_AB:
				uint arg_8B_0 = 830469958u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8B_0 ^ 2040654274u)) % 5u)
					{
					case 0u:
						output.WriteRawTag(29);
						output.WriteFixed32(this.Version);
						arg_8B_0 = (num * 270846916u ^ 1591348490u);
						continue;
					case 1u:
						output.WriteFixed32(this.Stream);
						arg_8B_0 = (num * 2505594027u ^ 4010972358u);
						continue;
					case 3u:
						goto IL_AB;
					case 4u:
						arg_8B_0 = (((this.Version == 0u) ? 1669674894u : 122290535u) ^ num * 839847226u);
						continue;
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
				IL_90:
				uint arg_6C_0 = 682876754u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_6C_0 ^ 321931457u)) % 6u)
					{
					case 0u:
						arg_6C_0 = (((this.Version == 0u) ? 2942812029u : 3360786753u) ^ num2 * 2042009441u);
						continue;
					case 1u:
						num += 5;
						arg_6C_0 = (num2 * 1496843209u ^ 56344140u);
						continue;
					case 2u:
						num += 5;
						arg_6C_0 = (num2 * 2333432314u ^ 2726581419u);
						continue;
					case 3u:
						goto IL_90;
					case 5u:
						num += 5;
						arg_6C_0 = (num2 * 2194961247u ^ 673170555u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(ContentHandleRequest other)
		{
			if (other == null)
			{
				goto IL_AE;
			}
			goto IL_F8;
			uint arg_B8_0;
			while (true)
			{
				IL_B3:
				uint num;
				switch ((num = (arg_B8_0 ^ 1481117938u)) % 9u)
				{
				case 0u:
					goto IL_AE;
				case 1u:
					this.Version = other.Version;
					arg_B8_0 = (num * 4020831897u ^ 1413714585u);
					continue;
				case 2u:
					arg_B8_0 = ((other.Stream == 0u) ? 683100910u : 1408589707u);
					continue;
				case 3u:
					this.Program = other.Program;
					arg_B8_0 = (num * 580779127u ^ 3999245948u);
					continue;
				case 4u:
					goto IL_F8;
				case 6u:
					return;
				case 7u:
					this.Stream = other.Stream;
					arg_B8_0 = (num * 3032042521u ^ 4080198719u);
					continue;
				case 8u:
					arg_B8_0 = ((other.Version == 0u) ? 427059833u : 1295170322u);
					continue;
				}
				break;
			}
			return;
			IL_AE:
			arg_B8_0 = 373455822u;
			goto IL_B3;
			IL_F8:
			arg_B8_0 = ((other.Program != 0u) ? 1402660202u : 425095124u);
			goto IL_B3;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_13B:
				uint num;
				uint arg_F3_0 = ((num = input.ReadTag()) == 0u) ? 2832475028u : 3875868814u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_F3_0 ^ 3782351043u)) % 11u)
					{
					case 1u:
						arg_F3_0 = (((num == 29u) ? 3818001735u : 3066532278u) ^ num2 * 651130996u);
						continue;
					case 2u:
						arg_F3_0 = 3875868814u;
						continue;
					case 3u:
						arg_F3_0 = ((num != 13u) ? 3940609223u : 4198650164u);
						continue;
					case 4u:
						arg_F3_0 = (((num != 21u) ? 1354523183u : 198975072u) ^ num2 * 4093704052u);
						continue;
					case 5u:
						this.Version = input.ReadFixed32();
						arg_F3_0 = 3713331752u;
						continue;
					case 6u:
						goto IL_13B;
					case 7u:
						arg_F3_0 = (num2 * 2379059398u ^ 3225345686u);
						continue;
					case 8u:
						input.SkipLastField();
						arg_F3_0 = (num2 * 3483037519u ^ 2753519197u);
						continue;
					case 9u:
						this.Stream = input.ReadFixed32();
						arg_F3_0 = 3713331752u;
						continue;
					case 10u:
						this.Program = input.ReadFixed32();
						arg_F3_0 = 3713331752u;
						continue;
					}
					return;
				}
			}
		}
	}
}
