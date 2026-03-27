#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateOperation : global::System.IEquatable<UpdateOperation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.UpsertOperation? Upsert { get; init; }
#else
        public global::Qdrant.UpsertOperation? Upsert { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Upsert))]
#endif
        public bool IsUpsert => Upsert != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DeleteOperation? Delete { get; init; }
#else
        public global::Qdrant.DeleteOperation? Delete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Delete))]
#endif
        public bool IsDelete => Delete != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.SetPayloadOperation? SetPayload { get; init; }
#else
        public global::Qdrant.SetPayloadOperation? SetPayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SetPayload))]
#endif
        public bool IsSetPayload => SetPayload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.OverwritePayloadOperation? OverwritePayload { get; init; }
#else
        public global::Qdrant.OverwritePayloadOperation? OverwritePayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OverwritePayload))]
#endif
        public bool IsOverwritePayload => OverwritePayload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DeletePayloadOperation? DeletePayload { get; init; }
#else
        public global::Qdrant.DeletePayloadOperation? DeletePayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeletePayload))]
#endif
        public bool IsDeletePayload => DeletePayload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.ClearPayloadOperation? ClearPayload { get; init; }
#else
        public global::Qdrant.ClearPayloadOperation? ClearPayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClearPayload))]
#endif
        public bool IsClearPayload => ClearPayload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.UpdateVectorsOperation? Vectors { get; init; }
#else
        public global::Qdrant.UpdateVectorsOperation? Vectors { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vectors))]
#endif
        public bool IsVectors => Vectors != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DeleteVectorsOperation? DeleteVectors { get; init; }
#else
        public global::Qdrant.DeleteVectorsOperation? DeleteVectors { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteVectors))]
#endif
        public bool IsDeleteVectors => DeleteVectors != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::Qdrant.UpsertOperation value) => new UpdateOperation((global::Qdrant.UpsertOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.UpsertOperation?(UpdateOperation @this) => @this.Upsert;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::Qdrant.UpsertOperation? value)
        {
            Upsert = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::Qdrant.DeleteOperation value) => new UpdateOperation((global::Qdrant.DeleteOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DeleteOperation?(UpdateOperation @this) => @this.Delete;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::Qdrant.DeleteOperation? value)
        {
            Delete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::Qdrant.SetPayloadOperation value) => new UpdateOperation((global::Qdrant.SetPayloadOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.SetPayloadOperation?(UpdateOperation @this) => @this.SetPayload;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::Qdrant.SetPayloadOperation? value)
        {
            SetPayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::Qdrant.OverwritePayloadOperation value) => new UpdateOperation((global::Qdrant.OverwritePayloadOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.OverwritePayloadOperation?(UpdateOperation @this) => @this.OverwritePayload;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::Qdrant.OverwritePayloadOperation? value)
        {
            OverwritePayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::Qdrant.DeletePayloadOperation value) => new UpdateOperation((global::Qdrant.DeletePayloadOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DeletePayloadOperation?(UpdateOperation @this) => @this.DeletePayload;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::Qdrant.DeletePayloadOperation? value)
        {
            DeletePayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::Qdrant.ClearPayloadOperation value) => new UpdateOperation((global::Qdrant.ClearPayloadOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.ClearPayloadOperation?(UpdateOperation @this) => @this.ClearPayload;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::Qdrant.ClearPayloadOperation? value)
        {
            ClearPayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::Qdrant.UpdateVectorsOperation value) => new UpdateOperation((global::Qdrant.UpdateVectorsOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.UpdateVectorsOperation?(UpdateOperation @this) => @this.Vectors;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::Qdrant.UpdateVectorsOperation? value)
        {
            Vectors = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateOperation(global::Qdrant.DeleteVectorsOperation value) => new UpdateOperation((global::Qdrant.DeleteVectorsOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.DeleteVectorsOperation?(UpdateOperation @this) => @this.DeleteVectors;

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(global::Qdrant.DeleteVectorsOperation? value)
        {
            DeleteVectors = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateOperation(
            global::Qdrant.UpsertOperation? upsert,
            global::Qdrant.DeleteOperation? delete,
            global::Qdrant.SetPayloadOperation? setPayload,
            global::Qdrant.OverwritePayloadOperation? overwritePayload,
            global::Qdrant.DeletePayloadOperation? deletePayload,
            global::Qdrant.ClearPayloadOperation? clearPayload,
            global::Qdrant.UpdateVectorsOperation? vectors,
            global::Qdrant.DeleteVectorsOperation? deleteVectors
            )
        {
            Upsert = upsert;
            Delete = delete;
            SetPayload = setPayload;
            OverwritePayload = overwritePayload;
            DeletePayload = deletePayload;
            ClearPayload = clearPayload;
            Vectors = vectors;
            DeleteVectors = deleteVectors;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeleteVectors as object ??
            Vectors as object ??
            ClearPayload as object ??
            DeletePayload as object ??
            OverwritePayload as object ??
            SetPayload as object ??
            Delete as object ??
            Upsert as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Upsert?.ToString() ??
            Delete?.ToString() ??
            SetPayload?.ToString() ??
            OverwritePayload?.ToString() ??
            DeletePayload?.ToString() ??
            ClearPayload?.ToString() ??
            Vectors?.ToString() ??
            DeleteVectors?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUpsert || IsDelete || IsSetPayload || IsOverwritePayload || IsDeletePayload || IsClearPayload || IsVectors || IsDeleteVectors;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.UpsertOperation?, TResult>? upsert = null,
            global::System.Func<global::Qdrant.DeleteOperation?, TResult>? delete = null,
            global::System.Func<global::Qdrant.SetPayloadOperation?, TResult>? setPayload = null,
            global::System.Func<global::Qdrant.OverwritePayloadOperation?, TResult>? overwritePayload = null,
            global::System.Func<global::Qdrant.DeletePayloadOperation?, TResult>? deletePayload = null,
            global::System.Func<global::Qdrant.ClearPayloadOperation?, TResult>? clearPayload = null,
            global::System.Func<global::Qdrant.UpdateVectorsOperation?, TResult>? vectors = null,
            global::System.Func<global::Qdrant.DeleteVectorsOperation?, TResult>? deleteVectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpsert && upsert != null)
            {
                return upsert(Upsert!);
            }
            else if (IsDelete && delete != null)
            {
                return delete(Delete!);
            }
            else if (IsSetPayload && setPayload != null)
            {
                return setPayload(SetPayload!);
            }
            else if (IsOverwritePayload && overwritePayload != null)
            {
                return overwritePayload(OverwritePayload!);
            }
            else if (IsDeletePayload && deletePayload != null)
            {
                return deletePayload(DeletePayload!);
            }
            else if (IsClearPayload && clearPayload != null)
            {
                return clearPayload(ClearPayload!);
            }
            else if (IsVectors && vectors != null)
            {
                return vectors(Vectors!);
            }
            else if (IsDeleteVectors && deleteVectors != null)
            {
                return deleteVectors(DeleteVectors!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.UpsertOperation?>? upsert = null,
            global::System.Action<global::Qdrant.DeleteOperation?>? delete = null,
            global::System.Action<global::Qdrant.SetPayloadOperation?>? setPayload = null,
            global::System.Action<global::Qdrant.OverwritePayloadOperation?>? overwritePayload = null,
            global::System.Action<global::Qdrant.DeletePayloadOperation?>? deletePayload = null,
            global::System.Action<global::Qdrant.ClearPayloadOperation?>? clearPayload = null,
            global::System.Action<global::Qdrant.UpdateVectorsOperation?>? vectors = null,
            global::System.Action<global::Qdrant.DeleteVectorsOperation?>? deleteVectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpsert)
            {
                upsert?.Invoke(Upsert!);
            }
            else if (IsDelete)
            {
                delete?.Invoke(Delete!);
            }
            else if (IsSetPayload)
            {
                setPayload?.Invoke(SetPayload!);
            }
            else if (IsOverwritePayload)
            {
                overwritePayload?.Invoke(OverwritePayload!);
            }
            else if (IsDeletePayload)
            {
                deletePayload?.Invoke(DeletePayload!);
            }
            else if (IsClearPayload)
            {
                clearPayload?.Invoke(ClearPayload!);
            }
            else if (IsVectors)
            {
                vectors?.Invoke(Vectors!);
            }
            else if (IsDeleteVectors)
            {
                deleteVectors?.Invoke(DeleteVectors!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Upsert,
                typeof(global::Qdrant.UpsertOperation),
                Delete,
                typeof(global::Qdrant.DeleteOperation),
                SetPayload,
                typeof(global::Qdrant.SetPayloadOperation),
                OverwritePayload,
                typeof(global::Qdrant.OverwritePayloadOperation),
                DeletePayload,
                typeof(global::Qdrant.DeletePayloadOperation),
                ClearPayload,
                typeof(global::Qdrant.ClearPayloadOperation),
                Vectors,
                typeof(global::Qdrant.UpdateVectorsOperation),
                DeleteVectors,
                typeof(global::Qdrant.DeleteVectorsOperation),
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
        public bool Equals(UpdateOperation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.UpsertOperation?>.Default.Equals(Upsert, other.Upsert) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DeleteOperation?>.Default.Equals(Delete, other.Delete) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.SetPayloadOperation?>.Default.Equals(SetPayload, other.SetPayload) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.OverwritePayloadOperation?>.Default.Equals(OverwritePayload, other.OverwritePayload) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DeletePayloadOperation?>.Default.Equals(DeletePayload, other.DeletePayload) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.ClearPayloadOperation?>.Default.Equals(ClearPayload, other.ClearPayload) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.UpdateVectorsOperation?>.Default.Equals(Vectors, other.Vectors) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DeleteVectorsOperation?>.Default.Equals(DeleteVectors, other.DeleteVectors) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateOperation obj1, UpdateOperation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateOperation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateOperation obj1, UpdateOperation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateOperation o && Equals(o);
        }
    }
}
