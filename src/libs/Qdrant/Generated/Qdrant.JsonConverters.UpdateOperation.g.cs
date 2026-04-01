#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class UpdateOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.UpdateOperation>
    {
        /// <inheritdoc />
        public override global::Qdrant.UpdateOperation Read(
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
            if (__jsonProps.Contains("upsert")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("delete")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("set_payload")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("overwrite_payload")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delete_payload")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("clear_payload")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("update_vectors")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("delete_vectors")) __score7++;
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

            global::Qdrant.UpsertOperation? upsert = default;
            global::Qdrant.DeleteOperation? delete = default;
            global::Qdrant.SetPayloadOperation? setPayload = default;
            global::Qdrant.OverwritePayloadOperation? overwritePayload = default;
            global::Qdrant.DeletePayloadOperation? deletePayload = default;
            global::Qdrant.ClearPayloadOperation? clearPayload = default;
            global::Qdrant.UpdateVectorsOperation? vectors = default;
            global::Qdrant.DeleteVectorsOperation? deleteVectors = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UpsertOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UpsertOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UpsertOperation).Name}");
                        upsert = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeleteOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeleteOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeleteOperation).Name}");
                        delete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.SetPayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.SetPayloadOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.SetPayloadOperation).Name}");
                        setPayload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.OverwritePayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.OverwritePayloadOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.OverwritePayloadOperation).Name}");
                        overwritePayload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeletePayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeletePayloadOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeletePayloadOperation).Name}");
                        deletePayload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ClearPayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ClearPayloadOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ClearPayloadOperation).Name}");
                        clearPayload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UpdateVectorsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UpdateVectorsOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UpdateVectorsOperation).Name}");
                        vectors = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeleteVectorsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeleteVectorsOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeleteVectorsOperation).Name}");
                        deleteVectors = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (upsert == null && delete == null && setPayload == null && overwritePayload == null && deletePayload == null && clearPayload == null && vectors == null && deleteVectors == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UpsertOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UpsertOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UpsertOperation).Name}");
                    upsert = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeleteOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeleteOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeleteOperation).Name}");
                    delete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.SetPayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.SetPayloadOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.SetPayloadOperation).Name}");
                    setPayload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.OverwritePayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.OverwritePayloadOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.OverwritePayloadOperation).Name}");
                    overwritePayload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeletePayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeletePayloadOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeletePayloadOperation).Name}");
                    deletePayload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ClearPayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ClearPayloadOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ClearPayloadOperation).Name}");
                    clearPayload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UpdateVectorsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UpdateVectorsOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UpdateVectorsOperation).Name}");
                    vectors = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeleteVectorsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeleteVectorsOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeleteVectorsOperation).Name}");
                    deleteVectors = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.UpdateOperation(
                upsert,

                delete,

                setPayload,

                overwritePayload,

                deletePayload,

                clearPayload,

                vectors,

                deleteVectors
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.UpdateOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUpsert)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UpsertOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UpsertOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UpsertOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Upsert!, typeInfo);
            }
            else if (value.IsDelete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeleteOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeleteOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeleteOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delete!, typeInfo);
            }
            else if (value.IsSetPayload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.SetPayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.SetPayloadOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.SetPayloadOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SetPayload!, typeInfo);
            }
            else if (value.IsOverwritePayload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.OverwritePayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.OverwritePayloadOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.OverwritePayloadOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverwritePayload!, typeInfo);
            }
            else if (value.IsDeletePayload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeletePayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeletePayloadOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeletePayloadOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeletePayload!, typeInfo);
            }
            else if (value.IsClearPayload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ClearPayloadOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ClearPayloadOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ClearPayloadOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClearPayload!, typeInfo);
            }
            else if (value.IsVectors)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.UpdateVectorsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.UpdateVectorsOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.UpdateVectorsOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vectors!, typeInfo);
            }
            else if (value.IsDeleteVectors)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DeleteVectorsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DeleteVectorsOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DeleteVectorsOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteVectors!, typeInfo);
            }
        }
    }
}