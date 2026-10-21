#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// The text to search for, or the text with scorer parameters.
    /// </summary>
    public readonly partial struct TextInterface : global::System.IEquatable<TextInterface>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TextInterfaceVariant1 { get; init; }
#else
        public string? TextInterfaceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextInterfaceVariant1))]
#endif
        public bool IsTextInterfaceVariant1 => TextInterfaceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextInterfaceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = TextInterfaceVariant1;
            return IsTextInterfaceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickTextInterfaceVariant1() => TextInterfaceVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextInterfaceVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.TextQueryInput? QueryInput { get; init; }
#else
        public global::Qdrant.TextQueryInput? QueryInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueryInput))]
#endif
        public bool IsQueryInput => QueryInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickQueryInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.TextQueryInput? value)
        {
            value = QueryInput;
            return IsQueryInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextQueryInput PickQueryInput() => QueryInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'QueryInput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextInterface(string value) => new TextInterface((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(TextInterface @this) => @this.TextInterfaceVariant1;

        /// <summary>
        ///
        /// </summary>
        public TextInterface(string? value)
        {
            TextInterfaceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextInterface FromTextInterfaceVariant1(string? value) => new TextInterface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextInterface(global::Qdrant.TextQueryInput value) => new TextInterface((global::Qdrant.TextQueryInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.TextQueryInput?(TextInterface @this) => @this.QueryInput;

        /// <summary>
        ///
        /// </summary>
        public TextInterface(global::Qdrant.TextQueryInput? value)
        {
            QueryInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextInterface FromQueryInput(global::Qdrant.TextQueryInput? value) => new TextInterface(value);

        /// <summary>
        ///
        /// </summary>
        public TextInterface(
            string? textInterfaceVariant1,
            global::Qdrant.TextQueryInput? queryInput
            )
        {
            TextInterfaceVariant1 = textInterfaceVariant1;
            QueryInput = queryInput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            QueryInput as object ??
            TextInterfaceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TextInterfaceVariant1?.ToString() ??
            QueryInput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTextInterfaceVariant1 || IsQueryInput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? textInterfaceVariant1 = null,
            global::System.Func<global::Qdrant.TextQueryInput, TResult>? queryInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextInterfaceVariant1 is { } __value0 && textInterfaceVariant1 != null)
            {
                return textInterfaceVariant1(__value0);
            }
            else if (QueryInput is { } __value1 && queryInput != null)
            {
                return queryInput(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? textInterfaceVariant1 = null,

            global::System.Action<global::Qdrant.TextQueryInput>? queryInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextInterfaceVariant1 is { } __value0)
            {
                textInterfaceVariant1?.Invoke(__value0);
            }
            else if (QueryInput is { } __value1)
            {
                queryInput?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? textInterfaceVariant1 = null,
            global::System.Action<global::Qdrant.TextQueryInput>? queryInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextInterfaceVariant1 is { } __value0)
            {
                textInterfaceVariant1?.Invoke(__value0);
            }
            else if (QueryInput is { } __value1)
            {
                queryInput?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextInterfaceVariant1,
                typeof(string),
                QueryInput,
                typeof(global::Qdrant.TextQueryInput),
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
        public bool Equals(TextInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TextInterfaceVariant1, other.TextInterfaceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.TextQueryInput?>.Default.Equals(QueryInput, other.QueryInput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextInterface obj1, TextInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextInterface obj1, TextInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextInterface o && Equals(o);
        }
    }
}
