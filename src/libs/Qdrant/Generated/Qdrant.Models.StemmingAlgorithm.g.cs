#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Different stemming algorithms with their configs.
    /// </summary>
    public readonly partial struct StemmingAlgorithm : global::System.IEquatable<StemmingAlgorithm>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SnowballParams? SnowballParams { get; init; }
#else
        public global::Qdrant.SnowballParams? SnowballParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SnowballParams))]
#endif
        public bool IsSnowballParams => SnowballParams != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StemmingAlgorithm(global::Qdrant.SnowballParams value) => new StemmingAlgorithm((global::Qdrant.SnowballParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SnowballParams?(StemmingAlgorithm @this) => @this.SnowballParams;

        /// <summary>
        /// 
        /// </summary>
        public StemmingAlgorithm(global::Qdrant.SnowballParams? value)
        {
            SnowballParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SnowballParams as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SnowballParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSnowballParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.SnowballParams?, TResult>? snowballParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSnowballParams && snowballParams != null)
            {
                return snowballParams(SnowballParams!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.SnowballParams?>? snowballParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSnowballParams)
            {
                snowballParams?.Invoke(SnowballParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SnowballParams,
                typeof(global::Qdrant.SnowballParams),
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
        public bool Equals(StemmingAlgorithm other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SnowballParams?>.Default.Equals(SnowballParams, other.SnowballParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StemmingAlgorithm obj1, StemmingAlgorithm obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StemmingAlgorithm>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StemmingAlgorithm obj1, StemmingAlgorithm obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StemmingAlgorithm o && Equals(o);
        }
    }
}
