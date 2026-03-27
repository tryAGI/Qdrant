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
        public float? Value1 { get; init; }
#else
        public float? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Condition? Value3 { get; init; }
#else
        public global::Qdrant.Condition? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.GeoDistance? Value4 { get; init; }
#else
        public global::Qdrant.GeoDistance? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DatetimeExpression? Value5 { get; init; }
#else
        public global::Qdrant.DatetimeExpression? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DatetimeKeyExpression? Value6 { get; init; }
#else
        public global::Qdrant.DatetimeKeyExpression? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.MultExpression? Value7 { get; init; }
#else
        public global::Qdrant.MultExpression? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SumExpression? Value8 { get; init; }
#else
        public global::Qdrant.SumExpression? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.NegExpression? Value9 { get; init; }
#else
        public global::Qdrant.NegExpression? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.AbsExpression? Value10 { get; init; }
#else
        public global::Qdrant.AbsExpression? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DivExpression? Value11 { get; init; }
#else
        public global::Qdrant.DivExpression? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SqrtExpression? Value12 { get; init; }
#else
        public global::Qdrant.SqrtExpression? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.PowExpression? Value13 { get; init; }
#else
        public global::Qdrant.PowExpression? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ExpExpression? Value14 { get; init; }
#else
        public global::Qdrant.ExpExpression? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Log10Expression? Value15 { get; init; }
#else
        public global::Qdrant.Log10Expression? Value15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.LnExpression? Value16 { get; init; }
#else
        public global::Qdrant.LnExpression? Value16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.LinDecayExpression? Value17 { get; init; }
#else
        public global::Qdrant.LinDecayExpression? Value17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value17))]
#endif
        public bool IsValue17 => Value17 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ExpDecayExpression? Value18 { get; init; }
#else
        public global::Qdrant.ExpDecayExpression? Value18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value18))]
#endif
        public bool IsValue18 => Value18 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.GaussDecayExpression? Value19 { get; init; }
#else
        public global::Qdrant.GaussDecayExpression? Value19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value19))]
#endif
        public bool IsValue19 => Value19 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(float value) => new Expression((float?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator float?(Expression @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Expression(float? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(string value) => new Expression((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Expression @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Expression(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.Condition value) => new Expression((global::Qdrant.Condition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Condition?(Expression @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.Condition? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.GeoDistance value) => new Expression((global::Qdrant.GeoDistance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.GeoDistance?(Expression @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.GeoDistance? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.DatetimeExpression value) => new Expression((global::Qdrant.DatetimeExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DatetimeExpression?(Expression @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.DatetimeExpression? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.DatetimeKeyExpression value) => new Expression((global::Qdrant.DatetimeKeyExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DatetimeKeyExpression?(Expression @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.DatetimeKeyExpression? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.MultExpression value) => new Expression((global::Qdrant.MultExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.MultExpression?(Expression @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.MultExpression? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.SumExpression value) => new Expression((global::Qdrant.SumExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SumExpression?(Expression @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.SumExpression? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.NegExpression value) => new Expression((global::Qdrant.NegExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.NegExpression?(Expression @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.NegExpression? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.AbsExpression value) => new Expression((global::Qdrant.AbsExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.AbsExpression?(Expression @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.AbsExpression? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.DivExpression value) => new Expression((global::Qdrant.DivExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DivExpression?(Expression @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.DivExpression? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.SqrtExpression value) => new Expression((global::Qdrant.SqrtExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SqrtExpression?(Expression @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.SqrtExpression? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.PowExpression value) => new Expression((global::Qdrant.PowExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.PowExpression?(Expression @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.PowExpression? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.ExpExpression value) => new Expression((global::Qdrant.ExpExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ExpExpression?(Expression @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.ExpExpression? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.Log10Expression value) => new Expression((global::Qdrant.Log10Expression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Log10Expression?(Expression @this) => @this.Value15;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.Log10Expression? value)
        {
            Value15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.LnExpression value) => new Expression((global::Qdrant.LnExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.LnExpression?(Expression @this) => @this.Value16;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.LnExpression? value)
        {
            Value16 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.LinDecayExpression value) => new Expression((global::Qdrant.LinDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.LinDecayExpression?(Expression @this) => @this.Value17;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.LinDecayExpression? value)
        {
            Value17 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.ExpDecayExpression value) => new Expression((global::Qdrant.ExpDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ExpDecayExpression?(Expression @this) => @this.Value18;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.ExpDecayExpression? value)
        {
            Value18 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expression(global::Qdrant.GaussDecayExpression value) => new Expression((global::Qdrant.GaussDecayExpression?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.GaussDecayExpression?(Expression @this) => @this.Value19;

        /// <summary>
        /// 
        /// </summary>
        public Expression(global::Qdrant.GaussDecayExpression? value)
        {
            Value19 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Expression(
            float? value1,
            string? value2,
            global::Qdrant.Condition? value3,
            global::Qdrant.GeoDistance? value4,
            global::Qdrant.DatetimeExpression? value5,
            global::Qdrant.DatetimeKeyExpression? value6,
            global::Qdrant.MultExpression? value7,
            global::Qdrant.SumExpression? value8,
            global::Qdrant.NegExpression? value9,
            global::Qdrant.AbsExpression? value10,
            global::Qdrant.DivExpression? value11,
            global::Qdrant.SqrtExpression? value12,
            global::Qdrant.PowExpression? value13,
            global::Qdrant.ExpExpression? value14,
            global::Qdrant.Log10Expression? value15,
            global::Qdrant.LnExpression? value16,
            global::Qdrant.LinDecayExpression? value17,
            global::Qdrant.ExpDecayExpression? value18,
            global::Qdrant.GaussDecayExpression? value19
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
            Value15 = value15;
            Value16 = value16;
            Value17 = value17;
            Value18 = value18;
            Value19 = value19;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value19 as object ??
            Value18 as object ??
            Value17 as object ??
            Value16 as object ??
            Value15 as object ??
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() ??
            Value11?.ToString() ??
            Value12?.ToString() ??
            Value13?.ToString() ??
            Value14?.ToString() ??
            Value15?.ToString() ??
            Value16?.ToString() ??
            Value17?.ToString() ??
            Value18?.ToString() ??
            Value19?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7 || IsValue8 || IsValue9 || IsValue10 || IsValue11 || IsValue12 || IsValue13 || IsValue14 || IsValue15 || IsValue16 || IsValue17 || IsValue18 || IsValue19;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<float?, TResult>? value1 = null,
            global::System.Func<string?, TResult>? value2 = null,
            global::System.Func<global::Qdrant.Condition?, TResult>? value3 = null,
            global::System.Func<global::Qdrant.GeoDistance?, TResult>? value4 = null,
            global::System.Func<global::Qdrant.DatetimeExpression?, TResult>? value5 = null,
            global::System.Func<global::Qdrant.DatetimeKeyExpression?, TResult>? value6 = null,
            global::System.Func<global::Qdrant.MultExpression?, TResult>? value7 = null,
            global::System.Func<global::Qdrant.SumExpression?, TResult>? value8 = null,
            global::System.Func<global::Qdrant.NegExpression?, TResult>? value9 = null,
            global::System.Func<global::Qdrant.AbsExpression?, TResult>? value10 = null,
            global::System.Func<global::Qdrant.DivExpression?, TResult>? value11 = null,
            global::System.Func<global::Qdrant.SqrtExpression?, TResult>? value12 = null,
            global::System.Func<global::Qdrant.PowExpression?, TResult>? value13 = null,
            global::System.Func<global::Qdrant.ExpExpression?, TResult>? value14 = null,
            global::System.Func<global::Qdrant.Log10Expression?, TResult>? value15 = null,
            global::System.Func<global::Qdrant.LnExpression?, TResult>? value16 = null,
            global::System.Func<global::Qdrant.LinDecayExpression?, TResult>? value17 = null,
            global::System.Func<global::Qdrant.ExpDecayExpression?, TResult>? value18 = null,
            global::System.Func<global::Qdrant.GaussDecayExpression?, TResult>? value19 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }
            else if (IsValue15 && value15 != null)
            {
                return value15(Value15!);
            }
            else if (IsValue16 && value16 != null)
            {
                return value16(Value16!);
            }
            else if (IsValue17 && value17 != null)
            {
                return value17(Value17!);
            }
            else if (IsValue18 && value18 != null)
            {
                return value18(Value18!);
            }
            else if (IsValue19 && value19 != null)
            {
                return value19(Value19!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<float?>? value1 = null,
            global::System.Action<string?>? value2 = null,
            global::System.Action<global::Qdrant.Condition?>? value3 = null,
            global::System.Action<global::Qdrant.GeoDistance?>? value4 = null,
            global::System.Action<global::Qdrant.DatetimeExpression?>? value5 = null,
            global::System.Action<global::Qdrant.DatetimeKeyExpression?>? value6 = null,
            global::System.Action<global::Qdrant.MultExpression?>? value7 = null,
            global::System.Action<global::Qdrant.SumExpression?>? value8 = null,
            global::System.Action<global::Qdrant.NegExpression?>? value9 = null,
            global::System.Action<global::Qdrant.AbsExpression?>? value10 = null,
            global::System.Action<global::Qdrant.DivExpression?>? value11 = null,
            global::System.Action<global::Qdrant.SqrtExpression?>? value12 = null,
            global::System.Action<global::Qdrant.PowExpression?>? value13 = null,
            global::System.Action<global::Qdrant.ExpExpression?>? value14 = null,
            global::System.Action<global::Qdrant.Log10Expression?>? value15 = null,
            global::System.Action<global::Qdrant.LnExpression?>? value16 = null,
            global::System.Action<global::Qdrant.LinDecayExpression?>? value17 = null,
            global::System.Action<global::Qdrant.ExpDecayExpression?>? value18 = null,
            global::System.Action<global::Qdrant.GaussDecayExpression?>? value19 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
            else if (IsValue15)
            {
                value15?.Invoke(Value15!);
            }
            else if (IsValue16)
            {
                value16?.Invoke(Value16!);
            }
            else if (IsValue17)
            {
                value17?.Invoke(Value17!);
            }
            else if (IsValue18)
            {
                value18?.Invoke(Value18!);
            }
            else if (IsValue19)
            {
                value19?.Invoke(Value19!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(float),
                Value2,
                typeof(string),
                Value3,
                typeof(global::Qdrant.Condition),
                Value4,
                typeof(global::Qdrant.GeoDistance),
                Value5,
                typeof(global::Qdrant.DatetimeExpression),
                Value6,
                typeof(global::Qdrant.DatetimeKeyExpression),
                Value7,
                typeof(global::Qdrant.MultExpression),
                Value8,
                typeof(global::Qdrant.SumExpression),
                Value9,
                typeof(global::Qdrant.NegExpression),
                Value10,
                typeof(global::Qdrant.AbsExpression),
                Value11,
                typeof(global::Qdrant.DivExpression),
                Value12,
                typeof(global::Qdrant.SqrtExpression),
                Value13,
                typeof(global::Qdrant.PowExpression),
                Value14,
                typeof(global::Qdrant.ExpExpression),
                Value15,
                typeof(global::Qdrant.Log10Expression),
                Value16,
                typeof(global::Qdrant.LnExpression),
                Value17,
                typeof(global::Qdrant.LinDecayExpression),
                Value18,
                typeof(global::Qdrant.ExpDecayExpression),
                Value19,
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
                global::System.Collections.Generic.EqualityComparer<float?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Condition?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.GeoDistance?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DatetimeExpression?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DatetimeKeyExpression?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.MultExpression?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SumExpression?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.NegExpression?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.AbsExpression?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DivExpression?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SqrtExpression?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.PowExpression?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ExpExpression?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Log10Expression?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.LnExpression?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.LinDecayExpression?>.Default.Equals(Value17, other.Value17) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ExpDecayExpression?>.Default.Equals(Value18, other.Value18) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.GaussDecayExpression?>.Default.Equals(Value19, other.Value19) 
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
