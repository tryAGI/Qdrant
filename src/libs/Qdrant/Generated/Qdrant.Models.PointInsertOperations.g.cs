#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PointInsertOperations : global::System.IEquatable<PointInsertOperations>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.PointsBatch? PointsBatch { get; init; }
#else
        public global::Qdrant.PointsBatch? PointsBatch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PointsBatch))]
#endif
        public bool IsPointsBatch => PointsBatch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.PointsList? PointsList { get; init; }
#else
        public global::Qdrant.PointsList? PointsList { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PointsList))]
#endif
        public bool IsPointsList => PointsList != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PointInsertOperations(global::Qdrant.PointsBatch value) => new PointInsertOperations((global::Qdrant.PointsBatch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.PointsBatch?(PointInsertOperations @this) => @this.PointsBatch;

        /// <summary>
        /// 
        /// </summary>
        public PointInsertOperations(global::Qdrant.PointsBatch? value)
        {
            PointsBatch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PointInsertOperations(global::Qdrant.PointsList value) => new PointInsertOperations((global::Qdrant.PointsList?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.PointsList?(PointInsertOperations @this) => @this.PointsList;

        /// <summary>
        /// 
        /// </summary>
        public PointInsertOperations(global::Qdrant.PointsList? value)
        {
            PointsList = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PointInsertOperations(
            global::Qdrant.PointsBatch? pointsBatch,
            global::Qdrant.PointsList? pointsList
            )
        {
            PointsBatch = pointsBatch;
            PointsList = pointsList;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PointsList as object ??
            PointsBatch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PointsBatch?.ToString() ??
            PointsList?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPointsBatch || IsPointsList;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.PointsBatch?, TResult>? pointsBatch = null,
            global::System.Func<global::Qdrant.PointsList?, TResult>? pointsList = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPointsBatch && pointsBatch != null)
            {
                return pointsBatch(PointsBatch!);
            }
            else if (IsPointsList && pointsList != null)
            {
                return pointsList(PointsList!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.PointsBatch?>? pointsBatch = null,
            global::System.Action<global::Qdrant.PointsList?>? pointsList = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPointsBatch)
            {
                pointsBatch?.Invoke(PointsBatch!);
            }
            else if (IsPointsList)
            {
                pointsList?.Invoke(PointsList!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PointsBatch,
                typeof(global::Qdrant.PointsBatch),
                PointsList,
                typeof(global::Qdrant.PointsList),
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
        public bool Equals(PointInsertOperations other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.PointsBatch?>.Default.Equals(PointsBatch, other.PointsBatch) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.PointsList?>.Default.Equals(PointsList, other.PointsList) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PointInsertOperations obj1, PointInsertOperations obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PointInsertOperations>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PointInsertOperations obj1, PointInsertOperations obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PointInsertOperations o && Equals(o);
        }
    }
}
