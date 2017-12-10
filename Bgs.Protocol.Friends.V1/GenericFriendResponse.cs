using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Friends.V1
{
	[DebuggerNonUserCode]
	public sealed class GenericFriendResponse : IMessage<GenericFriendResponse>, IEquatable<GenericFriendResponse>, IDeepCloneable<GenericFriendResponse>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly GenericFriendResponse.__c __9 = new GenericFriendResponse.__c();

			internal GenericFriendResponse cctor>b__24_0()
			{
				return new GenericFriendResponse();
			}
		}

		private static readonly MessageParser<GenericFriendResponse> _parser = new MessageParser<GenericFriendResponse>(new Func<GenericFriendResponse>(GenericFriendResponse.__c.__9.<.cctor>b__24_0));

		public const int TargetFriendFieldNumber = 1;

		private Friend targetFriend_;

		public static MessageParser<GenericFriendResponse> Parser
		{
			get
			{
				return GenericFriendResponse._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenericFriendResponse.Descriptor;
			}
		}

		public Friend TargetFriend
		{
			get
			{
				return this.targetFriend_;
			}
			set
			{
				this.targetFriend_ = value;
			}
		}

		public GenericFriendResponse()
		{
		}

		public GenericFriendResponse(GenericFriendResponse other) : this()
		{
			this.TargetFriend = ((other.targetFriend_ != null) ? other.TargetFriend.Clone() : null);
		}

		public GenericFriendResponse Clone()
		{
			return new GenericFriendResponse(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as GenericFriendResponse);
		}

		public bool Equals(GenericFriendResponse other)
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
				switch ((arg_48_0 ^ -481284102) % 7)
				{
				case 0:
					goto IL_3E;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
					goto IL_7A;
				case 6:
					arg_48_0 = ((!GenericFriendResponse.smethod_0(this.TargetFriend, other.TargetFriend)) ? -755819204 : -215223555);
					continue;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = -1433998514;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other == this) ? -1363562283 : -174120665);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			int num = 1;
			if (this.targetFriend_ != null)
			{
				while (true)
				{
					IL_44:
					uint arg_2C_0 = 608288889u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2C_0 ^ 582910853u)) % 3u)
						{
						case 1u:
							num ^= GenericFriendResponse.smethod_1(this.TargetFriend);
							arg_2C_0 = (num2 * 602309793u ^ 2349492596u);
							continue;
						case 2u:
							goto IL_44;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			if (this.targetFriend_ != null)
			{
				while (true)
				{
					IL_5B:
					uint arg_3F_0 = 3176292016u;
					while (true)
					{
						uint num;
						switch ((num = (arg_3F_0 ^ 3401141181u)) % 4u)
						{
						case 1u:
							output.WriteRawTag(10);
							arg_3F_0 = (num * 1500409397u ^ 2435209951u);
							continue;
						case 2u:
							goto IL_5B;
						case 3u:
							output.WriteMessage(this.TargetFriend);
							arg_3F_0 = (num * 3313887079u ^ 971432596u);
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
			if (this.targetFriend_ != null)
			{
				while (true)
				{
					IL_46:
					uint arg_2E_0 = 2279332820u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_2E_0 ^ 3321124023u)) % 3u)
						{
						case 0u:
							goto IL_46;
						case 1u:
							num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetFriend);
							arg_2E_0 = (num2 * 2963102706u ^ 3279582639u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
			return num;
		}

		public void MergeFrom(GenericFriendResponse other)
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
				switch ((num = (arg_7A_0 ^ 2743814540u)) % 7u)
				{
				case 0u:
					goto IL_B1;
				case 1u:
					this.TargetFriend.MergeFrom(other.TargetFriend);
					arg_7A_0 = 2858933175u;
					continue;
				case 2u:
					this.targetFriend_ = new Friend();
					arg_7A_0 = (num * 3012147199u ^ 3870607763u);
					continue;
				case 3u:
					arg_7A_0 = (((this.targetFriend_ == null) ? 1138256825u : 942591064u) ^ num * 1900074668u);
					continue;
				case 5u:
					return;
				case 6u:
					goto IL_15;
				}
				break;
			}
			return;
			IL_15:
			arg_7A_0 = 3987139808u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.targetFriend_ == null) ? 2858933175u : 3723162430u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_F3:
				uint num;
				uint arg_B3_0 = ((num = input.ReadTag()) == 0u) ? 391262270u : 792127524u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_B3_0 ^ 1330379313u)) % 9u)
					{
					case 0u:
						arg_B3_0 = 792127524u;
						continue;
					case 1u:
						this.targetFriend_ = new Friend();
						arg_B3_0 = (num2 * 3289956026u ^ 3664980577u);
						continue;
					case 2u:
						arg_B3_0 = ((num != 10u) ? 1246199755u : 664788917u);
						continue;
					case 3u:
						arg_B3_0 = (num2 * 584974791u ^ 1741251918u);
						continue;
					case 4u:
						goto IL_F3;
					case 5u:
						arg_B3_0 = ((this.targetFriend_ == null) ? 133000300u : 1663660019u);
						continue;
					case 7u:
						input.SkipLastField();
						arg_B3_0 = (num2 * 2896022696u ^ 1921387539u);
						continue;
					case 8u:
						input.ReadMessage(this.targetFriend_);
						arg_B3_0 = 1738077072u;
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
