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
        ///
        /// </summary>
        public bool TryPickField(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.FieldCondition? value)
        {
            value = Field;
            return IsField;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FieldCondition PickField() => Field is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Field' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickIsEmpty(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.IsEmptyCondition? value)
        {
            value = IsEmpty;
            return IsIsEmpty;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsEmptyCondition PickIsEmpty() => IsEmpty is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IsEmpty' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickIsNull(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.IsNullCondition? value)
        {
            value = IsNull;
            return IsIsNull;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IsNullCondition PickIsNull() => IsNull is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IsNull' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickHasId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.HasIdCondition? value)
        {
            value = HasId;
            return IsHasId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasIdCondition PickHasId() => HasId is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HasId' but the value was {ToString()}.");

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
        public bool TryPickHasVector(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.HasVectorCondition? value)
        {
            value = HasVector;
            return IsHasVector;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.HasVectorCondition PickHasVector() => HasVector is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HasVector' but the value was {ToString()}.");

        /// <summary>
        /// Select points that fall into one of `total` disjoint deterministic slices of the id space, for parallel scans and reproducible sampling.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SliceCondition? Slice { get; init; }
#else
        public global::Qdrant.SliceCondition? Slice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Slice))]
#endif
        public bool IsSlice => Slice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.SliceCondition? value)
        {
            value = Slice;
            return IsSlice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SliceCondition PickSlice() => Slice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Slice' but the value was {ToString()}.");

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
        public bool TryPickNested(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.NestedCondition? value)
        {
            value = Nested;
            return IsNested;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.NestedCondition PickNested() => Nested is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Nested' but the value was {ToString()}.");

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
        public bool TryPickFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.Filter? value)
        {
            value = Filter;
            return IsFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Filter PickFilter() => Filter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Filter' but the value was {ToString()}.");
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
        public static Condition FromField(global::Qdrant.FieldCondition? value) => new Condition(value);

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
        public static Condition FromIsEmpty(global::Qdrant.IsEmptyCondition? value) => new Condition(value);

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
        public static Condition FromIsNull(global::Qdrant.IsNullCondition? value) => new Condition(value);

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
        public static Condition FromHasId(global::Qdrant.HasIdCondition? value) => new Condition(value);

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
        public static Condition FromHasVector(global::Qdrant.HasVectorCondition? value) => new Condition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Condition(global::Qdrant.SliceCondition value) => new Condition((global::Qdrant.SliceCondition?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.SliceCondition?(Condition @this) => @this.Slice;

        /// <summary>
        ///
        /// </summary>
        public Condition(global::Qdrant.SliceCondition? value)
        {
            Slice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Condition FromSlice(global::Qdrant.SliceCondition? value) => new Condition(value);

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
        public static Condition FromNested(global::Qdrant.NestedCondition? value) => new Condition(value);

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
        public static Condition FromFilter(global::Qdrant.Filter? value) => new Condition(value);

        /// <summary>
        ///
        /// </summary>
        public Condition(
            global::Qdrant.FieldCondition? field,
            global::Qdrant.IsEmptyCondition? isEmpty,
            global::Qdrant.IsNullCondition? isNull,
            global::Qdrant.HasIdCondition? hasId,
            global::Qdrant.HasVectorCondition? hasVector,
            global::Qdrant.SliceCondition? slice,
            global::Qdrant.NestedCondition? nested,
            global::Qdrant.Filter? filter
            )
        {
            Field = field;
            IsEmpty = isEmpty;
            IsNull = isNull;
            HasId = hasId;
            HasVector = hasVector;
            Slice = slice;
            Nested = nested;
            Filter = filter;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Filter as object ??
            Nested as object ??
            Slice as object ??
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
            Slice?.ToString() ??
            Nested?.ToString() ??
            Filter?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsField || IsIsEmpty || IsIsNull || IsHasId || IsHasVector || IsSlice || IsNested || IsFilter;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.FieldCondition, TResult>? field = null,
            global::System.Func<global::Qdrant.IsEmptyCondition, TResult>? isEmpty = null,
            global::System.Func<global::Qdrant.IsNullCondition, TResult>? isNull = null,
            global::System.Func<global::Qdrant.HasIdCondition, TResult>? hasId = null,
            global::System.Func<global::Qdrant.HasVectorCondition, TResult>? hasVector = null,
            global::System.Func<global::Qdrant.SliceCondition, TResult>? slice = null,
            global::System.Func<global::Qdrant.NestedCondition, TResult>? nested = null,
            global::System.Func<global::Qdrant.Filter, TResult>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Field is { } __value0 && field != null)
            {
                return field(__value0);
            }
            else if (IsEmpty is { } __value1 && isEmpty != null)
            {
                return isEmpty(__value1);
            }
            else if (IsNull is { } __value2 && isNull != null)
            {
                return isNull(__value2);
            }
            else if (HasId is { } __value3 && hasId != null)
            {
                return hasId(__value3);
            }
            else if (HasVector is { } __value4 && hasVector != null)
            {
                return hasVector(__value4);
            }
            else if (Slice is { } __value5 && slice != null)
            {
                return slice(__value5);
            }
            else if (Nested is { } __value6 && nested != null)
            {
                return nested(__value6);
            }
            else if (Filter is { } __value7 && filter != null)
            {
                return filter(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.FieldCondition>? field = null,

            global::System.Action<global::Qdrant.IsEmptyCondition>? isEmpty = null,

            global::System.Action<global::Qdrant.IsNullCondition>? isNull = null,

            global::System.Action<global::Qdrant.HasIdCondition>? hasId = null,

            global::System.Action<global::Qdrant.HasVectorCondition>? hasVector = null,

            global::System.Action<global::Qdrant.SliceCondition>? slice = null,

            global::System.Action<global::Qdrant.NestedCondition>? nested = null,

            global::System.Action<global::Qdrant.Filter>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Field is { } __value0)
            {
                field?.Invoke(__value0);
            }
            else if (IsEmpty is { } __value1)
            {
                isEmpty?.Invoke(__value1);
            }
            else if (IsNull is { } __value2)
            {
                isNull?.Invoke(__value2);
            }
            else if (HasId is { } __value3)
            {
                hasId?.Invoke(__value3);
            }
            else if (HasVector is { } __value4)
            {
                hasVector?.Invoke(__value4);
            }
            else if (Slice is { } __value5)
            {
                slice?.Invoke(__value5);
            }
            else if (Nested is { } __value6)
            {
                nested?.Invoke(__value6);
            }
            else if (Filter is { } __value7)
            {
                filter?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.FieldCondition>? field = null,
            global::System.Action<global::Qdrant.IsEmptyCondition>? isEmpty = null,
            global::System.Action<global::Qdrant.IsNullCondition>? isNull = null,
            global::System.Action<global::Qdrant.HasIdCondition>? hasId = null,
            global::System.Action<global::Qdrant.HasVectorCondition>? hasVector = null,
            global::System.Action<global::Qdrant.SliceCondition>? slice = null,
            global::System.Action<global::Qdrant.NestedCondition>? nested = null,
            global::System.Action<global::Qdrant.Filter>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Field is { } __value0)
            {
                field?.Invoke(__value0);
            }
            else if (IsEmpty is { } __value1)
            {
                isEmpty?.Invoke(__value1);
            }
            else if (IsNull is { } __value2)
            {
                isNull?.Invoke(__value2);
            }
            else if (HasId is { } __value3)
            {
                hasId?.Invoke(__value3);
            }
            else if (HasVector is { } __value4)
            {
                hasVector?.Invoke(__value4);
            }
            else if (Slice is { } __value5)
            {
                slice?.Invoke(__value5);
            }
            else if (Nested is { } __value6)
            {
                nested?.Invoke(__value6);
            }
            else if (Filter is { } __value7)
            {
                filter?.Invoke(__value7);
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
                Slice,
                typeof(global::Qdrant.SliceCondition),
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
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SliceCondition?>.Default.Equals(Slice, other.Slice) &&
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
