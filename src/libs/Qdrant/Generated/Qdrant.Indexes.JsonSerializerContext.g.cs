
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Memory), TypeInfoPropertyName = "Memory2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateStatus), TypeInfoPropertyName = "UpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateFieldIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.PayloadFieldSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HardwareUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WriteOrdering), TypeInfoPropertyName = "WriteOrdering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.InferenceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.CreateFieldIndexResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.DeleteFieldIndexResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Memory?), TypeInfoPropertyName = "NullableMemory2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.UpdateStatus?), TypeInfoPropertyName = "NullableUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.WriteOrdering?), TypeInfoPropertyName = "NullableWriteOrdering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class IndexesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IndexesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IndexesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private IndexesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Qdrant.JsonConverters.PayloadSchemaParamsJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.StopwordsInterfaceJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.StemmingAlgorithmJsonConverter());
            options.Converters.Add(new global::Qdrant.JsonConverters.PayloadFieldSchemaJsonConverter());
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
                    typeToConvert == typeof(global::Qdrant.Memory)

                    || typeToConvert == typeof(global::Qdrant.Memory?)

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

                    || typeToConvert == typeof(global::Qdrant.WriteOrdering)

                    || typeToConvert == typeof(global::Qdrant.WriteOrdering?)

                    || typeToConvert == typeof(global::Qdrant.SnowballType)

                    || typeToConvert == typeof(global::Qdrant.SnowballType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Qdrant.Memory))
                {
                    return new global::Qdrant.JsonConverters.MemoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.Memory?))
                {
                    return new global::Qdrant.JsonConverters.MemoryNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Qdrant.WriteOrdering))
                {
                    return new global::Qdrant.JsonConverters.WriteOrderingJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.WriteOrdering?))
                {
                    return new global::Qdrant.JsonConverters.WriteOrderingNullableJsonConverter();
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
                    0 => new IndexesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}