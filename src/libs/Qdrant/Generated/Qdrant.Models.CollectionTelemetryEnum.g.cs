#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CollectionTelemetryEnum : global::System.IEquatable<CollectionTelemetryEnum>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.CollectionTelemetry? CollectionTelemetry { get; init; }
#else
        public global::Qdrant.CollectionTelemetry? CollectionTelemetry { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CollectionTelemetry))]
#endif
        public bool IsCollectionTelemetry => CollectionTelemetry != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.CollectionsAggregatedTelemetry? CollectionsAggregated { get; init; }
#else
        public global::Qdrant.CollectionsAggregatedTelemetry? CollectionsAggregated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CollectionsAggregated))]
#endif
        public bool IsCollectionsAggregated => CollectionsAggregated != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionTelemetryEnum(global::Qdrant.CollectionTelemetry value) => new CollectionTelemetryEnum((global::Qdrant.CollectionTelemetry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.CollectionTelemetry?(CollectionTelemetryEnum @this) => @this.CollectionTelemetry;

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(global::Qdrant.CollectionTelemetry? value)
        {
            CollectionTelemetry = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionTelemetryEnum(global::Qdrant.CollectionsAggregatedTelemetry value) => new CollectionTelemetryEnum((global::Qdrant.CollectionsAggregatedTelemetry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.CollectionsAggregatedTelemetry?(CollectionTelemetryEnum @this) => @this.CollectionsAggregated;

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(global::Qdrant.CollectionsAggregatedTelemetry? value)
        {
            CollectionsAggregated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(
            global::Qdrant.CollectionTelemetry? collectionTelemetry,
            global::Qdrant.CollectionsAggregatedTelemetry? collectionsAggregated
            )
        {
            CollectionTelemetry = collectionTelemetry;
            CollectionsAggregated = collectionsAggregated;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CollectionsAggregated as object ??
            CollectionTelemetry as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CollectionTelemetry?.ToString() ??
            CollectionsAggregated?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCollectionTelemetry || IsCollectionsAggregated;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.CollectionTelemetry?, TResult>? collectionTelemetry = null,
            global::System.Func<global::Qdrant.CollectionsAggregatedTelemetry?, TResult>? collectionsAggregated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollectionTelemetry && collectionTelemetry != null)
            {
                return collectionTelemetry(CollectionTelemetry!);
            }
            else if (IsCollectionsAggregated && collectionsAggregated != null)
            {
                return collectionsAggregated(CollectionsAggregated!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.CollectionTelemetry?>? collectionTelemetry = null,
            global::System.Action<global::Qdrant.CollectionsAggregatedTelemetry?>? collectionsAggregated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollectionTelemetry)
            {
                collectionTelemetry?.Invoke(CollectionTelemetry!);
            }
            else if (IsCollectionsAggregated)
            {
                collectionsAggregated?.Invoke(CollectionsAggregated!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CollectionTelemetry,
                typeof(global::Qdrant.CollectionTelemetry),
                CollectionsAggregated,
                typeof(global::Qdrant.CollectionsAggregatedTelemetry),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CollectionTelemetryEnum other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.CollectionTelemetry?>.Default.Equals(CollectionTelemetry, other.CollectionTelemetry) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.CollectionsAggregatedTelemetry?>.Default.Equals(CollectionsAggregated, other.CollectionsAggregated) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CollectionTelemetryEnum obj1, CollectionTelemetryEnum obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CollectionTelemetryEnum>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CollectionTelemetryEnum obj1, CollectionTelemetryEnum obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CollectionTelemetryEnum o && Equals(o);
        }
    }
}
