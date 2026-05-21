#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class LowMemoryModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.LowMemoryMode>
    {
        /// <inheritdoc />
        public override global::Qdrant.LowMemoryMode Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant1), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant2), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant3), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Qdrant.LowMemoryModeVariant1? lowMemoryModeVariant1 = default;
            global::Qdrant.LowMemoryModeVariant2? lowMemoryModeVariant2 = default;
            global::Qdrant.LowMemoryModeVariant3? lowMemoryModeVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant1).Name}");
                        lowMemoryModeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant2).Name}");
                        lowMemoryModeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant3).Name}");
                        lowMemoryModeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (lowMemoryModeVariant1 == null && lowMemoryModeVariant2 == null && lowMemoryModeVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant1).Name}");
                    lowMemoryModeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (lowMemoryModeVariant1 == null && lowMemoryModeVariant2 == null && lowMemoryModeVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant2).Name}");
                    lowMemoryModeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (lowMemoryModeVariant1 == null && lowMemoryModeVariant2 == null && lowMemoryModeVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant3).Name}");
                    lowMemoryModeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.LowMemoryMode(
                lowMemoryModeVariant1,

                lowMemoryModeVariant2,

                lowMemoryModeVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.LowMemoryMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLowMemoryModeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LowMemoryModeVariant1!.Value, typeInfo);
            }
            else if (value.IsLowMemoryModeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LowMemoryModeVariant2!.Value, typeInfo);
            }
            else if (value.IsLowMemoryModeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.LowMemoryModeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.LowMemoryModeVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.LowMemoryModeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LowMemoryModeVariant3!.Value, typeInfo);
            }
        }
    }
}