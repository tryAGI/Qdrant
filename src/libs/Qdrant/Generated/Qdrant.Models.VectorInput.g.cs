#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VectorInput : global::System.IEquatable<VectorInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Sparse vector structure
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SparseVector? Value2 { get; init; }
#else
        public global::Qdrant.SparseVector? Value2 { get; }
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
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Value3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ExtendedPointId? Value4 { get; init; }
#else
        public global::Qdrant.ExtendedPointId? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Text document for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Document? Value5 { get; init; }
#else
        public global::Qdrant.Document? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Image object for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Image? Value6 { get; init; }
#else
        public global::Qdrant.Image? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Custom object for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.InferenceObject? Value7 { get; init; }
#else
        public global::Qdrant.InferenceObject? Value7 { get; }
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
        public static implicit operator VectorInput(global::Qdrant.SparseVector value) => new VectorInput((global::Qdrant.SparseVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SparseVector?(VectorInput @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::Qdrant.SparseVector? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.ExtendedPointId value) => new VectorInput((global::Qdrant.ExtendedPointId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ExtendedPointId?(VectorInput @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::Qdrant.ExtendedPointId? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.Document value) => new VectorInput((global::Qdrant.Document?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Document?(VectorInput @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::Qdrant.Document? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.Image value) => new VectorInput((global::Qdrant.Image?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Image?(VectorInput @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::Qdrant.Image? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.InferenceObject value) => new VectorInput((global::Qdrant.InferenceObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.InferenceObject?(VectorInput @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(global::Qdrant.InferenceObject? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorInput(
            global::System.Collections.Generic.IList<float>? value1,
            global::Qdrant.SparseVector? value2,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? value3,
            global::Qdrant.ExtendedPointId? value4,
            global::Qdrant.Document? value5,
            global::Qdrant.Image? value6,
            global::Qdrant.InferenceObject? value7
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Value7?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? value1 = null,
            global::System.Func<global::Qdrant.SparseVector?, TResult>? value2 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? value3 = null,
            global::System.Func<global::Qdrant.ExtendedPointId?, TResult>? value4 = null,
            global::System.Func<global::Qdrant.Document?, TResult>? value5 = null,
            global::System.Func<global::Qdrant.Image?, TResult>? value6 = null,
            global::System.Func<global::Qdrant.InferenceObject?, TResult>? value7 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<float>?>? value1 = null,
            global::System.Action<global::Qdrant.SparseVector?>? value2 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? value3 = null,
            global::System.Action<global::Qdrant.ExtendedPointId?>? value4 = null,
            global::System.Action<global::Qdrant.Document?>? value5 = null,
            global::System.Action<global::Qdrant.Image?>? value6 = null,
            global::System.Action<global::Qdrant.InferenceObject?>? value7 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::System.Collections.Generic.IList<float>),
                Value2,
                typeof(global::Qdrant.SparseVector),
                Value3,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                Value4,
                typeof(global::Qdrant.ExtendedPointId),
                Value5,
                typeof(global::Qdrant.Document),
                Value6,
                typeof(global::Qdrant.Image),
                Value7,
                typeof(global::Qdrant.InferenceObject),
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
        public bool Equals(VectorInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SparseVector?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ExtendedPointId?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Document?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Image?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.InferenceObject?>.Default.Equals(Value7, other.Value7) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorInput obj1, VectorInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorInput obj1, VectorInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorInput o && Equals(o);
        }
    }
}
