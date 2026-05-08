#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Configuration for creating a new named vector.<br/>
    /// Contains only the immutable properties that define a vector space. Storage type, index, and quantization are determined automatically based on the segment type and can be configured separately later.<br/>
    /// Example JSON for a dense vector: ```json { "dense": { "size": 768, "distance": "Cosine" } } ```<br/>
    /// Example JSON for a sparse vector: ```json { "sparse": { "modifier": "Idf" } } ```
    /// </summary>
    public readonly partial struct VectorNameConfig : global::System.IEquatable<VectorNameConfig>
    {
        /// <summary>
        /// Wrapper for dense vector creation config.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DenseVectorNameConfig? Dense { get; init; }
#else
        public global::Qdrant.DenseVectorNameConfig? Dense { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dense))]
#endif
        public bool IsDense => Dense != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDense(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.DenseVectorNameConfig? value)
        {
            value = Dense;
            return IsDense;
        }

        /// <summary>
        /// Wrapper for sparse vector creation config.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SparseVectorNameConfig? Sparse { get; init; }
#else
        public global::Qdrant.SparseVectorNameConfig? Sparse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sparse))]
#endif
        public bool IsSparse => Sparse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSparse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.SparseVectorNameConfig? value)
        {
            value = Sparse;
            return IsSparse;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorNameConfig(global::Qdrant.DenseVectorNameConfig value) => new VectorNameConfig((global::Qdrant.DenseVectorNameConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DenseVectorNameConfig?(VectorNameConfig @this) => @this.Dense;

        /// <summary>
        /// 
        /// </summary>
        public VectorNameConfig(global::Qdrant.DenseVectorNameConfig? value)
        {
            Dense = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorNameConfig(global::Qdrant.SparseVectorNameConfig value) => new VectorNameConfig((global::Qdrant.SparseVectorNameConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SparseVectorNameConfig?(VectorNameConfig @this) => @this.Sparse;

        /// <summary>
        /// 
        /// </summary>
        public VectorNameConfig(global::Qdrant.SparseVectorNameConfig? value)
        {
            Sparse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorNameConfig(
            global::Qdrant.DenseVectorNameConfig? dense,
            global::Qdrant.SparseVectorNameConfig? sparse
            )
        {
            Dense = dense;
            Sparse = sparse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sparse as object ??
            Dense as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dense?.ToString() ??
            Sparse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDense || IsSparse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.DenseVectorNameConfig, TResult>? dense = null,
            global::System.Func<global::Qdrant.SparseVectorNameConfig, TResult>? sparse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDense && dense != null)
            {
                return dense(Dense!);
            }
            else if (IsSparse && sparse != null)
            {
                return sparse(Sparse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.DenseVectorNameConfig>? dense = null,

            global::System.Action<global::Qdrant.SparseVectorNameConfig>? sparse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDense)
            {
                dense?.Invoke(Dense!);
            }
            else if (IsSparse)
            {
                sparse?.Invoke(Sparse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.DenseVectorNameConfig>? dense = null,
            global::System.Action<global::Qdrant.SparseVectorNameConfig>? sparse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDense)
            {
                dense?.Invoke(Dense!);
            }
            else if (IsSparse)
            {
                sparse?.Invoke(Sparse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dense,
                typeof(global::Qdrant.DenseVectorNameConfig),
                Sparse,
                typeof(global::Qdrant.SparseVectorNameConfig),
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
        public bool Equals(VectorNameConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DenseVectorNameConfig?>.Default.Equals(Dense, other.Dense) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SparseVectorNameConfig?>.Default.Equals(Sparse, other.Sparse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorNameConfig obj1, VectorNameConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorNameConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorNameConfig obj1, VectorNameConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorNameConfig o && Equals(o);
        }
    }
}
