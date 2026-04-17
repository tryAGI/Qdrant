#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class MatchConditionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.MatchCondition>
    {
        /// <inheritdoc />
        public override global::Qdrant.MatchCondition Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("text")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("text_any")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("phrase")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("any")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("except")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Qdrant.MatchValue? value = default;
            global::Qdrant.MatchText? text = default;
            global::Qdrant.MatchTextAny? textAny = default;
            global::Qdrant.MatchPhrase? phrase = default;
            global::Qdrant.MatchAny? any = default;
            global::Qdrant.MatchExcept? except = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchValue).Name}");
                        value = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchText).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchTextAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchTextAny> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchTextAny).Name}");
                        textAny = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchPhrase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchPhrase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchPhrase).Name}");
                        phrase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchAny> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchAny).Name}");
                        any = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchExcept> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchExcept).Name}");
                        except = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value == null && text == null && textAny == null && phrase == null && any == null && except == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchValue).Name}");
                    value = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchText).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchTextAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchTextAny> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchTextAny).Name}");
                    textAny = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchPhrase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchPhrase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchPhrase).Name}");
                    phrase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchAny> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchAny).Name}");
                    any = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchExcept> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchExcept).Name}");
                    except = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.MatchCondition(
                value,

                text,

                textAny,

                phrase,

                any,

                except
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.MatchCondition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsTextAny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchTextAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchTextAny?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchTextAny).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextAny!, typeInfo);
            }
            else if (value.IsPhrase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchPhrase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchPhrase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchPhrase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Phrase!, typeInfo);
            }
            else if (value.IsAny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchAny?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchAny).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any!, typeInfo);
            }
            else if (value.IsExcept)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MatchExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MatchExcept?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MatchExcept).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Except!, typeInfo);
            }
        }
    }
}