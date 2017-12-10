using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public static class FieldCodec
	{
		private static class WrapperCodecs
		{
			private static readonly Dictionary<Type, object> Codecs = new Dictionary<Type, object>
			{
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(bool).TypeHandle),
					FieldCodec.ForBool(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(int).TypeHandle),
					FieldCodec.ForInt32(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(long).TypeHandle),
					FieldCodec.ForInt64(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(uint).TypeHandle),
					FieldCodec.ForUInt32(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(ulong).TypeHandle),
					FieldCodec.ForUInt64(WireFormat.MakeTag(1, WireFormat.WireType.Varint))
				},
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(float).TypeHandle),
					FieldCodec.ForFloat(WireFormat.MakeTag(1, WireFormat.WireType.Fixed32))
				},
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(double).TypeHandle),
					FieldCodec.ForDouble(WireFormat.MakeTag(1, WireFormat.WireType.Fixed64))
				},
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(string).TypeHandle),
					FieldCodec.ForString(WireFormat.MakeTag(1, WireFormat.WireType.LengthDelimited))
				},
				{
					FieldCodec.WrapperCodecs.smethod_0(typeof(ByteString).TypeHandle),
					FieldCodec.ForBytes(WireFormat.MakeTag(1, WireFormat.WireType.LengthDelimited))
				}
			};

			internal static FieldCodec<T> GetCodec<T>()
			{
				object obj;
				if (!FieldCodec.WrapperCodecs.Codecs.TryGetValue(FieldCodec.WrapperCodecs.smethod_0(typeof(T).TypeHandle), out obj))
				{
					throw FieldCodec.WrapperCodecs.smethod_2(FieldCodec.WrapperCodecs.smethod_1(Module.smethod_36<string>(372525645u), FieldCodec.WrapperCodecs.smethod_0(typeof(T).TypeHandle)));
				}
				return (FieldCodec<T>)obj;
			}

			internal static T Read<T>(CodedInputStream input, FieldCodec<T> codec)
			{
				int byteLimit = input.ReadLength();
				T result;
				while (true)
				{
					IL_FA:
					uint arg_C8_0 = 1476935752u;
					while (true)
					{
						uint num;
						switch ((num = (arg_C8_0 ^ 2018772964u)) % 9u)
						{
						case 0u:
							input.SkipLastField();
							arg_C8_0 = 1768391466u;
							continue;
						case 1u:
						{
							uint num2;
							arg_C8_0 = (((num2 = input.ReadTag()) == 0u) ? 789788880u : 1000495088u);
							continue;
						}
						case 3u:
							arg_C8_0 = (num * 422428889u ^ 15908708u);
							continue;
						case 4u:
							result = codec.Read(input);
							arg_C8_0 = (num * 2015424451u ^ 1456283564u);
							continue;
						case 5u:
						{
							uint num2;
							arg_C8_0 = ((num2 == codec.Tag) ? 627669222u : 345821031u);
							continue;
						}
						case 6u:
						{
							input.CheckReadEndOfStreamTag();
							int oldLimit;
							input.PopLimit(oldLimit);
							arg_C8_0 = (num * 1368242210u ^ 1133084529u);
							continue;
						}
						case 7u:
						{
							int oldLimit = input.PushLimit(byteLimit);
							result = codec.DefaultValue;
							arg_C8_0 = (num * 2466023856u ^ 3651674u);
							continue;
						}
						case 8u:
							goto IL_FA;
						}
						return result;
					}
				}
				return result;
			}

			internal static void Write<T>(CodedOutputStream output, T value, FieldCodec<T> codec)
			{
				output.WriteLength(codec.CalculateSizeWithTag(value));
				codec.WriteTagAndValue(output, value);
			}

			internal static int CalculateSize<T>(T value, FieldCodec<T> codec)
			{
				int num = codec.CalculateSizeWithTag(value);
				return CodedOutputStream.ComputeLengthSize(num) + num;
			}

			static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
			{
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}

			static string smethod_1(object object_0, object object_1)
			{
				return object_0 + object_1;
			}

			static InvalidOperationException smethod_2(string string_0)
			{
				return new InvalidOperationException(string_0);
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly FieldCodec.__c __9 = new FieldCodec.__c();

			public static Func<CodedInputStream, string> __9__0_0;

			public static Action<CodedOutputStream, string> __9__0_1;

			public static Func<CodedInputStream, ByteString> __9__1_0;

			public static Action<CodedOutputStream, ByteString> __9__1_1;

			public static Func<CodedInputStream, bool> __9__2_0;

			public static Action<CodedOutputStream, bool> __9__2_1;

			public static Func<CodedInputStream, int> __9__3_0;

			public static Action<CodedOutputStream, int> __9__3_1;

			public static Func<CodedInputStream, int> __9__4_0;

			public static Action<CodedOutputStream, int> __9__4_1;

			public static Func<CodedInputStream, uint> __9__5_0;

			public static Action<CodedOutputStream, uint> __9__5_1;

			public static Func<CodedInputStream, int> __9__6_0;

			public static Action<CodedOutputStream, int> __9__6_1;

			public static Func<CodedInputStream, uint> __9__7_0;

			public static Action<CodedOutputStream, uint> __9__7_1;

			public static Func<CodedInputStream, long> __9__8_0;

			public static Action<CodedOutputStream, long> __9__8_1;

			public static Func<CodedInputStream, long> __9__9_0;

			public static Action<CodedOutputStream, long> __9__9_1;

			public static Func<CodedInputStream, ulong> __9__10_0;

			public static Action<CodedOutputStream, ulong> __9__10_1;

			public static Func<CodedInputStream, long> __9__11_0;

			public static Action<CodedOutputStream, long> __9__11_1;

			public static Func<CodedInputStream, ulong> __9__12_0;

			public static Action<CodedOutputStream, ulong> __9__12_1;

			public static Func<CodedInputStream, float> __9__13_0;

			public static Action<CodedOutputStream, float> __9__13_1;

			public static Func<CodedInputStream, double> __9__14_0;

			public static Action<CodedOutputStream, double> __9__14_1;

			internal string <ForString>b__0_0(CodedInputStream input)
			{
				return input.ReadString();
			}

			internal void <ForString>b__0_1(CodedOutputStream output, string value)
			{
				output.WriteString(value);
			}

			internal ByteString <ForBytes>b__1_0(CodedInputStream input)
			{
				return input.ReadBytes();
			}

			internal void <ForBytes>b__1_1(CodedOutputStream output, ByteString value)
			{
				output.WriteBytes(value);
			}

			internal bool <ForBool>b__2_0(CodedInputStream input)
			{
				return input.ReadBool();
			}

			internal void <ForBool>b__2_1(CodedOutputStream output, bool value)
			{
				output.WriteBool(value);
			}

			internal int <ForInt32>b__3_0(CodedInputStream input)
			{
				return input.ReadInt32();
			}

			internal void <ForInt32>b__3_1(CodedOutputStream output, int value)
			{
				output.WriteInt32(value);
			}

			internal int <ForSInt32>b__4_0(CodedInputStream input)
			{
				return input.ReadSInt32();
			}

			internal void <ForSInt32>b__4_1(CodedOutputStream output, int value)
			{
				output.WriteSInt32(value);
			}

			internal uint <ForFixed32>b__5_0(CodedInputStream input)
			{
				return input.ReadFixed32();
			}

			internal void <ForFixed32>b__5_1(CodedOutputStream output, uint value)
			{
				output.WriteFixed32(value);
			}

			internal int <ForSFixed32>b__6_0(CodedInputStream input)
			{
				return input.ReadSFixed32();
			}

			internal void <ForSFixed32>b__6_1(CodedOutputStream output, int value)
			{
				output.WriteSFixed32(value);
			}

			internal uint <ForUInt32>b__7_0(CodedInputStream input)
			{
				return input.ReadUInt32();
			}

			internal void <ForUInt32>b__7_1(CodedOutputStream output, uint value)
			{
				output.WriteUInt32(value);
			}

			internal long <ForInt64>b__8_0(CodedInputStream input)
			{
				return input.ReadInt64();
			}

			internal void <ForInt64>b__8_1(CodedOutputStream output, long value)
			{
				output.WriteInt64(value);
			}

			internal long <ForSInt64>b__9_0(CodedInputStream input)
			{
				return input.ReadSInt64();
			}

			internal void <ForSInt64>b__9_1(CodedOutputStream output, long value)
			{
				output.WriteSInt64(value);
			}

			internal ulong <ForFixed64>b__10_0(CodedInputStream input)
			{
				return input.ReadFixed64();
			}

			internal void <ForFixed64>b__10_1(CodedOutputStream output, ulong value)
			{
				output.WriteFixed64(value);
			}

			internal long <ForSFixed64>b__11_0(CodedInputStream input)
			{
				return input.ReadSFixed64();
			}

			internal void <ForSFixed64>b__11_1(CodedOutputStream output, long value)
			{
				output.WriteSFixed64(value);
			}

			internal ulong <ForUInt64>b__12_0(CodedInputStream input)
			{
				return input.ReadUInt64();
			}

			internal void <ForUInt64>b__12_1(CodedOutputStream output, ulong value)
			{
				output.WriteUInt64(value);
			}

			internal float <ForFloat>b__13_0(CodedInputStream input)
			{
				return input.ReadFloat();
			}

			internal void <ForFloat>b__13_1(CodedOutputStream output, float value)
			{
				output.WriteFloat(value);
			}

			internal double <ForDouble>b__14_0(CodedInputStream input)
			{
				return input.ReadDouble();
			}

			internal void <ForDouble>b__14_1(CodedOutputStream output, double value)
			{
				output.WriteDouble(value);
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c__16<T> where T : object, IMessage<T>
		{
			public static readonly FieldCodec.__c__16<T> __9 = new FieldCodec.__c__16<T>();

			public static Action<CodedOutputStream, T> __9__16_1;

			public static Func<T, int> __9__16_2;

			internal void <ForMessage>b__16_1(CodedOutputStream output, T value)
			{
				output.WriteMessage(value);
			}

			internal int <ForMessage>b__16_2(T message)
			{
				return CodedOutputStream.ComputeMessageSize(message);
			}
		}

		public static FieldCodec<string> ForString(uint tag)
		{
			Func<CodedInputStream, string> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__0_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__0_0 = new Func<CodedInputStream, string>(FieldCodec.__c.__9.<ForString>b__0_0));
			}
			Action<CodedOutputStream, string> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__0_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__0_1 = new Action<CodedOutputStream, string>(FieldCodec.__c.__9.<ForString>b__0_1));
			}
			return new FieldCodec<string>(arg_4B_0, arg_4B_1, new Func<string, int>(CodedOutputStream.ComputeStringSize), tag);
		}

		public static FieldCodec<ByteString> ForBytes(uint tag)
		{
			Func<CodedInputStream, ByteString> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__1_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__1_0 = new Func<CodedInputStream, ByteString>(FieldCodec.__c.__9.<ForBytes>b__1_0));
			}
			Action<CodedOutputStream, ByteString> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__1_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__1_1 = new Action<CodedOutputStream, ByteString>(FieldCodec.__c.__9.<ForBytes>b__1_1));
			}
			return new FieldCodec<ByteString>(arg_4B_0, arg_4B_1, new Func<ByteString, int>(CodedOutputStream.ComputeBytesSize), tag);
		}

		public static FieldCodec<bool> ForBool(uint tag)
		{
			Func<CodedInputStream, bool> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__2_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__2_0 = new Func<CodedInputStream, bool>(FieldCodec.__c.__9.<ForBool>b__2_0));
			}
			Action<CodedOutputStream, bool> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__2_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__2_1 = new Action<CodedOutputStream, bool>(FieldCodec.__c.__9.<ForBool>b__2_1));
			}
			return new FieldCodec<bool>(arg_4B_0, arg_4B_1, new Func<bool, int>(CodedOutputStream.ComputeBoolSize), tag);
		}

		public static FieldCodec<int> ForInt32(uint tag)
		{
			Func<CodedInputStream, int> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__3_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__3_0 = new Func<CodedInputStream, int>(FieldCodec.__c.__9.<ForInt32>b__3_0));
			}
			Action<CodedOutputStream, int> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__3_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__3_1 = new Action<CodedOutputStream, int>(FieldCodec.__c.__9.<ForInt32>b__3_1));
			}
			return new FieldCodec<int>(arg_4B_0, arg_4B_1, new Func<int, int>(CodedOutputStream.ComputeInt32Size), tag);
		}

		public static FieldCodec<int> ForSInt32(uint tag)
		{
			Func<CodedInputStream, int> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__4_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__4_0 = new Func<CodedInputStream, int>(FieldCodec.__c.__9.<ForSInt32>b__4_0));
			}
			Action<CodedOutputStream, int> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__4_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__4_1 = new Action<CodedOutputStream, int>(FieldCodec.__c.__9.<ForSInt32>b__4_1));
			}
			return new FieldCodec<int>(arg_4B_0, arg_4B_1, new Func<int, int>(CodedOutputStream.ComputeSInt32Size), tag);
		}

		public static FieldCodec<uint> ForFixed32(uint tag)
		{
			Func<CodedInputStream, uint> arg_40_0;
			if ((arg_40_0 = FieldCodec.__c.__9__5_0) == null)
			{
				arg_40_0 = (FieldCodec.__c.__9__5_0 = new Func<CodedInputStream, uint>(FieldCodec.__c.__9.<ForFixed32>b__5_0));
			}
			Action<CodedOutputStream, uint> arg_40_1;
			if ((arg_40_1 = FieldCodec.__c.__9__5_1) == null)
			{
				arg_40_1 = (FieldCodec.__c.__9__5_1 = new Action<CodedOutputStream, uint>(FieldCodec.__c.__9.<ForFixed32>b__5_1));
			}
			return new FieldCodec<uint>(arg_40_0, arg_40_1, 4, tag);
		}

		public static FieldCodec<int> ForSFixed32(uint tag)
		{
			Func<CodedInputStream, int> arg_40_0;
			if ((arg_40_0 = FieldCodec.__c.__9__6_0) == null)
			{
				arg_40_0 = (FieldCodec.__c.__9__6_0 = new Func<CodedInputStream, int>(FieldCodec.__c.__9.<ForSFixed32>b__6_0));
			}
			Action<CodedOutputStream, int> arg_40_1;
			if ((arg_40_1 = FieldCodec.__c.__9__6_1) == null)
			{
				arg_40_1 = (FieldCodec.__c.__9__6_1 = new Action<CodedOutputStream, int>(FieldCodec.__c.__9.<ForSFixed32>b__6_1));
			}
			return new FieldCodec<int>(arg_40_0, arg_40_1, 4, tag);
		}

		public static FieldCodec<uint> ForUInt32(uint tag)
		{
			Func<CodedInputStream, uint> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__7_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__7_0 = new Func<CodedInputStream, uint>(FieldCodec.__c.__9.<ForUInt32>b__7_0));
			}
			Action<CodedOutputStream, uint> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__7_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__7_1 = new Action<CodedOutputStream, uint>(FieldCodec.__c.__9.<ForUInt32>b__7_1));
			}
			return new FieldCodec<uint>(arg_4B_0, arg_4B_1, new Func<uint, int>(CodedOutputStream.ComputeUInt32Size), tag);
		}

		public static FieldCodec<long> ForInt64(uint tag)
		{
			Func<CodedInputStream, long> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__8_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__8_0 = new Func<CodedInputStream, long>(FieldCodec.__c.__9.<ForInt64>b__8_0));
			}
			Action<CodedOutputStream, long> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__8_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__8_1 = new Action<CodedOutputStream, long>(FieldCodec.__c.__9.<ForInt64>b__8_1));
			}
			return new FieldCodec<long>(arg_4B_0, arg_4B_1, new Func<long, int>(CodedOutputStream.ComputeInt64Size), tag);
		}

		public static FieldCodec<long> ForSInt64(uint tag)
		{
			Func<CodedInputStream, long> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__9_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__9_0 = new Func<CodedInputStream, long>(FieldCodec.__c.__9.<ForSInt64>b__9_0));
			}
			Action<CodedOutputStream, long> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__9_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__9_1 = new Action<CodedOutputStream, long>(FieldCodec.__c.__9.<ForSInt64>b__9_1));
			}
			return new FieldCodec<long>(arg_4B_0, arg_4B_1, new Func<long, int>(CodedOutputStream.ComputeSInt64Size), tag);
		}

		public static FieldCodec<ulong> ForFixed64(uint tag)
		{
			Func<CodedInputStream, ulong> arg_40_0;
			if ((arg_40_0 = FieldCodec.__c.__9__10_0) == null)
			{
				arg_40_0 = (FieldCodec.__c.__9__10_0 = new Func<CodedInputStream, ulong>(FieldCodec.__c.__9.<ForFixed64>b__10_0));
			}
			Action<CodedOutputStream, ulong> arg_40_1;
			if ((arg_40_1 = FieldCodec.__c.__9__10_1) == null)
			{
				arg_40_1 = (FieldCodec.__c.__9__10_1 = new Action<CodedOutputStream, ulong>(FieldCodec.__c.__9.<ForFixed64>b__10_1));
			}
			return new FieldCodec<ulong>(arg_40_0, arg_40_1, 8, tag);
		}

		public static FieldCodec<long> ForSFixed64(uint tag)
		{
			Func<CodedInputStream, long> arg_40_0;
			if ((arg_40_0 = FieldCodec.__c.__9__11_0) == null)
			{
				arg_40_0 = (FieldCodec.__c.__9__11_0 = new Func<CodedInputStream, long>(FieldCodec.__c.__9.<ForSFixed64>b__11_0));
			}
			Action<CodedOutputStream, long> arg_40_1;
			if ((arg_40_1 = FieldCodec.__c.__9__11_1) == null)
			{
				arg_40_1 = (FieldCodec.__c.__9__11_1 = new Action<CodedOutputStream, long>(FieldCodec.__c.__9.<ForSFixed64>b__11_1));
			}
			return new FieldCodec<long>(arg_40_0, arg_40_1, 8, tag);
		}

		public static FieldCodec<ulong> ForUInt64(uint tag)
		{
			Func<CodedInputStream, ulong> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__12_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__12_0 = new Func<CodedInputStream, ulong>(FieldCodec.__c.__9.<ForUInt64>b__12_0));
			}
			Action<CodedOutputStream, ulong> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__12_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__12_1 = new Action<CodedOutputStream, ulong>(FieldCodec.__c.__9.<ForUInt64>b__12_1));
			}
			return new FieldCodec<ulong>(arg_4B_0, arg_4B_1, new Func<ulong, int>(CodedOutputStream.ComputeUInt64Size), tag);
		}

		public static FieldCodec<float> ForFloat(uint tag)
		{
			Func<CodedInputStream, float> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__13_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__13_0 = new Func<CodedInputStream, float>(FieldCodec.__c.__9.<ForFloat>b__13_0));
			}
			Action<CodedOutputStream, float> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__13_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__13_1 = new Action<CodedOutputStream, float>(FieldCodec.__c.__9.<ForFloat>b__13_1));
			}
			return new FieldCodec<float>(arg_4B_0, arg_4B_1, new Func<float, int>(CodedOutputStream.ComputeFloatSize), tag);
		}

		public static FieldCodec<double> ForDouble(uint tag)
		{
			Func<CodedInputStream, double> arg_4B_0;
			if ((arg_4B_0 = FieldCodec.__c.__9__14_0) == null)
			{
				arg_4B_0 = (FieldCodec.__c.__9__14_0 = new Func<CodedInputStream, double>(FieldCodec.__c.__9.<ForDouble>b__14_0));
			}
			Action<CodedOutputStream, double> arg_4B_1;
			if ((arg_4B_1 = FieldCodec.__c.__9__14_1) == null)
			{
				arg_4B_1 = (FieldCodec.__c.__9__14_1 = new Action<CodedOutputStream, double>(FieldCodec.__c.__9.<ForDouble>b__14_1));
			}
			return new FieldCodec<double>(arg_4B_0, arg_4B_1, new Func<double, int>(CodedOutputStream.ComputeDoubleSize), tag);
		}

		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32)
		{
			return new FieldCodec<T>((CodedInputStream input) => fromInt32(input.ReadEnum()), delegate(CodedOutputStream output, T value)
			{
				output.WriteEnum(toInt32(value));
			}, (T value) => CodedOutputStream.ComputeEnumSize(toInt32(value)), tag);
		}

		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser) where T : object, IMessage<T>
		{
			Func<CodedInputStream, T> arg_56_0 = delegate(CodedInputStream input)
			{
				T t = parser.CreateTemplate();
				input.ReadMessage(t);
				return t;
			};
			Action<CodedOutputStream, T> arg_56_1;
			if ((arg_56_1 = FieldCodec.__c__16<T>.__9__16_1) == null)
			{
				arg_56_1 = (FieldCodec.__c__16<T>.__9__16_1 = new Action<CodedOutputStream, T>(FieldCodec.__c__16<T>.__9.<ForMessage>b__16_1));
			}
			Func<T, int> arg_56_2;
			if ((arg_56_2 = FieldCodec.__c__16<T>.__9__16_2) == null)
			{
				arg_56_2 = (FieldCodec.__c__16<T>.__9__16_2 = new Func<T, int>(FieldCodec.__c__16<T>.__9.<ForMessage>b__16_2));
			}
			return new FieldCodec<T>(arg_56_0, arg_56_1, arg_56_2, tag);
		}

		public static FieldCodec<T> ForClassWrapper<T>(uint tag) where T : class
		{
			FieldCodec<T> nestedCodec;
			while (true)
			{
				IL_3D:
				uint arg_25_0 = 32061328u;
				while (true)
				{
					uint num;
					switch ((num = (arg_25_0 ^ 856689924u)) % 3u)
					{
					case 1u:
						nestedCodec = FieldCodec.WrapperCodecs.GetCodec<T>();
						arg_25_0 = (num * 65730384u ^ 3665532353u);
						continue;
					case 2u:
						goto IL_3D;
					}
					goto Block_1;
				}
			}
			Block_1:
			return new FieldCodec<T>((CodedInputStream input) => FieldCodec.WrapperCodecs.Read<T>(input, nestedCodec), delegate(CodedOutputStream output, T value)
			{
				FieldCodec.WrapperCodecs.Write<T>(output, value, nestedCodec);
			}, (T value) => FieldCodec.WrapperCodecs.CalculateSize<T>(value, nestedCodec), tag, default(T));
		}

		public static FieldCodec<T?> ForStructWrapper<T>(uint tag) where T : struct
		{
			FieldCodec<T> nestedCodec;
			while (true)
			{
				IL_3D:
				uint arg_25_0 = 294747616u;
				while (true)
				{
					uint num;
					switch ((num = (arg_25_0 ^ 212518295u)) % 3u)
					{
					case 0u:
						goto IL_3D;
					case 1u:
						nestedCodec = FieldCodec.WrapperCodecs.GetCodec<T>();
						arg_25_0 = (num * 2410490597u ^ 1481733282u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return new FieldCodec<T?>((CodedInputStream input) => new T?(FieldCodec.WrapperCodecs.Read<T>(input, nestedCodec)), delegate(CodedOutputStream output, T? value)
			{
				FieldCodec.WrapperCodecs.Write<T>(output, value.Value, nestedCodec);
			}, delegate(T? value)
			{
				if (value.HasValue)
				{
					return FieldCodec.WrapperCodecs.CalculateSize<T>(value.Value, nestedCodec);
				}
				return 0;
			}, tag, null);
		}
	}
	[ComVisible(true)]
	public sealed class FieldCodec<T>
	{
		private static readonly T DefaultDefault;

		private readonly Func<CodedInputStream, T> reader;

		private readonly Action<CodedOutputStream, T> writer;

		private readonly Func<T, int> sizeCalculator;

		private readonly uint tag;

		private readonly int tagSize;

		private readonly int fixedSize;

		private readonly T defaultValue;

		internal Func<T, int> ValueSizeCalculator
		{
			get
			{
				return this.sizeCalculator;
			}
		}

		internal Action<CodedOutputStream, T> ValueWriter
		{
			get
			{
				return this.writer;
			}
		}

		internal Func<CodedInputStream, T> ValueReader
		{
			get
			{
				return this.reader;
			}
		}

		internal int FixedSize
		{
			get
			{
				return this.fixedSize;
			}
		}

		public uint Tag
		{
			get
			{
				return this.tag;
			}
		}

		public T DefaultValue
		{
			get
			{
				return this.defaultValue;
			}
		}

		static FieldCodec()
		{
			if (FieldCodec<T>.smethod_0(typeof(T).TypeHandle) == FieldCodec<T>.smethod_0(typeof(string).TypeHandle))
			{
				goto IL_64;
			}
			goto IL_9E;
			uint arg_6E_0;
			while (true)
			{
				IL_69:
				uint num;
				switch ((num = (arg_6E_0 ^ 262867608u)) % 6u)
				{
				case 0u:
					goto IL_64;
				case 1u:
					FieldCodec<T>.DefaultDefault = (T)((object)"");
					arg_6E_0 = (num * 866381392u ^ 3422013123u);
					continue;
				case 3u:
					goto IL_9E;
				case 4u:
					FieldCodec<T>.DefaultDefault = (T)((object)ByteString.Empty);
					arg_6E_0 = (num * 860465387u ^ 3234019736u);
					continue;
				case 5u:
					return;
				}
				break;
			}
			return;
			IL_64:
			arg_6E_0 = 1886581677u;
			goto IL_69;
			IL_9E:
			arg_6E_0 = ((FieldCodec<T>.smethod_0(typeof(T).TypeHandle) != FieldCodec<T>.smethod_0(typeof(ByteString).TypeHandle)) ? 1229572486u : 1401307714u);
			goto IL_69;
		}

		private static Func<T, bool> CreateDefaultValueCheck<TTmp>(Func<TTmp, bool> check)
		{
			return (Func<T, bool>)check;
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag) : this(reader, writer, sizeCalculator, tag, FieldCodec<T>.DefaultDefault)
		{
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue)
		{
			this.reader = reader;
			this.writer = writer;
			this.sizeCalculator = sizeCalculator;
			this.fixedSize = 0;
			this.tag = tag;
			this.defaultValue = defaultValue;
			this.tagSize = CodedOutputStream.ComputeRawVarint32Size(tag);
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, int fixedSize, uint tag)
		{
			while (true)
			{
				IL_AF:
				uint arg_8B_0 = 3017510738u;
				while (true)
				{
					uint num;
					switch ((num = (arg_8B_0 ^ 2371091461u)) % 6u)
					{
					case 0u:
						this.fixedSize = fixedSize;
						this.tag = tag;
						arg_8B_0 = (num * 881978137u ^ 2738852917u);
						continue;
					case 1u:
						this.reader = reader;
						arg_8B_0 = (num * 1592895491u ^ 2147333601u);
						continue;
					case 2u:
						goto IL_AF;
					case 3u:
						this.sizeCalculator = ((T _) => fixedSize);
						arg_8B_0 = (num * 589634795u ^ 2685589926u);
						continue;
					case 5u:
						this.writer = writer;
						arg_8B_0 = (num * 2623320235u ^ 1911339515u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.tagSize = CodedOutputStream.ComputeRawVarint32Size(tag);
		}

		public void WriteTagAndValue(CodedOutputStream output, T value)
		{
			if (!this.IsDefault(value))
			{
				while (true)
				{
					IL_61:
					uint arg_45_0 = 936461950u;
					while (true)
					{
						uint num;
						switch ((num = (arg_45_0 ^ 454705023u)) % 4u)
						{
						case 0u:
							goto IL_61;
						case 1u:
							output.WriteTag(this.tag);
							arg_45_0 = (num * 2774526023u ^ 785160222u);
							continue;
						case 2u:
							this.writer(output, value);
							arg_45_0 = (num * 2200466085u ^ 4240235494u);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:;
			}
		}

		public T Read(CodedInputStream input)
		{
			return this.reader(input);
		}

		public int CalculateSizeWithTag(T value)
		{
			if (!this.IsDefault(value))
			{
				return this.sizeCalculator(value) + this.tagSize;
			}
			return 0;
		}

		private bool IsDefault(T value)
		{
			return EqualityComparer<T>.Default.Equals(value, this.defaultValue);
		}

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}
}
