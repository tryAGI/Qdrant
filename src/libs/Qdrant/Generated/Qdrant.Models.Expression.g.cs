#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Expression : global::System.IEquatable<Expression>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public float? ExpressionVariant1 { get; init; }
#else
        public float? ExpressionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressionVariant1))]
#endif
        public bool IsExpressionVariant1 => ExpressionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ExpressionVariant2 { get; init; }
#else
        public string? ExpressionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressionVariant2))]
#endif
        public bool IsExpressionVariant2 => ExpressionVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Condition? Condition { get; init; }
#else
        public global::Qdrant.Condition? Condition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Condition))]
#endif
        public bool IsCondition => Condition != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.GeoDistance? GeoDistance { get; init; }
#else
        public global::Qdrant.GeoDistance? GeoDistance { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeoDistance))]
#endif
        public bool IsGeoDistance => GeoDistance != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DatetimeExpression? Datetime { get; init; }
#else
        public global::Qdrant.DatetimeExpression? Datetime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Datetime))]
#endif
        public bool IsDatetime => Datetime != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DatetimeKeyExpression? DatetimeKey { get; init; }
#else
        public global::Qdrant.DatetimeKeyExpression? DatetimeKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatetimeKey))]
#endif
        public bool IsDatetimeKey => DatetimeKey != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.MultExpression? Mult { get; init; }
#else
        public global::Qdrant.MultExpression? Mult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mult))]
#endif
        public bool IsMult => Mult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SumExpression? Sum { get; init; }
#else
        public global::Qdrant.SumExpression? Sum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sum))]
#endif
        public bool IsSum => Sum != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.NegExpression? Neg { get; init; }
#else
        public global::Qdrant.NegExpression? Neg { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Neg))]
#endif
        public bool IsNeg => Neg != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.AbsExpression? Abs { get; init; }
#else
        public global::Qdrant.AbsExpression? Abs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Abs))]
#endif
        public bool IsAbs => Abs != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DivExpression? Div { get; init; }
#else
        public global::Qdrant.DivExpression? Div { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Div))]
#endif
        public bool IsDiv => Div != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SqrtExpression? Sqrt { get; init; }
#else
        public global::Qdrant.SqrtExpression? Sqrt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sqrt))]
#endif
        public bool IsSqrt => Sqrt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.PowExpression? Pow { get; init; }
#else
        public global::Qdrant.PowExpression? Pow { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pow))]
#endif
        public bool IsPow => Pow != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ExpExpression? Exp { get; init; }
#else
        public global::Qdrant.ExpExpression? Exp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exp))]
#endif
        public bool IsExp => Exp != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Log10Expression? Log10 { get; init; }
#else
        public global::Qdrant.Log10Expression? Log10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Log10))]
#endif
        public bool IsLog10 => Log10 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.LnExpression? Ln { get; init; }
#else
        public global::Qdrant.LnExpression? Ln { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ln))]
#endif
        public bool IsLn => Ln != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.LinDecayExpression? LinDecay { get; init; }
#else
        public global::Qdrant.LinDecayExpression? LinDecay { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LinDecay))]
#endif
        public bool IsLinDecay => LinDecay != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ExpDecayExpression? ExpDecay { get; init; }
#else
        public global::Qdrant.ExpDecayExpression? ExpDecay { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpDecay))]
#endif
        public bool IsExpDecay => ExpDecay != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.GaussDecayExpression? GaussDecay { get; init; }
#else
        public global::Qdrant.GaussDecayExpression? GaussDecay { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GaussDecay))]
#endif
        public bool IsGaussDecay => GaussDecay != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(float value) => new Expression((float?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator float?(Expression @this) => @this.ExpressionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Expression(float? value)
        {
            ExpressionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(string value) => new Expression((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Expression @this) => @this.ExpressionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Expression(string? value)
        {
            ExpressionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.Condition value) => new Expression((global::Qdrant.Condition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Condition?(Expression @this) => @this.Condition;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.Condition? value)
        {
            Condition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.GeoDistance value) => new Expression((global::Qdrant.GeoDistance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.GeoDistance?(Expression @this) => @this.GeoDistance;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.GeoDistance? value)
        {
            GeoDistance = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.DatetimeExpression value) => new Expression((global::Qdrant.DatetimeExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DatetimeExpression?(Expression @this) => @this.Datetime;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.DatetimeExpression? value)
        {
            Datetime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.DatetimeKeyExpression value) => new Expression((global::Qdrant.DatetimeKeyExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DatetimeKeyExpression?(Expression @this) => @this.DatetimeKey;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.DatetimeKeyExpression? value)
        {
            DatetimeKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.MultExpression value) => new Expression((global::Qdrant.MultExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.MultExpression?(Expression @this) => @this.Mult;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.MultExpression? value)
        {
            Mult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.SumExpression value) => new Expression((global::Qdrant.SumExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SumExpression?(Expression @this) => @this.Sum;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.SumExpression? value)
        {
            Sum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.NegExpression value) => new Expression((global::Qdrant.NegExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.NegExpression?(Expression @this) => @this.Neg;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.NegExpression? value)
        {
            Neg = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.AbsExpression value) => new Expression((global::Qdrant.AbsExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.AbsExpression?(Expression @this) => @this.Abs;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.AbsExpression? value)
        {
            Abs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.DivExpression value) => new Expression((global::Qdrant.DivExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DivExpression?(Expression @this) => @this.Div;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.DivExpression? value)
        {
            Div = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.SqrtExpression value) => new Expression((global::Qdrant.SqrtExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SqrtExpression?(Expression @this) => @this.Sqrt;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.SqrtExpression? value)
        {
            Sqrt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.PowExpression value) => new Expression((global::Qdrant.PowExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.PowExpression?(Expression @this) => @this.Pow;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.PowExpression? value)
        {
            Pow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.ExpExpression value) => new Expression((global::Qdrant.ExpExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ExpExpression?(Expression @this) => @this.Exp;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.ExpExpression? value)
        {
            Exp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.Log10Expression value) => new Expression((global::Qdrant.Log10Expression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Log10Expression?(Expression @this) => @this.Log10;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.Log10Expression? value)
        {
            Log10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.LnExpression value) => new Expression((global::Qdrant.LnExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.LnExpression?(Expression @this) => @this.Ln;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.LnExpression? value)
        {
            Ln = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.LinDecayExpression value) => new Expression((global::Qdrant.LinDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.LinDecayExpression?(Expression @this) => @this.LinDecay;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.LinDecayExpression? value)
        {
            LinDecay = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.ExpDecayExpression value) => new Expression((global::Qdrant.ExpDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ExpDecayExpression?(Expression @this) => @this.ExpDecay;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.ExpDecayExpression? value)
        {
            ExpDecay = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.GaussDecayExpression value) => new Expression((global::Qdrant.GaussDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.GaussDecayExpression?(Expression @this) => @this.GaussDecay;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.GaussDecayExpression? value)
        {
            GaussDecay = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Expression(
            float? expressionVariant1,
            string? expressionVariant2,
            global::Qdrant.Condition? condition,
            global::Qdrant.GeoDistance? geoDistance,
            global::Qdrant.DatetimeExpression? datetime,
            global::Qdrant.DatetimeKeyExpression? datetimeKey,
            global::Qdrant.MultExpression? mult,
            global::Qdrant.SumExpression? sum,
            global::Qdrant.NegExpression? neg,
            global::Qdrant.AbsExpression? abs,
            global::Qdrant.DivExpression? div,
            global::Qdrant.SqrtExpression? sqrt,
            global::Qdrant.PowExpression? pow,
            global::Qdrant.ExpExpression? exp,
            global::Qdrant.Log10Expression? log10,
            global::Qdrant.LnExpression? ln,
            global::Qdrant.LinDecayExpression? linDecay,
            global::Qdrant.ExpDecayExpression? expDecay,
            global::Qdrant.GaussDecayExpression? gaussDecay
            )
        {
            ExpressionVariant1 = expressionVariant1;
            ExpressionVariant2 = expressionVariant2;
            Condition = condition;
            GeoDistance = geoDistance;
            Datetime = datetime;
            DatetimeKey = datetimeKey;
            Mult = mult;
            Sum = sum;
            Neg = neg;
            Abs = abs;
            Div = div;
            Sqrt = sqrt;
            Pow = pow;
            Exp = exp;
            Log10 = log10;
            Ln = ln;
            LinDecay = linDecay;
            ExpDecay = expDecay;
            GaussDecay = gaussDecay;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GaussDecay as object ??
            ExpDecay as object ??
            LinDecay as object ??
            Ln as object ??
            Log10 as object ??
            Exp as object ??
            Pow as object ??
            Sqrt as object ??
            Div as object ??
            Abs as object ??
            Neg as object ??
            Sum as object ??
            Mult as object ??
            DatetimeKey as object ??
            Datetime as object ??
            GeoDistance as object ??
            Condition as object ??
            ExpressionVariant2 as object ??
            ExpressionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExpressionVariant1?.ToString() ??
            ExpressionVariant2?.ToString() ??
            Condition?.ToString() ??
            GeoDistance?.ToString() ??
            Datetime?.ToString() ??
            DatetimeKey?.ToString() ??
            Mult?.ToString() ??
            Sum?.ToString() ??
            Neg?.ToString() ??
            Abs?.ToString() ??
            Div?.ToString() ??
            Sqrt?.ToString() ??
            Pow?.ToString() ??
            Exp?.ToString() ??
            Log10?.ToString() ??
            Ln?.ToString() ??
            LinDecay?.ToString() ??
            ExpDecay?.ToString() ??
            GaussDecay?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExpressionVariant1 || IsExpressionVariant2 || IsCondition || IsGeoDistance || IsDatetime || IsDatetimeKey || IsMult || IsSum || IsNeg || IsAbs || IsDiv || IsSqrt || IsPow || IsExp || IsLog10 || IsLn || IsLinDecay || IsExpDecay || IsGaussDecay;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<float?, TResult>? expressionVariant1 = null,
            global::System.Func<string?, TResult>? expressionVariant2 = null,
            global::System.Func<global::Qdrant.Condition?, TResult>? condition = null,
            global::System.Func<global::Qdrant.GeoDistance?, TResult>? geoDistance = null,
            global::System.Func<global::Qdrant.DatetimeExpression?, TResult>? datetime = null,
            global::System.Func<global::Qdrant.DatetimeKeyExpression?, TResult>? datetimeKey = null,
            global::System.Func<global::Qdrant.MultExpression?, TResult>? mult = null,
            global::System.Func<global::Qdrant.SumExpression?, TResult>? sum = null,
            global::System.Func<global::Qdrant.NegExpression?, TResult>? neg = null,
            global::System.Func<global::Qdrant.AbsExpression?, TResult>? abs = null,
            global::System.Func<global::Qdrant.DivExpression?, TResult>? div = null,
            global::System.Func<global::Qdrant.SqrtExpression?, TResult>? sqrt = null,
            global::System.Func<global::Qdrant.PowExpression?, TResult>? pow = null,
            global::System.Func<global::Qdrant.ExpExpression?, TResult>? exp = null,
            global::System.Func<global::Qdrant.Log10Expression?, TResult>? log10 = null,
            global::System.Func<global::Qdrant.LnExpression?, TResult>? ln = null,
            global::System.Func<global::Qdrant.LinDecayExpression?, TResult>? linDecay = null,
            global::System.Func<global::Qdrant.ExpDecayExpression?, TResult>? expDecay = null,
            global::System.Func<global::Qdrant.GaussDecayExpression?, TResult>? gaussDecay = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressionVariant1 && expressionVariant1 != null)
            {
                return expressionVariant1(ExpressionVariant1!);
            }
            else if (IsExpressionVariant2 && expressionVariant2 != null)
            {
                return expressionVariant2(ExpressionVariant2!);
            }
            else if (IsCondition && condition != null)
            {
                return condition(Condition!);
            }
            else if (IsGeoDistance && geoDistance != null)
            {
                return geoDistance(GeoDistance!);
            }
            else if (IsDatetime && datetime != null)
            {
                return datetime(Datetime!);
            }
            else if (IsDatetimeKey && datetimeKey != null)
            {
                return datetimeKey(DatetimeKey!);
            }
            else if (IsMult && mult != null)
            {
                return mult(Mult!);
            }
            else if (IsSum && sum != null)
            {
                return sum(Sum!);
            }
            else if (IsNeg && neg != null)
            {
                return neg(Neg!);
            }
            else if (IsAbs && abs != null)
            {
                return abs(Abs!);
            }
            else if (IsDiv && div != null)
            {
                return div(Div!);
            }
            else if (IsSqrt && sqrt != null)
            {
                return sqrt(Sqrt!);
            }
            else if (IsPow && pow != null)
            {
                return pow(Pow!);
            }
            else if (IsExp && exp != null)
            {
                return exp(Exp!);
            }
            else if (IsLog10 && log10 != null)
            {
                return log10(Log10!);
            }
            else if (IsLn && ln != null)
            {
                return ln(Ln!);
            }
            else if (IsLinDecay && linDecay != null)
            {
                return linDecay(LinDecay!);
            }
            else if (IsExpDecay && expDecay != null)
            {
                return expDecay(ExpDecay!);
            }
            else if (IsGaussDecay && gaussDecay != null)
            {
                return gaussDecay(GaussDecay!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<float?>? expressionVariant1 = null,
            global::System.Action<string?>? expressionVariant2 = null,
            global::System.Action<global::Qdrant.Condition?>? condition = null,
            global::System.Action<global::Qdrant.GeoDistance?>? geoDistance = null,
            global::System.Action<global::Qdrant.DatetimeExpression?>? datetime = null,
            global::System.Action<global::Qdrant.DatetimeKeyExpression?>? datetimeKey = null,
            global::System.Action<global::Qdrant.MultExpression?>? mult = null,
            global::System.Action<global::Qdrant.SumExpression?>? sum = null,
            global::System.Action<global::Qdrant.NegExpression?>? neg = null,
            global::System.Action<global::Qdrant.AbsExpression?>? abs = null,
            global::System.Action<global::Qdrant.DivExpression?>? div = null,
            global::System.Action<global::Qdrant.SqrtExpression?>? sqrt = null,
            global::System.Action<global::Qdrant.PowExpression?>? pow = null,
            global::System.Action<global::Qdrant.ExpExpression?>? exp = null,
            global::System.Action<global::Qdrant.Log10Expression?>? log10 = null,
            global::System.Action<global::Qdrant.LnExpression?>? ln = null,
            global::System.Action<global::Qdrant.LinDecayExpression?>? linDecay = null,
            global::System.Action<global::Qdrant.ExpDecayExpression?>? expDecay = null,
            global::System.Action<global::Qdrant.GaussDecayExpression?>? gaussDecay = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExpressionVariant1)
            {
                expressionVariant1?.Invoke(ExpressionVariant1!);
            }
            else if (IsExpressionVariant2)
            {
                expressionVariant2?.Invoke(ExpressionVariant2!);
            }
            else if (IsCondition)
            {
                condition?.Invoke(Condition!);
            }
            else if (IsGeoDistance)
            {
                geoDistance?.Invoke(GeoDistance!);
            }
            else if (IsDatetime)
            {
                datetime?.Invoke(Datetime!);
            }
            else if (IsDatetimeKey)
            {
                datetimeKey?.Invoke(DatetimeKey!);
            }
            else if (IsMult)
            {
                mult?.Invoke(Mult!);
            }
            else if (IsSum)
            {
                sum?.Invoke(Sum!);
            }
            else if (IsNeg)
            {
                neg?.Invoke(Neg!);
            }
            else if (IsAbs)
            {
                abs?.Invoke(Abs!);
            }
            else if (IsDiv)
            {
                div?.Invoke(Div!);
            }
            else if (IsSqrt)
            {
                sqrt?.Invoke(Sqrt!);
            }
            else if (IsPow)
            {
                pow?.Invoke(Pow!);
            }
            else if (IsExp)
            {
                exp?.Invoke(Exp!);
            }
            else if (IsLog10)
            {
                log10?.Invoke(Log10!);
            }
            else if (IsLn)
            {
                ln?.Invoke(Ln!);
            }
            else if (IsLinDecay)
            {
                linDecay?.Invoke(LinDecay!);
            }
            else if (IsExpDecay)
            {
                expDecay?.Invoke(ExpDecay!);
            }
            else if (IsGaussDecay)
            {
                gaussDecay?.Invoke(GaussDecay!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExpressionVariant1,
                typeof(float),
                ExpressionVariant2,
                typeof(string),
                Condition,
                typeof(global::Qdrant.Condition),
                GeoDistance,
                typeof(global::Qdrant.GeoDistance),
                Datetime,
                typeof(global::Qdrant.DatetimeExpression),
                DatetimeKey,
                typeof(global::Qdrant.DatetimeKeyExpression),
                Mult,
                typeof(global::Qdrant.MultExpression),
                Sum,
                typeof(global::Qdrant.SumExpression),
                Neg,
                typeof(global::Qdrant.NegExpression),
                Abs,
                typeof(global::Qdrant.AbsExpression),
                Div,
                typeof(global::Qdrant.DivExpression),
                Sqrt,
                typeof(global::Qdrant.SqrtExpression),
                Pow,
                typeof(global::Qdrant.PowExpression),
                Exp,
                typeof(global::Qdrant.ExpExpression),
                Log10,
                typeof(global::Qdrant.Log10Expression),
                Ln,
                typeof(global::Qdrant.LnExpression),
                LinDecay,
                typeof(global::Qdrant.LinDecayExpression),
                ExpDecay,
                typeof(global::Qdrant.ExpDecayExpression),
                GaussDecay,
                typeof(global::Qdrant.GaussDecayExpression),
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
        public bool Equals(Expression other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<float?>.Default.Equals(ExpressionVariant1, other.ExpressionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ExpressionVariant2, other.ExpressionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Condition?>.Default.Equals(Condition, other.Condition) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.GeoDistance?>.Default.Equals(GeoDistance, other.GeoDistance) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DatetimeExpression?>.Default.Equals(Datetime, other.Datetime) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DatetimeKeyExpression?>.Default.Equals(DatetimeKey, other.DatetimeKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.MultExpression?>.Default.Equals(Mult, other.Mult) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SumExpression?>.Default.Equals(Sum, other.Sum) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.NegExpression?>.Default.Equals(Neg, other.Neg) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.AbsExpression?>.Default.Equals(Abs, other.Abs) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DivExpression?>.Default.Equals(Div, other.Div) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SqrtExpression?>.Default.Equals(Sqrt, other.Sqrt) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.PowExpression?>.Default.Equals(Pow, other.Pow) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ExpExpression?>.Default.Equals(Exp, other.Exp) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Log10Expression?>.Default.Equals(Log10, other.Log10) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.LnExpression?>.Default.Equals(Ln, other.Ln) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.LinDecayExpression?>.Default.Equals(LinDecay, other.LinDecay) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ExpDecayExpression?>.Default.Equals(ExpDecay, other.ExpDecay) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.GaussDecayExpression?>.Default.Equals(GaussDecay, other.GaussDecay) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Expression obj1, Expression obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Expression>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Expression obj1, Expression obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Expression o && Equals(o);
        }
    }
}
