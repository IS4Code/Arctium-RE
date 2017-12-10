using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.GameUtilities.V1
{
	[DebuggerNonUserCode]
	public sealed class GetAchievementsFileResponse : IMessage<GetAchievementsFileResponse>, IEquatable<GetAchievementsFileResponse>, IDeepCloneable<GetAchievementsFileResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GetAchievementsFileResponse.__c __9 = new GetAchievementsFileResponse.__c();

			internal GetAchievementsFileResponse cctor>b__24_0()
			{
				return new GetAchievementsFileResponse();
			}
		}

		private static readonly MessageParser<GetAchievementsFileResponse> _parser = new MessageParser<GetAchievementsFileResponse>(new Func<GetAchievementsFileResponse>(GetAchievementsFileResponse.__c.__9.<.cctor>b__24_0));

		public const int ContentHandleFieldNumber = 1;

		private ContentHandle contentHandle_;

		public static MessageParser<GetAchievementsFileResponse> Parser
		{
			get
			{
				return GetAchievementsFileResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAchievementsFileResponse.Descriptor;
			}
		}

		public ContentHandle ContentHandle
		{
			get
			{
				return this.contentHandle_;
			}
			set
			{
				this.contentHandle_ = value;
			}
		}

		public GetAchievementsFileResponse()
		{
		}

		public GetAchievementsFileResponse(GetAchievementsFileResponse other) : this()
		{
			this.ContentHandle = ((other.contentHandle_ != null) ? other.ContentHandle.Clone() : null);
		}

		public GetAchievementsFileResponse Clone()
		{
			return new GetAchievementsFileResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GetAchievementsFileResponse);
		}

		public bool Equals(GetAchievementsFileResponse other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 1091212789) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return false;
				case 2:
					arg_48_0 = (GetAchievementsFileResponse.smethod_0(this.ContentHandle, other.ContentHandle) ? 1215725019 : 823294605);
					continue;
				case 3:
					return true;
				case 4:
					return false;
				case 5:
					goto IL_7A;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 775459893;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? 598185604 : 20023786);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			while (true)
			{
				IL_69:
				uint arg_4D_0 = 2305690618u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4D_0 ^ 3645522797u)) % 4u)
					{
					case 0u:
						goto IL_69;
					case 1u:
						num ^= GetAchievementsFileResponse.smethod_1(this.ContentHandle);
						arg_4D_0 = (num2 * 4037621187u ^ 1694381152u);
						continue;
					case 3u:
						arg_4D_0 = (((this.contentHandle_ == null) ? 2658343728u : 3753364951u) ^ num2 * 1890891881u);
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
			if (this.contentHandle_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 1510243727u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 1346079777u)) % 4u)
						{
						case 0u:
							goto IL_5B;
						case 2u:
							output.WriteRawTag(10);
							arg_3F_0 = (num * 4060003978u ^ 3612647446u);
							continue;
						case 3u:
							output.WriteMessage(this.ContentHandle);
							arg_3F_0 = (num * 4046616517u ^ 22387015u);
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
				uint arg_4F_0 = 393306164u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_4F_0 ^ 903726525u)) % 4u)
					{
					case 0u:
						goto IL_6B;
					case 1u:
						arg_4F_0 = (((this.contentHandle_ != null) ? 2020608526u : 160690639u) ^ num2 * 23830280u);
						continue;
					case 3u:
						num += 1 + CodedOutputStream.ComputeMessageSize(this.ContentHandle);
						arg_4F_0 = (num2 * 564302645u ^ 1928061552u);
						continue;
					}
					return num;
				}
			}
			return num;
		}

		public void MergeFrom(GetAchievementsFileResponse other)
		{
			if (other == null)
			{
				goto IL_15;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 4146359975u)) % 7u)
				{
				case 0u:
					this.contentHandle_ = new ContentHandle();
					arg_7A_0 = (num * 3012817987u ^ 2535435534u);
					continue;
				case 1u:
					arg_7A_0 = (((this.contentHandle_ != null) ? 2751001615u : 3950844082u) ^ num * 790963209u);
					continue;
				case 3u:
					return;
				case 4u:
					this.ContentHandle.MergeFrom(other.ContentHandle);
					arg_7A_0 = 2304303825u;
					continue;
				case 5u:
					goto IL_B1;
				case 6u:
					goto IL_15;
				}
				break;
			}
			return;
			IL_15:
			arg_7A_0 = 2872367537u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.contentHandle_ != null) ? 2746779344u : 2304303825u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F3:
				uint num;
				uint arg_B3_0 = ((num = input.ReadTag()) != 0u) ? 2278426093u : 3284117644u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 3682691536u)) % 9u)
					{
					case 0u:
						goto IL_F3;
					case 1u:
						arg_B3_0 = ((this.contentHandle_ != null) ? 3456065100u : 3525891659u);
						continue;
					case 2u:
						input.ReadMessage(this.contentHandle_);
						arg_B3_0 = 2996628051u;
						continue;
					case 3u:
						arg_B3_0 = (num2 * 4105314507u ^ 3511464207u);
						continue;
					case 4u:
						arg_B3_0 = ((num == 10u) ? 3330101382u : 3905589687u);
						continue;
					case 5u:
						this.contentHandle_ = new ContentHandle();
						arg_B3_0 = (num2 * 95149221u ^ 3546672299u);
						continue;
					case 6u:
						input.SkipLastField();
						arg_B3_0 = (num2 * 1195574400u ^ 3691173060u);
						continue;
					case 7u:
						arg_B3_0 = 2278426093u;
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
