#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Controls how segments are loaded on startup to reduce memory pressure.<br/>
    /// Configured via `storage.low_memory_mode` in the configuration file.<br/>
    /// This setting only affects *loading* — it never modifies the persisted configuration of any segment. The same data directory will behave differently depending on how this mode is set at startup, which makes it safe to toggle for recovery from out-of-memory crash loops.
    /// </summary>
    public readonly partial struct LowMemoryMode : global::System.IEquatable<LowMemoryMode>
    {
        /// <summary>
        /// No special handling. Every component loads as persisted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.LowMemoryModeVariant1? LowMemoryModeVariant1 { get; init; }
#else
        public global::Qdrant.LowMemoryModeVariant1? LowMemoryModeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LowMemoryModeVariant1))]
#endif
        public bool IsLowMemoryModeVariant1 => LowMemoryModeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLowMemoryModeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.LowMemoryModeVariant1? value)
        {
            value = LowMemoryModeVariant1;
            return IsLowMemoryModeVariant1;
        }

        /// <summary>
        /// Load RAM-friendly components as their on-disk variants where possible:<br/>
        /// * Quantization is loaded as if `always_ram = false`. * Payload field indexes are loaded as if `on_disk = true`. * Payload storage is loaded as the mmap variant (lazy populate).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.LowMemoryModeVariant2? LowMemoryModeVariant2 { get; init; }
#else
        public global::Qdrant.LowMemoryModeVariant2? LowMemoryModeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LowMemoryModeVariant2))]
#endif
        public bool IsLowMemoryModeVariant2 => LowMemoryModeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLowMemoryModeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.LowMemoryModeVariant2? value)
        {
            value = LowMemoryModeVariant2;
            return IsLowMemoryModeVariant2;
        }

        /// <summary>
        /// Same as [`LowMemoryMode::NoResident`], plus mmap page population is skipped on load (for original vectors, HNSW graph and payload storage).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.LowMemoryModeVariant3? LowMemoryModeVariant3 { get; init; }
#else
        public global::Qdrant.LowMemoryModeVariant3? LowMemoryModeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LowMemoryModeVariant3))]
#endif
        public bool IsLowMemoryModeVariant3 => LowMemoryModeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLowMemoryModeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.LowMemoryModeVariant3? value)
        {
            value = LowMemoryModeVariant3;
            return IsLowMemoryModeVariant3;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LowMemoryMode(global::Qdrant.LowMemoryModeVariant1 value) => new LowMemoryMode((global::Qdrant.LowMemoryModeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.LowMemoryModeVariant1?(LowMemoryMode @this) => @this.LowMemoryModeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public LowMemoryMode(global::Qdrant.LowMemoryModeVariant1? value)
        {
            LowMemoryModeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LowMemoryMode(global::Qdrant.LowMemoryModeVariant2 value) => new LowMemoryMode((global::Qdrant.LowMemoryModeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.LowMemoryModeVariant2?(LowMemoryMode @this) => @this.LowMemoryModeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LowMemoryMode(global::Qdrant.LowMemoryModeVariant2? value)
        {
            LowMemoryModeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LowMemoryMode(global::Qdrant.LowMemoryModeVariant3 value) => new LowMemoryMode((global::Qdrant.LowMemoryModeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.LowMemoryModeVariant3?(LowMemoryMode @this) => @this.LowMemoryModeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public LowMemoryMode(global::Qdrant.LowMemoryModeVariant3? value)
        {
            LowMemoryModeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LowMemoryMode(
            global::Qdrant.LowMemoryModeVariant1? lowMemoryModeVariant1,
            global::Qdrant.LowMemoryModeVariant2? lowMemoryModeVariant2,
            global::Qdrant.LowMemoryModeVariant3? lowMemoryModeVariant3
            )
        {
            LowMemoryModeVariant1 = lowMemoryModeVariant1;
            LowMemoryModeVariant2 = lowMemoryModeVariant2;
            LowMemoryModeVariant3 = lowMemoryModeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LowMemoryModeVariant3 as object ??
            LowMemoryModeVariant2 as object ??
            LowMemoryModeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LowMemoryModeVariant1?.ToValueString() ??
            LowMemoryModeVariant2?.ToValueString() ??
            LowMemoryModeVariant3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLowMemoryModeVariant1 && !IsLowMemoryModeVariant2 && !IsLowMemoryModeVariant3 || !IsLowMemoryModeVariant1 && IsLowMemoryModeVariant2 && !IsLowMemoryModeVariant3 || !IsLowMemoryModeVariant1 && !IsLowMemoryModeVariant2 && IsLowMemoryModeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.LowMemoryModeVariant1?, TResult>? lowMemoryModeVariant1 = null,
            global::System.Func<global::Qdrant.LowMemoryModeVariant2?, TResult>? lowMemoryModeVariant2 = null,
            global::System.Func<global::Qdrant.LowMemoryModeVariant3?, TResult>? lowMemoryModeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLowMemoryModeVariant1 && lowMemoryModeVariant1 != null)
            {
                return lowMemoryModeVariant1(LowMemoryModeVariant1!);
            }
            else if (IsLowMemoryModeVariant2 && lowMemoryModeVariant2 != null)
            {
                return lowMemoryModeVariant2(LowMemoryModeVariant2!);
            }
            else if (IsLowMemoryModeVariant3 && lowMemoryModeVariant3 != null)
            {
                return lowMemoryModeVariant3(LowMemoryModeVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.LowMemoryModeVariant1?>? lowMemoryModeVariant1 = null,

            global::System.Action<global::Qdrant.LowMemoryModeVariant2?>? lowMemoryModeVariant2 = null,

            global::System.Action<global::Qdrant.LowMemoryModeVariant3?>? lowMemoryModeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLowMemoryModeVariant1)
            {
                lowMemoryModeVariant1?.Invoke(LowMemoryModeVariant1!);
            }
            else if (IsLowMemoryModeVariant2)
            {
                lowMemoryModeVariant2?.Invoke(LowMemoryModeVariant2!);
            }
            else if (IsLowMemoryModeVariant3)
            {
                lowMemoryModeVariant3?.Invoke(LowMemoryModeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.LowMemoryModeVariant1?>? lowMemoryModeVariant1 = null,
            global::System.Action<global::Qdrant.LowMemoryModeVariant2?>? lowMemoryModeVariant2 = null,
            global::System.Action<global::Qdrant.LowMemoryModeVariant3?>? lowMemoryModeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLowMemoryModeVariant1)
            {
                lowMemoryModeVariant1?.Invoke(LowMemoryModeVariant1!);
            }
            else if (IsLowMemoryModeVariant2)
            {
                lowMemoryModeVariant2?.Invoke(LowMemoryModeVariant2!);
            }
            else if (IsLowMemoryModeVariant3)
            {
                lowMemoryModeVariant3?.Invoke(LowMemoryModeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LowMemoryModeVariant1,
                typeof(global::Qdrant.LowMemoryModeVariant1),
                LowMemoryModeVariant2,
                typeof(global::Qdrant.LowMemoryModeVariant2),
                LowMemoryModeVariant3,
                typeof(global::Qdrant.LowMemoryModeVariant3),
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
        public bool Equals(LowMemoryMode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.LowMemoryModeVariant1?>.Default.Equals(LowMemoryModeVariant1, other.LowMemoryModeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.LowMemoryModeVariant2?>.Default.Equals(LowMemoryModeVariant2, other.LowMemoryModeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.LowMemoryModeVariant3?>.Default.Equals(LowMemoryModeVariant3, other.LowMemoryModeVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LowMemoryMode obj1, LowMemoryMode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LowMemoryMode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LowMemoryMode obj1, LowMemoryMode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LowMemoryMode o && Equals(o);
        }
    }
}
