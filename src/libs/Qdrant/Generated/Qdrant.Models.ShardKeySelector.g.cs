#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ShardKeySelector : global::System.IEquatable<ShardKeySelector>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ShardKey? ShardKey { get; init; }
#else
        public global::Qdrant.ShardKey? ShardKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShardKey))]
#endif
        public bool IsShardKey => ShardKey != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKey>? ShardKeySelectorVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Qdrant.ShardKey>? ShardKeySelectorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShardKeySelectorVariant2))]
#endif
        public bool IsShardKeySelectorVariant2 => ShardKeySelectorVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ShardKeyWithFallback? WithFallback { get; init; }
#else
        public global::Qdrant.ShardKeyWithFallback? WithFallback { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithFallback))]
#endif
        public bool IsWithFallback => WithFallback != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardKeySelector(global::Qdrant.ShardKey value) => new ShardKeySelector((global::Qdrant.ShardKey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ShardKey?(ShardKeySelector @this) => @this.ShardKey;

        /// <summary>
        /// 
        /// </summary>
        public ShardKeySelector(global::Qdrant.ShardKey? value)
        {
            ShardKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardKeySelector(global::Qdrant.ShardKeyWithFallback value) => new ShardKeySelector((global::Qdrant.ShardKeyWithFallback?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ShardKeyWithFallback?(ShardKeySelector @this) => @this.WithFallback;

        /// <summary>
        /// 
        /// </summary>
        public ShardKeySelector(global::Qdrant.ShardKeyWithFallback? value)
        {
            WithFallback = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ShardKeySelector(
            global::Qdrant.ShardKey? shardKey,
            global::System.Collections.Generic.IList<global::Qdrant.ShardKey>? shardKeySelectorVariant2,
            global::Qdrant.ShardKeyWithFallback? withFallback
            )
        {
            ShardKey = shardKey;
            ShardKeySelectorVariant2 = shardKeySelectorVariant2;
            WithFallback = withFallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WithFallback as object ??
            ShardKeySelectorVariant2 as object ??
            ShardKey as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ShardKey?.ToString() ??
            ShardKeySelectorVariant2?.ToString() ??
            WithFallback?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShardKey || IsShardKeySelectorVariant2 || IsWithFallback;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.ShardKey?, TResult>? shardKey = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Qdrant.ShardKey>?, TResult>? shardKeySelectorVariant2 = null,
            global::System.Func<global::Qdrant.ShardKeyWithFallback?, TResult>? withFallback = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShardKey && shardKey != null)
            {
                return shardKey(ShardKey!);
            }
            else if (IsShardKeySelectorVariant2 && shardKeySelectorVariant2 != null)
            {
                return shardKeySelectorVariant2(ShardKeySelectorVariant2!);
            }
            else if (IsWithFallback && withFallback != null)
            {
                return withFallback(WithFallback!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.ShardKey?>? shardKey = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Qdrant.ShardKey>?>? shardKeySelectorVariant2 = null,
            global::System.Action<global::Qdrant.ShardKeyWithFallback?>? withFallback = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShardKey)
            {
                shardKey?.Invoke(ShardKey!);
            }
            else if (IsShardKeySelectorVariant2)
            {
                shardKeySelectorVariant2?.Invoke(ShardKeySelectorVariant2!);
            }
            else if (IsWithFallback)
            {
                withFallback?.Invoke(WithFallback!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ShardKey,
                typeof(global::Qdrant.ShardKey),
                ShardKeySelectorVariant2,
                typeof(global::System.Collections.Generic.IList<global::Qdrant.ShardKey>),
                WithFallback,
                typeof(global::Qdrant.ShardKeyWithFallback),
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
        public bool Equals(ShardKeySelector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ShardKey?>.Default.Equals(ShardKey, other.ShardKey) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Qdrant.ShardKey>?>.Default.Equals(ShardKeySelectorVariant2, other.ShardKeySelectorVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ShardKeyWithFallback?>.Default.Equals(WithFallback, other.WithFallback) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ShardKeySelector obj1, ShardKeySelector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShardKeySelector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShardKeySelector obj1, ShardKeySelector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShardKeySelector o && Equals(o);
        }
    }
}
