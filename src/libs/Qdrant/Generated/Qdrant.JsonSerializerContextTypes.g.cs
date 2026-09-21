
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
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorParams>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorParams? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorParams? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParams>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Distance? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswConfigDiff? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Memory? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Datatype? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultiVectorConfig? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarQuantization? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProductQuantization? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantization? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantization? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarQuantizationConfig? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScalarType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProductQuantizationConfig? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CompressionRatio? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationConfig? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationEncoding? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BinaryQuantizationQueryEncoding? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantQuantizationConfig? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TurboQuantBitSize? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultiVectorComparator? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexParams? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Modifier? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivectorOutput>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparseOutput>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeMultivectorOutput? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeSparseOutput? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSchemaType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSchemaParams? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.KeywordIndexParams? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IntegerIndexParams? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FloatIndexParams? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoIndexParams? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextIndexParams? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BoolIndexParams? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeIndexParams? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UuidIndexParams? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.KeywordIndexType? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IntegerIndexType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FloatIndexType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoIndexType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextIndexType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TokenizerType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StopwordsInterface? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StemmingAlgorithm? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Language? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StopwordsSet? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Language>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballParams? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DisabledStemmerParams? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnowballLanguage? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NoStemmer? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BoolIndexType? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeIndexType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UuidIndexType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeySelector? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExtendedPointId? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithPayloadInterface? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithVector? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKey? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKey>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeyWithFallback? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelector? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelectorInclude? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadSelectorExclude? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Record? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStructOutput? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderValue? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorOutput>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorOutput? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVector? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScoredPoint? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateResult? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateStatus? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Filter? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderByInterface? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Condition? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Condition>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MinShould? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FieldCondition? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsEmptyCondition? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsNullCondition? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasIdCondition? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasVectorCondition? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SliceCondition? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NestedCondition? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchCondition? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RangeInterface? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoBoundingBox? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoRadius? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoPolygon? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ValuesCount? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchValue? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ValueVariants? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchText? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchTextAny? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchPhrase? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchPrefix? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchAny? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyVariants? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchExcept? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Range? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeRange? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoPoint? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoLineString? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GeoLineString>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GeoPoint>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadField? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Slice? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Nested? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderBy? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Direction? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartFrom? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollResult? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Record>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateCollection? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WalConfigDiff? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersConfigDiff? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeConfig? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxOptimizationThreads? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxOptimizationThreadsSetting? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivector>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparse>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeMultivector? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeSparse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollection? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParamsDiff>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionParamsDiff? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationConfigDiff? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorParamsDiff? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DisabledType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ChangeAliasesOperation? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.AliasOperations>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AliasOperations? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateAliasOperation? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteAliasOperation? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RenameAliasOperation? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateAlias? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteAlias? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RenameAlias? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFieldIndex? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadFieldSchema? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsSelector? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointIdsList? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FilterSelector? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointInsertOperations? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsBatch? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsList? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Batch? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateMode? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BatchVectorStruct? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Payload?>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Qdrant.Vector>>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Vector>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Vector? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Document>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Document? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Image>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Image? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.InferenceObject>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceObject? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DocumentOptions? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Bm25Config? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointStruct>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointStruct? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStruct? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.Vector>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayload? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayload? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatus? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant1? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant1Status? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant2? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant2Status? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerInfo>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerInfo? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RaftInfo? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatus? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.MessageSendErrors>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MessageSendErrors? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StateRole? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant1? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant3? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotDescription? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountRequest? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountResult? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionClusterInfo? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.LocalShardInfo>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LocalShardInfo? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.RemoteShardInfo>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemoteShardInfo? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardTransferInfo>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardTransferInfo? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReshardingInfo>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingInfo? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicaState? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardTransferMethod? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingDirection? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TelemetryData? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AppBuildTelemetry? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsTelemetry? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterTelemetry? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RequestsTelemetry? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MemoryTelemetry? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HardwareTelemetry? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchThreadPoolTelemetry? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaTelemetry? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AppFeaturesTelemetry? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeatureFlags? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryMode? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswGlobalConfig? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RunningEnvironmentTelemetry? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AuditTelemetry? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant1? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant2? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant3? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContainerRuntime? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CpuEndian? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GpuDeviceTelemetry>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GpuDeviceTelemetry? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionTelemetryEnum>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionTelemetryEnum? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionSnapshotTelemetry>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionSnapshotTelemetry? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionTelemetry? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsAggregatedTelemetry? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionConfigTelemetry? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReplicaSetTelemetry>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicaSetTelemetry? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ShardCleanStatusTelemetry>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetry? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LocalShardTelemetry? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.RemoteShardTelemetry>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemoteShardTelemetry? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ReplicaState>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PartialSnapshotTelemetry? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardStatus? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SegmentTelemetry>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentTelemetry? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizerTelemetry? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardUpdateQueueInfo? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentInfo? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentConfig? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.VectorIndexSearchesTelemetry>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorIndexSearchesTelemetry? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PayloadIndexTelemetry>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadIndexTelemetry? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataInfo>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorDataInfo? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IoBackend? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataConfig>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorDataConfig? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorDataConfig>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorDataConfig? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Indexes? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageDatatype? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant1? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant2? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant3? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant4? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant5? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant6? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant1? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant1Type? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant2? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant2Type? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexConfig? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant1? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant2? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant3? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageTypeVariant1? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageTypeVariant2? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant1? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant1Type? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant2? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant2Type? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OperationDurationStatistics? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.TrackerTelemetry>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerTelemetry? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatus? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum2? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum3? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum2? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusProgressTelemetry? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum3? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusFailedTelemetry? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusTelemetry? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterConfigTelemetry? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerMetadata>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerMetadata? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.P2pConfigTelemetry? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusConfigTelemetry? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WebApiTelemetry? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GrpcTelemetry? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.HardwareUsage>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HardwareUsage? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaConfig? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaExceeded? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterOperations? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MoveShardOperation? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicateShardOperation? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortTransferOperation? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropReplicaOperation? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardingKeyOperation? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropShardingKeyOperation? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RestartTransferOperation? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartReshardingOperation? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortReshardingOperation? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicatePointsOperation? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MoveShard? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicateShard? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortShardTransfer? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Replica? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardingKey? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropShardingKey? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RestartTransfer? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartResharding? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortResharding? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicatePoints? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotRecover? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotPriority? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsAliasesResponse? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.AliasDescription>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AliasDescription? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WriteOrdering? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReadConsistency? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReadConsistencyType? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectors? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointVectors>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointVectors? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectors? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointGroup? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ScoredPoint>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GroupId? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GroupsResult? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointGroup>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateOperations? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.UpdateOperation>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateOperation? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpsertOperation? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteOperation? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayloadOperation? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OverwritePayloadOperation? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayloadOperation? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearPayloadOperation? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectorsOperation? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorsOperation? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardSnapshotRecover? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardSnapshotLocation? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VersionInfo? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionExistence? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryRequest? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Prefetch2? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryInterface? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchParams? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LookupLocation? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorInput? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Query? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NearestQuery? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendQuery? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DiscoverQuery? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextQuery? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderByQuery? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FusionQuery? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RrfQuery? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FormulaQuery? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SampleQuery? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RelevanceFeedbackQuery? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Mmr? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendInput? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.VectorInput>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendStrategy? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DiscoverInput? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>, object>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextPair? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ContextPair>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextInput? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Fusion? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Rrf? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Expression? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoDistance? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeExpression? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeKeyExpression? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultExpression? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SumExpression? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxExpression? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MinExpression? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NegExpression? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbsExpression? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DivExpression? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SqrtExpression? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PowExpression? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExpExpression? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Log10Expression? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LnExpression? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AcoshExpression? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LinDecayExpression? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExpDecayExpression? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GaussDecayExpression? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoDistanceParams? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Expression>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DivParams? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PowParams? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DecayParamsExpression? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Sample? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RelevanceFeedbackInput? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.FeedbackItem>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeedbackItem? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeedbackStrategy? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NaiveFeedbackStrategy? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NaiveFeedbackStrategyParams? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationSearchParams? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AcornSearchParams? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfParams? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfScope? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfCorpusParams? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryRequestBatch? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.QueryRequest>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryGroupsRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithLookupInterface? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithLookup? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixRequest? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixOffsetsResponse? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPairsResponse? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SearchMatrixPair>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPair? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetRequest? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetResponse? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.FacetValueHit>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetValueHit? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetValue? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Usage? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceUsage? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ModelUsage? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeysResponse? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKeyDescription>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeyDescription? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationsResponse? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationsSummary? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Optimization>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Optimization? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PendingOptimization>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PendingOptimization? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.OptimizationSegmentInfo>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationSegmentInfo? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProgressTree? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ProgressTree>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedTelemetryData? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedCollectionTelemetry>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedCollectionTelemetry? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedClusterTelemetry? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.DistributedShardTelemetry>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedShardTelemetry? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.DistributedReplicaTelemetry>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedReplicaTelemetry? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedPeerInfo>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedPeerInfo? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedPeerDetails? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorNameConfig? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DenseVectorNameConfig? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorNameConfig? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DenseVectorConfig? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorConfig? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaStatus? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaUsage? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerQuotaUsage>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerQuotaUsage? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotRequest? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotRequest? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardKeyResponse? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListShardKeysResponse? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardKeyResponse? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TelemetryResponse? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearIssuesResponse? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusResponse? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterTelemetryResponse? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverCurrentPeerResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemovePeerResponse? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetQuotasResponse? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateQuotasResponse? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionsResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionResponse? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateCollectionResponse? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollectionResponse? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteCollectionResponse? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateAliasesResponse? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFieldIndexResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionExistsResponse? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFieldIndexResponse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateVectorNameResponse? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorNameResponse? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionClusterInfoResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollectionClusterResponse? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetOptimizationsResponse? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionAliasesResponse? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionsAliasesResponse? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotResponse? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotResponse2? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromSnapshotResponse? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromSnapshotResponse2? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListSnapshotsResponse? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SnapshotDescription>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateSnapshotResponse? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateSnapshotResponse2? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteSnapshotResponse? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteSnapshotResponse2? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListFullSnapshotsResponse? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFullSnapshotResponse? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFullSnapshotResponse2? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFullSnapshotResponse? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFullSnapshotResponse2? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotResponse? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotResponse2? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromSnapshotResponse? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromSnapshotResponse2? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListShardSnapshotsResponse? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardSnapshotResponse? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardSnapshotResponse2? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardSnapshotResponse? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardSnapshotResponse2? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetPointResponse? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetPointsResponse? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpsertPointsResponse? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePointsResponse? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectorsResponse? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorsResponse? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayloadResponse? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OverwritePayloadResponse? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayloadResponse? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearPayloadResponse? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BatchUpdateResponse? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.UpdateResult>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollPointsResponse? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountPointsResponse? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetResponse2? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryPointsResponse? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryBatchPointsResponse? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.QueryResponse>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryPointsGroupsResponse? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPairsResponse2? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixOffsetsResponse2? Type610 { get; set; }

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
        public global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.List<global::Qdrant.Condition>, object>? ListType9 { get; set; }
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
        public global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.List<global::Qdrant.Prefetch2>, object>? ListType43 { get; set; }
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
        public global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.List<global::Qdrant.ContextPair>, object>? ListType46 { get; set; }
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