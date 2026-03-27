#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class PayloadSchemaParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.PayloadSchemaParams>
    {
        /// <inheritdoc />
        public override global::Qdrant.PayloadSchemaParams Read(
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
            if (__jsonProps.Contains("enable_hnsw")) __score0++;
            if (__jsonProps.Contains("is_tenant")) __score0++;
            if (__jsonProps.Contains("on_disk")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("enable_hnsw")) __score1++;
            if (__jsonProps.Contains("is_principal")) __score1++;
            if (__jsonProps.Contains("lookup")) __score1++;
            if (__jsonProps.Contains("on_disk")) __score1++;
            if (__jsonProps.Contains("range")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("enable_hnsw")) __score2++;
            if (__jsonProps.Contains("is_principal")) __score2++;
            if (__jsonProps.Contains("on_disk")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("enable_hnsw")) __score3++;
            if (__jsonProps.Contains("on_disk")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("ascii_folding")) __score4++;
            if (__jsonProps.Contains("enable_hnsw")) __score4++;
            if (__jsonProps.Contains("lowercase")) __score4++;
            if (__jsonProps.Contains("max_token_len")) __score4++;
            if (__jsonProps.Contains("min_token_len")) __score4++;
            if (__jsonProps.Contains("on_disk")) __score4++;
            if (__jsonProps.Contains("phrase_matching")) __score4++;
            if (__jsonProps.Contains("stemmer")) __score4++;
            if (__jsonProps.Contains("stopwords")) __score4++;
            if (__jsonProps.Contains("tokenizer")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("enable_hnsw")) __score5++;
            if (__jsonProps.Contains("on_disk")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("enable_hnsw")) __score6++;
            if (__jsonProps.Contains("is_principal")) __score6++;
            if (__jsonProps.Contains("on_disk")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("enable_hnsw")) __score7++;
            if (__jsonProps.Contains("is_tenant")) __score7++;
            if (__jsonProps.Contains("on_disk")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::Qdrant.KeywordIndexParams? keywordIndex = default;
            global::Qdrant.IntegerIndexParams? integerIndex = default;
            global::Qdrant.FloatIndexParams? floatIndex = default;
            global::Qdrant.GeoIndexParams? geoIndex = default;
            global::Qdrant.TextIndexParams? textIndex = default;
            global::Qdrant.BoolIndexParams? boolIndex = default;
            global::Qdrant.DatetimeIndexParams? datetimeIndex = default;
            global::Qdrant.UuidIndexParams? uuidIndex = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.KeywordIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.KeywordIndexParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.KeywordIndexParams).Name}");
                        keywordIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IntegerIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IntegerIndexParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IntegerIndexParams).Name}");
                        integerIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FloatIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FloatIndexParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FloatIndexParams).Name}");
                        floatIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.GeoIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.GeoIndexParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.GeoIndexParams).Name}");
                        geoIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.TextIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.TextIndexParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.TextIndexParams).Name}");
                        textIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.BoolIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.BoolIndexParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.BoolIndexParams).Name}");
                        boolIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DatetimeIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DatetimeIndexParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DatetimeIndexParams).Name}");
                        datetimeIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UuidIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UuidIndexParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UuidIndexParams).Name}");
                        uuidIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (keywordIndex == null && integerIndex == null && floatIndex == null && geoIndex == null && textIndex == null && boolIndex == null && datetimeIndex == null && uuidIndex == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.KeywordIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.KeywordIndexParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.KeywordIndexParams).Name}");
                    keywordIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IntegerIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IntegerIndexParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IntegerIndexParams).Name}");
                    integerIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FloatIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FloatIndexParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FloatIndexParams).Name}");
                    floatIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.GeoIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.GeoIndexParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.GeoIndexParams).Name}");
                    geoIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.TextIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.TextIndexParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.TextIndexParams).Name}");
                    textIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.BoolIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.BoolIndexParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.BoolIndexParams).Name}");
                    boolIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DatetimeIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DatetimeIndexParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DatetimeIndexParams).Name}");
                    datetimeIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UuidIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UuidIndexParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UuidIndexParams).Name}");
                    uuidIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.PayloadSchemaParams(
                keywordIndex,

                integerIndex,

                floatIndex,

                geoIndex,

                textIndex,

                boolIndex,

                datetimeIndex,

                uuidIndex
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.PayloadSchemaParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsKeywordIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.KeywordIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.KeywordIndexParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.KeywordIndexParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KeywordIndex, typeInfo);
            }
            else if (value.IsIntegerIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IntegerIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IntegerIndexParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IntegerIndexParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IntegerIndex, typeInfo);
            }
            else if (value.IsFloatIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FloatIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FloatIndexParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FloatIndexParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FloatIndex, typeInfo);
            }
            else if (value.IsGeoIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.GeoIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.GeoIndexParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.GeoIndexParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeoIndex, typeInfo);
            }
            else if (value.IsTextIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.TextIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.TextIndexParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.TextIndexParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextIndex, typeInfo);
            }
            else if (value.IsBoolIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.BoolIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.BoolIndexParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.BoolIndexParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BoolIndex, typeInfo);
            }
            else if (value.IsDatetimeIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DatetimeIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DatetimeIndexParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DatetimeIndexParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DatetimeIndex, typeInfo);
            }
            else if (value.IsUuidIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UuidIndexParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UuidIndexParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UuidIndexParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UuidIndex, typeInfo);
            }
        }
    }
}