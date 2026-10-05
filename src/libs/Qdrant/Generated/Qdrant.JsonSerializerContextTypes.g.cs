
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
        public int? Type13 { get; set; }
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
        public global::Qdrant.OptimizersStatusEnum? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersStatusEnum2? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionParams? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswConfig? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersConfig? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WalConfig? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationConfig? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeConfigOutput? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Payload? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorsConfig? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardingMethod? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageParams? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdTrackerParams? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorParams>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorParams? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorParams? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParams>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Distance? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswConfigDiff? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Memory? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Datatype? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultiVectorConfig? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarQuantization? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProductQuantization? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantization? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantization? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarQuantizationConfig? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProductQuantizationConfig? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CompressionRatio? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationConfig? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationEncoding? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationQueryEncoding? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantQuantizationConfig? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantBitSize? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultiVectorComparator? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexParams? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Modifier? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivectorOutput>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparseOutput>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeMultivectorOutput? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeSparseOutput? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSchemaType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSchemaParams? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.KeywordIndexParams? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IntegerIndexParams? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FloatIndexParams? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoIndexParams? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextIndexParams? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BoolIndexParams? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeIndexParams? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UuidIndexParams? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.KeywordIndexType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IntegerIndexType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FloatIndexType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoIndexType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextIndexType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TokenizerType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StopwordsInterface? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StemmingAlgorithm? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Language? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StopwordsSet? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Language>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballParams? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DisabledStemmerParams? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballType? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballLanguage? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NoStemmer? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BoolIndexType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeIndexType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UuidIndexType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeySelector? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExtendedPointId? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithPayloadInterface? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithVector? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKey? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKey>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeyWithFallback? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelector? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelectorInclude? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelectorExclude? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Record? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStructOutput? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderValue? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorOutput>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorOutput? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVector? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScoredPoint? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateResult? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateStatus? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Filter? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderByInterface? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Condition? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Condition>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MinShould? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FieldCondition? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsEmptyCondition? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsNullCondition? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasIdCondition? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasVectorCondition? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SliceCondition? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NestedCondition? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchCondition? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RangeInterface? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoBoundingBox? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoRadius? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoPolygon? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ValuesCount? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchValue? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ValueVariants? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchText? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchTextAny? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchPhrase? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchPrefix? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchSubstring? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchAny? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyVariants? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchExcept? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Range? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeRange? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoPoint? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoLineString? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GeoLineString>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GeoPoint>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadField? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Slice? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Nested? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderBy? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Direction? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartFrom? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollResult? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Record>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateCollection? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WalConfigDiff? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersConfigDiff? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeConfig? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxOptimizationThreads? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxOptimizationThreadsSetting? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivector>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparse>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeMultivector? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeSparse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollection? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParamsDiff>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionParamsDiff? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationConfigDiff? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorParamsDiff? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DisabledType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ChangeAliasesOperation? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.AliasOperations>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AliasOperations? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateAliasOperation? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteAliasOperation? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RenameAliasOperation? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateAlias? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteAlias? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RenameAlias? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFieldIndex? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadFieldSchema? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsSelector? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointIdsList? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FilterSelector? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointInsertOperations? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsBatch? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsList? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Batch? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateMode? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BatchVectorStruct? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Payload?>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Qdrant.Vector>>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Vector>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Vector? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Document>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Document? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Image>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Image? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.InferenceObject>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceObject? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DocumentOptions? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Bm25Config? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointStruct>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointStruct? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStruct? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.Vector>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayload? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayload? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatus? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant1? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant1Status? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant2? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant2Status? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerInfo>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerInfo? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RaftInfo? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatus? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.MessageSendErrors>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MessageSendErrors? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StateRole? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant1? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant2? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant3? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotDescription? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountRequest? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountResult? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionClusterInfo? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.LocalShardInfo>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LocalShardInfo? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.RemoteShardInfo>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemoteShardInfo? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardTransferInfo>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardTransferInfo? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReshardingInfo>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingInfo? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicaState? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardTransferMethod? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingDirection? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TelemetryData? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AppBuildTelemetry? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsTelemetry? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterTelemetry? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RequestsTelemetry? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MemoryTelemetry? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HardwareTelemetry? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchThreadPoolTelemetry? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaTelemetry? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AppFeaturesTelemetry? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeatureFlags? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryMode? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswGlobalConfig? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RunningEnvironmentTelemetry? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AuditTelemetry? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant1? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant2? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant3? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContainerRuntime? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CpuEndian? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GpuDeviceTelemetry>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GpuDeviceTelemetry? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionTelemetryEnum>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionTelemetryEnum? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionSnapshotTelemetry>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionSnapshotTelemetry? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionTelemetry? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsAggregatedTelemetry? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionConfigTelemetry? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReplicaSetTelemetry>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicaSetTelemetry? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReshardingTelemetry>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingTelemetry? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ShardCleanStatusTelemetry>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetry? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LocalShardTelemetry? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.RemoteShardTelemetry>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemoteShardTelemetry? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ReplicaState>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PartialSnapshotTelemetry? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardStatus? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SegmentTelemetry>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentTelemetry? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizerTelemetry? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardUpdateQueueInfo? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentInfo? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentConfig? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.VectorIndexSearchesTelemetry>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorIndexSearchesTelemetry? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PayloadIndexTelemetry>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadIndexTelemetry? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataInfo>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorDataInfo? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IoBackend? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataConfig>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorDataConfig? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorDataConfig>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorDataConfig? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageType? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Indexes? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageDatatype? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant1? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant2? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant3? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant4? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant5? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant6? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant1? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant1Type? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant2? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant2Type? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexConfig? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant1? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant2? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant3? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageTypeEnum? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant1? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant1Type? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant2? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant2Type? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OperationDurationStatistics? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.TrackerTelemetry>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerTelemetry? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatus? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum2? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum3? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingStage? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum2? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusProgressTelemetry? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum3? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusFailedTelemetry? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusTelemetry? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterConfigTelemetry? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerMetadata>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerMetadata? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.P2pConfigTelemetry? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusConfigTelemetry? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WebApiTelemetry? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GrpcTelemetry? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.HardwareUsage>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HardwareUsage? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaConfig? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaExceeded? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterOperations? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MoveShardOperation? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicateShardOperation? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortTransferOperation? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropReplicaOperation? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardingKeyOperation? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropShardingKeyOperation? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RestartTransferOperation? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartReshardingOperation? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortReshardingOperation? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicatePointsOperation? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MoveShard? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicateShard? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortShardTransfer? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Replica? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardingKey? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropShardingKey? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RestartTransfer? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartResharding? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortResharding? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicatePoints? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotRecover? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotPriority? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsAliasesResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.AliasDescription>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AliasDescription? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WriteOrdering? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReadConsistency? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReadConsistencyType? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectors? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointVectors>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointVectors? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectors? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointGroup? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ScoredPoint>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GroupId? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GroupsResult? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointGroup>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateOperations? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.UpdateOperation>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateOperation? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpsertOperation? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteOperation? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayloadOperation? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OverwritePayloadOperation? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayloadOperation? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearPayloadOperation? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectorsOperation? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorsOperation? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardSnapshotRecover? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardSnapshotLocation? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VersionInfo? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionExistence? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryRequest? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Prefetch2? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryInterface? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchParams? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LookupLocation? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorInput? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Query? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NearestQuery? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendQuery? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DiscoverQuery? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextQuery? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderByQuery? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FusionQuery? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RrfQuery? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FormulaQuery? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SampleQuery? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RelevanceFeedbackQuery? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Mmr? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendInput? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.VectorInput>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendStrategy? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DiscoverInput? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextPair? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ContextPair>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextInput? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Fusion? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Rrf? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Expression? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoDistance? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeExpression? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeKeyExpression? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultExpression? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SumExpression? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxExpression? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MinExpression? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NegExpression? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbsExpression? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DivExpression? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SqrtExpression? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PowExpression? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExpExpression? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Log10Expression? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LnExpression? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AcoshExpression? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LinDecayExpression? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExpDecayExpression? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GaussDecayExpression? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoDistanceParams? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Expression>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DivParams? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PowParams? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DecayParamsExpression? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Sample? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RelevanceFeedbackInput? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.FeedbackItem>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeedbackItem? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeedbackStrategy? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NaiveFeedbackStrategy? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NaiveFeedbackStrategyParams? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationSearchParams? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AcornSearchParams? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfParams? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfScope? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfCorpusParams? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryRequestBatch? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.QueryRequest>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryResponse? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryGroupsRequest? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithLookupInterface? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithLookup? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixOffsetsResponse? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPairsResponse? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SearchMatrixPair>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPair? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetRequest? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.FacetValueHit>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetValueHit? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetValue? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Usage? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceUsage? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ModelUsage? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeysResponse? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKeyDescription>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeyDescription? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationsResponse? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationsSummary? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Optimization>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Optimization? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PendingOptimization>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PendingOptimization? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.OptimizationSegmentInfo>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationSegmentInfo? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProgressTree? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ProgressTree>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedTelemetryData? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedCollectionTelemetry>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedCollectionTelemetry? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedClusterTelemetry? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.DistributedShardTelemetry>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedShardTelemetry? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.DistributedReplicaTelemetry>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedReplicaTelemetry? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedPeerInfo>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedPeerInfo? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedPeerDetails? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorNameConfig? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DenseVectorNameConfig? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorNameConfig? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DenseVectorConfig? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorConfig? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaStatus? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaUsage? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerQuotaUsage>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerQuotaUsage? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotRequest? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotRequest? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardKeyResponse? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListShardKeysResponse? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardKeyResponse? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TelemetryResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearIssuesResponse? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusResponse? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterTelemetryResponse? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverCurrentPeerResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemovePeerResponse? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetQuotasResponse? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateQuotasResponse? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionsResponse? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionResponse? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateCollectionResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollectionResponse? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteCollectionResponse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateAliasesResponse? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFieldIndexResponse? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionExistsResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFieldIndexResponse? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateVectorNameResponse? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorNameResponse? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionClusterInfoResponse? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollectionClusterResponse? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetOptimizationsResponse? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionAliasesResponse? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionsAliasesResponse? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotResponse? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotResponse2? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromSnapshotResponse? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromSnapshotResponse2? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListSnapshotsResponse? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SnapshotDescription>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateSnapshotResponse? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateSnapshotResponse2? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteSnapshotResponse? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteSnapshotResponse2? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListFullSnapshotsResponse? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFullSnapshotResponse? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFullSnapshotResponse2? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFullSnapshotResponse? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFullSnapshotResponse2? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotResponse? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotResponse2? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromSnapshotResponse? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromSnapshotResponse2? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListShardSnapshotsResponse? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardSnapshotResponse? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardSnapshotResponse2? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardSnapshotResponse? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardSnapshotResponse2? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetPointResponse? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetPointsResponse? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpsertPointsResponse? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePointsResponse? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectorsResponse? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorsResponse? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayloadResponse? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OverwritePayloadResponse? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayloadResponse? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearPayloadResponse? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BatchUpdateResponse? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.UpdateResult>? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollPointsResponse? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountPointsResponse? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetResponse2? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryPointsResponse? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryBatchPointsResponse? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.QueryResponse>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryPointsGroupsResponse? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPairsResponse2? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixOffsetsResponse2? Type614 { get; set; }

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
        public global::System.Collections.Generic.List<int>? ListType8 { get; set; }
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
        public global::System.Collections.Generic.List<long>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.GeoLineString>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.GeoPoint>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Record>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.AliasOperations>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Payload?>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Qdrant.Vector>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Vector>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Document>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Image>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.InferenceObject>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PointStruct>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.LocalShardInfo>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.RemoteShardInfo>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ShardTransferInfo>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ReshardingInfo>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.GpuDeviceTelemetry>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.CollectionTelemetryEnum>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.CollectionSnapshotTelemetry>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ReplicaSetTelemetry>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ReshardingTelemetry>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.RemoteShardTelemetry>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.SegmentTelemetry>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.VectorIndexSearchesTelemetry>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PayloadIndexTelemetry>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.TrackerTelemetry>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.AliasDescription>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PointVectors>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ScoredPoint>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PointGroup>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.UpdateOperation>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.List<global::Qdrant.Prefetch2>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Prefetch2>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.VectorInput>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.List<global::Qdrant.ContextPair>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ContextPair>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Expression>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.FeedbackItem>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.QueryRequest>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.SearchMatrixPair>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.FacetValueHit>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ShardKeyDescription>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.Optimization>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.PendingOptimization>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.OptimizationSegmentInfo>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.ProgressTree>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.DistributedShardTelemetry>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.DistributedReplicaTelemetry>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.SnapshotDescription>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.UpdateResult>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Qdrant.QueryResponse>? ListType63 { get; set; }
    }
}