#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Condition : global::System.IEquatable<Condition>
    {
        /// <summary>
        /// All possible payload filtering conditions
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.FieldCondition? Field { get; init; }
#else
        public global::Qdrant.FieldCondition? Field { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Field))]
#endif
        public bool IsField => Field != null;

        /// <summary>
        /// Select points with empty payload for a specified field
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.IsEmptyCondition? IsEmpty { get; init; }
#else
        public global::Qdrant.IsEmptyCondition? IsEmpty { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IsEmpty))]
#endif
        public bool IsIsEmpty => IsEmpty != null;

        /// <summary>
        /// Select points with null payload for a specified field
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.IsNullCondition? IsNull { get; init; }
#else
        public global::Qdrant.IsNullCondition? IsNull { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IsNull))]
#endif
        public bool IsIsNull => IsNull != null;

        /// <summary>
        /// ID-based filtering condition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.HasIdCondition? HasId { get; init; }
#else
        public global::Qdrant.HasIdCondition? HasId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HasId))]
#endif
        public bool IsHasId => HasId != null;

        /// <summary>
        /// Filter points which have specific vector assigned
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.HasVectorCondition? HasVector { get; init; }
#else
        public global::Qdrant.HasVectorCondition? HasVector { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HasVector))]
#endif
        public bool IsHasVector => HasVector != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.NestedCondition? Nested { get; init; }
#else
        public global::Qdrant.NestedCondition? Nested { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Nested))]
#endif
        public bool IsNested => Nested != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Filter? Filter { get; init; }
#else
        public global::Qdrant.Filter? Filter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Filter))]
#endif
        public bool IsFilter => Filter != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::Qdrant.FieldCondition value) => new Condition((global::Qdrant.FieldCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.FieldCondition?(Condition @this) => @this.Field;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::Qdrant.FieldCondition? value)
        {
            Field = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::Qdrant.IsEmptyCondition value) => new Condition((global::Qdrant.IsEmptyCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.IsEmptyCondition?(Condition @this) => @this.IsEmpty;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::Qdrant.IsEmptyCondition? value)
        {
            IsEmpty = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::Qdrant.IsNullCondition value) => new Condition((global::Qdrant.IsNullCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.IsNullCondition?(Condition @this) => @this.IsNull;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::Qdrant.IsNullCondition? value)
        {
            IsNull = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::Qdrant.HasIdCondition value) => new Condition((global::Qdrant.HasIdCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.HasIdCondition?(Condition @this) => @this.HasId;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::Qdrant.HasIdCondition? value)
        {
            HasId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::Qdrant.HasVectorCondition value) => new Condition((global::Qdrant.HasVectorCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.HasVectorCondition?(Condition @this) => @this.HasVector;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::Qdrant.HasVectorCondition? value)
        {
            HasVector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::Qdrant.NestedCondition value) => new Condition((global::Qdrant.NestedCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.NestedCondition?(Condition @this) => @this.Nested;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::Qdrant.NestedCondition? value)
        {
            Nested = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::Qdrant.Filter value) => new Condition((global::Qdrant.Filter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Filter?(Condition @this) => @this.Filter;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::Qdrant.Filter? value)
        {
            Filter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Condition(
            global::Qdrant.FieldCondition? field,
            global::Qdrant.IsEmptyCondition? isEmpty,
            global::Qdrant.IsNullCondition? isNull,
            global::Qdrant.HasIdCondition? hasId,
            global::Qdrant.HasVectorCondition? hasVector,
            global::Qdrant.NestedCondition? nested,
            global::Qdrant.Filter? filter
            )
        {
            Field = field;
            IsEmpty = isEmpty;
            IsNull = isNull;
            HasId = hasId;
            HasVector = hasVector;
            Nested = nested;
            Filter = filter;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Filter as object ??
            Nested as object ??
            HasVector as object ??
            HasId as object ??
            IsNull as object ??
            IsEmpty as object ??
            Field as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Field?.ToString() ??
            IsEmpty?.ToString() ??
            IsNull?.ToString() ??
            HasId?.ToString() ??
            HasVector?.ToString() ??
            Nested?.ToString() ??
            Filter?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsField || IsIsEmpty || IsIsNull || IsHasId || IsHasVector || IsNested || IsFilter;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.FieldCondition?, TResult>? field = null,
            global::System.Func<global::Qdrant.IsEmptyCondition?, TResult>? isEmpty = null,
            global::System.Func<global::Qdrant.IsNullCondition?, TResult>? isNull = null,
            global::System.Func<global::Qdrant.HasIdCondition?, TResult>? hasId = null,
            global::System.Func<global::Qdrant.HasVectorCondition?, TResult>? hasVector = null,
            global::System.Func<global::Qdrant.NestedCondition?, TResult>? nested = null,
            global::System.Func<global::Qdrant.Filter?, TResult>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsField && field != null)
            {
                return field(Field!);
            }
            else if (IsIsEmpty && isEmpty != null)
            {
                return isEmpty(IsEmpty!);
            }
            else if (IsIsNull && isNull != null)
            {
                return isNull(IsNull!);
            }
            else if (IsHasId && hasId != null)
            {
                return hasId(HasId!);
            }
            else if (IsHasVector && hasVector != null)
            {
                return hasVector(HasVector!);
            }
            else if (IsNested && nested != null)
            {
                return nested(Nested!);
            }
            else if (IsFilter && filter != null)
            {
                return filter(Filter!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.FieldCondition?>? field = null,
            global::System.Action<global::Qdrant.IsEmptyCondition?>? isEmpty = null,
            global::System.Action<global::Qdrant.IsNullCondition?>? isNull = null,
            global::System.Action<global::Qdrant.HasIdCondition?>? hasId = null,
            global::System.Action<global::Qdrant.HasVectorCondition?>? hasVector = null,
            global::System.Action<global::Qdrant.NestedCondition?>? nested = null,
            global::System.Action<global::Qdrant.Filter?>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsField)
            {
                field?.Invoke(Field!);
            }
            else if (IsIsEmpty)
            {
                isEmpty?.Invoke(IsEmpty!);
            }
            else if (IsIsNull)
            {
                isNull?.Invoke(IsNull!);
            }
            else if (IsHasId)
            {
                hasId?.Invoke(HasId!);
            }
            else if (IsHasVector)
            {
                hasVector?.Invoke(HasVector!);
            }
            else if (IsNested)
            {
                nested?.Invoke(Nested!);
            }
            else if (IsFilter)
            {
                filter?.Invoke(Filter!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Field,
                typeof(global::Qdrant.FieldCondition),
                IsEmpty,
                typeof(global::Qdrant.IsEmptyCondition),
                IsNull,
                typeof(global::Qdrant.IsNullCondition),
                HasId,
                typeof(global::Qdrant.HasIdCondition),
                HasVector,
                typeof(global::Qdrant.HasVectorCondition),
                Nested,
                typeof(global::Qdrant.NestedCondition),
                Filter,
                typeof(global::Qdrant.Filter),
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
        public bool Equals(Condition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.FieldCondition?>.Default.Equals(Field, other.Field) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.IsEmptyCondition?>.Default.Equals(IsEmpty, other.IsEmpty) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.IsNullCondition?>.Default.Equals(IsNull, other.IsNull) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.HasIdCondition?>.Default.Equals(HasId, other.HasId) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.HasVectorCondition?>.Default.Equals(HasVector, other.HasVector) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.NestedCondition?>.Default.Equals(Nested, other.Nested) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Filter?>.Default.Equals(Filter, other.Filter) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Condition obj1, Condition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Condition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Condition obj1, Condition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Condition o && Equals(o);
        }
    }
}
