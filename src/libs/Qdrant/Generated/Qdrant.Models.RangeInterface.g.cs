#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RangeInterface : global::System.IEquatable<RangeInterface>
    {
        /// <summary>
        /// Range filter request
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Range? Range { get; init; }
#else
        public global::Qdrant.Range? Range { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Range))]
#endif
        public bool IsRange => Range != null;

        /// <summary>
        /// Range filter request
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DatetimeRange? Datetime { get; init; }
#else
        public global::Qdrant.DatetimeRange? Datetime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Datetime))]
#endif
        public bool IsDatetime => Datetime != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RangeInterface(global::Qdrant.Range value) => new RangeInterface((global::Qdrant.Range?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Range?(RangeInterface @this) => @this.Range;

        /// <summary>
        /// 
        /// </summary>
        public RangeInterface(global::Qdrant.Range? value)
        {
            Range = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RangeInterface(global::Qdrant.DatetimeRange value) => new RangeInterface((global::Qdrant.DatetimeRange?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DatetimeRange?(RangeInterface @this) => @this.Datetime;

        /// <summary>
        /// 
        /// </summary>
        public RangeInterface(global::Qdrant.DatetimeRange? value)
        {
            Datetime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RangeInterface(
            global::Qdrant.Range? range,
            global::Qdrant.DatetimeRange? datetime
            )
        {
            Range = range;
            Datetime = datetime;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Datetime as object ??
            Range as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Range?.ToString() ??
            Datetime?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRange || IsDatetime;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.Range?, TResult>? range = null,
            global::System.Func<global::Qdrant.DatetimeRange?, TResult>? datetime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRange && range != null)
            {
                return range(Range!);
            }
            else if (IsDatetime && datetime != null)
            {
                return datetime(Datetime!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.Range?>? range = null,
            global::System.Action<global::Qdrant.DatetimeRange?>? datetime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRange)
            {
                range?.Invoke(Range!);
            }
            else if (IsDatetime)
            {
                datetime?.Invoke(Datetime!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Range,
                typeof(global::Qdrant.Range),
                Datetime,
                typeof(global::Qdrant.DatetimeRange),
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
        public bool Equals(RangeInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Range?>.Default.Equals(Range, other.Range) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DatetimeRange?>.Default.Equals(Datetime, other.Datetime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RangeInterface obj1, RangeInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RangeInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RangeInterface obj1, RangeInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RangeInterface o && Equals(o);
        }
    }
}
