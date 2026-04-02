#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Vector data separator for named and unnamed modes Unnamed mode:<br/>
    /// { "vector": [1.0, 2.0, 3.0] }<br/>
    /// or named mode:<br/>
    /// { "vector": { "vector": [1.0, 2.0, 3.0], "name": "image-embeddings" } }
    /// </summary>
    public readonly partial struct NamedVectorStruct : global::System.IEquatable<NamedVectorStruct>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? NamedVectorStructVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? NamedVectorStructVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedVectorStructVariant1))]
#endif
        public bool IsNamedVectorStructVariant1 => NamedVectorStructVariant1 != null;

        /// <summary>
        /// Dense vector data with name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.NamedVector? NamedVector { get; init; }
#else
        public global::Qdrant.NamedVector? NamedVector { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedVector))]
#endif
        public bool IsNamedVector => NamedVector != null;

        /// <summary>
        /// Sparse vector data with name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.NamedSparseVector? Sparse { get; init; }
#else
        public global::Qdrant.NamedSparseVector? Sparse { get; }
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
        public static implicit operator NamedVectorStruct(global::Qdrant.NamedVector value) => new NamedVectorStruct((global::Qdrant.NamedVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.NamedVector?(NamedVectorStruct @this) => @this.NamedVector;

        /// <summary>
        /// 
        /// </summary>
        public NamedVectorStruct(global::Qdrant.NamedVector? value)
        {
            NamedVector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedVectorStruct(global::Qdrant.NamedSparseVector value) => new NamedVectorStruct((global::Qdrant.NamedSparseVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.NamedSparseVector?(NamedVectorStruct @this) => @this.Sparse;

        /// <summary>
        /// 
        /// </summary>
        public NamedVectorStruct(global::Qdrant.NamedSparseVector? value)
        {
            Sparse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NamedVectorStruct(
            global::System.Collections.Generic.IList<float>? namedVectorStructVariant1,
            global::Qdrant.NamedVector? namedVector,
            global::Qdrant.NamedSparseVector? sparse
            )
        {
            NamedVectorStructVariant1 = namedVectorStructVariant1;
            NamedVector = namedVector;
            Sparse = sparse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sparse as object ??
            NamedVector as object ??
            NamedVectorStructVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NamedVectorStructVariant1?.ToString() ??
            NamedVector?.ToString() ??
            Sparse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNamedVectorStructVariant1 || IsNamedVector || IsSparse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? namedVectorStructVariant1 = null,
            global::System.Func<global::Qdrant.NamedVector?, TResult>? namedVector = null,
            global::System.Func<global::Qdrant.NamedSparseVector?, TResult>? sparse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamedVectorStructVariant1 && namedVectorStructVariant1 != null)
            {
                return namedVectorStructVariant1(NamedVectorStructVariant1!);
            }
            else if (IsNamedVector && namedVector != null)
            {
                return namedVector(NamedVector!);
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
            global::System.Action<global::System.Collections.Generic.IList<float>?>? namedVectorStructVariant1 = null,
            global::System.Action<global::Qdrant.NamedVector?>? namedVector = null,
            global::System.Action<global::Qdrant.NamedSparseVector?>? sparse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamedVectorStructVariant1)
            {
                namedVectorStructVariant1?.Invoke(NamedVectorStructVariant1!);
            }
            else if (IsNamedVector)
            {
                namedVector?.Invoke(NamedVector!);
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
                NamedVectorStructVariant1,
                typeof(global::System.Collections.Generic.IList<float>),
                NamedVector,
                typeof(global::Qdrant.NamedVector),
                Sparse,
                typeof(global::Qdrant.NamedSparseVector),
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
        public bool Equals(NamedVectorStruct other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(NamedVectorStructVariant1, other.NamedVectorStructVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.NamedVector?>.Default.Equals(NamedVector, other.NamedVector) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.NamedSparseVector?>.Default.Equals(Sparse, other.Sparse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NamedVectorStruct obj1, NamedVectorStruct obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NamedVectorStruct>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NamedVectorStruct obj1, NamedVectorStruct obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NamedVectorStruct o && Equals(o);
        }
    }
}
