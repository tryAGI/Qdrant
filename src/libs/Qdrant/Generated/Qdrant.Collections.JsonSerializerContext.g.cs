
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.CollectionDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionStatus), TypeInfoPropertyName = "CollectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizersStatus), TypeInfoPropertyName = "OptimizersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.CollectionWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.PayloadIndexInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadIndexInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateQueueInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizersStatusEnum), TypeInfoPropertyName = "OptimizersStatusEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizersStatusEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HnswConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizersConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WalConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QuantizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StrictModeConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Payload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorsConfig), TypeInfoPropertyName = "VectorsConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardingMethod), TypeInfoPropertyName = "ShardingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParams>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Distance), TypeInfoPropertyName = "Distance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HnswConfigDiff))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Memory), TypeInfoPropertyName = "Memory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Datatype), TypeInfoPropertyName = "Datatype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MultiVectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScalarQuantization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ProductQuantization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BinaryQuantization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TurboQuantization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScalarQuantizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScalarType), TypeInfoPropertyName = "ScalarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ProductQuantizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CompressionRatio), TypeInfoPropertyName = "CompressionRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BinaryQuantizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BinaryQuantizationEncoding), TypeInfoPropertyName = "BinaryQuantizationEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BinaryQuantizationQueryEncoding), TypeInfoPropertyName = "BinaryQuantizationQueryEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TurboQuantQuantizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TurboQuantBitSize), TypeInfoPropertyName = "TurboQuantBitSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MultiVectorComparator), TypeInfoPropertyName = "MultiVectorComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Modifier), TypeInfoPropertyName = "Modifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivectorOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparseOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StrictModeMultivectorOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StrictModeSparseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadSchemaType), TypeInfoPropertyName = "PayloadSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadSchemaParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.KeywordIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IntegerIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FloatIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TextIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BoolIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DatetimeIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UuidIndexParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.KeywordIndexType), TypeInfoPropertyName = "KeywordIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IntegerIndexType), TypeInfoPropertyName = "IntegerIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FloatIndexType), TypeInfoPropertyName = "FloatIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoIndexType), TypeInfoPropertyName = "GeoIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TextIndexType), TypeInfoPropertyName = "TextIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TokenizerType), TypeInfoPropertyName = "TokenizerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StopwordsInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StemmingAlgorithm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Language), TypeInfoPropertyName = "Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StopwordsSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnowballParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DisabledStemmerParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnowballType), TypeInfoPropertyName = "SnowballType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnowballLanguage), TypeInfoPropertyName = "SnowballLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NoStemmer), TypeInfoPropertyName = "NoStemmer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BoolIndexType), TypeInfoPropertyName = "BoolIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DatetimeIndexType), TypeInfoPropertyName = "DatetimeIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UuidIndexType), TypeInfoPropertyName = "UuidIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateStatus), TypeInfoPropertyName = "UpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WalConfigDiff))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizersConfigDiff))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StrictModeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MaxOptimizationThreads))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MaxOptimizationThreadsSetting), TypeInfoPropertyName = "MaxOptimizationThreadsSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StrictModeMultivector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StrictModeSparse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParamsDiff>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionParamsDiff))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QuantizationConfigDiff))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorParamsDiff))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DisabledType), TypeInfoPropertyName = "DisabledType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageDatatype), TypeInfoPropertyName = "VectorStorageDatatype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatus), TypeInfoPropertyName = "TrackerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatusEnum), TypeInfoPropertyName = "TrackerStatusEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatusEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatusEnum3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HardwareUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WriteOrdering), TypeInfoPropertyName = "WriteOrdering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionExistence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.InferenceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizationsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Optimization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Optimization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.PendingOptimization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PendingOptimization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.OptimizationSegmentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizationSegmentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ProgressTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ProgressTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorNameConfig), TypeInfoPropertyName = "VectorNameConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DenseVectorNameConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorNameConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DenseVectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetCollectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionExistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateVectorNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteVectorNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetOptimizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionStatus?), TypeInfoPropertyName = "NullableCollectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizersStatus?), TypeInfoPropertyName = "NullableOptimizersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizersStatusEnum?), TypeInfoPropertyName = "NullableOptimizersStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorsConfig?), TypeInfoPropertyName = "NullableVectorsConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardingMethod?), TypeInfoPropertyName = "NullableShardingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Distance?), TypeInfoPropertyName = "NullableDistance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Memory?), TypeInfoPropertyName = "NullableMemory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Datatype?), TypeInfoPropertyName = "NullableDatatype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScalarType?), TypeInfoPropertyName = "NullableScalarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CompressionRatio?), TypeInfoPropertyName = "NullableCompressionRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BinaryQuantizationEncoding?), TypeInfoPropertyName = "NullableBinaryQuantizationEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BinaryQuantizationQueryEncoding?), TypeInfoPropertyName = "NullableBinaryQuantizationQueryEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TurboQuantBitSize?), TypeInfoPropertyName = "NullableTurboQuantBitSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MultiVectorComparator?), TypeInfoPropertyName = "NullableMultiVectorComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Modifier?), TypeInfoPropertyName = "NullableModifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadSchemaType?), TypeInfoPropertyName = "NullablePayloadSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.KeywordIndexType?), TypeInfoPropertyName = "NullableKeywordIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IntegerIndexType?), TypeInfoPropertyName = "NullableIntegerIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FloatIndexType?), TypeInfoPropertyName = "NullableFloatIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoIndexType?), TypeInfoPropertyName = "NullableGeoIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TextIndexType?), TypeInfoPropertyName = "NullableTextIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TokenizerType?), TypeInfoPropertyName = "NullableTokenizerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Language?), TypeInfoPropertyName = "NullableLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnowballType?), TypeInfoPropertyName = "NullableSnowballType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnowballLanguage?), TypeInfoPropertyName = "NullableSnowballLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NoStemmer?), TypeInfoPropertyName = "NullableNoStemmer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BoolIndexType?), TypeInfoPropertyName = "NullableBoolIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DatetimeIndexType?), TypeInfoPropertyName = "NullableDatetimeIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UuidIndexType?), TypeInfoPropertyName = "NullableUuidIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateStatus?), TypeInfoPropertyName = "NullableUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MaxOptimizationThreadsSetting?), TypeInfoPropertyName = "NullableMaxOptimizationThreadsSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DisabledType?), TypeInfoPropertyName = "NullableDisabledType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageDatatype?), TypeInfoPropertyName = "NullableVectorStorageDatatype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatus?), TypeInfoPropertyName = "NullableTrackerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatusEnum?), TypeInfoPropertyName = "NullableTrackerStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WriteOrdering?), TypeInfoPropertyName = "NullableWriteOrdering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorNameConfig?), TypeInfoPropertyName = "NullableVectorNameConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.CollectionDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.CollectionWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Optimization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.PendingOptimization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.OptimizationSegmentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ProgressTree>))]
    internal sealed partial class CollectionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CollectionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CollectionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CollectionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Qdrant.JsonConverters.OptimizersStatusJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorsConfigJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.QuantizationConfigJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.PayloadSchemaParamsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.StopwordsInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.StemmingAlgorithmJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.MaxOptimizationThreadsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.QuantizationConfigDiffJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.TrackerStatusJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorNameConfigJsonConverter());
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
                    typeToConvert == typeof(global::Qdrant.CollectionStatus)

                    || typeToConvert == typeof(global::Qdrant.CollectionStatus?)

                    || typeToConvert == typeof(global::Qdrant.OptimizersStatusEnum)

                    || typeToConvert == typeof(global::Qdrant.OptimizersStatusEnum?)

                    || typeToConvert == typeof(global::Qdrant.Distance)

                    || typeToConvert == typeof(global::Qdrant.Distance?)

                    || typeToConvert == typeof(global::Qdrant.Memory)

                    || typeToConvert == typeof(global::Qdrant.Memory?)

                    || typeToConvert == typeof(global::Qdrant.ScalarType)

                    || typeToConvert == typeof(global::Qdrant.ScalarType?)

                    || typeToConvert == typeof(global::Qdrant.CompressionRatio)

                    || typeToConvert == typeof(global::Qdrant.CompressionRatio?)

                    || typeToConvert == typeof(global::Qdrant.BinaryQuantizationEncoding)

                    || typeToConvert == typeof(global::Qdrant.BinaryQuantizationEncoding?)

                    || typeToConvert == typeof(global::Qdrant.BinaryQuantizationQueryEncoding)

                    || typeToConvert == typeof(global::Qdrant.BinaryQuantizationQueryEncoding?)

                    || typeToConvert == typeof(global::Qdrant.TurboQuantBitSize)

                    || typeToConvert == typeof(global::Qdrant.TurboQuantBitSize?)

                    || typeToConvert == typeof(global::Qdrant.Datatype)

                    || typeToConvert == typeof(global::Qdrant.Datatype?)

                    || typeToConvert == typeof(global::Qdrant.MultiVectorComparator)

                    || typeToConvert == typeof(global::Qdrant.MultiVectorComparator?)

                    || typeToConvert == typeof(global::Qdrant.ShardingMethod)

                    || typeToConvert == typeof(global::Qdrant.ShardingMethod?)

                    || typeToConvert == typeof(global::Qdrant.Modifier)

                    || typeToConvert == typeof(global::Qdrant.Modifier?)

                    || typeToConvert == typeof(global::Qdrant.PayloadSchemaType)

                    || typeToConvert == typeof(global::Qdrant.PayloadSchemaType?)

                    || typeToConvert == typeof(global::Qdrant.KeywordIndexType)

                    || typeToConvert == typeof(global::Qdrant.KeywordIndexType?)

                    || typeToConvert == typeof(global::Qdrant.IntegerIndexType)

                    || typeToConvert == typeof(global::Qdrant.IntegerIndexType?)

                    || typeToConvert == typeof(global::Qdrant.FloatIndexType)

                    || typeToConvert == typeof(global::Qdrant.FloatIndexType?)

                    || typeToConvert == typeof(global::Qdrant.GeoIndexType)

                    || typeToConvert == typeof(global::Qdrant.GeoIndexType?)

                    || typeToConvert == typeof(global::Qdrant.TextIndexType)

                    || typeToConvert == typeof(global::Qdrant.TextIndexType?)

                    || typeToConvert == typeof(global::Qdrant.TokenizerType)

                    || typeToConvert == typeof(global::Qdrant.TokenizerType?)

                    || typeToConvert == typeof(global::Qdrant.Language)

                    || typeToConvert == typeof(global::Qdrant.Language?)

                    || typeToConvert == typeof(global::Qdrant.SnowballLanguage)

                    || typeToConvert == typeof(global::Qdrant.SnowballLanguage?)

                    || typeToConvert == typeof(global::Qdrant.NoStemmer)

                    || typeToConvert == typeof(global::Qdrant.NoStemmer?)

                    || typeToConvert == typeof(global::Qdrant.BoolIndexType)

                    || typeToConvert == typeof(global::Qdrant.BoolIndexType?)

                    || typeToConvert == typeof(global::Qdrant.DatetimeIndexType)

                    || typeToConvert == typeof(global::Qdrant.DatetimeIndexType?)

                    || typeToConvert == typeof(global::Qdrant.UuidIndexType)

                    || typeToConvert == typeof(global::Qdrant.UuidIndexType?)

                    || typeToConvert == typeof(global::Qdrant.UpdateStatus)

                    || typeToConvert == typeof(global::Qdrant.UpdateStatus?)

                    || typeToConvert == typeof(global::Qdrant.MaxOptimizationThreadsSetting)

                    || typeToConvert == typeof(global::Qdrant.MaxOptimizationThreadsSetting?)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageDatatype)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageDatatype?)

                    || typeToConvert == typeof(global::Qdrant.TrackerStatusEnum)

                    || typeToConvert == typeof(global::Qdrant.TrackerStatusEnum?)

                    || typeToConvert == typeof(global::Qdrant.WriteOrdering)

                    || typeToConvert == typeof(global::Qdrant.WriteOrdering?)

                    || typeToConvert == typeof(global::Qdrant.DisabledType)

                    || typeToConvert == typeof(global::Qdrant.DisabledType?)

                    || typeToConvert == typeof(global::Qdrant.SnowballType)

                    || typeToConvert == typeof(global::Qdrant.SnowballType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Qdrant.CollectionStatus))
                {
                    return new global::Qdrant.JsonConverters.CollectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.CollectionStatus?))
                {
                    return new global::Qdrant.JsonConverters.CollectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.OptimizersStatusEnum))
                {
                    return new global::Qdrant.JsonConverters.OptimizersStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.OptimizersStatusEnum?))
                {
                    return new global::Qdrant.JsonConverters.OptimizersStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Distance))
                {
                    return new global::Qdrant.JsonConverters.DistanceJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Distance?))
                {
                    return new global::Qdrant.JsonConverters.DistanceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Memory))
                {
                    return new global::Qdrant.JsonConverters.MemoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Memory?))
                {
                    return new global::Qdrant.JsonConverters.MemoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ScalarType))
                {
                    return new global::Qdrant.JsonConverters.ScalarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ScalarType?))
                {
                    return new global::Qdrant.JsonConverters.ScalarTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.CompressionRatio))
                {
                    return new global::Qdrant.JsonConverters.CompressionRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.CompressionRatio?))
                {
                    return new global::Qdrant.JsonConverters.CompressionRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.BinaryQuantizationEncoding))
                {
                    return new global::Qdrant.JsonConverters.BinaryQuantizationEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.BinaryQuantizationEncoding?))
                {
                    return new global::Qdrant.JsonConverters.BinaryQuantizationEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.BinaryQuantizationQueryEncoding))
                {
                    return new global::Qdrant.JsonConverters.BinaryQuantizationQueryEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.BinaryQuantizationQueryEncoding?))
                {
                    return new global::Qdrant.JsonConverters.BinaryQuantizationQueryEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TurboQuantBitSize))
                {
                    return new global::Qdrant.JsonConverters.TurboQuantBitSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TurboQuantBitSize?))
                {
                    return new global::Qdrant.JsonConverters.TurboQuantBitSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Datatype))
                {
                    return new global::Qdrant.JsonConverters.DatatypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Datatype?))
                {
                    return new global::Qdrant.JsonConverters.DatatypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.MultiVectorComparator))
                {
                    return new global::Qdrant.JsonConverters.MultiVectorComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.MultiVectorComparator?))
                {
                    return new global::Qdrant.JsonConverters.MultiVectorComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardingMethod))
                {
                    return new global::Qdrant.JsonConverters.ShardingMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardingMethod?))
                {
                    return new global::Qdrant.JsonConverters.ShardingMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Modifier))
                {
                    return new global::Qdrant.JsonConverters.ModifierJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Modifier?))
                {
                    return new global::Qdrant.JsonConverters.ModifierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.PayloadSchemaType))
                {
                    return new global::Qdrant.JsonConverters.PayloadSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.PayloadSchemaType?))
                {
                    return new global::Qdrant.JsonConverters.PayloadSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.KeywordIndexType))
                {
                    return new global::Qdrant.JsonConverters.KeywordIndexTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.KeywordIndexType?))
                {
                    return new global::Qdrant.JsonConverters.KeywordIndexTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IntegerIndexType))
                {
                    return new global::Qdrant.JsonConverters.IntegerIndexTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IntegerIndexType?))
                {
                    return new global::Qdrant.JsonConverters.IntegerIndexTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.FloatIndexType))
                {
                    return new global::Qdrant.JsonConverters.FloatIndexTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.FloatIndexType?))
                {
                    return new global::Qdrant.JsonConverters.FloatIndexTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.GeoIndexType))
                {
                    return new global::Qdrant.JsonConverters.GeoIndexTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.GeoIndexType?))
                {
                    return new global::Qdrant.JsonConverters.GeoIndexTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TextIndexType))
                {
                    return new global::Qdrant.JsonConverters.TextIndexTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TextIndexType?))
                {
                    return new global::Qdrant.JsonConverters.TextIndexTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TokenizerType))
                {
                    return new global::Qdrant.JsonConverters.TokenizerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TokenizerType?))
                {
                    return new global::Qdrant.JsonConverters.TokenizerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Language))
                {
                    return new global::Qdrant.JsonConverters.LanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Language?))
                {
                    return new global::Qdrant.JsonConverters.LanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SnowballLanguage))
                {
                    return new global::Qdrant.JsonConverters.SnowballLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SnowballLanguage?))
                {
                    return new global::Qdrant.JsonConverters.SnowballLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.NoStemmer))
                {
                    return new global::Qdrant.JsonConverters.NoStemmerJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.NoStemmer?))
                {
                    return new global::Qdrant.JsonConverters.NoStemmerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.BoolIndexType))
                {
                    return new global::Qdrant.JsonConverters.BoolIndexTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.BoolIndexType?))
                {
                    return new global::Qdrant.JsonConverters.BoolIndexTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.DatetimeIndexType))
                {
                    return new global::Qdrant.JsonConverters.DatetimeIndexTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.DatetimeIndexType?))
                {
                    return new global::Qdrant.JsonConverters.DatetimeIndexTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.UuidIndexType))
                {
                    return new global::Qdrant.JsonConverters.UuidIndexTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.UuidIndexType?))
                {
                    return new global::Qdrant.JsonConverters.UuidIndexTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.UpdateStatus))
                {
                    return new global::Qdrant.JsonConverters.UpdateStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.UpdateStatus?))
                {
                    return new global::Qdrant.JsonConverters.UpdateStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.MaxOptimizationThreadsSetting))
                {
                    return new global::Qdrant.JsonConverters.MaxOptimizationThreadsSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.MaxOptimizationThreadsSetting?))
                {
                    return new global::Qdrant.JsonConverters.MaxOptimizationThreadsSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageDatatype))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageDatatypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageDatatype?))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageDatatypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TrackerStatusEnum))
                {
                    return new global::Qdrant.JsonConverters.TrackerStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TrackerStatusEnum?))
                {
                    return new global::Qdrant.JsonConverters.TrackerStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.WriteOrdering))
                {
                    return new global::Qdrant.JsonConverters.WriteOrderingJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.WriteOrdering?))
                {
                    return new global::Qdrant.JsonConverters.WriteOrderingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.DisabledType))
                {
                    return new global::Qdrant.JsonConverters.DisabledTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.DisabledType?))
                {
                    return new global::Qdrant.JsonConverters.DisabledTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SnowballType))
                {
                    return new global::Qdrant.JsonConverters.SnowballTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SnowballType?))
                {
                    return new global::Qdrant.JsonConverters.SnowballTypeNullableJsonConverter();
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
                    0 => new CollectionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}