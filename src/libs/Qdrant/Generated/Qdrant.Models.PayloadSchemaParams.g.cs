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
            global::System.Func<global::Qdrant.KeywordIndexParams?, TResult>? keywordIndex = null,
            global::System.Func<global::Qdrant.IntegerIndexParams?, TResult>? integerIndex = null,
            global::System.Func<global::Qdrant.FloatIndexParams?, TResult>? floatIndex = null,
            global::System.Func<global::Qdrant.GeoIndexParams?, TResult>? geoIndex = null,
            global::System.Func<global::Qdrant.TextIndexParams?, TResult>? textIndex = null,
            global::System.Func<global::Qdrant.BoolIndexParams?, TResult>? boolIndex = null,
            global::System.Func<global::Qdrant.DatetimeIndexParams?, TResult>? datetimeIndex = null,
            global::System.Func<global::Qdrant.UuidIndexParams?, TResult>? uuidIndex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeywordIndex && keywordIndex != null)
            {
                return keywordIndex(KeywordIndex!);
            }
            else if (IsIntegerIndex && integerIndex != null)
            {
                return integerIndex(IntegerIndex!);
            }
            else if (IsFloatIndex && floatIndex != null)
            {
                return floatIndex(FloatIndex!);
            }
            else if (IsGeoIndex && geoIndex != null)
            {
                return geoIndex(GeoIndex!);
            }
            else if (IsTextIndex && textIndex != null)
            {
                return textIndex(TextIndex!);
            }
            else if (IsBoolIndex && boolIndex != null)
            {
                return boolIndex(BoolIndex!);
            }
            else if (IsDatetimeIndex && datetimeIndex != null)
            {
                return datetimeIndex(DatetimeIndex!);
            }
            else if (IsUuidIndex && uuidIndex != null)
            {
                return uuidIndex(UuidIndex!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.KeywordIndexParams?>? keywordIndex = null,
            global::System.Action<global::Qdrant.IntegerIndexParams?>? integerIndex = null,
            global::System.Action<global::Qdrant.FloatIndexParams?>? floatIndex = null,
            global::System.Action<global::Qdrant.GeoIndexParams?>? geoIndex = null,
            global::System.Action<global::Qdrant.TextIndexParams?>? textIndex = null,
            global::System.Action<global::Qdrant.BoolIndexParams?>? boolIndex = null,
            global::System.Action<global::Qdrant.DatetimeIndexParams?>? datetimeIndex = null,
            global::System.Action<global::Qdrant.UuidIndexParams?>? uuidIndex = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeywordIndex)
            {
                keywordIndex?.Invoke(KeywordIndex!);
            }
            else if (IsIntegerIndex)
            {
                integerIndex?.Invoke(IntegerIndex!);
            }
            else if (IsFloatIndex)
            {
                floatIndex?.Invoke(FloatIndex!);
            }
            else if (IsGeoIndex)
            {
                geoIndex?.Invoke(GeoIndex!);
            }
            else if (IsTextIndex)
            {
                textIndex?.Invoke(TextIndex!);
            }
            else if (IsBoolIndex)
            {
                boolIndex?.Invoke(BoolIndex!);
            }
            else if (IsDatetimeIndex)
            {
                datetimeIndex?.Invoke(DatetimeIndex!);
            }
            else if (IsUuidIndex)
            {
                uuidIndex?.Invoke(UuidIndex!);
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
