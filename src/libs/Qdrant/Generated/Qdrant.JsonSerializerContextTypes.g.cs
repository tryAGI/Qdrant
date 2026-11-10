
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ErrorResponse? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ErrorResponseStatus? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsResponse? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionDescription>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionDescription? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionInfo? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionStatus? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersStatus? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionWarning>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionWarning? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionConfig? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PayloadIndexInfo>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadIndexInfo? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateQueueInfo? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersStatusEnum? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersStatusEnum2? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionParams? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswConfig? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersConfig? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WalConfig? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationConfig? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeConfigOutput? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Payload? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorsConfig? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardingMethod? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageParams? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdTrackerParams? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorParams>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorParams? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorParams? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParams>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Distance? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswConfigDiff? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Memory? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Datatype? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultiVectorConfig? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarQuantization? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProductQuantization? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantization? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantization? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarQuantizationConfig? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarType? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProductQuantizationConfig? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CompressionRatio? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationConfig? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationEncoding? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationQueryEncoding? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantQuantizationConfig? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantBitSize? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultiVectorComparator? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexParams? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Modifier? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivectorOutput>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparseOutput>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeMultivectorOutput? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeSparseOutput? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSchemaType? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSchemaParams? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.KeywordIndexParams? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IntegerIndexParams? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FloatIndexParams? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoIndexParams? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextIndexParams? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BoolIndexParams? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeIndexParams? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UuidIndexParams? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.KeywordIndexType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IntegerIndexType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FloatIndexType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoIndexType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextIndexType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TokenizerType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StopwordsInterface? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StemmingAlgorithm? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextScoringInterface? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Language? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StopwordsSet? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Language>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballParams? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DisabledStemmerParams? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballType? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballLanguage? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NoStemmer? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextScoringParams? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextScoringType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BoolIndexType? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeIndexType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UuidIndexType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointRequest? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeySelector? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExtendedPointId? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithPayloadInterface? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithVector? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKey? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKey>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeyWithFallback? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelector? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelectorInclude? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelectorExclude? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Record? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStructOutput? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderValue? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorOutput>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorOutput? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVector? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScoredPoint? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateResult? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateStatus? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Filter? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderByInterface? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Condition? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Condition>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MinShould? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FieldCondition? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsEmptyCondition? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsNullCondition? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasIdCondition? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasVectorCondition? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SliceCondition? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NestedCondition? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchCondition? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RangeInterface? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoBoundingBox? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoRadius? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoPolygon? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ValuesCount? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchValue? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ValueVariants? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchText? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchTextAny? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchPhrase? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchPrefix? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchSubstring? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchAny? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyVariants? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchExcept? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Range? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeRange? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoPoint? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoLineString? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GeoLineString>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GeoPoint>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadField? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Slice? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Nested? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderBy? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Direction? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartFrom? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollResult? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Record>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateCollection? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WalConfigDiff? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersConfigDiff? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeConfig? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxOptimizationThreads? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxOptimizationThreadsSetting? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivector>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparse>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeMultivector? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeSparse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollection? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParamsDiff>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionParamsDiff? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationConfigDiff? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorParamsDiff? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DisabledType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ChangeAliasesOperation? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.AliasOperations>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AliasOperations? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateAliasOperation? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteAliasOperation? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RenameAliasOperation? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateAlias? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteAlias? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RenameAlias? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFieldIndex? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadFieldSchema? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsSelector? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointIdsList? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FilterSelector? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointInsertOperations? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsBatch? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsList? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Batch? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateMode? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BatchVectorStruct? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Payload?>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Qdrant.Vector>>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Vector>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Vector? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Document>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Document? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Image>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Image? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.InferenceObject>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceObject? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DocumentOptions? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Bm25Config? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointStruct>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointStruct? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStruct? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.Vector>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayload? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayload? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatus? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant1? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant1Status? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant2? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant2Status? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerInfo>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerInfo? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RaftInfo? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatus? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.MessageSendErrors>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MessageSendErrors? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StateRole? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant1? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant2? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant3? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotDescription? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountRequest? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountResult? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionClusterInfo? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.LocalShardInfo>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LocalShardInfo? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.RemoteShardInfo>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemoteShardInfo? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardTransferInfo>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardTransferInfo? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReshardingInfo>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingInfo? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicaState? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardTransferMethod? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingDirection? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TelemetryData? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AppBuildTelemetry? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsTelemetry? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterTelemetry? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RequestsTelemetry? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MemoryTelemetry? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HardwareTelemetry? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchThreadPoolTelemetry? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaTelemetry? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AppFeaturesTelemetry? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeatureFlags? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryMode? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswGlobalConfig? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RunningEnvironmentTelemetry? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AuditTelemetry? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant1? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant2? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant3? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContainerRuntime? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CpuEndian? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GpuDeviceTelemetry>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GpuDeviceTelemetry? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionTelemetryEnum>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionTelemetryEnum? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionSnapshotTelemetry>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionSnapshotTelemetry? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionTelemetry? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsAggregatedTelemetry? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionConfigTelemetry? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReplicaSetTelemetry>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicaSetTelemetry? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReshardingTelemetry>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingTelemetry? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ShardCleanStatusTelemetry>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetry? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LocalShardTelemetry? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.RemoteShardTelemetry>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemoteShardTelemetry? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ReplicaState>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PartialSnapshotTelemetry? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardStatus? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SegmentTelemetry>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentTelemetry? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizerTelemetry? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardUpdateQueueInfo? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentInfo? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentConfig? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.VectorIndexSearchesTelemetry>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorIndexSearchesTelemetry? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PayloadIndexTelemetry>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadIndexTelemetry? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataInfo>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorDataInfo? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IoBackend? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataConfig>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorDataConfig? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorDataConfig>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorDataConfig? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageType? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Indexes? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageDatatype? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant1? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant2? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant3? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant4? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant5? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant6? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant1? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant1Type? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant2? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant2Type? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexConfig? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexType? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant1? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant2? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant3? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageTypeEnum? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant1? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant1Type? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant2? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant2Type? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OperationDurationStatistics? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.TrackerTelemetry>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerTelemetry? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatus? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum2? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum3? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingStage? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusProgressTelemetry? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum3? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusFailedTelemetry? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusTelemetry? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterConfigTelemetry? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerMetadata>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerMetadata? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.P2pConfigTelemetry? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusConfigTelemetry? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WebApiTelemetry? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GrpcTelemetry? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.HardwareUsage>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HardwareUsage? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaConfig? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaExceeded? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterOperations? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MoveShardOperation? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicateShardOperation? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortTransferOperation? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropReplicaOperation? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardingKeyOperation? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropShardingKeyOperation? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RestartTransferOperation? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartReshardingOperation? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortReshardingOperation? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicatePointsOperation? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MoveShard? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicateShard? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortShardTransfer? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Replica? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardingKey? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropShardingKey? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RestartTransfer? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartResharding? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortResharding? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicatePoints? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotRecover? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotPriority? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsAliasesResponse? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.AliasDescription>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AliasDescription? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WriteOrdering? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReadConsistency? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReadConsistencyType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectors? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointVectors>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointVectors? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectors? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointGroup? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ScoredPoint>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GroupId? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GroupsResult? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointGroup>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateOperations? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.UpdateOperation>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateOperation? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpsertOperation? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteOperation? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayloadOperation? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OverwritePayloadOperation? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayloadOperation? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearPayloadOperation? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectorsOperation? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorsOperation? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardSnapshotRecover? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardSnapshotLocation? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VersionInfo? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionExistence? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryRequest? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Prefetch2? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryInterface? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchParams? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LookupLocation? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorInput? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Query? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NearestQuery? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendQuery? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DiscoverQuery? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextQuery? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderByQuery? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FusionQuery? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RrfQuery? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FormulaQuery? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SampleQuery? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RelevanceFeedbackQuery? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextQuery? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Mmr? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendInput? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.VectorInput>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendStrategy? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DiscoverInput? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextPair? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ContextPair>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextInput? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Fusion? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Rrf? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Expression? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoDistance? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeExpression? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeKeyExpression? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultExpression? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SumExpression? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxExpression? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MinExpression? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NegExpression? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbsExpression? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DivExpression? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SqrtExpression? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PowExpression? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExpExpression? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Log10Expression? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LnExpression? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AcoshExpression? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LinDecayExpression? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExpDecayExpression? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GaussDecayExpression? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoDistanceParams? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Expression>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DivParams? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PowParams? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DecayParamsExpression? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Sample? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RelevanceFeedbackInput? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.FeedbackItem>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeedbackItem? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeedbackStrategy? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NaiveFeedbackStrategy? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NaiveFeedbackStrategyParams? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextInterface? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextQueryInput? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextQueryScoring? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Bm25Scoring? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Bm25Params? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationSearchParams? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AcornSearchParams? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfParams? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfScope? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfCorpusParams? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryRequestBatch? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.QueryRequest>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryResponse? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryGroupsRequest? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithLookupInterface? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithLookup? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixRequest? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixOffsetsResponse? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPairsResponse? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SearchMatrixPair>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPair? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetRequest? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetResponse? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.FacetValueHit>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetValueHit? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetValue? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Usage? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceUsage? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ModelUsage? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeysResponse? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKeyDescription>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeyDescription? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationsResponse? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationsSummary? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Optimization>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Optimization? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PendingOptimization>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PendingOptimization? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.OptimizationSegmentInfo>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationSegmentInfo? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProgressTree? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ProgressTree>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedTelemetryData? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedCollectionTelemetry>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedCollectionTelemetry? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedClusterTelemetry? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.DistributedShardTelemetry>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedShardTelemetry? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.DistributedReplicaTelemetry>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedReplicaTelemetry? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedPeerInfo>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedPeerInfo? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedPeerDetails? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorNameConfig? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DenseVectorNameConfig? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorNameConfig? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DenseVectorConfig? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorConfig? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaStatus? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaUsage? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerQuotaUsage>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerQuotaUsage? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotRequest? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotRequest? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardKeyResponse? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListShardKeysResponse? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardKeyResponse? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TelemetryResponse? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearIssuesResponse? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterTelemetryResponse? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverCurrentPeerResponse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemovePeerResponse? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetQuotasResponse? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateQuotasResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionsResponse? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionResponse? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateCollectionResponse? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollectionResponse? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteCollectionResponse? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateAliasesResponse? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFieldIndexResponse? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionExistsResponse? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFieldIndexResponse? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateVectorNameResponse? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorNameResponse? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionClusterInfoResponse? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollectionClusterResponse? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetOptimizationsResponse? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionAliasesResponse? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionsAliasesResponse? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotResponse? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotResponse2? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromSnapshotResponse? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromSnapshotResponse2? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListSnapshotsResponse? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SnapshotDescription>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateSnapshotResponse? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateSnapshotResponse2? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteSnapshotResponse? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteSnapshotResponse2? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListFullSnapshotsResponse? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFullSnapshotResponse? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFullSnapshotResponse2? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFullSnapshotResponse? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFullSnapshotResponse2? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotResponse? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotResponse2? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromSnapshotResponse? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromSnapshotResponse2? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListShardSnapshotsResponse? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardSnapshotResponse? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardSnapshotResponse2? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardSnapshotResponse? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardSnapshotResponse2? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetPointResponse? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetPointsResponse? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpsertPointsResponse? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePointsResponse? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectorsResponse? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorsResponse? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayloadResponse? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OverwritePayloadResponse? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayloadResponse? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearPayloadResponse? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BatchUpdateResponse? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.UpdateResult>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollPointsResponse? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountPointsResponse? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetResponse2? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryPointsResponse? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryBatchPointsResponse? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.QueryResponse>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryPointsGroupsResponse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPairsResponse2? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixOffsetsResponse2? Type622 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.CollectionDescription>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.CollectionWarning>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Language>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ExtendedPointId>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ShardKey>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.List<global::Qdrant.Condition>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Condition>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.GeoLineString>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.GeoPoint>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Record>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.AliasOperations>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Payload?>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Qdrant.Vector>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Vector>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Document>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Image>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.InferenceObject>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PointStruct>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.LocalShardInfo>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.RemoteShardInfo>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ShardTransferInfo>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ReshardingInfo>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.GpuDeviceTelemetry>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.CollectionTelemetryEnum>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.CollectionSnapshotTelemetry>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ReplicaSetTelemetry>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ReshardingTelemetry>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.RemoteShardTelemetry>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.SegmentTelemetry>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.VectorIndexSearchesTelemetry>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PayloadIndexTelemetry>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.TrackerTelemetry>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.AliasDescription>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PointVectors>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ScoredPoint>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PointGroup>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.UpdateOperation>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.List<global::Qdrant.Prefetch2>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Prefetch2>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.VectorInput>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.List<global::Qdrant.ContextPair>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ContextPair>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Expression>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.FeedbackItem>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.QueryRequest>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.SearchMatrixPair>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.FacetValueHit>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ShardKeyDescription>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Optimization>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PendingOptimization>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.OptimizationSegmentInfo>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ProgressTree>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.DistributedShardTelemetry>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.DistributedReplicaTelemetry>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.SnapshotDescription>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.UpdateResult>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.QueryResponse>? ListType62 { get; set; }
    }
}