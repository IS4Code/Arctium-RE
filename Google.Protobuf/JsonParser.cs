using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Google.Protobuf
{
	[ComVisible(true)]
	public sealed class JsonParser
	{
		public sealed class Settings
		{
			public static JsonParser.Settings Default
			{
				[CompilerGenerated]
				get
				{
					return JsonParser.Settings.<Default>k__BackingField;
				}
			}

			public int RecursionLimit
			{
				[CompilerGenerated]
				get
				{
					return this.<RecursionLimit>k__BackingField;
				}
			}

			public TypeRegistry TypeRegistry
			{
				[CompilerGenerated]
				get
				{
					return this.<TypeRegistry>k__BackingField;
				}
			}

			static Settings()
			{
				JsonParser.Settings.<Default>k__BackingField = new JsonParser.Settings(64);
			}

			public Settings(int recursionLimit) : this(recursionLimit, TypeRegistry.Empty)
			{
			}

			public Settings(int recursionLimit, TypeRegistry typeRegistry)
			{
				while (true)
				{
					IL_4F:
					uint arg_37_0 = 4016672047u;
					while (true)
					{
						uint num;
						switch ((num = (arg_37_0 ^ 2853316843u)) % 3u)
						{
						case 1u:
							this.<RecursionLimit>k__BackingField = recursionLimit;
							this.<TypeRegistry>k__BackingField = Preconditions.CheckNotNull<TypeRegistry>(typeRegistry, Module.smethod_34<string>(3473407542u));
							arg_37_0 = (num * 1137548354u ^ 3688102375u);
							continue;
						case 2u:
							goto IL_4F;
						}
						return;
					}
				}
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly JsonParser.__c __9 = new JsonParser.__c();

			internal void cctor>b__36_0(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
			{
				JsonParser.MergeTimestamp(message, tokenizer.Next());
			}

			internal void cctor>b__36_1(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
			{
				JsonParser.MergeDuration(message, tokenizer.Next());
			}

			internal void cctor>b__36_2(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
			{
				parser.MergeStructValue(message, tokenizer);
			}

			internal void cctor>b__36_3(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
			{
				parser.MergeRepeatedField(message, message.Descriptor.Fields[1], tokenizer);
			}

			internal void cctor>b__36_4(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
			{
				parser.MergeStruct(message, tokenizer);
			}

			internal void cctor>b__36_5(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
			{
				parser.MergeAny(message, tokenizer);
			}

			internal void cctor>b__36_6(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
			{
				JsonParser.MergeFieldMask(message, tokenizer.Next());
			}
		}

		private static readonly Regex TimestampRegex = JsonParser.smethod_28(Module.smethod_37<string>(2537404934u), FrameworkPortability.CompiledRegexWhereAvailable);

		private static readonly Regex DurationRegex;

		private static readonly int[] SubsecondScalingFactors;

		private static readonly char[] FieldMaskPathSeparators;

		private static readonly JsonParser defaultInstance;

		private static readonly Dictionary<string, Action<JsonParser, IMessage, JsonTokenizer>> WellKnownTypeHandlers;

		private readonly JsonParser.Settings settings;

		public static JsonParser Default
		{
			get
			{
				return JsonParser.defaultInstance;
			}
		}

		private static void MergeWrapperField(JsonParser parser, IMessage message, JsonTokenizer tokenizer)
		{
			parser.MergeField(message, message.Descriptor.Fields[1], tokenizer);
		}

		public JsonParser(JsonParser.Settings settings)
		{
			while (true)
			{
				IL_39:
				uint arg_21_0 = 4152800057u;
				while (true)
				{
					uint num;
					switch ((num = (arg_21_0 ^ 2701149360u)) % 3u)
					{
					case 0u:
						goto IL_39;
					case 1u:
						this.settings = settings;
						arg_21_0 = (num * 316918118u ^ 263345839u);
						continue;
					}
					return;
				}
			}
		}

		internal void Merge(IMessage message, string json)
		{
			this.Merge(message, JsonParser.smethod_0(json));
		}

		internal void Merge(IMessage message, TextReader jsonReader)
		{
			JsonTokenizer jsonTokenizer = JsonTokenizer.FromTextReader(jsonReader);
			this.Merge(message, jsonTokenizer);
			while (true)
			{
				IL_5E:
				uint arg_42_0 = 3270485863u;
				while (true)
				{
					uint num;
					switch ((num = (arg_42_0 ^ 3779853905u)) % 4u)
					{
					case 0u:
						goto IL_5E;
					case 2u:
						arg_42_0 = (((jsonTokenizer.Next() == JsonToken.EndDocument) ? 3559760258u : 4167807268u) ^ num * 449741833u);
						continue;
					case 3u:
						goto IL_65;
					}
					goto Block_2;
				}
			}
			Block_2:
			return;
			IL_65:
			throw new InvalidProtocolBufferException(Module.smethod_34<string>(3379670930u));
		}

		private void Merge(IMessage message, JsonTokenizer tokenizer)
		{
			if (tokenizer.ObjectDepth > this.settings.RecursionLimit)
			{
				goto IL_166;
			}
			goto IL_1D1;
			uint arg_170_0;
			JsonToken jsonToken;
			string stringValue;
			Action<JsonParser, IMessage, JsonTokenizer> action;
			while (true)
			{
				IL_16B:
				uint num;
				switch ((num = (arg_170_0 ^ 1078358184u)) % 17u)
				{
				case 0u:
					goto IL_166;
				case 1u:
					goto IL_1D1;
				case 2u:
					return;
				case 3u:
					jsonToken = tokenizer.Next();
					arg_170_0 = 585431802u;
					continue;
				case 4u:
					arg_170_0 = (((jsonToken.Type != JsonToken.TokenType.EndObject) ? 1936488639u : 1104038645u) ^ num * 1880809857u);
					continue;
				case 5u:
				{
					stringValue = jsonToken.StringValue;
					IDictionary<string, FieldDescriptor> dictionary;
					FieldDescriptor field;
					arg_170_0 = (dictionary.TryGetValue(stringValue, out field) ? 1712244973u : 410120627u);
					continue;
				}
				case 6u:
				{
					FieldDescriptor field;
					this.MergeField(message, field, tokenizer);
					arg_170_0 = (num * 3702916737u ^ 1750960619u);
					continue;
				}
				case 7u:
					goto IL_1E4;
				case 8u:
					arg_170_0 = (((!JsonParser.WellKnownTypeHandlers.TryGetValue(message.Descriptor.FullName, out action)) ? 454152534u : 1326785874u) ^ num * 2935428474u);
					continue;
				case 9u:
					jsonToken = tokenizer.Next();
					arg_170_0 = 1405425133u;
					continue;
				case 11u:
					goto IL_230;
				case 12u:
				{
					IDictionary<string, FieldDescriptor> dictionary = message.Descriptor.Fields.ByJsonName();
					arg_170_0 = 609874222u;
					continue;
				}
				case 13u:
					goto IL_200;
				case 14u:
					arg_170_0 = (((jsonToken.Type == JsonToken.TokenType.StartObject) ? 398803499u : 28852835u) ^ num * 1284069959u);
					continue;
				case 15u:
					goto IL_210;
				case 16u:
					arg_170_0 = ((jsonToken.Type == JsonToken.TokenType.Name) ? 1798285210u : 878968841u);
					continue;
				}
				break;
			}
			goto IL_1EA;
			IL_1E4:
			throw InvalidProtocolBufferException.JsonRecursionLimitExceeded();
			IL_1EA:
			throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_36<string>(369247576u), stringValue));
			IL_200:
			throw new InvalidProtocolBufferException(Module.smethod_35<string>(182362879u));
			IL_210:
			throw JsonParser.smethod_2(JsonParser.smethod_1(Module.smethod_34<string>(3754617378u), jsonToken.Type));
			IL_230:
			action(this, message, tokenizer);
			return;
			IL_166:
			arg_170_0 = 2061109089u;
			goto IL_16B;
			IL_1D1:
			arg_170_0 = ((!message.Descriptor.IsWellKnownType) ? 1578145520u : 33384807u);
			goto IL_16B;
		}

		private void MergeField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			while (true)
			{
				IL_FF:
				uint arg_C6_0 = 2728460861u;
				while (true)
				{
					uint num;
					switch ((num = (arg_C6_0 ^ 4088202538u)) % 11u)
					{
					case 0u:
						tokenizer.PushBack(jsonToken);
						arg_C6_0 = 3391872723u;
						continue;
					case 1u:
						field.Accessor.Clear(message);
						arg_C6_0 = (num * 3094303059u ^ 3964149977u);
						continue;
					case 2u:
						arg_C6_0 = (field.IsRepeated ? 4127807774u : 2761628867u);
						continue;
					case 3u:
						goto IL_106;
					case 4u:
						goto IL_FF;
					case 5u:
						this.MergeMapField(message, field, tokenizer);
						arg_C6_0 = (num * 2740112576u ^ 1415568343u);
						continue;
					case 6u:
						return;
					case 7u:
						arg_C6_0 = (((jsonToken.Type == JsonToken.TokenType.Null) ? 133441576u : 1327102556u) ^ num * 525105402u);
						continue;
					case 9u:
						return;
					case 10u:
						arg_C6_0 = (((!field.IsMap) ? 1515221911u : 88506733u) ^ num * 2127989669u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			goto IL_111;
			IL_106:
			this.MergeRepeatedField(message, field, tokenizer);
			return;
			IL_111:
			object value = this.ParseSingleValue(field, tokenizer);
			field.Accessor.SetValue(message, value);
		}

		private void MergeRepeatedField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.StartArray)
			{
				goto IL_59;
			}
			goto IL_89;
			int arg_63_0;
			IList ilist_;
			while (true)
			{
				IL_5E:
				switch ((arg_63_0 ^ -96800083) % 7)
				{
				case 0:
					break;
				case 1:
					goto IL_89;
				case 2:
					return;
				case 3:
					goto IL_59;
				case 4:
					goto IL_A2;
				case 5:
					goto IL_20;
				case 6:
					tokenizer.PushBack(jsonToken);
					arg_63_0 = -38945780;
					continue;
				default:
					goto IL_20;
				}
				IL_2F:
				jsonToken = tokenizer.Next();
				arg_63_0 = ((jsonToken.Type != JsonToken.TokenType.EndArray) ? -165915210 : -92736225);
				continue;
				IL_20:
				JsonParser.smethod_4(ilist_, this.ParseSingleValue(field, tokenizer));
				goto IL_2F;
			}
			IL_A2:
			throw new InvalidProtocolBufferException(JsonParser.smethod_1(Module.smethod_34<string>(2723514646u), jsonToken.Type));
			IL_59:
			arg_63_0 = -1374708303;
			goto IL_5E;
			IL_89:
			ilist_ = (IList)field.Accessor.GetValue(message);
			arg_63_0 = -1453703693;
			goto IL_5E;
		}

		private void MergeMapField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			while (true)
			{
				IL_185:
				uint arg_13C_0 = 1602437427u;
				while (true)
				{
					uint num;
					object object_;
					object object_2;
					IDictionary idictionary_;
					switch ((num = (arg_13C_0 ^ 1027221640u)) % 14u)
					{
					case 0u:
						return;
					case 1u:
						arg_13C_0 = (((jsonToken.Type != JsonToken.TokenType.EndObject) ? 3031360279u : 3293094157u) ^ num * 99189417u);
						continue;
					case 2u:
						goto IL_185;
					case 3u:
					{
						MessageDescriptor expr_F8 = field.MessageType;
						FieldDescriptor fieldDescriptor = expr_F8.FindFieldByNumber(1);
						FieldDescriptor fieldDescriptor2 = expr_F8.FindFieldByNumber(2);
						arg_13C_0 = 894103472u;
						continue;
					}
					case 4u:
					{
						FieldDescriptor fieldDescriptor2;
						arg_13C_0 = (((fieldDescriptor2 != null) ? 4064381129u : 2567681974u) ^ num * 2234778990u);
						continue;
					}
					case 5u:
						goto IL_18C;
					case 6u:
					{
						FieldDescriptor fieldDescriptor;
						arg_13C_0 = (((fieldDescriptor == null) ? 315775450u : 105751566u) ^ num * 513407619u);
						continue;
					}
					case 7u:
					{
						FieldDescriptor fieldDescriptor2;
						object_ = this.ParseSingleValue(fieldDescriptor2, tokenizer);
						arg_13C_0 = (num * 1341013222u ^ 143618253u);
						continue;
					}
					case 8u:
					{
						FieldDescriptor fieldDescriptor;
						object_2 = JsonParser.ParseMapKey(fieldDescriptor, jsonToken.StringValue);
						arg_13C_0 = 1112118343u;
						continue;
					}
					case 9u:
						goto IL_67;
					case 10u:
						goto IL_19C;
					case 11u:
						arg_13C_0 = (((jsonToken.Type != JsonToken.TokenType.StartObject) ? 805488328u : 1688901164u) ^ num * 3409497837u);
						continue;
					case 12u:
						break;
					case 13u:
						idictionary_ = (IDictionary)field.Accessor.GetValue(message);
						arg_13C_0 = 89503584u;
						continue;
					default:
						goto IL_67;
					}
					IL_28:
					jsonToken = tokenizer.Next();
					arg_13C_0 = 1923606965u;
					continue;
					IL_67:
					JsonParser.smethod_5(idictionary_, object_2, object_);
					goto IL_28;
				}
			}
			IL_18C:
			throw new InvalidProtocolBufferException(Module.smethod_33<string>(2975024404u));
			IL_19C:
			throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_34<string>(3285934318u), field.FullName));
		}

		private object ParseSingleValue(FieldDescriptor field, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			FieldType fieldType;
			while (true)
			{
				IL_241:
				uint arg_1DB_0 = 2895183132u;
				while (true)
				{
					uint num;
					switch ((num = (arg_1DB_0 ^ 4227999491u)) % 22u)
					{
					case 0u:
						fieldType = field.FieldType;
						arg_1DB_0 = (num * 3631647553u ^ 1627424644u);
						continue;
					case 1u:
						arg_1DB_0 = (((jsonToken.Type == JsonToken.TokenType.Null) ? 2562487117u : 3264765317u) ^ num * 2320226437u);
						continue;
					case 2u:
						arg_1DB_0 = ((field.MessageType.IsWrapperType ? 2451041983u : 3106705937u) ^ num * 2937492452u);
						continue;
					case 3u:
						goto IL_10E;
					case 4u:
						goto IL_241;
					case 5u:
						goto IL_248;
					case 6u:
						goto IL_257;
					case 7u:
						goto IL_2A8;
					case 8u:
						goto IL_2C5;
					case 9u:
						fieldType = field.FieldType;
						arg_1DB_0 = 3868419237u;
						continue;
					case 10u:
						goto IL_2B8;
					case 11u:
						arg_1DB_0 = (((field.FieldType != FieldType.Message) ? 3251097083u : 2733609498u) ^ num * 862346660u);
						continue;
					case 13u:
						goto IL_29B;
					case 14u:
					{
						JsonToken.TokenType type;
						switch (type)
						{
						case JsonToken.TokenType.Null:
							goto IL_2A8;
						case JsonToken.TokenType.False:
						case JsonToken.TokenType.True:
							goto IL_10E;
						case JsonToken.TokenType.StringValue:
							goto IL_2B8;
						case JsonToken.TokenType.Number:
							goto IL_2C5;
						default:
							arg_1DB_0 = (num * 3820120435u ^ 3713021620u);
							continue;
						}
						break;
					}
					case 15u:
						arg_1DB_0 = (((!JsonParser.smethod_6(field.MessageType.FullName, Value.Descriptor.FullName)) ? 3539103804u : 3514659843u) ^ num * 2554588575u);
						continue;
					case 16u:
						field = field.MessageType.Fields[1];
						arg_1DB_0 = (num * 2112469621u ^ 1822803999u);
						continue;
					case 17u:
					{
						IMessage message;
						return message;
					}
					case 18u:
					{
						tokenizer.PushBack(jsonToken);
						IMessage message = JsonParser.NewMessageForField(field);
						this.Merge(message, tokenizer);
						arg_1DB_0 = 3973606158u;
						continue;
					}
					case 19u:
					{
						JsonToken.TokenType type = jsonToken.Type;
						arg_1DB_0 = 3591463145u;
						continue;
					}
					case 20u:
						arg_1DB_0 = (((fieldType != FieldType.Message) ? 2518168550u : 2364668323u) ^ num * 353123967u);
						continue;
					case 21u:
						arg_1DB_0 = (num * 2401492949u ^ 959663284u);
						continue;
					}
					goto Block_8;
					IL_10E:
					arg_1DB_0 = ((fieldType != FieldType.Bool) ? 3264650281u : 2606235060u);
				}
			}
			Block_8:
			goto IL_259;
			IL_248:
			return jsonToken.Type == JsonToken.TokenType.True;
			IL_257:
			return null;
			IL_259:
			throw new InvalidProtocolBufferException(JsonParser.smethod_8(new object[]
			{
				Module.smethod_35<string>(1595405755u),
				jsonToken.Type,
				Module.smethod_33<string>(3358579280u),
				fieldType
			}));
			IL_29B:
			return new Value
			{
				NullValue = NullValue.NULL_VALUE
			};
			IL_2A8:
			throw JsonParser.smethod_7(Module.smethod_36<string>(2253431815u));
			IL_2B8:
			return JsonParser.ParseSingleStringValue(field, jsonToken.StringValue);
			IL_2C5:
			return JsonParser.ParseSingleNumberValue(field, jsonToken);
		}

		public T Parse<T>(string json) where T : IMessage, new()
		{
			Preconditions.CheckNotNull<string>(json, Module.smethod_37<string>(1047885616u));
			return this.Parse<T>(JsonParser.smethod_0(json));
		}

		public T Parse<T>(TextReader jsonReader) where T : IMessage, new()
		{
			Preconditions.CheckNotNull<TextReader>(jsonReader, Module.smethod_34<string>(1438865445u));
			T t;
			while (true)
			{
				IL_63:
				uint arg_47_0 = 909048356u;
				while (true)
				{
					uint num;
					switch ((num = (arg_47_0 ^ 38086297u)) % 4u)
					{
					case 0u:
						goto IL_63;
					case 1u:
						t = Activator.CreateInstance<T>();
						arg_47_0 = (num * 2254866517u ^ 4036767062u);
						continue;
					case 2u:
						this.Merge(t, jsonReader);
						arg_47_0 = (num * 3930331853u ^ 2440088268u);
						continue;
					}
					return t;
				}
			}
			return t;
		}

		public IMessage Parse(string json, MessageDescriptor descriptor)
		{
			Preconditions.CheckNotNull<string>(json, Module.smethod_36<string>(1642750916u));
			Preconditions.CheckNotNull<MessageDescriptor>(descriptor, Module.smethod_37<string>(3239194258u));
			return this.Parse(JsonParser.smethod_0(json), descriptor);
		}

		public IMessage Parse(TextReader jsonReader, MessageDescriptor descriptor)
		{
			Preconditions.CheckNotNull<TextReader>(jsonReader, Module.smethod_36<string>(1301239194u));
			Preconditions.CheckNotNull<MessageDescriptor>(descriptor, Module.smethod_35<string>(3931769886u));
			IMessage message = descriptor.Parser.CreateTemplate();
			this.Merge(message, jsonReader);
			return message;
		}

		private void MergeStructValue(IMessage message, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			MessageDescriptor.FieldCollection fields;
			while (true)
			{
				IL_D9:
				uint arg_9B_0 = 1098154793u;
				while (true)
				{
					uint num;
					switch ((num = (arg_9B_0 ^ 1051869849u)) % 12u)
					{
					case 0u:
						goto IL_D9;
					case 1u:
						goto IL_E1;
					case 2u:
						goto IL_140;
					case 4u:
						fields = message.Descriptor.Fields;
						arg_9B_0 = (num * 4176649528u ^ 1545379649u);
						continue;
					case 5u:
						goto IL_102;
					case 6u:
						arg_9B_0 = (num * 2566969128u ^ 102451614u);
						continue;
					case 7u:
						return;
					case 8u:
						switch (jsonToken.Type)
						{
						case JsonToken.TokenType.Null:
							goto IL_16D;
						case JsonToken.TokenType.False:
						case JsonToken.TokenType.True:
							goto IL_E1;
						case JsonToken.TokenType.StringValue:
							goto IL_0C;
						case JsonToken.TokenType.Number:
							goto IL_102;
						case JsonToken.TokenType.Name:
						case JsonToken.TokenType.EndObject:
							break;
						case JsonToken.TokenType.StartObject:
							goto IL_186;
						case JsonToken.TokenType.StartArray:
							goto IL_140;
						default:
							arg_9B_0 = (num * 673296015u ^ 1606414163u);
							continue;
						}
						break;
					case 9u:
						goto IL_16D;
					case 10u:
						goto IL_0C;
					case 11u:
						goto IL_186;
					}
					goto Block_2;
					IL_0C:
					fields[3].Accessor.SetValue(message, jsonToken.StringValue);
					arg_9B_0 = 587775730u;
				}
			}
			Block_2:
			goto IL_120;
			IL_E1:
			fields[4].Accessor.SetValue(message, jsonToken.Type == JsonToken.TokenType.True);
			return;
			IL_102:
			fields[2].Accessor.SetValue(message, jsonToken.NumberValue);
			return;
			IL_120:
			throw JsonParser.smethod_2(JsonParser.smethod_1(Module.smethod_36<string>(246668818u), jsonToken.Type));
			IL_140:
			FieldDescriptor expr_147 = fields[6];
			IMessage message2 = JsonParser.NewMessageForField(expr_147);
			tokenizer.PushBack(jsonToken);
			this.Merge(message2, tokenizer);
			expr_147.Accessor.SetValue(message, message2);
			return;
			IL_16D:
			fields[1].Accessor.SetValue(message, 0);
			return;
			IL_186:
			FieldDescriptor expr_18D = fields[5];
			IMessage message3 = JsonParser.NewMessageForField(expr_18D);
			tokenizer.PushBack(jsonToken);
			this.Merge(message3, tokenizer);
			expr_18D.Accessor.SetValue(message, message3);
		}

		private void MergeStruct(IMessage message, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			if (jsonToken.Type != JsonToken.TokenType.StartObject)
			{
				goto IL_4B;
			}
			goto IL_79;
			uint arg_55_0;
			while (true)
			{
				IL_50:
				uint num;
				switch ((num = (arg_55_0 ^ 1653967734u)) % 6u)
				{
				case 0u:
					goto IL_4B;
				case 1u:
					goto IL_79;
				case 2u:
				{
					FieldDescriptor field = message.Descriptor.Fields[1];
					arg_55_0 = (num * 3438667733u ^ 1101684043u);
					continue;
				}
				case 3u:
				{
					FieldDescriptor field;
					this.MergeMapField(message, field, tokenizer);
					arg_55_0 = (num * 2991607230u ^ 1358340007u);
					continue;
				}
				case 4u:
					goto IL_87;
				}
				break;
			}
			return;
			IL_87:
			throw new InvalidProtocolBufferException(Module.smethod_34<string>(2435928094u));
			IL_4B:
			arg_55_0 = 1454851390u;
			goto IL_50;
			IL_79:
			tokenizer.PushBack(jsonToken);
			arg_55_0 = 1487544692u;
			goto IL_50;
		}

		private void MergeAny(IMessage message, JsonTokenizer tokenizer)
		{
			List<JsonToken> list = new List<JsonToken>();
			string typeName;
			while (true)
			{
				IL_32C:
				uint arg_2BA_0 = 1448548076u;
				while (true)
				{
					uint num;
					switch ((num = (arg_2BA_0 ^ 1478598455u)) % 25u)
					{
					case 0u:
					{
						JsonToken jsonToken;
						arg_2BA_0 = (((jsonToken.Type != JsonToken.TokenType.StartObject) ? 169911250u : 542751207u) ^ num * 3565547574u);
						continue;
					}
					case 1u:
					{
						MessageDescriptor messageDescriptor;
						IMessage message2 = messageDescriptor.Parser.CreateTemplate();
						arg_2BA_0 = ((messageDescriptor.IsWellKnownType ? 905236089u : 1797763964u) ^ num * 4225873014u);
						continue;
					}
					case 2u:
						goto IL_333;
					case 3u:
					{
						IMessage message2;
						ByteString value = message2.ToByteString();
						arg_2BA_0 = 1007236507u;
						continue;
					}
					case 4u:
					{
						JsonTokenizer tokenizer2 = JsonTokenizer.FromReplayedTokens(list, tokenizer);
						arg_2BA_0 = 1740447578u;
						continue;
					}
					case 5u:
					{
						MessageDescriptor messageDescriptor;
						arg_2BA_0 = (((messageDescriptor == null) ? 1978605643u : 474750921u) ^ num * 3448549742u);
						continue;
					}
					case 6u:
					{
						JsonToken jsonToken;
						list.Add(jsonToken);
						jsonToken = tokenizer.Next();
						arg_2BA_0 = 486044040u;
						continue;
					}
					case 7u:
					{
						string stringValue;
						message.Descriptor.Fields[1].Accessor.SetValue(message, stringValue);
						ByteString value;
						message.Descriptor.Fields[2].Accessor.SetValue(message, value);
						arg_2BA_0 = (num * 2479283979u ^ 2103243500u);
						continue;
					}
					case 8u:
					{
						JsonToken jsonToken = tokenizer.Next();
						arg_2BA_0 = (num * 3946219542u ^ 3697851440u);
						continue;
					}
					case 9u:
						goto IL_343;
					case 10u:
					{
						JsonToken jsonToken;
						string stringValue = jsonToken.StringValue;
						arg_2BA_0 = 49789875u;
						continue;
					}
					case 11u:
						goto IL_353;
					case 12u:
					{
						int objectDepth;
						arg_2BA_0 = (((tokenizer.ObjectDepth == objectDepth) ? 4018706426u : 2723087548u) ^ num * 489652238u);
						continue;
					}
					case 13u:
					{
						JsonToken jsonToken = tokenizer.Next();
						arg_2BA_0 = (num * 2684042365u ^ 1351852711u);
						continue;
					}
					case 14u:
					{
						JsonToken jsonToken;
						arg_2BA_0 = (((jsonToken.Type != JsonToken.TokenType.StringValue) ? 3656972936u : 2253876696u) ^ num * 1993675286u);
						continue;
					}
					case 15u:
					{
						MessageDescriptor messageDescriptor = this.settings.TypeRegistry.Find(typeName);
						arg_2BA_0 = (num * 166593685u ^ 1985437103u);
						continue;
					}
					case 16u:
					{
						JsonToken jsonToken;
						arg_2BA_0 = ((JsonParser.smethod_9(jsonToken.StringValue, Module.smethod_36<string>(2843911711u)) ? 2869146979u : 3771489917u) ^ num * 1931197875u);
						continue;
					}
					case 17u:
					{
						string stringValue;
						typeName = JsonFormatter.GetTypeName(stringValue);
						arg_2BA_0 = (num * 4240734580u ^ 1519801139u);
						continue;
					}
					case 19u:
					{
						JsonToken jsonToken;
						arg_2BA_0 = ((jsonToken.Type == JsonToken.TokenType.Name) ? 656477912u : 1364969598u);
						continue;
					}
					case 20u:
					{
						IMessage message2;
						JsonTokenizer tokenizer2;
						this.Merge(message2, tokenizer2);
						arg_2BA_0 = 1399484075u;
						continue;
					}
					case 21u:
						arg_2BA_0 = (num * 3779688449u ^ 2144537681u);
						continue;
					case 22u:
						goto IL_32C;
					case 23u:
					{
						IMessage message2;
						JsonTokenizer tokenizer2;
						this.MergeWellKnownTypeAnyBody(message2, tokenizer2);
						arg_2BA_0 = (num * 2237969446u ^ 2282714989u);
						continue;
					}
					case 24u:
					{
						int objectDepth = tokenizer.ObjectDepth;
						arg_2BA_0 = 486044040u;
						continue;
					}
					}
					goto Block_8;
				}
			}
			Block_8:
			return;
			IL_333:
			throw new InvalidProtocolBufferException(Module.smethod_36<string>(2978762594u));
			IL_343:
			throw new InvalidProtocolBufferException(Module.smethod_37<string>(3881420535u));
			IL_353:
			throw JsonParser.smethod_2(JsonParser.smethod_10(Module.smethod_37<string>(1193978753u), new object[]
			{
				typeName
			}));
		}

		private void MergeWellKnownTypeAnyBody(IMessage body, JsonTokenizer tokenizer)
		{
			JsonToken jsonToken = tokenizer.Next();
			while (true)
			{
				IL_FB:
				uint arg_CA_0 = 1243585352u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CA_0 ^ 30401385u)) % 9u)
					{
					case 1u:
						jsonToken = tokenizer.Next();
						arg_CA_0 = (((jsonToken.Type == JsonToken.TokenType.Name) ? 597710735u : 1911170991u) ^ num * 2497769275u);
						continue;
					case 2u:
						goto IL_102;
					case 3u:
						this.Merge(body, tokenizer);
						arg_CA_0 = 1416378815u;
						continue;
					case 4u:
						arg_CA_0 = ((JsonParser.smethod_9(jsonToken.StringValue, Module.smethod_35<string>(4287036u)) ? 3490082770u : 4036978239u) ^ num * 1544479070u);
						continue;
					case 5u:
						goto IL_FB;
					case 6u:
						arg_CA_0 = (((jsonToken.Type == JsonToken.TokenType.EndObject) ? 3805322814u : 3204445242u) ^ num * 4181565098u);
						continue;
					case 7u:
						goto IL_12A;
					case 8u:
						jsonToken = tokenizer.Next();
						arg_CA_0 = (num * 1292893797u ^ 4007342446u);
						continue;
					}
					goto Block_4;
				}
			}
			Block_4:
			return;
			IL_102:
			throw new InvalidProtocolBufferException(JsonParser.smethod_10(Module.smethod_36<string>(4075640305u), new object[]
			{
				Module.smethod_33<string>(58016685u)
			}));
			IL_12A:
			throw new InvalidProtocolBufferException(Module.smethod_33<string>(2955856016u));
		}

		private static object ParseMapKey(FieldDescriptor field, string keyText)
		{
			FieldType fieldType = field.FieldType;
			while (true)
			{
				IL_10F:
				uint arg_CA_0 = 2807994242u;
				while (true)
				{
					uint num;
					switch ((num = (arg_CA_0 ^ 2360211423u)) % 14u)
					{
					case 0u:
						goto IL_156;
					case 1u:
						goto IL_13D;
					case 2u:
						goto IL_116;
					case 3u:
						goto IL_124;
					case 4u:
						goto IL_11D;
					case 5u:
						switch (fieldType)
						{
						case FieldType.Int64:
						case FieldType.SFixed64:
						case FieldType.SInt64:
							goto IL_156;
						case FieldType.UInt64:
						case FieldType.Fixed64:
							goto IL_124;
						case FieldType.Int32:
						case FieldType.SFixed32:
						case FieldType.SInt32:
							goto IL_13D;
						case FieldType.Fixed32:
						case FieldType.UInt32:
							goto IL_16F;
						case FieldType.Bool:
							goto IL_0C;
						case FieldType.String:
							return keyText;
						case FieldType.Group:
						case FieldType.Message:
						case FieldType.Bytes:
							break;
						default:
							arg_CA_0 = (num * 1011171654u ^ 884623786u);
							continue;
						}
						break;
					case 6u:
						arg_CA_0 = ((!JsonParser.smethod_6(keyText, Module.smethod_37<string>(54440496u))) ? 4231775696u : 2941729777u);
						continue;
					case 7u:
						goto IL_16F;
					case 8u:
						return keyText;
					case 9u:
						arg_CA_0 = (num * 1214129262u ^ 510516631u);
						continue;
					case 11u:
						goto IL_1A8;
					case 12u:
						goto IL_0C;
					case 13u:
						goto IL_10F;
					}
					goto Block_4;
					IL_0C:
					arg_CA_0 = ((!JsonParser.smethod_6(keyText, Module.smethod_33<string>(2183097496u))) ? 2402669603u : 3430961391u);
				}
			}
			Block_4:
			goto IL_188;
			IL_116:
			return true;
			IL_11D:
			return false;
			IL_124:
			return JsonParser.ParseNumericString<ulong>(keyText, new Func<string, NumberStyles, IFormatProvider, ulong>(ulong.Parse), false);
			IL_13D:
			return JsonParser.ParseNumericString<int>(keyText, new Func<string, NumberStyles, IFormatProvider, int>(int.Parse), false);
			IL_156:
			return JsonParser.ParseNumericString<long>(keyText, new Func<string, NumberStyles, IFormatProvider, long>(long.Parse), false);
			IL_16F:
			return JsonParser.ParseNumericString<uint>(keyText, new Func<string, NumberStyles, IFormatProvider, uint>(uint.Parse), false);
			IL_188:
			throw new InvalidProtocolBufferException(JsonParser.smethod_1(Module.smethod_34<string>(4040197009u), field.FieldType));
			IL_1A8:
			throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_36<string>(3227730768u), keyText));
		}

		private static object ParseSingleNumberValue(FieldDescriptor field, JsonToken token)
		{
			double numberValue = token.NumberValue;
			object result;
			try
			{
				FieldType fieldType = field.FieldType;
				while (true)
				{
					IL_236:
					uint arg_1C5_0 = 2714162256u;
					while (true)
					{
						uint num;
						switch ((num = (arg_1C5_0 ^ 3081497452u)) % 25u)
						{
						case 0u:
							goto IL_236;
						case 1u:
							arg_1C5_0 = (((numberValue >= -3.4028234663852886E+38) ? 108139018u : 1580937062u) ^ num * 1792843395u);
							continue;
						case 2u:
							goto IL_23D;
						case 3u:
							result = (float)numberValue;
							arg_1C5_0 = 3841389836u;
							continue;
						case 4u:
							arg_1C5_0 = (num * 4155140879u ^ 3914873338u);
							continue;
						case 5u:
							goto IL_23F;
						case 6u:
							arg_1C5_0 = ((!double.IsNegativeInfinity(numberValue)) ? 2860638638u : 3287639585u);
							continue;
						case 7u:
							goto IL_286;
						case 8u:
							goto IL_27C;
						case 9u:
							goto IL_10E;
						case 10u:
							result = float.NaN;
							arg_1C5_0 = (num * 519730457u ^ 2192162278u);
							continue;
						case 12u:
							goto IL_25A;
						case 13u:
							result = float.NegativeInfinity;
							arg_1C5_0 = (num * 2072606338u ^ 2537405877u);
							continue;
						case 14u:
							switch (fieldType)
							{
							case FieldType.Double:
								goto IL_10E;
							case FieldType.Float:
								goto IL_66;
							case FieldType.Int64:
							case FieldType.SFixed64:
							case FieldType.SInt64:
								goto IL_286;
							case FieldType.UInt64:
							case FieldType.Fixed64:
								goto IL_292;
							case FieldType.Int32:
							case FieldType.SFixed32:
							case FieldType.SInt32:
								goto IL_27C;
							case FieldType.Fixed32:
							case FieldType.UInt32:
								goto IL_13;
							case FieldType.Bool:
							case FieldType.String:
							case FieldType.Group:
							case FieldType.Message:
							case FieldType.Bytes:
								break;
							default:
								arg_1C5_0 = (num * 6725480u ^ 3431166399u);
								continue;
							}
							break;
						case 15u:
							goto IL_290;
						case 16u:
							arg_1C5_0 = ((numberValue > 3.4028234663852886E+38) ? 2615766076u : 4080106354u);
							continue;
						case 17u:
							goto IL_66;
						case 18u:
							result = float.PositiveInfinity;
							arg_1C5_0 = (num * 2932461535u ^ 2132088557u);
							continue;
						case 19u:
							goto IL_292;
						case 20u:
							arg_1C5_0 = (double.IsPositiveInfinity(numberValue) ? 2962263815u : 2997685618u);
							continue;
						case 21u:
							goto IL_29C;
						case 22u:
							goto IL_29E;
						case 23u:
							goto IL_2A0;
						case 24u:
							goto IL_13;
						}
						goto Block_9;
						IL_13:
						result = checked((uint)numberValue);
						arg_1C5_0 = 3298924930u;
						continue;
						IL_66:
						arg_1C5_0 = ((!double.IsNaN(numberValue)) ? 2700260390u : 2475679739u);
						continue;
						IL_10E:
						result = numberValue;
						arg_1C5_0 = 4188884243u;
					}
				}
				Block_9:
				goto IL_25C;
				IL_23D:
				return result;
				IL_23F:
				throw new InvalidProtocolBufferException(JsonParser.smethod_1(Module.smethod_33<string>(827338283u), numberValue));
				IL_25A:
				return result;
				IL_25C:
				throw new InvalidProtocolBufferException(JsonParser.smethod_1(Module.smethod_37<string>(3764563708u), field.FieldType));
				IL_27C:
				checked
				{
					result = (int)numberValue;
					return result;
					IL_286:
					result = (long)numberValue;
					IL_290:
					return result;
					IL_292:
					result = (ulong)numberValue;
					IL_29C:
					IL_29E:
					IL_2A0:;
				}
			}
			catch (OverflowException)
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_1(Module.smethod_33<string>(827338283u), numberValue));
			}
			return result;
		}

		private static object ParseSingleStringValue(FieldDescriptor field, string text)
		{
			FieldType fieldType = field.FieldType;
			while (true)
			{
				IL_BF:
				uint arg_7B_0 = 2669369356u;
				while (true)
				{
					uint num;
					switch ((num = (arg_7B_0 ^ 3757300285u)) % 13u)
					{
					case 0u:
						goto IL_C6;
					case 1u:
						goto IL_10F;
					case 2u:
						goto IL_116;
					case 3u:
						switch (fieldType)
						{
						case FieldType.Double:
							goto IL_C6;
						case FieldType.Float:
							goto IL_1E1;
						case FieldType.Int64:
						case FieldType.SFixed64:
						case FieldType.SInt64:
							goto IL_1AF;
						case FieldType.UInt64:
						case FieldType.Fixed64:
							goto IL_131;
						case FieldType.Int32:
						case FieldType.SFixed32:
						case FieldType.SInt32:
							goto IL_116;
						case FieldType.Fixed32:
						case FieldType.UInt32:
							goto IL_1C8;
						case FieldType.Bool:
						case FieldType.Group:
						case FieldType.Message:
							break;
						case FieldType.String:
							return text;
						case FieldType.Bytes:
							goto IL_10F;
						case FieldType.Enum:
							goto IL_14A;
						default:
							arg_7B_0 = (num * 1146191775u ^ 1244459093u);
							continue;
						}
						break;
					case 4u:
						return text;
					case 5u:
						goto IL_131;
					case 6u:
						goto IL_14A;
					case 8u:
						goto IL_1AF;
					case 9u:
						goto IL_1C8;
					case 10u:
						goto IL_1E1;
					case 11u:
						goto IL_BF;
					case 12u:
						arg_7B_0 = (num * 2436245771u ^ 1680811102u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			goto IL_18F;
			IL_C6:
			double expr_D9 = JsonParser.ParseNumericString<double>(text, new Func<string, NumberStyles, IFormatProvider, double>(double.Parse), true);
			if (double.IsInfinity(expr_D9) && !JsonParser.smethod_11(text, Module.smethod_35<string>(2182845045u)))
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_37<string>(1631698215u), text));
			}
			return expr_D9;
			IL_10F:
			return ByteString.FromBase64(text);
			IL_116:
			return JsonParser.ParseNumericString<int>(text, new Func<string, NumberStyles, IFormatProvider, int>(int.Parse), false);
			IL_131:
			return JsonParser.ParseNumericString<ulong>(text, new Func<string, NumberStyles, IFormatProvider, ulong>(ulong.Parse), false);
			IL_14A:
			EnumValueDescriptor expr_156 = field.EnumType.FindValueByName(text);
			if (expr_156 == null)
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_12(Module.smethod_35<string>(449296466u), text, Module.smethod_33<string>(2731997989u), field.EnumType.FullName));
			}
			return expr_156.Number;
			IL_18F:
			throw new InvalidProtocolBufferException(JsonParser.smethod_1(Module.smethod_35<string>(2533819953u), field.FieldType));
			IL_1AF:
			return JsonParser.ParseNumericString<long>(text, new Func<string, NumberStyles, IFormatProvider, long>(long.Parse), false);
			IL_1C8:
			return JsonParser.ParseNumericString<uint>(text, new Func<string, NumberStyles, IFormatProvider, uint>(uint.Parse), false);
			IL_1E1:
			float expr_1F4 = JsonParser.ParseNumericString<float>(text, new Func<string, NumberStyles, IFormatProvider, float>(float.Parse), true);
			if (float.IsInfinity(expr_1F4) && !JsonParser.smethod_11(text, Module.smethod_35<string>(2182845045u)))
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_36<string>(712664627u), text));
			}
			return expr_1F4;
		}

		private static IMessage NewMessageForField(FieldDescriptor field)
		{
			return field.MessageType.Parser.CreateTemplate();
		}

		private static T ParseNumericString<T>(string text, Func<string, NumberStyles, IFormatProvider, T> parser, bool floatingPoint)
		{
			if (JsonParser.smethod_13(text, Module.smethod_37<string>(3618441100u)))
			{
				goto IL_55;
			}
			goto IL_1BC;
			uint arg_16C_0;
			while (true)
			{
				IL_167:
				uint num;
				switch ((num = (arg_16C_0 ^ 4177359718u)) % 13u)
				{
				case 0u:
					arg_16C_0 = (((JsonParser.smethod_14(text) > 1) ? 2463668687u : 3598180064u) ^ num * 2568927712u);
					continue;
				case 1u:
					goto IL_1D3;
				case 2u:
					arg_16C_0 = (((JsonParser.smethod_14(text) > 2) ? 3907063306u : 3060195777u) ^ num * 2050404848u);
					continue;
				case 3u:
					arg_16C_0 = (((JsonParser.smethod_15(text, 2) > '9') ? 3640000129u : 2883664693u) ^ num * 3792810758u);
					continue;
				case 4u:
					arg_16C_0 = (((JsonParser.smethod_15(text, 1) > '9') ? 2116282117u : 1825164171u) ^ num * 1872945357u);
					continue;
				case 5u:
					goto IL_1E9;
				case 6u:
					arg_16C_0 = (((JsonParser.smethod_15(text, 1) >= '0') ? 2146772721u : 1482794594u) ^ num * 540114235u);
					continue;
				case 7u:
					goto IL_1BC;
				case 8u:
					arg_16C_0 = (((JsonParser.smethod_15(text, 2) < '0') ? 2547763313u : 3381176574u) ^ num * 1355254552u);
					continue;
				case 9u:
					goto IL_1FF;
				case 10u:
					goto IL_55;
				case 12u:
					arg_16C_0 = (JsonParser.smethod_13(text, Module.smethod_35<string>(547297454u)) ? 2931114137u : 4211666897u);
					continue;
				}
				break;
			}
			goto IL_215;
			IL_1D3:
			throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_35<string>(1498538043u), text));
			IL_1E9:
			throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_37<string>(1631698215u), text));
			IL_1FF:
			throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_36<string>(712664627u), text));
			IL_215:
			T result;
			try
			{
				NumberStyles arg_243_0;
				if (floatingPoint)
				{
					arg_243_0 = (NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent);
					goto IL_243;
				}
				IL_220:
				int arg_22A_0 = -14019326;
				IL_225:
				switch ((arg_22A_0 ^ -117607578) % 3)
				{
				case 1:
					arg_243_0 = NumberStyles.AllowLeadingSign;
					goto IL_243;
				case 2:
					goto IL_220;
				}
				NumberStyles arg;
				result = parser(text, arg, JsonParser.smethod_16());
				return result;
				IL_243:
				arg = arg_243_0;
				arg_22A_0 = -1612766286;
				goto IL_225;
			}
			catch (FormatException)
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_37<string>(2332868648u), text));
			}
			catch (OverflowException)
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_33<string>(827338283u), text));
			}
			return result;
			IL_55:
			arg_16C_0 = 3791357276u;
			goto IL_167;
			IL_1BC:
			arg_16C_0 = ((!JsonParser.smethod_13(text, Module.smethod_33<string>(2258260179u))) ? 4151560608u : 3475140416u);
			goto IL_167;
		}

		private static void MergeTimestamp(IMessage message, JsonToken token)
		{
			if (token.Type != JsonToken.TokenType.StringValue)
			{
				throw new InvalidProtocolBufferException(Module.smethod_34<string>(4106270254u));
			}
			Match expr_30 = JsonParser.smethod_17(JsonParser.TimestampRegex, token.StringValue);
			if (!JsonParser.smethod_18(expr_30))
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_35<string>(687177443u), token.StringValue));
			}
			string s = JsonParser.smethod_21(JsonParser.smethod_20(JsonParser.smethod_19(expr_30), Module.smethod_37<string>(3034098023u)));
			string string_ = JsonParser.smethod_21(JsonParser.smethod_20(JsonParser.smethod_19(expr_30), Module.smethod_33<string>(3434946563u)));
			string string_2 = JsonParser.smethod_21(JsonParser.smethod_20(JsonParser.smethod_19(expr_30), Module.smethod_33<string>(1037578013u)));
			try
			{
				Timestamp timestamp = Timestamp.FromDateTime(DateTime.ParseExact(s, Module.smethod_34<string>(2071728157u), JsonParser.smethod_16(), DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal));
				while (true)
				{
					IL_3E0:
					uint arg_37A_0 = 3482553023u;
					while (true)
					{
						uint num;
						int arg_2B6_0;
						int num3;
						int num4;
						switch ((num = (arg_37A_0 ^ 2253564775u)) % 22u)
						{
						case 0u:
							goto IL_3E7;
						case 1u:
						{
							int num2;
							num2++;
							arg_37A_0 = (num * 2420059356u ^ 3584083717u);
							continue;
						}
						case 2u:
							if (JsonParser.smethod_15(string_2, 0) != '-')
							{
								arg_37A_0 = (num * 1484961684u ^ 1375498980u);
								continue;
							}
							arg_2B6_0 = 1;
							goto IL_2B6;
						case 3u:
						{
							int num2 = num3 * num4 * 60;
							arg_37A_0 = 3213147769u;
							continue;
						}
						case 5u:
						{
							int num5;
							arg_37A_0 = (((num5 <= 0) ? 2488158781u : 3845899968u) ^ num * 1776378968u);
							continue;
						}
						case 6u:
						{
							int num2;
							arg_37A_0 = ((num2 != 0) ? 2353943368u : 3121454488u);
							continue;
						}
						case 7u:
							arg_2B6_0 = -1;
							goto IL_2B6;
						case 8u:
						{
							int num5 = 0;
							arg_37A_0 = ((JsonParser.smethod_9(string_, "") ? 4119342013u : 2537885837u) ^ num * 1509081769u);
							continue;
						}
						case 9u:
							goto IL_3E0;
						case 10u:
							goto IL_402;
						case 11u:
							arg_37A_0 = (((num4 <= 1080) ? 162770018u : 1694212733u) ^ num * 3621179598u);
							continue;
						case 12u:
							arg_37A_0 = (((num3 != 1) ? 3768917040u : 2670467745u) ^ num * 3434461367u);
							continue;
						case 13u:
							goto IL_41D;
						case 14u:
						{
							int num5;
							num5 -= 1000000000;
							arg_37A_0 = (num * 752942754u ^ 330657225u);
							continue;
						}
						case 15u:
						{
							int num2;
							int num5;
							timestamp += new Duration
							{
								Nanos = num5,
								Seconds = (long)num2
							};
							arg_37A_0 = ((timestamp.Seconds < Timestamp.UnixSecondsAtBclMinValue) ? 2941647600u : 3675294830u);
							continue;
						}
						case 16u:
						{
							int num2;
							arg_37A_0 = ((num2 < 0) ? 4042516610u : 3413606533u);
							continue;
						}
						case 17u:
							arg_37A_0 = ((num4 != 0) ? 4238917532u : 4277665491u);
							continue;
						case 18u:
						{
							int num5 = int.Parse(JsonParser.smethod_22(string_, 1), JsonParser.smethod_16()) * JsonParser.SubsecondScalingFactors[JsonParser.smethod_14(string_)];
							arg_37A_0 = (num * 580118435u ^ 1430632979u);
							continue;
						}
						case 19u:
							arg_37A_0 = (((timestamp.Seconds > Timestamp.UnixSecondsAtBclMaxValue) ? 3343645217u : 3869490034u) ^ num * 1021343113u);
							continue;
						case 20u:
						{
							int num2 = 0;
							arg_37A_0 = (JsonParser.smethod_9(string_2, Module.smethod_36<string>(845610181u)) ? 3528904889u : 3213147769u);
							continue;
						}
						case 21u:
						{
							int num5;
							arg_37A_0 = (((num5 != 0) ? 1527006506u : 1509404097u) ^ num * 2844187550u);
							continue;
						}
						}
						goto Block_17;
						IL_2B6:
						num3 = arg_2B6_0;
						int arg_2DB_0 = int.Parse(JsonParser.smethod_23(string_2, 1, 2), JsonParser.smethod_16());
						int num6 = int.Parse(JsonParser.smethod_23(string_2, 4, 2));
						num4 = arg_2DB_0 * 60 + num6;
						arg_37A_0 = 2749352340u;
					}
				}
				Block_17:
				goto IL_438;
				IL_3E7:
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_33<string>(2239792768u), token.StringValue));
				IL_402:
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_34<string>(599605732u), token.StringValue));
				IL_41D:
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_37<string>(1660875583u), token.StringValue));
				IL_438:
				message.Descriptor.Fields[1].Accessor.SetValue(message, timestamp.Seconds);
				message.Descriptor.Fields[2].Accessor.SetValue(message, timestamp.Nanos);
			}
			catch (FormatException)
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_37<string>(1660875583u), token.StringValue));
			}
		}

		private static void MergeDuration(IMessage message, JsonToken token)
		{
			if (token.Type != JsonToken.TokenType.StringValue)
			{
				goto IL_B9;
			}
			goto IL_0E;
			uint arg_C3_0;
			string string_;
			while (true)
			{
				IL_BE:
				uint num;
				switch ((num = (arg_C3_0 ^ 3743477647u)) % 5u)
				{
				case 0u:
					goto IL_B9;
				case 1u:
					if (!JsonParser.smethod_6(string_, Module.smethod_33<string>(4150506188u)))
					{
						arg_C3_0 = (num * 2043214906u ^ 3207108872u);
						continue;
					}
					goto IL_11A;
				case 2u:
					goto IL_11D;
				case 3u:
					goto IL_0E;
				}
				break;
			}
			goto IL_12D;
			IL_11A:
			int arg_12E_0 = -1;
			goto IL_12E;
			IL_11D:
			throw new InvalidProtocolBufferException(Module.smethod_34<string>(1162025404u));
			IL_12D:
			arg_12E_0 = 1;
			IL_12E:
			int num2 = arg_12E_0;
			string text;
			try
			{
				long num3 = long.Parse(text, JsonParser.smethod_16());
				int num4 = 0;
				string string_2;
				if (JsonParser.smethod_9(string_2, ""))
				{
					goto IL_161;
				}
				goto IL_280;
				uint arg_244_0;
				while (true)
				{
					IL_23F:
					uint num;
					switch ((num = (arg_244_0 ^ 3743477647u)) % 8u)
					{
					case 1u:
						goto IL_280;
					case 2u:
						arg_244_0 = (((num3 <= 315576000000L) ? 3059631780u : 3189406498u) ^ num * 3359534107u);
						continue;
					case 3u:
						goto IL_292;
					case 4u:
						message.Descriptor.Fields[1].Accessor.SetValue(message, num3 * (long)num2);
						message.Descriptor.Fields[2].Accessor.SetValue(message, num4 * num2);
						arg_244_0 = 2780097103u;
						continue;
					case 5u:
						arg_244_0 = (((num4 <= 0) ? 3727840889u : 3118434438u) ^ num * 35559058u);
						continue;
					case 6u:
						num4 = int.Parse(JsonParser.smethod_22(string_2, 1)) * JsonParser.SubsecondScalingFactors[JsonParser.smethod_14(string_2)];
						arg_244_0 = (num * 475716902u ^ 3859568690u);
						continue;
					case 7u:
						goto IL_161;
					}
					break;
				}
				goto IL_2AD;
				IL_292:
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_34<string>(1950328178u), token.StringValue));
				IL_2AD:
				return;
				IL_161:
				arg_244_0 = 3912563481u;
				goto IL_23F;
				IL_280:
				arg_244_0 = ((num3 >= 315576000000L) ? 3748588597u : 4046420291u);
				goto IL_23F;
			}
			catch (FormatException)
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_34<string>(1950328178u), token.StringValue));
			}
			return;
			IL_0E:
			Match expr_1E = JsonParser.smethod_17(JsonParser.DurationRegex, token.StringValue);
			if (!JsonParser.smethod_18(expr_1E))
			{
				throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_36<string>(949893265u), token.StringValue));
			}
			string_ = JsonParser.smethod_21(JsonParser.smethod_20(JsonParser.smethod_19(expr_1E), Module.smethod_35<string>(519378120u)));
			text = JsonParser.smethod_21(JsonParser.smethod_20(JsonParser.smethod_19(expr_1E), Module.smethod_37<string>(2449754946u)));
			if (JsonParser.smethod_15(text, 0) != '0' || JsonParser.smethod_14(text) <= 1)
			{
				string string_2 = JsonParser.smethod_21(JsonParser.smethod_20(JsonParser.smethod_19(expr_1E), Module.smethod_36<string>(1114779358u)));
				arg_C3_0 = 3507747885u;
				goto IL_BE;
			}
			throw new InvalidProtocolBufferException(JsonParser.smethod_3(Module.smethod_37<string>(3589234261u), token.StringValue));
			IL_B9:
			arg_C3_0 = 4269426338u;
			goto IL_BE;
		}

		private static void MergeFieldMask(IMessage message, JsonToken token)
		{
			if (token.Type != JsonToken.TokenType.StringValue)
			{
				goto IL_3F;
			}
			goto IL_A6;
			uint arg_79_0;
			string[] array;
			IList ilist_;
			while (true)
			{
				IL_74:
				uint num;
				switch ((num = (arg_79_0 ^ 84484847u)) % 8u)
				{
				case 0u:
					arg_79_0 = (num * 1923833620u ^ 3952286986u);
					continue;
				case 2u:
					goto IL_A6;
				case 3u:
				{
					int num2;
					string text = array[num2];
					JsonParser.smethod_4(ilist_, JsonParser.ToSnakeCase(text));
					num2++;
					arg_79_0 = 1706344746u;
					continue;
				}
				case 4u:
					goto IL_3F;
				case 5u:
				{
					int num2;
					arg_79_0 = ((num2 >= array.Length) ? 1071206574u : 1605914468u);
					continue;
				}
				case 6u:
				{
					int num2 = 0;
					arg_79_0 = (num * 3900225482u ^ 2965957787u);
					continue;
				}
				case 7u:
					goto IL_E1;
				}
				break;
			}
			return;
			IL_E1:
			throw new InvalidProtocolBufferException(Module.smethod_34<string>(3516187215u));
			IL_3F:
			arg_79_0 = 1522600896u;
			goto IL_74;
			IL_A6:
			string[] arg_D9_0 = JsonParser.smethod_24(token.StringValue, JsonParser.FieldMaskPathSeparators, StringSplitOptions.RemoveEmptyEntries);
			ilist_ = (IList)message.Descriptor.Fields[1].Accessor.GetValue(message);
			array = arg_D9_0;
			arg_79_0 = 890178969u;
			goto IL_74;
		}

		private static string ToSnakeCase(string text)
		{
			StringBuilder stringBuilder = JsonParser.smethod_25(JsonParser.smethod_14(text) * 2);
			bool flag = false;
			while (true)
			{
				IL_29A:
				uint arg_23C_0 = 4087458186u;
				while (true)
				{
					uint num;
					switch ((num = (arg_23C_0 ^ 3615967362u)) % 20u)
					{
					case 0u:
						arg_23C_0 = (num * 430891444u ^ 987544121u);
						continue;
					case 1u:
					{
						int num2;
						arg_23C_0 = (((JsonParser.smethod_15(text, num2 + 1) >= 'a') ? 2716490890u : 3914129437u) ^ num * 2866782617u);
						continue;
					}
					case 2u:
					{
						int num2 = 0;
						arg_23C_0 = (num * 4185695377u ^ 564518536u);
						continue;
					}
					case 3u:
					{
						int num2;
						arg_23C_0 = ((num2 < JsonParser.smethod_14(text)) ? 4028625926u : 2879589281u);
						continue;
					}
					case 4u:
					{
						flag = true;
						bool flag2 = false;
						arg_23C_0 = (num * 2799082275u ^ 546262518u);
						continue;
					}
					case 5u:
					{
						int num2;
						arg_23C_0 = (((num2 + 1 >= JsonParser.smethod_14(text)) ? 243075670u : 1690560673u) ^ num * 3537512010u);
						continue;
					}
					case 6u:
						JsonParser.smethod_26(stringBuilder, '_');
						arg_23C_0 = 2742354300u;
						continue;
					case 8u:
						arg_23C_0 = (num * 1195174495u ^ 1809923487u);
						continue;
					case 9u:
					{
						int num2;
						arg_23C_0 = (((JsonParser.smethod_15(text, num2 + 1) > 'z') ? 1132507784u : 25457392u) ^ num * 1502253524u);
						continue;
					}
					case 10u:
					{
						char c;
						JsonParser.smethod_26(stringBuilder, c + 'a' - 'A');
						arg_23C_0 = 3175761382u;
						continue;
					}
					case 11u:
					{
						char c;
						arg_23C_0 = (((c <= 'Z') ? 3083540943u : 2197215848u) ^ num * 2979711453u);
						continue;
					}
					case 12u:
					{
						bool flag2 = false;
						arg_23C_0 = (num * 2112741697u ^ 2017133496u);
						continue;
					}
					case 13u:
					{
						int num2;
						num2++;
						arg_23C_0 = 2810480601u;
						continue;
					}
					case 14u:
					{
						char c;
						arg_23C_0 = (((c < 'A') ? 3593171199u : 3129699993u) ^ num * 3794484278u);
						continue;
					}
					case 15u:
					{
						bool flag2;
						arg_23C_0 = (((!flag2) ? 2703065160u : 3981958271u) ^ num * 390337625u);
						continue;
					}
					case 16u:
					{
						int num2;
						char c = JsonParser.smethod_15(text, num2);
						arg_23C_0 = 3594289208u;
						continue;
					}
					case 17u:
					{
						char c;
						JsonParser.smethod_26(stringBuilder, c);
						flag = (c != '_');
						bool flag2 = true;
						arg_23C_0 = 4199024311u;
						continue;
					}
					case 18u:
						arg_23C_0 = (((!flag) ? 1209794314u : 1051599623u) ^ num * 1872829977u);
						continue;
					case 19u:
						goto IL_29A;
					}
					goto Block_9;
				}
			}
			Block_9:
			return JsonParser.smethod_27(stringBuilder);
		}

		static JsonParser()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_29A:
				uint arg_276_0 = 2952191229u;
				while (true)
				{
					uint num;
					switch ((num = (arg_276_0 ^ 3083703703u)) % 6u)
					{
					case 0u:
						JsonParser.defaultInstance = new JsonParser(JsonParser.Settings.Default);
						arg_276_0 = (num * 422700756u ^ 1523261254u);
						continue;
					case 2u:
						goto IL_29A;
					case 3u:
					{
						int[] expr_226 = new int[11];
						JsonParser.smethod_29(expr_226, fieldof(Google.Protobuf.<PrivateImplementationDetails>.CA6D43393CCBD523D8BC1CAC86DE8DC9F018B896).FieldHandle);
						JsonParser.SubsecondScalingFactors = expr_226;
						JsonParser.FieldMaskPathSeparators = new char[]
						{
							','
						};
						arg_276_0 = (num * 457754209u ^ 825326268u);
						continue;
					}
					case 4u:
						JsonParser.DurationRegex = JsonParser.smethod_28(Module.smethod_37<string>(2274513912u), FrameworkPortability.CompiledRegexWhereAvailable);
						arg_276_0 = (num * 3847093214u ^ 3671499966u);
						continue;
					case 5u:
						JsonParser.WellKnownTypeHandlers = new Dictionary<string, Action<JsonParser, IMessage, JsonTokenizer>>
						{
							{
								Timestamp.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.__c.__9.<.cctor>b__36_0)
							},
							{
								Duration.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.__c.__9.<.cctor>b__36_1)
							},
							{
								Value.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.__c.__9.<.cctor>b__36_2)
							},
							{
								ListValue.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.__c.__9.<.cctor>b__36_3)
							},
							{
								Struct.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.__c.__9.<.cctor>b__36_4)
							},
							{
								Any.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.__c.__9.<.cctor>b__36_5)
							},
							{
								FieldMask.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.__c.__9.<.cctor>b__36_6)
							},
							{
								Int32Value.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.MergeWrapperField)
							},
							{
								Int64Value.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.MergeWrapperField)
							},
							{
								UInt32Value.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.MergeWrapperField)
							},
							{
								UInt64Value.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.MergeWrapperField)
							},
							{
								FloatValue.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.MergeWrapperField)
							},
							{
								DoubleValue.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.MergeWrapperField)
							},
							{
								BytesValue.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.MergeWrapperField)
							},
							{
								StringValue.Descriptor.FullName,
								new Action<JsonParser, IMessage, JsonTokenizer>(JsonParser.MergeWrapperField)
							}
						};
						arg_276_0 = (num * 1561989255u ^ 793254927u);
						continue;
					}
					return;
				}
			}
		}

		static StringReader smethod_0(string string_0)
		{
			return new StringReader(string_0);
		}

		static string smethod_1(object object_0, object object_1)
		{
			return object_0 + object_1;
		}

		static InvalidOperationException smethod_2(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static string smethod_3(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static int smethod_4(IList ilist_0, object object_0)
		{
			return ilist_0.Add(object_0);
		}

		static void smethod_5(IDictionary idictionary_0, object object_0, object object_1)
		{
			idictionary_0[object_0] = object_1;
		}

		static bool smethod_6(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		static NotImplementedException smethod_7(string string_0)
		{
			return new NotImplementedException(string_0);
		}

		static string smethod_8(object[] object_0)
		{
			return string.Concat(object_0);
		}

		static bool smethod_9(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		static string smethod_10(string string_0, object[] object_0)
		{
			return string.Format(string_0, object_0);
		}

		static bool smethod_11(string string_0, string string_1)
		{
			return string_0.Contains(string_1);
		}

		static string smethod_12(string string_0, string string_1, string string_2, string string_3)
		{
			return string_0 + string_1 + string_2 + string_3;
		}

		static bool smethod_13(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1);
		}

		static int smethod_14(string string_0)
		{
			return string_0.Length;
		}

		static char smethod_15(string string_0, int int_0)
		{
			return string_0[int_0];
		}

		static CultureInfo smethod_16()
		{
			return CultureInfo.InvariantCulture;
		}

		static Match smethod_17(Regex regex_0, string string_0)
		{
			return regex_0.Match(string_0);
		}

		static bool smethod_18(Group group_0)
		{
			return group_0.Success;
		}

		static GroupCollection smethod_19(Match match_0)
		{
			return match_0.Groups;
		}

		static Group smethod_20(GroupCollection groupCollection_0, string string_0)
		{
			return groupCollection_0[string_0];
		}

		static string smethod_21(Capture capture_0)
		{
			return capture_0.Value;
		}

		static string smethod_22(string string_0, int int_0)
		{
			return string_0.Substring(int_0);
		}

		static string smethod_23(string string_0, int int_0, int int_1)
		{
			return string_0.Substring(int_0, int_1);
		}

		static string[] smethod_24(string string_0, char[] char_0, StringSplitOptions stringSplitOptions_0)
		{
			return string_0.Split(char_0, stringSplitOptions_0);
		}

		static StringBuilder smethod_25(int int_0)
		{
			return new StringBuilder(int_0);
		}

		static StringBuilder smethod_26(StringBuilder stringBuilder_0, char char_0)
		{
			return stringBuilder_0.Append(char_0);
		}

		static string smethod_27(object object_0)
		{
			return object_0.ToString();
		}

		static Regex smethod_28(string string_0, RegexOptions regexOptions_0)
		{
			return new Regex(string_0, regexOptions_0);
		}

		static void smethod_29(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}
}
