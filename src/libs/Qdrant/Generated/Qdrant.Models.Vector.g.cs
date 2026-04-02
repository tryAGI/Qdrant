#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Vector Data Vectors can be described directly with values Or specified with source "objects" for inference
    /// </summary>
    public readonly partial struct Vector : global::System.IEquatable<Vector>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<float>? VectorVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? VectorVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorVariant1))]
#endif
        public bool IsVectorVariant1 => VectorVariant1 != null;

        /// <summary>
        /// Sparse vector structure
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SparseVector? Sparse { get; init; }
#else
        public global::Qdrant.SparseVector? Sparse { get; }
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
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorVariant3))]
#endif
        public bool IsVectorVariant3 => VectorVariant3 != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Text document for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Document? Document { get; init; }
#else
        public global::Qdrant.Document? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Image object for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.Image? Image { get; init; }
#else
        public global::Qdrant.Image? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// WARN: Work-in-progress, unimplemented<br/>
        /// Custom object for embedding. Requires inference infrastructure, unimplemented.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.InferenceObject? InferenceObject { get; init; }
#else
        public global::Qdrant.InferenceObject? InferenceObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InferenceObject))]
#endif
        public bool IsInferenceObject => InferenceObject != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Vector(global::Qdrant.SparseVector value) => new Vector((global::Qdrant.SparseVector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SparseVector?(Vector @this) => @this.Sparse;

        /// <summary>
        /// 
        /// </summary>
        public Vector(global::Qdrant.SparseVector? value)
        {
            Sparse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Vector(global::Qdrant.Document value) => new Vector((global::Qdrant.Document?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Document?(Vector @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public Vector(global::Qdrant.Document? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Vector(global::Qdrant.Image value) => new Vector((global::Qdrant.Image?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.Image?(Vector @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Vector(global::Qdrant.Image? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Vector(global::Qdrant.InferenceObject value) => new Vector((global::Qdrant.InferenceObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.InferenceObject?(Vector @this) => @this.InferenceObject;

        /// <summary>
        /// 
        /// </summary>
        public Vector(global::Qdrant.InferenceObject? value)
        {
            InferenceObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Vector(
            global::System.Collections.Generic.IList<float>? vectorVariant1,
            global::Qdrant.SparseVector? sparse,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? vectorVariant3,
            global::Qdrant.Document? document,
            global::Qdrant.Image? image,
            global::Qdrant.InferenceObject? inferenceObject
            )
        {
            VectorVariant1 = vectorVariant1;
            Sparse = sparse;
            VectorVariant3 = vectorVariant3;
            Document = document;
            Image = image;
            InferenceObject = inferenceObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InferenceObject as object ??
            Image as object ??
            Document as object ??
            VectorVariant3 as object ??
            Sparse as object ??
            VectorVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorVariant1?.ToString() ??
            Sparse?.ToString() ??
            VectorVariant3?.ToString() ??
            Document?.ToString() ??
            Image?.ToString() ??
            InferenceObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorVariant1 || IsSparse || IsVectorVariant3 || IsDocument || IsImage || IsInferenceObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>?, TResult>? vectorVariant1 = null,
            global::System.Func<global::Qdrant.SparseVector?, TResult>? sparse = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? vectorVariant3 = null,
            global::System.Func<global::Qdrant.Document?, TResult>? document = null,
            global::System.Func<global::Qdrant.Image?, TResult>? image = null,
            global::System.Func<global::Qdrant.InferenceObject?, TResult>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorVariant1 && vectorVariant1 != null)
            {
                return vectorVariant1(VectorVariant1!);
            }
            else if (IsSparse && sparse != null)
            {
                return sparse(Sparse!);
            }
            else if (IsVectorVariant3 && vectorVariant3 != null)
            {
                return vectorVariant3(VectorVariant3!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsInferenceObject && inferenceObject != null)
            {
                return inferenceObject(InferenceObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<float>?>? vectorVariant1 = null,
            global::System.Action<global::Qdrant.SparseVector?>? sparse = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? vectorVariant3 = null,
            global::System.Action<global::Qdrant.Document?>? document = null,
            global::System.Action<global::Qdrant.Image?>? image = null,
            global::System.Action<global::Qdrant.InferenceObject?>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorVariant1)
            {
                vectorVariant1?.Invoke(VectorVariant1!);
            }
            else if (IsSparse)
            {
                sparse?.Invoke(Sparse!);
            }
            else if (IsVectorVariant3)
            {
                vectorVariant3?.Invoke(VectorVariant3!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsInferenceObject)
            {
                inferenceObject?.Invoke(InferenceObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorVariant1,
                typeof(global::System.Collections.Generic.IList<float>),
                Sparse,
                typeof(global::Qdrant.SparseVector),
                VectorVariant3,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                Document,
                typeof(global::Qdrant.Document),
                Image,
                typeof(global::Qdrant.Image),
                InferenceObject,
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
        public bool Equals(Vector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(VectorVariant1, other.VectorVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SparseVector?>.Default.Equals(Sparse, other.Sparse) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(VectorVariant3, other.VectorVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Document?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Image?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.InferenceObject?>.Default.Equals(InferenceObject, other.InferenceObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Vector obj1, Vector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Vector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Vector obj1, Vector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Vector o && Equals(o);
        }
    }
}
