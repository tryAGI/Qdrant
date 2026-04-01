#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class ConditionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.Condition>
    {
        /// <inheritdoc />
        public override global::Qdrant.Condition Read(
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
            if (__jsonProps.Contains("geo_bounding_box")) __score0++;
            if (__jsonProps.Contains("geo_polygon")) __score0++;
            if (__jsonProps.Contains("geo_radius")) __score0++;
            if (__jsonProps.Contains("is_empty")) __score0++;
            if (__jsonProps.Contains("is_null")) __score0++;
            if (__jsonProps.Contains("key")) __score0++;
            if (__jsonProps.Contains("match")) __score0++;
            if (__jsonProps.Contains("range")) __score0++;
            if (__jsonProps.Contains("values_count")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("is_empty")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("is_null")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("has_id")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("has_vector")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("nested")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("min_should")) __score6++;
            if (__jsonProps.Contains("must")) __score6++;
            if (__jsonProps.Contains("must_not")) __score6++;
            if (__jsonProps.Contains("should")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Qdrant.FieldCondition? field = default;
            global::Qdrant.IsEmptyCondition? isEmpty = default;
            global::Qdrant.IsNullCondition? isNull = default;
            global::Qdrant.HasIdCondition? hasId = default;
            global::Qdrant.HasVectorCondition? hasVector = default;
            global::Qdrant.NestedCondition? nested = default;
            global::Qdrant.Filter? filter = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FieldCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FieldCondition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FieldCondition).Name}");
                        field = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IsEmptyCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IsEmptyCondition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IsEmptyCondition).Name}");
                        isEmpty = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IsNullCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IsNullCondition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IsNullCondition).Name}");
                        isNull = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.HasIdCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.HasIdCondition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.HasIdCondition).Name}");
                        hasId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.HasVectorCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.HasVectorCondition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.HasVectorCondition).Name}");
                        hasVector = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.NestedCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.NestedCondition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.NestedCondition).Name}");
                        nested = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.Filter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.Filter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.Filter).Name}");
                        filter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (field == null && isEmpty == null && isNull == null && hasId == null && hasVector == null && nested == null && filter == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FieldCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FieldCondition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FieldCondition).Name}");
                    field = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IsEmptyCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IsEmptyCondition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IsEmptyCondition).Name}");
                    isEmpty = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IsNullCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IsNullCondition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IsNullCondition).Name}");
                    isNull = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.HasIdCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.HasIdCondition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.HasIdCondition).Name}");
                    hasId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.HasVectorCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.HasVectorCondition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.HasVectorCondition).Name}");
                    hasVector = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.NestedCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.NestedCondition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.NestedCondition).Name}");
                    nested = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.Filter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.Filter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.Filter).Name}");
                    filter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.Condition(
                field,

                isEmpty,

                isNull,

                hasId,

                hasVector,

                nested,

                filter
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.Condition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsField)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FieldCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FieldCondition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FieldCondition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Field!, typeInfo);
            }
            else if (value.IsIsEmpty)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IsEmptyCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IsEmptyCondition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IsEmptyCondition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IsEmpty!, typeInfo);
            }
            else if (value.IsIsNull)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.IsNullCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.IsNullCondition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.IsNullCondition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IsNull!, typeInfo);
            }
            else if (value.IsHasId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.HasIdCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.HasIdCondition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.HasIdCondition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HasId!, typeInfo);
            }
            else if (value.IsHasVector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.HasVectorCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.HasVectorCondition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.HasVectorCondition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HasVector!, typeInfo);
            }
            else if (value.IsNested)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.NestedCondition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.NestedCondition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.NestedCondition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Nested!, typeInfo);
            }
            else if (value.IsFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.Filter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.Filter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.Filter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Filter!, typeInfo);
            }
        }
    }
}