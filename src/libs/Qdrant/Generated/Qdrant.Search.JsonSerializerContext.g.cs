
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Payload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorOutput), TypeInfoPropertyName = "VectorOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SparseVector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ScoredPoint))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.InferenceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DocumentOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Bm25Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HardwareUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReadConsistency), TypeInfoPropertyName = "ReadConsistency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReadConsistencyType), TypeInfoPropertyName = "ReadConsistencyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PointGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.ScoredPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GroupId), TypeInfoPropertyName = "GroupId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GroupsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.PointGroup>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MaxExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.MinExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NegExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AbsExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DivExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SqrtExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PowExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ExpExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Log10Expression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.LnExpression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AcoshExpression))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.InferenceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryPointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryBatchPointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Qdrant.QueryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.QueryPointsGroupsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchMatrixPairsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SearchMatrixOffsetsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.TokenizerType?), TypeInfoPropertyName = "NullableTokenizerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Language?), TypeInfoPropertyName = "NullableLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnowballType?), TypeInfoPropertyName = "NullableSnowballType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnowballLanguage?), TypeInfoPropertyName = "NullableSnowballLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.NoStemmer?), TypeInfoPropertyName = "NullableNoStemmer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ExtendedPointId?), TypeInfoPropertyName = "NullableExtendedPointId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WithVector?), TypeInfoPropertyName = "NullableWithVector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardKey?), TypeInfoPropertyName = "NullableShardKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadSelector?), TypeInfoPropertyName = "NullablePayloadSelector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.VectorOutput?), TypeInfoPropertyName = "NullableVectorOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>?), TypeInfoPropertyName = "NullableAnyOfConditionIListConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Condition?), TypeInfoPropertyName = "NullableCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ValueVariants?), TypeInfoPropertyName = "NullableValueVariants2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyVariants?), TypeInfoPropertyName = "NullableAnyVariants2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Direction?), TypeInfoPropertyName = "NullableDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReadConsistency?), TypeInfoPropertyName = "NullableReadConsistency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ReadConsistencyType?), TypeInfoPropertyName = "NullableReadConsistencyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.GroupId?), TypeInfoPropertyName = "NullableGroupId2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ScoredPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.PointGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.List<global::Qdrant.Prefetch2>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Prefetch2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.VectorInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.List<global::Qdrant.ContextPair>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.ContextPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Expression>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.FeedbackItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.QueryRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.SearchMatrixPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.QueryResponse>))]
    internal sealed partial class SearchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SearchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SearchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Qdrant.JsonConverters.DocumentOptionsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ReadConsistencyJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.GroupIdJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.QueryInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.VectorInputJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.QueryJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ContextInputJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.ExpressionJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.FeedbackStrategyJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.IdfParamsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.WithLookupInterfaceJsonConverter());
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
                    typeToConvert == typeof(global::Qdrant.TokenizerType)

                    || typeToConvert == typeof(global::Qdrant.TokenizerType?)

                    || typeToConvert == typeof(global::Qdrant.Language)

                    || typeToConvert == typeof(global::Qdrant.Language?)

                    || typeToConvert == typeof(global::Qdrant.SnowballLanguage)

                    || typeToConvert == typeof(global::Qdrant.SnowballLanguage?)

                    || typeToConvert == typeof(global::Qdrant.NoStemmer)

                    || typeToConvert == typeof(global::Qdrant.NoStemmer?)

                    || typeToConvert == typeof(global::Qdrant.Direction)

                    || typeToConvert == typeof(global::Qdrant.Direction?)

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

                    || typeToConvert == typeof(global::Qdrant.SnowballType)

                    || typeToConvert == typeof(global::Qdrant.SnowballType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Qdrant.Direction))
                {
                    return new global::Qdrant.JsonConverters.DirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Direction?))
                {
                    return new global::Qdrant.JsonConverters.DirectionNullableJsonConverter();
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
                    0 => new SearchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}