
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnapshotDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.HardwareUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnapshotRecover))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnapshotPriority), TypeInfoPropertyName = "SnapshotPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardSnapshotRecover))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardSnapshotLocation), TypeInfoPropertyName = "ShardSnapshotLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.InferenceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Qdrant.ModelUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverFromUploadedSnapshotRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.RecoverShardFromUploadedSnapshotRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.SnapshotPriority?), TypeInfoPropertyName = "NullableSnapshotPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Qdrant.ShardSnapshotLocation?), TypeInfoPropertyName = "NullableShardSnapshotLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Qdrant.SnapshotDescription>))]
    internal sealed partial class SnapshotsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SnapshotsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SnapshotsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SnapshotsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Qdrant.JsonConverters.ShardSnapshotLocationJsonConverter());
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
                    typeToConvert == typeof(global::Qdrant.SnapshotPriority)

                    || typeToConvert == typeof(global::Qdrant.SnapshotPriority?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Qdrant.SnapshotPriority))
                {
                    return new global::Qdrant.JsonConverters.SnapshotPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::Qdrant.SnapshotPriority?))
                {
                    return new global::Qdrant.JsonConverters.SnapshotPriorityNullableJsonConverter();
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
                    0 => new SnapshotsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}