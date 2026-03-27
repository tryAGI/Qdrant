#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PayloadFieldSchema : global::System.IEquatable<PayloadFieldSchema>
    {
        /// <summary>
        /// All possible names of payload types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.PayloadSchemaType? Type { get; init; }
#else
        public global::Qdrant.PayloadSchemaType? Type { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Type))]
#endif
        public bool IsType => Type != null;

        /// <summary>
        /// Payload type with parameters
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Qdrant.PayloadSchemaParams? Params { get; init; }
#else
        public global::Qdrant.PayloadSchemaParams? Params { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Params))]
#endif
        public bool IsParams => Params != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadFieldSchema(global::Qdrant.PayloadSchemaType value) => new PayloadFieldSchema((global::Qdrant.PayloadSchemaType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.PayloadSchemaType?(PayloadFieldSchema @this) => @this.Type;

        /// <summary>
        /// 
        /// </summary>
        public PayloadFieldSchema(global::Qdrant.PayloadSchemaType? value)
        {
            Type = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadFieldSchema(global::Qdrant.PayloadSchemaParams value) => new PayloadFieldSchema((global::Qdrant.PayloadSchemaParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Qdrant.PayloadSchemaParams?(PayloadFieldSchema @this) => @this.Params;

        /// <summary>
        /// 
        /// </summary>
        public PayloadFieldSchema(global::Qdrant.PayloadSchemaParams? value)
        {
            Params = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PayloadFieldSchema(
            global::Qdrant.PayloadSchemaType? type,
            global::Qdrant.PayloadSchemaParams? @params
            )
        {
            Type = type;
            Params = @params;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Params as object ??
            Type as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Type?.ToValueString() ??
            Params?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsType || IsParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Qdrant.PayloadSchemaType?, TResult>? type = null,
            global::System.Func<global::Qdrant.PayloadSchemaParams?, TResult>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsType && type != null)
            {
                return type(Type!);
            }
            else if (IsParams && @params != null)
            {
                return @params(Params!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Qdrant.PayloadSchemaType?>? type = null,
            global::System.Action<global::Qdrant.PayloadSchemaParams?>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsType)
            {
                type?.Invoke(Type!);
            }
            else if (IsParams)
            {
                @params?.Invoke(Params!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Type,
                typeof(global::Qdrant.PayloadSchemaType),
                Params,
                typeof(global::Qdrant.PayloadSchemaParams),
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
        public bool Equals(PayloadFieldSchema other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.PayloadSchemaType?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::Qdrant.PayloadSchemaParams?>.Default.Equals(Params, other.Params) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PayloadFieldSchema obj1, PayloadFieldSchema obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PayloadFieldSchema>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PayloadFieldSchema obj1, PayloadFieldSchema obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PayloadFieldSchema o && Equals(o);
        }
    }
}
