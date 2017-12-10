using System;

namespace Google.Protobuf
{
	internal sealed class JsonToken : IEquatable<JsonToken>
	{
		internal enum TokenType
		{
			Null,
			False,
			True,
			StringValue,
			Number,
			Name,
			StartObject,
			EndObject,
			StartArray,
			EndArray,
			EndDocument
		}

		private static readonly JsonToken _true = new JsonToken(JsonToken.TokenType.True, null, 0.0);

		private static readonly JsonToken _false;

		private static readonly JsonToken _null;

		private static readonly JsonToken startObject;

		private static readonly JsonToken endObject;

		private static readonly JsonToken startArray;

		private static readonly JsonToken endArray;

		private static readonly JsonToken endDocument;

		private readonly JsonToken.TokenType type;

		private readonly string stringValue;

		private readonly double numberValue;

		internal static JsonToken Null
		{
			get
			{
				return JsonToken._null;
			}
		}

		internal static JsonToken False
		{
			get
			{
				return JsonToken._false;
			}
		}

		internal static JsonToken True
		{
			get
			{
				return JsonToken._true;
			}
		}

		internal static JsonToken StartObject
		{
			get
			{
				return JsonToken.startObject;
			}
		}

		internal static JsonToken EndObject
		{
			get
			{
				return JsonToken.endObject;
			}
		}

		internal static JsonToken StartArray
		{
			get
			{
				return JsonToken.startArray;
			}
		}

		internal static JsonToken EndArray
		{
			get
			{
				return JsonToken.endArray;
			}
		}

		internal static JsonToken EndDocument
		{
			get
			{
				return JsonToken.endDocument;
			}
		}

		internal JsonToken.TokenType Type
		{
			get
			{
				return this.type;
			}
		}

		internal string StringValue
		{
			get
			{
				return this.stringValue;
			}
		}

		internal double NumberValue
		{
			get
			{
				return this.numberValue;
			}
		}

		internal static JsonToken Name(string name)
		{
			return new JsonToken(JsonToken.TokenType.Name, name, 0.0);
		}

		internal static JsonToken Value(string value)
		{
			return new JsonToken(JsonToken.TokenType.StringValue, value, 0.0);
		}

		internal static JsonToken Value(double value)
		{
			return new JsonToken(JsonToken.TokenType.Number, null, value);
		}

		private JsonToken(JsonToken.TokenType type, string stringValue = null, double numberValue = 0.0)
		{
			while (true)
			{
				IL_5A:
				uint arg_3E_0 = 2482964016u;
				while (true)
				{
					uint num;
					switch ((num = (arg_3E_0 ^ 3449118601u)) % 4u)
					{
					case 0u:
						this.numberValue = numberValue;
						arg_3E_0 = (num * 3564385074u ^ 1989645462u);
						continue;
					case 1u:
						this.type = type;
						this.stringValue = stringValue;
						arg_3E_0 = (num * 2560805287u ^ 1189576714u);
						continue;
					case 2u:
						goto IL_5A;
					}
					return;
				}
			}
		}

		public override bool Equals(object obj)
		{
			return this.Equals(obj as JsonToken);
		}

		public override int GetHashCode()
		{
			return ((JsonToken.smethod_0((int)(((JsonToken.TokenType)527 + (int)this.type) * (JsonToken.TokenType)31), this.stringValue) == null) ? 0 : JsonToken.smethod_1(this.stringValue)) * 31 + this.numberValue.GetHashCode();
		}

		public override string ToString()
		{
			JsonToken.TokenType tokenType = this.type;
			while (true)
			{
				IL_AB:
				uint arg_5F_0 = 2682264506u;
				while (true)
				{
					uint num;
					switch ((num = (arg_5F_0 ^ 4241128215u)) % 15u)
					{
					case 0u:
						goto IL_C8;
					case 1u:
						goto IL_BD;
					case 2u:
						goto IL_E8;
					case 3u:
						goto IL_B2;
					case 4u:
						arg_5F_0 = (num * 3627266443u ^ 1115301066u);
						continue;
					case 5u:
						switch (tokenType)
						{
						case JsonToken.TokenType.Null:
							goto IL_B2;
						case JsonToken.TokenType.False:
							goto IL_144;
						case JsonToken.TokenType.True:
							goto IL_BD;
						case JsonToken.TokenType.StringValue:
							goto IL_16F;
						case JsonToken.TokenType.Number:
							goto IL_F3;
						case JsonToken.TokenType.Name:
							goto IL_C8;
						case JsonToken.TokenType.StartObject:
							goto IL_123;
						case JsonToken.TokenType.EndObject:
							goto IL_139;
						case JsonToken.TokenType.StartArray:
							goto IL_12E;
						case JsonToken.TokenType.EndArray:
							goto IL_E8;
						case JsonToken.TokenType.EndDocument:
							goto IL_118;
						default:
							arg_5F_0 = (num * 2433619620u ^ 3405509361u);
							continue;
						}
						break;
					case 6u:
						goto IL_AB;
					case 7u:
						goto IL_F3;
					case 8u:
						goto IL_118;
					case 9u:
						goto IL_123;
					case 10u:
						goto IL_12E;
					case 11u:
						goto IL_139;
					case 12u:
						goto IL_144;
					case 14u:
						goto IL_16F;
					}
					goto Block_2;
				}
			}
			Block_2:
			goto IL_14F;
			IL_B2:
			return Module.smethod_34<string>(854952751u);
			IL_BD:
			return Module.smethod_33<string>(2183097496u);
			IL_C8:
			return JsonToken.smethod_2(Module.smethod_35<string>(2827822917u), this.stringValue, Module.smethod_36<string>(472157920u));
			IL_E8:
			return Module.smethod_36<string>(1155181364u);
			IL_F3:
			return JsonToken.smethod_3(Module.smethod_34<string>(1106698670u), this.numberValue, Module.smethod_33<string>(4291034649u));
			IL_118:
			return Module.smethod_34<string>(985298691u);
			IL_123:
			return Module.smethod_34<string>(2110138035u);
			IL_12E:
			return Module.smethod_33<string>(3370785385u);
			IL_139:
			return Module.smethod_34<string>(891562079u);
			IL_144:
			return Module.smethod_34<string>(1042425975u);
			IL_14F:
			throw JsonToken.smethod_4(JsonToken.smethod_0(Module.smethod_34<string>(1266508527u), this.type));
			IL_16F:
			return JsonToken.smethod_2(Module.smethod_35<string>(743299430u), this.stringValue, Module.smethod_37<string>(988941460u));
		}

		public bool Equals(JsonToken other)
		{
			if (other == null)
			{
				goto IL_12;
			}
			goto IL_80;
			uint arg_50_0;
			while (true)
			{
				IL_4B:
				uint num;
				switch ((num = (arg_50_0 ^ 2022758360u)) % 6u)
				{
				case 0u:
					arg_50_0 = ((JsonToken.smethod_5(other.stringValue, this.stringValue) ? 3339617465u : 4144370203u) ^ num * 1474894069u);
					continue;
				case 1u:
					goto IL_80;
				case 2u:
					return false;
				case 3u:
					goto IL_95;
				case 4u:
					goto IL_12;
				}
				break;
			}
			return false;
			IL_95:
			return other.numberValue.Equals(this.numberValue);
			IL_12:
			arg_50_0 = 349897714u;
			goto IL_4B;
			IL_80:
			arg_50_0 = ((other.type != this.type) ? 525633735u : 1412776500u);
			goto IL_4B;
		}

		static JsonToken()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_141:
				uint arg_115_0 = 1875517405u;
				while (true)
				{
					uint num;
					switch ((num = (arg_115_0 ^ 143700716u)) % 8u)
					{
					case 0u:
						goto IL_141;
					case 1u:
						JsonToken._false = new JsonToken(JsonToken.TokenType.False, null, 0.0);
						JsonToken._null = new JsonToken(JsonToken.TokenType.Null, null, 0.0);
						arg_115_0 = (num * 2365135103u ^ 2905530529u);
						continue;
					case 2u:
						JsonToken.startObject = new JsonToken(JsonToken.TokenType.StartObject, null, 0.0);
						arg_115_0 = (num * 2387771332u ^ 3997082761u);
						continue;
					case 4u:
						JsonToken.endDocument = new JsonToken(JsonToken.TokenType.EndDocument, null, 0.0);
						arg_115_0 = (num * 2008010039u ^ 961248203u);
						continue;
					case 5u:
						JsonToken.endObject = new JsonToken(JsonToken.TokenType.EndObject, null, 0.0);
						arg_115_0 = (num * 253508060u ^ 4097918919u);
						continue;
					case 6u:
						JsonToken.endArray = new JsonToken(JsonToken.TokenType.EndArray, null, 0.0);
						arg_115_0 = (num * 3755424471u ^ 987096586u);
						continue;
					case 7u:
						JsonToken.startArray = new JsonToken(JsonToken.TokenType.StartArray, null, 0.0);
						arg_115_0 = (num * 2598877456u ^ 1311215378u);
						continue;
					}
					return;
				}
			}
		}

		static string smethod_0(object object_0, object object_1)
		{
			return object_0 + object_1;
		}

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}

		static string smethod_2(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}

		static string smethod_3(object object_0, object object_1, object object_2)
		{
			return object_0 + object_1 + object_2;
		}

		static InvalidOperationException smethod_4(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static bool smethod_5(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}
}
