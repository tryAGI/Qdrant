
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ErrorResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ExtendedPointId), TypeInfoPropertyName = "ExtendedPointId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKey), TypeInfoPropertyName = "ShardKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Filter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>), TypeInfoPropertyName = "AnyOfConditionIListConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Condition), TypeInfoPropertyName = "Condition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MinShould))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FieldCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IsEmptyCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IsNullCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HasIdCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HasVectorCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SliceCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NestedCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MatchCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RangeInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoRadius))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoPolygon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ValuesCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MatchValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ValueVariants), TypeInfoPropertyName = "ValueVariants2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MatchText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MatchTextAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MatchPhrase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MatchPrefix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MatchAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyVariants), TypeInfoPropertyName = "AnyVariants2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MatchExcept))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Range))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DatetimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoLineString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.GeoLineString>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.GeoPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Slice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Nested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatus), TypeInfoPropertyName = "ClusterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusVariant1Status), TypeInfoPropertyName = "ClusterStatusVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusVariant2Status), TypeInfoPropertyName = "ClusterStatusVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PeerInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RaftInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatus), TypeInfoPropertyName = "ConsensusThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.MessageSendErrors>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MessageSendErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StateRole), TypeInfoPropertyName = "StateRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus), TypeInfoPropertyName = "ConsensusThreadStatusVariant1ConsensusThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus), TypeInfoPropertyName = "ConsensusThreadStatusVariant2ConsensusThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus), TypeInfoPropertyName = "ConsensusThreadStatusVariant3ConsensusThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionClusterInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.LocalShardInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LocalShardInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.RemoteShardInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RemoteShardInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ShardTransferInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardTransferInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ReshardingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReshardingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReplicaState), TypeInfoPropertyName = "ReplicaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardTransferMethod), TypeInfoPropertyName = "ShardTransferMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReshardingDirection), TypeInfoPropertyName = "ReshardingDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetry), TypeInfoPropertyName = "ShardCleanStatusTelemetry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PartialSnapshotTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardStatus), TypeInfoPropertyName = "ShardStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetryEnum), TypeInfoPropertyName = "ShardCleanStatusTelemetryEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetryEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusProgressTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetryEnum3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusFailedTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HardwareUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterOperations), TypeInfoPropertyName = "ClusterOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MoveShardOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReplicateShardOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AbortTransferOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DropReplicaOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateShardingKeyOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DropShardingKeyOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RestartTransferOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StartReshardingOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AbortReshardingOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReplicatePointsOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MoveShard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReplicateShard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AbortShardTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Replica))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateShardingKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DropShardingKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RestartTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StartResharding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AbortResharding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReplicatePoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.InferenceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ShardKeyDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKeyDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DistributedTelemetryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedCollectionTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DistributedCollectionTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DistributedClusterTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.DistributedShardTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DistributedShardTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.DistributedReplicaTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DistributedReplicaTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedPeerInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DistributedPeerInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DistributedPeerDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateShardKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ListShardKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteShardKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterTelemetryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverCurrentPeerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RemovePeerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionClusterInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateCollectionClusterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ExtendedPointId?), TypeInfoPropertyName = "NullableExtendedPointId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKey?), TypeInfoPropertyName = "NullableShardKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>?), TypeInfoPropertyName = "NullableAnyOfConditionIListConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Condition?), TypeInfoPropertyName = "NullableCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ValueVariants?), TypeInfoPropertyName = "NullableValueVariants2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyVariants?), TypeInfoPropertyName = "NullableAnyVariants2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatus?), TypeInfoPropertyName = "NullableClusterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusVariant1Status?), TypeInfoPropertyName = "NullableClusterStatusVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusVariant2Status?), TypeInfoPropertyName = "NullableClusterStatusVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatus?), TypeInfoPropertyName = "NullableConsensusThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StateRole?), TypeInfoPropertyName = "NullableStateRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus?), TypeInfoPropertyName = "NullableConsensusThreadStatusVariant1ConsensusThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus?), TypeInfoPropertyName = "NullableConsensusThreadStatusVariant2ConsensusThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus?), TypeInfoPropertyName = "NullableConsensusThreadStatusVariant3ConsensusThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReplicaState?), TypeInfoPropertyName = "NullableReplicaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardTransferMethod?), TypeInfoPropertyName = "NullableShardTransferMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReshardingDirection?), TypeInfoPropertyName = "NullableReshardingDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetry?), TypeInfoPropertyName = "NullableShardCleanStatusTelemetry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardStatus?), TypeInfoPropertyName = "NullableShardStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetryEnum?), TypeInfoPropertyName = "NullableShardCleanStatusTelemetryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterOperations?), TypeInfoPropertyName = "NullableClusterOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ExtendedPointId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.List<global::Qdrant.Condition>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.GeoLineString>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.GeoPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.LocalShardInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.RemoteShardInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ShardTransferInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ReshardingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ShardKeyDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.DistributedShardTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.DistributedReplicaTelemetry>))]
    internal sealed partial class DistributedSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DistributedSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DistributedSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DistributedSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Qdrant.JsonConverters.ShardKeyJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ExtendedPointIdJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ConditionJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ValueVariantsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyVariantsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.RangeInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ClusterStatusJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ConsensusThreadStatusJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ShardCleanStatusTelemetryJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ClusterOperationsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.MatchConditionJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Qdrant.ClusterStatusVariant1Status)

                    || typeToConvert == typeof(global::Qdrant.ClusterStatusVariant1Status?)

                    || typeToConvert == typeof(global::Qdrant.ClusterStatusVariant2Status)

                    || typeToConvert == typeof(global::Qdrant.ClusterStatusVariant2Status?)

                    || typeToConvert == typeof(global::Qdrant.StateRole)

                    || typeToConvert == typeof(global::Qdrant.StateRole?)

                    || typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus)

                    || typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus?)

                    || typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus)

                    || typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus?)

                    || typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus)

                    || typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus?)

                    || typeToConvert == typeof(global::Qdrant.ReplicaState)

                    || typeToConvert == typeof(global::Qdrant.ReplicaState?)

                    || typeToConvert == typeof(global::Qdrant.ShardTransferMethod)

                    || typeToConvert == typeof(global::Qdrant.ShardTransferMethod?)

                    || typeToConvert == typeof(global::Qdrant.ReshardingDirection)

                    || typeToConvert == typeof(global::Qdrant.ReshardingDirection?)

                    || typeToConvert == typeof(global::Qdrant.ShardStatus)

                    || typeToConvert == typeof(global::Qdrant.ShardStatus?)

                    || typeToConvert == typeof(global::Qdrant.ShardCleanStatusTelemetryEnum)

                    || typeToConvert == typeof(global::Qdrant.ShardCleanStatusTelemetryEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Qdrant.ClusterStatusVariant1Status))
                {
                    return new global::Qdrant.JsonConverters.ClusterStatusVariant1StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ClusterStatusVariant1Status?))
                {
                    return new global::Qdrant.JsonConverters.ClusterStatusVariant1StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ClusterStatusVariant2Status))
                {
                    return new global::Qdrant.JsonConverters.ClusterStatusVariant2StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ClusterStatusVariant2Status?))
                {
                    return new global::Qdrant.JsonConverters.ClusterStatusVariant2StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.StateRole))
                {
                    return new global::Qdrant.JsonConverters.StateRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.StateRole?))
                {
                    return new global::Qdrant.JsonConverters.StateRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus))
                {
                    return new global::Qdrant.JsonConverters.ConsensusThreadStatusVariant1ConsensusThreadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus?))
                {
                    return new global::Qdrant.JsonConverters.ConsensusThreadStatusVariant1ConsensusThreadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus))
                {
                    return new global::Qdrant.JsonConverters.ConsensusThreadStatusVariant2ConsensusThreadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus?))
                {
                    return new global::Qdrant.JsonConverters.ConsensusThreadStatusVariant2ConsensusThreadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus))
                {
                    return new global::Qdrant.JsonConverters.ConsensusThreadStatusVariant3ConsensusThreadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus?))
                {
                    return new global::Qdrant.JsonConverters.ConsensusThreadStatusVariant3ConsensusThreadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ReplicaState))
                {
                    return new global::Qdrant.JsonConverters.ReplicaStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ReplicaState?))
                {
                    return new global::Qdrant.JsonConverters.ReplicaStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardTransferMethod))
                {
                    return new global::Qdrant.JsonConverters.ShardTransferMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardTransferMethod?))
                {
                    return new global::Qdrant.JsonConverters.ShardTransferMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ReshardingDirection))
                {
                    return new global::Qdrant.JsonConverters.ReshardingDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ReshardingDirection?))
                {
                    return new global::Qdrant.JsonConverters.ReshardingDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardStatus))
                {
                    return new global::Qdrant.JsonConverters.ShardStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardStatus?))
                {
                    return new global::Qdrant.JsonConverters.ShardStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardCleanStatusTelemetryEnum))
                {
                    return new global::Qdrant.JsonConverters.ShardCleanStatusTelemetryEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardCleanStatusTelemetryEnum?))
                {
                    return new global::Qdrant.JsonConverters.ShardCleanStatusTelemetryEnumNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new DistributedSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}