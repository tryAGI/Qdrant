
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKeySelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ExtendedPointId), TypeInfoPropertyName = "ExtendedPointId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WithPayloadInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WithVector), TypeInfoPropertyName = "WithVector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKey), TypeInfoPropertyName = "ShardKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ShardKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKeyWithFallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadSelector), TypeInfoPropertyName = "PayloadSelector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadSelectorInclude))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadSelectorExclude))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Record))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStructOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OrderValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorOutput), TypeInfoPropertyName = "VectorOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScoredPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateStatus), TypeInfoPropertyName = "UpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScrollRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Filter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OrderByInterface))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OrderBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Direction), TypeInfoPropertyName = "Direction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.StartFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScrollResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Record>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ChangeAliasesOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.AliasOperations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AliasOperations), TypeInfoPropertyName = "AliasOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateAliasOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteAliasOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RenameAliasOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateAlias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteAlias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RenameAlias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateFieldIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadFieldSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointsSelector), TypeInfoPropertyName = "PointsSelector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointIdsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FilterSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointInsertOperations), TypeInfoPropertyName = "PointInsertOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointsBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateMode), TypeInfoPropertyName = "UpdateMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BatchVectorStruct), TypeInfoPropertyName = "BatchVectorStruct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Payload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Qdrant.Vector>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Vector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Vector), TypeInfoPropertyName = "Vector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.InferenceObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.InferenceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DocumentOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Bm25Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.PointStruct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointStruct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStruct), TypeInfoPropertyName = "VectorStruct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SetPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeletePayload))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnapshotDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CountResult))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TelemetryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AppBuildTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionsTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RequestsTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MemoryTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HardwareTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchThreadPoolTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QuotaTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AppFeaturesTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FeatureFlags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LowMemoryMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HnswGlobalConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RunningEnvironmentTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AuditTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LowMemoryModeVariant1), TypeInfoPropertyName = "LowMemoryModeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LowMemoryModeVariant2), TypeInfoPropertyName = "LowMemoryModeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LowMemoryModeVariant3), TypeInfoPropertyName = "LowMemoryModeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CpuEndian), TypeInfoPropertyName = "CpuEndian2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.GpuDeviceTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GpuDeviceTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.CollectionTelemetryEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionTelemetryEnum), TypeInfoPropertyName = "CollectionTelemetryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.CollectionSnapshotTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionSnapshotTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionsAggregatedTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionConfigTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ReplicaSetTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReplicaSetTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetry), TypeInfoPropertyName = "ShardCleanStatusTelemetry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LocalShardTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.RemoteShardTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RemoteShardTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.ReplicaState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PartialSnapshotTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardStatus), TypeInfoPropertyName = "ShardStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.SegmentTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SegmentTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OptimizerTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardUpdateQueueInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SegmentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SegmentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.VectorIndexSearchesTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorIndexSearchesTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.PayloadIndexTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadIndexTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SegmentType), TypeInfoPropertyName = "SegmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorDataInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IoBackend), TypeInfoPropertyName = "IoBackend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorDataConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorDataConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorDataConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageType), TypeInfoPropertyName = "PayloadStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageType), TypeInfoPropertyName = "VectorStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Indexes), TypeInfoPropertyName = "Indexes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageDatatype), TypeInfoPropertyName = "VectorStorageDatatype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant1), TypeInfoPropertyName = "VectorStorageTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant2), TypeInfoPropertyName = "VectorStorageTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant3), TypeInfoPropertyName = "VectorStorageTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant4), TypeInfoPropertyName = "VectorStorageTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant5), TypeInfoPropertyName = "VectorStorageTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant6), TypeInfoPropertyName = "VectorStorageTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IndexesVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IndexesVariant1Type), TypeInfoPropertyName = "IndexesVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IndexesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IndexesVariant2Type), TypeInfoPropertyName = "IndexesVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorStorageType), TypeInfoPropertyName = "SparseVectorStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexType), TypeInfoPropertyName = "SparseIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexTypeVariant1), TypeInfoPropertyName = "SparseIndexTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexTypeVariant2), TypeInfoPropertyName = "SparseIndexTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexTypeVariant3), TypeInfoPropertyName = "SparseIndexTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorStorageTypeVariant1), TypeInfoPropertyName = "SparseVectorStorageTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorStorageTypeVariant2), TypeInfoPropertyName = "SparseVectorStorageTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageTypeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageTypeVariant1Type), TypeInfoPropertyName = "PayloadStorageTypeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageTypeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageTypeVariant2Type), TypeInfoPropertyName = "PayloadStorageTypeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OperationDurationStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.TrackerTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatus), TypeInfoPropertyName = "TrackerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatusEnum), TypeInfoPropertyName = "TrackerStatusEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatusEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatusEnum3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetryEnum), TypeInfoPropertyName = "ShardCleanStatusTelemetryEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetryEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusProgressTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetryEnum3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusFailedTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterConfigTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PeerMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.P2pConfigTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ConsensusConfigTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WebApiTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GrpcTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.HardwareUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HardwareUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QuotaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QuotaExceeded))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnapshotRecover))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnapshotPriority), TypeInfoPropertyName = "SnapshotPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionsAliasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.AliasDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AliasDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WriteOrdering), TypeInfoPropertyName = "WriteOrdering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReadConsistency), TypeInfoPropertyName = "ReadConsistency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReadConsistencyType), TypeInfoPropertyName = "ReadConsistencyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateVectors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.PointVectors>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointVectors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteVectors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ScoredPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GroupId), TypeInfoPropertyName = "GroupId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GroupsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.PointGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateOperations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.UpdateOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateOperation), TypeInfoPropertyName = "UpdateOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpsertOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SetPayloadOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OverwritePayloadOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeletePayloadOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClearPayloadOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateVectorsOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteVectorsOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardSnapshotRecover))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardSnapshotLocation), TypeInfoPropertyName = "ShardSnapshotLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VersionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionExistence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>), TypeInfoPropertyName = "AnyOfPrefetch2IListPrefetch2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Prefetch2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LookupLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorInput), TypeInfoPropertyName = "VectorInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Query), TypeInfoPropertyName = "Query2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NearestQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecommendQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DiscoverQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ContextQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OrderByQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FusionQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RrfQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FormulaQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SampleQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RelevanceFeedbackQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Mmr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecommendInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.VectorInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecommendStrategy), TypeInfoPropertyName = "RecommendStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DiscoverInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>, object>), TypeInfoPropertyName = "AnyOfContextPairIListContextPairObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ContextPair))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ContextPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ContextInput), TypeInfoPropertyName = "ContextInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Fusion), TypeInfoPropertyName = "Fusion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Rrf))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Expression), TypeInfoPropertyName = "Expression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoDistance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DatetimeExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DatetimeKeyExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MultExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SumExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NegExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AbsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DivExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SqrtExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PowExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ExpExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Log10Expression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LnExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LinDecayExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ExpDecayExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GaussDecayExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GeoDistanceParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.Expression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DivParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PowParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DecayParamsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Sample), TypeInfoPropertyName = "Sample2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RelevanceFeedbackInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.FeedbackItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FeedbackItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FeedbackStrategy), TypeInfoPropertyName = "FeedbackStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NaiveFeedbackStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NaiveFeedbackStrategyParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QuantizationSearchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AcornSearchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IdfParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IdfScope), TypeInfoPropertyName = "IdfScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IdfCorpusParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryRequestBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.QueryRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryGroupsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WithLookupInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WithLookup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchMatrixRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchMatrixOffsetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchMatrixPairsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.SearchMatrixPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchMatrixPair))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FacetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FacetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.FacetValueHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FacetValueHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FacetValue), TypeInfoPropertyName = "FacetValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.InferenceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ModelUsage))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ShardKeyDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKeyDescription))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorNameConfig), TypeInfoPropertyName = "VectorNameConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DenseVectorNameConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorNameConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DenseVectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QuotaStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QuotaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerQuotaUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PeerQuotaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverFromUploadedSnapshotRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverShardFromUploadedSnapshotRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateShardKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ListShardKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteShardKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TelemetryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClearIssuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterTelemetryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverCurrentPeerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RemovePeerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetQuotasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateQuotasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetCollectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateAliasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateFieldIndexResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionExistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteFieldIndexResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateVectorNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteVectorNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionClusterInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateCollectionClusterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetOptimizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetCollectionAliasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetCollectionsAliasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverFromUploadedSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverFromUploadedSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverFromSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverFromSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ListSnapshotsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.SnapshotDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ListFullSnapshotsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateFullSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateFullSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteFullSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteFullSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverShardFromUploadedSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverShardFromUploadedSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverShardFromSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverShardFromSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ListShardSnapshotsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateShardSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateShardSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteShardSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteShardSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetPointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GetPointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpsertPointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeletePointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateVectorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteVectorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SetPayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.OverwritePayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeletePayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClearPayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BatchUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.UpdateResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScrollPointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CountPointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FacetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryPointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryBatchPointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.QueryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryPointsGroupsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchMatrixPairsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchMatrixOffsetsResponse2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ExtendedPointId?), TypeInfoPropertyName = "NullableExtendedPointId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WithVector?), TypeInfoPropertyName = "NullableWithVector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKey?), TypeInfoPropertyName = "NullableShardKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadSelector?), TypeInfoPropertyName = "NullablePayloadSelector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorOutput?), TypeInfoPropertyName = "NullableVectorOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateStatus?), TypeInfoPropertyName = "NullableUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>?), TypeInfoPropertyName = "NullableAnyOfConditionIListConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Condition?), TypeInfoPropertyName = "NullableCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ValueVariants?), TypeInfoPropertyName = "NullableValueVariants2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyVariants?), TypeInfoPropertyName = "NullableAnyVariants2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Direction?), TypeInfoPropertyName = "NullableDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MaxOptimizationThreadsSetting?), TypeInfoPropertyName = "NullableMaxOptimizationThreadsSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DisabledType?), TypeInfoPropertyName = "NullableDisabledType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AliasOperations?), TypeInfoPropertyName = "NullableAliasOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointsSelector?), TypeInfoPropertyName = "NullablePointsSelector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointInsertOperations?), TypeInfoPropertyName = "NullablePointInsertOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateMode?), TypeInfoPropertyName = "NullableUpdateMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.BatchVectorStruct?), TypeInfoPropertyName = "NullableBatchVectorStruct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Vector?), TypeInfoPropertyName = "NullableVector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStruct?), TypeInfoPropertyName = "NullableVectorStruct2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LowMemoryModeVariant1?), TypeInfoPropertyName = "NullableLowMemoryModeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LowMemoryModeVariant2?), TypeInfoPropertyName = "NullableLowMemoryModeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LowMemoryModeVariant3?), TypeInfoPropertyName = "NullableLowMemoryModeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CpuEndian?), TypeInfoPropertyName = "NullableCpuEndian2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CollectionTelemetryEnum?), TypeInfoPropertyName = "NullableCollectionTelemetryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetry?), TypeInfoPropertyName = "NullableShardCleanStatusTelemetry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardStatus?), TypeInfoPropertyName = "NullableShardStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SegmentType?), TypeInfoPropertyName = "NullableSegmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IoBackend?), TypeInfoPropertyName = "NullableIoBackend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageType?), TypeInfoPropertyName = "NullablePayloadStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageType?), TypeInfoPropertyName = "NullableVectorStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Indexes?), TypeInfoPropertyName = "NullableIndexes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageDatatype?), TypeInfoPropertyName = "NullableVectorStorageDatatype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant1?), TypeInfoPropertyName = "NullableVectorStorageTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant2?), TypeInfoPropertyName = "NullableVectorStorageTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant3?), TypeInfoPropertyName = "NullableVectorStorageTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant4?), TypeInfoPropertyName = "NullableVectorStorageTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant5?), TypeInfoPropertyName = "NullableVectorStorageTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorStorageTypeVariant6?), TypeInfoPropertyName = "NullableVectorStorageTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IndexesVariant1Type?), TypeInfoPropertyName = "NullableIndexesVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IndexesVariant2Type?), TypeInfoPropertyName = "NullableIndexesVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorStorageType?), TypeInfoPropertyName = "NullableSparseVectorStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexType?), TypeInfoPropertyName = "NullableSparseIndexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexTypeVariant1?), TypeInfoPropertyName = "NullableSparseIndexTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexTypeVariant2?), TypeInfoPropertyName = "NullableSparseIndexTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseIndexTypeVariant3?), TypeInfoPropertyName = "NullableSparseIndexTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorStorageTypeVariant1?), TypeInfoPropertyName = "NullableSparseVectorStorageTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVectorStorageTypeVariant2?), TypeInfoPropertyName = "NullableSparseVectorStorageTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageTypeVariant1Type?), TypeInfoPropertyName = "NullablePayloadStorageTypeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadStorageTypeVariant2Type?), TypeInfoPropertyName = "NullablePayloadStorageTypeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatus?), TypeInfoPropertyName = "NullableTrackerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TrackerStatusEnum?), TypeInfoPropertyName = "NullableTrackerStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardCleanStatusTelemetryEnum?), TypeInfoPropertyName = "NullableShardCleanStatusTelemetryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ClusterOperations?), TypeInfoPropertyName = "NullableClusterOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnapshotPriority?), TypeInfoPropertyName = "NullableSnapshotPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WriteOrdering?), TypeInfoPropertyName = "NullableWriteOrdering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReadConsistency?), TypeInfoPropertyName = "NullableReadConsistency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReadConsistencyType?), TypeInfoPropertyName = "NullableReadConsistencyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GroupId?), TypeInfoPropertyName = "NullableGroupId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateOperation?), TypeInfoPropertyName = "NullableUpdateOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardSnapshotLocation?), TypeInfoPropertyName = "NullableShardSnapshotLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>?), TypeInfoPropertyName = "NullableAnyOfPrefetch2IListPrefetch2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorInput?), TypeInfoPropertyName = "NullableVectorInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Query?), TypeInfoPropertyName = "NullableQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecommendStrategy?), TypeInfoPropertyName = "NullableRecommendStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>, object>?), TypeInfoPropertyName = "NullableAnyOfContextPairIListContextPairObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ContextInput?), TypeInfoPropertyName = "NullableContextInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Fusion?), TypeInfoPropertyName = "NullableFusion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Expression?), TypeInfoPropertyName = "NullableExpression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Sample?), TypeInfoPropertyName = "NullableSample2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FeedbackStrategy?), TypeInfoPropertyName = "NullableFeedbackStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.IdfScope?), TypeInfoPropertyName = "NullableIdfScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.FacetValue?), TypeInfoPropertyName = "NullableFacetValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorNameConfig?), TypeInfoPropertyName = "NullableVectorNameConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.CollectionDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.CollectionWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ExtendedPointId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ShardKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.List<global::Qdrant.Condition>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.GeoLineString>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.GeoPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Record>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.AliasOperations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Payload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Qdrant.Vector>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Vector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.InferenceObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.PointStruct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.LocalShardInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.RemoteShardInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ShardTransferInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ReshardingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.GpuDeviceTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.CollectionTelemetryEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.CollectionSnapshotTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ReplicaSetTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.RemoteShardTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.SegmentTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.VectorIndexSearchesTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.PayloadIndexTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.TrackerTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.AliasDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.PointVectors>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ScoredPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.PointGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.UpdateOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.List<global::Qdrant.Prefetch2>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Prefetch2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.VectorInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.List<global::Qdrant.ContextPair>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ContextPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Expression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.FeedbackItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.QueryRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.SearchMatrixPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.FacetValueHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ShardKeyDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Optimization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.PendingOptimization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.OptimizationSegmentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ProgressTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.DistributedShardTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.DistributedReplicaTelemetry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.SnapshotDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.UpdateResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.QueryResponse>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Qdrant.JsonConverters.OptimizersStatusJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorsConfigJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.QuantizationConfigJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.PayloadSchemaParamsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.StopwordsInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.StemmingAlgorithmJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ShardKeySelectorJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ShardKeyJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ExtendedPointIdJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.WithPayloadInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.PayloadSelectorJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.WithVectorJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorStructOutputJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorOutputJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.OrderValueJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ConditionJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ValueVariantsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyVariantsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.RangeInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.OrderByInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.StartFromJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.MaxOptimizationThreadsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.QuantizationConfigDiffJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.AliasOperationsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.PayloadFieldSchemaJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.PointsSelectorJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.PointInsertOperationsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.BatchVectorStructJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.DocumentOptionsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorStructJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ClusterStatusJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ConsensusThreadStatusJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.LowMemoryModeJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.CollectionTelemetryEnumJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorStorageTypeJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.IndexesJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.SparseIndexTypeJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.SparseVectorStorageTypeJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.PayloadStorageTypeJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.TrackerStatusJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ShardCleanStatusTelemetryJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ClusterOperationsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ReadConsistencyJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.GroupIdJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.UpdateOperationJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ShardSnapshotLocationJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.QueryInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorInputJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.QueryJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ContextInputJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ExpressionJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.FeedbackStrategyJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.IdfParamsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.WithLookupInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.FacetValueJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorNameConfigJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.MatchConditionJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>());
            options.Converters.Add(new global::Qdrant.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

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

                    || typeToConvert == typeof(global::Qdrant.Direction)

                    || typeToConvert == typeof(global::Qdrant.Direction?)

                    || typeToConvert == typeof(global::Qdrant.MaxOptimizationThreadsSetting)

                    || typeToConvert == typeof(global::Qdrant.MaxOptimizationThreadsSetting?)

                    || typeToConvert == typeof(global::Qdrant.UpdateMode)

                    || typeToConvert == typeof(global::Qdrant.UpdateMode?)

                    || typeToConvert == typeof(global::Qdrant.ClusterStatusVariant1Status)

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

                    || typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant1)

                    || typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant1?)

                    || typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant2)

                    || typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant2?)

                    || typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant3)

                    || typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant3?)

                    || typeToConvert == typeof(global::Qdrant.CpuEndian)

                    || typeToConvert == typeof(global::Qdrant.CpuEndian?)

                    || typeToConvert == typeof(global::Qdrant.ShardStatus)

                    || typeToConvert == typeof(global::Qdrant.ShardStatus?)

                    || typeToConvert == typeof(global::Qdrant.SegmentType)

                    || typeToConvert == typeof(global::Qdrant.SegmentType?)

                    || typeToConvert == typeof(global::Qdrant.IoBackend)

                    || typeToConvert == typeof(global::Qdrant.IoBackend?)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant1)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant1?)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant2)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant2?)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant3)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant3?)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant4)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant4?)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant5)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant5?)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant6)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant6?)

                    || typeToConvert == typeof(global::Qdrant.IndexesVariant1Type)

                    || typeToConvert == typeof(global::Qdrant.IndexesVariant1Type?)

                    || typeToConvert == typeof(global::Qdrant.IndexesVariant2Type)

                    || typeToConvert == typeof(global::Qdrant.IndexesVariant2Type?)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageDatatype)

                    || typeToConvert == typeof(global::Qdrant.VectorStorageDatatype?)

                    || typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant1)

                    || typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant1?)

                    || typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant2)

                    || typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant2?)

                    || typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant3)

                    || typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant3?)

                    || typeToConvert == typeof(global::Qdrant.SparseVectorStorageTypeVariant1)

                    || typeToConvert == typeof(global::Qdrant.SparseVectorStorageTypeVariant1?)

                    || typeToConvert == typeof(global::Qdrant.SparseVectorStorageTypeVariant2)

                    || typeToConvert == typeof(global::Qdrant.SparseVectorStorageTypeVariant2?)

                    || typeToConvert == typeof(global::Qdrant.PayloadStorageTypeVariant1Type)

                    || typeToConvert == typeof(global::Qdrant.PayloadStorageTypeVariant1Type?)

                    || typeToConvert == typeof(global::Qdrant.PayloadStorageTypeVariant2Type)

                    || typeToConvert == typeof(global::Qdrant.PayloadStorageTypeVariant2Type?)

                    || typeToConvert == typeof(global::Qdrant.TrackerStatusEnum)

                    || typeToConvert == typeof(global::Qdrant.TrackerStatusEnum?)

                    || typeToConvert == typeof(global::Qdrant.ShardCleanStatusTelemetryEnum)

                    || typeToConvert == typeof(global::Qdrant.ShardCleanStatusTelemetryEnum?)

                    || typeToConvert == typeof(global::Qdrant.SnapshotPriority)

                    || typeToConvert == typeof(global::Qdrant.SnapshotPriority?)

                    || typeToConvert == typeof(global::Qdrant.WriteOrdering)

                    || typeToConvert == typeof(global::Qdrant.WriteOrdering?)

                    || typeToConvert == typeof(global::Qdrant.ReadConsistencyType)

                    || typeToConvert == typeof(global::Qdrant.ReadConsistencyType?)

                    || typeToConvert == typeof(global::Qdrant.RecommendStrategy)

                    || typeToConvert == typeof(global::Qdrant.RecommendStrategy?)

                    || typeToConvert == typeof(global::Qdrant.Fusion)

                    || typeToConvert == typeof(global::Qdrant.Fusion?)

                    || typeToConvert == typeof(global::Qdrant.Sample)

                    || typeToConvert == typeof(global::Qdrant.Sample?)

                    || typeToConvert == typeof(global::Qdrant.IdfScope)

                    || typeToConvert == typeof(global::Qdrant.IdfScope?)

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

                if (typeToConvert == typeof(global::Qdrant.Direction))
                {
                    return new global::Qdrant.JsonConverters.DirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Direction?))
                {
                    return new global::Qdrant.JsonConverters.DirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.MaxOptimizationThreadsSetting))
                {
                    return new global::Qdrant.JsonConverters.MaxOptimizationThreadsSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.MaxOptimizationThreadsSetting?))
                {
                    return new global::Qdrant.JsonConverters.MaxOptimizationThreadsSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.UpdateMode))
                {
                    return new global::Qdrant.JsonConverters.UpdateModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.UpdateMode?))
                {
                    return new global::Qdrant.JsonConverters.UpdateModeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant1))
                {
                    return new global::Qdrant.JsonConverters.LowMemoryModeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant1?))
                {
                    return new global::Qdrant.JsonConverters.LowMemoryModeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant2))
                {
                    return new global::Qdrant.JsonConverters.LowMemoryModeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant2?))
                {
                    return new global::Qdrant.JsonConverters.LowMemoryModeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant3))
                {
                    return new global::Qdrant.JsonConverters.LowMemoryModeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.LowMemoryModeVariant3?))
                {
                    return new global::Qdrant.JsonConverters.LowMemoryModeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.CpuEndian))
                {
                    return new global::Qdrant.JsonConverters.CpuEndianJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.CpuEndian?))
                {
                    return new global::Qdrant.JsonConverters.CpuEndianNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardStatus))
                {
                    return new global::Qdrant.JsonConverters.ShardStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardStatus?))
                {
                    return new global::Qdrant.JsonConverters.ShardStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SegmentType))
                {
                    return new global::Qdrant.JsonConverters.SegmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SegmentType?))
                {
                    return new global::Qdrant.JsonConverters.SegmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IoBackend))
                {
                    return new global::Qdrant.JsonConverters.IoBackendJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IoBackend?))
                {
                    return new global::Qdrant.JsonConverters.IoBackendNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant1))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant1?))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant2))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant2?))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant3))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant3?))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant4))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant4?))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant5))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant5?))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant6))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageTypeVariant6?))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageTypeVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IndexesVariant1Type))
                {
                    return new global::Qdrant.JsonConverters.IndexesVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IndexesVariant1Type?))
                {
                    return new global::Qdrant.JsonConverters.IndexesVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IndexesVariant2Type))
                {
                    return new global::Qdrant.JsonConverters.IndexesVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IndexesVariant2Type?))
                {
                    return new global::Qdrant.JsonConverters.IndexesVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageDatatype))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageDatatypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.VectorStorageDatatype?))
                {
                    return new global::Qdrant.JsonConverters.VectorStorageDatatypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant1))
                {
                    return new global::Qdrant.JsonConverters.SparseIndexTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant1?))
                {
                    return new global::Qdrant.JsonConverters.SparseIndexTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant2))
                {
                    return new global::Qdrant.JsonConverters.SparseIndexTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant2?))
                {
                    return new global::Qdrant.JsonConverters.SparseIndexTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant3))
                {
                    return new global::Qdrant.JsonConverters.SparseIndexTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseIndexTypeVariant3?))
                {
                    return new global::Qdrant.JsonConverters.SparseIndexTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseVectorStorageTypeVariant1))
                {
                    return new global::Qdrant.JsonConverters.SparseVectorStorageTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseVectorStorageTypeVariant1?))
                {
                    return new global::Qdrant.JsonConverters.SparseVectorStorageTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseVectorStorageTypeVariant2))
                {
                    return new global::Qdrant.JsonConverters.SparseVectorStorageTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SparseVectorStorageTypeVariant2?))
                {
                    return new global::Qdrant.JsonConverters.SparseVectorStorageTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.PayloadStorageTypeVariant1Type))
                {
                    return new global::Qdrant.JsonConverters.PayloadStorageTypeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.PayloadStorageTypeVariant1Type?))
                {
                    return new global::Qdrant.JsonConverters.PayloadStorageTypeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.PayloadStorageTypeVariant2Type))
                {
                    return new global::Qdrant.JsonConverters.PayloadStorageTypeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.PayloadStorageTypeVariant2Type?))
                {
                    return new global::Qdrant.JsonConverters.PayloadStorageTypeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TrackerStatusEnum))
                {
                    return new global::Qdrant.JsonConverters.TrackerStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.TrackerStatusEnum?))
                {
                    return new global::Qdrant.JsonConverters.TrackerStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardCleanStatusTelemetryEnum))
                {
                    return new global::Qdrant.JsonConverters.ShardCleanStatusTelemetryEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ShardCleanStatusTelemetryEnum?))
                {
                    return new global::Qdrant.JsonConverters.ShardCleanStatusTelemetryEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SnapshotPriority))
                {
                    return new global::Qdrant.JsonConverters.SnapshotPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SnapshotPriority?))
                {
                    return new global::Qdrant.JsonConverters.SnapshotPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.WriteOrdering))
                {
                    return new global::Qdrant.JsonConverters.WriteOrderingJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.WriteOrdering?))
                {
                    return new global::Qdrant.JsonConverters.WriteOrderingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ReadConsistencyType))
                {
                    return new global::Qdrant.JsonConverters.ReadConsistencyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.ReadConsistencyType?))
                {
                    return new global::Qdrant.JsonConverters.ReadConsistencyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.RecommendStrategy))
                {
                    return new global::Qdrant.JsonConverters.RecommendStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.RecommendStrategy?))
                {
                    return new global::Qdrant.JsonConverters.RecommendStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Fusion))
                {
                    return new global::Qdrant.JsonConverters.FusionJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Fusion?))
                {
                    return new global::Qdrant.JsonConverters.FusionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Sample))
                {
                    return new global::Qdrant.JsonConverters.SampleJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Sample?))
                {
                    return new global::Qdrant.JsonConverters.SampleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IdfScope))
                {
                    return new global::Qdrant.JsonConverters.IdfScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.IdfScope?))
                {
                    return new global::Qdrant.JsonConverters.IdfScopeNullableJsonConverter();
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}