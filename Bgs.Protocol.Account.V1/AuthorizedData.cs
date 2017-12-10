using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Account.V1
{
	[DebuggerNonUserCode]
	public sealed class AuthorizedData : IMessage<AuthorizedData>, IEquatable<AuthorizedData>, IDeepCloneable<AuthorizedData>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly AuthorizedData.__c __9 = new AuthorizedData.__c();

			internal AuthorizedData cctor>b__29_0()
			{
				return new AuthorizedData();
			}
		}

		private static readonly MessageParser<AuthorizedData> _parser = new MessageParser<AuthorizedData>(new Func<AuthorizedData>(AuthorizedData.__c.__9.<.cctor>b__29_0));

		public const int DataFieldNumber = 1;

		private string data_ = "";

		public const int LicenseFieldNumber = 2;

		private static readonly FieldCodec<uint> _repeated_license_codec = FieldCodec.ForUInt32(18u);

		private readonly RepeatedField<uint> license_ = new RepeatedField<uint>();

		public static MessageParser<AuthorizedData> Parser
		{
			get
			{
				return AuthorizedData._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[35];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AuthorizedData.Descriptor;
			}
		}

		public string Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = Preconditions.CheckNotNull<string>(value, Module.smethod_34<string>(2130392831u));
			}
		}

		public RepeatedField<uint> License
		{
			get
			{
				return this.license_;
			}
		}

		public AuthorizedData()
		{
		}

		public AuthorizedData(AuthorizedData other) : this()
		{
			this.data_ = other.data_;
			this.license_ = other.license_.Clone();
		}

		public AuthorizedData Clone()
		{
			return new AuthorizedData(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as AuthorizedData);
		}

		public bool Equals(AuthorizedData other)
		{
			if (other == null)
			{
				goto IL_6D;
			}
			goto IL_B5;
			int arg_77_0;
			while (true)
			{
				IL_72:
				switch ((arg_77_0 ^ 1757708499) % 9)
				{
				case 0:
					return false;
				case 1:
					goto IL_B5;
				case 2:
					return false;
				case 3:
					return true;
				case 4:
					goto IL_6D;
				case 5:
					arg_77_0 = ((!AuthorizedData.smethod_0(this.Data, other.Data)) ? 1260636656 : 2046418669);
					continue;
				case 6:
					return false;
				case 8:
					arg_77_0 = (this.license_.Equals(other.license_) ? 159039448 : 194870694);
					continue;
				}
				break;
			}
			return true;
			IL_6D:
			arg_77_0 = 542556968;
			goto IL_72;
			IL_B5:
			arg_77_0 = ((other != this) ? 1915253847 : 823274818);
			goto IL_72;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_8A:
				uint arg_6A_0 = 3394865309u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_6A_0 ^ 3748041431u)) % 5u)
					{
					case 0u:
						num ^= AuthorizedData.smethod_2(this.license_);
						arg_6A_0 = 3791696846u;
						continue;
					case 2u:
						goto IL_8A;
					case 3u:
						num ^= AuthorizedData.smethod_2(this.Data);
						arg_6A_0 = (num2 * 3626397936u ^ 3449716401u);
						continue;
					case 4u:
						arg_6A_0 = (((AuthorizedData.smethod_1(this.Data) != 0) ? 2041683399u : 1976797255u) ^ num2 * 3481560207u);
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
			if (AuthorizedData.smethod_1(this.Data) != 0)
			{
				goto IL_0D;
			}
			goto IL_56;
			uint arg_3A_0;
			while (true)
			{
				IL_35:
				uint num;
				switch ((num = (arg_3A_0 ^ 3007622307u)) % 4u)
				{
				case 1u:
					output.WriteRawTag(10);
					output.WriteString(this.Data);
					arg_3A_0 = (num * 2294691190u ^ 2854463035u);
					continue;
				case 2u:
					goto IL_56;
				case 3u:
					goto IL_0D;
				}
				break;
			}
			return;
			IL_0D:
			arg_3A_0 = 3111150582u;
			goto IL_35;
			IL_56:
			this.license_.WriteTo(output, AuthorizedData._repeated_license_codec);
			arg_3A_0 = 3694060759u;
			goto IL_35;
		}

		public int CalculateSize()
		{
			int num = 0;
			while (true)
			{
				IL_91:
				uint arg_71_0 = 173392389u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_71_0 ^ 1794059730u)) % 5u)
					{
					case 1u:
						arg_71_0 = (((AuthorizedData.smethod_1(this.Data) == 0) ? 2992904664u : 2222401492u) ^ num2 * 378018328u);
						continue;
					case 2u:
						num += 1 + CodedOutputStream.ComputeStringSize(this.Data);
						arg_71_0 = (num2 * 3980594072u ^ 1900420768u);
						continue;
					case 3u:
						num += this.license_.CalculateSize(AuthorizedData._repeated_license_codec);
						arg_71_0 = 1246052956u;
						continue;
					case 4u:
						goto IL_91;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(AuthorizedData other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_7F;
			uint arg_4F_0;
			while (true)
			{
				IL_4A:
				uint num;
				switch ((num = (arg_4F_0 ^ 3210178980u)) % 6u)
				{
				case 0u:
					goto IL_7F;
				case 1u:
					return;
				case 2u:
					this.Data = other.Data;
					arg_4F_0 = (num * 1871020990u ^ 105897451u);
					continue;
				case 3u:
					this.license_.Add(other.license_);
					arg_4F_0 = 4025169451u;
					continue;
				case 4u:
					goto IL_12;
				}
				break;
			}
			return;
			IL_12:
			arg_4F_0 = 4121642979u;
			goto IL_4A;
			IL_7F:
			arg_4F_0 = ((AuthorizedData.smethod_1(other.Data) != 0) ? 3296086318u : 2651277703u);
			goto IL_4A;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_10D:
				uint num;
				uint arg_CD_0 = ((num = input.ReadTag()) != 0u) ? 3092859724u : 2356177287u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_CD_0 ^ 2779670157u)) % 9u)
					{
					case 1u:
						input.SkipLastField();
						arg_CD_0 = (num2 * 552037045u ^ 3903292289u);
						continue;
					case 2u:
						this.license_.AddEntriesFrom(input, AuthorizedData._repeated_license_codec);
						arg_CD_0 = 2988937376u;
						continue;
					case 3u:
						arg_CD_0 = 3092859724u;
						continue;
					case 4u:
						goto IL_10D;
					case 5u:
						this.Data = input.ReadString();
						arg_CD_0 = 2988937376u;
						continue;
					case 6u:
						arg_CD_0 = (((num == 18u) ? 2092980123u : 1097806609u) ^ num2 * 1136821257u);
						continue;
					case 7u:
						arg_CD_0 = ((num == 10u) ? 4164026629u : 3291120509u);
						continue;
					case 8u:
						arg_CD_0 = (((num != 16u) ? 3682249732u : 2874619498u) ^ num2 * 4140144763u);
						continue;
					}
					return;
				}
			}
		}

		static bool smethod_0(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static int smethod_1(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_2(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
