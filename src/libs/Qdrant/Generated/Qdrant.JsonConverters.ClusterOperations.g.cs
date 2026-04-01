#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public class ClusterOperationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.ClusterOperations>
    {
        /// <inheritdoc />
        public override global::Qdrant.ClusterOperations Read(
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
            if (__jsonProps.Contains("move_shard")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("replicate_shard")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("abort_transfer")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("drop_replica")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("create_sharding_key")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("drop_sharding_key")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("restart_transfer")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("start_resharding")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("abort_resharding")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("replicate_points")) __score9++;
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
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::Qdrant.MoveShardOperation? moveShardOperation = default;
            global::Qdrant.ReplicateShardOperation? replicateShardOperation = default;
            global::Qdrant.AbortTransferOperation? abortTransferOperation = default;
            global::Qdrant.DropReplicaOperation? dropReplicaOperation = default;
            global::Qdrant.CreateShardingKeyOperation? createShardingKeyOperation = default;
            global::Qdrant.DropShardingKeyOperation? dropShardingKeyOperation = default;
            global::Qdrant.RestartTransferOperation? restartTransferOperation = default;
            global::Qdrant.StartReshardingOperation? startReshardingOperation = default;
            global::Qdrant.AbortReshardingOperation? abortReshardingOperation = default;
            global::Qdrant.ReplicatePointsOperation? replicatePointsOperation = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MoveShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MoveShardOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MoveShardOperation).Name}");
                        moveShardOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ReplicateShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ReplicateShardOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ReplicateShardOperation).Name}");
                        replicateShardOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.AbortTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.AbortTransferOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.AbortTransferOperation).Name}");
                        abortTransferOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DropReplicaOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DropReplicaOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DropReplicaOperation).Name}");
                        dropReplicaOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.CreateShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.CreateShardingKeyOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.CreateShardingKeyOperation).Name}");
                        createShardingKeyOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DropShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DropShardingKeyOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DropShardingKeyOperation).Name}");
                        dropShardingKeyOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.RestartTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.RestartTransferOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.RestartTransferOperation).Name}");
                        restartTransferOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.StartReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.StartReshardingOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.StartReshardingOperation).Name}");
                        startReshardingOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.AbortReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.AbortReshardingOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.AbortReshardingOperation).Name}");
                        abortReshardingOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ReplicatePointsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ReplicatePointsOperation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ReplicatePointsOperation).Name}");
                        replicatePointsOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (moveShardOperation == null && replicateShardOperation == null && abortTransferOperation == null && dropReplicaOperation == null && createShardingKeyOperation == null && dropShardingKeyOperation == null && restartTransferOperation == null && startReshardingOperation == null && abortReshardingOperation == null && replicatePointsOperation == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MoveShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MoveShardOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MoveShardOperation).Name}");
                    moveShardOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ReplicateShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ReplicateShardOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ReplicateShardOperation).Name}");
                    replicateShardOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.AbortTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.AbortTransferOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.AbortTransferOperation).Name}");
                    abortTransferOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DropReplicaOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DropReplicaOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DropReplicaOperation).Name}");
                    dropReplicaOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.CreateShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.CreateShardingKeyOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.CreateShardingKeyOperation).Name}");
                    createShardingKeyOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DropShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DropShardingKeyOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DropShardingKeyOperation).Name}");
                    dropShardingKeyOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.RestartTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.RestartTransferOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.RestartTransferOperation).Name}");
                    restartTransferOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.StartReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.StartReshardingOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.StartReshardingOperation).Name}");
                    startReshardingOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.AbortReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.AbortReshardingOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.AbortReshardingOperation).Name}");
                    abortReshardingOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ReplicatePointsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ReplicatePointsOperation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ReplicatePointsOperation).Name}");
                    replicatePointsOperation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Qdrant.ClusterOperations(
                moveShardOperation,

                replicateShardOperation,

                abortTransferOperation,

                dropReplicaOperation,

                createShardingKeyOperation,

                dropShardingKeyOperation,

                restartTransferOperation,

                startReshardingOperation,

                abortReshardingOperation,

                replicatePointsOperation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.ClusterOperations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMoveShardOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.MoveShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.MoveShardOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.MoveShardOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MoveShardOperation!, typeInfo);
            }
            else if (value.IsReplicateShardOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ReplicateShardOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ReplicateShardOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ReplicateShardOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReplicateShardOperation!, typeInfo);
            }
            else if (value.IsAbortTransferOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.AbortTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.AbortTransferOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.AbortTransferOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AbortTransferOperation!, typeInfo);
            }
            else if (value.IsDropReplicaOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DropReplicaOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DropReplicaOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DropReplicaOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DropReplicaOperation!, typeInfo);
            }
            else if (value.IsCreateShardingKeyOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.CreateShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.CreateShardingKeyOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.CreateShardingKeyOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateShardingKeyOperation!, typeInfo);
            }
            else if (value.IsDropShardingKeyOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.DropShardingKeyOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.DropShardingKeyOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.DropShardingKeyOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DropShardingKeyOperation!, typeInfo);
            }
            else if (value.IsRestartTransferOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.RestartTransferOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.RestartTransferOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.RestartTransferOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RestartTransferOperation!, typeInfo);
            }
            else if (value.IsStartReshardingOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.StartReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.StartReshardingOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.StartReshardingOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StartReshardingOperation!, typeInfo);
            }
            else if (value.IsAbortReshardingOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.AbortReshardingOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.AbortReshardingOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.AbortReshardingOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AbortReshardingOperation!, typeInfo);
            }
            else if (value.IsReplicatePointsOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Qdrant.ReplicatePointsOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Qdrant.ReplicatePointsOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Qdrant.ReplicatePointsOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReplicatePointsOperation!, typeInfo);
            }
        }
    }
}