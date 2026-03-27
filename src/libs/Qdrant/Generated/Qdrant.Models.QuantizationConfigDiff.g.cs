#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct QuantizationConfigDiff : global::System.IEquatable<QuantizationConfigDiff>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ScalarQuantization? Scalar { get; init; }
#else
        public global::Qdrant.ScalarQuantization? Scalar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scalar))]
#endif
        public bool IsScalar => Scalar != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ProductQuantization? Product { get; init; }
#else
        public global::Qdrant.ProductQuantization? Product { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Product))]
#endif
        public bool IsProduct => Product != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.BinaryQuantization? Binary { get; init; }
#else
        public global::Qdrant.BinaryQuantization? Binary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Binary))]
#endif
        public bool IsBinary => Binary != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DisabledType? DisabledType { get; init; }
#else
        public global::Qdrant.DisabledType? DisabledType { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DisabledType))]
#endif
        public bool IsDisabledType => DisabledType != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QuantizationConfigDiff(global::Qdrant.ScalarQuantization value) => new QuantizationConfigDiff((global::Qdrant.ScalarQuantization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ScalarQuantization?(QuantizationConfigDiff @this) => @this.Scalar;

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(global::Qdrant.ScalarQuantization? value)
        {
            Scalar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QuantizationConfigDiff(global::Qdrant.ProductQuantization value) => new QuantizationConfigDiff((global::Qdrant.ProductQuantization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ProductQuantization?(QuantizationConfigDiff @this) => @this.Product;

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(global::Qdrant.ProductQuantization? value)
        {
            Product = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QuantizationConfigDiff(global::Qdrant.BinaryQuantization value) => new QuantizationConfigDiff((global::Qdrant.BinaryQuantization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.BinaryQuantization?(QuantizationConfigDiff @this) => @this.Binary;

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(global::Qdrant.BinaryQuantization? value)
        {
            Binary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QuantizationConfigDiff(global::Qdrant.DisabledType value) => new QuantizationConfigDiff((global::Qdrant.DisabledType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DisabledType?(QuantizationConfigDiff @this) => @this.DisabledType;

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(global::Qdrant.DisabledType? value)
        {
            DisabledType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(
            global::Qdrant.ScalarQuantization? scalar,
            global::Qdrant.ProductQuantization? product,
            global::Qdrant.BinaryQuantization? binary,
            global::Qdrant.DisabledType? disabledType
            )
        {
            Scalar = scalar;
            Product = product;
            Binary = binary;
            DisabledType = disabledType;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DisabledType as object ??
            Binary as object ??
            Product as object ??
            Scalar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Scalar?.ToString() ??
            Product?.ToString() ??
            Binary?.ToString() ??
            DisabledType?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScalar || IsProduct || IsBinary || IsDisabledType;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.ScalarQuantization?, TResult>? scalar = null,
            global::System.Func<global::Qdrant.ProductQuantization?, TResult>? product = null,
            global::System.Func<global::Qdrant.BinaryQuantization?, TResult>? binary = null,
            global::System.Func<global::Qdrant.DisabledType?, TResult>? disabledType = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScalar && scalar != null)
            {
                return scalar(Scalar!);
            }
            else if (IsProduct && product != null)
            {
                return product(Product!);
            }
            else if (IsBinary && binary != null)
            {
                return binary(Binary!);
            }
            else if (IsDisabledType && disabledType != null)
            {
                return disabledType(DisabledType!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.ScalarQuantization?>? scalar = null,
            global::System.Action<global::Qdrant.ProductQuantization?>? product = null,
            global::System.Action<global::Qdrant.BinaryQuantization?>? binary = null,
            global::System.Action<global::Qdrant.DisabledType?>? disabledType = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScalar)
            {
                scalar?.Invoke(Scalar!);
            }
            else if (IsProduct)
            {
                product?.Invoke(Product!);
            }
            else if (IsBinary)
            {
                binary?.Invoke(Binary!);
            }
            else if (IsDisabledType)
            {
                disabledType?.Invoke(DisabledType!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Scalar,
                typeof(global::Qdrant.ScalarQuantization),
                Product,
                typeof(global::Qdrant.ProductQuantization),
                Binary,
                typeof(global::Qdrant.BinaryQuantization),
                DisabledType,
                typeof(global::Qdrant.DisabledType),
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
        public bool Equals(QuantizationConfigDiff other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ScalarQuantization?>.Default.Equals(Scalar, other.Scalar) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ProductQuantization?>.Default.Equals(Product, other.Product) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.BinaryQuantization?>.Default.Equals(Binary, other.Binary) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DisabledType?>.Default.Equals(DisabledType, other.DisabledType) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QuantizationConfigDiff obj1, QuantizationConfigDiff obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QuantizationConfigDiff>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QuantizationConfigDiff obj1, QuantizationConfigDiff obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QuantizationConfigDiff o && Equals(o);
        }
    }
}
