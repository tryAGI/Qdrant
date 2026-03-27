#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Specifies how to treat payload selector
    /// </summary>
    public readonly partial struct PayloadSelector : global::System.IEquatable<PayloadSelector>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.PayloadSelectorInclude? Include { get; init; }
#else
        public global::Qdrant.PayloadSelectorInclude? Include { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Include))]
#endif
        public bool IsInclude => Include != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.PayloadSelectorExclude? Exclude { get; init; }
#else
        public global::Qdrant.PayloadSelectorExclude? Exclude { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exclude))]
#endif
        public bool IsExclude => Exclude != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSelector(global::Qdrant.PayloadSelectorInclude value) => new PayloadSelector((global::Qdrant.PayloadSelectorInclude?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.PayloadSelectorInclude?(PayloadSelector @this) => @this.Include;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSelector(global::Qdrant.PayloadSelectorInclude? value)
        {
            Include = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSelector(global::Qdrant.PayloadSelectorExclude value) => new PayloadSelector((global::Qdrant.PayloadSelectorExclude?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.PayloadSelectorExclude?(PayloadSelector @this) => @this.Exclude;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSelector(global::Qdrant.PayloadSelectorExclude? value)
        {
            Exclude = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PayloadSelector(
            global::Qdrant.PayloadSelectorInclude? include,
            global::Qdrant.PayloadSelectorExclude? exclude
            )
        {
            Include = include;
            Exclude = exclude;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Exclude as object ??
            Include as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Include?.ToString() ??
            Exclude?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInclude || IsExclude;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.PayloadSelectorInclude?, TResult>? include = null,
            global::System.Func<global::Qdrant.PayloadSelectorExclude?, TResult>? exclude = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInclude && include != null)
            {
                return include(Include!);
            }
            else if (IsExclude && exclude != null)
            {
                return exclude(Exclude!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.PayloadSelectorInclude?>? include = null,
            global::System.Action<global::Qdrant.PayloadSelectorExclude?>? exclude = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInclude)
            {
                include?.Invoke(Include!);
            }
            else if (IsExclude)
            {
                exclude?.Invoke(Exclude!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Include,
                typeof(global::Qdrant.PayloadSelectorInclude),
                Exclude,
                typeof(global::Qdrant.PayloadSelectorExclude),
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
        public bool Equals(PayloadSelector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.PayloadSelectorInclude?>.Default.Equals(Include, other.Include) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.PayloadSelectorExclude?>.Default.Equals(Exclude, other.Exclude) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PayloadSelector obj1, PayloadSelector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PayloadSelector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PayloadSelector obj1, PayloadSelector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PayloadSelector o && Equals(o);
        }
    }
}
