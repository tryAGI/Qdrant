#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class PointsSelectorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.PointsSelector>
    {
        /// <inheritdoc />
        public override global::Qdrant.PointsSelector Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("points")) __score0++;
            if (__jsonProps.Contains("shard_key")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("filter")) __score1++;
            if (__jsonProps.Contains("filter.min_should")) __score1++;
            if (__jsonProps.Contains("filter.must")) __score1++;
            if (__jsonProps.Contains("filter.must_not")) __score1++;
            if (__jsonProps.Contains("filter.should")) __score1++;
            if (__jsonProps.Contains("shard_key")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Qdrant.PointIdsList? pointIdsList = default;
            global::Qdrant.FilterSelector? filter = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.PointIdsList), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.PointIdsList> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.PointIdsList).Name}");
                        pointIdsList = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FilterSelector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FilterSelector> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FilterSelector).Name}");
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

            if (pointIdsList == null && filter == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.PointIdsList), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.PointIdsList> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.PointIdsList).Name}");
                    pointIdsList = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FilterSelector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FilterSelector> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FilterSelector).Name}");
                    filter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.PointsSelector(
                pointIdsList,

                filter
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.PointsSelector value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPointIdsList)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.PointIdsList), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.PointIdsList?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.PointIdsList).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PointIdsList!, typeInfo);
            }
            else if (value.IsFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.FilterSelector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.FilterSelector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.FilterSelector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Filter!, typeInfo);
            }
        }
    }
}