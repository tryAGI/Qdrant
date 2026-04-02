#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Represents the current state of the optimizer being tracked
    /// </summary>
    public readonly partial struct TrackerStatus : global::System.IEquatable<TrackerStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.TrackerStatusEnum? Enum { get; init; }
#else
        public global::Qdrant.TrackerStatusEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.TrackerStatusEnum2? Enum2 { get; init; }
#else
        public global::Qdrant.TrackerStatusEnum2? Enum2 { get; }
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
#if NET6_0_OR_GREATER
        public global::Qdrant.TrackerStatusEnum3? Enum3 { get; init; }
#else
        public global::Qdrant.TrackerStatusEnum3? Enum3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum3))]
#endif
        public bool IsEnum3 => Enum3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackerStatus(global::Qdrant.TrackerStatusEnum value) => new TrackerStatus((global::Qdrant.TrackerStatusEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.TrackerStatusEnum?(TrackerStatus @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public TrackerStatus(global::Qdrant.TrackerStatusEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackerStatus(global::Qdrant.TrackerStatusEnum2 value) => new TrackerStatus((global::Qdrant.TrackerStatusEnum2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.TrackerStatusEnum2?(TrackerStatus @this) => @this.Enum2;

        /// <summary>
        /// 
        /// </summary>
        public TrackerStatus(global::Qdrant.TrackerStatusEnum2? value)
        {
            Enum2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrackerStatus(global::Qdrant.TrackerStatusEnum3 value) => new TrackerStatus((global::Qdrant.TrackerStatusEnum3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.TrackerStatusEnum3?(TrackerStatus @this) => @this.Enum3;

        /// <summary>
        /// 
        /// </summary>
        public TrackerStatus(global::Qdrant.TrackerStatusEnum3? value)
        {
            Enum3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TrackerStatus(
            global::Qdrant.TrackerStatusEnum? @enum,
            global::Qdrant.TrackerStatusEnum2? enum2,
            global::Qdrant.TrackerStatusEnum3? enum3
            )
        {
            Enum = @enum;
            Enum2 = enum2;
            Enum3 = enum3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum3 as object ??
            Enum2 as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            Enum2?.ToString() ??
            Enum3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsEnum2 && !IsEnum3 || !IsEnum && IsEnum2 && !IsEnum3 || !IsEnum && !IsEnum2 && IsEnum3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.TrackerStatusEnum?, TResult>? @enum = null,
            global::System.Func<global::Qdrant.TrackerStatusEnum2?, TResult>? enum2 = null,
            global::System.Func<global::Qdrant.TrackerStatusEnum3?, TResult>? enum3 = null,
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
            else if (IsEnum3 && enum3 != null)
            {
                return enum3(Enum3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.TrackerStatusEnum?>? @enum = null,
            global::System.Action<global::Qdrant.TrackerStatusEnum2?>? enum2 = null,
            global::System.Action<global::Qdrant.TrackerStatusEnum3?>? enum3 = null,
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
            else if (IsEnum3)
            {
                enum3?.Invoke(Enum3!);
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
                typeof(global::Qdrant.TrackerStatusEnum),
                Enum2,
                typeof(global::Qdrant.TrackerStatusEnum2),
                Enum3,
                typeof(global::Qdrant.TrackerStatusEnum3),
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
        public bool Equals(TrackerStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.TrackerStatusEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.TrackerStatusEnum2?>.Default.Equals(Enum2, other.Enum2) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.TrackerStatusEnum3?>.Default.Equals(Enum3, other.Enum3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrackerStatus obj1, TrackerStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackerStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrackerStatus obj1, TrackerStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackerStatus o && Equals(o);
        }
    }
}
