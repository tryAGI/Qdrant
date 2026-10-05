#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SparseVectorStorageType : global::System.IEquatable<SparseVectorStorageType>
    {
        /// <summary>
        /// Storage in memory maps (gridstore storage)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SparseVectorStorageTypeEnum? Enum { get; init; }
#else
        public global::Qdrant.SparseVectorStorageTypeEnum? Enum { get; }
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
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.SparseVectorStorageTypeEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVectorStorageTypeEnum PickEnum() => Enum is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SparseVectorStorageType(global::Qdrant.SparseVectorStorageTypeEnum value) => new SparseVectorStorageType((global::Qdrant.SparseVectorStorageTypeEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.SparseVectorStorageTypeEnum?(SparseVectorStorageType @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public SparseVectorStorageType(global::Qdrant.SparseVectorStorageTypeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SparseVectorStorageType FromEnum(global::Qdrant.SparseVectorStorageTypeEnum? value) => new SparseVectorStorageType(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enum as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.SparseVectorStorageTypeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enum is { } __value0 && @enum != null)
            {
                return @enum(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.SparseVectorStorageTypeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enum is { } __value0)
            {
                @enum?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.SparseVectorStorageTypeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enum is { } __value0)
            {
                @enum?.Invoke(__value0);
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
                typeof(global::Qdrant.SparseVectorStorageTypeEnum),
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
        public bool Equals(SparseVectorStorageType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SparseVectorStorageTypeEnum?>.Default.Equals(Enum, other.Enum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SparseVectorStorageType obj1, SparseVectorStorageType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SparseVectorStorageType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SparseVectorStorageType obj1, SparseVectorStorageType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SparseVectorStorageType o && Equals(o);
        }
    }
}
