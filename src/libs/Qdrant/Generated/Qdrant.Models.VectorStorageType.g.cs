#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Storage types for vectors
    /// </summary>
    public readonly partial struct VectorStorageType : global::System.IEquatable<VectorStorageType>
    {
        /// <summary>
        /// Storage in memory (RAM)<br/>
        /// Will be very fast at the cost of consuming a lot of memory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.VectorStorageTypeVariant1? VectorStorageTypeVariant1 { get; init; }
#else
        public global::Qdrant.VectorStorageTypeVariant1? VectorStorageTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant1))]
#endif
        public bool IsVectorStorageTypeVariant1 => VectorStorageTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorStorageTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.VectorStorageTypeVariant1? value)
        {
            value = VectorStorageTypeVariant1;
            return IsVectorStorageTypeVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant1 PickVectorStorageTypeVariant1() => IsVectorStorageTypeVariant1
            ? VectorStorageTypeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorStorageTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Storage in mmap file, not appendable<br/>
        /// Search performance is defined by disk speed and the fraction of vectors that fit in memory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.VectorStorageTypeVariant2? VectorStorageTypeVariant2 { get; init; }
#else
        public global::Qdrant.VectorStorageTypeVariant2? VectorStorageTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant2))]
#endif
        public bool IsVectorStorageTypeVariant2 => VectorStorageTypeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorStorageTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.VectorStorageTypeVariant2? value)
        {
            value = VectorStorageTypeVariant2;
            return IsVectorStorageTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant2 PickVectorStorageTypeVariant2() => IsVectorStorageTypeVariant2
            ? VectorStorageTypeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorStorageTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        /// Storage in chunked mmap files, appendable<br/>
        /// Search performance is defined by disk speed and the fraction of vectors that fit in memory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.VectorStorageTypeVariant3? VectorStorageTypeVariant3 { get; init; }
#else
        public global::Qdrant.VectorStorageTypeVariant3? VectorStorageTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant3))]
#endif
        public bool IsVectorStorageTypeVariant3 => VectorStorageTypeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorStorageTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.VectorStorageTypeVariant3? value)
        {
            value = VectorStorageTypeVariant3;
            return IsVectorStorageTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant3 PickVectorStorageTypeVariant3() => IsVectorStorageTypeVariant3
            ? VectorStorageTypeVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorStorageTypeVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Same as `ChunkedMmap`, but vectors are forced to be locked in RAM In this way we avoid cold requests to disk, but risk to run out of memory<br/>
        /// Designed as a replacement for `Memory`, which doesn't depend on RocksDB
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.VectorStorageTypeVariant4? VectorStorageTypeVariant4 { get; init; }
#else
        public global::Qdrant.VectorStorageTypeVariant4? VectorStorageTypeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant4))]
#endif
        public bool IsVectorStorageTypeVariant4 => VectorStorageTypeVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorStorageTypeVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.VectorStorageTypeVariant4? value)
        {
            value = VectorStorageTypeVariant4;
            return IsVectorStorageTypeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant4 PickVectorStorageTypeVariant4() => IsVectorStorageTypeVariant4
            ? VectorStorageTypeVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorStorageTypeVariant4' but the value was {ToString()}.");

        /// <summary>
        /// Storage in a single mmap file, not appendable Pre-fetched into RAM on load
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.VectorStorageTypeVariant5? VectorStorageTypeVariant5 { get; init; }
#else
        public global::Qdrant.VectorStorageTypeVariant5? VectorStorageTypeVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant5))]
#endif
        public bool IsVectorStorageTypeVariant5 => VectorStorageTypeVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorStorageTypeVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.VectorStorageTypeVariant5? value)
        {
            value = VectorStorageTypeVariant5;
            return IsVectorStorageTypeVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant5 PickVectorStorageTypeVariant5() => IsVectorStorageTypeVariant5
            ? VectorStorageTypeVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorStorageTypeVariant5' but the value was {ToString()}.");

        /// <summary>
        /// Placeholder storage: contains no data, all vectors reported as deleted. Used for newly created named vectors on immutable segments. No files on disk, reconstructed from config on load.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.VectorStorageTypeVariant6? VectorStorageTypeVariant6 { get; init; }
#else
        public global::Qdrant.VectorStorageTypeVariant6? VectorStorageTypeVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant6))]
#endif
        public bool IsVectorStorageTypeVariant6 => VectorStorageTypeVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorStorageTypeVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.VectorStorageTypeVariant6? value)
        {
            value = VectorStorageTypeVariant6;
            return IsVectorStorageTypeVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Qdrant.VectorStorageTypeVariant6 PickVectorStorageTypeVariant6() => IsVectorStorageTypeVariant6
            ? VectorStorageTypeVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorStorageTypeVariant6' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::Qdrant.VectorStorageTypeVariant1 value) => new VectorStorageType((global::Qdrant.VectorStorageTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.VectorStorageTypeVariant1?(VectorStorageType @this) => @this.VectorStorageTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::Qdrant.VectorStorageTypeVariant1? value)
        {
            VectorStorageTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorStorageType FromVectorStorageTypeVariant1(global::Qdrant.VectorStorageTypeVariant1? value) => new VectorStorageType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::Qdrant.VectorStorageTypeVariant2 value) => new VectorStorageType((global::Qdrant.VectorStorageTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.VectorStorageTypeVariant2?(VectorStorageType @this) => @this.VectorStorageTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::Qdrant.VectorStorageTypeVariant2? value)
        {
            VectorStorageTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorStorageType FromVectorStorageTypeVariant2(global::Qdrant.VectorStorageTypeVariant2? value) => new VectorStorageType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::Qdrant.VectorStorageTypeVariant3 value) => new VectorStorageType((global::Qdrant.VectorStorageTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.VectorStorageTypeVariant3?(VectorStorageType @this) => @this.VectorStorageTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::Qdrant.VectorStorageTypeVariant3? value)
        {
            VectorStorageTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorStorageType FromVectorStorageTypeVariant3(global::Qdrant.VectorStorageTypeVariant3? value) => new VectorStorageType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::Qdrant.VectorStorageTypeVariant4 value) => new VectorStorageType((global::Qdrant.VectorStorageTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.VectorStorageTypeVariant4?(VectorStorageType @this) => @this.VectorStorageTypeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::Qdrant.VectorStorageTypeVariant4? value)
        {
            VectorStorageTypeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorStorageType FromVectorStorageTypeVariant4(global::Qdrant.VectorStorageTypeVariant4? value) => new VectorStorageType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::Qdrant.VectorStorageTypeVariant5 value) => new VectorStorageType((global::Qdrant.VectorStorageTypeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.VectorStorageTypeVariant5?(VectorStorageType @this) => @this.VectorStorageTypeVariant5;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::Qdrant.VectorStorageTypeVariant5? value)
        {
            VectorStorageTypeVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorStorageType FromVectorStorageTypeVariant5(global::Qdrant.VectorStorageTypeVariant5? value) => new VectorStorageType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::Qdrant.VectorStorageTypeVariant6 value) => new VectorStorageType((global::Qdrant.VectorStorageTypeVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.VectorStorageTypeVariant6?(VectorStorageType @this) => @this.VectorStorageTypeVariant6;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::Qdrant.VectorStorageTypeVariant6? value)
        {
            VectorStorageTypeVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorStorageType FromVectorStorageTypeVariant6(global::Qdrant.VectorStorageTypeVariant6? value) => new VectorStorageType(value);

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(
            global::Qdrant.VectorStorageTypeVariant1? vectorStorageTypeVariant1,
            global::Qdrant.VectorStorageTypeVariant2? vectorStorageTypeVariant2,
            global::Qdrant.VectorStorageTypeVariant3? vectorStorageTypeVariant3,
            global::Qdrant.VectorStorageTypeVariant4? vectorStorageTypeVariant4,
            global::Qdrant.VectorStorageTypeVariant5? vectorStorageTypeVariant5,
            global::Qdrant.VectorStorageTypeVariant6? vectorStorageTypeVariant6
            )
        {
            VectorStorageTypeVariant1 = vectorStorageTypeVariant1;
            VectorStorageTypeVariant2 = vectorStorageTypeVariant2;
            VectorStorageTypeVariant3 = vectorStorageTypeVariant3;
            VectorStorageTypeVariant4 = vectorStorageTypeVariant4;
            VectorStorageTypeVariant5 = vectorStorageTypeVariant5;
            VectorStorageTypeVariant6 = vectorStorageTypeVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorStorageTypeVariant6 as object ??
            VectorStorageTypeVariant5 as object ??
            VectorStorageTypeVariant4 as object ??
            VectorStorageTypeVariant3 as object ??
            VectorStorageTypeVariant2 as object ??
            VectorStorageTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorStorageTypeVariant1?.ToValueString() ??
            VectorStorageTypeVariant2?.ToValueString() ??
            VectorStorageTypeVariant3?.ToValueString() ??
            VectorStorageTypeVariant4?.ToValueString() ??
            VectorStorageTypeVariant5?.ToValueString() ??
            VectorStorageTypeVariant6?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 && !IsVectorStorageTypeVariant6 || !IsVectorStorageTypeVariant1 && IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 && !IsVectorStorageTypeVariant6 || !IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 && !IsVectorStorageTypeVariant6 || !IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 && !IsVectorStorageTypeVariant6 || !IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && IsVectorStorageTypeVariant5 && !IsVectorStorageTypeVariant6 || !IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 && IsVectorStorageTypeVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.VectorStorageTypeVariant1?, TResult>? vectorStorageTypeVariant1 = null,
            global::System.Func<global::Qdrant.VectorStorageTypeVariant2?, TResult>? vectorStorageTypeVariant2 = null,
            global::System.Func<global::Qdrant.VectorStorageTypeVariant3?, TResult>? vectorStorageTypeVariant3 = null,
            global::System.Func<global::Qdrant.VectorStorageTypeVariant4?, TResult>? vectorStorageTypeVariant4 = null,
            global::System.Func<global::Qdrant.VectorStorageTypeVariant5?, TResult>? vectorStorageTypeVariant5 = null,
            global::System.Func<global::Qdrant.VectorStorageTypeVariant6?, TResult>? vectorStorageTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStorageTypeVariant1 && vectorStorageTypeVariant1 != null)
            {
                return vectorStorageTypeVariant1(VectorStorageTypeVariant1!);
            }
            else if (IsVectorStorageTypeVariant2 && vectorStorageTypeVariant2 != null)
            {
                return vectorStorageTypeVariant2(VectorStorageTypeVariant2!);
            }
            else if (IsVectorStorageTypeVariant3 && vectorStorageTypeVariant3 != null)
            {
                return vectorStorageTypeVariant3(VectorStorageTypeVariant3!);
            }
            else if (IsVectorStorageTypeVariant4 && vectorStorageTypeVariant4 != null)
            {
                return vectorStorageTypeVariant4(VectorStorageTypeVariant4!);
            }
            else if (IsVectorStorageTypeVariant5 && vectorStorageTypeVariant5 != null)
            {
                return vectorStorageTypeVariant5(VectorStorageTypeVariant5!);
            }
            else if (IsVectorStorageTypeVariant6 && vectorStorageTypeVariant6 != null)
            {
                return vectorStorageTypeVariant6(VectorStorageTypeVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.VectorStorageTypeVariant1?>? vectorStorageTypeVariant1 = null,

            global::System.Action<global::Qdrant.VectorStorageTypeVariant2?>? vectorStorageTypeVariant2 = null,

            global::System.Action<global::Qdrant.VectorStorageTypeVariant3?>? vectorStorageTypeVariant3 = null,

            global::System.Action<global::Qdrant.VectorStorageTypeVariant4?>? vectorStorageTypeVariant4 = null,

            global::System.Action<global::Qdrant.VectorStorageTypeVariant5?>? vectorStorageTypeVariant5 = null,

            global::System.Action<global::Qdrant.VectorStorageTypeVariant6?>? vectorStorageTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStorageTypeVariant1)
            {
                vectorStorageTypeVariant1?.Invoke(VectorStorageTypeVariant1!);
            }
            else if (IsVectorStorageTypeVariant2)
            {
                vectorStorageTypeVariant2?.Invoke(VectorStorageTypeVariant2!);
            }
            else if (IsVectorStorageTypeVariant3)
            {
                vectorStorageTypeVariant3?.Invoke(VectorStorageTypeVariant3!);
            }
            else if (IsVectorStorageTypeVariant4)
            {
                vectorStorageTypeVariant4?.Invoke(VectorStorageTypeVariant4!);
            }
            else if (IsVectorStorageTypeVariant5)
            {
                vectorStorageTypeVariant5?.Invoke(VectorStorageTypeVariant5!);
            }
            else if (IsVectorStorageTypeVariant6)
            {
                vectorStorageTypeVariant6?.Invoke(VectorStorageTypeVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.VectorStorageTypeVariant1?>? vectorStorageTypeVariant1 = null,
            global::System.Action<global::Qdrant.VectorStorageTypeVariant2?>? vectorStorageTypeVariant2 = null,
            global::System.Action<global::Qdrant.VectorStorageTypeVariant3?>? vectorStorageTypeVariant3 = null,
            global::System.Action<global::Qdrant.VectorStorageTypeVariant4?>? vectorStorageTypeVariant4 = null,
            global::System.Action<global::Qdrant.VectorStorageTypeVariant5?>? vectorStorageTypeVariant5 = null,
            global::System.Action<global::Qdrant.VectorStorageTypeVariant6?>? vectorStorageTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStorageTypeVariant1)
            {
                vectorStorageTypeVariant1?.Invoke(VectorStorageTypeVariant1!);
            }
            else if (IsVectorStorageTypeVariant2)
            {
                vectorStorageTypeVariant2?.Invoke(VectorStorageTypeVariant2!);
            }
            else if (IsVectorStorageTypeVariant3)
            {
                vectorStorageTypeVariant3?.Invoke(VectorStorageTypeVariant3!);
            }
            else if (IsVectorStorageTypeVariant4)
            {
                vectorStorageTypeVariant4?.Invoke(VectorStorageTypeVariant4!);
            }
            else if (IsVectorStorageTypeVariant5)
            {
                vectorStorageTypeVariant5?.Invoke(VectorStorageTypeVariant5!);
            }
            else if (IsVectorStorageTypeVariant6)
            {
                vectorStorageTypeVariant6?.Invoke(VectorStorageTypeVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorStorageTypeVariant1,
                typeof(global::Qdrant.VectorStorageTypeVariant1),
                VectorStorageTypeVariant2,
                typeof(global::Qdrant.VectorStorageTypeVariant2),
                VectorStorageTypeVariant3,
                typeof(global::Qdrant.VectorStorageTypeVariant3),
                VectorStorageTypeVariant4,
                typeof(global::Qdrant.VectorStorageTypeVariant4),
                VectorStorageTypeVariant5,
                typeof(global::Qdrant.VectorStorageTypeVariant5),
                VectorStorageTypeVariant6,
                typeof(global::Qdrant.VectorStorageTypeVariant6),
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
        public bool Equals(VectorStorageType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.VectorStorageTypeVariant1?>.Default.Equals(VectorStorageTypeVariant1, other.VectorStorageTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.VectorStorageTypeVariant2?>.Default.Equals(VectorStorageTypeVariant2, other.VectorStorageTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.VectorStorageTypeVariant3?>.Default.Equals(VectorStorageTypeVariant3, other.VectorStorageTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.VectorStorageTypeVariant4?>.Default.Equals(VectorStorageTypeVariant4, other.VectorStorageTypeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.VectorStorageTypeVariant5?>.Default.Equals(VectorStorageTypeVariant5, other.VectorStorageTypeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.VectorStorageTypeVariant6?>.Default.Equals(VectorStorageTypeVariant6, other.VectorStorageTypeVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorStorageType obj1, VectorStorageType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorStorageType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorStorageType obj1, VectorStorageType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorStorageType o && Equals(o);
        }
    }
}
