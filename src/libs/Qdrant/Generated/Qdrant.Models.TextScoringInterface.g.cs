#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// BM25 scoring for a text index: `true` for the default parameters, `false` to disable it, or the parameters themselves.
    /// </summary>
    public readonly partial struct TextScoringInterface : global::System.IEquatable<TextScoringInterface>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? TextScoringInterfaceVariant1 { get; init; }
#else
        public bool? TextScoringInterfaceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextScoringInterfaceVariant1))]
#endif
        public bool IsTextScoringInterfaceVariant1 => TextScoringInterfaceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextScoringInterfaceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = TextScoringInterfaceVariant1;
            return IsTextScoringInterfaceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickTextScoringInterfaceVariant1() => TextScoringInterfaceVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextScoringInterfaceVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Parameters of ranking over a text index. The index records the length of each document, which BM25 normalizes by. `k1` and `b` are set per query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.TextScoringParams? Params { get; init; }
#else
        public global::Qdrant.TextScoringParams? Params { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Params))]
#endif
        public bool IsParams => Params != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickParams(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.TextScoringParams? value)
        {
            value = Params;
            return IsParams;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextScoringParams PickParams() => Params is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Params' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextScoringInterface(bool value) => new TextScoringInterface((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(TextScoringInterface @this) => @this.TextScoringInterfaceVariant1;

        /// <summary>
        ///
        /// </summary>
        public TextScoringInterface(bool? value)
        {
            TextScoringInterfaceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextScoringInterface FromTextScoringInterfaceVariant1(bool? value) => new TextScoringInterface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextScoringInterface(global::Qdrant.TextScoringParams value) => new TextScoringInterface((global::Qdrant.TextScoringParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.TextScoringParams?(TextScoringInterface @this) => @this.Params;

        /// <summary>
        ///
        /// </summary>
        public TextScoringInterface(global::Qdrant.TextScoringParams? value)
        {
            Params = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextScoringInterface FromParams(global::Qdrant.TextScoringParams? value) => new TextScoringInterface(value);

        /// <summary>
        ///
        /// </summary>
        public TextScoringInterface(
            bool? textScoringInterfaceVariant1,
            global::Qdrant.TextScoringParams? @params
            )
        {
            TextScoringInterfaceVariant1 = textScoringInterfaceVariant1;
            Params = @params;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Params as object ??
            TextScoringInterfaceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TextScoringInterfaceVariant1?.ToString().ToLowerInvariant() ??
            Params?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTextScoringInterfaceVariant1 || IsParams;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? textScoringInterfaceVariant1 = null,
            global::System.Func<global::Qdrant.TextScoringParams, TResult>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextScoringInterfaceVariant1 is { } __value0 && textScoringInterfaceVariant1 != null)
            {
                return textScoringInterfaceVariant1(__value0);
            }
            else if (Params is { } __value1 && @params != null)
            {
                return @params(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<bool?>? textScoringInterfaceVariant1 = null,

            global::System.Action<global::Qdrant.TextScoringParams>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextScoringInterfaceVariant1 is { } __value0)
            {
                textScoringInterfaceVariant1?.Invoke(__value0);
            }
            else if (Params is { } __value1)
            {
                @params?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<bool?>? textScoringInterfaceVariant1 = null,
            global::System.Action<global::Qdrant.TextScoringParams>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextScoringInterfaceVariant1 is { } __value0)
            {
                textScoringInterfaceVariant1?.Invoke(__value0);
            }
            else if (Params is { } __value1)
            {
                @params?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextScoringInterfaceVariant1,
                typeof(bool),
                Params,
                typeof(global::Qdrant.TextScoringParams),
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
        public bool Equals(TextScoringInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(TextScoringInterfaceVariant1, other.TextScoringInterfaceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.TextScoringParams?>.Default.Equals(Params, other.Params)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextScoringInterface obj1, TextScoringInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextScoringInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextScoringInterface obj1, TextScoringInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextScoringInterface o && Equals(o);
        }
    }
}
