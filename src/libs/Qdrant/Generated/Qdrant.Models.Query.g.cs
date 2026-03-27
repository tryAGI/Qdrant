#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Query : global::System.IEquatable<Query>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.NearestQuery? Nearest { get; init; }
#else
        public global::Qdrant.NearestQuery? Nearest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Nearest))]
#endif
        public bool IsNearest => Nearest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.RecommendQuery? Recommend { get; init; }
#else
        public global::Qdrant.RecommendQuery? Recommend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Recommend))]
#endif
        public bool IsRecommend => Recommend != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DiscoverQuery? Discover { get; init; }
#else
        public global::Qdrant.DiscoverQuery? Discover { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Discover))]
#endif
        public bool IsDiscover => Discover != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ContextQuery? Context { get; init; }
#else
        public global::Qdrant.ContextQuery? Context { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Context))]
#endif
        public bool IsContext => Context != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.OrderByQuery? OrderBy { get; init; }
#else
        public global::Qdrant.OrderByQuery? OrderBy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrderBy))]
#endif
        public bool IsOrderBy => OrderBy != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.FusionQuery? Fusion { get; init; }
#else
        public global::Qdrant.FusionQuery? Fusion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fusion))]
#endif
        public bool IsFusion => Fusion != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.RrfQuery? Rrf { get; init; }
#else
        public global::Qdrant.RrfQuery? Rrf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rrf))]
#endif
        public bool IsRrf => Rrf != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.FormulaQuery? Formula { get; init; }
#else
        public global::Qdrant.FormulaQuery? Formula { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Formula))]
#endif
        public bool IsFormula => Formula != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SampleQuery? Sample { get; init; }
#else
        public global::Qdrant.SampleQuery? Sample { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sample))]
#endif
        public bool IsSample => Sample != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.RelevanceFeedbackQuery? RelevanceFeedback { get; init; }
#else
        public global::Qdrant.RelevanceFeedbackQuery? RelevanceFeedback { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RelevanceFeedback))]
#endif
        public bool IsRelevanceFeedback => RelevanceFeedback != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.NearestQuery value) => new Query((global::Qdrant.NearestQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.NearestQuery?(Query @this) => @this.Nearest;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.NearestQuery? value)
        {
            Nearest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.RecommendQuery value) => new Query((global::Qdrant.RecommendQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.RecommendQuery?(Query @this) => @this.Recommend;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.RecommendQuery? value)
        {
            Recommend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.DiscoverQuery value) => new Query((global::Qdrant.DiscoverQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DiscoverQuery?(Query @this) => @this.Discover;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.DiscoverQuery? value)
        {
            Discover = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.ContextQuery value) => new Query((global::Qdrant.ContextQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ContextQuery?(Query @this) => @this.Context;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.ContextQuery? value)
        {
            Context = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.OrderByQuery value) => new Query((global::Qdrant.OrderByQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.OrderByQuery?(Query @this) => @this.OrderBy;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.OrderByQuery? value)
        {
            OrderBy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.FusionQuery value) => new Query((global::Qdrant.FusionQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.FusionQuery?(Query @this) => @this.Fusion;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.FusionQuery? value)
        {
            Fusion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.RrfQuery value) => new Query((global::Qdrant.RrfQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.RrfQuery?(Query @this) => @this.Rrf;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.RrfQuery? value)
        {
            Rrf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.FormulaQuery value) => new Query((global::Qdrant.FormulaQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.FormulaQuery?(Query @this) => @this.Formula;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.FormulaQuery? value)
        {
            Formula = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.SampleQuery value) => new Query((global::Qdrant.SampleQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SampleQuery?(Query @this) => @this.Sample;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.SampleQuery? value)
        {
            Sample = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::Qdrant.RelevanceFeedbackQuery value) => new Query((global::Qdrant.RelevanceFeedbackQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.RelevanceFeedbackQuery?(Query @this) => @this.RelevanceFeedback;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::Qdrant.RelevanceFeedbackQuery? value)
        {
            RelevanceFeedback = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Query(
            global::Qdrant.NearestQuery? nearest,
            global::Qdrant.RecommendQuery? recommend,
            global::Qdrant.DiscoverQuery? discover,
            global::Qdrant.ContextQuery? context,
            global::Qdrant.OrderByQuery? orderBy,
            global::Qdrant.FusionQuery? fusion,
            global::Qdrant.RrfQuery? rrf,
            global::Qdrant.FormulaQuery? formula,
            global::Qdrant.SampleQuery? sample,
            global::Qdrant.RelevanceFeedbackQuery? relevanceFeedback
            )
        {
            Nearest = nearest;
            Recommend = recommend;
            Discover = discover;
            Context = context;
            OrderBy = orderBy;
            Fusion = fusion;
            Rrf = rrf;
            Formula = formula;
            Sample = sample;
            RelevanceFeedback = relevanceFeedback;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RelevanceFeedback as object ??
            Sample as object ??
            Formula as object ??
            Rrf as object ??
            Fusion as object ??
            OrderBy as object ??
            Context as object ??
            Discover as object ??
            Recommend as object ??
            Nearest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Nearest?.ToString() ??
            Recommend?.ToString() ??
            Discover?.ToString() ??
            Context?.ToString() ??
            OrderBy?.ToString() ??
            Fusion?.ToString() ??
            Rrf?.ToString() ??
            Formula?.ToString() ??
            Sample?.ToString() ??
            RelevanceFeedback?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNearest || IsRecommend || IsDiscover || IsContext || IsOrderBy || IsFusion || IsRrf || IsFormula || IsSample || IsRelevanceFeedback;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.NearestQuery?, TResult>? nearest = null,
            global::System.Func<global::Qdrant.RecommendQuery?, TResult>? recommend = null,
            global::System.Func<global::Qdrant.DiscoverQuery?, TResult>? discover = null,
            global::System.Func<global::Qdrant.ContextQuery?, TResult>? context = null,
            global::System.Func<global::Qdrant.OrderByQuery?, TResult>? orderBy = null,
            global::System.Func<global::Qdrant.FusionQuery?, TResult>? fusion = null,
            global::System.Func<global::Qdrant.RrfQuery?, TResult>? rrf = null,
            global::System.Func<global::Qdrant.FormulaQuery?, TResult>? formula = null,
            global::System.Func<global::Qdrant.SampleQuery?, TResult>? sample = null,
            global::System.Func<global::Qdrant.RelevanceFeedbackQuery?, TResult>? relevanceFeedback = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNearest && nearest != null)
            {
                return nearest(Nearest!);
            }
            else if (IsRecommend && recommend != null)
            {
                return recommend(Recommend!);
            }
            else if (IsDiscover && discover != null)
            {
                return discover(Discover!);
            }
            else if (IsContext && context != null)
            {
                return context(Context!);
            }
            else if (IsOrderBy && orderBy != null)
            {
                return orderBy(OrderBy!);
            }
            else if (IsFusion && fusion != null)
            {
                return fusion(Fusion!);
            }
            else if (IsRrf && rrf != null)
            {
                return rrf(Rrf!);
            }
            else if (IsFormula && formula != null)
            {
                return formula(Formula!);
            }
            else if (IsSample && sample != null)
            {
                return sample(Sample!);
            }
            else if (IsRelevanceFeedback && relevanceFeedback != null)
            {
                return relevanceFeedback(RelevanceFeedback!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.NearestQuery?>? nearest = null,
            global::System.Action<global::Qdrant.RecommendQuery?>? recommend = null,
            global::System.Action<global::Qdrant.DiscoverQuery?>? discover = null,
            global::System.Action<global::Qdrant.ContextQuery?>? context = null,
            global::System.Action<global::Qdrant.OrderByQuery?>? orderBy = null,
            global::System.Action<global::Qdrant.FusionQuery?>? fusion = null,
            global::System.Action<global::Qdrant.RrfQuery?>? rrf = null,
            global::System.Action<global::Qdrant.FormulaQuery?>? formula = null,
            global::System.Action<global::Qdrant.SampleQuery?>? sample = null,
            global::System.Action<global::Qdrant.RelevanceFeedbackQuery?>? relevanceFeedback = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNearest)
            {
                nearest?.Invoke(Nearest!);
            }
            else if (IsRecommend)
            {
                recommend?.Invoke(Recommend!);
            }
            else if (IsDiscover)
            {
                discover?.Invoke(Discover!);
            }
            else if (IsContext)
            {
                context?.Invoke(Context!);
            }
            else if (IsOrderBy)
            {
                orderBy?.Invoke(OrderBy!);
            }
            else if (IsFusion)
            {
                fusion?.Invoke(Fusion!);
            }
            else if (IsRrf)
            {
                rrf?.Invoke(Rrf!);
            }
            else if (IsFormula)
            {
                formula?.Invoke(Formula!);
            }
            else if (IsSample)
            {
                sample?.Invoke(Sample!);
            }
            else if (IsRelevanceFeedback)
            {
                relevanceFeedback?.Invoke(RelevanceFeedback!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Nearest,
                typeof(global::Qdrant.NearestQuery),
                Recommend,
                typeof(global::Qdrant.RecommendQuery),
                Discover,
                typeof(global::Qdrant.DiscoverQuery),
                Context,
                typeof(global::Qdrant.ContextQuery),
                OrderBy,
                typeof(global::Qdrant.OrderByQuery),
                Fusion,
                typeof(global::Qdrant.FusionQuery),
                Rrf,
                typeof(global::Qdrant.RrfQuery),
                Formula,
                typeof(global::Qdrant.FormulaQuery),
                Sample,
                typeof(global::Qdrant.SampleQuery),
                RelevanceFeedback,
                typeof(global::Qdrant.RelevanceFeedbackQuery),
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
        public bool Equals(Query other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.NearestQuery?>.Default.Equals(Nearest, other.Nearest) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.RecommendQuery?>.Default.Equals(Recommend, other.Recommend) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DiscoverQuery?>.Default.Equals(Discover, other.Discover) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ContextQuery?>.Default.Equals(Context, other.Context) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.OrderByQuery?>.Default.Equals(OrderBy, other.OrderBy) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.FusionQuery?>.Default.Equals(Fusion, other.Fusion) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.RrfQuery?>.Default.Equals(Rrf, other.Rrf) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.FormulaQuery?>.Default.Equals(Formula, other.Formula) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SampleQuery?>.Default.Equals(Sample, other.Sample) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.RelevanceFeedbackQuery?>.Default.Equals(RelevanceFeedback, other.RelevanceFeedback) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Query obj1, Query obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Query>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Query obj1, Query obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Query o && Equals(o);
        }
    }
}
