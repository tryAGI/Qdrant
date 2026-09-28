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
        public global::System.Collections.Generic.IList<float>? VectorInputVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<float>? VectorInputVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorInputVariant1))]
#endif
        public bool IsVectorInputVariant1 => VectorInputVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVectorInputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<float>? value)
        {
            value = VectorInputVariant1;
            return IsVectorInputVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float> PickVectorInputVariant1() => VectorInputVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorInputVariant1' but the value was {ToString()}.");

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
        public bool TryPickSparse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.SparseVector? value)
        {
            value = Sparse;
            return IsSparse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.SparseVector PickSparse() => Sparse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sparse' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorInputVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? VectorInputVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorInputVariant3))]
#endif
        public bool IsVectorInputVariant3 => VectorInputVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVectorInputVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? value)
        {
            value = VectorInputVariant3;
            return IsVectorInputVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> PickVectorInputVariant3() => VectorInputVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorInputVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ExtendedPointId? ExtendedPointId { get; init; }
#else
        public global::Qdrant.ExtendedPointId? ExtendedPointId { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtendedPointId))]
#endif
        public bool IsExtendedPointId => ExtendedPointId != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExtendedPointId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.ExtendedPointId? value)
        {
            value = ExtendedPointId;
            return IsExtendedPointId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.ExtendedPointId PickExtendedPointId() => ExtendedPointId is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExtendedPointId' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.Document? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Document PickDocument() => Document is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.Image? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.Image PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

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
        public bool TryPickInferenceObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.InferenceObject? value)
        {
            value = InferenceObject;
            return IsInferenceObject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.InferenceObject PickInferenceObject() => InferenceObject is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InferenceObject' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.SparseVector value) => new VectorInput((global::Qdrant.SparseVector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.SparseVector?(VectorInput @this) => @this.Sparse;

        /// <summary>
        ///
        /// </summary>
        public VectorInput(global::Qdrant.SparseVector? value)
        {
            Sparse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VectorInput FromSparse(global::Qdrant.SparseVector? value) => new VectorInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.ExtendedPointId value) => new VectorInput((global::Qdrant.ExtendedPointId?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.ExtendedPointId?(VectorInput @this) => @this.ExtendedPointId;

        /// <summary>
        ///
        /// </summary>
        public VectorInput(global::Qdrant.ExtendedPointId? value)
        {
            ExtendedPointId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VectorInput FromExtendedPointId(global::Qdrant.ExtendedPointId? value) => new VectorInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.Document value) => new VectorInput((global::Qdrant.Document?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.Document?(VectorInput @this) => @this.Document;

        /// <summary>
        ///
        /// </summary>
        public VectorInput(global::Qdrant.Document? value)
        {
            Document = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VectorInput FromDocument(global::Qdrant.Document? value) => new VectorInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.Image value) => new VectorInput((global::Qdrant.Image?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.Image?(VectorInput @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public VectorInput(global::Qdrant.Image? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VectorInput FromImage(global::Qdrant.Image? value) => new VectorInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VectorInput(global::Qdrant.InferenceObject value) => new VectorInput((global::Qdrant.InferenceObject?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.InferenceObject?(VectorInput @this) => @this.InferenceObject;

        /// <summary>
        ///
        /// </summary>
        public VectorInput(global::Qdrant.InferenceObject? value)
        {
            InferenceObject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VectorInput FromInferenceObject(global::Qdrant.InferenceObject? value) => new VectorInput(value);

        /// <summary>
        ///
        /// </summary>
        public VectorInput(
            global::System.Collections.Generic.IList<float>? vectorInputVariant1,
            global::Qdrant.SparseVector? sparse,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? vectorInputVariant3,
            global::Qdrant.ExtendedPointId? extendedPointId,
            global::Qdrant.Document? document,
            global::Qdrant.Image? image,
            global::Qdrant.InferenceObject? inferenceObject
            )
        {
            VectorInputVariant1 = vectorInputVariant1;
            Sparse = sparse;
            VectorInputVariant3 = vectorInputVariant3;
            ExtendedPointId = extendedPointId;
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
            ExtendedPointId as object ??
            VectorInputVariant3 as object ??
            Sparse as object ??
            VectorInputVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            VectorInputVariant1?.ToString() ??
            Sparse?.ToString() ??
            VectorInputVariant3?.ToString() ??
            ExtendedPointId?.ToString() ??
            Document?.ToString() ??
            Image?.ToString() ??
            InferenceObject?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVectorInputVariant1 || IsSparse || IsVectorInputVariant3 || IsExtendedPointId || IsDocument || IsImage || IsInferenceObject;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<float>, TResult>? vectorInputVariant1 = null,
            global::System.Func<global::Qdrant.SparseVector, TResult>? sparse = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>, TResult>? vectorInputVariant3 = null,
            global::System.Func<global::Qdrant.ExtendedPointId?, TResult>? extendedPointId = null,
            global::System.Func<global::Qdrant.Document, TResult>? document = null,
            global::System.Func<global::Qdrant.Image, TResult>? image = null,
            global::System.Func<global::Qdrant.InferenceObject, TResult>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VectorInputVariant1 is { } __value0 && vectorInputVariant1 != null)
            {
                return vectorInputVariant1(__value0);
            }
            else if (Sparse is { } __value1 && sparse != null)
            {
                return sparse(__value1);
            }
            else if (VectorInputVariant3 is { } __value2 && vectorInputVariant3 != null)
            {
                return vectorInputVariant3(__value2);
            }
            else if (ExtendedPointId is { } __value3 && extendedPointId != null)
            {
                return extendedPointId(__value3);
            }
            else if (Document is { } __value4 && document != null)
            {
                return document(__value4);
            }
            else if (Image is { } __value5 && image != null)
            {
                return image(__value5);
            }
            else if (InferenceObject is { } __value6 && inferenceObject != null)
            {
                return inferenceObject(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<float>>? vectorInputVariant1 = null,

            global::System.Action<global::Qdrant.SparseVector>? sparse = null,

            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? vectorInputVariant3 = null,

            global::System.Action<global::Qdrant.ExtendedPointId?>? extendedPointId = null,

            global::System.Action<global::Qdrant.Document>? document = null,

            global::System.Action<global::Qdrant.Image>? image = null,

            global::System.Action<global::Qdrant.InferenceObject>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VectorInputVariant1 is { } __value0)
            {
                vectorInputVariant1?.Invoke(__value0);
            }
            else if (Sparse is { } __value1)
            {
                sparse?.Invoke(__value1);
            }
            else if (VectorInputVariant3 is { } __value2)
            {
                vectorInputVariant3?.Invoke(__value2);
            }
            else if (ExtendedPointId is { } __value3)
            {
                extendedPointId?.Invoke(__value3);
            }
            else if (Document is { } __value4)
            {
                document?.Invoke(__value4);
            }
            else if (Image is { } __value5)
            {
                image?.Invoke(__value5);
            }
            else if (InferenceObject is { } __value6)
            {
                inferenceObject?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<float>>? vectorInputVariant1 = null,
            global::System.Action<global::Qdrant.SparseVector>? sparse = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>? vectorInputVariant3 = null,
            global::System.Action<global::Qdrant.ExtendedPointId?>? extendedPointId = null,
            global::System.Action<global::Qdrant.Document>? document = null,
            global::System.Action<global::Qdrant.Image>? image = null,
            global::System.Action<global::Qdrant.InferenceObject>? inferenceObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VectorInputVariant1 is { } __value0)
            {
                vectorInputVariant1?.Invoke(__value0);
            }
            else if (Sparse is { } __value1)
            {
                sparse?.Invoke(__value1);
            }
            else if (VectorInputVariant3 is { } __value2)
            {
                vectorInputVariant3?.Invoke(__value2);
            }
            else if (ExtendedPointId is { } __value3)
            {
                extendedPointId?.Invoke(__value3);
            }
            else if (Document is { } __value4)
            {
                document?.Invoke(__value4);
            }
            else if (Image is { } __value5)
            {
                image?.Invoke(__value5);
            }
            else if (InferenceObject is { } __value6)
            {
                inferenceObject?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorInputVariant1,
                typeof(global::System.Collections.Generic.IList<float>),
                Sparse,
                typeof(global::Qdrant.SparseVector),
                VectorInputVariant3,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                ExtendedPointId,
                typeof(global::Qdrant.ExtendedPointId),
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
        public bool Equals(VectorInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<float>?>.Default.Equals(VectorInputVariant1, other.VectorInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SparseVector?>.Default.Equals(Sparse, other.Sparse) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(VectorInputVariant3, other.VectorInputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ExtendedPointId?>.Default.Equals(ExtendedPointId, other.ExtendedPointId) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Document?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.Image?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.InferenceObject?>.Default.Equals(InferenceObject, other.InferenceObject)
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
