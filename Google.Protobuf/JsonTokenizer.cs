using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Google.Protobuf
{
	internal abstract class JsonTokenizer
	{
		private class JsonReplayTokenizer : JsonTokenizer
		{
			private readonly IList<JsonToken> tokens;

			private readonly JsonTokenizer nextTokenizer;

			private int nextTokenIndex;

			internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer)
			{
				this.tokens = tokens;
				this.nextTokenizer = nextTokenizer;
			}

			protected override JsonToken NextImpl()
			{
				if (this.nextTokenIndex >= this.tokens.Count)
				{
					return this.nextTokenizer.Next();
				}
				IList<JsonToken> arg_36_0 = this.tokens;
				int num = this.nextTokenIndex;
				this.nextTokenIndex = num + 1;
				return arg_36_0[num];
			}
		}

		private sealed class JsonTextTokenizer : JsonTokenizer
		{
			private enum ContainerType
			{
				Document,
				Object,
				Array
			}

			[Flags]
			private enum State
			{
				StartOfDocument = 1,
				ExpectedEndOfDocument = 2,
				ReaderExhausted = 4,
				ObjectStart = 8,
				ObjectBeforeColon = 16,
				ObjectAfterColon = 32,
				ObjectAfterProperty = 64,
				ObjectAfterComma = 128,
				ArrayStart = 256,
				ArrayAfterValue = 512,
				ArrayAfterComma = 1024
			}

			private class PushBackReader
			{
				private readonly TextReader reader;

				private char? nextChar;

				internal PushBackReader(TextReader reader)
				{
					this.reader = reader;
				}

				internal char? Read()
				{
					if (this.nextChar.HasValue)
					{
						goto IL_34;
					}
					goto IL_62;
					uint arg_3E_0;
					int num2;
					while (true)
					{
						IL_39:
						uint num;
						switch ((num = (arg_3E_0 ^ 54458132u)) % 6u)
						{
						case 0u:
							goto IL_75;
						case 2u:
							goto IL_34;
						case 3u:
							arg_3E_0 = (((num2 == -1) ? 3551026886u : 3152099965u) ^ num * 365943735u);
							continue;
						case 4u:
							goto IL_62;
						case 5u:
							goto IL_87;
						}
						break;
					}
					goto IL_7D;
					IL_75:
					return new char?((char)num2);
					IL_7D:
					return null;
					IL_87:
					char? arg_99_0 = this.nextChar;
					this.nextChar = null;
					return arg_99_0;
					IL_34:
					arg_3E_0 = 659434097u;
					goto IL_39;
					IL_62:
					num2 = JsonTokenizer.JsonTextTokenizer.PushBackReader.smethod_0(this.reader);
					arg_3E_0 = 412973525u;
					goto IL_39;
				}

				internal char ReadOrFail(string messageOnFailure)
				{
					char? c = this.Read();
					while (true)
					{
						IL_52:
						uint arg_36_0 = 2901153560u;
						while (true)
						{
							uint num;
							switch ((num = (arg_36_0 ^ 2903223402u)) % 4u)
							{
							case 1u:
								goto IL_59;
							case 2u:
								arg_36_0 = (((!c.HasValue) ? 1849441321u : 154677480u) ^ num * 4107666269u);
								continue;
							case 3u:
								goto IL_52;
							}
							goto Block_2;
						}
					}
					Block_2:
					goto IL_61;
					IL_59:
					throw this.CreateException(messageOnFailure);
					IL_61:
					return c.Value;
				}

				internal void PushBack(char c)
				{
					if (this.nextChar.HasValue)
					{
						throw JsonTokenizer.JsonTextTokenizer.PushBackReader.smethod_1(Module.smethod_34<string>(1813605522u));
					}
					this.nextChar = new char?(c);
				}

				internal InvalidJsonException CreateException(string message)
				{
					return new InvalidJsonException(message);
				}

				static int smethod_0(TextReader textReader_0)
				{
					return textReader_0.Read();
				}

				static InvalidOperationException smethod_1(string string_0)
				{
					return new InvalidOperationException(string_0);
				}
			}

			private static readonly JsonTokenizer.JsonTextTokenizer.State ValueStates = JsonTokenizer.JsonTextTokenizer.State.StartOfDocument | JsonTokenizer.JsonTextTokenizer.State.ObjectAfterColon | JsonTokenizer.JsonTextTokenizer.State.ArrayStart | JsonTokenizer.JsonTextTokenizer.State.ArrayAfterComma;

			private readonly Stack<JsonTokenizer.JsonTextTokenizer.ContainerType> containerStack = new Stack<JsonTokenizer.JsonTextTokenizer.ContainerType>();

			private readonly JsonTokenizer.JsonTextTokenizer.PushBackReader reader;

			private JsonTokenizer.JsonTextTokenizer.State state;

			internal JsonTextTokenizer(TextReader reader)
			{
				this.reader = new JsonTokenizer.JsonTextTokenizer.PushBackReader(reader);
				this.state = JsonTokenizer.JsonTextTokenizer.State.StartOfDocument;
				this.containerStack.Push(JsonTokenizer.JsonTextTokenizer.ContainerType.Document);
			}

			protected override JsonToken NextImpl()
			{
				if (this.state == JsonTokenizer.JsonTextTokenizer.State.ReaderExhausted)
				{
					goto IL_2D4;
				}
				goto IL_58F;
				uint arg_4BB_0;
				char? c;
				char value;
				string text;
				while (true)
				{
					IL_4B6:
					uint num;
					switch ((num = (arg_4BB_0 ^ 4104288529u)) % 49u)
					{
					case 0u:
						arg_4BB_0 = ((((this.state & (JsonTokenizer.JsonTextTokenizer.State.ObjectStart | JsonTokenizer.JsonTextTokenizer.State.ObjectAfterComma)) != (JsonTokenizer.JsonTextTokenizer.State)0) ? 4189633668u : 4074212105u) ^ num * 613776407u);
						continue;
					case 1u:
						arg_4BB_0 = (num * 1780515259u ^ 1079949964u);
						continue;
					case 2u:
						this.ConsumeLiteral(Module.smethod_33<string>(2183097496u));
						arg_4BB_0 = 3354073184u;
						continue;
					case 3u:
						goto IL_5A5;
					case 4u:
						goto IL_1E1;
					case 5u:
						value = c.Value;
						arg_4BB_0 = ((value <= ']') ? 2713967851u : 4194276540u);
						continue;
					case 6u:
						goto IL_1F2;
					case 7u:
						this.containerStack.Push(JsonTokenizer.JsonTextTokenizer.ContainerType.Array);
						arg_4BB_0 = (num * 3569194665u ^ 4042399453u);
						continue;
					case 8u:
						this.state = ((this.state == JsonTokenizer.JsonTextTokenizer.State.ObjectAfterProperty) ? JsonTokenizer.JsonTextTokenizer.State.ObjectAfterComma : JsonTokenizer.JsonTextTokenizer.State.ArrayAfterComma);
						arg_4BB_0 = 3256357922u;
						continue;
					case 9u:
						this.state = JsonTokenizer.JsonTextTokenizer.State.ArrayStart;
						arg_4BB_0 = (num * 1565805873u ^ 2991989195u);
						continue;
					case 10u:
						arg_4BB_0 = (((value == 'f') ? 16608841u : 1831065471u) ^ num * 3882616260u);
						continue;
					case 11u:
						this.ValidateState(JsonTokenizer.JsonTextTokenizer.State.ExpectedEndOfDocument, Module.smethod_37<string>(696784657u));
						arg_4BB_0 = (num * 3238566415u ^ 1787036935u);
						continue;
					case 12u:
						goto IL_5FF;
					case 13u:
						goto IL_5AB;
					case 14u:
						arg_4BB_0 = ((value != '[') ? 2651008389u : 2849759416u);
						continue;
					case 15u:
						goto IL_5B7;
					case 16u:
						goto IL_5C9;
					case 17u:
						arg_4BB_0 = ((c.HasValue ? 601949170u : 2073706518u) ^ num * 45218448u);
						continue;
					case 18u:
						arg_4BB_0 = (num * 31089536u ^ 1655698913u);
						continue;
					case 19u:
						this.ValidateAndModifyStateForValue(Module.smethod_36<string>(2697853881u));
						arg_4BB_0 = 2165679561u;
						continue;
					case 20u:
						arg_4BB_0 = (num * 3218023307u ^ 518270700u);
						continue;
					case 21u:
						arg_4BB_0 = (((value != 'n') ? 4277936919u : 2351134377u) ^ num * 2118258224u);
						continue;
					case 22u:
						goto IL_211;
					case 23u:
						goto IL_2D4;
					case 24u:
						switch (value)
						{
						case '\t':
						case '\n':
						case '\r':
							goto IL_58F;
						case '\v':
						case '\f':
							break;
						default:
							arg_4BB_0 = (num * 3323278026u ^ 3691783999u);
							continue;
						}
						break;
					case 25u:
						arg_4BB_0 = ((value <= 'n') ? 4128490372u : 2255017729u);
						continue;
					case 26u:
						goto IL_5EF;
					case 27u:
						arg_4BB_0 = (((value <= ':') ? 1654060446u : 498475676u) ^ num * 2385843212u);
						continue;
					case 28u:
						this.ValidateState(JsonTokenizer.JsonTextTokenizer.ValueStates, Module.smethod_33<string>(3038277013u));
						this.state = JsonTokenizer.JsonTextTokenizer.State.ObjectStart;
						arg_4BB_0 = 4204753262u;
						continue;
					case 29u:
						switch (value)
						{
						case ' ':
							goto IL_58F;
						case '!':
						case '#':
						case '$':
						case '%':
						case '&':
						case '\'':
						case '(':
						case ')':
						case '*':
						case '+':
						case '.':
						case '/':
							break;
						case '"':
							goto IL_1E1;
						case ',':
							goto IL_1F2;
						case '-':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
							goto IL_5FF;
						case ':':
							goto IL_211;
						default:
							arg_4BB_0 = (num * 2264991434u ^ 3481491539u);
							continue;
						}
						break;
					case 31u:
						arg_4BB_0 = (num * 3672174545u ^ 1262540738u);
						continue;
					case 32u:
						this.ValidateState(JsonTokenizer.JsonTextTokenizer.State.ObjectStart | JsonTokenizer.JsonTextTokenizer.State.ObjectAfterProperty, Module.smethod_35<string>(729339763u));
						arg_4BB_0 = 3646157473u;
						continue;
					case 33u:
						this.ValidateAndModifyStateForValue(Module.smethod_35<string>(3051744227u));
						arg_4BB_0 = (num * 1242424546u ^ 2253991453u);
						continue;
					case 34u:
						goto IL_646;
					case 35u:
						goto IL_65C;
					case 36u:
						arg_4BB_0 = (num * 1156292080u ^ 354682250u);
						continue;
					case 37u:
						arg_4BB_0 = (((value == ']') ? 2126881218u : 210840875u) ^ num * 3486021890u);
						continue;
					case 38u:
						this.ValidateState(JsonTokenizer.JsonTextTokenizer.ValueStates, Module.smethod_33<string>(264414547u));
						arg_4BB_0 = 3155664105u;
						continue;
					case 39u:
						goto IL_662;
					case 40u:
						arg_4BB_0 = ((value == 't') ? 3451957491u : 2391816909u);
						continue;
					case 41u:
						arg_4BB_0 = (((value == '}') ? 2696882427u : 4041481864u) ^ num * 4174514279u);
						continue;
					case 42u:
						goto IL_58F;
					case 43u:
						arg_4BB_0 = (num * 1137712071u ^ 1249477728u);
						continue;
					case 44u:
						goto IL_669;
					case 45u:
						arg_4BB_0 = (((value != '{') ? 9585384u : 2028305637u) ^ num * 3718391630u);
						continue;
					case 46u:
						goto IL_68A;
					case 47u:
						goto IL_697;
					case 48u:
						this.ConsumeLiteral(Module.smethod_34<string>(854952751u));
						arg_4BB_0 = 4008116300u;
						continue;
					}
					break;
					IL_1E1:
					text = this.ReadString();
					arg_4BB_0 = 3240433145u;
					continue;
					IL_1F2:
					this.ValidateState(JsonTokenizer.JsonTextTokenizer.State.ObjectAfterProperty | JsonTokenizer.JsonTextTokenizer.State.ArrayAfterValue, Module.smethod_37<string>(3384786388u));
					arg_4BB_0 = 2838028240u;
					continue;
					IL_211:
					this.ValidateState(JsonTokenizer.JsonTextTokenizer.State.ObjectBeforeColon, Module.smethod_34<string>(422879019u));
					this.state = JsonTokenizer.JsonTextTokenizer.State.ObjectAfterColon;
					arg_4BB_0 = 4019477044u;
				}
				goto IL_622;
				IL_5A5:
				return JsonToken.True;
				IL_5AB:
				this.PopContainer();
				return JsonToken.EndObject;
				IL_5B7:
				this.containerStack.Push(JsonTokenizer.JsonTextTokenizer.ContainerType.Object);
				return JsonToken.StartObject;
				IL_5C9:
				this.ConsumeLiteral(Module.smethod_34<string>(1042425975u));
				this.ValidateAndModifyStateForValue(Module.smethod_35<string>(4226906126u));
				return JsonToken.False;
				IL_5EF:
				throw JsonTokenizer.JsonTextTokenizer.smethod_1(Module.smethod_34<string>(1238845160u));
				IL_5FF:
				double arg_61C_0 = this.ReadNumber(c.Value);
				this.ValidateAndModifyStateForValue(Module.smethod_33<string>(3249020366u));
				return JsonToken.Value(arg_61C_0);
				IL_622:
				string arg_63B_0 = Module.smethod_36<string>(78504656u);
				value = c.Value;
				throw new InvalidJsonException(arg_63B_0 + value.ToString());
				IL_646:
				this.ValidateAndModifyStateForValue(Module.smethod_36<string>(3099968612u));
				return JsonToken.Null;
				IL_65C:
				return JsonToken.StartArray;
				IL_662:
				return JsonToken.Value(text);
				IL_669:
				this.ValidateState(JsonTokenizer.JsonTextTokenizer.State.ArrayStart | JsonTokenizer.JsonTextTokenizer.State.ArrayAfterValue, Module.smethod_34<string>(4127763276u));
				this.PopContainer();
				return JsonToken.EndArray;
				IL_68A:
				this.state = JsonTokenizer.JsonTextTokenizer.State.ReaderExhausted;
				return JsonToken.EndDocument;
				IL_697:
				this.state = JsonTokenizer.JsonTextTokenizer.State.ObjectBeforeColon;
				return JsonToken.Name(text);
				IL_2D4:
				arg_4BB_0 = 2572704042u;
				goto IL_4B6;
				IL_58F:
				c = this.reader.Read();
				arg_4BB_0 = 2432965824u;
				goto IL_4B6;
			}

			private void ValidateState(JsonTokenizer.JsonTextTokenizer.State validStates, string errorPrefix)
			{
				if ((validStates & this.state) == (JsonTokenizer.JsonTextTokenizer.State)0)
				{
					throw this.reader.CreateException(JsonTokenizer.JsonTextTokenizer.smethod_2(errorPrefix, this.state));
				}
			}

			private string ReadString()
			{
				StringBuilder stringBuilder = JsonTokenizer.JsonTextTokenizer.smethod_3();
				char c;
				while (true)
				{
					IL_15A:
					uint arg_112_0 = 3620687331u;
					while (true)
					{
						uint num;
						bool flag;
						switch ((num = (arg_112_0 ^ 4272740808u)) % 14u)
						{
						case 0u:
							goto IL_161;
						case 1u:
							break;
						case 2u:
							c = this.ReadEscapedCharacter();
							arg_112_0 = (num * 2725289111u ^ 1120742850u);
							continue;
						case 3u:
							goto IL_1BC;
						case 4u:
							arg_112_0 = ((flag == char.IsLowSurrogate(c)) ? 3003995817u : 2588340739u);
							continue;
						case 5u:
							goto IL_177;
						case 6u:
							goto IL_15A;
						case 7u:
							arg_112_0 = ((flag ? 107009173u : 777590446u) ^ num * 2996127681u);
							continue;
						case 8u:
							arg_112_0 = ((c != '"') ? 2558513376u : 3518886843u);
							continue;
						case 9u:
							arg_112_0 = (((c >= ' ') ? 1341174011u : 1546045331u) ^ num * 3828862361u);
							continue;
						case 10u:
							goto IL_18D;
						case 11u:
							goto IL_40;
						case 12u:
							arg_112_0 = ((c == '\\') ? 2622634104u : 2417193746u);
							continue;
						case 13u:
							flag = false;
							arg_112_0 = (num * 2648914611u ^ 3534606762u);
							continue;
						default:
							goto IL_40;
						}
						IL_4F:
						c = this.reader.ReadOrFail(Module.smethod_36<string>(2665913342u));
						arg_112_0 = 2904473537u;
						continue;
						IL_40:
						flag = char.IsHighSurrogate(c);
						JsonTokenizer.JsonTextTokenizer.smethod_7(stringBuilder, c);
						goto IL_4F;
					}
				}
				IL_161:
				throw this.reader.CreateException(Module.smethod_36<string>(1175382367u));
				IL_177:
				throw this.reader.CreateException(Module.smethod_34<string>(1971821200u));
				IL_18D:
				throw this.reader.CreateException(JsonTokenizer.JsonTextTokenizer.smethod_5(JsonTokenizer.JsonTextTokenizer.smethod_4(), Module.smethod_36<string>(420016378u), new object[]
				{
					(int)c
				}));
				IL_1BC:
				return JsonTokenizer.JsonTextTokenizer.smethod_6(stringBuilder);
			}

			private char ReadEscapedCharacter()
			{
				char c = this.reader.ReadOrFail(Module.smethod_34<string>(3162733789u));
				while (true)
				{
					IL_211:
					uint arg_1A8_0 = 3062335140u;
					while (true)
					{
						uint num;
						switch ((num = (arg_1A8_0 ^ 4079434994u)) % 23u)
						{
						case 0u:
							goto IL_211;
						case 1u:
							arg_1A8_0 = ((c > 'f') ? 2722377798u : 2643363571u);
							continue;
						case 2u:
							return '\n';
						case 3u:
							arg_1A8_0 = (((c != '"') ? 2765306433u : 2240310335u) ^ num * 2674925868u);
							continue;
						case 4u:
							return '\t';
						case 5u:
							arg_1A8_0 = ((c != 'n') ? 3467003307u : 3305353407u);
							continue;
						case 6u:
							return '/';
						case 7u:
							arg_1A8_0 = (num * 3982733363u ^ 1979839306u);
							continue;
						case 8u:
							return '\\';
						case 9u:
							arg_1A8_0 = (((c != '\\') ? 3548623818u : 3165263482u) ^ num * 3790190069u);
							continue;
						case 10u:
							arg_1A8_0 = (num * 1462205459u ^ 3808141827u);
							continue;
						case 11u:
							return '\b';
						case 12u:
							return '\r';
						case 13u:
							arg_1A8_0 = (((c != 'b') ? 778816751u : 577794695u) ^ num * 2347313433u);
							continue;
						case 14u:
							arg_1A8_0 = (((c > '\\') ? 3974670883u : 2172466138u) ^ num * 2507694954u);
							continue;
						case 15u:
							arg_1A8_0 = (num * 967588637u ^ 1015961980u);
							continue;
						case 16u:
							return '"';
						case 17u:
							switch (c)
							{
							case 'r':
								return '\r';
							case 's':
								break;
							case 't':
								return '\t';
							case 'u':
								goto IL_25E;
							default:
								arg_1A8_0 = (num * 1675692336u ^ 3977989151u);
								continue;
							}
							break;
						case 18u:
							arg_1A8_0 = (((c != 'f') ? 739719556u : 208991868u) ^ num * 1787573665u);
							continue;
						case 19u:
							return '\f';
						case 20u:
							arg_1A8_0 = (((c != '/') ? 3155057367u : 2833038793u) ^ num * 3475288260u);
							continue;
						case 21u:
							goto IL_25E;
						}
						goto Block_10;
					}
				}
				Block_10:
				throw this.reader.CreateException(JsonTokenizer.JsonTextTokenizer.smethod_5(JsonTokenizer.JsonTextTokenizer.smethod_4(), Module.smethod_36<string>(1720276859u), new object[]
				{
					(int)c
				}));
				IL_25E:
				return this.ReadUnicodeEscape();
			}

			private char ReadUnicodeEscape()
			{
				int num = 0;
				int num2 = 0;
				char c;
				while (true)
				{
					IL_1FE:
					uint arg_1AC_0 = 2653937280u;
					while (true)
					{
						uint num3;
						switch ((num3 = (arg_1AC_0 ^ 4233377929u)) % 17u)
						{
						case 0u:
						{
							int num4 = (int)(c - 'A' + '\n');
							arg_1AC_0 = (num3 * 508779129u ^ 2702182616u);
							continue;
						}
						case 1u:
							arg_1AC_0 = (num3 * 2609668024u ^ 2787699904u);
							continue;
						case 2u:
							goto IL_1FE;
						case 3u:
							arg_1AC_0 = ((c < 'A') ? 3942694087u : 2573427630u);
							continue;
						case 4u:
						{
							int num4;
							num = (num << 4) + num4;
							num2++;
							arg_1AC_0 = 2776515000u;
							continue;
						}
						case 5u:
						{
							int num4 = (int)(c - '0');
							arg_1AC_0 = (num3 * 2963008298u ^ 2633543671u);
							continue;
						}
						case 6u:
							arg_1AC_0 = (((c <= 'f') ? 2168919537u : 4260011693u) ^ num3 * 145883296u);
							continue;
						case 8u:
							arg_1AC_0 = (num3 * 361108721u ^ 2287302452u);
							continue;
						case 9u:
							arg_1AC_0 = (((c > '9') ? 3439603900u : 4211219570u) ^ num3 * 2833537411u);
							continue;
						case 10u:
						{
							int num4 = (int)(c - 'a' + '\n');
							arg_1AC_0 = (num3 * 1070551868u ^ 1248349112u);
							continue;
						}
						case 11u:
							goto IL_205;
						case 12u:
							arg_1AC_0 = ((num2 < 4) ? 3092110384u : 2742418676u);
							continue;
						case 13u:
							c = this.reader.ReadOrFail(Module.smethod_33<string>(3103850383u));
							arg_1AC_0 = 2564271999u;
							continue;
						case 14u:
							arg_1AC_0 = (((c > 'F') ? 2960974476u : 3337493250u) ^ num3 * 1618405949u);
							continue;
						case 15u:
							arg_1AC_0 = ((c < 'a') ? 3078328205u : 2286537020u);
							continue;
						case 16u:
							arg_1AC_0 = (((c >= '0') ? 1993715127u : 225562518u) ^ num3 * 1948514286u);
							continue;
						}
						goto Block_8;
					}
				}
				Block_8:
				goto IL_234;
				IL_205:
				throw this.reader.CreateException(JsonTokenizer.JsonTextTokenizer.smethod_5(JsonTokenizer.JsonTextTokenizer.smethod_4(), Module.smethod_37<string>(3267752735u), new object[]
				{
					(int)c
				}));
				IL_234:
				return (char)num;
			}

			private void ConsumeLiteral(string text)
			{
				int num = 1;
				while (true)
				{
					IL_E4:
					uint arg_AF_0 = 2223443095u;
					while (true)
					{
						uint num2;
						switch ((num2 = (arg_AF_0 ^ 4018287206u)) % 10u)
						{
						case 0u:
							goto IL_E4;
						case 1u:
						{
							char? c;
							arg_AF_0 = ((c.Value == JsonTokenizer.JsonTextTokenizer.smethod_9(text, num)) ? 2475896341u : 2649898718u);
							continue;
						}
						case 2u:
							goto IL_EB;
						case 4u:
						{
							char? c;
							arg_AF_0 = ((c.HasValue ? 413622785u : 845568016u) ^ num2 * 2831655103u);
							continue;
						}
						case 5u:
							arg_AF_0 = (num2 * 2640271923u ^ 3158801794u);
							continue;
						case 6u:
						{
							char? c = this.reader.Read();
							arg_AF_0 = 2243680368u;
							continue;
						}
						case 7u:
							arg_AF_0 = ((num < JsonTokenizer.JsonTextTokenizer.smethod_10(text)) ? 3419246786u : 3878512697u);
							continue;
						case 8u:
							goto IL_107;
						case 9u:
							num++;
							arg_AF_0 = 4007410049u;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:
				return;
				IL_EB:
				throw this.reader.CreateException(JsonTokenizer.JsonTextTokenizer.smethod_8(Module.smethod_34<string>(2084068847u), text));
				IL_107:
				throw this.reader.CreateException(JsonTokenizer.JsonTextTokenizer.smethod_8(Module.smethod_33<string>(2183601119u), text));
			}

			private double ReadNumber(char initialCharacter)
			{
				StringBuilder stringBuilder = JsonTokenizer.JsonTextTokenizer.smethod_3();
				while (true)
				{
					IL_335:
					uint arg_2BB_0 = 3428734534u;
					while (true)
					{
						uint num;
						int? arg_280_0;
						int? arg_10B_0;
						bool arg_24C_0;
						int? num3;
						int num4;
						int? arg_94_0;
						bool arg_DE_0;
						bool arg_6D_0;
						switch ((num = (arg_2BB_0 ^ 3927575223u)) % 27u)
						{
						case 0u:
						{
							int? num2;
							arg_280_0 = num2;
							goto IL_280;
						}
						case 1u:
						{
							int? num2 = null;
							arg_2BB_0 = (num * 1586604714u ^ 3961031747u);
							continue;
						}
						case 2u:
						{
							char? c2;
							char? c = c2;
							arg_2BB_0 = (num * 3822594773u ^ 852107585u);
							continue;
						}
						case 3u:
						{
							char? c;
							if (!c.HasValue)
							{
								arg_2BB_0 = (num * 465742550u ^ 3416447339u);
								continue;
							}
							arg_280_0 = new int?((int)c.GetValueOrDefault());
							goto IL_280;
						}
						case 4u:
						{
							IL_EA:
							char? c2;
							char? c = c2;
							if (!c.HasValue)
							{
								arg_2BB_0 = 2724569965u;
								continue;
							}
							arg_10B_0 = new int?((int)c.GetValueOrDefault());
							goto IL_10B;
						}
						case 5u:
							goto IL_335;
						case 6u:
							arg_24C_0 = false;
							goto IL_24C;
						case 7u:
							if (num3.GetValueOrDefault() != num4)
							{
								arg_2BB_0 = (num * 1885808447u ^ 2657365177u);
								continue;
							}
							arg_24C_0 = num3.HasValue;
							goto IL_24C;
						case 8u:
							JsonTokenizer.JsonTextTokenizer.smethod_11(stringBuilder, Module.smethod_35<string>(1735569063u));
							arg_2BB_0 = (num * 1242346118u ^ 1050600342u);
							continue;
						case 9u:
						{
							char? c2 = this.ReadFrac(stringBuilder);
							arg_2BB_0 = (num * 3770122022u ^ 2562161041u);
							continue;
						}
						case 10u:
						{
							IL_79:
							char? c2 = this.ReadExp(stringBuilder);
							arg_2BB_0 = 4147365055u;
							continue;
						}
						case 11u:
						{
							int? num2 = null;
							arg_2BB_0 = (num * 2951998524u ^ 2318018128u);
							continue;
						}
						case 12u:
						{
							char? c;
							if (!c.HasValue)
							{
								arg_2BB_0 = (num * 3387693675u ^ 1621036160u);
								continue;
							}
							arg_94_0 = new int?((int)c.GetValueOrDefault());
							goto IL_94;
						}
						case 13u:
							arg_DE_0 = false;
							goto IL_DE;
						case 14u:
						{
							int? num2;
							arg_10B_0 = num2;
							goto IL_10B;
						}
						case 15u:
						{
							char? c2;
							this.reader.PushBack(c2.Value);
							arg_2BB_0 = (num * 3535000700u ^ 2130462297u);
							continue;
						}
						case 16u:
							num4 = 69;
							arg_2BB_0 = (num * 2075355319u ^ 2753586756u);
							continue;
						case 17u:
							this.reader.PushBack(initialCharacter);
							arg_2BB_0 = 2364013152u;
							continue;
						case 18u:
							if (num3.GetValueOrDefault() != num4)
							{
								arg_2BB_0 = (num * 4033526008u ^ 732759247u);
								continue;
							}
							arg_6D_0 = num3.HasValue;
							goto IL_6D;
						case 19u:
							num4 = 46;
							if (num3.GetValueOrDefault() != 46)
							{
								arg_2BB_0 = (num * 2416914792u ^ 3273315036u);
								continue;
							}
							arg_DE_0 = num3.HasValue;
							goto IL_DE;
						case 20u:
						{
							char? c2;
							char? c = c2;
							arg_2BB_0 = (num * 1103274222u ^ 1981349786u);
							continue;
						}
						case 21u:
						{
							int? num2 = null;
							arg_94_0 = num2;
							goto IL_94;
						}
						case 22u:
							arg_6D_0 = false;
							goto IL_6D;
						case 23u:
						{
							IL_47:
							char? c2;
							arg_2BB_0 = ((!c2.HasValue) ? 3934159273u : 3011508275u);
							continue;
						}
						case 24u:
						{
							char? c2 = this.ReadInt(stringBuilder);
							arg_2BB_0 = 2561948362u;
							continue;
						}
						case 25u:
							arg_2BB_0 = (((initialCharacter == '-') ? 3554109322u : 2353928084u) ^ num * 65242644u);
							continue;
						}
						goto Block_12;
						IL_24C:
						if (arg_24C_0)
						{
							arg_2BB_0 = 2323792816u;
							continue;
						}
						goto IL_47;
						IL_6D:
						if (!arg_6D_0)
						{
							arg_2BB_0 = 2367946797u;
							continue;
						}
						goto IL_79;
						IL_94:
						num3 = arg_94_0;
						arg_2BB_0 = 4251868856u;
						continue;
						IL_DE:
						if (arg_DE_0)
						{
							arg_2BB_0 = 3425460158u;
							continue;
						}
						goto IL_EA;
						IL_10B:
						num3 = arg_10B_0;
						num4 = 101;
						arg_2BB_0 = 3746874534u;
						continue;
						IL_280:
						num3 = arg_280_0;
						arg_2BB_0 = 3391648321u;
					}
				}
				Block_12:
				double result;
				try
				{
					result = double.Parse(JsonTokenizer.JsonTextTokenizer.smethod_6(stringBuilder), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, JsonTokenizer.JsonTextTokenizer.smethod_4());
				}
				catch (OverflowException)
				{
					throw this.reader.CreateException(JsonTokenizer.JsonTextTokenizer.smethod_2(Module.smethod_34<string>(4278420801u), stringBuilder));
				}
				return result;
			}

			private char? ReadInt(StringBuilder builder)
			{
				char c = this.reader.ReadOrFail(Module.smethod_34<string>(2966108233u));
				if (c >= '0')
				{
					while (true)
					{
						IL_62:
						uint arg_46_0 = 690750146u;
						while (true)
						{
							uint num;
							switch ((num = (arg_46_0 ^ 1624767232u)) % 4u)
							{
							case 0u:
								goto IL_62;
							case 2u:
								arg_46_0 = (((c <= '9') ? 2667681701u : 3557724311u) ^ num * 3973277460u);
								continue;
							case 3u:
								goto IL_98;
							}
							goto Block_3;
						}
					}
					Block_3:
					JsonTokenizer.JsonTextTokenizer.smethod_7(builder, c);
					int num2;
					char? arg_AE_0 = this.ConsumeDigits(builder, out num2);
					if (c == '0' && num2 != 0)
					{
						throw this.reader.CreateException(Module.smethod_33<string>(55083386u));
					}
					return arg_AE_0;
				}
				IL_98:
				throw this.reader.CreateException(Module.smethod_34<string>(2966108233u));
			}

			private char? ReadFrac(StringBuilder builder)
			{
				JsonTokenizer.JsonTextTokenizer.smethod_7(builder, '.');
				int num;
				char? arg_2B_0 = this.ConsumeDigits(builder, out num);
				if (num == 0)
				{
					throw this.reader.CreateException(Module.smethod_35<string>(392891160u));
				}
				return arg_2B_0;
			}

			private char? ReadExp(StringBuilder builder)
			{
				JsonTokenizer.JsonTextTokenizer.smethod_7(builder, 'E');
				char? c = this.reader.Read();
				if (!c.HasValue)
				{
					goto IL_1A4;
				}
				goto IL_21C;
				uint arg_1BE_0;
				char? c2;
				while (true)
				{
					IL_1B9:
					uint num;
					int? arg_A6_0;
					int? arg_172_0;
					bool arg_12A_0;
					int? num4;
					bool arg_B2_0;
					switch ((num = (arg_1BE_0 ^ 1452476557u)) % 20u)
					{
					case 0u:
						IL_BE:
						this.reader.PushBack(c.Value);
						arg_1BE_0 = 1026790028u;
						continue;
					case 1u:
						goto IL_225;
					case 2u:
					{
						int? num2 = null;
						arg_A6_0 = num2;
						goto IL_A6;
					}
					case 3u:
						goto IL_1A4;
					case 5u:
					{
						int num3 = 45;
						arg_1BE_0 = (num * 513620110u ^ 1041112062u);
						continue;
					}
					case 6u:
						goto IL_21C;
					case 7u:
					{
						int? num2;
						arg_172_0 = num2;
						goto IL_172;
					}
					case 8u:
						arg_12A_0 = false;
						goto IL_12A;
					case 9u:
						arg_1BE_0 = (num * 1271940519u ^ 1122894535u);
						continue;
					case 10u:
						c2 = c;
						if (!c2.HasValue)
						{
							arg_1BE_0 = (num * 2915296724u ^ 772849874u);
							continue;
						}
						arg_172_0 = new int?((int)c2.GetValueOrDefault());
						goto IL_172;
					case 11u:
						IL_136:
						JsonTokenizer.JsonTextTokenizer.smethod_7(builder, c.Value);
						arg_1BE_0 = 1064449072u;
						continue;
					case 12u:
						goto IL_23B;
					case 13u:
					{
						int num3;
						if (num4.GetValueOrDefault() != num3)
						{
							arg_1BE_0 = (num * 4133245891u ^ 3311303066u);
							continue;
						}
						arg_12A_0 = num4.HasValue;
						goto IL_12A;
					}
					case 14u:
					{
						int num3 = 43;
						if (num4.GetValueOrDefault() != 43)
						{
							arg_1BE_0 = (num * 2037214372u ^ 2231304710u);
							continue;
						}
						arg_B2_0 = num4.HasValue;
						goto IL_B2;
					}
					case 15u:
						arg_B2_0 = false;
						goto IL_B2;
					case 16u:
						if (!c2.HasValue)
						{
							arg_1BE_0 = (num * 1423660325u ^ 3552384875u);
							continue;
						}
						arg_A6_0 = new int?((int)c2.GetValueOrDefault());
						goto IL_A6;
					case 17u:
					{
						int num5;
						c = this.ConsumeDigits(builder, out num5);
						arg_1BE_0 = 1148111359u;
						continue;
					}
					case 18u:
					{
						int num5;
						arg_1BE_0 = (((num5 == 0) ? 3507790385u : 4190769701u) ^ num * 1492411848u);
						continue;
					}
					case 19u:
					{
						int? num2 = null;
						arg_1BE_0 = (num * 1089365034u ^ 3166610304u);
						continue;
					}
					}
					break;
					IL_A6:
					num4 = arg_A6_0;
					arg_1BE_0 = 162673416u;
					continue;
					IL_B2:
					if (arg_B2_0)
					{
						arg_1BE_0 = 497826230u;
						continue;
					}
					goto IL_BE;
					IL_12A:
					if (!arg_12A_0)
					{
						arg_1BE_0 = 1084111467u;
						continue;
					}
					goto IL_136;
					IL_172:
					num4 = arg_172_0;
					arg_1BE_0 = 2023662975u;
				}
				return c;
				IL_225:
				throw this.reader.CreateException(Module.smethod_35<string>(2365453992u));
				IL_23B:
				throw this.reader.CreateException(Module.smethod_37<string>(2975595932u));
				IL_1A4:
				arg_1BE_0 = 2143502108u;
				goto IL_1B9;
				IL_21C:
				c2 = c;
				arg_1BE_0 = 1301372849u;
				goto IL_1B9;
			}

			private char? ConsumeDigits(StringBuilder builder, out int count)
			{
				count = 0;
				char? result;
				while (true)
				{
					IL_ED:
					uint arg_BE_0 = 3951464437u;
					while (true)
					{
						uint num;
						switch ((num = (arg_BE_0 ^ 2644738753u)) % 8u)
						{
						case 0u:
							arg_BE_0 = (((!result.HasValue) ? 2395340546u : 2736623126u) ^ num * 4031030723u);
							continue;
						case 1u:
							arg_BE_0 = (((result.Value > '9') ? 487804024u : 980450185u) ^ num * 274626106u);
							continue;
						case 2u:
							count++;
							arg_BE_0 = 3565798471u;
							continue;
						case 3u:
							return result;
						case 4u:
							break;
						case 5u:
							goto IL_ED;
						case 6u:
							goto IL_37;
						case 7u:
							arg_BE_0 = (((result.Value >= '0') ? 2236503732u : 3617672102u) ^ num * 961368668u);
							continue;
						default:
							goto IL_37;
						}
						IL_45:
						result = this.reader.Read();
						arg_BE_0 = 3677530081u;
						continue;
						IL_37:
						JsonTokenizer.JsonTextTokenizer.smethod_7(builder, result.Value);
						goto IL_45;
					}
				}
				return result;
			}

			private void ValidateAndModifyStateForValue(string errorPrefix)
			{
				this.ValidateState(JsonTokenizer.JsonTextTokenizer.ValueStates, errorPrefix);
				JsonTokenizer.JsonTextTokenizer.State state = this.state;
				while (true)
				{
					IL_14F:
					uint arg_10E_0 = 3430627113u;
					while (true)
					{
						uint num;
						switch ((num = (arg_10E_0 ^ 4234330315u)) % 13u)
						{
						case 0u:
							arg_10E_0 = (num * 2103314050u ^ 4217759484u);
							continue;
						case 2u:
							goto IL_14F;
						case 3u:
							goto IL_166;
						case 4u:
							arg_10E_0 = (((state != JsonTokenizer.JsonTextTokenizer.State.ArrayAfterComma) ? 4203480299u : 2258613579u) ^ num * 3796198173u);
							continue;
						case 5u:
							arg_10E_0 = (((state == JsonTokenizer.JsonTextTokenizer.State.StartOfDocument) ? 1553897359u : 1279355368u) ^ num * 1651647674u);
							continue;
						case 6u:
							arg_10E_0 = (((state == JsonTokenizer.JsonTextTokenizer.State.ObjectAfterColon) ? 115129714u : 514500073u) ^ num * 1869021165u);
							continue;
						case 7u:
							this.state = JsonTokenizer.JsonTextTokenizer.State.ExpectedEndOfDocument;
							arg_10E_0 = 2844930869u;
							continue;
						case 8u:
							arg_10E_0 = ((state == JsonTokenizer.JsonTextTokenizer.State.ArrayStart) ? 3449997873u : 3347045001u);
							continue;
						case 9u:
							return;
						case 10u:
							goto IL_173;
						case 11u:
							arg_10E_0 = (((state > JsonTokenizer.JsonTextTokenizer.State.ObjectAfterColon) ? 1100180620u : 587742203u) ^ num * 711010174u);
							continue;
						case 12u:
							arg_10E_0 = (num * 2736823529u ^ 2303030765u);
							continue;
						}
						goto Block_6;
					}
				}
				Block_6:
				throw JsonTokenizer.JsonTextTokenizer.smethod_1(Module.smethod_36<string>(4006575829u));
				IL_166:
				this.state = JsonTokenizer.JsonTextTokenizer.State.ArrayAfterValue;
				return;
				IL_173:
				this.state = JsonTokenizer.JsonTextTokenizer.State.ObjectAfterProperty;
			}

			private void PopContainer()
			{
				this.containerStack.Pop();
				JsonTokenizer.JsonTextTokenizer.ContainerType containerType = this.containerStack.Peek();
				uint arg_45_0;
				switch (containerType)
				{
				case JsonTokenizer.JsonTextTokenizer.ContainerType.Document:
					IL_6D:
					this.state = JsonTokenizer.JsonTextTokenizer.State.ExpectedEndOfDocument;
					arg_45_0 = 1207811057u;
					break;
				case JsonTokenizer.JsonTextTokenizer.ContainerType.Object:
					IL_97:
					this.state = JsonTokenizer.JsonTextTokenizer.State.ObjectAfterProperty;
					return;
				case JsonTokenizer.JsonTextTokenizer.ContainerType.Array:
					IL_A0:
					this.state = JsonTokenizer.JsonTextTokenizer.State.ArrayAfterValue;
					return;
				default:
					goto IL_3B;
				}
				while (true)
				{
					IL_40:
					uint num;
					switch ((num = (arg_45_0 ^ 514295036u)) % 7u)
					{
					case 0u:
						goto IL_3B;
					case 1u:
						goto IL_97;
					case 2u:
						return;
					case 4u:
						goto IL_A0;
					case 5u:
						arg_45_0 = (num * 2509268472u ^ 3261285597u);
						continue;
					case 6u:
						goto IL_6D;
					}
					break;
				}
				throw JsonTokenizer.JsonTextTokenizer.smethod_1(JsonTokenizer.JsonTextTokenizer.smethod_2(Module.smethod_33<string>(157176394u), containerType));
				IL_3B:
				arg_45_0 = 716639050u;
				goto IL_40;
			}

			static InvalidOperationException smethod_1(string string_0)
			{
				return new InvalidOperationException(string_0);
			}

			static string smethod_2(object object_0, object object_1)
			{
				return object_0 + object_1;
			}

			static StringBuilder smethod_3()
			{
				return new StringBuilder();
			}

			static CultureInfo smethod_4()
			{
				return CultureInfo.InvariantCulture;
			}

			static string smethod_5(IFormatProvider iformatProvider_0, string string_0, object[] object_0)
			{
				return string.Format(iformatProvider_0, string_0, object_0);
			}

			static string smethod_6(object object_0)
			{
				return object_0.ToString();
			}

			static StringBuilder smethod_7(StringBuilder stringBuilder_0, char char_0)
			{
				return stringBuilder_0.Append(char_0);
			}

			static string smethod_8(string string_0, string string_1)
			{
				return string_0 + string_1;
			}

			static char smethod_9(string string_0, int int_0)
			{
				return string_0[int_0];
			}

			static int smethod_10(string string_0)
			{
				return string_0.Length;
			}

			static StringBuilder smethod_11(StringBuilder stringBuilder_0, string string_0)
			{
				return stringBuilder_0.Append(string_0);
			}
		}

		private JsonToken bufferedToken;

		internal int ObjectDepth
		{
			get;
			private set;
		}

		internal static JsonTokenizer FromTextReader(TextReader reader)
		{
			return new JsonTokenizer.JsonTextTokenizer(reader);
		}

		internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation)
		{
			return new JsonTokenizer.JsonReplayTokenizer(tokens, continuation);
		}

		internal void PushBack(JsonToken token)
		{
			if (this.bufferedToken != null)
			{
				goto IL_55;
			}
			goto IL_E9;
			uint arg_A5_0;
			while (true)
			{
				IL_A0:
				uint num;
				switch ((num = (arg_A5_0 ^ 1095103441u)) % 10u)
				{
				case 0u:
				{
					int objectDepth;
					this.ObjectDepth = objectDepth + 1;
					arg_A5_0 = (num * 3220692062u ^ 2789066209u);
					continue;
				}
				case 1u:
					goto IL_FE;
				case 2u:
				{
					int objectDepth = this.ObjectDepth;
					arg_A5_0 = (num * 3962606672u ^ 722860213u);
					continue;
				}
				case 3u:
					return;
				case 4u:
				{
					int objectDepth;
					this.ObjectDepth = objectDepth - 1;
					arg_A5_0 = (num * 3751611531u ^ 1773678302u);
					continue;
				}
				case 5u:
					goto IL_55;
				case 6u:
					arg_A5_0 = ((token.Type == JsonToken.TokenType.EndObject) ? 620316280u : 129698317u);
					continue;
				case 7u:
					goto IL_E9;
				case 9u:
				{
					int objectDepth = this.ObjectDepth;
					arg_A5_0 = (num * 529432075u ^ 1218121848u);
					continue;
				}
				}
				break;
			}
			return;
			IL_FE:
			throw JsonTokenizer.smethod_0(Module.smethod_37<string>(2099213936u));
			IL_55:
			arg_A5_0 = 1385124762u;
			goto IL_A0;
			IL_E9:
			this.bufferedToken = token;
			arg_A5_0 = ((token.Type != JsonToken.TokenType.StartObject) ? 443914991u : 1555337421u);
			goto IL_A0;
		}

		internal JsonToken Next()
		{
			if (this.bufferedToken != null)
			{
				goto IL_E2;
			}
			goto IL_125;
			uint arg_EC_0;
			JsonToken jsonToken;
			while (true)
			{
				IL_E7:
				uint num;
				switch ((num = (arg_EC_0 ^ 3450593029u)) % 11u)
				{
				case 0u:
					goto IL_E2;
				case 1u:
				{
					int objectDepth = this.ObjectDepth;
					arg_EC_0 = (num * 2880460023u ^ 777687680u);
					continue;
				}
				case 2u:
				{
					int objectDepth = this.ObjectDepth;
					this.ObjectDepth = objectDepth + 1;
					arg_EC_0 = (num * 987853680u ^ 819751387u);
					continue;
				}
				case 3u:
				{
					int objectDepth;
					this.ObjectDepth = objectDepth - 1;
					arg_EC_0 = (num * 3554561161u ^ 770806806u);
					continue;
				}
				case 4u:
					arg_EC_0 = (num * 1647000435u ^ 4198112770u);
					continue;
				case 5u:
					this.bufferedToken = null;
					arg_EC_0 = (num * 1663122805u ^ 980987310u);
					continue;
				case 7u:
					arg_EC_0 = ((jsonToken.Type != JsonToken.TokenType.StartObject) ? 3594187970u : 2617038862u);
					continue;
				case 8u:
					arg_EC_0 = ((jsonToken.Type != JsonToken.TokenType.EndObject) ? 3157552139u : 2794562581u);
					continue;
				case 9u:
					jsonToken = this.bufferedToken;
					arg_EC_0 = (num * 1617573968u ^ 3761570439u);
					continue;
				case 10u:
					goto IL_125;
				}
				break;
			}
			return jsonToken;
			IL_E2:
			arg_EC_0 = 3957548835u;
			goto IL_E7;
			IL_125:
			jsonToken = this.NextImpl();
			arg_EC_0 = 3187922577u;
			goto IL_E7;
		}

		protected abstract JsonToken NextImpl();

		static InvalidOperationException smethod_0(string string_0)
		{
			return new InvalidOperationException(string_0);
		}
	}
}
