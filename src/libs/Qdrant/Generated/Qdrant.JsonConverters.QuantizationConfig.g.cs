#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class QuantizationConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.QuantizationConfig>
    {
        /// <inheritdoc />
        public override global::Qdrant.QuantizationConfig Read(
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
            if (__jsonProps.Contains("scalar")) __score0++;
            if (__jsonProps.Contains("scalar.always_ram")) __score0++;
            if (__jsonProps.Contains("scalar.quantile")) __score0++;
            if (__jsonProps.Contains("scalar.type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("product")) __score1++;
            if (__jsonProps.Contains("product.always_ram")) __score1++;
            if (__jsonProps.Contains("product.compression")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("binary")) __score2++;
            if (__jsonProps.Contains("binary.always_ram")) __score2++;
            if (__jsonProps.Contains("binary.encoding")) __score2++;
            if (__jsonProps.Contains("binary.query_encoding")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Qdrant.ScalarQuantization? scalar = default;
            global::Qdrant.ProductQuantization? product = default;
            global::Qdrant.BinaryQuantization? binary = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ScalarQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ScalarQuantization> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ScalarQuantization).Name}");
                        scalar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ProductQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ProductQuantization> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ProductQuantization).Name}");
                        product = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.BinaryQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.BinaryQuantization> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.BinaryQuantization).Name}");
                        binary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (scalar == null && product == null && binary == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ScalarQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ScalarQuantization> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ScalarQuantization).Name}");
                    scalar = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ProductQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ProductQuantization> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ProductQuantization).Name}");
                    product = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.BinaryQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.BinaryQuantization> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.BinaryQuantization).Name}");
                    binary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.QuantizationConfig(
                scalar,

                product,

                binary
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.QuantizationConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsScalar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ScalarQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ScalarQuantization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ScalarQuantization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Scalar!, typeInfo);
            }
            else if (value.IsProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ProductQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ProductQuantization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ProductQuantization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Product!, typeInfo);
            }
            else if (value.IsBinary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.BinaryQuantization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.BinaryQuantization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.BinaryQuantization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Binary!, typeInfo);
            }
        }
    }
}