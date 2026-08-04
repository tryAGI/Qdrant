#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Population over which sparse vector IDF statistics are computed for scoring — the *IDF corpus*.<br/>
    /// - `"global"` — collection-wide statistics, same as omitting the parameter. - `{ "corpus": &lt;filter&gt; }` — document count and per-term document frequencies are computed over the points matching the corpus filter only. The corpus is independent of the retrieval filter and is usually broader than it.
    /// </summary>
    public readonly partial struct IdfParams : global::System.IEquatable<IdfParams>
    {
        /// <summary>
        /// Named IDF scope without a corpus filter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.IdfScope? Scope { get; init; }
#else
        public global::Qdrant.IdfScope? Scope { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scope))]
#endif
        public bool IsScope => Scope != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScope(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.IdfScope? value)
        {
            value = Scope;
            return IsScope;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.IdfScope PickScope() => IsScope
            ? Scope!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scope' but the value was {ToString()}.");

        /// <summary>
        /// IDF statistics computed over the points matching a corpus filter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.IdfCorpusParams? Corpus { get; init; }
#else
        public global::Qdrant.IdfCorpusParams? Corpus { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Corpus))]
#endif
        public bool IsCorpus => Corpus != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCorpus(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.IdfCorpusParams? value)
        {
            value = Corpus;
            return IsCorpus;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.IdfCorpusParams PickCorpus() => IsCorpus
            ? Corpus!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Corpus' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IdfParams(global::Qdrant.IdfScope value) => new IdfParams((global::Qdrant.IdfScope?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.IdfScope?(IdfParams @this) => @this.Scope;

        /// <summary>
        /// 
        /// </summary>
        public IdfParams(global::Qdrant.IdfScope? value)
        {
            Scope = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IdfParams FromScope(global::Qdrant.IdfScope? value) => new IdfParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IdfParams(global::Qdrant.IdfCorpusParams value) => new IdfParams((global::Qdrant.IdfCorpusParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.IdfCorpusParams?(IdfParams @this) => @this.Corpus;

        /// <summary>
        /// 
        /// </summary>
        public IdfParams(global::Qdrant.IdfCorpusParams? value)
        {
            Corpus = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IdfParams FromCorpus(global::Qdrant.IdfCorpusParams? value) => new IdfParams(value);

        /// <summary>
        /// 
        /// </summary>
        public IdfParams(
            global::Qdrant.IdfScope? scope,
            global::Qdrant.IdfCorpusParams? corpus
            )
        {
            Scope = scope;
            Corpus = corpus;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Corpus as object ??
            Scope as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Scope?.ToValueString() ??
            Corpus?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScope || IsCorpus;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.IdfScope?, TResult>? scope = null,
            global::System.Func<global::Qdrant.IdfCorpusParams, TResult>? corpus = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScope && scope != null)
            {
                return scope(Scope!);
            }
            else if (IsCorpus && corpus != null)
            {
                return corpus(Corpus!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.IdfScope?>? scope = null,

            global::System.Action<global::Qdrant.IdfCorpusParams>? corpus = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScope)
            {
                scope?.Invoke(Scope!);
            }
            else if (IsCorpus)
            {
                corpus?.Invoke(Corpus!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.IdfScope?>? scope = null,
            global::System.Action<global::Qdrant.IdfCorpusParams>? corpus = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScope)
            {
                scope?.Invoke(Scope!);
            }
            else if (IsCorpus)
            {
                corpus?.Invoke(Corpus!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Scope,
                typeof(global::Qdrant.IdfScope),
                Corpus,
                typeof(global::Qdrant.IdfCorpusParams),
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
        public bool Equals(IdfParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.IdfScope?>.Default.Equals(Scope, other.Scope) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.IdfCorpusParams?>.Default.Equals(Corpus, other.Corpus) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IdfParams obj1, IdfParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IdfParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IdfParams obj1, IdfParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IdfParams o && Equals(o);
        }
    }
}
