#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class StopwordsInterfaceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.StopwordsInterface>
    {
        /// <inheritdoc />
        public override global::Qdrant.StopwordsInterface Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("custom")) __score1++;
            if (__jsonProps.Contains("languages")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Qdrant.Language? language = default;
            global::Qdrant.StopwordsSet? set = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.Language), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.Language> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.Language).Name}");
                        language = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.StopwordsSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.StopwordsSet> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.StopwordsSet).Name}");
                        set = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (language == null && set == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.Language), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.Language> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.Language).Name}");
                    language = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.StopwordsSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.StopwordsSet> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.StopwordsSet).Name}");
                    set = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.StopwordsInterface(
                language,

                set
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.StopwordsInterface value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLanguage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.Language), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.Language> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.Language).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Language!.Value, typeInfo);
            }
            else if (value.IsSet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.StopwordsSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.StopwordsSet?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.StopwordsSet).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Set!, typeInfo);
            }
        }
    }
}