#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Payload type with parameters
    /// </summary>
    public readonly partial struct PayloadSchemaParams : global::System.IEquatable<PayloadSchemaParams>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.KeywordIndexParams? KeywordIndex { get; init; }
#else
        public global::Qdrant.KeywordIndexParams? KeywordIndex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeywordIndex))]
#endif
        public bool IsKeywordIndex => KeywordIndex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKeywordIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.KeywordIndexParams? value)
        {
            value = KeywordIndex;
            return IsKeywordIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.KeywordIndexParams PickKeywordIndex() => KeywordIndex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KeywordIndex' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.IntegerIndexParams? IntegerIndex { get; init; }
#else
        public global::Qdrant.IntegerIndexParams? IntegerIndex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IntegerIndex))]
#endif
        public bool IsIntegerIndex => IntegerIndex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIntegerIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.IntegerIndexParams? value)
        {
            value = IntegerIndex;
            return IsIntegerIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.IntegerIndexParams PickIntegerIndex() => IntegerIndex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IntegerIndex' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.FloatIndexParams? FloatIndex { get; init; }
#else
        public global::Qdrant.FloatIndexParams? FloatIndex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FloatIndex))]
#endif
        public bool IsFloatIndex => FloatIndex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFloatIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.FloatIndexParams? value)
        {
            value = FloatIndex;
            return IsFloatIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.FloatIndexParams PickFloatIndex() => FloatIndex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FloatIndex' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.GeoIndexParams? GeoIndex { get; init; }
#else
        public global::Qdrant.GeoIndexParams? GeoIndex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeoIndex))]
#endif
        public bool IsGeoIndex => GeoIndex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGeoIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.GeoIndexParams? value)
        {
            value = GeoIndex;
            return IsGeoIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.GeoIndexParams PickGeoIndex() => GeoIndex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeoIndex' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.TextIndexParams? TextIndex { get; init; }
#else
        public global::Qdrant.TextIndexParams? TextIndex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextIndex))]
#endif
        public bool IsTextIndex => TextIndex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.TextIndexParams? value)
        {
            value = TextIndex;
            return IsTextIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.TextIndexParams PickTextIndex() => TextIndex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextIndex' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.BoolIndexParams? BoolIndex { get; init; }
#else
        public global::Qdrant.BoolIndexParams? BoolIndex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BoolIndex))]
#endif
        public bool IsBoolIndex => BoolIndex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBoolIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.BoolIndexParams? value)
        {
            value = BoolIndex;
            return IsBoolIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.BoolIndexParams PickBoolIndex() => BoolIndex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BoolIndex' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.DatetimeIndexParams? DatetimeIndex { get; init; }
#else
        public global::Qdrant.DatetimeIndexParams? DatetimeIndex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatetimeIndex))]
#endif
        public bool IsDatetimeIndex => DatetimeIndex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDatetimeIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.DatetimeIndexParams? value)
        {
            value = DatetimeIndex;
            return IsDatetimeIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.DatetimeIndexParams PickDatetimeIndex() => DatetimeIndex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DatetimeIndex' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.UuidIndexParams? UuidIndex { get; init; }
#else
        public global::Qdrant.UuidIndexParams? UuidIndex { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UuidIndex))]
#endif
        public bool IsUuidIndex => UuidIndex != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUuidIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Qdrant.UuidIndexParams? value)
        {
            value = UuidIndex;
            return IsUuidIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Qdrant.UuidIndexParams PickUuidIndex() => UuidIndex is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UuidIndex' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::Qdrant.KeywordIndexParams value) => new PayloadSchemaParams((global::Qdrant.KeywordIndexParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.KeywordIndexParams?(PayloadSchemaParams @this) => @this.KeywordIndex;

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(global::Qdrant.KeywordIndexParams? value)
        {
            KeywordIndex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PayloadSchemaParams FromKeywordIndex(global::Qdrant.KeywordIndexParams? value) => new PayloadSchemaParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::Qdrant.IntegerIndexParams value) => new PayloadSchemaParams((global::Qdrant.IntegerIndexParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.IntegerIndexParams?(PayloadSchemaParams @this) => @this.IntegerIndex;

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(global::Qdrant.IntegerIndexParams? value)
        {
            IntegerIndex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PayloadSchemaParams FromIntegerIndex(global::Qdrant.IntegerIndexParams? value) => new PayloadSchemaParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::Qdrant.FloatIndexParams value) => new PayloadSchemaParams((global::Qdrant.FloatIndexParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.FloatIndexParams?(PayloadSchemaParams @this) => @this.FloatIndex;

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(global::Qdrant.FloatIndexParams? value)
        {
            FloatIndex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PayloadSchemaParams FromFloatIndex(global::Qdrant.FloatIndexParams? value) => new PayloadSchemaParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::Qdrant.GeoIndexParams value) => new PayloadSchemaParams((global::Qdrant.GeoIndexParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.GeoIndexParams?(PayloadSchemaParams @this) => @this.GeoIndex;

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(global::Qdrant.GeoIndexParams? value)
        {
            GeoIndex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PayloadSchemaParams FromGeoIndex(global::Qdrant.GeoIndexParams? value) => new PayloadSchemaParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::Qdrant.TextIndexParams value) => new PayloadSchemaParams((global::Qdrant.TextIndexParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.TextIndexParams?(PayloadSchemaParams @this) => @this.TextIndex;

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(global::Qdrant.TextIndexParams? value)
        {
            TextIndex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PayloadSchemaParams FromTextIndex(global::Qdrant.TextIndexParams? value) => new PayloadSchemaParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::Qdrant.BoolIndexParams value) => new PayloadSchemaParams((global::Qdrant.BoolIndexParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.BoolIndexParams?(PayloadSchemaParams @this) => @this.BoolIndex;

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(global::Qdrant.BoolIndexParams? value)
        {
            BoolIndex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PayloadSchemaParams FromBoolIndex(global::Qdrant.BoolIndexParams? value) => new PayloadSchemaParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::Qdrant.DatetimeIndexParams value) => new PayloadSchemaParams((global::Qdrant.DatetimeIndexParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.DatetimeIndexParams?(PayloadSchemaParams @this) => @this.DatetimeIndex;

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(global::Qdrant.DatetimeIndexParams? value)
        {
            DatetimeIndex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PayloadSchemaParams FromDatetimeIndex(global::Qdrant.DatetimeIndexParams? value) => new PayloadSchemaParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PayloadSchemaParams(global::Qdrant.UuidIndexParams value) => new PayloadSchemaParams((global::Qdrant.UuidIndexParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Qdrant.UuidIndexParams?(PayloadSchemaParams @this) => @this.UuidIndex;

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(global::Qdrant.UuidIndexParams? value)
        {
            UuidIndex = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PayloadSchemaParams FromUuidIndex(global::Qdrant.UuidIndexParams? value) => new PayloadSchemaParams(value);

        /// <summary>
        ///
        /// </summary>
        public PayloadSchemaParams(
            global::Qdrant.KeywordIndexParams? keywordIndex,
            global::Qdrant.IntegerIndexParams? integerIndex,
            global::Qdrant.FloatIndexParams? floatIndex,
            global::Qdrant.GeoIndexParams? geoIndex,
            global::Qdrant.TextIndexParams? textIndex,
            global::Qdrant.BoolIndexParams? boolIndex,
            global::Qdrant.DatetimeIndexParams? datetimeIndex,
            global::Qdrant.UuidIndexParams? uuidIndex
            )
        {
            KeywordIndex = keywordIndex;
            IntegerIndex = integerIndex;
            FloatIndex = floatIndex;
            GeoIndex = geoIndex;
            TextIndex = textIndex;
            BoolIndex = boolIndex;
            DatetimeIndex = datetimeIndex;
            UuidIndex = uuidIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UuidIndex as object ??
            DatetimeIndex as object ??
            BoolIndex as object ??
            TextIndex as object ??
            GeoIndex as object ??
            FloatIndex as object ??
            IntegerIndex as object ??
            KeywordIndex as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            KeywordIndex?.ToString() ??
            IntegerIndex?.ToString() ??
            FloatIndex?.ToString() ??
            GeoIndex?.ToString() ??
            TextIndex?.ToString() ??
            BoolIndex?.ToString() ??
            DatetimeIndex?.ToString() ??
            UuidIndex?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsKeywordIndex || IsIntegerIndex || IsFloatIndex || IsGeoIndex || IsTextIndex || IsBoolIndex || IsDatetimeIndex || IsUuidIndex;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.KeywordIndexParams, TResult>? keywordIndex = null,
            global::System.Func<global::Qdrant.IntegerIndexParams, TResult>? integerIndex = null,
            global::System.Func<global::Qdrant.FloatIndexParams, TResult>? floatIndex = null,
            global::System.Func<global::Qdrant.GeoIndexParams, TResult>? geoIndex = null,
            global::System.Func<global::Qdrant.TextIndexParams, TResult>? textIndex = null,
            global::System.Func<global::Qdrant.BoolIndexParams, TResult>? boolIndex = null,
            global::System.Func<global::Qdrant.DatetimeIndexParams, TResult>? datetimeIndex = null,
            global::System.Func<global::Qdrant.UuidIndexParams, TResult>? uuidIndex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (KeywordIndex is { } __value0 && keywordIndex != null)
            {
                return keywordIndex(__value0);
            }
            else if (IntegerIndex is { } __value1 && integerIndex != null)
            {
                return integerIndex(__value1);
            }
            else if (FloatIndex is { } __value2 && floatIndex != null)
            {
                return floatIndex(__value2);
            }
            else if (GeoIndex is { } __value3 && geoIndex != null)
            {
                return geoIndex(__value3);
            }
            else if (TextIndex is { } __value4 && textIndex != null)
            {
                return textIndex(__value4);
            }
            else if (BoolIndex is { } __value5 && boolIndex != null)
            {
                return boolIndex(__value5);
            }
            else if (DatetimeIndex is { } __value6 && datetimeIndex != null)
            {
                return datetimeIndex(__value6);
            }
            else if (UuidIndex is { } __value7 && uuidIndex != null)
            {
                return uuidIndex(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.KeywordIndexParams>? keywordIndex = null,

            global::System.Action<global::Qdrant.IntegerIndexParams>? integerIndex = null,

            global::System.Action<global::Qdrant.FloatIndexParams>? floatIndex = null,

            global::System.Action<global::Qdrant.GeoIndexParams>? geoIndex = null,

            global::System.Action<global::Qdrant.TextIndexParams>? textIndex = null,

            global::System.Action<global::Qdrant.BoolIndexParams>? boolIndex = null,

            global::System.Action<global::Qdrant.DatetimeIndexParams>? datetimeIndex = null,

            global::System.Action<global::Qdrant.UuidIndexParams>? uuidIndex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (KeywordIndex is { } __value0)
            {
                keywordIndex?.Invoke(__value0);
            }
            else if (IntegerIndex is { } __value1)
            {
                integerIndex?.Invoke(__value1);
            }
            else if (FloatIndex is { } __value2)
            {
                floatIndex?.Invoke(__value2);
            }
            else if (GeoIndex is { } __value3)
            {
                geoIndex?.Invoke(__value3);
            }
            else if (TextIndex is { } __value4)
            {
                textIndex?.Invoke(__value4);
            }
            else if (BoolIndex is { } __value5)
            {
                boolIndex?.Invoke(__value5);
            }
            else if (DatetimeIndex is { } __value6)
            {
                datetimeIndex?.Invoke(__value6);
            }
            else if (UuidIndex is { } __value7)
            {
                uuidIndex?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Qdrant.KeywordIndexParams>? keywordIndex = null,
            global::System.Action<global::Qdrant.IntegerIndexParams>? integerIndex = null,
            global::System.Action<global::Qdrant.FloatIndexParams>? floatIndex = null,
            global::System.Action<global::Qdrant.GeoIndexParams>? geoIndex = null,
            global::System.Action<global::Qdrant.TextIndexParams>? textIndex = null,
            global::System.Action<global::Qdrant.BoolIndexParams>? boolIndex = null,
            global::System.Action<global::Qdrant.DatetimeIndexParams>? datetimeIndex = null,
            global::System.Action<global::Qdrant.UuidIndexParams>? uuidIndex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (KeywordIndex is { } __value0)
            {
                keywordIndex?.Invoke(__value0);
            }
            else if (IntegerIndex is { } __value1)
            {
                integerIndex?.Invoke(__value1);
            }
            else if (FloatIndex is { } __value2)
            {
                floatIndex?.Invoke(__value2);
            }
            else if (GeoIndex is { } __value3)
            {
                geoIndex?.Invoke(__value3);
            }
            else if (TextIndex is { } __value4)
            {
                textIndex?.Invoke(__value4);
            }
            else if (BoolIndex is { } __value5)
            {
                boolIndex?.Invoke(__value5);
            }
            else if (DatetimeIndex is { } __value6)
            {
                datetimeIndex?.Invoke(__value6);
            }
            else if (UuidIndex is { } __value7)
            {
                uuidIndex?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                KeywordIndex,
                typeof(global::Qdrant.KeywordIndexParams),
                IntegerIndex,
                typeof(global::Qdrant.IntegerIndexParams),
                FloatIndex,
                typeof(global::Qdrant.FloatIndexParams),
                GeoIndex,
                typeof(global::Qdrant.GeoIndexParams),
                TextIndex,
                typeof(global::Qdrant.TextIndexParams),
                BoolIndex,
                typeof(global::Qdrant.BoolIndexParams),
                DatetimeIndex,
                typeof(global::Qdrant.DatetimeIndexParams),
                UuidIndex,
                typeof(global::Qdrant.UuidIndexParams),
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
        public bool Equals(PayloadSchemaParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.KeywordIndexParams?>.Default.Equals(KeywordIndex, other.KeywordIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.IntegerIndexParams?>.Default.Equals(IntegerIndex, other.IntegerIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.FloatIndexParams?>.Default.Equals(FloatIndex, other.FloatIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.GeoIndexParams?>.Default.Equals(GeoIndex, other.GeoIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.TextIndexParams?>.Default.Equals(TextIndex, other.TextIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.BoolIndexParams?>.Default.Equals(BoolIndex, other.BoolIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.DatetimeIndexParams?>.Default.Equals(DatetimeIndex, other.DatetimeIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.UuidIndexParams?>.Default.Equals(UuidIndex, other.UuidIndex)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PayloadSchemaParams obj1, PayloadSchemaParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PayloadSchemaParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PayloadSchemaParams obj1, PayloadSchemaParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PayloadSchemaParams o && Equals(o);
        }
    }
}
