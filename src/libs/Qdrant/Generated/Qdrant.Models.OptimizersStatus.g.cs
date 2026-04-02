#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Current state of the collection
    /// </summary>
    public readonly partial struct OptimizersStatus : global::System.IEquatable<OptimizersStatus>
    {
        /// <summary>
        /// Optimizers are reporting as expected
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.OptimizersStatusEnum? Enum { get; init; }
#else
        public global::Qdrant.OptimizersStatusEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// Something wrong happened with optimizers
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.OptimizersStatusEnum2? Enum2 { get; init; }
#else
        public global::Qdrant.OptimizersStatusEnum2? Enum2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum2))]
#endif
        public bool IsEnum2 => Enum2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OptimizersStatus(global::Qdrant.OptimizersStatusEnum value) => new OptimizersStatus((global::Qdrant.OptimizersStatusEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.OptimizersStatusEnum?(OptimizersStatus @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public OptimizersStatus(global::Qdrant.OptimizersStatusEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OptimizersStatus(global::Qdrant.OptimizersStatusEnum2 value) => new OptimizersStatus((global::Qdrant.OptimizersStatusEnum2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.OptimizersStatusEnum2?(OptimizersStatus @this) => @this.Enum2;

        /// <summary>
        /// 
        /// </summary>
        public OptimizersStatus(global::Qdrant.OptimizersStatusEnum2? value)
        {
            Enum2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OptimizersStatus(
            global::Qdrant.OptimizersStatusEnum? @enum,
            global::Qdrant.OptimizersStatusEnum2? enum2
            )
        {
            Enum = @enum;
            Enum2 = enum2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum2 as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            Enum2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsEnum2 || !IsEnum && IsEnum2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.OptimizersStatusEnum?, TResult>? @enum = null,
            global::System.Func<global::Qdrant.OptimizersStatusEnum2?, TResult>? enum2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsEnum2 && enum2 != null)
            {
                return enum2(Enum2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.OptimizersStatusEnum?>? @enum = null,
            global::System.Action<global::Qdrant.OptimizersStatusEnum2?>? enum2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsEnum2)
            {
                enum2?.Invoke(Enum2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::Qdrant.OptimizersStatusEnum),
                Enum2,
                typeof(global::Qdrant.OptimizersStatusEnum2),
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
        public bool Equals(OptimizersStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.OptimizersStatusEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.OptimizersStatusEnum2?>.Default.Equals(Enum2, other.Enum2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OptimizersStatus obj1, OptimizersStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OptimizersStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OptimizersStatus obj1, OptimizersStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OptimizersStatus o && Equals(o);
        }
    }
}
