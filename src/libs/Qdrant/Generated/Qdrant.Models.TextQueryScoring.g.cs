#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Parameters of one scorer, keyed by its name.
    /// </summary>
    public readonly partial struct TextQueryScoring : global::System.IEquatable<TextQueryScoring>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Bm25Scoring? Bm25 { get; init; }
#else
        public global::Qdrant.Bm25Scoring? Bm25 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bm25))]
#endif
        public bool IsBm25 => Bm25 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBm25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.Bm25Scoring? value)
        {
            value = Bm25;
            return IsBm25;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Bm25Scoring PickBm25() => Bm25 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bm25' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextQueryScoring(global::Qdrant.Bm25Scoring value) => new TextQueryScoring((global::Qdrant.Bm25Scoring?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.Bm25Scoring?(TextQueryScoring @this) => @this.Bm25;

        /// <summary>
        ///
        /// </summary>
        public TextQueryScoring(global::Qdrant.Bm25Scoring? value)
        {
            Bm25 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextQueryScoring FromBm25(global::Qdrant.Bm25Scoring? value) => new TextQueryScoring(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Bm25 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Bm25?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBm25;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.Bm25Scoring, TResult>? bm25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bm25 is { } __value0 && bm25 != null)
            {
                return bm25(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.Bm25Scoring>? bm25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bm25 is { } __value0)
            {
                bm25?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.Bm25Scoring>? bm25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bm25 is { } __value0)
            {
                bm25?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Bm25,
                typeof(global::Qdrant.Bm25Scoring),
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
        public bool Equals(TextQueryScoring other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Bm25Scoring?>.Default.Equals(Bm25, other.Bm25)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextQueryScoring obj1, TextQueryScoring obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextQueryScoring>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextQueryScoring obj1, TextQueryScoring obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextQueryScoring o && Equals(o);
        }
    }
}
