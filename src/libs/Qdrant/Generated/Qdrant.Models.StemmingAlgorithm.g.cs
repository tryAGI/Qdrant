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
        public bool TryPickSnowballParams(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.SnowballParams? value)
        {
            value = SnowballParams;
            return IsSnowballParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.SnowballParams PickSnowballParams() => IsSnowballParams
            ? SnowballParams!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SnowballParams' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DisabledStemmerParams? DisabledStemmerParams { get; init; }
#else
        public global::Qdrant.DisabledStemmerParams? DisabledStemmerParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DisabledStemmerParams))]
#endif
        public bool IsDisabledStemmerParams => DisabledStemmerParams != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDisabledStemmerParams(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.DisabledStemmerParams? value)
        {
            value = DisabledStemmerParams;
            return IsDisabledStemmerParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.DisabledStemmerParams PickDisabledStemmerParams() => IsDisabledStemmerParams
            ? DisabledStemmerParams!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DisabledStemmerParams' but the value was {ToString()}.");
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
        public static StemmingAlgorithm FromSnowballParams(global::Qdrant.SnowballParams? value) => new StemmingAlgorithm(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StemmingAlgorithm(global::Qdrant.DisabledStemmerParams value) => new StemmingAlgorithm((global::Qdrant.DisabledStemmerParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DisabledStemmerParams?(StemmingAlgorithm @this) => @this.DisabledStemmerParams;

        /// <summary>
        /// 
        /// </summary>
        public StemmingAlgorithm(global::Qdrant.DisabledStemmerParams? value)
        {
            DisabledStemmerParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StemmingAlgorithm FromDisabledStemmerParams(global::Qdrant.DisabledStemmerParams? value) => new StemmingAlgorithm(value);

        /// <summary>
        /// 
        /// </summary>
        public StemmingAlgorithm(
            global::Qdrant.SnowballParams? snowballParams,
            global::Qdrant.DisabledStemmerParams? disabledStemmerParams
            )
        {
            SnowballParams = snowballParams;
            DisabledStemmerParams = disabledStemmerParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DisabledStemmerParams as object ??
            SnowballParams as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SnowballParams?.ToString() ??
            DisabledStemmerParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSnowballParams || IsDisabledStemmerParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.SnowballParams, TResult>? snowballParams = null,
            global::System.Func<global::Qdrant.DisabledStemmerParams, TResult>? disabledStemmerParams = null,
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
            else if (IsDisabledStemmerParams && disabledStemmerParams != null)
            {
                return disabledStemmerParams(DisabledStemmerParams!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.SnowballParams>? snowballParams = null,

            global::System.Action<global::Qdrant.DisabledStemmerParams>? disabledStemmerParams = null,
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
            else if (IsDisabledStemmerParams)
            {
                disabledStemmerParams?.Invoke(DisabledStemmerParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.SnowballParams>? snowballParams = null,
            global::System.Action<global::Qdrant.DisabledStemmerParams>? disabledStemmerParams = null,
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
            else if (IsDisabledStemmerParams)
            {
                disabledStemmerParams?.Invoke(DisabledStemmerParams!);
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
                DisabledStemmerParams,
                typeof(global::Qdrant.DisabledStemmerParams),
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
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SnowballParams?>.Default.Equals(SnowballParams, other.SnowballParams) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DisabledStemmerParams?>.Default.Equals(DisabledStemmerParams, other.DisabledStemmerParams) 
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
