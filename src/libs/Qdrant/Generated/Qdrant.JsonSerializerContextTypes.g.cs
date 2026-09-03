
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
        public global::Qdrant.VectorOutput? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVector? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScoredPoint? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateResult? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateStatus? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollRequest? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Filter? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderByInterface? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Condition?, global::System.Collections.Generic.IList<global::Qdrant.Condition>, object>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Condition? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Condition>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MinShould? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FieldCondition? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsEmptyCondition? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsNullCondition? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasIdCondition? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasVectorCondition? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SliceCondition? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NestedCondition? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchCondition? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RangeInterface? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoBoundingBox? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoRadius? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoPolygon? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ValuesCount? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchValue? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ValueVariants? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchText? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchTextAny? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchPhrase? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchPrefix? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchAny? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyVariants? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MatchExcept? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Range? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeRange? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoPoint? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoLineString? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GeoLineString>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GeoPoint>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadField? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Slice? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Nested? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderBy? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Direction? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartFrom? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollResult? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Record>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateCollection? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WalConfigDiff? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizersConfigDiff? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeConfig? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxOptimizationThreads? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxOptimizationThreadsSetting? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeMultivector>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.StrictModeSparse>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeMultivector? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StrictModeSparse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollection? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParamsDiff>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionParamsDiff? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationConfigDiff? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorParamsDiff? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DisabledType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ChangeAliasesOperation? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.AliasOperations>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AliasOperations? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateAliasOperation? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteAliasOperation? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RenameAliasOperation? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateAlias? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteAlias? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RenameAlias? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFieldIndex? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadFieldSchema? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsSelector? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointIdsList? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FilterSelector? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointInsertOperations? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsBatch? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointsList? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Batch? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateMode? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BatchVectorStruct? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Payload>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Qdrant.Vector>>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Vector>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Vector? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Document>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Document? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Image>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Image? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.InferenceObject>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceObject? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DocumentOptions? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Bm25Config? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointStruct>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointStruct? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStruct? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayload? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayload? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatus? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant1? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant1Status? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant2? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusVariant2Status? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerInfo>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerInfo? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RaftInfo? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatus? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.MessageSendErrors>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MessageSendErrors? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StateRole? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant1? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant2? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant3? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotDescription? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountRequest? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountResult? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionClusterInfo? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.LocalShardInfo>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LocalShardInfo? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.RemoteShardInfo>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemoteShardInfo? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardTransferInfo>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardTransferInfo? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReshardingInfo>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingInfo? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicaState? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardTransferMethod? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReshardingDirection? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TelemetryData? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AppBuildTelemetry? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsTelemetry? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterTelemetry? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RequestsTelemetry? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MemoryTelemetry? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HardwareTelemetry? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchThreadPoolTelemetry? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaTelemetry? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AppFeaturesTelemetry? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeatureFlags? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryMode? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HnswGlobalConfig? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RunningEnvironmentTelemetry? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AuditTelemetry? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant1? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant2? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LowMemoryModeVariant3? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContainerRuntime? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CpuEndian? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.GpuDeviceTelemetry>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GpuDeviceTelemetry? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionTelemetryEnum>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionTelemetryEnum? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.CollectionSnapshotTelemetry>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionSnapshotTelemetry? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionTelemetry? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsAggregatedTelemetry? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionConfigTelemetry? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ReplicaSetTelemetry>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicaSetTelemetry? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetry? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LocalShardTelemetry? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.RemoteShardTelemetry>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemoteShardTelemetry? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ReplicaState>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PartialSnapshotTelemetry? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardStatus? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SegmentTelemetry>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentTelemetry? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizerTelemetry? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardUpdateQueueInfo? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentInfo? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentConfig? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.VectorIndexSearchesTelemetry>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorIndexSearchesTelemetry? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PayloadIndexTelemetry>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadIndexTelemetry? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SegmentType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataInfo>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorDataInfo? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IoBackend? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataConfig>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorDataConfig? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorDataConfig>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorDataConfig? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Indexes? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageDatatype? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant1? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant2? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant3? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant4? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant5? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant6? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant1? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant1Type? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant2? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IndexesVariant2Type? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexConfig? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant1? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant2? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseIndexTypeVariant3? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageTypeVariant1? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageTypeVariant2? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant1? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant1Type? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant2? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PayloadStorageTypeVariant2Type? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OperationDurationStatistics? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.TrackerTelemetry>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerTelemetry? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatus? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum2? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TrackerStatusEnum3? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum2? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusProgressTelemetry? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusTelemetryEnum3? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardCleanStatusFailedTelemetry? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusTelemetry? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterConfigTelemetry? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerMetadata>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerMetadata? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.P2pConfigTelemetry? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ConsensusConfigTelemetry? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WebApiTelemetry? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GrpcTelemetry? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Qdrant.OperationDurationStatistics>>>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.HardwareUsage>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HardwareUsage? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaConfig? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaExceeded? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterOperations? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MoveShardOperation? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicateShardOperation? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortTransferOperation? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropReplicaOperation? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardingKeyOperation? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropShardingKeyOperation? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RestartTransferOperation? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartReshardingOperation? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortReshardingOperation? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicatePointsOperation? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MoveShard? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicateShard? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortShardTransfer? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Replica? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardingKey? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DropShardingKey? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RestartTransfer? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.StartResharding? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbortResharding? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReplicatePoints? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotRecover? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SnapshotPriority? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionsAliasesResponse? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.AliasDescription>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AliasDescription? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WriteOrdering? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReadConsistency? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ReadConsistencyType? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectors? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointVectors>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointVectors? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectors? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PointGroup? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ScoredPoint>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GroupId? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GroupsResult? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PointGroup>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateOperations? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.UpdateOperation>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateOperation? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpsertOperation? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteOperation? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayloadOperation? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OverwritePayloadOperation? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayloadOperation? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearPayloadOperation? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectorsOperation? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorsOperation? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardSnapshotRecover? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardSnapshotLocation? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VersionInfo? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionExistence? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryRequest? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Prefetch2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryInterface? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchParams? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LookupLocation? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorInput? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Query? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NearestQuery? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendQuery? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DiscoverQuery? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextQuery? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OrderByQuery? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FusionQuery? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RrfQuery? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FormulaQuery? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SampleQuery? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RelevanceFeedbackQuery? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Mmr? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendInput? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.VectorInput>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecommendStrategy? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DiscoverInput? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>, object>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextPair? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ContextPair>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ContextInput? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Fusion? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Rrf? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Expression? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoDistance? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeExpression? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeKeyExpression? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MultExpression? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SumExpression? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MaxExpression? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.MinExpression? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NegExpression? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AbsExpression? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DivExpression? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SqrtExpression? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PowExpression? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExpExpression? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Log10Expression? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LnExpression? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AcoshExpression? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.LinDecayExpression? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExpDecayExpression? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GaussDecayExpression? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoDistanceParams? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Expression>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DivParams? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PowParams? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DecayParamsExpression? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Sample? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RelevanceFeedbackInput? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.FeedbackItem>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeedbackItem? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FeedbackStrategy? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NaiveFeedbackStrategy? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NaiveFeedbackStrategyParams? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuantizationSearchParams? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.AcornSearchParams? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfParams? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfScope? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IdfCorpusParams? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryRequestBatch? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.QueryRequest>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryResponse? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryGroupsRequest? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithLookupInterface? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.WithLookup? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixOffsetsResponse? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPairsResponse? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SearchMatrixPair>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPair? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetResponse? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.FacetValueHit>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetValueHit? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetValue? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Usage? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceUsage? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ModelUsage? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeysResponse? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKeyDescription>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ShardKeyDescription? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationsResponse? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationsSummary? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.Optimization>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Optimization? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.PendingOptimization>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PendingOptimization? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.OptimizationSegmentInfo>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OptimizationSegmentInfo? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ProgressTree? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.ProgressTree>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedTelemetryData? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedCollectionTelemetry>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedCollectionTelemetry? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedClusterTelemetry? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.DistributedShardTelemetry>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedShardTelemetry? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.DistributedReplicaTelemetry>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedReplicaTelemetry? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.DistributedPeerInfo>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedPeerInfo? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DistributedPeerDetails? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.VectorNameConfig? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DenseVectorNameConfig? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorNameConfig? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DenseVectorConfig? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorConfig? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaStatus? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QuotaUsage? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerQuotaUsage>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.PeerQuotaUsage? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotRequest? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotRequest? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardKeyResponse? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListShardKeysResponse? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardKeyResponse? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TelemetryResponse? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearIssuesResponse? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterStatusResponse? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClusterTelemetryResponse? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverCurrentPeerResponse? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RemovePeerResponse? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetQuotasResponse? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateQuotasResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionsResponse? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionResponse? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateCollectionResponse? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollectionResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteCollectionResponse? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateAliasesResponse? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFieldIndexResponse? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionExistsResponse? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFieldIndexResponse? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateVectorNameResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorNameResponse? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CollectionClusterInfoResponse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateCollectionClusterResponse? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetOptimizationsResponse? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionAliasesResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetCollectionsAliasesResponse? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotResponse? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromUploadedSnapshotResponse2? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromSnapshotResponse? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverFromSnapshotResponse2? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListSnapshotsResponse? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.SnapshotDescription>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateSnapshotResponse? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateSnapshotResponse2? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteSnapshotResponse? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteSnapshotResponse2? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListFullSnapshotsResponse? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFullSnapshotResponse? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateFullSnapshotResponse2? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFullSnapshotResponse? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteFullSnapshotResponse2? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotResponse? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromUploadedSnapshotResponse2? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromSnapshotResponse? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.RecoverShardFromSnapshotResponse2? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ListShardSnapshotsResponse? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardSnapshotResponse? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CreateShardSnapshotResponse2? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardSnapshotResponse? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteShardSnapshotResponse2? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetPointResponse? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GetPointsResponse? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpsertPointsResponse? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePointsResponse? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UpdateVectorsResponse? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeleteVectorsResponse? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SetPayloadResponse? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.OverwritePayloadResponse? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DeletePayloadResponse? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ClearPayloadResponse? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BatchUpdateResponse? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.UpdateResult>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ScrollPointsResponse? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.CountPointsResponse? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FacetResponse2? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryPointsResponse? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryBatchPointsResponse? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Qdrant.QueryResponse>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.QueryPointsGroupsResponse? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixPairsResponse2? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SearchMatrixOffsetsResponse2? Type607 { get; set; }

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
        public global::System.Collections.Generic.List<global::Qdrant.Payload>? ListType16 { get; set; }
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